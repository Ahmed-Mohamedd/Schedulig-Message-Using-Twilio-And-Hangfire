

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
      (dotnet build,
      dotnet run)

5. Access the Hangfire Dashboard:
Open your browser and navigate to http://localhost:<port>/hangfire. Here, you can view and manage scheduled jobs.

# Project Structure
- ApiController.cs:
This class contains methods for scheduling messages Which it called by HangfireService.

- HangFireService.cs:
The HangFireService class encapsulates the hangfire-related functionality, such as scheduling Message or Recurring Message.

- TwilioService.cs:
The TwilioService class encapsulates the Twilio-related functionality, such as sending SMS messages or whatsApp message.

- Program.cs:
The entry point of the application where i configure (hangfire & twilio) and allowing Dependency Injection For Both TwilioService & HangFireService.

- appsettings.json:
Configuration file containing Twilio credentials and connection string for hangfire.


# Contributing
Feel free to contribute to this project by opening issues or submitting pull requests. Your feedback and improvements are highly appreciated!

# Built With
.NET Core
Twilio
Hangfire

# Authors
Ahmed Mohamed
