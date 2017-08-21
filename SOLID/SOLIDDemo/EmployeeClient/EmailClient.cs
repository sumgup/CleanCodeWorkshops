using EmployeeClient.Interfaces;
using System;

namespace EmployeeClient
{
    // Adapted from http://www.oodesign.com/single-responsibility-principle.html
    public class EmailClient : IEmail
    {
        // Gets the content
        public string GetContent(IContent content)
        {
            Console.WriteLine(content.GetType().ToString());
            return content.Content();
        }

        public void Receive()
        {
            Console.WriteLine("Receive");
        }

        public void Send(string sender)
        {
            Console.WriteLine("Send");
        }
    }
}
