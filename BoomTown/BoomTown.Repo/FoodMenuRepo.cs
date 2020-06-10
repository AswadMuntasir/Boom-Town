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
    public class FoodMenuRepo
    {
        public Result<List<FMenu>> GetAllMenu()
        {
            var result = new Result<List<FMenu>>() { Data = new List<FMenu>() };
            try
            {
                string query = "Select * from order";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    FMenu fm = ConvertToEntity(dt.Rows[i]);
                    result.Data.Add(fm);
                }
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }
        private FMenu ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            FMenu fm = new FMenu();
            fm.menu_no = int.Parse(row["menu_no"].ToString());
            fm.menu_name = row["menu_name"].ToString();
            fm.menu_price = float.Parse(row["menu_price"].ToString());
            return fm;
        }

        public Result<FMenu> AddMenu(FMenu fm)
        {
            var result = new Result<FMenu>();
            string query = "select * from order where menu_no = " + fm.menu_no + ";";
            var dt = DataAccess.GetDataTable(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                query = "Insert into order values ('" + fm.menu_no.ToString() + "'," + fm.menu_price + ")";
            }

            result.HasError = DataAccess.ExecuteQuery(query) <= 0;
            if (result.HasError)
            {
                result.Message = "Wrong";
            }
            else
            {
                result.Data = fm;
            }

            return result;
        }
    }
}
