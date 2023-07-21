using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Membership 
    {
        private readonly IWelcomeEmailSender _emmailSender;
        public Membership(IWelcomeEmailSender emailSender)
        {
            _emmailSender= emailSender;
        }
        public void Signup(string email,string password)
        {
            CreateUser(email, password);
            _emmailSender.SendWelcomeEmail(email);
        }

        private void CreateUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
