using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class HTMLemailSender : IWelcomeEmailSender
    {
        public void Send(string email,string subject,string body)
        {

        }

        public void SendWelcomeEmail(string email)
        {
            Send(email,"Hello","Welcome");
        }
    }
}
