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

namespace Project
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
        Cust cust;
        Status stat;
        public string logc;
        
        public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            butenable();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        void butenable()
        {
           
            if (logc == "Cashier")
            {
                button2.Enabled = false;
                button4.Enabled = false;
            }
        }
		
		void Button2Click(object sender, EventArgs e)
		{
			new Sales().Show();
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
            cust = new Cust();
            cust.Show();
			this.Hide();
            cust.logc = logc;
        }
		
		void Button3Click(object sender, EventArgs e)
		{
            stat = new Status();
            stat.Show();
            this.Hide();
            stat.logc = logc;
        }
		
		void Button4Click(object sender, EventArgs e)
		{
			new Stocks().Show();
			this.Hide();
			
		}
		
		void Button5MouseHover(object sender, EventArgs e)
		{
			button5.BackColor = System.Drawing.Color.DarkSlateGray;
			panel1.Visible = true;
            butenable();
		}
		
		void Panel1MouseHover(object sender, EventArgs e)
		{
			panel1.Visible = true;
		}
		
		void Panel1MouseLeave(object sender, EventArgs e)
		{
			
		}
		
		void Button5MouseLeave(object sender, EventArgs e)
		{
		}
		
		void MenuMouseHover(object sender, EventArgs e)
		{
			button5.BackColor = System.Drawing.Color.CadetBlue;
			panel1.Visible = false;	
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			
		}

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Log().Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
