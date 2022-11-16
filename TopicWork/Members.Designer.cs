namespace TopicWork
{
	partial class Members
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.searchButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.identityNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractExpiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.memberIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.memberIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.identityNumberDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.contractExpiredDataGridViewTextBoxColumn,
            this.phoneBrandDataGridViewTextBoxColumn,
            this.phoneModelDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.memberIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(34, 84);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(745, 306);
			this.dataGridView1.TabIndex = 0;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(222, 37);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(34, 38);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(156, 22);
			this.textBox1.TabIndex = 2;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "用戶姓名";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// identityNumberDataGridViewTextBoxColumn
			// 
			this.identityNumberDataGridViewTextBoxColumn.DataPropertyName = "IdentityNumber";
			this.identityNumberDataGridViewTextBoxColumn.HeaderText = "身分證號碼";
			this.identityNumberDataGridViewTextBoxColumn.Name = "identityNumberDataGridViewTextBoxColumn";
			this.identityNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "電話號碼";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// contractExpiredDataGridViewTextBoxColumn
			// 
			this.contractExpiredDataGridViewTextBoxColumn.DataPropertyName = "ContractExpired";
			this.contractExpiredDataGridViewTextBoxColumn.HeaderText = "合約到期日";
			this.contractExpiredDataGridViewTextBoxColumn.Name = "contractExpiredDataGridViewTextBoxColumn";
			this.contractExpiredDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneBrandDataGridViewTextBoxColumn
			// 
			this.phoneBrandDataGridViewTextBoxColumn.DataPropertyName = "PhoneBrand";
			this.phoneBrandDataGridViewTextBoxColumn.HeaderText = "手機品牌";
			this.phoneBrandDataGridViewTextBoxColumn.Name = "phoneBrandDataGridViewTextBoxColumn";
			this.phoneBrandDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneModelDataGridViewTextBoxColumn
			// 
			this.phoneModelDataGridViewTextBoxColumn.DataPropertyName = "PhoneModel";
			this.phoneModelDataGridViewTextBoxColumn.HeaderText = "手機型號";
			this.phoneModelDataGridViewTextBoxColumn.Name = "phoneModelDataGridViewTextBoxColumn";
			this.phoneModelDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// memberIndexVMBindingSource
			// 
			this.memberIndexVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.MemberIndexVM);
			// 
			// Members
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Members";
			this.Text = "Members";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.memberIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource memberIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn identityNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contractExpiredDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneBrandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneModelDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox textBox1;
	}
}