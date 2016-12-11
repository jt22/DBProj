/*
 * Created by SharpDevelop.
 * User: Bernard
 * Date: 9/4/2016
 * Time: 1:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PnlOrd = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pnlinord = new System.Windows.Forms.Panel();
			this.ordtextBox3 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.ordtextBox2 = new System.Windows.Forms.TextBox();
			this.ordcomboBox2 = new System.Windows.Forms.ComboBox();
			this.delord = new System.Windows.Forms.Button();
			this.ordcomboBox1 = new System.Windows.Forms.ComboBox();
			this.editord = new System.Windows.Forms.Button();
			this.addord = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ordtextBox1 = new System.Windows.Forms.TextBox();
			this.PnlOrd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.pnlinord.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlOrd
			// 
			this.PnlOrd.BackColor = System.Drawing.Color.PowderBlue;
			this.PnlOrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PnlOrd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlOrd.Controls.Add(this.dataGridView1);
			this.PnlOrd.Controls.Add(this.pnlinord);
			this.PnlOrd.Location = new System.Drawing.Point(43, 56);
			this.PnlOrd.Name = "PnlOrd";
			this.PnlOrd.Size = new System.Drawing.Size(897, 471);
			this.PnlOrd.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.Color.PaleTurquoise;
			this.dataGridView1.Location = new System.Drawing.Point(34, 275);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(736, 176);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// pnlinord
			// 
			this.pnlinord.BackColor = System.Drawing.Color.DarkSlateGray;
			this.pnlinord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlinord.Controls.Add(this.ordtextBox3);
			this.pnlinord.Controls.Add(this.dateTimePicker1);
			this.pnlinord.Controls.Add(this.label5);
			this.pnlinord.Controls.Add(this.ordtextBox2);
			this.pnlinord.Controls.Add(this.ordcomboBox2);
			this.pnlinord.Controls.Add(this.delord);
			this.pnlinord.Controls.Add(this.ordcomboBox1);
			this.pnlinord.Controls.Add(this.editord);
			this.pnlinord.Controls.Add(this.addord);
			this.pnlinord.Controls.Add(this.label4);
			this.pnlinord.Controls.Add(this.label3);
			this.pnlinord.Controls.Add(this.label2);
			this.pnlinord.Controls.Add(this.label1);
			this.pnlinord.Controls.Add(this.ordtextBox1);
			this.pnlinord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlinord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.pnlinord.Location = new System.Drawing.Point(34, 14);
			this.pnlinord.Name = "pnlinord";
			this.pnlinord.Size = new System.Drawing.Size(666, 255);
			this.pnlinord.TabIndex = 2;
			// 
			// ordtextBox3
			// 
			this.ordtextBox3.Location = new System.Drawing.Point(302, 42);
			this.ordtextBox3.Name = "ordtextBox3";
			this.ordtextBox3.Size = new System.Drawing.Size(100, 26);
			this.ordtextBox3.TabIndex = 19;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(302, 115);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
			this.dateTimePicker1.TabIndex = 18;
			this.dateTimePicker1.Value = new System.DateTime(2016, 9, 10, 0, 0, 0, 0);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Quantity";
			// 
			// ordtextBox2
			// 
			this.ordtextBox2.Location = new System.Drawing.Point(3, 184);
			this.ordtextBox2.Name = "ordtextBox2";
			this.ordtextBox2.Size = new System.Drawing.Size(100, 26);
			this.ordtextBox2.TabIndex = 16;
			this.ordtextBox2.TextChanged += new System.EventHandler(this.OrdtextBox2TextChanged);
			// 
			// ordcomboBox2
			// 
			this.ordcomboBox2.FormattingEnabled = true;
			this.ordcomboBox2.Location = new System.Drawing.Point(146, 117);
			this.ordcomboBox2.Name = "ordcomboBox2";
			this.ordcomboBox2.Size = new System.Drawing.Size(121, 28);
			this.ordcomboBox2.TabIndex = 15;
			this.ordcomboBox2.SelectedIndexChanged += new System.EventHandler(this.OrdcomboBox2SelectedIndexChanged);
			// 
			// delord
			// 
			this.delord.BackColor = System.Drawing.Color.Transparent;
			this.delord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.delord.FlatAppearance.BorderSize = 3;
			this.delord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.delord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.delord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.delord.Image = ((System.Drawing.Image)(resources.GetObject("delord.Image")));
			this.delord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.delord.Location = new System.Drawing.Point(542, 110);
			this.delord.Name = "delord";
			this.delord.Size = new System.Drawing.Size(103, 41);
			this.delord.TabIndex = 2;
			this.delord.Text = "Delete";
			this.delord.UseVisualStyleBackColor = false;
			// 
			// ordcomboBox1
			// 
			this.ordcomboBox1.FormattingEnabled = true;
			this.ordcomboBox1.Location = new System.Drawing.Point(3, 117);
			this.ordcomboBox1.Name = "ordcomboBox1";
			this.ordcomboBox1.Size = new System.Drawing.Size(121, 28);
			this.ordcomboBox1.TabIndex = 14;
			// 
			// editord
			// 
			this.editord.BackColor = System.Drawing.Color.Transparent;
			this.editord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.editord.FlatAppearance.BorderSize = 3;
			this.editord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.editord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.editord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.editord.Image = ((System.Drawing.Image)(resources.GetObject("editord.Image")));
			this.editord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.editord.Location = new System.Drawing.Point(542, 63);
			this.editord.Name = "editord";
			this.editord.Size = new System.Drawing.Size(103, 41);
			this.editord.TabIndex = 1;
			this.editord.Text = "Edit";
			this.editord.UseVisualStyleBackColor = false;
			this.editord.Click += new System.EventHandler(this.EditordClick);
			// 
			// addord
			// 
			this.addord.BackColor = System.Drawing.Color.Transparent;
			this.addord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addord.FlatAppearance.BorderSize = 3;
			this.addord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.addord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.addord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.addord.Image = ((System.Drawing.Image)(resources.GetObject("addord.Image")));
			this.addord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addord.Location = new System.Drawing.Point(542, 16);
			this.addord.Name = "addord";
			this.addord.Size = new System.Drawing.Size(103, 41);
			this.addord.TabIndex = 0;
			this.addord.Text = "Add";
			this.addord.UseVisualStyleBackColor = false;
			this.addord.Click += new System.EventHandler(this.AddordClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(302, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Date";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(144, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Product ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Customer ID";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(3, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Order ID";
			// 
			// ordtextBox1
			// 
			this.ordtextBox1.Enabled = false;
			this.ordtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ordtextBox1.Location = new System.Drawing.Point(3, 52);
			this.ordtextBox1.Name = "ordtextBox1";
			this.ordtextBox1.Size = new System.Drawing.Size(100, 26);
			this.ordtextBox1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 582);
			this.Controls.Add(this.PnlOrd);
			this.Name = "MainForm";
			this.Text = "Project";
			this.PnlOrd.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.pnlinord.ResumeLayout(false);
			this.pnlinord.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox ordtextBox3;
		private System.Windows.Forms.ComboBox ordcomboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox ordtextBox1;
		private System.Windows.Forms.TextBox ordtextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button addord;
		private System.Windows.Forms.Button editord;
		private System.Windows.Forms.ComboBox ordcomboBox1;
		private System.Windows.Forms.Button delord;
		private System.Windows.Forms.Panel pnlinord;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel PnlOrd;
	}
}
