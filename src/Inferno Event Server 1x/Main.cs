using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Timers;
using System.Net.Mail;

namespace Inferno_Event_Server_1x
{
    public partial class Main : Form
    {
        SqlConnection _myConnection, _myConnection1;
        System.Timers.Timer _myTimer;

        public Main()
        {
            InitializeComponent();
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            string userId = userid.Text;
            string passwd = pass.Text;
            string host_name = hostName.Text;
            
            if (ConnectSqlServer(host_name, userId, passwd))
            {
                startButton.Enabled = false;
                stopButton.Enabled = true;
                userid.Enabled = false;
                pass.Enabled = false;
                hostName.Enabled = false;
                double randomTime = GetRandomNumber();
                StartServer(randomTime);
            }
            else
                MessageBox.Show("Could not connect to MSSQL server!", "Inferno Event Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ConnectSqlServer(string host, string userId, string password)
        {
            _myConnection = new SqlConnection("user id=" + userId + ";password=" + password + ";server=" + host + ";Trusted_Connection=yes;database=ASD;connection timeout=30");
            _myConnection1 = new SqlConnection("user id=" + userId + ";password=" + password + ";server=" + host + ";Trusted_Connection=yes;database=A3ItemEvent;connection timeout=30");
            try
            {
                _myConnection.Open();
                _myConnection1.Open();
                WriteLog("Connection established!");
                return true;
            }
            catch (Exception e)
            {
                WriteLog("ERROR in connecting to MSSQL. Error details :::::::::: " + e.Message);
                return false;
            }
        }

        private void StopServer()
        {
            _myTimer.Stop();
            _myTimer.Close();
            _myConnection.Close();
            _myConnection1.Close();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            userid.Enabled = true;
            pass.Enabled = true;
            hostName.Enabled = true;
        }

        private void StartServer(double rTime)
        {
            WriteLog("INFO :::::::: Gifting will happen in " + (rTime / 60000).ToString() + " minutes!");
            _myTimer = new System.Timers.Timer(rTime);
            _myTimer.Elapsed += DoGifting;
            _myTimer.AutoReset = false;
            _myTimer.Enabled = true;
        }

        private void DoGifting(object source, ElapsedEventArgs e)
        {
            try
            {
                SqlDataReader myReader = null;
                var myCommand = new SqlCommand("select count(*) as count from charac0 where online = 1", _myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    int onlinePlayerCount = 0;
                    while (myReader.Read())
                    {
                        var r = (IDataRecord)myReader;
                        onlinePlayerCount = Convert.ToInt32(r[0].ToString());
                        break;
                    }
                    myReader.Close();
                    if (onlinePlayerCount > 5) // Minimum online player required for gifting is greater than 5
                    {
                        var myCommand1 = new SqlCommand("SELECT TOP 1 c_id, c_sheaderc FROM charac0 where online = 1 ORDER BY NEWID()", _myConnection);
                        SqlDataReader myReader1 = myCommand1.ExecuteReader();
                        string playerName = "";
                        int playerLevel = 0;
                        while (myReader1.Read())
                        {
                            var r1 = (IDataRecord)myReader1;
                            playerName = r1[0].ToString().Trim();
                            playerLevel = Convert.ToInt32(r1[1].ToString());
                            break;
                        }
                        myReader1.Close();
                        string giftCode = "";
                        while (true)
                        {
                            giftCode = GetGiftCode();
                            var myCommand4 = new SqlCommand("select count(*) as count from SerialList where SerialNo = '" + giftCode + "'", _myConnection1);
                            SqlDataReader myReader4 = myCommand4.ExecuteReader();
                            int count = 1;
                            while (myReader4.Read())
                            {
                                var r4 = (IDataRecord)myReader4;
                                count = Convert.ToInt32(r4[0].ToString());
                                break;
                            }
                            myReader4.Close();
                            if (count == 0)
                                break;
                        }
                        string giftWz = GetGiftWz(playerLevel);
                        var myCommand2 = new SqlCommand("insert into SerialList(SerialNo, ItemInfo, Parameter1, Parameter2, Type, UsedFlag, ExpireDate) values('" + giftCode + "', '1', '" + giftWz + "', '0', '1', '0', '2014-01-01 00:00:00.000')", _myConnection1);
                        SqlDataReader myReader2 = myCommand2.ExecuteReader();
                        myReader2.Close();
                        var myCommand3 = new SqlCommand("insert into online_gift(character, gift_code, gift_time) values('" + playerName + "', '" + giftCode + "', '" + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "')", _myConnection);
                        SqlDataReader myReader3 = myCommand3.ExecuteReader();
                        myReader3.Close();
                        var url = "http://yourserver.com/mailer.php?char=" + playerName + "&gift=" + giftCode;
                        DoHttpGetRequest(url);
                        WriteLog("INFO :::::::: Character named " + playerName + " with level " + playerLevel.ToString() + " has been scheduled to gift by random event manager!");
                    }
                    else
                        WriteLog("INFO ::::::: No player was gifted because of low player online count!");
                }
                double randomTime = GetRandomNumber();
                StartServer(randomTime);
            }
            catch (Exception ex)
            {
                WriteLog("ERROR :::::::::: " + ex.Message);
                double randomTime = GetRandomNumber();
                StartServer(randomTime);
            }
        }

        private static void DoHttpGetRequest(string url)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            resp.Close();
        }

        private static string GetGiftCode()
        {
            string rStr = "";
            while(true)
            {
                rStr = rStr + Path.GetRandomFileName();
                rStr = rStr.Replace(".", "");
                if (rStr.Length > 20)
                {
                    rStr = rStr.Substring(0, 20);
                    break;
                }
            }
            return rStr;
        }

        private static string GetGiftWz(int lvl)
        {
            double wz = 0;
            if (lvl <= 20)
            {
                System.Threading.Thread.Sleep(1);
                var rn = new Random(DateTime.Now.Millisecond);
                wz = rn.Next(10000, 500000);
            }
            else if (lvl > 20 && lvl <= 50)
            {
                System.Threading.Thread.Sleep(1);
                var rn = new Random(DateTime.Now.Millisecond);
                wz = rn.Next(100000, 1000000);
            }
            else if (lvl > 50 && lvl <= 100)
            {
                System.Threading.Thread.Sleep(1);
                var rn = new Random(DateTime.Now.Millisecond);
                wz = rn.Next(500000, 3000000);
            }
            else if (lvl > 100 && lvl <= 140)
            {
                System.Threading.Thread.Sleep(1);
                var rn = new Random(DateTime.Now.Millisecond);
                wz = rn.Next(1000000, 3500000);
            }
            else
            {
                System.Threading.Thread.Sleep(1);
                var rn = new Random(DateTime.Now.Millisecond);
                wz = rn.Next(1000000, 5000000);
            }
            return wz.ToString();
        }

        private static double GetRandomNumber()
        {
            System.Threading.Thread.Sleep(1);
            var rn = new Random(DateTime.Now.Millisecond);
            return rn.Next(60000, 43200000);            
        }

        private static void WriteLog(string log)
        {
            using (var sw = new StreamWriter("EventServer.log", true))
            {
                sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt") + " : " + log);
            }
        }

        private void StopButtonClick(object sender, EventArgs e)
        {
            WriteLog("INFO :::::::: Server manually stopped!");
            StopServer();
        }
    }
}
