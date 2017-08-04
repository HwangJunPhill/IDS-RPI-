using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Monitoring.Properties;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Monitoring
{
    public partial class MainForm : Form
    {
        public static Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //TCP IDS
        public static IPEndPoint ipep = new IPEndPoint(IPAddress .Parse("192.168.137.10"), 3416);

        //TCP LOCAL
        //public static IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

        public static DateTime stdTime = DateTime.Parse("1970-01-01 09:00:00");

        List<Options> Options = new List<Options>();
        List<Label> Labels = new List<Label>();
        Settings settings => Settings.Default;

        private bool isMove;
        Point labelPoint;
        
        private DataSet data;
        Connection db;

        public MainForm()
        {
            InitializeComponent();

            db = new Connection();

            Options = JsonConvert.DeserializeObject<List<Options>>(settings.Options) ?? new List<Options>();

            //try
            //{
            //    tcpSocket.Connect(ipep);
            //}
            //catch
            //{
            //    MessageBox.Show("서버와의 연결이 원활하지 않습니다.");
            //    //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //}

            //Thread getThread = new Thread(new ThreadStart(getPacket));
            //getThread.Start();

            drawChart();

            lastInsLabel.Text = "2017-08-04 10:06:37";

        }

        private void drawChart()
        {
            string query;
            for (int i = 1; i < 9; i++)
            {
                query = string.Format("select count(*) from log where sensorid = {0} and isIn = \"YES\"", i);
                data = db.SelectData(query);

                if (data.Tables.Count > 0)
                {
                    foreach (DataRow r in data.Tables[0].Rows)
                    {
                        double b = Convert.ToDouble(r.ItemArray[0]);
                        chart.Series["series1"].Points.Add(b);
                    }
                }
            }


        }

        private void setLabels()
        {
            Labels.Add(sensorLabel1);
            Labels.Add(sensorLabel2);
            Labels.Add(sensorLabel3);
            Labels.Add(sensorLabel4);
            Labels.Add(sensorLabel5);
            Labels.Add(sensorLabel6);
            Labels.Add(sensorLabel7);
            Labels.Add(sensorLabel8);
        }

        private void getPacket()
        {
            byte[] packet = new byte[1024];
            while(true) 
            {
                try
                {
                    tcpSocket.Receive(packet);
                }

                catch
                {
                    MessageBox.Show("서버와의 연결이 원활하지 않습니다. ");
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }

                if (tcpSocket.Connected == true)
                {
                    string data = Encoding.Default.GetString(packet);
                    MessageBox.Show(data);
                }
                //조건문 이후 어떤 함수를 호출할지 결정.
            }
        }

        private void InvInfo()
        {
            //침입인지 아닌지 식별.
            //침입이 아니라면 로그 저장 규칙에 따라 로그 저장하거나 저장하지 않음
            //침입이라면 알림 규칙에 따라 경고창을 띄우거나 띄우지 않음
            //침입이라면 침입한 센서의 라벨을 잠시동안 붉게 변함
        }

        private void setCycle()
        {
            //받은 값으로 옵션에서 cycle 값 변경.
        }

        private void sensorOnOff()
        {
            //센서 번호와 온오프 여부를 옵션에서 변경.
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            ConfigForm con = new ConfigForm();
            con.ShowDialog();
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            ViewLogForm vie = new ViewLogForm();
            vie.Show();
        }

        private void sensorLabel_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            labelPoint = new Point(e.X, e.Y);
        }

        private void sensorLabel_MouseMove(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                label.Location = new Point(label.Left - (labelPoint.X - e.X), label.Top - (labelPoint.Y - e.Y));
            }
        }

        private void sensorLabel_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
