using System;
using System.Net.Mail;

namespace WindowsForms
{
    public class Student
    {
        private string _firstname;

        public string Firstname
        {
            get => _firstname;
            set
            {
                if (value.Trim().Length > 2)
                {
                    _firstname = value;
                }
                else
                {
                    throw new ArgumentException("Firstname cant be less than 2 char!");
                }
            }
        }

        private string _lastname;

        public string Lastname
        {
            get => _lastname;
            set
            {
                if (value.Trim().Length > 2)
                {
                    _lastname = value;
                }
                else
                {
                    throw new ArgumentException("Lastname cant be less than 2 char!");
                }
            }
        }

        public string Fullname => Firstname + " " + Lastname;

        private string _email;

        public string Email
        {
            get => _email;
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
        }
        public override string ToString()
        {
            return $"{Fullname} {Email}";
        }
    }
}



