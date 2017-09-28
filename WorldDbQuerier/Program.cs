using System;
using MySql.Data.MySqlClient;
namespace WorldDbQuerier
{
    class Program
    {

        static string version = "0.1";

        static void Main(string[] args)
        {
            if (args.Length > 0)
                switch (args[0])
                {
                    case "-v":
                        Console.WriteLine("v" + version);
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }
            MySqlConnection comm = new MySqlConnection();


            comm.ConnectionString = "Server = 192.168.56.101;Port = 3306; Database = Concertzalen1;Uid = root;Pwd = imma; ";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = comm;
            cmd.CommandText = "SELECT count(*) FROM tblConcertzalen";

            comm.Open();


            Console.WriteLine("Aantal concertzalen {0}", cmd.ExecuteScalar());

        }
    }
}
