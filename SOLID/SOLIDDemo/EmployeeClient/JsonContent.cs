using EmployeeClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClient
{
    public class JsonContent : IContent
    {
        public string Content()
        {
            Console.WriteLine("JSON content");
            return "JSON";
        }
    }
}
