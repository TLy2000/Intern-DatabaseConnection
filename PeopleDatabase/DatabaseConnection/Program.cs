/*  Author
 *  Thinh Ly
 *  Console app to take user input and connect to a database
 */


using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLCmd.DatabaseAccess();
            Console.ReadKey();
        }
    }
}
