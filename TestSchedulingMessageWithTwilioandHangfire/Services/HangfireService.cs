using Hangfire;
using Microsoft.Extensions.Options;
using TestSchedulingMessageWithTwilioandHangfire.Utilities;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML.Messaging;

namespace TestSchedulingMessageWithTwilioandHangfire.Services
{
    public class HangfireService : IHangfireService
    {
        private readonly IWhatsAppService _whatsAppService;
        public HangfireService( IWhatsAppService whatsAppService)
        {

            
            _whatsAppService=whatsAppService;
        }
        public void ScheduleMessage(string MobileNumber , string Body , DateTime appointment)
        {
            Console.WriteLine(DateTime.Now);
            BackgroundJob.Schedule( () => _whatsAppService.SendAsync(MobileNumber, Body).GetAwaiter(), appointment);
        }
    }
}
