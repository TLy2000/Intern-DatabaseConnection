using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DatabaseConnection
{
    public class SQLCmd
    {
        public static void DatabaseAccess()
        {
            string prompt;
            do
            {
                Person person = new Person();
                prompt = "";
                person = (new Person { UserID = GetID(), FirstName = Helper.GetFirstName(), LastName = Helper.GetLastName() });
                Console.WriteLine(person.UserID + person.FirstName + person.LastName);
                WriteToDatabase(person);
                Console.WriteLine("Do you want to add a name? Y/N ");
                prompt = Console.ReadLine();
            } while (prompt != "n" && prompt != "N");
            ReadDatabase();
            return;
        }
        private static void ReadDatabase()
        {
            string table = "[dbo].[Table]";
            SqlConnection conn = new SqlConnection(Helper.CnnVal("dboPeopledb"));
            conn.Open();
            SqlCommand cmdRd = new SqlCommand("SELECT FirstName, LastName FROM " + table, conn);
            SqlDataReader reader = cmdRd.ExecuteReader();
            Console.WriteLine("Last name, First name");
            while (reader.Read())
            {
                Console.WriteLine("{1}, {0}", reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
            conn.Close();
        }
        private static void WriteToDatabase(Person person)
        {
            string table = "[dbo].[Table]";
            SqlConnection conn = new SqlConnection(Helper.CnnVal("dboPeopledb"));
            conn.Open();
            SqlCommand insertComm = new SqlCommand("INSERT INTO " + table + "(UserID, FirstName, LastName) VALUES (@0, @1, @2)", conn);
            insertComm.Parameters.Add(new SqlParameter("0", person.UserID));
            insertComm.Parameters.Add(new SqlParameter("1", person.FirstName));
            insertComm.Parameters.Add(new SqlParameter("2", person.LastName));
            insertComm.ExecuteNonQuery();
            conn.Close();
            return;
        }
        private static int GetID()
        {
            string table = "[dbo].[Table]";
            SqlConnection conn = new SqlConnection(Helper.CnnVal("dboPeopledb"));
            Int32 id = 0;
            string sql = "SELECT COUNT(*) UserID FROM" + table;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                id = (Int32)cmd.ExecuteScalar();
                id++;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            conn.Close();
            return id;
        }
    }
}
