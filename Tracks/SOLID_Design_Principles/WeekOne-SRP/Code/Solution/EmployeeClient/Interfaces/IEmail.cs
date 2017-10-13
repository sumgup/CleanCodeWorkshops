using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClient.Interfaces
{
    interface IEmail
    {
        void Send(string toEmailAddress);
        void Receive();
        string GetContent(IContent content);
    }
}
