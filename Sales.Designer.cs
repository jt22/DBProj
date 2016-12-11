/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 5:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project
{
	partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.panelcontent = new System.Windows.Forms.Panel();
            this.sukibut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.suki = new System.Windows.Forms.Panel();
            this.sukidatagrid1 = new System.Windows.Forms.DataGridView();
            this.PnlSrchCust = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthcmbo = new System.Windows.Forms.ComboBox();
            this.yearcmbo = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.suki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sukidatagrid1)).BeginInit();
            this.PnlSrchCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontent
            // 
            this.panelcontent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelcontent.Controls.Add(this.sukibut);
            this.panelcontent.Controls.Add(this.panel1);
            this.panelcontent.Controls.Add(this.exit);
            this.panelcontent.Controls.Add(this.button4);
            this.panelcontent.Location = new System.Drawing.Point(0, 89);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(996, 580);
            this.panelcontent.TabIndex = 1;
            // 
            // sukibut
            // 
            this.sukibut.BackColor = System.Drawing.Color.Black;
            this.sukibut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sukibut.FlatAppearance.BorderSize = 2;
            this.sukibut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.sukibut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sukibut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sukibut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukibut.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.sukibut.Image = ((System.Drawing.Image)(resources.GetObject("sukibut.Image")));
            this.sukibut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sukibut.Location = new System.Drawing.Point(245, 0);
            this.sukibut.Margin = new System.Windows.Forms.Padding(0);
            this.sukibut.Name = "sukibut";
            this.sukibut.Size = new System.Drawing.Size(200, 81);
            this.sukibut.TabIndex = 11;
            this.sukibut.Text = "Suki";
            this.sukibut.UseVisualStyleBackColor = false;
            this.sukibut.Click += new System.EventHandler(this.SukibutClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.suki);
            this.panel1.Controls.Add(this.PnlSrchCust);
            this.panel1.Location = new System.Drawing.Point(45, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 471);
            this.panel1.TabIndex = 10;
            // 
            // suki
            // 
            this.suki.BackColor = System.Drawing.Color.PowderBlue;
            this.suki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.suki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.suki.Controls.Add(this.sukidatagrid1);
            this.suki.Location = new System.Drawing.Point(0, 0);
            this.suki.Name = "suki";
            this.suki.Size = new System.Drawing.Size(897, 471);
            this.suki.TabIndex = 10;
            this.suki.Visible = false;
            // 
            // sukidatagrid1
            // 
            this.sukidatagrid1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.sukidatagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sukidatagrid1.Location = new System.Drawing.Point(77, 73);
            this.sukidatagrid1.Name = "sukidatagrid1";
            this.sukidatagrid1.Size = new System.Drawing.Size(638, 313);
            this.sukidatagrid1.TabIndex = 0;
            this.sukidatagrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sukidatagrid1CellContentClick);
            // 
            // PnlSrchCust
            // 
            this.PnlSrchCust.BackColor = System.Drawing.Color.PowderBlue;
            this.PnlSrchCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlSrchCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlSrchCust.Controls.Add(this.dataGridView1);
            this.PnlSrchCust.Controls.Add(this.button1);
            this.PnlSrchCust.Controls.Add(this.label1);
            this.PnlSrchCust.Controls.Add(this.monthcmbo);
            this.PnlSrchCust.Controls.Add(this.yearcmbo);
            this.PnlSrchCust.Controls.Add(this.dataGridView2);
            this.PnlSrchCust.Controls.Add(this.label8);
            this.PnlSrchCust.Location = new System.Drawing.Point(0, 0);
            this.PnlSrchCust.Name = "PnlSrchCust";
            this.PnlSrchCust.Size = new System.Drawing.Size(897, 471);
            this.PnlSrchCust.TabIndex = 9;
            this.PnlSrchCust.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(143, 68);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(673, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Graph";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(272, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Month";
            this.label1.Click += new System.EventHandler(this.Label1Click);
            // 
            // monthcmbo
            // 
            this.monthcmbo.FormattingEnabled = true;
            this.monthcmbo.Items.AddRange(new object[] {
            ""});
            this.monthcmbo.Location = new System.Drawing.Point(322, 26);
            this.monthcmbo.Name = "monthcmbo";
            this.monthcmbo.Size = new System.Drawing.Size(121, 21);
            this.monthcmbo.TabIndex = 5;
            this.monthcmbo.SelectedIndexChanged += new System.EventHandler(this.MonthcmboSelectedIndexChanged);
            // 
            // yearcmbo
            // 
            this.yearcmbo.FormattingEnabled = true;
            this.yearcmbo.Items.AddRange(new object[] {
            ""});
            this.yearcmbo.Location = new System.Drawing.Point(123, 28);
            this.yearcmbo.Name = "yearcmbo";
            this.yearcmbo.Size = new System.Drawing.Size(121, 21);
            this.yearcmbo.TabIndex = 1;
            this.yearcmbo.SelectedIndexChanged += new System.EventHandler(this.YearcmboSelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(75, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(486, 313);
            this.dataGridView2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(75, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Year";
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
            this.button4.Text = "Sales";
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
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(993, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelcontent);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panelcontent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.suki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sukidatagrid1)).EndInit();
            this.PnlSrchCust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox monthcmbo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.ComboBox yearcmbo;
		private System.Windows.Forms.Panel PnlSrchCust;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Panel panelcontent;
		private System.Windows.Forms.Panel suki;
		private System.Windows.Forms.DataGridView sukidatagrid1;
		private System.Windows.Forms.Button sukibut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
