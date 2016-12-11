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
	/// Description of Stocks.
	/// </summary>
	public partial class Stocks : Form
	{
		public Stocks()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			tble1update();
			tble2update();
			cboxval();
			qntyvalue();
			prodlabel();
			prodid();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/*
		  * 
		  * 
		  * Product
		  * 
		  * */
		
		void prodid()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("SELECT `auto_increment` FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'product' and table_schema = 'project' ",conn);
			MySqlDataReader rd;
			
			try
			{
				conn.Open();
				rd = cmd.ExecuteReader();
				while(rd.Read())
				{
					textBox1.Text = rd[0].ToString();
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void tble1update()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select Prod_ID as 'Product ID',Prod_Name as 'Product Name',Prod_Brand as 'Product Brand',Price from project.product",conn);
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
		
		/*
		  * 
		  * 
		  * Stocks
		  * 
		  * */
			void tble2update()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select Prod_ID as 'Product ID',Prod_Name as 'Product Name',Quantity from project.product",conn);
			try
			{
				MySqlDataAdapter adp = new MySqlDataAdapter();
				adp.SelectCommand = cmd;
				DataTable dt = new DataTable();
				adp.Fill(dt);
				BindingSource bs = new BindingSource();
				bs.DataSource = dt;
				dataGridView2.DataSource = bs;
				adp.Update(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		
		void cboxval()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select Prod_ID From project.product", conn);
			try
			{
				conn.Open();
  				MySqlDataReader DR = cmd.ExecuteReader();

           		 while (DR.Read())
           		 {
               		 comboBox2.Items.Add(DR[0]);
               		 

           		 }
           		 conn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void prodlabel()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select Prod_Name,Prod_Brand,Price From project.product where Prod_ID = '"+comboBox2.Text+"' ", conn);
			MySqlDataReader rd;
			
			if(comboBox2.Text != "")
			{
			try
			{
				conn.Open();
				rd = cmd.ExecuteReader();
                    int count = 0;
				while(rd.Read())
				{
					label6.Text = "Product Information\n\n  Product Name:   "+rd[0].ToString()+"\n  Product Brand:      "+rd[1].ToString()+"\n  Price:                     "+rd[2].ToString()+"";
                    count = count + 1;
               }
                    if (count == 0)
                    {
                        comboBox2.Text = "";
                    }
                    conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			}
			
			
		}
		
		void qntyvalue()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select Quantity From project.product where Prod_ID = '"+comboBox2.Text+"' ", conn);
			MySqlDataReader rd;
			
			if(comboBox2.Text != "")
			{
			try
			{
				conn.Open();
				rd = cmd.ExecuteReader();
				while(rd.Read())
				{
					textBox4.Text = rd[0].ToString();
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			}
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			button4.BackColor = System.Drawing.Color.Transparent;
			button5.BackColor = System.Drawing.Color.Black;
			PnlProd.Visible = true;
			PnlProd.BringToFront();
			panelstockloob.Enabled = false;
			button1.Visible = false;
			button3.Visible = false;
			label6.Text = "";
			comboBox2.Text ="";
		}
		
		void ExitClick(object sender, EventArgs e)
		{
			new Menu().Show();
			this.Hide();
		}
		
		void AddstockClick(object sender, EventArgs e)
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Insert into project.product (Prod_Name,Price,Prod_Brand) values ('"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox1.Text+"') ",conn);
			MySqlDataReader dr;
			
			if( textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" )
			{
				
				try
				{	
					conn.Open();
					dr = cmd.ExecuteReader();
					MessageBox.Show("Product Record Added!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tble1update();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 
			}
		textBox1.Text = "";
		textBox2.Text = "";
		textBox3.Text = "";
		comboBox1.Text = "";
		addstock.Visible = false;
		panelprodloob.Enabled = false;
		}
		
		void EditstockClick(object sender, EventArgs e)
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Update project.product set Prod_Name = '"+textBox2.Text+"', Prod_Brand = '"+comboBox1.Text+"', Price = '"+textBox3.Text+"' where Prod_ID = '"+textBox1.Text+"' ",conn);
			MySqlDataReader dr;
			
			if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "")
			{
				try
				{	
					conn.Open();
					dr = cmd.ExecuteReader();
					MessageBox.Show("Product Record Updated!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tble1update();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 

		textBox1.Text = "";
		textBox2.Text = "";
		textBox3.Text = "";
		comboBox1.Text = "";
			}
		editstock.Visible = false;
		delstock.Visible = false;
		panelprodloob.Enabled = false;
		}
		
		void DelstockClick(object sender, EventArgs e)
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Insert into project.productarch (Prod_ID,Prod_Name,Price,Prod_Brand) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox1.Text+"') ",conn);
			MySqlCommand cmd2 = new MySqlCommand("Delete from project.product where Prod_ID = '"+textBox1.Text+"'",conn);
			MySqlDataReader dr;
			
			if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "")
			{
				try
				{	
					conn.Open();
					dr = cmd1.ExecuteReader();
					tble1update();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 
				
				try
				{	
					conn.Open();
					dr = cmd2.ExecuteReader();
					MessageBox.Show("Product Record Deleted!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tble1update();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 
		textBox1.Text = "";
		textBox2.Text = "";
		textBox3.Text = "";
		comboBox1.Text = "";
			}
		editstock.Visible = false;
		delstock.Visible = false;
		panelprodloob.Enabled = false;
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			addstock.Visible = false;
			editstock.Visible = true;
			delstock.Visible = true;
			panelprodloob.Enabled = true;
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				textBox1.Text = row.Cells["Prod_ID"].Value.ToString();
				textBox2.Text = row.Cells["Prod_Name"].Value.ToString();
				comboBox1.Text = row.Cells["Prod_Brand"].Value.ToString();
				textBox3.Text = row.Cells["Price"].Value.ToString();


			}
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			
			qntyvalue();
			prodlabel();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			button5.BackColor = System.Drawing.Color.Transparent;
			button4.BackColor = System.Drawing.Color.Black;
			PnlStock.Visible = true;
			PnlStock.BringToFront();
			panelprodloob.Enabled = false;
			addstock.Visible = false;
			editstock.Visible = false;
			delstock.Visible = false;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			label6.Visible = false;
			int a,b;
			string c;
			int.TryParse(textBox4.Text, out a);
			int.TryParse(textBox5.Text, out b);
			c = (a+b).ToString();
			
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Update project.product set Quantity = '"+c+"' where Prod_ID = '"+comboBox2.Text+"' ",conn);
			MySqlDataReader dr;
			
			if(comboBox2.Text != "" && textBox5.Text != "")
			{
				try
				{	
					conn.Open();
					dr = cmd.ExecuteReader();
					MessageBox.Show("Stock Added!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tble2update();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 

		comboBox2.Text = "";
		textBox5.Text = "";
		panelstockloob.Enabled = false;
		button3.Visible = false;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			panelstockloob.Enabled = true;
			button3.Visible = true;
			button1.Visible = false;
			prodid();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Update project.product set Quantity = '"+textBox5.Text+"' where Prod_ID = '"+comboBox2.Text+"' ",conn);
			MySqlDataReader dr;
			
			if(comboBox2.Text != "" && textBox5.Text != "")
			{
				try
				{	
					conn.Open();
					dr = cmd.ExecuteReader();
					MessageBox.Show("Stock Updated!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tble2update();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 

		comboBox2.Text = "";
		textBox5.Text = "";
		panelstockloob.Enabled = false;
		button1.Visible = false;
			}
		}
		
		void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			panelstockloob.Enabled = true;
			button3.Visible = false;
			button1.Visible = true;
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
				comboBox2.Text = row.Cells["Prod_ID"].Value.ToString();
				textBox5.Text = row.Cells["Quantity"].Value.ToString();
				textBox4.Text = row.Cells["Quantity"].Value.ToString();

			}
			
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void StocksLoad(object sender, EventArgs e)
		{
			
		}
		
		void NewordClick(object sender, EventArgs e)
		{
           
			addstock.Visible = true;
			editstock.Visible = false;
			delstock.Visible = false;
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			comboBox1.Text = "";
			panelprodloob.Enabled = true;
            prodid();
        }
		
		void PanelprodloobPaint(object sender, PaintEventArgs e)
		{
			
		}
		
		void CancelprodClick(object sender, EventArgs e)
		{
			panelstockloob.Enabled = false;
			button1.Visible = false;
			button3.Visible = false;
			comboBox2.Text = "";
			textBox5.Text = "";
			label6.Text = "";
		}
		
		void Cancelprod1Click(object sender, EventArgs e)
		{
			panelprodloob.Enabled = false;
			addstock.Visible = false;
			editstock.Visible = false;
			delstock.Visible = false;
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			comboBox1.Text = "";
		
		}
		void ComboBox2TextUpdate(object sender, EventArgs e)
		{
			qntyvalue();
			prodlabel();
		}

        private void panelstockloob_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
