using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class SalesGraph : Form
    {
        public SalesGraph()
        {
            InitializeComponent();
            cmbitem();
            graphval();
        }
        void cmbitem()
        {
            int x;
            for(x=1;x<=10; x++)
            {
                comboBox1.Items.Add(x+2010);
            }
        }
        void graphval()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            int x;
            int rdv;
            for (x = 1; x <= 12; x++)
            {
                string date = x.ToString();
                string strconn = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection conn = new MySqlConnection(strconn);
                MySqlCommand cmd1 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '" + date + "%' and Date like '%" + comboBox1.Text + "'", conn);
                MySqlDataReader rd;
                try
                {
                    conn.Open();
                    rd = cmd1.ExecuteReader();
                    while (rd.Read())
                    {
                        string r = "";
                        if (x == 1)
                            r = "January";
                        if (x == 2)
                            r = "February";
                        if (x == 3)
                            r = "March";
                        if (x == 4)
                            r = "April";
                        if (x == 5)
                            r = "May";
                        if (x == 6)
                            r = "June";
                        if (x == 7)
                            r = "Julyy";
                        if (x == 8)
                            r = "August";
                        if (x == 9)
                            r = "September";
                        if (x == 10)
                            r = "October";
                        if (x == 11)
                            r = "November";
                        if (x == 12)
                            r = "December";
                        int.TryParse(rd[0].ToString(), out rdv);
                        this.chart1.Series["Series1"].Points.AddXY("" + r + "", rdv);
                    }
                    conn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            graphval();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            new Sales().Show();
            this.Hide();
        }
    }
}
