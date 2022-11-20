using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace Insertoperation
{
    class CurdOperations
    {
        public static void Main()
        {
            string connectionstring= "Data source=.;Database=gayathri;integrated security='True'";
            using(SqlConnection con=new SqlConnection(connectionstring))
            {
                con.Open();
                Console.WriteLine("Enter stid: ");
                int stid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter stname: ");
                String stname = Console.ReadLine();
                Console.WriteLine("Enter stgroup :");
                String stgroup = Console.ReadLine();

                string insertQuery = "insert into student(stid,stname,stgroup)values(" + stid + ",'" + stname + "','" + stgroup + "')";
                SqlCommand insertcommand = new SqlCommand(insertQuery, con);
                insertcommand.ExecuteNonQuery();
                Console.WriteLine("Data inserted");
                con.Close();
            }
            Console.ReadLine();
            Console.ReadKey();        
        }
    }
}

