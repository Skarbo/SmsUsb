using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SmsUsb
{
    public partial class Form1 : Form
    {
        public static int CONFIG_DEVICE_USB = 0;
        public static int CONFIG_DEVICE_EMULATOR = 1;
        public static int CONFIG_DEVICE_SELECTED = 2;
        public static string MESSAGE_SPLITTER = ":";

        public int configDevice = CONFIG_DEVICE_USB;
        public string configDeviceSelected = "";
        public string adbPath = "";
        public string sendFilePath = "mnt/sdcard/Test/send.txt";
        public string recieveFilePath = "mnt/sdcard/Test/recieve.txt";

        public Form1()
        {
            InitializeComponent();
            sendPathTextBox.Text = sendFilePath;
            recievePathTextBox.Text = recieveFilePath;
        }

        private string run2(object command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;

            Process process = Process.Start(processStartInfo);
            process.EnableRaisingEvents = true;

            if (process != null)
            {
                process.StandardInput.WriteLine(command);
                //process.StandardInput.WriteLine("yourCommand.exe arg1 arg2");

                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                string outputString = process.StandardOutput.ReadToEnd();
                return outputString;
            }

            return string.Empty;
        }

        private string run3(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = true;
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string resultSuccess = proc.StandardOutput.ReadToEnd();
                string resultError = proc.StandardError.ReadToEnd();
                // Display the command output.
                //Debug.WriteLine("Test: " + result);
                //Console.WriteLine(result);
                return resultSuccess;
            }
            catch (Exception objException)
            {
                // Log the exception
                Debug.WriteLine(objException);
            }
            return "";
        }

        private string run(object command)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = (adbPath != "" ? adbPath.Replace("\\", "/") + "/adb.exe" : "cmd.exe");
                process.StartInfo.Arguments = "/c " + command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                StringBuilder output = new StringBuilder();
                StringBuilder error = new StringBuilder();

                using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                {
                    process.OutputDataReceived += (sender, e) =>
                    {
                        if (e.Data == null)
                        {
                            outputWaitHandle.Set();
                        }
                        else
                        {
                            output.AppendLine(e.Data);
                        }
                    };
                    process.ErrorDataReceived += (sender, e) =>
                    {
                        if (e.Data == null)
                        {
                            errorWaitHandle.Set();
                        }
                        else
                        {
                            error.AppendLine(e.Data);
                        }
                    };

                    process.Start();

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    int timeout = 100;
                    if (process.WaitForExit(timeout) &&
                        outputWaitHandle.WaitOne(timeout) &&
                        errorWaitHandle.WaitOne(timeout))
                    {
                        // Process completed. Check process.ExitCode here.
                        return process.ExitCode == 0 ? output.ToString() : error.ToString();
                    }
                    else
                    {
                        // Timed out.
                        return "";
                    }
                }
            }
        }

        /**
         * Run ADB commands
         */
        private string adb(object command)
        {
            string deviceOption = "";
            // Direct an adb command to the only attached USB device.
            if (configDevice == CONFIG_DEVICE_USB)
                deviceOption = "-d";
            // Direct an adb command to the only running emulator instance.
            else if (configDevice == CONFIG_DEVICE_EMULATOR)
                deviceOption = "-e";
            // Direct an adb command a specific emulator/device instance,
            else if (configDevice == CONFIG_DEVICE_SELECTED)
                deviceOption = "-s " + configDeviceSelected;
            string runCommand = "adb " + deviceOption + " " + command;
            Debug.WriteLine(runCommand);
            return run(runCommand);
        }

        private List<string> adbDevices()
        {
            string devicesResult = run("adb devices");
            string[] devicesResults = devicesResult.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            List<string> devices = new List<string>();
            bool listDevices = false;
            foreach (string deviceResultLine in devicesResults)
            {
                if (deviceResultLine.Trim().Equals("List of devices attached"))
                    listDevices = true;
                else if (listDevices && !deviceResultLine.Trim().Equals(""))
                    devices.Add(deviceResultLine.Substring(0, deviceResultLine.IndexOf("\t")).Trim());
            }
            return devices;
        }

        private void adbPush(string localFilePath, string remoteFilePath)
        {
            string pushResult = adb("push \"" + localFilePath + "\" \"" + remoteFilePath + "\"");
            if (pushResult.IndexOf("Android Debug Bridge") == 0)
                throw new Exception("Error push command");
            if (!pushResult.Trim().Equals(""))
                throw new Exception(pushResult);
        }

        private bool adbPull(string remoteFilePath, string localFilePath)
        {
            string pullResult = adb("pull \"" + remoteFilePath + "\" \"" + localFilePath + "\"");
            if (pullResult.IndexOf("Android Debug Bridge") == 0)
                throw new Exception("Error pull command");
            if (pullResult.Trim().Equals(""))
                return true;
            if (pullResult.IndexOf("remote object") == 0)
                return false;
            throw new Exception(pullResult);
        }

        private string createSmsSendMessage(string reciever, string message)
        {
            return reciever + MESSAGE_SPLITTER + message;
        }

        private string[] createSmsRecieveMessage(string recieveMessage)
        {
            string[] recieve = new string[3];
            int split1 = recieveMessage.IndexOf(MESSAGE_SPLITTER);
            int split2 = recieveMessage.IndexOf(MESSAGE_SPLITTER, split1+1);
            recieve[0] = recieveMessage.Substring(0, split1);
            recieve[1] = recieveMessage.Substring(split1+1, split2-(split1+1));
            recieve[2] = recieveMessage.Substring(split2+1, recieveMessage.Length-(split2+1));
            return recieve;
        }

        private void devicesButton_Click(object sender, EventArgs e)
        {
            List<string> devices = adbDevices();
            devicesListBox.Items.Clear();
            if (devices != null)
            {
                foreach (string device in devices)
                {
                    devicesListBox.Items.Add(device);
                }
                if (devices.Count != 0)
                    devicesListBox.SetSelected(0, true);
            }
        }

        private void deviceUsbRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            configDevice = CONFIG_DEVICE_USB;
        }

        private void deviceRunningRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            configDevice = CONFIG_DEVICE_EMULATOR;
        }

        private void deviceSelectedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            configDevice = CONFIG_DEVICE_SELECTED;
        }

        private void devicesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            configDeviceSelected = devicesListBox.SelectedItem.ToString();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string reciever = receiverTextBox.Text.Trim();
            string message = messageSendTextBox.Text.Trim();

            if (reciever.Equals("") || message.Equals(""))
            {
                sendMessageInfoLabel.Text = "Reciever or message is empty";
            }
            else if (sendFilePath.Equals(""))
            {
                sendMessageInfoLabel.Text = "Send file path is not given";
            }
            else
            {
                using (var tempFile = new TemporaryFile())
                {
                    // Write message to temp file
                    Debug.WriteLine("temp file:" + tempFile.FilePath);
                    TextWriter tw = new StreamWriter(tempFile.FilePath);
                    tw.Write(createSmsSendMessage(reciever, message));
                    tw.Close();

                    // Send message
                    try
                    {
                        adbPush(tempFile.FilePath, sendFilePath);
                        sendMessageInfoLabel.Text = "Message sendt!";
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine("Error: " + err.Message);
                        MessageBox.Show(err.Message, "Error send message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sendMessageInfoLabel.Text = "Error send message";
                    }
                }
            }
        }

        private void receiveMessageButton_Click(object sender, EventArgs e)
        {
            if (recieveFilePath.Equals(""))
            {
                receiveInfoLabel.Text = "Reciever file path is not given";
            }
            else
            {
                // Local file
                string localFilePath = Path.GetTempPath() + Path.GetRandomFileName();
                Debug.WriteLine("Local file path: " + localFilePath);
                // Recieve message
                try
                {
                    // Pull remote file
                    if (adbPull(recieveFilePath, localFilePath))
                    {
                        // Read pulled file
                        TextReader tr = new StreamReader(localFilePath);
                        string recieveMessage = tr.ReadToEnd();
                        tr.Close();

                        // Recieve message
                        string[] recieve = createSmsRecieveMessage(recieveMessage);
                        recieveSenderTextBox.Text = recieve[0];
                        recieveDateTextBox.Text = recieve[1];
                        recieveMessageTextBox.Text = recieve[2];

                        receiveInfoLabel.Text = "Message recieved!";
                    }
                    else
                    {
                        receiveInfoLabel.Text = "No new message";
                    }
                }
                catch (Exception err)
                {
                    Debug.WriteLine("Error: " + err.Message);
                    MessageBox.Show(err.Message, "Error recieve message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sendMessageInfoLabel.Text = "Error recieve message";
                }
            }
        }

        private void sendPathTextBox_TextChanged(object sender, EventArgs e)
        {
            sendFilePath = sendPathTextBox.Text;
        }

        private void recievePathTextBox_TextChanged(object sender, EventArgs e)
        {
            recieveFilePath = recievePathTextBox.Text;
        }

        private void adbPathTextBox_TextChanged(object sender, EventArgs e)
        {
            adbPath = adbPathTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = textBox1.Text;
            string result = run(cmd);
            textBox2.Text = result;
        }

        private void recieveSenderTextBox_TextChanged(object sender, EventArgs e)
        {
            replyButton.Enabled = !recieveSenderTextBox.Text.Equals("");
        }

        private void replyButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            receiverTextBox.Text = recieveSenderTextBox.Text;
            messageSendTextBox.Focus();
            messageSendTextBox.SelectAll();
        }

    }

    public sealed class TemporaryFile : IDisposable
    {
        public TemporaryFile() :
            this(Path.GetTempPath()) { }

        public TemporaryFile(string directory)
        {
            Create(Path.Combine(directory, Path.GetRandomFileName()));
        }

        ~TemporaryFile()
        {
            Delete();
        }

        public void Dispose()
        {
            Delete();
            GC.SuppressFinalize(this);
        }

        public string FilePath { get; private set; }

        private void Create(string path)
        {
            FilePath = path;
            using (File.Create(FilePath)) { };
        }

        private void Delete()
        {
            if (FilePath == null) return;
            File.Delete(FilePath);
            FilePath = null;
        }
    }
}
