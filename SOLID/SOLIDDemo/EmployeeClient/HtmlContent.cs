using EmployeeClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClient
{
    public class HtmlContent : IContent
    {
        public string Content()
        {
            Console.WriteLine("html content");
            return "HTML";
        }
    }
}
