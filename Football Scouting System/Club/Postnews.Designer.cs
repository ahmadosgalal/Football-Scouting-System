﻿namespace Football_Scouting_System.Club
{
	partial class Postnews
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textbox = new System.Windows.Forms.TextBox();
			this.titletext = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Magenta;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(119, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = " Date:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Magenta;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(119, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Title:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Magenta;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(119, 229);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "Text:";
			// 
			// textbox
			// 
			this.textbox.Location = new System.Drawing.Point(253, 226);
			this.textbox.Multiline = true;
			this.textbox.Name = "textbox";
			this.textbox.Size = new System.Drawing.Size(286, 128);
			this.textbox.TabIndex = 4;
			this.textbox.Text = "Max 500 characters";
			// 
			// titletext
			// 
			this.titletext.Location = new System.Drawing.Point(253, 182);
			this.titletext.Name = "titletext";
			this.titletext.Size = new System.Drawing.Size(286, 24);
			this.titletext.TabIndex = 5;
			this.titletext.Text = "Max 50 characters";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(558, 229);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 128);
			this.button1.TabIndex = 8;
			this.button1.Text = "Post";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(253, 133);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(286, 24);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Magenta;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 36);
			this.label1.TabIndex = 10;
			this.label1.Text = "Please fill all the fields:";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Magenta;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(558, 405);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(162, 50);
			this.button2.TabIndex = 11;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Postnews
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkMagenta;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(762, 493);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.titletext);
			this.Controls.Add(this.textbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Postnews";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Post official news";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostnewsForm_FormClosed);
			this.Load += new System.EventHandler(this.Postnews_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textbox;
		private System.Windows.Forms.TextBox titletext;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
	}
}