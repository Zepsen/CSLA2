namespace CSLA
{
    partial class Form1
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.btn_Get = new System.Windows.Forms.Button();
            this.num_Id = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(156, 214);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(89, 23);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(40, 120);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 14;
            this.label_Email.Text = "Email";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(40, 75);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(55, 13);
            this.label_LastName.TabIndex = 13;
            this.label_LastName.Text = "LastName";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(43, 136);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(202, 20);
            this.textBox_Email.TabIndex = 12;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(43, 91);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(202, 20);
            this.textBox_LastName.TabIndex = 11;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(43, 39);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(202, 20);
            this.textBox_FirstName.TabIndex = 10;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(40, 23);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(54, 13);
            this.label_FirstName.TabIndex = 9;
            this.label_FirstName.Text = "FirstName";
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(43, 214);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(89, 23);
            this.btn_Get.TabIndex = 8;
            this.btn_Get.Text = "Get";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Visible = false;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // num_Id
            // 
            this.num_Id.Location = new System.Drawing.Point(43, 188);
            this.num_Id.Name = "num_Id";
            this.num_Id.Size = new System.Drawing.Size(89, 20);
            this.num_Id.TabIndex = 16;
            this.num_Id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Id.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.num_Id);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.btn_Get);
            this.Name = "Form1";
            this.Text = "CSLA";
            ((System.ComponentModel.ISupportInitialize)(this.num_Id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.NumericUpDown num_Id;
    }
}

