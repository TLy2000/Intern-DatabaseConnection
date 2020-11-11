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
        // separate methods 
        public static string CnnVal(string name)
        {
            // connection string that is coded in the app.config
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        // methods to get the name information
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
