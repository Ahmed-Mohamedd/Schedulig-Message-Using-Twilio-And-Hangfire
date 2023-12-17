namespace TestSchedulingMessageWithTwilioandHangfire.Services
{
    public interface IHangfireService
    {
        void EnqueuingMessage(string MobileNumber, string Body, DateTime appointment);
        void ScheduleMessage(string MobileNumber, string Body , DateTime appointment);
        void RecurringMessage(string MobileNumber, string Body , DateTime appointment);
    }
}
