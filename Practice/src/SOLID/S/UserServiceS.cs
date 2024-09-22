using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.SOLID.S
{
    public class UserServiceS
    {
        // Business logic here related to a user
        public void Register(UserS user)
        {
            // Register user

            // Send email
            // Dependency relationship: UserServiceS class depends on EmailSenderS class
            EmailSenderS emailSender = new EmailSenderS();
            emailSender.SendEmail(user.Email, "Welcome to our platform!");
        }
    }
}