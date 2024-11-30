using Gym_Management_system;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Eventing.Reader;

namespace Gym_Management_system.Database
{
    public class Helper
    {
        private static string path = @"C:\Users\Farah\source\repos\Gym-Management-system\Gym Management system\Database\Gym.db";
        public string ConnectionString = @$"Data Source={path}; Version=3;";


        public struct Result
        {
            public SQLiteDataReader ReaderData;
            public string msg;

            public Result(SQLiteDataReader readerData, string msg)
            {
                this.ReaderData = readerData;
                this.msg = msg;
            }
        }







        public void QueryReader(string query, Action<Result> processResults)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    SQLiteCommand cmd = connection.CreateCommand();

                    cmd.CommandText = query;
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    Result r = new (reader, "Saved");
                    processResults(r);
                }
            }
            
            catch (Exception err)
            {
                string msg = err.Message;
                //Console.WriteLine(msg);
                Result r = new Result(null, "Error::" + msg);
                processResults(r);

            }
            
        }



        public void QueryWriter(string query, Action<Result> processResults)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        Result r = new Result(null, "Saved");
                        processResults(r);
                    } ;
                    
                    connection.Close();
                }
                
            }
            catch (Exception err)
            {

                string msg = err.Message;
                Result r = new Result(null, "Error::" + msg);
                processResults(r);
                
            }
            
        }
    }
}

