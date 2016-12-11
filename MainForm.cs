/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 1:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Project
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();	
			tbleupdate();
			ordcb1item();
			squantity();
			orderstock();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void squantity()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select Quantity From project.product where Prod_ID = '"+ordcomboBox2.Text+"' ", conn);
			MySqlDataReader rd;
			
			if(ordcomboBox2.Text != "")
			{
			try
			{
				conn.Open();
				rd = cmd.ExecuteReader();
				while(rd.Read())
				{
					ordtextBox3.Text = rd[0].ToString();
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			}
		}
		
		void orderstock()
		{
			int a,b;
			string c;
			int.TryParse(ordtextBox3.Text,out a);
			int.TryParse(ordtextBox2.Text,out b);
			c = (a-b).ToString();
			string strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Update project.product set Quantity = '"+c+"' where Prod_ID = '"+ordcomboBox2.Text+"' ",conn);
			MySqlDataReader rd1;
		
			
			try
			{
				conn.Open();
				rd1 = cmd1.ExecuteReader();
				conn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		
		void ordcb1item()
		{
			string strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Select Cust_ID  from project.customer",conn);
			MySqlCommand cmd2 = new MySqlCommand("Select Prod_ID  from project.product",conn);
			MySqlDataReader rd;
			try
			{
				conn.Open();
				rd = cmd1.ExecuteReader();
				while(rd.Read())
				{
					ordcomboBox1.Items.Add(rd[0]);
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
					ordcomboBox2.Items.Add(rd[0]);
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}
			
		void tbleupdate()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select * from project.order",conn);
			try
			{
				MySqlDataAdapter adp = new MySqlDataAdapter();
				adp.SelectCommand = cmd;
				DataTable dt = new DataTable();
				adp.Fill(dt);
				BindingSource bs = new BindingSource();
				bs.DataSource = dt;
				dataGridView1.DataSource = bs;
				adp.Update(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void OrdtextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void AddordClick(object sender, EventArgs e)
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Insert into project.order (Cust_ID,Prod_ID,Date,Quantity) values ('"+ordcomboBox1.Text+"','"+ordcomboBox2.Text+"','"+dateTimePicker1.Value.Date+"','"+ordtextBox2.Text+"') ",conn);
			MySqlDataReader dr;
			
			if(ordcomboBox1.Text != "" && ordcomboBox2.Text != "" && ordtextBox2.Text != "")
			{
				
				try
				{	
					conn.Open();
					dr = cmd.ExecuteReader();
					
					//MessageBox.Show("Record Saved!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tbleupdate();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 
			}
			orderstock();
			ordtextBox1.Text = "";
			ordcomboBox1.Text = "";
			ordcomboBox2.Text = "";
			dateTimePicker1.Text = "";
			ordtextBox2.Text = "";
			
		}
		
		
		
		void EditordClick(object sender, EventArgs e)
		{
			MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				ordtextBox1.Text = row.Cells["Order_ID"].Value.ToString();
				ordcomboBox1.Text = row.Cells["Cust_ID"].Value.ToString();
				ordcomboBox2.Text = row.Cells["Prod_ID"].Value.ToString();
				dateTimePicker1.Text = row.Cells["Date"].Value.ToString();
				ordtextBox2.Text = row.Cells["Quantity"].Value.ToString();


			}
		}
		
		void OrdcomboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			squantity();
		}
	}
}
