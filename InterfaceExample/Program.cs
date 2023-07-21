// See https://aka.ms/new-console-template for more information

using InterfaceExample;

IWelcomeEmailSender emailSender = new TextEmailSender();

Membership membership = new Membership(emailSender);
membership.Signup("abc@gmail.com", "1234");


