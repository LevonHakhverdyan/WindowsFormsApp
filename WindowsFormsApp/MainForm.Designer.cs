
namespace WindowsFormsApp
{
    partial class MainForm
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
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGridView
            // 
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(12, 312);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowHeadersWidth = 62;
            this.customerGridView.RowTemplate.Height = 28;
            this.customerGridView.Size = new System.Drawing.Size(1266, 216);
            this.customerGridView.TabIndex = 0;
            this.customerGridView.SelectionChanged+= new System.EventHandler(this.CustomerGridView_SelectionChanged);
            this.customerGridView.BackgroundColor = System.Drawing.Color.White;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(12, 19);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(86, 20);
            this.firstNameLbl.TabIndex = 1;
            this.firstNameLbl.Text = "First Name";
            // 
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(12, 51);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(100, 26);
            this.firstNametxt.TabIndex = 2;
            // 
            // lastNametxt
            // 
            this.lastNametxt.Location = new System.Drawing.Point(227, 50);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(173, 26);
            this.lastNametxt.TabIndex = 3;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(497, 50);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(100, 26);
            this.agetxt.TabIndex = 4;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(232, 19);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(86, 20);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Last Name";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(503, 19);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(38, 20);
            this.ageLbl.TabIndex = 6;
            this.ageLbl.Text = "Age";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.Location = new System.Drawing.Point(12, 143);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 32);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.ForeColor = System.Drawing.Color.Blue;
            this.updateBtn.Location = new System.Drawing.Point(261, 143);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 32);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(497, 143);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 32);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(DeleteBtn_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 564);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.firstNametxt);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.customerGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox firstNametxt;
        private System.Windows.Forms.TextBox lastNametxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

