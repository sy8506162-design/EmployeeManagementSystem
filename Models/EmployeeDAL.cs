using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeSystem.Models
{
    public class EmployeeDAL
    {

        string cs =
ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;
    }
}