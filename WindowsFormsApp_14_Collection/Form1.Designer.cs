namespace WindowsFormsApp_14_Collection
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
            this.ID = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.f_Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(212, 142);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(252, 21);
            this.ID.TabIndex = 0;
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(212, 182);
            this.PW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(252, 21);
            this.PW.TabIndex = 0;
            // 
            // f_Select
            // 
            this.f_Select.Location = new System.Drawing.Point(19, 27);
            this.f_Select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f_Select.Name = "f_Select";
            this.f_Select.Size = new System.Drawing.Size(117, 66);
            this.f_Select.TabIndex = 1;
            this.f_Select.Text = "File Select";
            this.f_Select.UseVisualStyleBackColor = true;
            this.f_Select.Click += new System.EventHandler(this.f_Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(496, 142);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(66, 60);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f_Select);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.Button f_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
    }
}

