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
    public class OrderRepo
    {
        public Result<List<Odr>> GetAllOrder()
        {
            var result = new Result<List<Odr>>() { Data = new List<Odr>() };
            try
            {
                string query = "Select * from order";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Odr od = ConvertToEntity(dt.Rows[i]);
                    result.Data.Add(od);
                }
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }
        private Odr ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            Odr od = new Odr();
            od.order_no = int.Parse(row["customer_no"].ToString());
            od.order_date = DateTime.Parse(row["order_date"].ToString());
            return od;
        }

        public Result<Odr> AddOrder(Odr od)
        {
            var result = new Result<Odr>();
            string query = "select * from order where order_no = " + od.order_no + ";";
            var dt = DataAccess.GetDataTable(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                query = "Insert into order values ('" + od.order_date + "')";
            }

            result.HasError = DataAccess.ExecuteQuery(query) <= 0;
            if (result.HasError)
            {
                result.Message = "Wrong";
            }
            else
            {
                result.Data = od;
            }

            return result;
        }
    }
}