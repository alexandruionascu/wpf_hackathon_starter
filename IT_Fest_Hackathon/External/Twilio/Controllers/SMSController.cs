using IT_Fest_Hackathon.External.Twilio.Models;
using Twilio;

namespace IT_Fest_Hackathon.External.Twilio.Controllers
{
    public class SMSController
    {
        public void sendSMS(string message, string senderPhoneNumber)
        {
            var client = new TwilioRestClient(TwilioCredentials.accountSid, TwilioCredentials.authToken);

            client.SendMessage(TwilioCredentials.phoneNumber, senderPhoneNumber, message);
        }
    }
}
