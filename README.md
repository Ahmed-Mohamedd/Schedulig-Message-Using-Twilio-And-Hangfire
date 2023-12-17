

# Scheduling Messages with Twilio and Hangfire


# Overview
This repository demonstrates a simple implementation of scheduling messages using Twilio and Hangfire in a .NET application. 
Twilio is a cloud communications platform that allows developers to send messages programmatically,
and Hangfire is a .NET library for background processing.

This project showcases how to leverage Hangfire to schedule the sending of messages through Twilio,
enabling you to automate the process of sending messages at specified times.

# Prerequisites
Before getting started, make sure you have the following installed:

- .NET Core SDK
- Twilio account and credentials (Account SID, Auth Token)
- Hangfire NuGet package

# Getting Started
1. Clone this repository to your local machine.
(git clone (https://github.com/Ahmed-Mohamedd/Schedulig-Message-Using-Twilio-And-Hangfire.git))

2. Open the solution file (TestSchedulingMessageWithTwilioandHangfire.sln) in Visual Studio.
  or Navigate to the Project Directory: bash (cd Scheduling Messages with Twilio and Hangfire)

3. Configure Twilio Credentials:
Update the appsettings.json file with your Twilio Account SID and Auth Token.

{
  "Twilio": {
    "AccountSid": "YOUR_TWILIO_ACCOUNT_SID",
    "AuthToken": "YOUR_TWILIO_AUTH_TOKEN",
    "FromPhoneNumber": "YOUR_TWILIO_PHONE_NUMBER"
  }
}
Replace the values with your own Twilio account SID, auth token, and phone number.

4. Build and Run:
    Build and run the application using the following commands:
      dotnet build
      dotnet run

Open your web browser and navigate to http://localhost:5000.

Enter the message details and schedule the message.

Built With
.NET Core
Twilio
Hangfire
Authors
Your Name
