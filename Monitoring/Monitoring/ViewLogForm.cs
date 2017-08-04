using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring
{
    public partial class ViewLogForm : Form
    {
        Connection db;
        private DataSet data;

        public ViewLogForm()
        {
            InitializeComponent();

            comboBox.SelectedIndex = 0;

            db = new Connection();
        }

        private void lookupButton_Click(object sender, EventArgs e)
        {
            string query = MakeQuery(comboBox.SelectedIndex, checkBox.Checked);
            data = db.SelectData(query);
            logListView.Items.Clear();

            if (data.Tables.Count > 0)
            {
                foreach (DataRow r in data.Tables[0].Rows)
                {
                    

                    Console.Write(r["sensorid"].ToString());
                    Console.Write(r["time"] + " ");
                    Console.WriteLine(r["isIn"]);

                    //ListViewItem logs = new ListViewItem(r["sensor"].ToString());
                    //logs.SubItems.Add(r["time"].ToString());
                    //logs.SubItems.Add(r["isIn"].ToString());

                    ListViewItem logs = new ListViewItem(Convert.ToString(r["sensorid"]));
                    logs.SubItems.Add(Convert.ToString(r["time"]));
                    logs.SubItems.Add(Convert.ToString(r["isIn"]));

                    logListView.Items.Add(logs);
                }
            }
        }

        private string MakeQuery(int index, bool whether)
        {
            string query = "";

            if(index == 0)
            {
                query = "select * from log ";
                if(whether == true)
                {
                    query += " where isIn = \"YES\"";
                }
            }

            else
            {
                query = string.Format("select * from log where sensorid = {0}", index);

                if(whether == true)
                {
                    query += " and isIn = \"YES\"";
                }
            }

            return query;
        }
    }
}
