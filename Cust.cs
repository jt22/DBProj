/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 1:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Project
{
	/// <summary>
	/// Description of Cust.
	/// </summary>
	public partial class Cust : Form
	{
        string cid;
        Menu menu;
        public string logc;
		public Cust()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            tblecust();
			tblesearch();
			Custid();
			buttonsearch();
			tbleord();
			ordcb1item();
			squantity();
			ordprice();
			prodlabel();
			custlabel();
			orderid();
			birthday();
            daten();
          
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		/*
 		 * 
		 * CUSTOMER
		 *  
		 * */
		void birthday()
		{
			int x;
			for(x=1;x<=31;x++)
			{
				biday.Items.Add(x);
			}
			for(x=1;x<=125;x++)
			{
				byear.Items.Add(x+1900);
			}
		}
		void Custid()
		{
				String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("SELECT `auto_increment` FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'customer' and table_schema = 'project' ",conn);
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
				
		void tblecust()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("SELECT Cust_ID as 'Customer ID',CONCAT(FName,' ',LName) as 'Customer Name',CONCAT(Street,',',Barangay,',',City,',',Prov) as Address,CONCAT(BMonth,'/',BDay,'/',BYear) as Birthday,Gender,Contact FROM project.customer", conn);
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
		 * ORDER
		 * 
		 *  */
		void daten()
        {
            dateTimePicker1.Value = DateTime.Now;
        }
		
		void orderstock(string c)
		{
			
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
		
		void orddel()
		{
			int a,b;
			string c;
			int.TryParse(ordtextBox3.Text,out a);
			int.TryParse(ordtextBox2.Text,out b);
			c = (a+b).ToString();
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
		
		void orderid()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("SELECT `auto_increment` FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'order' and table_schema = 'project' ",conn);
			MySqlDataReader rd;
			
			try
			{
				conn.Open();
				rd = cmd.ExecuteReader();
				while(rd.Read())
				{
					ordtextBox1.Text = rd[0].ToString();
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void squantity()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select Quantity,Price From project.product where Prod_ID = '"+ordcomboBox2.Text+"' ", conn);
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
					ordtextBox4.Text = rd[1].ToString();
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			}
		}
		
		void ordprice()
		{
            if (ordcomboBox2.Text != "")
            {
                int a, b;
                int.TryParse(ordtextBox2.Text, out a);
                int.TryParse(ordtextBox4.Text, out b);

                ordtextprice.Text = (a * b).ToString();
            }
            else
                ordtextprice.Text = "";
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
		
		void prodlabel()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select Prod_Name,Prod_Brand,Price From project.product where Prod_ID = '"+ordcomboBox2.Text+"' ", conn);
			MySqlDataReader rd;
			
			if(ordcomboBox2.Text != "")
			{
			try
			{
				conn.Open();
				rd = cmd.ExecuteReader();
                int count = 0;
				while(rd.Read())
				{
					labelord.Text = "Product Information\n\n  Product Name:   "+rd[0].ToString()+"\n  Product Brand:     "+rd[1].ToString()+"\n  Price:                     "+rd[2].ToString()+"";
                    count = count + 1;
                }
                    if (count == 0)
                    {
                        ordcomboBox2.Text = "";
                    }
                conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			}
            if (ordcomboBox2.Text == "")
            {
                labelord.Text = "";
            }

        }
		
		void custlabel()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select FName,MName,LName From project.customer where Cust_ID = '"+ordcomboBox1.Text+"' ", conn);
			MySqlDataReader rd;
			
			if(ordcomboBox1.Text != "")
			{
			try
			{
				
				conn.Open();
				rd = cmd.ExecuteReader();
				int count = 0;
				while(rd.Read())
				{
					labelcust.Text = ""+rd[0].ToString()+" "+rd[1].ToString()+" "+rd[2].ToString()+"";
					count = count+1;
				}
				if (count==0)
				{
					ordcomboBox1.Text ="";
				}
				conn.Close();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			}
			if(ordcomboBox1.Text == "")
			{
				labelcust.Text = "";
			}
			
		}
		
		void tbleord()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=;database=project";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("SELECT `order`.Order_ID as 'Order ID', `order`.Prod_ID as 'Product ID', `product`.Prod_Name as 'Product Name', `product`.Prod_Brand as 'Product Brand',`order`.Quantity, `order`.Price, `order`.Date FROM `product` INNER JOIN `order` ON `product`.Prod_ID=`order`.Prod_ID where Cust_ID = '"+ordcomboBox1.Text+"'",conn);
			try
			{
				MySqlDataAdapter adp = new MySqlDataAdapter();
				adp.SelectCommand = cmd;
				DataTable dt = new DataTable();
				adp.Fill(dt);
				BindingSource bs = new BindingSource();
				bs.DataSource = dt;
				dataGridView3.DataSource = bs;
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
		  * SEARCH
		  * 
		  * */
		void tblesearch()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("SELECT Cust_ID as 'Customer ID',CONCAT(FName,' ',LName) as 'Customer Name',CONCAT(BMonth,'/',BDay,'/',BYear) as Birthday,CONCAT(Street,',',Barangay,',',City,',',Prov) as Address,Gender,Contact FROM project.customer", conn);
			MySqlCommand cmd2 = new MySqlCommand("SELECT Cust_ID as 'Customer ID',CONCAT(FName,' ',LName) as 'Customer Name',CONCAT(BMonth,'/',BDay,'/',BYear) as Birthday,CONCAT(Street,',',Barangay,',',City,',',Prov) as Address,Gender,Contact FROM project.customer where " + srchcmbo.Text+" like '"+srchtxt.Text+"%'",conn);
			if(srchcmbo.Text != "" && srchtxt.Text != "")
			{
				try
				{
					MySqlDataAdapter adp = new MySqlDataAdapter();
					adp.SelectCommand = cmd2;
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
			else
			{
				try
				{
					MySqlDataAdapter adp = new MySqlDataAdapter();
					adp.SelectCommand = cmd1;
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

		}
		
		void buttonsearch()
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Select * from project.customer where '"+srchcmbo.Text+"'  = '"+srchtxt.Text+"' ",conn);
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
		
		
		void TabPage2Click(object sender, EventArgs e)
		{
			
		}
		
		void TabPage1Click(object sender, EventArgs e)
		{
			
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				cid = row.Cells["Customer ID"].Value.ToString();
				
			}

            String strconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conn = new MySqlConnection(strconn);
            MySqlCommand cmd = new MySqlCommand("Select * from project.customer where Cust_ID = '"+cid+"'", conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    textBox1.Text = rd["Cust_ID"].ToString();
                    textBox2.Text = rd[1].ToString();
                    textBox3.Text = rd[2].ToString();
                    textBox4.Text = rd[3].ToString();
                    bmonth.Text = rd[4].ToString();
                    biday.Text = rd[5].ToString();
                    byear.Text = rd[6].ToString();
                    stad.Text = rd[7].ToString();
                    brngyad.Text = rd[8].ToString();
                    cityad.Text = rd[9].ToString();
                    provad.Text = rd[10].ToString();
                    comboBox1.Text = rd[11].ToString();
                    textBox6.Text = rd[12].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            addcust.Visible = false;
			editcust.Visible = true;
			delcust.Visible = true;
			panel1.Enabled = true;
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label8Click(object sender, EventArgs e)
		{
			
		}
		
		void CustLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Insert into project.customer (FName,MName,LName,BMonth,BDay,BYear,Street,Barangay,City,Prov,Gender,Contact) values ('"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+bmonth.Text+"','"+biday.Text+"','"+byear.Text+"','"+stad.Text+"','"+brngyad.Text+"','"+cityad.Text+"','"+provad.Text+"','"+comboBox1.Text+"','"+textBox6.Text+"') ",conn);
			MySqlDataReader dr;
			
			if( textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && bmonth.Text != "" && biday.Text != "" && byear.Text != "" && stad.Text != "" && brngyad.Text != "" && cityad.Text != "" && provad.Text != "" && comboBox1.Text != ""  && textBox6.Text != "")
			{
				
				try
				{	
					conn.Open();
					dr = cmd.ExecuteReader();
					MessageBox.Show("Customer Record Saved!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tblecust();
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
		textBox4.Text = "";
		comboBox1.Text = "";
		bmonth.Text = "";
		biday.Text = "";
		byear.Text = "";
		stad.Text = "";
		brngyad.Text = "";
		cityad.Text = "";
		provad.Text = "";
		textBox6.Text = "";
		panel1.Enabled = false;
		addcust.Visible = false;
		}					
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			 String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Update project.customer set FName = '"+textBox2.Text+"', MName = '"+textBox3.Text+"', LName = '"+textBox4.Text+"', BMonth = '"+bmonth.Text+"', BDay = '"+biday.Text+"', BYear = '"+byear.Text+"', Street = '"+stad.Text+"', Barangay = '"+brngyad.Text+"', City = '"+cityad.Text+"', Prov = '"+provad.Text+"', Gender = '"+comboBox1.Text+"', Contact = '"+textBox6.Text+"' where Cust_ID = '"+textBox1.Text+"' ",conn);
			MySqlDataReader dr;
			
			if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "" && stad.Text != "" && textBox6.Text != "")
			{
				try
				{	
					conn.Open();
					dr = cmd.ExecuteReader();
					MessageBox.Show("Customer Record Updated!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tblecust();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 

		textBox1.Text = "";
		textBox2.Text = "";
		textBox3.Text = "";
		textBox4.Text = "";
		comboBox1.Text = "";
		stad.Text = "";
		textBox6.Text = "";
		bmonth.Text = "";
		biday.Text = "";
		byear.Text = "";
		stad.Text = "";
		brngyad.Text = "";
		cityad.Text = "";
		provad.Text = "";
			}
		panel1.Enabled = false;
		editcust.Visible = false;
		delcust.Visible = false;
		}
		
		void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Insert into project.customerarch (Cust_ID,FName,MName,LName,BMonth,BDay,BYear,Street,Barangay,City,Prov,Gender,Contact) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+bmonth.Text+"','"+biday.Text+"','"+byear.Text+"','"+stad.Text+"','"+brngyad.Text+"','"+cityad.Text+"','"+provad.Text+"','"+comboBox1.Text+"','"+textBox6.Text+"') ",conn);
			MySqlCommand cmd2 = new MySqlCommand("Delete from project.customer where Cust_ID = '"+textBox1.Text+"'",conn);
			MySqlDataReader dr;
			
			if( textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && bmonth.Text != "" && biday.Text != "" && byear.Text != "" && stad.Text != "" && brngyad.Text != "" && cityad.Text != "" && provad.Text != "" && comboBox1.Text != ""  && textBox6.Text != "")
			{
				try
				{	
					conn.Open();
					dr = cmd1.ExecuteReader();
					tblecust();
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
                    MessageBox.Show("Customer Record Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tblecust();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBox1.Text = "";
		textBox1.Text = "";
		textBox2.Text = "";
		textBox3.Text = "";
		textBox4.Text = "";
		comboBox1.Text = "";
		stad.Text = "";
		textBox6.Text = "";
		bmonth.Text = "";
		biday.Text = "";
		byear.Text = "";
		stad.Text = "";
		brngyad.Text = "";
		cityad.Text = "";
		provad.Text = "";
			}
		panel1.Enabled = false;
		delcust.Visible = false;
		editcust.Visible = false;
		}
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			tblesearch();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
            tblesearch();
            button4.BackColor = System.Drawing.Color.Transparent;
			button5.BackColor = System.Drawing.Color.Black;
			OrderButton.BackColor = System.Drawing.Color.Black;
			PnlSrchCust.Visible = true;
			PnlSrchCust.BringToFront();
			panel1.Enabled = false;
			pnlinord.Enabled = false;
			addord.Visible = false;
			delord.Visible = false;
			addcust.Visible = false;
			editcust.Visible = false;
			delcust.Visible = false;
			labelcust.Text = "";
			ordcomboBox1.Text = "";
            Custid();
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			comboBox1.Text = "";
			bmonth.Text = "";
			biday.Text = "";
			byear.Text = "";
			stad.Text = "";
			brngyad.Text = "";
			cityad.Text = "";
			provad.Text = "";
			textBox6.Text = "";
            orderid();
			ordtextBox2.Text = "";
			ordcomboBox2.Text = "";
			ordtextprice.Text = "";
			labelord.Text = "";
			tbleord();
            daten();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			button5.BackColor = System.Drawing.Color.Transparent;
			button4.BackColor = System.Drawing.Color.Black;	
			OrderButton.BackColor = System.Drawing.Color.Black;
			PnlCust.Visible = true;
			PnlCust.BringToFront();
			pnlinord.Enabled = false;
			addord.Visible = false;
			delord.Visible = false;
			labelcust.Text = "";
			ordtextBox2.Text = "";
			ordcomboBox1.Text = "";
			ordcomboBox2.Text = "";
			ordtextprice.Text = "";
			labelord.Text = "";
			tbleord();
            orderid();
            daten();
		}
		
		void Panel3Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void Panel2Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void ExitClick(object sender, EventArgs e)
		{
            menu = new Menu();
            menu.Show();
			this.Hide();
            menu.logc = logc;
		}
		
		void CustlayoutPaint(object sender, PaintEventArgs e)
		{
			
		}
		
		void SrchButtonClick(object sender, EventArgs e)
		{
			buttonsearch();
		}
		
		void AddordClick(object sender, EventArgs e)
		{
			int a,b,t;
			string c;
			int.TryParse(ordtextBox3.Text,out a);
			int.TryParse(ordtextBox2.Text,out b);
			t = (a-b);
			c = t.ToString();
			if(a == 0)
			{
				MessageBox.Show("Out of Stock","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				ordtextBox2.Text = "";
				ordcomboBox2.Text = "";
				labelord.Text = "";
			}
			else
			{
			if(t<0)
			{
				DialogResult result = MessageBox.Show("Your order cannot reach the stock.\nDo you want to order with our maximum quantity of "+ordtextBox3.Text+" instead of "+ordtextBox2.Text+"?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
				if(result == DialogResult.Yes)
					{ 
						int.TryParse(ordtextBox3.Text,out a);
						int.TryParse(ordtextBox3.Text,out b);
						t = (a-b);
						c = t.ToString();
						String strconn = "datasource=localhost;port=3306;username=root;password=";
						MySqlConnection conn = new MySqlConnection(strconn);
						MySqlCommand cmd = new MySqlCommand("Insert into project.order (Cust_ID,Prod_ID,Date,Quantity,Price) values ('"+ordcomboBox1.Text+"','"+ordcomboBox2.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+ordtextBox3.Text+"','"+ordtextprice.Text+"') ",conn);
						MySqlDataReader dr;
				
						if(ordcomboBox1.Text != "" && ordcomboBox2.Text != "" && ordtextBox2.Text != "" && ordtextprice.Text != "")
							{
								try
									{	
										conn.Open();
										dr = cmd.ExecuteReader();
                                         MessageBox.Show("Order Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
										tbleord();
										conn.Close();
									}		
								catch (Exception ex)
									{
										MessageBox.Show(ex.Message);
									} 
									orderstock(c);
						
							}
							pnlinord.Enabled = false;
							addord.Visible = false;
							ordtextBox1.Text = "";
							ordtextBox2.Text = "";
							ordtextBox3.Text = "";
							ordcomboBox1.Text = "";
							ordcomboBox2.Text = "";
							ordtextprice.Text = "";
							labelord.Text = "";
							labelcust.Text = "";
							
					}
				else if (result == DialogResult.No)
					{ 
   						ordtextBox2.Text = "";
						ordcomboBox2.Text = "";
						labelord.Text = "";
					}
			}
			else
			{
				
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd = new MySqlCommand("Insert into project.order (Cust_ID,Prod_ID,Date,Quantity,Price) values ('"+ordcomboBox1.Text+"','"+ordcomboBox2.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+ordtextBox2.Text+"','"+ordtextprice.Text+"') ",conn);
			MySqlDataReader dr;
			
			if(ordcomboBox1.Text != "" && ordcomboBox2.Text != "" && ordtextBox2.Text != "" && ordtextprice.Text != "")
			{
				{
				try
				{	
					conn.Open();
					dr = cmd.ExecuteReader();
                    MessageBox.Show("Order Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbleord();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 
				orderstock(c);
				}
			}
			pnlinord.Enabled = false;
			addord.Visible = false;
			ordtextBox1.Text = "";
			ordtextBox2.Text = "";
			ordtextBox3.Text = "";
			ordcomboBox1.Text = "";
			ordcomboBox2.Text = "";
			ordtextprice.Text = "";
			labelord.Text = "";
			labelcust.Text = "";
			}
			}
			
			
		}
		
		void EditordClick(object sender, EventArgs e)
		{
		}
		
		void DelordClick(object sender, EventArgs e)
		{
			String strconn = "datasource=localhost;port=3306;username=root;password=";
			MySqlConnection conn = new MySqlConnection(strconn);
			MySqlCommand cmd1 = new MySqlCommand("Insert into project.orderarch (Order_ID,Cust_ID,Prod_ID,Date,Quantity,Price) values ('"+ordtextBox1.Text+"','"+ordcomboBox1.Text+"','"+ordcomboBox2.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+ordtextBox2.Text+"','"+ordtextprice.Text+"') ",conn);
			MySqlCommand cmd2 = new MySqlCommand("Delete from project.order where Order_ID = '"+ordtextBox1.Text+"' ",conn);
			MySqlDataReader dr;
			
			if(ordtextBox1.Text != "" && ordcomboBox1.Text != "" && ordcomboBox2.Text != "" && ordtextBox2.Text != "")
			{
				try
				{	
					conn.Open();
					dr = cmd1.ExecuteReader();
                    MessageBox.Show("Order Canceled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbleord();
					conn.Close();
				}		
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} 
				
//				try
//				{	
//					conn.Open();
//					dr = cmd2.ExecuteReader();
//					
//					tbleord();
//					conn.Close();
//				}		
//				catch (Exception ex)
//				{
//					MessageBox.Show(ex.Message);
//				} 
				orddel();
			}
			pnlinord.Enabled = false;
			delord.Visible = false;
			ordtextBox1.Text = "";
			ordtextBox2.Text = "";
			ordtextBox3.Text = "";
			ordcomboBox1.Text = "";
			ordcomboBox2.Text = "";
			ordtextprice.Text = "";
			labelord.Text = "";
			labelcust.Text = "";
		}
		
		void DataGridView3CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                ordtextBox1.Text = row.Cells["Order ID"].Value.ToString();
            }
            String strconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conn = new MySqlConnection(strconn);
            MySqlCommand cmd = new MySqlCommand("Select * from project.order where Order_ID = '" + ordtextBox1.Text+ "'", conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ordtextBox1.Text = rd[0].ToString();
                    ordcomboBox2.Text = rd[2].ToString();
                    dateTimePicker1.Text = rd[3].ToString();
                    ordtextBox2.Text = rd[4].ToString();  
                    ordtextprice.Text = rd[5].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            addord.Visible = false;
			delord.Visible = true;
            pnlinord.Enabled = true;
			
		}
		
		void OrdcomboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			squantity();
			prodlabel();
            if (ordcomboBox2.Text != "")
            {
                ordprice();
            }
            else
                ordtextprice.Text = "";
		}
		
		void OrderButtonClick(object sender, EventArgs e)
		{
			OrderButton.BackColor = System.Drawing.Color.Transparent;
			button4.BackColor = System.Drawing.Color.Black;	
			button5.BackColor = System.Drawing.Color.Black;
			PnlOrd.Visible = true;
			PnlOrd.BringToFront();
			panel1.Enabled = false;
			addcust.Visible = false;
			editcust.Visible = false;
			delcust.Visible = false;
            Custid();
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			comboBox1.Text = "";
			bmonth.Text = "";
			biday.Text = "";
			byear.Text = "";
			stad.Text = "";
			brngyad.Text = "";
			cityad.Text = "";
			provad.Text = "";
			textBox6.Text = "";
		}
		
		void OrdtextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void OrdtextBox2TextChanged(object sender, EventArgs e)
		{
			ordprice();
		}
		
		void Label16Click(object sender, EventArgs e)
		{
			
		}
		
		void OrdcomboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			custlabel();
			tbleord();
			neword.Visible = true;
            orderid();
            ordtextBox2.Text = "";
            ordtextBox3.Text = "";
            ordcomboBox2.Text = "";
            ordtextprice.Text = "";
            labelord.Text = "";
            daten();
            pnlinord.Enabled = false;
        }
		
		void NewcustClick(object sender, EventArgs e)
		{
			
		}
		
		void NewordClick(object sender, EventArgs e)
		{
			addord.Visible = true;
			delord.Visible = false;
			ordtextBox1.Text = "";
			ordtextBox2.Text = "";
			ordcomboBox2.Text = "";
			ordtextprice.Text = "";
			labelord.Text = "";
			pnlinord.Enabled = true;
			orderid();
		}
		
		void OrdtextpriceTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void NewcustomerClick(object sender, EventArgs e)
		{
			addcust.Visible = true;
			editcust.Visible = false;
			delcust.Visible = false;
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			stad.Text = "";
			textBox6.Text = "";
			comboBox1.Text = "";
			bmonth.Text = "";
			biday.Text = "";
			byear.Text = "";
			stad.Text = "";
			brngyad.Text = "";
			cityad.Text = "";
			provad.Text = "";
			panel1.Enabled = true;
			Custid();

		}
		
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CancelordClick(object sender, EventArgs e)
		{
			pnlinord.Enabled = false;
			addord.Visible = false;
			delord.Visible = false;
            orderid();
			ordtextBox2.Text = "";
			ordtextBox3.Text = "";
			ordcomboBox2.Text = "";
			ordtextprice.Text = "";
			labelord.Text = "";
            daten();
		}
		
		void CancelcustClick(object sender, EventArgs e)
		{
			panel1.Enabled = false;
			addcust.Visible = false;
			editcust.Visible = false;
			delcust.Visible = false;
            Custid();
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			comboBox1.Text = "";
            bmonth.Text = "";
            biday.Text = "";
            byear.Text = "";
			stad.Text = "";
            brngyad.Text = "";
            cityad.Text = "";
            provad.Text = "";
			textBox6.Text = "";
		}
		void LabelcustClick(object sender, EventArgs e)
		{
	
		}
		void OrdcomboBox1TextUpdate(object sender, EventArgs e)
		{
			custlabel();
			tbleord();
			if(ordcomboBox1.Text!= "")
			{
			neword.Visible = true;
			}
			if(ordcomboBox1.Text == "")
			{
			neword.Visible = false;
			}
            orderid();
            ordtextBox2.Text = "";
            ordtextBox3.Text = "";
            ordcomboBox2.Text = "";
            ordtextprice.Text = "";
            labelord.Text = "";
            daten();
            pnlinord.Enabled = false;
        }
		void OrdtextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void OrdcomboBox2TextUpdate(object sender, EventArgs e)
		{
			squantity();
			prodlabel();
            if (ordcomboBox2.Text != "")
            {
                ordprice();
            }
            else
                ordtextprice.Text = "";
        }
		void YesordClick(object sender, EventArgs e)
		{
			
		}
		void NoordClick(object sender, EventArgs e)
		{
			
		}
	}
}
