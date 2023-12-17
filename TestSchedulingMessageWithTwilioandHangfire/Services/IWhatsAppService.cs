using Twilio.Rest.Api.V2010.Account;

namespace TestSchedulingMessageWithTwilioandHangfire.Services
{
    public interface IWhatsAppService
    {
        Task<MessageResource> SendAsync(string MobileNumber, string Body);
        
    }
}
