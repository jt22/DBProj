/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 5:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project
{
	partial class Status
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.panelcontent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlSrchCust = new System.Windows.Forms.Panel();
            this.addord = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.srchcmbo = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlSrchCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontent
            // 
            this.panelcontent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelcontent.Controls.Add(this.panel1);
            this.panelcontent.Controls.Add(this.exit);
            this.panelcontent.Controls.Add(this.button4);
            this.panelcontent.Location = new System.Drawing.Point(0, 89);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(996, 580);
            this.panelcontent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PnlSrchCust);
            this.panel1.Location = new System.Drawing.Point(45, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 471);
            this.panel1.TabIndex = 10;
            // 
            // PnlSrchCust
            // 
            this.PnlSrchCust.BackColor = System.Drawing.Color.PowderBlue;
            this.PnlSrchCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlSrchCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlSrchCust.Controls.Add(this.addord);
            this.PnlSrchCust.Controls.Add(this.textBox1);
            this.PnlSrchCust.Controls.Add(this.srchcmbo);
            this.PnlSrchCust.Controls.Add(this.dataGridView2);
            this.PnlSrchCust.Controls.Add(this.label8);
            this.PnlSrchCust.Location = new System.Drawing.Point(0, 0);
            this.PnlSrchCust.Name = "PnlSrchCust";
            this.PnlSrchCust.Size = new System.Drawing.Size(897, 471);
            this.PnlSrchCust.TabIndex = 9;
            // 
            // addord
            // 
            this.addord.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addord.FlatAppearance.BorderSize = 3;
            this.addord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.addord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addord.Image = ((System.Drawing.Image)(resources.GetObject("addord.Image")));
            this.addord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addord.Location = new System.Drawing.Point(719, 26);
            this.addord.Name = "addord";
            this.addord.Size = new System.Drawing.Size(103, 41);
            this.addord.TabIndex = 4;
            this.addord.Text = "Paid";
            this.addord.UseVisualStyleBackColor = false;
            this.addord.Click += new System.EventHandler(this.AddordClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // srchcmbo
            // 
            this.srchcmbo.FormattingEnabled = true;
            this.srchcmbo.Items.AddRange(new object[] {
            "",
            "Order_ID",
            "Prod_ID",
            "Cust_ID"});
            this.srchcmbo.Location = new System.Drawing.Point(145, 46);
            this.srchcmbo.Name = "srchcmbo";
            this.srchcmbo.Size = new System.Drawing.Size(121, 21);
            this.srchcmbo.TabIndex = 1;
            this.srchcmbo.SelectedIndexChanged += new System.EventHandler(this.SrchcmboSelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(75, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(747, 313);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(75, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Search By";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.exit.Location = new System.Drawing.Point(835, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 43);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(45, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 81);
            this.button4.TabIndex = 6;
            this.button4.Text = "Order Status";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 79);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(993, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelcontent);
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            this.panelcontent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PnlSrchCust.ResumeLayout(false);
            this.PnlSrchCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button addord;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.ComboBox srchcmbo;
		private System.Windows.Forms.Panel PnlSrchCust;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
