using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Abstraction
{
    public class EmailService {
        public void SendEmail() {
            Connect();
            Authenticate();
            System.Console.WriteLine("Sending email...");
            Disconnect();
        } 

        private void Connect() {
            System.Console.WriteLine("Connecting...");
        }

        private void Authenticate() {
            System.Console.WriteLine("Authenticating...");
        }

        private void Disconnect() {
            System.Console.WriteLine("Disconnecting...");
        }
    }
}