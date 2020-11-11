/*  Author
 *  Thinh Ly
 *  Console app to take user input and connect to a database
 */

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Person
    {
        // creates an object person
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
