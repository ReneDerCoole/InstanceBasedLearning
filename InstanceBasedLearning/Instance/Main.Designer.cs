﻿namespace Instance
{
	partial class Main
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonTrue = new System.Windows.Forms.Button();
			this.buttonFalse = new System.Windows.Forms.Button();
			this.buttonRequest = new System.Windows.Forms.Button();
			this.display = new System.Windows.Forms.Panel();
			this.buttonPlus = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonTrue
			// 
			this.buttonTrue.Location = new System.Drawing.Point(12, 20);
			this.buttonTrue.Name = "buttonTrue";
			this.buttonTrue.Size = new System.Drawing.Size(83, 23);
			this.buttonTrue.TabIndex = 0;
			this.buttonTrue.Text = "Wahr";
			this.buttonTrue.UseVisualStyleBackColor = true;
			this.buttonTrue.Click += new System.EventHandler(this.True_Click);
			// 
			// buttonFalse
			// 
			this.buttonFalse.Location = new System.Drawing.Point(12, 49);
			this.buttonFalse.Name = "buttonFalse";
			this.buttonFalse.Size = new System.Drawing.Size(83, 23);
			this.buttonFalse.TabIndex = 1;
			this.buttonFalse.Text = "Falsch";
			this.buttonFalse.UseVisualStyleBackColor = true;
			this.buttonFalse.Click += new System.EventHandler(this.False_Click);
			// 
			// buttonRequest
			// 
			this.buttonRequest.Location = new System.Drawing.Point(12, 78);
			this.buttonRequest.Name = "buttonRequest";
			this.buttonRequest.Size = new System.Drawing.Size(83, 23);
			this.buttonRequest.TabIndex = 2;
			this.buttonRequest.Text = "Abfrage";
			this.buttonRequest.UseVisualStyleBackColor = true;
			this.buttonRequest.Click += new System.EventHandler(this.Request_Click);
			// 
			// display
			// 
			this.display.BackColor = System.Drawing.Color.Transparent;
			this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.display.Location = new System.Drawing.Point(150, 20);
			this.display.Name = "display";
			this.display.Size = new System.Drawing.Size(600, 400);
			this.display.TabIndex = 3;
			this.display.Click += new System.EventHandler(this.Display_Click);
			// 
			// buttonPlus
			// 
			this.buttonPlus.Location = new System.Drawing.Point(12, 385);
			this.buttonPlus.Name = "buttonPlus";
			this.buttonPlus.Size = new System.Drawing.Size(25, 25);
			this.buttonPlus.TabIndex = 4;
			this.buttonPlus.Text = "+";
			this.buttonPlus.UseVisualStyleBackColor = true;
			this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(43, 385);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(25, 25);
			this.button1.TabIndex = 5;
			this.button1.Text = "-";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 391);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Auswertung: ";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonPlus);
			this.Controls.Add(this.display);
			this.Controls.Add(this.buttonRequest);
			this.Controls.Add(this.buttonFalse);
			this.Controls.Add(this.buttonTrue);
			this.Name = "Main";
			this.Text = "Instance based Learning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonTrue;
		private System.Windows.Forms.Button buttonFalse;
		private System.Windows.Forms.Button buttonRequest;
		private System.Windows.Forms.Panel display;
		private System.Windows.Forms.Button buttonPlus;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

