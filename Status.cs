/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 5:53 PM
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
	/// Description of Status.
	/// </summary>
	public partial class Status : Form
	{
        Menu menu;
        public string logc;
		string orid,curid,proid,date,quan,price;
		public Status()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			updatetable();
		
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void updatetable()
		{
			string strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn =  new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Select `order`.Order_ID,CONCAT(`customer`.FName,' ',`customer`.LName) as 'Customer Name',`product`.Prod_Name as 'Product Name',`product`.Prod_Brand as 'Product Brand', `order`.Date,`order`.Quantity,`order`.Price From project.`order` Inner Join project.`customer` On `order`.Cust_ID=`customer`.Cust_ID Inner Join project.`product` ON `order`.Prod_ID=`product`.Prod_ID ORDER BY order.Order_ID ASC", conn);
			MySqlCommand cmd2 = new MySqlCommand("Select `order`.Order_ID,CONCAT(`customer`.FName,' ',`customer`.LName) as 'Customer Name',`product`.Prod_Name as 'Product Name',`product`.Prod_Brand as 'Product Brand', `order`.Date,`order`.Quantity,`order`.Price From project.`order` Inner Join project.`customer` On `order`.Cust_ID=`customer`.Cust_ID Inner Join project.`product` ON `order`.Prod_ID=`product`.Prod_ID where order."+ srchcmbo.Text+" like '"+textBox1.Text+"%'",conn);
			if (srchcmbo.Text == "")
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
			}
			else
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
			}
			                  
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			button4.BackColor = System.Drawing.Color.Transparent;
		}
		
		void ExitClick(object sender, EventArgs e)
		{
            menu = new Menu();
            menu.Show();
            this.Hide();
            menu.logc = logc;
        }
		
		void SrchcmboSelectedIndexChanged(object sender, EventArgs e)
		{
			updatetable();
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			updatetable();
		}
		
		void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
				orid = row.Cells["Order_ID"].Value.ToString();
				
			}
            string strconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conn = new MySqlConnection(strconn);
            MySqlCommand cmd1 = new MySqlCommand("Select * from project.order where Order_ID = '"+orid+"'",conn);
            MySqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd1.ExecuteReader();
                while(dr.Read())
                {
                    curid = dr[1].ToString();
                    proid = dr[2].ToString();
                    date = dr[3].ToString();
                    quan = dr[4].ToString();
                    price = dr[5].ToString();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
		
		void AddordClick(object sender, EventArgs e)
		{
			string strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Insert into project.orderpaid (Order_ID,Cust_ID,Prod_ID,Date,Quantity,Price) values ('"+orid+"','"+curid+"','"+proid+"','"+date+"','"+quan+"','"+price+"')",conn);
			MySqlCommand cmd2 = new MySqlCommand("Delete from project.order where Order_ID = '"+orid+"' ",conn);
			MySqlDataReader dr;
			
			try
			{
				conn.Open();
				dr = cmd1.ExecuteReader();
				MessageBox.Show("Order is paid!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
//			try
//			{
//				conn.Open()
//				dr = cmd2.ExecuteReader();
//				conn.Close()
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show(ex.Message);
//			}
		}
	}
}
