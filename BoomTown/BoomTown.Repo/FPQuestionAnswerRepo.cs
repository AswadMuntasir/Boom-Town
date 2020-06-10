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
    public class FPQuestionAnswerRepo
    {
        public Result<List<FPQsnAns>> GetAllQuestion()
        {
            var result = new Result<List<FPQsnAns>>() { Data = new List<FPQsnAns>() };
            try
            {
                string query = "Select * from fp_question_answer";
                var dt = DataAccess.GetDataTable(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    FPQsnAns qs = ConvertToEntity(dt.Rows[i]);
                    result.Data.Add(qs);
                }
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }
        public Result<List<FPQsnAns>> GetAllquestion(int a)
        {
            var result = new Result<List<FPQsnAns>>() { Data = new List<FPQsnAns>() };
            try
            {
                string query = "Select question from fp_question_answer where question_no = " + a + ";";
                var dt = DataAccess.GetDataTable(query);
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }

        public Result<List<FPQsnAns>> GetAllAnswer(int a)
        {
            var result = new Result<List<FPQsnAns>>() { Data = new List<FPQsnAns>() };
            try
            {
                string query = "Select answer from fp_question_answer where question_no = " + a + ";";
                var dt = DataAccess.GetDataTable(query);
            }
            catch (Exception exc)
            {
                result.HasError = true;
                result.Message = exc.Message;
            }
            return result;
        }

        private FPQsnAns ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            FPQsnAns qs = new FPQsnAns();
            qs.question_no = int.Parse(row["question_no"].ToString());
            qs.question = row["question"].ToString();
            qs.answer = row["answer"].ToString();
            return qs;
        }

        public Result<FPQsnAns> SaveCustomer(FPQsnAns qs)
        {
            var result = new Result<FPQsnAns>();
            string query = "select * from customer where customer_no = '" + qs.question_no + "'";
            var dt = DataAccess.GetDataTable(query);
            if (dt == null || dt.Rows.Count == 0)
            {
                query = "Insert into fp_question_answer values ('" + qs.question + "','" + qs.answer + "')";
            }
            else
            {
                query = "Update fp_question_answer set question = '" + qs.question + "',answer='" + qs.answer + "' where question_no=" + qs.question_no + ";";
            }

            result.HasError = DataAccess.ExecuteQuery(query) <= 0;
            if (result.HasError)
            {
                result.Message = "Wrong";
            }
            else
            {
                result.Data = qs;
            }

            return result;
        }

        public Result<FPQsnAns> DeleteCustomer(FPQsnAns e, string a)
        {
            var result = new Result<FPQsnAns>();
            string query = "delete from fp_question_answer where question_no = " + a + ";";

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
