using Microsoft.Extensions.Options;
using TestSchedulingMessageWithTwilioandHangfire.Utilities;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TestSchedulingMessageWithTwilioandHangfire.Services
{
    public class WhatsAppService : IWhatsAppService
    {
        private readonly TwilioSetting _twilio;
        public WhatsAppService(IOptions<TwilioSetting> setting)
        {
            _twilio=setting.Value;
        }

        public async Task<MessageResource> SendAsync(string MobileNumber, string Body)
        {
            TwilioClient.Init(_twilio.AccountSid, _twilio.AuthToken);
            var result = await MessageResource.CreateAsync(
                from: new Twilio.Types.PhoneNumber($"whatsapp:{_twilio.TwilioPhoneNumber}"),
                body: Body,
                to: new Twilio.Types.PhoneNumber($"whatsapp:{MobileNumber}"));
                
            return result;
        }
       
    }
}
