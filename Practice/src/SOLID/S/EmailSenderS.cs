using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.SOLID.S
{
    public class EmailSenderS
    {
        public void SendEmail(string email, string message)
        {
            // Send email
            System.Console.WriteLine($"Email sent to {email} with message: {message}");
        }
    }
}