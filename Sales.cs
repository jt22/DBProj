/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 5:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Project
{
	/// <summary>
	/// Description of Sales.
	/// </summary>
	public partial class Sales : Form
	{
		public Sales()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			updatetable();
			yearitem();
			monthitem();
			sukitable();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void sukitable()
		{
			string strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn =  new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("SELECT `order`.Cust_ID as 'Customer ID', Concat(`customer`.FName, ' ',`customer`.LName) as 'Customer Name', Concat(Street,',',Barangay,',',City,',',Prov) as Address, Contact, SUM(`order`.Price) AS TotalPrice FROM project.`order` Join project.`customer` ON `order`.Cust_ID =`customer`.Cust_ID GROUP BY `order`.Cust_ID ORDER BY TotalPrice DESC", conn);
			
			
				try
				{
					MySqlDataAdapter da = new MySqlDataAdapter();
					da.SelectCommand = cmd1;
					DataTable dt = new DataTable();
					da.Fill(dt);
					BindingSource bs = new BindingSource();
					bs.DataSource = dt;
					sukidatagrid1.DataSource = bs;
					da.Update(dt);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			
		}
		/*
		 /
		 /SALES
		 /
		 */
		
		void yearitem()
		{
			int x;
			for(x=0;x<=20;x++)
			{
				yearcmbo.Items.Add(2016+x);
			}
		}
		
		void monthitem()
		{
			int x;
			for(x=0;x<=11;x++)
			{
				monthcmbo.Items.Add(1+x);
			}
		}
		
		void updatetable()
		{
			string strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn =  new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Select Order_ID as 'Order ID',Quantity,Date from project.order",conn);
			MySqlCommand cmd2 = new MySqlCommand("Select Order_ID as 'Order ID',Quantity,Date from project.order where Date like '%/" + yearcmbo.Text+"' and Date like '"+monthcmbo.Text+"/%' ",conn);
			MySqlCommand cmd3 = new MySqlCommand("Select Sum(Quantity) as 'Monthly Sales' from project.order where Date like '"+monthcmbo.Text+"/%' and Date like '%/"+yearcmbo.Text+"'",conn);
			if(monthcmbo.Text != "" && yearcmbo.Text != "")
			{
				try
				{
					MySqlDataAdapter da = new MySqlDataAdapter();
					da.SelectCommand = cmd2;
					DataTable dt = new DataTable();
					da.Fill(dt);
					BindingSource bs = new BindingSource();
					bs.DataSource = dt;
					dataGridView2.DataSource = bs;
					da.Update(dt);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				
				try
				{
					MySqlDataAdapter da = new MySqlDataAdapter();
					da.SelectCommand = cmd3;
					DataTable dt = new DataTable();
					da.Fill(dt);
					BindingSource bs = new BindingSource();
					bs.DataSource = dt;
					dataGridView1.DataSource = bs;
					da.Update(dt);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				
			}
			else
			{
				try
				{
					MySqlDataAdapter da = new MySqlDataAdapter();
					da.SelectCommand = cmd1;
					DataTable dt = new DataTable();
					da.Fill(dt);
					BindingSource bs = new BindingSource();
					bs.DataSource = dt;
					dataGridView2.DataSource = bs;
					da.Update(dt);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				
				try
				{
					MySqlDataAdapter da = new MySqlDataAdapter();
					da.SelectCommand = cmd3;
					DataTable dt = new DataTable();
					da.Fill(dt);
					BindingSource bs = new BindingSource();
					bs.DataSource = dt;
					dataGridView1.DataSource = bs;
					da.Update(dt);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
				
		}

		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void ExitClick(object sender, EventArgs e)
		{
			new Menu().Show();
			this.Hide();
		
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			button4.BackColor = System.Drawing.Color.Transparent;
			PnlSrchCust.Visible = true;
			PnlSrchCust.BringToFront();
			
		}
		
		void YearcmboSelectedIndexChanged(object sender, EventArgs e)
		{
			updatetable();
		}
		
		void MonthcmboSelectedIndexChanged(object sender, EventArgs e)
		{
			updatetable();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			new SalesGraph().Show();
			this.Hide();
		}
		void DataGridView3CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Sukidatagrid1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		void SukibutClick(object sender, EventArgs e)
		{
			suki.Visible = true;
			suki.BringToFront();
		}

        private void Sales_Load(object sender, EventArgs e)
        {

        }
    }
}
