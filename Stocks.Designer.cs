﻿/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 5:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project
{
	partial class Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            this.panelcontent = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panelprodstock = new System.Windows.Forms.Panel();
            this.PnlStock = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panelstockloob = new System.Windows.Forms.Panel();
            this.Cancelprod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlProd = new System.Windows.Forms.Panel();
            this.neword = new System.Windows.Forms.Button();
            this.delstock = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addstock = new System.Windows.Forms.Button();
            this.editstock = new System.Windows.Forms.Button();
            this.panelprodloob = new System.Windows.Forms.Panel();
            this.cancelprod1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontent.SuspendLayout();
            this.panelprodstock.SuspendLayout();
            this.PnlStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelstockloob.SuspendLayout();
            this.PnlProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelprodloob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontent
            // 
            this.panelcontent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelcontent.Controls.Add(this.button5);
            this.panelcontent.Controls.Add(this.panelprodstock);
            this.panelcontent.Controls.Add(this.exit);
            this.panelcontent.Controls.Add(this.button4);
            this.panelcontent.Location = new System.Drawing.Point(0, 89);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(996, 580);
            this.panelcontent.TabIndex = 0;
            this.panelcontent.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(245, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 81);
            this.button5.TabIndex = 10;
            this.button5.Text = "Add Stock";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // panelprodstock
            // 
            this.panelprodstock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelprodstock.Controls.Add(this.PnlStock);
            this.panelprodstock.Controls.Add(this.PnlProd);
            this.panelprodstock.Location = new System.Drawing.Point(45, 81);
            this.panelprodstock.Name = "panelprodstock";
            this.panelprodstock.Size = new System.Drawing.Size(897, 471);
            this.panelprodstock.TabIndex = 9;
            // 
            // PnlStock
            // 
            this.PnlStock.BackColor = System.Drawing.Color.PowderBlue;
            this.PnlStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlStock.Controls.Add(this.button2);
            this.PnlStock.Controls.Add(this.dataGridView2);
            this.PnlStock.Controls.Add(this.panelstockloob);
            this.PnlStock.Controls.Add(this.button3);
            this.PnlStock.Controls.Add(this.button1);
            this.PnlStock.Location = new System.Drawing.Point(0, 0);
            this.PnlStock.Name = "PnlStock";
            this.PnlStock.Size = new System.Drawing.Size(897, 471);
            this.PnlStock.TabIndex = 8;
            this.PnlStock.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(548, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 55);
            this.button2.TabIndex = 26;
            this.button2.Text = "New Stock";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(602, 176);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
            // 
            // panelstockloob
            // 
            this.panelstockloob.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelstockloob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelstockloob.Controls.Add(this.Cancelprod);
            this.panelstockloob.Controls.Add(this.label6);
            this.panelstockloob.Controls.Add(this.textBox4);
            this.panelstockloob.Controls.Add(this.comboBox2);
            this.panelstockloob.Controls.Add(this.label5);
            this.panelstockloob.Controls.Add(this.label7);
            this.panelstockloob.Controls.Add(this.textBox5);
            this.panelstockloob.Enabled = false;
            this.panelstockloob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelstockloob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelstockloob.Location = new System.Drawing.Point(34, 14);
            this.panelstockloob.Name = "panelstockloob";
            this.panelstockloob.Size = new System.Drawing.Size(508, 255);
            this.panelstockloob.TabIndex = 2;
            this.panelstockloob.Paint += new System.Windows.Forms.PaintEventHandler(this.panelstockloob_Paint);
            // 
            // Cancelprod
            // 
            this.Cancelprod.BackColor = System.Drawing.Color.Black;
            this.Cancelprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelprod.FlatAppearance.BorderSize = 2;
            this.Cancelprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Cancelprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cancelprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelprod.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Cancelprod.Location = new System.Drawing.Point(406, 193);
            this.Cancelprod.Name = "Cancelprod";
            this.Cancelprod.Size = new System.Drawing.Size(75, 43);
            this.Cancelprod.TabIndex = 26;
            this.Cancelprod.Text = "Cancel";
            this.Cancelprod.UseVisualStyleBackColor = false;
            this.Cancelprod.Click += new System.EventHandler(this.CancelprodClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(5, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 106);
            this.label6.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(7, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 12;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
            this.comboBox2.TextUpdate += new System.EventHandler(this.ComboBox2TextUpdate);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Product ID";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(7, 210);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(123, 26);
            this.textBox5.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(548, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 55);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add Stock";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(548, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit Stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // PnlProd
            // 
            this.PnlProd.BackColor = System.Drawing.Color.PowderBlue;
            this.PnlProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlProd.Controls.Add(this.neword);
            this.PnlProd.Controls.Add(this.delstock);
            this.PnlProd.Controls.Add(this.dataGridView1);
            this.PnlProd.Controls.Add(this.addstock);
            this.PnlProd.Controls.Add(this.editstock);
            this.PnlProd.Controls.Add(this.panelprodloob);
            this.PnlProd.Location = new System.Drawing.Point(0, 0);
            this.PnlProd.Name = "PnlProd";
            this.PnlProd.Size = new System.Drawing.Size(897, 471);
            this.PnlProd.TabIndex = 7;
            this.PnlProd.Visible = false;
            // 
            // neword
            // 
            this.neword.BackColor = System.Drawing.Color.Black;
            this.neword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.neword.FlatAppearance.BorderSize = 3;
            this.neword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.neword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.neword.Image = ((System.Drawing.Image)(resources.GetObject("neword.Image")));
            this.neword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.neword.Location = new System.Drawing.Point(766, 14);
            this.neword.Name = "neword";
            this.neword.Size = new System.Drawing.Size(124, 55);
            this.neword.TabIndex = 26;
            this.neword.Text = "New Product";
            this.neword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.neword.UseVisualStyleBackColor = false;
            this.neword.Click += new System.EventHandler(this.NewordClick);
            // 
            // delstock
            // 
            this.delstock.BackColor = System.Drawing.Color.Black;
            this.delstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delstock.FlatAppearance.BorderSize = 3;
            this.delstock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delstock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.delstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delstock.Image = ((System.Drawing.Image)(resources.GetObject("delstock.Image")));
            this.delstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delstock.Location = new System.Drawing.Point(766, 178);
            this.delstock.Name = "delstock";
            this.delstock.Size = new System.Drawing.Size(124, 55);
            this.delstock.TabIndex = 2;
            this.delstock.Text = "Delete Product";
            this.delstock.UseVisualStyleBackColor = false;
            this.delstock.Visible = false;
            this.delstock.Click += new System.EventHandler(this.DelstockClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 176);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
            // 
            // addstock
            // 
            this.addstock.BackColor = System.Drawing.Color.Black;
            this.addstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addstock.FlatAppearance.BorderSize = 3;
            this.addstock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addstock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.addstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addstock.Image = ((System.Drawing.Image)(resources.GetObject("addstock.Image")));
            this.addstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstock.Location = new System.Drawing.Point(766, 68);
            this.addstock.Name = "addstock";
            this.addstock.Size = new System.Drawing.Size(124, 55);
            this.addstock.TabIndex = 0;
            this.addstock.Text = "Add Product";
            this.addstock.UseVisualStyleBackColor = false;
            this.addstock.Visible = false;
            this.addstock.Click += new System.EventHandler(this.AddstockClick);
            // 
            // editstock
            // 
            this.editstock.BackColor = System.Drawing.Color.Black;
            this.editstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editstock.FlatAppearance.BorderSize = 3;
            this.editstock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editstock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.editstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editstock.Image = ((System.Drawing.Image)(resources.GetObject("editstock.Image")));
            this.editstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editstock.Location = new System.Drawing.Point(766, 123);
            this.editstock.Name = "editstock";
            this.editstock.Size = new System.Drawing.Size(124, 55);
            this.editstock.TabIndex = 1;
            this.editstock.Text = "Edit Product";
            this.editstock.UseVisualStyleBackColor = false;
            this.editstock.Visible = false;
            this.editstock.Click += new System.EventHandler(this.EditstockClick);
            // 
            // panelprodloob
            // 
            this.panelprodloob.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelprodloob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelprodloob.Controls.Add(this.cancelprod1);
            this.panelprodloob.Controls.Add(this.comboBox1);
            this.panelprodloob.Controls.Add(this.label4);
            this.panelprodloob.Controls.Add(this.label3);
            this.panelprodloob.Controls.Add(this.textBox3);
            this.panelprodloob.Controls.Add(this.label2);
            this.panelprodloob.Controls.Add(this.label1);
            this.panelprodloob.Controls.Add(this.textBox2);
            this.panelprodloob.Controls.Add(this.textBox1);
            this.panelprodloob.Enabled = false;
            this.panelprodloob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelprodloob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelprodloob.Location = new System.Drawing.Point(34, 14);
            this.panelprodloob.Name = "panelprodloob";
            this.panelprodloob.Size = new System.Drawing.Size(731, 255);
            this.panelprodloob.TabIndex = 2;
            this.panelprodloob.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelprodloobPaint);
            // 
            // cancelprod1
            // 
            this.cancelprod1.BackColor = System.Drawing.Color.Black;
            this.cancelprod1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelprod1.FlatAppearance.BorderSize = 2;
            this.cancelprod1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cancelprod1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelprod1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelprod1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cancelprod1.Location = new System.Drawing.Point(639, 193);
            this.cancelprod1.Name = "cancelprod1";
            this.cancelprod1.Size = new System.Drawing.Size(75, 43);
            this.cancelprod1.TabIndex = 27;
            this.cancelprod1.Text = "Cancel";
            this.cancelprod1.UseVisualStyleBackColor = false;
            this.cancelprod1.Click += new System.EventHandler(this.Cancelprod1Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Isuzu",
            "Fuzo",
            "Nissan",
            "Hino"});
            this.comboBox1.Location = new System.Drawing.Point(151, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(149, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Brand";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 26);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product ID";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
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
            this.button4.Text = "Add New Product";
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
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(993, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelcontent);
            this.Name = "Stocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.StocksLoad);
            this.panelcontent.ResumeLayout(false);
            this.panelprodstock.ResumeLayout(false);
            this.PnlStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelstockloob.ResumeLayout(false);
            this.panelstockloob.PerformLayout();
            this.PnlProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelprodloob.ResumeLayout(false);
            this.panelprodloob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button cancelprod1;
		private System.Windows.Forms.Button Cancelprod;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button neword;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Panel panelstockloob;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Panel PnlStock;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Panel panelprodstock;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button addstock;
		private System.Windows.Forms.Button editstock;
		private System.Windows.Forms.Button delstock;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel PnlProd;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panelprodloob;
		private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
