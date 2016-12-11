/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/13/2016
 * Time: 7:49 PM
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
	/// Description of graph.
	/// </summary>
	public partial class graph : Form
	{
		
		public graph()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
//			salesize();
			cb();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void cb()
		{
			int x;
			for(x=0;x<=20;x++)
			{
				comboBox1.Items.Add(2016+x);
			}
		}
		void salesize()
		{
			int h = 512;
			string strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '1/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd2 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '2/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd3 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '3/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd4 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '4/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd5 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '5/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd6 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '6/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd7 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '7/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd8 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '8/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd9 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '9/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd10 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '10/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd11 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '11/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlCommand cmd12 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '12/%' and Date like '%"+comboBox1.Text+"'",conn);
			MySqlDataReader rd;
			if(comboBox1.Text != "")
			{
			try
			{
				conn.Open();
				rd = cmd1.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label1.Height = b;
					label1.Location = new System.Drawing.Point(87,h-b);
					
				}
				conn.Close();
				
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			
			try
			{
				conn.Open();
				rd = cmd2.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label2.Height = b;
					label2.Location = new System.Drawing.Point(130,h-b);
					
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			
			try
			{
				conn.Open();
				rd = cmd3.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label3.Height = b;
					label3.Location = new System.Drawing.Point(173,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd4.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label4.Height = b;
					label4.Location = new System.Drawing.Point(216,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd5.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label5.Height = b;
					label5.Location = new System.Drawing.Point(259,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd6.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label6.Height = b;
					label6.Location = new System.Drawing.Point(302,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd7.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label7.Height = b;
					label7.Location = new System.Drawing.Point(345,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd8.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label8.Height = b;
					label8.Location = new System.Drawing.Point(388,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd9.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label9.Height = b;
					label9.Location = new System.Drawing.Point(431,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd10.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label10.Height = b;
					label10.Location = new System.Drawing.Point(474,h-b);
//					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd11.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
					b = a/2+7;
					
					label11.Height = b;
					label11.Location = new System.Drawing.Point(517,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			try
			{
				conn.Open();
				rd = cmd12.ExecuteReader();
				while(rd.Read())
				{
					string c;
					int a,b;
					c = rd[0].ToString();
					int.TryParse(c,out a);
					if(a == 0)
					b = 0;
					else
						b = a/2+7;
					
					label12.Height = b;
					label12.Location = new System.Drawing.Point(560,h-b);
					
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
	}
		
//		void salelabel(int x)
//		{
//			string strconn = "datasource=locahost;port=3306;username=root;password=";
//			MySqlConnection conn = new MySqlConnection(strconn);
//			MySqlCommand cmd1 = new MySqlCommand("Select Sum(Quantity) from project.order where Date like '"+x+"/%' and Date like '%"+comboBox1.Text+"'",conn);
//			MySqlDataReader rd;
//			
//			try
//			{
//				conn.Open();
//				rd = cmd1.ExecuteReader();
//				while(rd.Read())
//				{
//					int a,b;
//					string c;
//					Label[] f = new Label[12];
//					c = rd[0].ToString();
//					int.TryParse(c,out a);
//					b = a/10;
//					f[a] = new Label();
////					f[a].BackColor = new System.Drawing.Color.Blue;
//					f[a].Height = b;
//					f[a].Location = new System.Drawing.Point(100,292-b);
//					
//				}
//				conn.Close();
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show(ex.Message);
//			}
			
//		}
		
		void Button1Click(object sender, EventArgs e)
		{
			new Sales().Show();
			this.Hide();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label1SizeChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
//			int x;
//			for(x=1;x<=12;x++)
//			{
//				salelabel(x);
//			}
			
			salesize();
			 
			
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			
		}
		
		void GraphLoad(object sender, EventArgs e)
		{
			
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void Label15Click(object sender, EventArgs e)
		{
			
		}
		
		void Label14Click(object sender, EventArgs e)
		{
			
		}
		
		void Label33Click(object sender, EventArgs e)
		{
			
		}
		
		void Label34Click(object sender, EventArgs e)
		{
			
		}
		
		void Label31Click(object sender, EventArgs e)
		{
			
		}
	}
}
