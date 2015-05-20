namespace InformixClient
{
	partial class frmAdd
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
			this.btnSave = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtPerson = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.txtBuilding = new System.Windows.Forms.TextBox();
			this.txtAppartment = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(12, 168);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(185, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(70, 12);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(127, 20);
			this.txtId.TabIndex = 1;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(70, 38);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(127, 20);
			this.txtPhone.TabIndex = 2;
			// 
			// txtPerson
			// 
			this.txtPerson.Location = new System.Drawing.Point(70, 64);
			this.txtPerson.Name = "txtPerson";
			this.txtPerson.Size = new System.Drawing.Size(127, 20);
			this.txtPerson.TabIndex = 3;
			// 
			// txtStreet
			// 
			this.txtStreet.Location = new System.Drawing.Point(70, 90);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(127, 20);
			this.txtStreet.TabIndex = 4;
			// 
			// txtBuilding
			// 
			this.txtBuilding.Location = new System.Drawing.Point(70, 116);
			this.txtBuilding.Name = "txtBuilding";
			this.txtBuilding.Size = new System.Drawing.Size(127, 20);
			this.txtBuilding.TabIndex = 5;
			// 
			// txtAppartment
			// 
			this.txtAppartment.Location = new System.Drawing.Point(70, 142);
			this.txtAppartment.Name = "txtAppartment";
			this.txtAppartment.Size = new System.Drawing.Size(127, 20);
			this.txtAppartment.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Ид";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Телефон";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "ФИО";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Улица";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Дом";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Квартира";
			// 
			// frmAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 200);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAppartment);
			this.Controls.Add(this.txtBuilding);
			this.Controls.Add(this.txtStreet);
			this.Controls.Add(this.txtPerson);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавить / Изменить";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtPerson;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.TextBox txtBuilding;
		private System.Windows.Forms.TextBox txtAppartment;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}