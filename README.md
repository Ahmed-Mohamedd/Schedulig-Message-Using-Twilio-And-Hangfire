

# Scheduling Messages with Twilio and Hangfire


#Overview
This repository demonstrates a simple implementation of scheduling messages using Twilio and Hangfire in a .NET application. 
Twilio is a cloud communications platform that allows developers to send messages programmatically,
and Hangfire is a .NET library for background processing.

This project showcases how to leverage Hangfire to schedule the sending of messages through Twilio, enabling you to automate the process of sending messages at specified times.

Prerequisites
Before getting started, make sure you have the following installed:

.NET Core SDK
Twilio account and credentials (Account SID, Auth Token)
Hangfire NuGet package
This repository contains a sample application that demonstrates how to schedule messages using Twilio and Hangfire.

Prerequisites
To run this application, you need to have the following installed on your machine:

.NET Core SDK
Visual Studio Code or any other code editor of your choice
Getting Started
Clone this repository to your local machine.

Open the solution file SchedulingMessages.sln in Visual Studio Code.

In the terminal, navigate to the project directory and run the following command to install the required packages:

dotnet restore

Create a new file named appsettings.json in the root directory of the project and add the following code:

JSON
AI-generated code. Review and use carefully. More info on FAQ.

{
  "Twilio": {
    "AccountSid": "YOUR_TWILIO_ACCOUNT_SID",
    "AuthToken": "YOUR_TWILIO_AUTH_TOKEN",
    "FromPhoneNumber": "YOUR_TWILIO_PHONE_NUMBER"
  }
}
Replace the values with your own Twilio account SID, auth token, and phone number.

Run the following command to start the application:

dotnet run

Open your web browser and navigate to http://localhost:5000.

Enter the message details and schedule the message.

Built With
.NET Core
Twilio
Hangfire
Authors
Your Name
