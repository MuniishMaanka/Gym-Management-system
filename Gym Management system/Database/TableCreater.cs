using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics;
using System.Data.SqlClient;

//To-do List 

namespace Gym_Management_system.Database
{
    internal static class TableCreater
    {
        
        // Copy your db Path from the Solution Explorer
        private static string path = @"C:\Users\Farah\source\repos\Gym-Management-system\Gym Management system\Database\Gym.db";
        private static string ConnectionString = @$"Data Source={path};Version=3;";


        public static void Init()
        {
            bool checkExists = File.Exists(path);
            Console.WriteLine(checkExists);

            //check if file exists
            if (!checkExists)
            {
                //Create new DB File
                //SQLiteConnection.CreateFile(path);
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                
                    


                    string Schedule = @"CREATE TABLE schedule (
                        id VARCHAR(255) PRIMARY KEY,
                        plan_id VARCHAR(255),
                        customer_id VARCHAR(255),
                        time_in TIMESTAMP,
                        time_out TIMESTAMP,
                        FOREIGN KEY (plan_id) REFERENCES plans(id),
                        FOREIGN KEY (customer_id) REFERENCES customer_information(id)
                    );";
                    string Revenue = @"CREATE TABLE revenue (
                        id VARCHAR(255) PRIMARY KEY,
                        customer_id VARCHAR(255),
                        amount FLOAT,
                        date_issue DATETIME,
                        user_id VARCHAR(255),
                        FOREIGN KEY (customer_id) REFERENCES customer_information(id),
                        FOREIGN KEY (user_id) REFERENCES users(id)
                    );";
                    string Salaries = @"CREATE TABLE salaries (
                        id VARCHAR(255) PRIMARY KEY,
                        staff_id VARCHAR(255),
                        amount FLOAT,
                        date DATETIME,
                        FOREIGN KEY (staff_id) REFERENCES staff_information(id)
                    );";
                    string Staff_info = @"CREATE TABLE staff_information (
                        id VARCHAR(255) PRIMARY KEY,
                        firstname VARCHAR(100),
                        lastname VARCHAR(100),
                        dob DATETIME,
                        tell VARCHAR(25),
                        email VARCHAR(100),
                        sex VARCHAR(10),
                        city VARCHAR(20),
                        village VARCHAR(30),
                        emmergence_contact VARCHAR(30),
                        emmergency_name VARCHAR(30),
                        emergency_relation VARCHAR(30),
                        shift VARCHAR(10),
                        staff_type VARCHAR(30),
                        salary FLOAT
                    );";
                    string Customer = @"Create TABLE Customer_info(
                        id VARCHAR(255) PRIMARY KEY,
                        firstname VARCHAR(255),
                        lastname VARCHAR(255),
                        dob datetime
                        tell VARCHAR(25),
                        email VARCHAR(100),
                        sex VARCHAR(10),
                        weight FLOAT,
                        city VARCHAR(30),
                        village VARCHAR(30),
                        emmergence_contact VARCHAR(30),
                        emmergency_name VARCHAR(30),
                        emergency_relation VARCHAR(30));";

                    string Attendance = @"CREATE TABLE attendance (
                        id VARCHAR(255) PRIMARY KEY,
                        sche_id VARCHAR(255),
                        date TIMESTAMP,
                        attendanced BOOLEAN,
                        FOREIGN KEY (sche_id) REFERENCES schedule(id)
                    );";

                    string user = @"CREATE TABLE users (
                        id VARCHAR(255) PRIMARY KEY,
                        staff_id VARCHAR(255),
                        username VARCHAR(30),
                        password VARCHAR(30),
                        user_type VARCHAR(20),
                        FOREIGN KEY (staff_id) REFERENCES staff_information(id)
                    );";

                    string Plans = @"CREATE TABLE plans (
                        id VARCHAR(255) PRIMARY KEY,
                        plan_name VARCHAR(20),
                        signup_fee FLOAT,
                        price FLOAT,
                        staff_id VARCHAR(255),
                        customer_id VARCHAR(255),
                        plan_type VARCHAR(20),
                        FOREIGN KEY (staff_id) REFERENCES staff_information(id),
                        FOREIGN KEY (customer_id) REFERENCES customer_information(id)
                    );";
                    string Measurement = @"CREATE TABLE measurement (
                        id VARCHAR(255) PRIMARY KEY,
                        customer_id VARCHAR(255),
                        weight FLOAT,
                        date_issue TIMESTAMP,
                        description VARCHAR(255),
                        FOREIGN KEY (customer_id) REFERENCES customer_information(id)
                    );";

                    string[] tableQueries = { Staff_info, Customer, user, Salaries, Plans, Schedule, Measurement, Revenue, Attendance };


                    //Create Commands 
                    using (SQLiteCommand command = connection.CreateCommand())
                    {
                        foreach (var query in tableQueries)
                        {
                            command.CommandText = query;
                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close(); 
                } 
            }



        }
    }
}
