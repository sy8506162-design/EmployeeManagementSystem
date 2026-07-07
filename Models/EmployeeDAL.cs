using EmployeeSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeSystem.Models
{
    public class EmployeeDAL
    {
        private readonly string cs = ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("sp_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", "SELECT");

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Employee emp = new Employee();

                    emp.EmployeeId = Convert.ToInt32(dr["EmployeeId"]);
                    emp.Name = dr["Name"].ToString();
                    emp.Email = dr["Email"].ToString();
                    emp.Department = dr["Department"].ToString();
                    emp.Salary = Convert.ToDecimal(dr["Salary"]);

                    employeeList.Add(emp);
                }
            }

            return employeeList;
        }
    }
}