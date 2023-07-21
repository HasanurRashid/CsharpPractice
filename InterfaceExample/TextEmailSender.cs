using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class TextEmailSender : IWelcomeEmailSender
    {
        public void SendEmail(string email, string subject, string body)
        {
            throw new NotImplementedException();
        }

        public void SendWelcomeEmail(string email)
        {
            SendEmail(email,"Hello","Wecloce ");
        }
    }
}
