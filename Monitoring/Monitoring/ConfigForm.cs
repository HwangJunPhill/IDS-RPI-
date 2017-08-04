using Monitoring.Properties;
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

namespace Monitoring
{

    public partial class ConfigForm : Form
    {
        List<Options> Options = new List<Options>();
        List<Sensor> Sensor = new List<Sensor>();
        List<CheckBox> checkBoxes = new List<CheckBox>();

        Settings settings => Settings.Default;

        public ConfigForm()
        {
            Options = JsonConvert.DeserializeObject<List<Options>>(settings.Options) ?? new List<Options>();
            Sensor = JsonConvert.DeserializeObject<List<Sensor>>(settings.Sensor) ?? new List<Sensor>();

            InitializeComponent();

            if(Options.Count > 0)
            {
                alertCheckBox.Checked = Options[0].alert;
                saveLogCheckBox.Checked = Options[0].saveLog;
                imgSourceTextBox.Text = Options[0].imgSource;
            }

            if (Sensor.Count > 0)
            {
                numericUpDown.Value = Convert.ToDecimal(Sensor[0].cycle);
                checkBox1.Checked = Sensor[0].s1;
                textBox1.Text = Sensor[0].s1m;
                checkBox2.Checked = Sensor[0].s2;
                textBox2.Text = Sensor[0].s2m;
                checkBox3.Checked = Sensor[0].s3;
                textBox3.Text = Sensor[0].s3m;
                checkBox4.Checked = Sensor[0].s4;
                textBox4.Text = Sensor[0].s4m;
                checkBox5.Checked = Sensor[0].s5;
                textBox5.Text = Sensor[0].s5m;
                checkBox6.Checked = Sensor[0].s6;
                textBox6.Text = Sensor[0].s6m;
                checkBox7.Checked = Sensor[0].s7;
                textBox7.Text = Sensor[0].s7m;
                checkBox8.Checked = Sensor[0].s8;
                textBox8.Text = Sensor[0].s8m;
            }

            checkBoxes.Add(checkBox1);
            checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3);
            checkBoxes.Add(checkBox4);
            checkBoxes.Add(checkBox5);
            checkBoxes.Add(checkBox6);
            checkBoxes.Add(checkBox7);
            checkBoxes.Add(checkBox8);

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgSourceTextBox.Text = openFileDialog.FileName;
            }
        }

        private void alertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var x = sender as CheckBox;

            Console.WriteLine(x.Checked);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Options.Count == 0)
            {
                Options.Add(new Options { alert = alertCheckBox.Checked, saveLog = saveLogCheckBox.Checked, imgSource = imgSourceTextBox.Text });
            }

            else
            {
                Options[0].alert = alertCheckBox.Checked;
                Options[0].saveLog = saveLogCheckBox.Checked;
                Options[0].imgSource = imgSourceTextBox.Text;
            }

            settings.Options = JsonConvert.SerializeObject(Options);
            settings.Save();
        }

        private void sensorCheckChanged(object sender, EventArgs e)
        {
            var sensorCheck = sender as CheckBox;
            if (sensorCheck.Checked == true)
            {
                sensorCheck.ForeColor = System.Drawing.Color.LimeGreen;
            }

            else if (sensorCheck.Checked == false)
            {
                sensorCheck.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void sensorCheckClick(object sender, EventArgs e)
        {
            var sensorCheck = sender as CheckBox;
            int senNo = Convert.ToInt16(sensorCheck.Name[8]);

            if (sensorCheck.Checked == true)
            {
                DialogResult dia = MessageBox.Show(sensorCheck.Text + "를 활성화하시겠습니까?", sensorCheck.Text, MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
                    sensorCheck.Checked = true;

                    //활성화 패킷 전송              
                    byte[] datas = new byte[24];
                    //datas = makePacket(datas, 2, 1, 1, "ON");
                }
                else
                {
                    sensorCheck.Checked = false;
                }
            }

            else if (sensorCheck.Checked == false)
            {
                DialogResult dia = MessageBox.Show(sensorCheck.Text + "를 비활성화하시겠습니까?", sensorCheck.Text, MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
                    byte[] datas = new byte[24];
                    datas = makePacket(datas, 2, 1, 1, "OFF");
                    sensorCheck.Checked = false;
                }
                else
                {
                    sensorCheck.Checked = true;
                }
            }

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(Sensor[0].cycle) != numericUpDown.Value)
            {
                //반복문으로 8번 보내
                byte[] datas = new byte[24];
                //datas = makePacket(datas, 3, 1, 1, numericUpDown.Value.ToString());
            }
        }

        private byte[] makePacket(byte[] packet, int flag, int sys_id, int sen_id, string data)
        {
            byte[] tmp;

            DateTime now = DateTime.Now;
            DateTime std = DateTime.Parse("1970-01-01 09:00:00");

            TimeSpan ts = now - std;

            long timestamp = ts.Ticks;
            int index = 0;

            tmp = BitConverter.GetBytes(flag);
            for(int i = 0; i < tmp.Length; i++)
            {
                packet[i] = tmp[i];
            }
            index += tmp.Length;

            tmp = BitConverter.GetBytes(sys_id);
            for(int i = 0; i < tmp.Length; i++)
            {
                packet[i + index] = tmp[i];
            }
            index += tmp.Length;


            tmp = BitConverter.GetBytes(sen_id);
            for(int i = 0; i < tmp.Length; i++)
            {
                packet[i + index] = tmp[i];
            }
            index += tmp.Length;

            tmp = BitConverter.GetBytes(timestamp);
            for(int i = 0; i < tmp.Length; i++)
            {
                packet[i + index] = tmp[i];
            }
            index += tmp.Length;

            tmp = Encoding.Default.GetBytes(data);
            for(int i = 0; i < tmp.Length; i++)
            {
                packet[i + index] = tmp[i];
            }

            return sendPacket(packet);
        }

        private byte[] sendPacket(byte[] packet)
        {

            MainForm.tcpSocket.Send(packet);
            System.Array.Clear(packet, 0, packet.Length);

            return packet;
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Sensor.Count == 0)
            {
                Sensor.Add(new Sensor
                {
                    cycle = Convert.ToInt32(numericUpDown.Value),
                    s1 = checkBox1.Checked,
                    s1m = textBox1.Text,
                    s2 = checkBox2.Checked,
                    s2m = textBox2.Text,
                    s3 = checkBox3.Checked,
                    s3m = textBox3.Text,
                    s4 = checkBox4.Checked,
                    s4m = textBox4.Text,
                    s5 = checkBox5.Checked,
                    s5m = textBox5.Text,
                    s6 = checkBox6.Checked,
                    s6m = textBox6.Text,
                    s7 = checkBox7.Checked,
                    s7m = textBox7.Text,
                    s8 = checkBox8.Checked,
                    s8m = textBox8.Text
                }
                );
            }

            else
            {
                Sensor[0].cycle = Convert.ToInt32(numericUpDown.Value);
                Sensor[0].s1 = checkBox1.Checked;
                Sensor[0].s1m = textBox1.Text;
                Sensor[0].s2 = checkBox2.Checked;
                Sensor[0].s2m = textBox2.Text;
                Sensor[0].s3 = checkBox3.Checked;
                Sensor[0].s3m = textBox3.Text;
                Sensor[0].s4 = checkBox4.Checked;
                Sensor[0].s4m = textBox4.Text;
                Sensor[0].s5 = checkBox5.Checked;
                Sensor[0].s5m = textBox5.Text;
                Sensor[0].s6 = checkBox6.Checked;
                Sensor[0].s6m = textBox6.Text;
                Sensor[0].s7 = checkBox7.Checked;
                Sensor[0].s7m = textBox7.Text;
                Sensor[0].s8 = checkBox8.Checked;
                Sensor[0].s8m = textBox8.Text;
            }

            settings.Options = JsonConvert.SerializeObject(Options);
            settings.Sensor = JsonConvert.SerializeObject(Sensor);
            settings.Save();
        }
    }


}
