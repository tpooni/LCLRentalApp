using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace LCLRentalApp
{
    class DataModule
    {
        private const string SQL_CONN_WISDOM = "Data Source=SQLWEBWISDOM;Initial Catalog=WEBWISDOM;User ID=WISDOMuser;Password=sesame";

        public DataTable GetJobScheduleForAdmin()
        {
            SqlConnection cnWISDOM = new SqlConnection(SQL_CONN_WISDOM);
            SqlCommand cmdWISDOM = new SqlCommand();
            DataTable dtWISDOM = null;
            try
            {
                cnWISDOM.Open();
                cmdWISDOM.Connection = cnWISDOM;
                cmdWISDOM.CommandType = CommandType.StoredProcedure;
                cmdWISDOM.CommandText = "spGetJobListForAdmin";
                cmdWISDOM.CommandTimeout = 60;
                cmdWISDOM.Parameters.Clear();

                SqlDataAdapter daWISDOM = new SqlDataAdapter();
                daWISDOM.SelectCommand = cmdWISDOM;

                DataSet dsWISDOM = new DataSet();
                daWISDOM.Fill(dsWISDOM, "JobSchedule");

                dtWISDOM = dsWISDOM.Tables["JobSchedule"];

                return dtWISDOM;
            }
            catch (Exception ex)
            {
                //MsgBox(ex.Message);
                return dtWISDOM;
            }
            finally
            {
                cnWISDOM.Close();
            }
            return dtWISDOM;
        }

        public void RollbackJobConfirmation(string JobNo)
        {
            SqlConnection cnWISDOM = new SqlConnection(SQL_CONN_WISDOM);
            SqlCommand cmdWISDOM = new SqlCommand();
            DataTable dtWISDOM = null;
            try
            {
                cnWISDOM.Open();
                cmdWISDOM.Connection = cnWISDOM;
                cmdWISDOM.CommandType = CommandType.StoredProcedure;
                cmdWISDOM.CommandText = "spRollbackJobConfirmation";
                cmdWISDOM.Parameters.Clear();
                cmdWISDOM.Parameters.Add(new SqlParameter("@JobNo", SqlDbType.Int)).Value = JobNo;
                cmdWISDOM.CommandTimeout = 60;
                cmdWISDOM.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cnWISDOM.Close();
            }
        }

        public void AddUpdateJobState(string JobNo, int Step, string UserID)
        {
            SqlConnection cnWISDOM = new SqlConnection(SQL_CONN_WISDOM);
            SqlCommand cmdWISDOM = new SqlCommand();
            DataTable dtWISDOM = null;
            try
            {
                cnWISDOM.Open();
                cmdWISDOM.Connection = cnWISDOM;
                cmdWISDOM.CommandType = CommandType.StoredProcedure;
                cmdWISDOM.CommandText = "spAddUpdateJobState";
                cmdWISDOM.Parameters.Clear();
                cmdWISDOM.Parameters.Add(new SqlParameter("@JobNo", SqlDbType.Int)).Value = JobNo;
                cmdWISDOM.Parameters.Add(new SqlParameter("@Step", SqlDbType.Int)).Value = Step;
                cmdWISDOM.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar)).Value = UserID;
                cmdWISDOM.CommandTimeout = 60;
                cmdWISDOM.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cnWISDOM.Close();
            }
        }

        public Int32 GetJobStep(string JobNo, string UserID)
        {
            SqlConnection cnWISDOM = new SqlConnection(SQL_CONN_WISDOM);
            SqlCommand cmdWISDOM = new SqlCommand();
            DataTable dtWISDOM = null;
            SqlDataReader rdr = null;
            Int32 Step = 0;
            try
            {
                cnWISDOM.Open();
                cmdWISDOM.Connection = cnWISDOM;
                cmdWISDOM.CommandType = CommandType.StoredProcedure;
                cmdWISDOM.CommandText = "spGetJobStep";
                cmdWISDOM.Parameters.Clear();
                cmdWISDOM.Parameters.Add(new SqlParameter("@JobNo", SqlDbType.Int)).Value = JobNo;
                cmdWISDOM.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar)).Value = UserID;
                cmdWISDOM.CommandTimeout = 60;
                rdr = cmdWISDOM.ExecuteReader();
                while (rdr.Read())
                {
                    Step = Int32.Parse(rdr["Step"].ToString());
                }
                return Step;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cnWISDOM.Close();
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            return Step;
        }
    }
}
