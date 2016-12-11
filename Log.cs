/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 1:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
	/// <summary>
	/// Description of Log.
	/// </summary>
	public partial class Log : Form
	{
        Menu ths;
        string c;
		public Log()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        void checkedb()
        {
            if (checkBox2.Checked == true)
            {
                c = checkBox2.Text;
            }
            if (checkBox1.Checked == true)
            {
                c = checkBox1.Text;
            }
        }
		
		void Button1Click(object sender, EventArgs e)
		{
			string strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select * from project.login where user = '"+textBox1.Text+"' and pass = '"+textBox2.Text+"' and position = '"+c+"' ",conn);
			conn.Open();
			MySqlDataReader rdr = cmd.ExecuteReader();
			try
			{
			int count = 0;
			while(rdr.Read())
			{
				count = count+1;
			}

			if(count ==1)
			{
				MessageBox.Show("Successfully Login","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ths = new Menu();
                    ths.Show();
                    this.Hide();
                    ths.logc = c;
                conn.Close();
			}
			else
			{
				MessageBox.Show("Invalid Username or Password");
			}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void LogLoad(object sender, EventArgs e)
		{			
		}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
            checkedb();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
            checkedb();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
