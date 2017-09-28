﻿using System;
using MySql.Data.MySqlClient;
namespace WorldDbQuerier
{
    class Program
    {

        static string version = "0.2";

        static void Main(string[] args)
        {
            if (args.Length > 0)
                switch (args[0])
                {
                    case "-v":
                        Console.WriteLine("v" + version);
                        break;
                    case "aantal":
                        AantalLanden();
                        break;
                    case "lijst":
                        LijstLanden();
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }                
           
        }
        public static void AantalLanden()
        {
            MySqlConnection comm = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            comm.ConnectionString = "Server = 192.168.56.101;Port = 3306; Database = world;Uid = root;Pwd = imma; ";
            cmd.Connection = comm;
            comm.Open();
            cmd.CommandText = "SELECT count(*) FROM Country";
            Console.WriteLine("Aantal landen {0}", cmd.ExecuteScalar());
        }
        public static void LijstLanden()
        {
            MySqlConnection comm = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            comm.ConnectionString = "Server = 192.168.56.101;Port = 3306; Database = world;Uid = root;Pwd = imma; ";
            cmd.Connection = comm;
            comm.Open();
            cmd.CommandText = "SELECT * FROM Country";
            cmd.ExecuteReader();
            }
        }



}
