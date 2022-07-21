using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July19
{
    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException()
        {
            //Console.WriteLine("Password length should be greater than 5");
        }
        public InvalidPasswordException(string msg) : base(msg)
        {

        }
    }

    class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string msg) : base(msg)
        {

        }
    }

    internal class CustomException
    {
        string username;
        string password;

        public string Username
        {
            get { return username; }    
            set { 
                if(value != "User")
                {
                    throw new InvalidUsernameException("Username is wrong");
                }
                    this.username = value; }
        }
        public string Password
        {
            get { return password; }
            set 
            { 
                if(value.Length <= 5)
                {
                    throw new InvalidPasswordException("Password length should be greater than 5");
                }
                else
                    this.password = value; 
            }
        }

        

        static void Main(string[] args)
        {
            CustomException ce = new CustomException();
            try
            {
                ce.Username = "User1";
            }
            catch(InvalidUsernameException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                ce.Password = "abcd";
            }
            catch(InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");
        }
    }
}
