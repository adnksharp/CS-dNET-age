namespace Age
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(4, 4);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(178, 27);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.CB1SIC);
			// 
			// comboBox2
			// 
			this.comboBox2.BackColor = System.Drawing.Color.White;
			this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Enabled = false;
			this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(4, 41);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(178, 27);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.CB2SIC);
			// 
			// comboBox3
			// 
			this.comboBox3.BackColor = System.Drawing.Color.White;
			this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Enabled = false;
			this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(4, 79);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(178, 27);
			this.comboBox3.TabIndex = 3;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.CB3SIC);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.comboBox2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBox3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 60);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 114);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "label3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
			this.ClientSize = new System.Drawing.Size(218, 206);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("SF Pro Rounded", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Edad";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
	}
}

