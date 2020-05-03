using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnik
{
    class DAL
    {
        string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = University; Integrated Security = True;";

        public ArrayList GetStud()
        {
            ArrayList GetStud = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Студенты", con);
                con.Open();


                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    foreach (DbDataRecord result in dr)
                    {
                        GetStud.Add(result);
                    }
                }


            }
            return GetStud;
        }
        public bool SaveNewStud(string FIO, int NumberZach, string year, string Group)
        {
            bool flag = false;

            string query = string.Format("INSERT INTO Студенты(ФИО, НомерЗачетки,ГодПоступления, Группа) VALUES('{0}','{1}','{2}','{3}')",
                FIO, NumberZach, year, Group);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }

                return flag;

            }
        }

            public bool DeleteStud(int id)
            {
                bool flag = false;
                string sql = string.Format("DELETE FROM Студенты WHERE НомерЗачетки = '{0}' ", id);
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand com = new SqlCommand(sql, con);
                    con.Open();

                    if (com.ExecuteNonQuery() == 1)
                    {
                        flag = true;
                    }
                    return true;
                }
        }
        //////////////////////////////////////////////////////////////////////
        public ArrayList GetPrepod()
        {
            ArrayList GetPrepod = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Преподаватели", con);
                    con.Open();


                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    foreach (DbDataRecord result in dr)
                    {
                        GetPrepod.Add(result);
                    }
                }


            }
            return GetPrepod;
        }

       ///////////////////////////////////////////////////////////////
        public ArrayList Getgr()
        {
            ArrayList GetPrepod = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Группы", con);
                con.Open();


                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    foreach (DbDataRecord result in dr)
                    {
                        GetPrepod.Add(result);
                    }
                }


            }
            return GetPrepod;
        }

        public ArrayList Getdolg()
        {
            ArrayList GetPrepod = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Должники", con);
                con.Open();


                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    foreach (DbDataRecord result in dr)
                    {
                        GetPrepod.Add(result);
                    }
                }


            }
            return GetPrepod;
        }
    }
}
