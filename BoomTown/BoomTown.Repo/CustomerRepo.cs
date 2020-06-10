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
    public class CustomerRepo
    {
        public Result<List<Custo>> GetAllCustomer()
        {
            var result = new Result<List<Custo>>() { Data = new List<Custo>() };
            try
            {
                string query = "Select * from customer";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Custo c = ConvertToEntity(dt.Rows[i]);
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
        public Result<List<Custo>> GetDataSearch(string a)
        {
            var result = new Result<List<Custo>>() { Data = new List<Custo>() };
            try
            {
                string query = "select * from customer where customer_name like '" + a + "%' or customer_contact_no like '" + a + "%'; ";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Custo c = ConvertToEntity(dt.Rows[i]);
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


        private Custo ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            Custo c = new Custo();
            c.customer_no = int.Parse(row["customer_no"].ToString());
            c.customer_Name = row["customer_name"].ToString();
            c.customer_contact_no = row["customer_contact_no"].ToString();
            c.customer_email = row["customer_email"].ToString();
            c.customer_address = row["customer_address"].ToString();
            return c;
        }

        public Result<Custo> SaveCustomer(Custo c)
        {
            var result = new Result<Custo>();
            string query = "select * from customer where customer_no = '" + c.customer_no + "'";
            var dt = DataAccess.GetDataTable(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                query = "Insert into customer values ('" + c.customer_Name + "','" + c.customer_contact_no + "','" + c.customer_email + "','" + c.customer_address + ")";
            }
            else
            {
                query = "Update customer set customer_name = '" + c.customer_Name + "',customer_contact_no='" + c.customer_contact_no + "',customer_email='" + c.customer_email + "',customer_address='" + c.customer_address + "' where id = '" + c.customer_no + "'";
            }

            result.HasError = DataAccess.ExecuteQuery(query) <= 0;
            if (result.HasError)
            {
                result.Message = "Wrong";
            }
            else
            {
                result.Data = c;
            }

            return result;
        }

        public Result<Custo> DeleteCustomer(Custo e, string a)
        {
            var result = new Result<Custo>();
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
