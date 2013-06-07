SmsUsb
======

A C# application for sending SMS messages from a USB connected Android device.

When the C# applications creates a SMS it pushes a file to a specific folder on the Android device. 
The device has an application that listens to the spesific folder, parses the file and sends the SMS.

When the phone recieves a SMS an Android application creates a file and stores it in a spesific folder on the phone. 
When triggered the C# application will pull all new files for a spesific folder, parse the file and display the new messages.
