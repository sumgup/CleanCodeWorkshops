using System;
using EmployeeClient;
using EmployeeClient.Interfaces;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailClient();
           
            IContent htmlContent = new HtmlContent();
            IContent jsonContent = new JsonContent();
            IContent xmlContent = new XmlContent();
            
            Console.WriteLine(email.GetContent(htmlContent));
            Console.WriteLine(email.GetContent(jsonContent));
            Console.WriteLine(email.GetContent(xmlContent));

            Console.Read();
      
        }
    }
}