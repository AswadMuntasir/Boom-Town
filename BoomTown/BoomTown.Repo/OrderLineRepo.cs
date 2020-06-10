using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BoomTown.Data;
using BoomTown.Entities;
using BoomTown.Framework;

namespace BoomTown.Repo
{
    public class OrderLineRepo
    {
        public Result<List<OdrLine>> GetAllOrderLine()
        {
            var result = new Result<List<OdrLine>>() { Data = new List<OdrLine>() };
            try
            {
                string query = "Select * from order_line";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    OdrLine ol = ConvertToEntity(dt.Rows[i]);
                    result.Data.Add(ol);
                }
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }
        private OdrLine ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            OdrLine ol = new OdrLine();
            ol.order_no = int.Parse(row["order_no"].ToString());
            ol.menu_no = int.Parse(row["menu_no"].ToString());
            ol.quantity = int.Parse(row["quantity"].ToString());
            return ol;
        }

        public Result<OdrLine> AddOrderLine(OdrLine ol)
        {
            var result = new Result<OdrLine>();
            string query = "select * from order_line where order_no = " + ol.order_no + ";";
            var dt = DataAccess.GetDataTable(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                query = "Insert into order_line values (" + ol.menu_no + "," + ol.quantity + ");";
            }

            result.HasError = DataAccess.ExecuteQuery(query) <= 0;
            if (result.HasError)
            {
                result.Message = "Wrong";
            }
            else
            {
                result.Data = ol;
            }

            return result;
        }
    }
}