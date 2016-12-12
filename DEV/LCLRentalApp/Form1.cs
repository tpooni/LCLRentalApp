using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WIS.WISE;
using System.Data.SqlClient;
using Rebex.Net;
using System.Net.Mail;
using System.Web;
using Outlook = Microsoft.Office.Interop.Outlook;
using WIS.WISDOM;

namespace LCLRentalApp
{
    public partial class frmMain : Form
    {
        private WIS.WISE.WISEJob mWISEJobInfo;
        private WIS.WISDOM.Job CountJob;
        public frmMain()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            this.grdJobSchedule.DataSource = null;
            DataModule dmUtility = new DataModule();
            this.grdJobSchedule.DataSource = dmUtility.GetJobScheduleForAdmin();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataModule dmUtility = new DataModule();
            this.grdJobSchedule.DataSource = dmUtility.GetJobScheduleForAdmin();
            this.cmdPullTerminalFiles.Enabled = false;
            this.cmdPullSoftware.Enabled = false;
            this.cmdLaunchWISDOM.Enabled = false;
            this.cmdSendFilesToLCL.Enabled = false;
            this.cmdWrapUp.Enabled = false;
            this.cmdPostTagRange.Enabled = false;
        }

        #region "WISDOM Functions"

        private static void SetPrivateField(System.Xml.XmlDocument X, string FieldName, object Value)
        {
            //System.Reflection.FieldInfo FI = O.GetType().GetField(FieldName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            //if (FI.FieldType.FullName == "System.Int32") FI.SetValue(O, Value);
            //else if ((FI.FieldType.FullName == "System.Int64")) FI.SetValue(O, Value);
            //else if (FI.FieldType == typeof(string)) FI.SetValue(O, Value.ToString());
            //else FI.SetValue(O, Value);

            X.SelectSingleNode(string.Format("//WISEJOB/{0}", FieldName)).InnerText = Value.ToString();

        }

        private static System.Xml.XmlDocument GetJobInfo(Int64 JobNo, bool isReadExportInfo)
        {
            System.Data.SqlClient.SqlDataAdapter dr = null;
            System.Data.DataTable dt = null;
            System.Xml.XmlDocument x = new System.Xml.XmlDocument();
//            x.Load(@"C:\TEMP\WISDOMDEBUG.XWJ");
            x.Load(System.IO.Path.Combine(Application.StartupPath, "WISDOMDEBUG.XWJ"));
            x.DocumentElement.Attributes["JobNo"].Value = JobNo.ToString();




            string sSQL = null;
            //MessageBox.Show(Me.getConnectString(filename))
            string sConn = "Server=SQLWH.western-inventory.com;Database=WISE;user=WISEUser;pwd=WISE";
            if (JobNo == 0)
            {
                //read the first record
                throw new Exception("Invalid Parameter");
            }
            else
            {
                sSQL = "SELECT * FROM qryJobSelectionDetails WHERE JobNo=" + JobNo.ToString().Trim();
            }

            try
            {
                System.DateTime LastEdit = DateTime.Now;
                //Dim LastRepositor As String = WISE.WISESettings.Repositor
                //Read Job Info from WISEDATA
                dr = new System.Data.SqlClient.SqlDataAdapter(sSQL, sConn);
                dt = new System.Data.DataTable();
                dr.Fill(dt);
                //If dt.Rows.Count > 0 AndAlso CLng(dt.Rows(0).Item("JobNo")) = JobNo Then
                if (dt.Rows.Count > 0)
                {
                    var _with1 = dt.Rows[0];
                    if (!_with1.IsNull("JobNo"))
                    {
                        SetPrivateField(x, "m_jobno", _with1["JobNo"]);
                    }
                    if (!_with1.IsNull("OfficeNo"))
                    {
                        SetPrivateField(x, "m_officeno", _with1["OfficeNo"]);
                    }
                    if (!_with1.IsNull("Name"))
                    {
                        SetPrivateField(x, "m_name", _with1["Name"]);
                    }
                    if (!_with1.IsNull("PhoneMain"))
                    {
                        SetPrivateField(x, "m_phone", _with1["PhoneMain"]);
                    }
                    if (!_with1.IsNull("Address1"))
                    {
                        SetPrivateField(x, "m_addr", _with1["Address1"]);
                    }
                    if (!_with1.IsNull("Address2"))
                    {
                        SetPrivateField(x, "m_addr", _with1["Address2"]);
                    }
                    if (!_with1.IsNull("City"))
                    {
                        SetPrivateField(x, "m_City", _with1["City"]);
                    }
                    if (!_with1.IsNull("Province"))
                    {
                        SetPrivateField(x, "m_prov", _with1["Province"]);
                    }
                    if (!_with1.IsNull("PostalCode"))
                    {
                        SetPrivateField(x, "m_postal", _with1["PostalCode"]);
                    }
                    //                    if (!_with1.IsNull("StockLevel"))
                    //                  {
                    //                    SetPrivateField(x, "m_postal", 0);
                    //              }
                    if (!_with1.IsNull("Notes"))
                    {
                        SetPrivateField(x, "m_notes", _with1["Notes"]);
                    }
                    if (!_with1.IsNull("OpNotes"))
                    {
                        SetPrivateField(x, "m_opnotes", _with1["OpNotes"]);
                    }
                    if (!_with1.IsNull("JobID"))
                    {
                        SetPrivateField(x, "m_jobid", _with1["JobID"]);
                    }
                    //                    if (!_with1.IsNull("BranchID"))
                    //                  {
                    //                    SetPrivateField(x, "m_opnotes", 0);
                    //              }
                    //                    if (!_with1.IsNull("BranchNo"))
                    //                  {
                    //                    SetPrivateField(x, "m_jobid", 0);
                    //              }
                    if (!_with1.IsNull("EntryNotes"))
                    {
                        SetPrivateField(x, "m_entrynotes", _with1["EntryNotes"]);
                    }
                    if (!_with1.IsNull("PrecallNotes"))
                    {
                        SetPrivateField(x, "m_custprecallnotes", _with1["PrecallNotes"]);
                    }
                    //                    if (!_with1.IsNull("PrecallReq"))
                    //                  {
                    //                    SetPrivateField(x, "m_precallreq", _with1["PrecallReq"]);
                    //              }
                    if (!_with1.IsNull("StoreEntry"))
                    {
                        SetPrivateField(x, "m_storeentry", _with1["StoreEntry"]);
                    }
                    //                    if (!_with1.IsNull("CrewSizeEst"))
                    //                  {
                    //                    SetPrivateField(x, "m_storeentry", 0);
                    //              }
                    if (!_with1.IsNull("CustNo"))
                    {
                        SetPrivateField(x, "m_custno", _with1["CustNo"]);
                    }
                    if (!_with1.IsNull("StoreNo"))
                    {
                        SetPrivateField(x, "m_storeno", _with1["StoreNo"]);
                    }
                    if (!_with1.IsNull("SoftwareID"))
                    {
                        SetPrivateField(x, "m_softwareid", _with1["SoftwareID"]);
                    }
                    //if (!_with1.IsNull("SoftwareVer"))
                    //{
                    //    SetPrivateField(x, "m_softwareVer", _with1["SoftwareVer"]);
                    //}
                    if (!_with1.IsNull("IncludeID"))
                    {
                        SetPrivateField(x, "m_includeid", _with1["IncludeID"]);
                    }
                    //                    if (!_with1.IsNull("IncludeVer"))
                    //                 {
                    //                     SetPrivateField(x, "m_includeVer", _with1["IncludeVer"]);
                    //             }
                    /*
                    if (!_with1.IsNull("CPHrequired"))
                    {
                        SetPrivateField(x, "m_CPHrequired", _with1["CPHrequired"]);
                    }
                    if (!_with1.IsNull("CPHfactor"))
                    {
                        SetPrivateField(x, "m_CPHfactor", _with1["CPHfactor"]);
                    }
                     * */
                    return x;
                    //                        x.JobNo = Convert.ToInt64(_with1["JobNo"]).ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dr.Dispose();
                dt.Dispose();
            }

            return x;
        }


#endregion


        public static void UnzipFile(string ZipFileName, string DestFolder, string SearchPattern = "*.*", bool UseDirectories = false)
        {
            WIS.SysLib.ZipFunc zip1 = new WIS.SysLib.ZipFunc();
            zip1.UseDirectories = UseDirectories;
            zip1.OverWrite = true;
            zip1.UnZipFile(ZipFileName, SearchPattern, DestFolder, true);
        }

        public static bool WISDOMDownload(string InputFileName, string LocalPath, Boolean IsDataFile)
        {
            string UNCFileShare1Path = null;
            string InputPath = null;

            WIS.SysLib.AppSettings MyAppSet = new WIS.SysLib.AppSettings(Application.ExecutablePath + ".Config", true);

            if (IsDataFile) UNCFileShare1Path = MyAppSet.Item("UNCFileshare1DataFilesPath").Value.ToString();
            else UNCFileShare1Path = MyAppSet.Item("UNCFileshare1Path").Value.ToString();


            InputPath = UNCFileShare1Path;

            try
            {
                System.IO.File.Copy(System.IO.Path.Combine(InputPath, InputFileName), System.IO.Path.Combine(LocalPath, InputFileName), true);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return true;
        }


        private void selectStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drv = null;
            DataModule dmUtility = new DataModule();
            Int32 JobStep = 0;

            drv = (DataRowView)this.grdJobSchedule.BindingContext[this.grdJobSchedule.DataSource].Current;

            if (drv["Confirmed"].ToString() == "1")
            {
                JobStep = dmUtility.GetJobStep(drv["Job_No"].ToString(), Environment.UserName);
                if ( JobStep >= 5)
                {
                    this.cmdPullTerminalFiles.Enabled = true;
                    this.cmdPullSoftware.Enabled = false;
                    this.cmdLaunchWISDOM.Enabled = false;
                    this.cmdSendFilesToLCL.Enabled = false;
                    
                    switch (JobStep)
                    {
                        case 5:
                            this.cmdWrapUp.Enabled = true;
                            this.cmdPostTagRange.Enabled = false;
                            break;
                        case 6:
                            this.cmdWrapUp.Enabled = false;
                            this.cmdPostTagRange.Enabled = true;
                            break;
                        default:
                            this.cmdWrapUp.Enabled = true;
                            this.cmdPostTagRange.Enabled = true;
                            break;
                    }
                }
                else
                {
                    this.cmdPullTerminalFiles.Enabled = true;
                    this.cmdPullSoftware.Enabled = false;
                    this.cmdLaunchWISDOM.Enabled = false;
                    this.cmdSendFilesToLCL.Enabled = false;
                    this.cmdWrapUp.Enabled = false;
                    this.cmdPostTagRange.Enabled = false;
                    dmUtility.AddUpdateJobState(drv["Job_No"].ToString(), 1, Environment.UserName);
                }
                this.labelControl2.Text = drv["Job_No"].ToString();
                this.labelControl4.Text = drv["Software_ID"].ToString();
                this.labelControl6.Text = drv["Include_ID"].ToString();
                this.labelControl12.Text = drv["StoreNo"].ToString();
                this.labelControl14.Text = drv["Email"].ToString();
                this.labelControl16.Text = drv["Phone_No"].ToString();
                this.labelControl20.Text = drv["Notes"].ToString();
            }
            else
            {
                if (MessageBox.Show("Job is not confirmed, No tag range will be pulled. Are you sure you want to continue?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    this.labelControl2.Text = drv["Job_No"].ToString();
                    this.labelControl4.Text = drv["Software_ID"].ToString();
                    this.labelControl6.Text = drv["Include_ID"].ToString();
                    this.labelControl12.Text = drv["StoreNo"].ToString();
                    this.labelControl14.Text = drv["Email"].ToString();
                    this.labelControl16.Text = drv["Phone_No"].ToString();
                    this.labelControl20.Text = drv["Notes"].ToString();
                    this.cmdPullTerminalFiles.Enabled = true;
                    this.cmdPullSoftware.Enabled = false;
                    this.cmdLaunchWISDOM.Enabled = false;
                    this.cmdSendFilesToLCL.Enabled = false;
                    this.cmdWrapUp.Enabled = false;
                    this.cmdPostTagRange.Enabled = false;
                    dmUtility.AddUpdateJobState(this.labelControl2.Text, 1, Environment.UserName);
                }
            }
        }

        private void cmdPullTerminalFiles_Click(object sender, EventArgs e)
        {
            DataModule dmUtility = new DataModule();
            WIS.SysLib.AppSettings MyAppSet = new WIS.SysLib.AppSettings(Application.ExecutablePath + ".Config", true);

            string hostname = MyAppSet.Item("hostname").Value.ToString();
            string username = MyAppSet.Item("username").Value.ToString();
            string password = MyAppSet.Item("password").Value.ToString();

            Sftp client = new Sftp();
//            Defaults.Initialize();
            try
            {
                client.Connect(hostname);
                client.Login(username, password);
                client.ChangeDirectory("TerminalFiles");
                client.ChangeDirectory(this.labelControl2.Text);

                bool exist = System.IO.Directory.Exists(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(MyAppSet.Item("wisdompath").Value.ToString(), this.labelControl2.Text), this.labelControl4.Text),MyAppSet.Item("downloadfolder").Value.ToString()));
//                bool exist = System.IO.Directory.Exists(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot,"JOBS"), this.labelControl2.Text), this.labelControl4.Text), MyAppSet.Item("downloadfolder").Value.ToString()));
                if (!exist)
                {
//                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(MyAppSet.Item("wisdompath").Value.ToString(), this.labelControl2.Text), this.labelControl4.Text), MyAppSet.Item("downloadfolder").Value.ToString()));
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot, "JOBS"), this.labelControl2.Text), this.labelControl4.Text), MyAppSet.Item("downloadfolder").Value.ToString()));
                }
                string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(MyAppSet.Item("wisdompath").Value.ToString(), this.labelControl2.Text), this.labelControl4.Text), MyAppSet.Item("downloadfolder").Value.ToString());
//                string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot, "JOBS"), this.labelControl2.Text), this.labelControl4.Text), MyAppSet.Item("downloadfolder").Value.ToString());
                SftpItemCollection list = client.GetList();
                foreach (SftpItem item in list)
                {
                    client.GetFile(item.Name, System.IO.Path.Combine(Outputpath, item.Name));
                }

                this.cmdPullSoftware.Enabled = true;
                this.cmdPullTerminalFiles.Enabled = false;
                dmUtility.AddUpdateJobState(this.labelControl2.Text, 2, Environment.UserName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Disconnect();
            }
        }

        private void CreateWEBTagFile()
        {
            WIS.SysLib.AppSettings MyAppSet = new WIS.SysLib.AppSettings(Application.ExecutablePath + ".Config", true);
//            Defaults.Initialize();

            SqlConnection conn = new SqlConnection(MyAppSet.Item("WEBWISDOM_CONNSTRING").Value.ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rdr = default(SqlDataReader);
            string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(MyAppSet.Item("wisdompath").Value.ToString(), this.labelControl2.Text), this.labelControl4.Text);
//            string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot, "JOBS"), this.labelControl2.Text), this.labelControl4.Text);
            System.IO.TextWriter OutputFile = System.IO.File.CreateText(System.IO.Path.Combine(Outputpath, MyAppSet.Item("importtagfilename").Value.ToString()));
            string OutString = null;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "EXEC dbo.GetTagRangesForAJob @JobNo = " + this.labelControl2.Text;
                cmd.CommandTimeout = 120;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    OutString = labelControl2.Text + "|" + rdr.GetInt32(0).ToString() + "|" + rdr.GetInt32(1).ToString() + "|5|" + rdr.GetString(2) + "|" + rdr.GetInt32(0).ToString() + "-" + rdr.GetInt32(1).ToString();
                    OutputFile.WriteLine(OutString);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
                OutputFile.Close();
            }
        }

        private void cmdPullSoftware_Click(object sender, EventArgs e)
        {
            DataModule dmUtility = new DataModule();
            Defaults.Initialize();

            if (labelControl2.Text.Trim().Length > 0)
            {
                string mJobNo;
                string mSID;
                string mIID;

                mJobNo = labelControl2.Text + ".zip";
                mSID = labelControl4.Text + ".sdl";
                mIID = labelControl6.Text + ".zip";

                WIS.WISDOM.Defaults.Initialize();

                try
                {
                    //                    WISDOMDownload(mJobNo, WIS.WISDOM.Defaults.SDLFolder, true);
                    WISDOMDownload(mSID, System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMFolder, "SDL"), false);
                    WISDOMDownload(mIID, System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMFolder, "SDL"), false);
//                    WISDOMDownload(mSID, System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot, "SDL"), false);
  //                  WISDOMDownload(mIID, System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot, "SDL"), false);
                    CreateWEBTagFile();
                    this.cmdLaunchWISDOM.Enabled = true;
                    this.cmdPullSoftware.Enabled = false;
                    dmUtility.AddUpdateJobState(this.labelControl2.Text, 3, Environment.UserName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a job to continue");
            }
        }

        private void cmdLaunchWISDOM_Click(object sender, EventArgs e)
        {

            string mJobNo;
            DataModule dmUtility = new DataModule();

            mJobNo = labelControl2.Text;


            WIS.WISDOM.Defaults.Initialize();

            System.Xml.XmlDocument WJ = GetJobInfo(Convert.ToInt32(mJobNo), false);

            string TmpName = System.IO.Path.GetTempFileName();
            WJ.Save(TmpName);

//            System.Diagnostics.Process P = System.Diagnostics.Process.Start("C:\\WISDOM-LCL\\BIN.2011\\WISDOMLauncher.exe", TmpName);
            System.Diagnostics.Process P = System.Diagnostics.Process.Start("C:\\WISDOM\\BIN.2011\\WISDOMLauncher.exe", TmpName);
            
            P.WaitForExit();
//            this.cmdLaunchWISDOM.Enabled = false;
            this.cmdSendFilesToLCL.Enabled = true;
            dmUtility.AddUpdateJobState(this.labelControl2.Text, 4, Environment.UserName);

            return;
        }

        public void email_send(string[] Attachments)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("barracuda1.wisintl.com");
//            SmtpClient SmtpServer = new SmtpClient("outlook.wisintl.com");
            mail.From = new MailAddress("tpooni@wisintl.com");
            mail.To.Add("tpooni@wisintl.com");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";

            System.Net.Mail.Attachment attachment;
//          attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            if ((Attachments != null))
            {
                for (Int32 i = 0; i <= Attachments.Length - 1; i++)
                {
                    if (System.IO.File.Exists(Attachments[i]))
                    {
                        mail.Attachments.Add(new System.Net.Mail.Attachment(Attachments[i]));
                    }
                }
            }

            SmtpServer.Port = 587;
//            SmtpServer.Credentials = new System.Net.NetworkCredential("afps@wisintl.com", "Sn@@p1ng","WIS");
//            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        public void sendEMailThroughOUTLOOK(string[] Attachments)
        {
            try
            {
                // Create the Outlook application.
                Outlook.Application oApp = new Outlook.Application();
                // Create a new mail item.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
                // Set HTMLBody. 
                //add the body of the email
                oMsg.HTMLBody = "LCL Files";
                //Add an attachment.
                String sDisplayName = "MyAttachment";
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //now attached the file
                if ((Attachments != null))
                {
                    for (Int32 i = 0; i <= Attachments.Length - 1; i++)
                    {
                        if (System.IO.File.Exists(Attachments[i]))
                        {
                            Outlook.Attachment oAttach = oMsg.Attachments.Add(Attachments[i], iAttachType, iPosition, sDisplayName);
//                            mail.Attachments.Add(new System.Net.Mail.Attachment(Attachments[i]));
                        }
                    }
                }
//                Outlook.Attachment oAttach = oMsg.Attachments.Add(@"C:\\fileName.jpg", iAttachType, iPosition, sDisplayName);
                //Subject line
                oMsg.Subject = "LCR LCL Reports";
                // Add a recipient.
                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(this.labelControl14.Text);
                Outlook.Recipient oRecip2 = (Outlook.Recipient)oRecips.Add("textreports@wisintl.com");
                oRecip.Resolve();
                // Send.
                oMsg.Send();
                // Clean up.
                oRecip = null;
                oRecip2 = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }//end of try block
            catch (Exception ex)
            {
            }//end of catch
        }//end of Email Method
        
        private void cmdSendFilesToLCL_Click(object sender, EventArgs e)
        {
            DataModule dmUtility = new DataModule();
            WIS.SysLib.AppSettings MyAppSet = new WIS.SysLib.AppSettings(Application.ExecutablePath + ".Config", true);
//            Defaults.Initialize();
            string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(MyAppSet.Item("wisdompath").Value.ToString(), this.labelControl2.Text), this.labelControl4.Text);
            System.IO.File.Delete(System.IO.Path.Combine(System.IO.Path.Combine(Outputpath, MyAppSet.Item("workingfolder").Value.ToString()), this.labelControl2.Text + ".BAK1"));
            System.IO.File.Delete(System.IO.Path.Combine(System.IO.Path.Combine(Outputpath, MyAppSet.Item("workingfolder").Value.ToString()), this.labelControl2.Text + ".BAK2"));

//            string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot, "JOBS"), this.labelControl2.Text), this.labelControl4.Text);

          //  email_send(System.IO.Directory.GetFiles(System.IO.Path.Combine(Outputpath, MyAppSet.Item("workingfolder").Value.ToString())));
            if (System.IO.Directory.GetFiles(System.IO.Path.Combine(Outputpath, MyAppSet.Item("workingfolder").Value.ToString())).Count() < 6) {
                if (MessageBox.Show("Total created reports are less than six. Are you sure you want to continue?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                sendEMailThroughOUTLOOK(System.IO.Directory.GetFiles(System.IO.Path.Combine(Outputpath, MyAppSet.Item("workingfolder").Value.ToString())));
                } 
            } else
                sendEMailThroughOUTLOOK(System.IO.Directory.GetFiles(System.IO.Path.Combine(Outputpath, MyAppSet.Item("workingfolder").Value.ToString())));
            this.cmdLaunchWISDOM.Enabled = false;
            this.cmdSendFilesToLCL.Enabled = false;
            this.cmdWrapUp.Enabled = true;
            dmUtility.AddUpdateJobState(this.labelControl2.Text, 5, Environment.UserName);
        }

        private void CreateTagFile()
        {
            DataModule dmUtility = new DataModule();
            WIS.SysLib.AppSettings MyAppSet = new WIS.SysLib.AppSettings(Application.ExecutablePath + ".Config", true);
//            Defaults.Initialize();

            string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(MyAppSet.Item("wisdompath").Value.ToString(), this.labelControl2.Text), this.labelControl4.Text);
//            string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot, "JOBS"), this.labelControl2.Text), this.labelControl4.Text);
            string JobMDBPath = System.IO.Path.Combine(Outputpath, labelControl2.Text + ".mdb");
            System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(WIS.WISE.WISEData.getConnectionString(JobMDBPath));
            try
            {
                cnn.Open();
                string sqlcmd = MyAppSet.Item("tagrangesql").Value.ToString();
//                string sqlcmd = "SELECT tblTagRange.TagValFrom, tblTagRange.TagValTo, tblTagRange.GroupRangeID, tblTagRange.Name, tblTagRange.Description FROM tblTagRange WHERE Deleted = 0";
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(sqlcmd, cnn);
                Int32 RecordCount = 0;

                System.Data.OleDb.OleDbDataReader Reader = cmd.ExecuteReader();

                string OutputFileName = System.IO.Path.Combine(System.IO.Path.Combine(Outputpath, MyAppSet.Item("workingfolder").Value.ToString()), MyAppSet.Item("tagfilename").Value.ToString()) + this.labelControl12.Text.Trim().PadLeft(5, '0') + ".TXT";
                System.IO.TextWriter OutputFile = System.IO.File.CreateText(OutputFileName);
                string OutString = null;
                while (Reader.Read())
                {
                    OutString = labelControl2.Text + "|" + Reader.GetInt32(0).ToString() + "|" + Reader.GetInt32(1).ToString() + "|" + Reader.GetInt32(2).ToString() + "|" + Reader.GetString(3) + "|" + Reader.GetString(4);
                    //                    OutString = Reader.GetString(0).PadLeft(3, "0") + Strings.Mid(Reader.GetString(1).Trim.Replace(",", " ").PadRight(11, " "), 1, 11);
                    OutputFile.WriteLine(OutString);
                    RecordCount = RecordCount + 1;
                }
                OutputFile.Close();
                PostFilestoFTP(OutputFileName);
                dmUtility.AddUpdateJobState(this.labelControl2.Text, 5, Environment.UserName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        private void CreateTableDetailFile()
        {
            WIS.SysLib.AppSettings MyAppSet = new WIS.SysLib.AppSettings(Application.ExecutablePath + ".Config", true);
//            Defaults.Initialize();
            string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(MyAppSet.Item("wisdompath").Value.ToString(), this.labelControl2.Text), this.labelControl4.Text);
//            string Outputpath = System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(WIS.WISDOM.Defaults.WISDOMDataRoot, "JOBS"), this.labelControl2.Text), this.labelControl4.Text);
            string JobMDBPath = System.IO.Path.Combine(Outputpath, labelControl2.Text + ".mdb");
            System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(WIS.WISE.WISEData.getConnectionString(JobMDBPath));
            try
            {
                cnn.Open();
                string sqlcmd = MyAppSet.Item("tbldetailssql").Value.ToString();
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(sqlcmd, cnn);
                Int32 RecordCount = 0;

                System.Data.OleDb.OleDbDataReader Reader = cmd.ExecuteReader();

                string OutputFileName = System.IO.Path.Combine(System.IO.Path.Combine(Outputpath, MyAppSet.Item("workingfolder").Value.ToString()), MyAppSet.Item("tbldetailsfilename").Value.ToString()) + this.labelControl12.Text.Trim().PadLeft(5, '0') + ".TXT";
                System.IO.TextWriter OutputFile = System.IO.File.CreateText(OutputFileName);
                string OutString = null;
                while (Reader.Read())
                {
                    OutString = labelControl2.Text + "|" + Reader.GetString(0) + "|" + Reader.GetString(1) + "|" + Reader.GetString(2) + "|" + Reader.GetString(3) + "|" + Reader.GetBoolean(4).ToString() + "|" + Reader.GetString(5) + "|" + Reader.GetString(6) + "|" + Reader.GetString(7) + "|" + Reader.GetString(8) + "|" + Reader.GetString(9) + "|" + Reader.GetString(10) + "|" + Reader.GetString(11) + "|" + Reader.GetString(12) + "|" + Reader.GetString(13) + "|" + Reader.GetDouble(14).ToString() + "|" + Reader.GetInt32(15).ToString() + "|" + Reader.GetDateTime(16).ToString();
                    //                    OutString = Reader.GetString(0).PadLeft(3, "0") + Strings.Mid(Reader.GetString(1).Trim.Replace(",", " ").PadRight(11, " "), 1, 11);
                    OutputFile.WriteLine(OutString);
                    RecordCount = RecordCount + 1;
                }
                OutputFile.Close();
                PostFilestoFTP(OutputFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        private void PostFilestoFTP(string filetopost)
        {
            WIS.SysLib.AppSettings MyAppSet = new WIS.SysLib.AppSettings(Application.ExecutablePath + ".Config", true);

            string hostname = MyAppSet.Item("hostname").Value.ToString();
            string username = MyAppSet.Item("username").Value.ToString();
            string password = MyAppSet.Item("password").Value.ToString();

            Sftp client = new Sftp();
            WIS.WISDOM.Defaults.Initialize();
            try
            {
                client.Connect(hostname);
                client.Login(username, password);
                client.ChangeDirectory("inbox");
                client.PutFile(filetopost, System.IO.Path.GetFileName(filetopost));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Disconnect();
            }
        }

        private void cmdWrapUp_Click(object sender, EventArgs e)
        {
            DataModule dmUtility = new DataModule();
            CreateTableDetailFile();
            MessageBox.Show("Pre-Count File Posted");
            this.cmdPostTagRange.Enabled = true;
            dmUtility.AddUpdateJobState(this.labelControl2.Text, 6, Environment.UserName);
        }

        private void unConfirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drv = null;
            string JobNo;
            drv = (DataRowView)this.grdJobSchedule.BindingContext[this.grdJobSchedule.DataSource].Current;
            JobNo = drv["Job_No"].ToString();
            DataModule dmUtility = new DataModule();

            if (drv["Confirmed"].ToString() != "1")
                MessageBox.Show("Job is not confirmed, Nothing to do.");
            else
            {
                if (MessageBox.Show("Are you sure you want Un_Confirm Job " + JobNo + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dmUtility.RollbackJobConfirmation(JobNo);
                    MessageBox.Show("Done");
                    RefreshGrid();
                }
                else
                {
                    dmUtility.RollbackJobConfirmation(JobNo);
                    MessageBox.Show("Done");
                    RefreshGrid();
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmdPostTagRange_Click(object sender, EventArgs e)
        {
            DataModule dmUtility = new DataModule();
            CreateTagFile();
            MessageBox.Show("Tag Range File Posted");
            dmUtility.AddUpdateJobState(this.labelControl2.Text, 7, Environment.UserName);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
