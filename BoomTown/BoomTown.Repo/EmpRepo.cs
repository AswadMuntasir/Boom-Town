using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BoomTown.Data;
using BoomTown.Framework;
using BoomTown.Entities;

namespace BoomTown.Repo
{
    public class EmpRepo
    {
        public Result<List<Emp>> GetAllEmployee()
        {
            var result = new Result<List<Emp>>() { Data = new List<Emp>() };
            try
            {
                string query = "Select * from emp";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Emp e = ConvertToEntity(dt.Rows[i]);
                    result.Data.Add(e);
                }
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }
        private Emp ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            Emp e = new Emp();
            e.emp_no = int.Parse(row["emp_no"].ToString());
            e.emp_Name = row["emp_name"].ToString();
            e.emp_contact_no = row["emp_contact_no"].ToString();
            e.emp_type = row["emp_type"].ToString();
            e.emp_address = row["emp_address"].ToString();
            e.emp_sal = float.Parse(row["salary"].ToString());
            e.emp_hiredate = DateTime.Parse(row["emp_hiredate"].ToString());
            return e;
        }

        public Result<Emp> SaveEmployee(Emp e)
        {
            var result = new Result<Emp>();
            string query = "select * from emp where emp_no = '" + e.emp_no + "'";
            var dt = DataAccess.GetDataTable(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                query = "insert into emp values ('" + e.emp_Name + "','" + e.emp_contact_no + "','" + e.emp_type + "','" + e.emp_address + "'," + e.emp_sal + ",'" + e.emp_hiredate + "')";
            }
            else
            {
                query = "update emp set emp_name = '" + e.emp_Name + "',emp_contact_no='" + e.emp_contact_no + "',emp_type='" + e.emp_type + "',emp_address='" + e.emp_address + "',emp_sal=" + e.emp_sal + ",emp_hiredate= '" + e.emp_hiredate + "' where emp_no = " + Convert.ToInt32(e.emp_no);
            }

            result.HasError = DataAccess.ExecuteQuery(query) <= 0;
            if (result.HasError)
            {
                result.Message = "Wrong";
            }
            else
            {
                result.Data = e;
            }

            return result;
        }

        public Result<Emp> DeleteEmployee(Emp e, string a)
        {
            var result = new Result<Emp>();
            string query = "delete from emp where emp_no = " + a + ";";

            result.HasError = DataAccess.ExecuteQuery(query) <= 0;
            if (result.HasError)
            {
                result.Message = "Wrong";
            }
            else
            {
                result.Data = e;
            }

            return result;
        }
    }
}
