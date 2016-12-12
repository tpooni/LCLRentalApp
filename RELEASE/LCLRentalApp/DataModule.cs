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

    }
}
