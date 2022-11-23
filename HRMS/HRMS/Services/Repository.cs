﻿using HRMS.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace hrms_portal.models
{
    public class Repository
    {
        private readonly IConfiguration _configuration;
        int idfromtable = 0;
        public Repository(IConfiguration configuration)
        {
            this._configuration = configuration;


        }



        public string GetEmployeeId()
        {
            string str = "fb00";

            string query = "select count(1) id from empid order by id desc";
            var sqlconnection = new SqlConnection(_configuration.GetConnectionString("myconn"));
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            SqlDataReader sreader = cmd.ExecuteReader();
            while (sreader.Read())
            {
                idfromtable = ((int)sreader["id"]);
            }

            string c = str + idfromtable;

            InsertEmpid(c);

            return c;


        }

        public void InsertEmpid(string str)
        {
            SqlConnection sqlconnection = new SqlConnection(_configuration.GetConnectionString("myconn"));
            sqlconnection.Open();
            string insertqery = "insert into empid (id) values(@id)";
            SqlCommand scmd = new SqlCommand(insertqery, sqlconnection);
            scmd.Parameters.AddWithValue("@id", idfromtable + 1);
            int a = scmd.ExecuteNonQuery();

        }
        public bool AddEmployee(string json)
        {

            SqlConnection sqlconnection = new SqlConnection(_configuration.GetConnectionString("myconn"));
            SqlCommand com = new SqlCommand("AddNewEmpDetails", sqlconnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@JSON", json);
           
            sqlconnection.Open();
            int i = com.ExecuteNonQuery();
            sqlconnection.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
