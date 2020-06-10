using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoomTown.Data;
using BoomTown.Entities;
using BoomTown.Framework;


namespace BoomTown.Repo
{
    public class AdminRepo
    {
        public Result<List<Admin>> GetAllAdminDetails()
        {
            var result = new Result<List<Admin>>() { Data = new List<Admin>() };
            try
            {
                string query = "Select * from owner_credential";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Admin c = ConvertToEntity(dt.Rows[i]);
                    result.Data.Add(c);
                }
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }

        public Result<List<Admin>> GetID(string id)
        {
            //string s;
            var result = new Result<List<Admin>>() { Data = new List<Admin>() };
            try
            {
                string query = "Select user_id from owner_credential where user_id='" + id + "';";
                var dt = DataAccess.GetDataTable(query);
                //s = dt.ToString();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Admin c = ConvertToEntity(dt.Rows[i]);
                    result.Data.Add(c);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Database problem in AdminRepo");
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }

        public Result<List<Admin>> GetPass(string id)
        {
            var result = new Result<List<Admin>>();
            try
            {
                string query = "Select password from owner_credential where user_id='" + id + "';";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Admin c = ConvertToEntity(dt.Rows[i]);
                    result.Data.Add(c);
                }
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }

        private Admin ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            Admin a = new Admin();
            a.user_id = row["customer_no"].ToString();
            a.password = row["customer_name"].ToString();
            return a;
        }

        public Result<Admin> UpdatePassword(Admin a, string pass)
        {
            var result = new Result<Admin>();
            /*string query = "select * from owner_credential where user_id= '" + a.user_id + "'";
            var dt = DataAccess.GetDataTable(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                query = "Insert into owner_credential values ('" + a.password + "')";
            }
            else
            {
                query = "Update owner_credential set customer_name = '" + a.password + "' where id = '" + a.user_id + "'";
            }
            */
            string query = "Update owner_credential set customer_name = '" + pass + "' where id = '" + a.user_id + "'";
            result.HasError = DataAccess.ExecuteQuery(query) <= 0;
            if (result.HasError)
            {
                result.Message = "Wrong ID";
            }
            else
            {
                result.Data = a;
            }

            return result;
        }
    }
}
