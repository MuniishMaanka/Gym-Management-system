using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics;
using System.Data.SqlClient;
using Gym_Management_system.Database;
using static Gym_Management_system.Database.Helper;
using System.Windows.Controls.Primitives;
using Gym_Management_system.Schedules;

public class SqlClass
{
    Helper helper = new Helper();
    public string ConnetionStr { get { return helper.ConnectionString; } }


    //QueryExcuter Method
    public string ExcuteQuery(string query)
    {
        string msg = "";
        helper.QueryWriter(query, r =>
        {
            msg = r.msg;
        });
        return msg;
    }


    // Get Methods
    public Dictionary<string, List<object>>? getPlansDshBdData()
    {
        string query = @"SELECT p.plan_name, p.signup_fee, p.price, p.plan_type, si.firstname, si.tell, si.shift,strftime('%H:%M',                                sch.time_in), strftime('%H:%M',sch.time_out), p.id from plans as p
                                LEFT JOIN staff_information as si on p.staff_id = si.id
                                LEFT JOIN schedule as sch on sch.plan_id = p.id";

        Dictionary<string, List<object>> Dict = new Dictionary<string, List<object>>();
        int count = 0;
        helper.QueryReader(query, r =>
        {
            if (r.ReaderData.HasRows)
            {
                while (r.ReaderData.Read())
                {
                    // Use the GetValue method and handle null values
                    string planName = r.ReaderData.IsDBNull(0) ? "NULL" : r.ReaderData.GetString(0);
                    float signupFee = r.ReaderData.IsDBNull(1) ? 0 : r.ReaderData.GetFloat(1);
                    float price = r.ReaderData.IsDBNull(2) ? 0 : r.ReaderData.GetFloat(2);
                    string planType = r.ReaderData.IsDBNull(3) ? "NULL" : r.ReaderData.GetString(3);
                    string firstname = r.ReaderData.IsDBNull(4) ? "NULL" : r.ReaderData.GetString(4);
                    string tell = r.ReaderData.IsDBNull(5) ? "NULL" : r.ReaderData.GetString(5);
                    string shift = r.ReaderData.IsDBNull(6) ? "NULL" : r.ReaderData.GetString(6);
                    string timeIn = r.ReaderData.IsDBNull(7) ? "NULL" : r.ReaderData.GetString(7);
                    string timeOut = r.ReaderData.IsDBNull(8) ? "NULL" : r.ReaderData.GetString(8);
                    int planId = r.ReaderData.IsDBNull(9) ? 0 : r.ReaderData.GetInt32(9);

                    List<object> list = new List<object>
                {
                    planName,
                    signupFee,
                    price,
                    planType,
                    firstname,
                    tell,
                    shift,
                    timeIn,
                    timeOut,
                    planId
                };

                    Dict.Add(planName, list);
                    count++;
                }
            }
        });
        return Dict ?? null;
    }


    // Get Plans
    public List<string> getPlans()
    {
        string query = @"select plan_name from plans";
        List<string> list = new List<string>();
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                list.Add(r.ReaderData.GetString(0));
            }
        });
        return list;
    }

    // Get Trainers
    public Dictionary<string, List<object>> getTrainer()
    {
        string query = @"SELECT id, firstname FROM staff_information where staff_type = 'Trainer';";

        Dictionary<string, List<object>> DictTrainer = new Dictionary<string, List<object>>();

        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                int staffId = r.ReaderData.GetInt32(0);
                string staffName = r.ReaderData.GetString(1);

                List<object> list = new List<object>
                    {
                        staffId, staffName
                    };
                DictTrainer.Add(staffName, list);
            }
        });

        return DictTrainer;
    }
    // Get Staff
    public List<StaffModal> GetStaffData(string query)
    {
        List<StaffModal> StaffList = new List<StaffModal>();
        Console.WriteLine(query);
        if (query == "")
        {
            query = @"SELECT * FROM staff_information";
        }
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                //int planId = r.ReaderData.IsDBNull(9) ? 0 : r.ReaderData.GetInt32(9);

                int id = r.ReaderData.IsDBNull(0) ? 0 : r.ReaderData.GetInt32(0);
                string FirstName = r.ReaderData.IsDBNull(1) ? "null" : r.ReaderData.GetString(1);
                string LastName = r.ReaderData.IsDBNull(2) ? "null" : r.ReaderData.GetString(2);
                string DoB = r.ReaderData.IsDBNull(3) ? "null" : r.ReaderData.GetString(3);
                string Tell = r.ReaderData.IsDBNull(4) ? "null" : r.ReaderData.GetString(4);
                string Email = r.ReaderData.IsDBNull(5) ? "null" : r.ReaderData.GetString(5);
                string Sex = r.ReaderData.IsDBNull(6) ? "null" : r.ReaderData.GetString(6);
                string City = r.ReaderData.IsDBNull(7) ? "null" : r.ReaderData.GetString(7);
                string Village = r.ReaderData.IsDBNull(8) ? "null" : r.ReaderData.GetString(8);
                string Em_Contact = r.ReaderData.IsDBNull(9) ? "null" : r.ReaderData.GetString(9);
                string Emm_Name = r.ReaderData.IsDBNull(10) ? "null" : r.ReaderData.GetString(10);
                string Emm_R = r.ReaderData.IsDBNull(11) ? "null" : r.ReaderData.GetString(11);
                string Shift = r.ReaderData.IsDBNull(12) ? "null" : r.ReaderData.GetString(12);
                string StaffType = r.ReaderData.IsDBNull(13) ? "null" : r.ReaderData.GetString(13);
                float Salary = r.ReaderData.IsDBNull(14) ? 0 : r.ReaderData.GetFloat(14);

                //StaffObject
                StaffModal staffs = new StaffModal(
                id,
                FirstName,
                LastName,
                DoB,
                Tell, Email,
                Sex,
                City,
                Village,
                Em_Contact,
                Emm_Name,
                Emm_R,
                Shift,
                StaffType,
                Salary
                        );
                StaffList.Add(staffs);
            }
        });

        return StaffList;
    }

    public List<MemberShipModal>? GetMembersData(string query)
    {
        List<MemberShipModal> MemberList = new List<MemberShipModal>();
        Console.WriteLine(query);
        if (query == "")
        {
            query = @"select * from Customer_info";
        }

        helper.QueryReader(query, r =>
        {
            try
            {
                while (r.ReaderData.Read())
                {
                    int id = r.ReaderData.GetInt32(0);
                    string FirstName = r.ReaderData.IsDBNull(1) ? "null" : r.ReaderData.GetString(1);
                    string LastName = r.ReaderData.IsDBNull(2) ? "null" : r.ReaderData.GetString(2);
                    string DoB = r.ReaderData.IsDBNull(3) ? "null" : r.ReaderData.GetString(3);
                    string Tell = r.ReaderData.IsDBNull(4) ? "null" : r.ReaderData.GetString(4);
                    string Email = r.ReaderData.IsDBNull(5) ? "null" : r.ReaderData.GetString(5);
                    string Sex = r.ReaderData.IsDBNull(6) ? "null" : r.ReaderData.GetString(6);
                    float Weight = r.ReaderData.IsDBNull(7) ? 0 : r.ReaderData.GetFloat(7);
                    string City = r.ReaderData.IsDBNull(8) ? "null" : r.ReaderData.GetString(8);
                    string Village = r.ReaderData.IsDBNull(9) ? "null" : r.ReaderData.GetString(9);
                    string Em_Contact = r.ReaderData.IsDBNull(10) ? "null" : r.ReaderData.GetString(10);
                    string Emm_Name = r.ReaderData.IsDBNull(11) ? "null" : r.ReaderData.GetString(11);
                    string Emm_R = r.ReaderData.IsDBNull(12) ? "null" : r.ReaderData.GetString(12);
                    int PlansId = r.ReaderData.IsDBNull(13) ? 0 : r.ReaderData.GetInt32(13);

                    //MemberObject
                    MemberShipModal member = new MemberShipModal(
                    id,
                    FirstName,
                    LastName,
                    DoB,
                    Tell,
                    Email,
                    Sex,
                    City,
                    Village,
                    Em_Contact,
                    Emm_Name,
                    Emm_R,
                    Weight,
                    PlansId
                    );
                    MemberList.Add(member);
                }

            }
            catch (NullReferenceException)
            {

                Console.WriteLine("Why");
            }
        });

        return MemberList;
    }




    public List<AttendanceModal> GetAttendance()
    {
        string query = @"select att.customer_id,
	    cus.firstname || ' ' || cus.lastname AS full_name,
	    att.AttDate,
	    att.attendanced
       from attendance as att 
        INNER JOIN Customer_info as cus on att.customer_id = cus.id
        where date(att.AttDate) = date()
        order by att.AttDate DESC";

        List<AttendanceModal> AttendanceList = new List<AttendanceModal>();

        helper.QueryReader(query, r =>
        {
            Console.WriteLine(r.msg + " Attendances");

            while (r.ReaderData.Read())
            {
                int Customer_ID = r.ReaderData.GetInt32(0);
                string Fullname = r.ReaderData.GetString(1);
                string Date = r.ReaderData.GetString(2);
                bool Attended = r.ReaderData.GetBoolean(3);
                AttendanceModal attendance = new AttendanceModal(Customer_ID, Fullname, Date, Attended);


                AttendanceList.Add(attendance);
            }
        });

        return AttendanceList;
    }

    public List<AttendanceModal> checkAttended(int memberid)
    {
        string query = $@"SELECT
                        cus.id,
                        firstname || ' ' || cus.lastname AS full_name,
                        date(),
                        case
	                        WHEN date(AttDate) = date('now')
		                        THEN 1 
	                        ELSE
		                        0 END as Attended
                        from Customer_info as cus
                        join attendance on customer_id = cus.id
                        WHERE cus.id = {memberid}
                        ORDER by AttDate DESC
                        limit 1";


        List<AttendanceModal> AttendanceList = new List<AttendanceModal>();
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                int Customer_ID = r.ReaderData.GetInt16(0);
                string Fullname = r.ReaderData.GetString(1);
                string Date = r.ReaderData.GetString(2);
                bool Attended = r.ReaderData.GetBoolean(3);

                AttendanceModal attendance = new AttendanceModal(Customer_ID, Fullname, Date, Attended);
                AttendanceList.Add(attendance);
            }
        });

        return AttendanceList;
    }


    public void Attended(int memberid)
    {
        string query = $@"INSERT into attendance(customer_id,AttDate, attendanced)
                         VALUES({memberid}, datetime('now'), 1)";

        helper.QueryWriter(query, r =>
        {
            Console.WriteLine(r.msg);
        });
    }



    public List<AttendanceModal> ViewThisMonth(int? memberid)
    {

        string query = $@"SELECT 
                            att.customer_id,
	                        cus.firstname || ' ' || cus.lastname AS full_name,
	                        att.AttDate,
	                        att.attendanced  from attendance as att
                            inner join Customer_info as cus on cus.id = att.customer_id
                            WHERE strftime('%m', date(att.AttDate)) = strftime('%m', date('now')) and cus.id = {memberid}
                            order by AttDate ASC";

        List<AttendanceModal> AttendanceList = new List<AttendanceModal>();
        helper.QueryReader(query, r =>
        {

            while (r.ReaderData.Read())
            {
                int Customer_ID = r.ReaderData.GetInt16(0);
                string Fullname = r.ReaderData.GetString(1);
                string Date = r.ReaderData.GetString(2);
                bool Attended = r.ReaderData.GetBoolean(3);

                AttendanceModal attendance = new AttendanceModal(Customer_ID, Fullname, Date, Attended);
                AttendanceList.Add(attendance);
            }
        });
        return AttendanceList;
    }


    public List<ScheduleModel> SchedulesList()
    {
        string query = @"SELECT p.plan_name, sch.time_in, sch.time_out, stff.firstname||' '||stff.lastname as Fullname from schedule as sch
                        INNER JOIN plans as p on sch.plan_id = p.id
                        INNER JOIN staff_information as stff on stff.id = p.staff_id";

        List<ScheduleModel> SchList = new List<ScheduleModel>();
        helper.QueryReader(query, r => 
        {
            while (r.ReaderData.Read())
            {
                string planName = r.ReaderData.GetString(0);
                string timeIn = r.ReaderData.GetDateTime(1).ToString("HH:mm:ss");
                string timeOut = r.ReaderData.GetDateTime(2).ToString("HH:mm:ss");
                string fullName = r.ReaderData.GetString(3);

                ScheduleModel model = new ScheduleModel(planName, timeIn, timeOut, fullName);
                SchList.Add(model);
            }
        });

        return SchList;
    }


    public Dictionary<string, int> dashboardSummary()
    {
        Dictionary<string, int> SummaryData = new Dictionary<string, int>();

        string query = @"SELECT (SELECT count(*) FROM Customer_info) as cus_Count,
		                 (SELECT count(*) from staff_information) as Stf_Count,
		                 (SELECT count(attendanced) from attendance
		                 where date(AttDate) = date('now')) as today_Count";

        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                SummaryData.Add("Cus_Count", r.ReaderData.GetInt16(0));
                SummaryData.Add("Stf_Count", r.ReaderData.GetInt16(1));
                SummaryData.Add("today_Count", r.ReaderData.GetInt16(2));
            }
        });
        return SummaryData;
    }


    public List<AttendanceModal> GetAttendLast10()
    {
        string query = @"select att.customer_id,
	    cus.firstname || ' ' || cus.lastname AS full_name,
	    att.AttDate,
	    att.attendanced
       from attendance as att 
        INNER JOIN Customer_info as cus on att.customer_id = cus.id
        where date(att.AttDate) = date()
        order by att.AttDate DESC
        LIMIT 10
";

        List<AttendanceModal> AttendanceList = new List<AttendanceModal>();
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                int Customer_ID = r.ReaderData.GetInt32(0);
                string Fullname = r.ReaderData.GetString(1);
                string Date = r.ReaderData.GetString(2);
                bool Attended = r.ReaderData.GetBoolean(3);
                AttendanceModal attendance = new AttendanceModal(Customer_ID, Fullname, Date, Attended);


                AttendanceList.Add(attendance);
            }
        });

        return AttendanceList;
    }

    



    public Dictionary<string, float> FinanceSummary()
    {
        string query = @"SELECT  
        (select sum(stff.salary) as Grand_Total from salaries as sal
	    inner join staff_information as stff on stff.id = sal.staff_id)
		as TotalExp,
		
		(select sum(stff.salary) as This_Month from salaries as sal
		inner join staff_information as stff on stff.id = sal.staff_id
		where strftime('%m', date(sal.date_created)) = strftime('%m', date('now')))
		as MonExp,
	
		(select sum(stff.salary) as This_Year from salaries as sal
		inner join staff_information as stff on stff.id = sal.staff_id
		WHERE strftime('%Y', date(sal.date_created)) = strftime('%Y', date('now'))
		AND sal.date_created <= date('now'))
		as YearExp,
		
		(SELECT sum(p.price) + sum(p.signup_fee) from revenue as r
        inner join Customer_info as cus on cus.id = r.customer_id
        inner join plans as p on p.id = cus.planId) 
        as TotalRev,

        (SELECT sum(p.price) from revenue as r
        inner join Customer_info as cus on cus.id = r.customer_id
        inner join plans as p on p.id = cus.planId
        where strftime('%m', date(r.date_created)) = strftime('%m', date('now')))
        as MonRev,

        (SELECT sum(p.price) from revenue as r
        inner join Customer_info as cus on cus.id = r.customer_id
        inner join plans as p on p.id = cus.planId
        WHERE strftime('%Y', date(r.date_created)) = strftime('%Y', date('now'))
	    AND r.date_created <= date('now'))
        as YearRev
        ";

        Dictionary<string, float> FinanceSummary = new Dictionary<string, float>();
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                
                FinanceSummary.Add("TotalExp", r.ReaderData.IsDBNull(0) ? 0 : r.ReaderData.GetFloat(0));
                FinanceSummary.Add( "MonExp", r.ReaderData.IsDBNull(1) ? 0 : r.ReaderData.GetFloat(1));
                FinanceSummary.Add("YearExp", r.ReaderData.IsDBNull(2) ? 0 : r.ReaderData.GetFloat(2));


                FinanceSummary.Add("TotalRev", r.ReaderData.IsDBNull(3) ? 0 : r.ReaderData.GetFloat(3));
                FinanceSummary.Add("MonRev", r.ReaderData.IsDBNull(4) ? 0 : r.ReaderData.GetFloat(4));
                FinanceSummary.Add("YearRev", r.ReaderData.IsDBNull(5) ? 0 : r.ReaderData.GetFloat(5));
            }
        });

        return FinanceSummary;
    }



    public struct PayementStatus
    {
        public float Price { get; set; }
        public string Fullname { get; set; }
        public int Id { get; set; }
        public string Pay_status { get; set; }

        public PayementStatus(float price, string fullname, int id, string pay_status)
        {
            Price = price;
            Fullname = fullname;
            Id = id;
            Pay_status = pay_status;
        }
    }

    
    
    public List<PayementStatus> PayedMember()
    {
        string query = @"SELECT ifnull(p.price,0.0),cus.firstname||' '||cus.lastname,cus.id,
                        CASE 
                            WHEN max(strftime('%m', date(r.date_created))) = strftime('%m', date('now')) THEN 'Payed'
                            ELSE 'Not Payed'
                        END AS Payed
                        FROM Customer_info AS cus
                        LEFT JOIN 
                            revenue AS r ON cus.id = r.customer_id
                        LEFT JOIN 
                            plans AS p ON p.id = cus.planId
                        GROUP BY 
                            cus.id
                        HAVING 
                            Payed = 'Payed';";

        List<PayementStatus> PayedList = new List<PayementStatus>();
        Console.WriteLine(query);
        helper.QueryReader(query, r => {
            while (r.ReaderData.Read())
            {
                float price = r.ReaderData.GetFloat(0);
                string fullname = r.ReaderData.GetString(1);
                int id = r.ReaderData.GetInt16(2);
                string status = r.ReaderData.GetString(3);

                PayementStatus payed = new PayementStatus(price, fullname, id, status);
                PayedList.Add(payed);
            }
        });

        return PayedList;
    }



    public List<PayementStatus> NonPayedMember()
    {
        string query = @"SELECT ifnull(p.price,0.0),cus.firstname||' '||cus.lastname,cus.id,
                        CASE 
                            WHEN max(strftime('%m', date(r.date_created))) = strftime('%m', date('now')) THEN 'Payed'
                            ELSE 'Not Payed'
                        END AS Payed
                        FROM Customer_info AS cus
                        LEFT JOIN 
                            revenue AS r ON cus.id = r.customer_id
                        LEFT JOIN 
                            plans AS p ON p.id = cus.planId
                        GROUP BY 
                            cus.id
                        HAVING 
                            Payed = 'Not Payed';";

        List<PayementStatus> PayedList = new List<PayementStatus>();
        helper.QueryReader(query, r => {

            while (r.ReaderData.Read())
            {
                float price = r.ReaderData.GetFloat(0);
                string fullname = r.ReaderData.GetString(1);
                int id = r.ReaderData.GetInt16(2);
                string status = r.ReaderData.GetString(3);

                PayementStatus payed = new PayementStatus(price, fullname, id, status);
                PayedList.Add(payed);
            }
        });

        return PayedList;
    }



    public struct StaffSalary
    {
        

        public int ID { get; set; }
        public string Staff_Name { get; set; }
        public float Staff_Salary {  get; set; }
        public DateTime Date_Created { get; set; }

        public StaffSalary(int iD, string staff_Name, float staff_Salary, DateTime date_Created)
        {
            ID = iD;
            Staff_Name = staff_Name;
            Staff_Salary = staff_Salary;
            Date_Created = date_Created;
        }

    }

    public List<StaffSalary> StaffSalaryGrid()
    {
        string query = @"SELECT 
                            stf.id,
                            stf.firstname||' '||stf.lastname, 
                            stf.salary,
                            sal.date_created
                            from salaries as sal
                         inner join staff_information as stf on sal.staff_id = stf.id";

        List<StaffSalary> StaffSalary_List = new List<StaffSalary>();
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                int id = r.ReaderData.GetInt16(0);
                string Fullname = r.ReaderData.GetString(1);
                float salary = r.ReaderData.GetFloat(2);
                DateTime date_created = r.ReaderData.GetDateTime(3);

                StaffSalary staff_row = new StaffSalary(id,Fullname,salary,date_created);
                StaffSalary_List.Add(staff_row);
            }
        });

        return StaffSalary_List;
    }

    public List<int> staffIds()
    {
        string query = @"SELECT id from staff_information";

        List <int> ids = new List<int>();
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                int id = r.ReaderData.GetInt32(0);
                ids.Add(id);
            }
        });
        return ids;
    }

    public struct PlansReport
    {
        public int id { get; set; }
        public string plan_name { get; set; }
        public float signUp_fee { get; set; }
        public float price { get; set; }
        public string plan_type { get; set; }

        public PlansReport(int id, string plan_name, float signUp_fee, float price, string plan_type)
        {
            this.id = id;
            this.plan_name = plan_name;
            this.signUp_fee = signUp_fee;
            this.price = price;
            this.plan_type = plan_type;
        }
    }

    public List<PlansReport> PlansReportList()
    {
        string query = @"SELECT id, plan_name, signup_fee, price, plan_type  from plans";

        List<PlansReport> plansReports = new List<PlansReport>();

        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                int id = r.ReaderData.GetInt16(0);
                string planame = r.ReaderData.GetString(1);
                float signupfee = r.ReaderData.GetFloat(2);
                float price = r.ReaderData.GetFloat(3);
                string plantype = r.ReaderData.GetString(4);

                PlansReport plansReport = new PlansReport(id, planame, signupfee, price, plantype);
                plansReports.Add(plansReport);
            }
        });
        return plansReports;

    }

}

