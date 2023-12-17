namespace TestSchedulingMessageWithTwilioandHangfire.Services
{
    public interface IHangfireService
    {
        void ScheduleMessage(string MobileNumber, string Body , DateTime appointment);
    }
}
