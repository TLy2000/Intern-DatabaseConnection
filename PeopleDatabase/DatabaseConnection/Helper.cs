/*  Author
 *  Thinh Ly
 *  Console app to take user input and connect to a database
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static string GetFirstName()
        {
            string firstName = "";
            Console.WriteLine("Enter a first name: ");
            firstName = Console.ReadLine();
            return firstName;
        }
        public static string GetLastName()
        {
            string lastName = "";
            Console.WriteLine("Enter a last name: ");
            lastName = Console.ReadLine();
            return lastName;
        }
    }
}
