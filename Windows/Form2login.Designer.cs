
namespace Windows
{
    partial class login
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(601, 258);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 1;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(740, 258);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(601, 168);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(214, 22);
            this.passbox.TabIndex = 4;
            this.passbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passbox_KeyPress);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(601, 83);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(214, 22);
            this.idbox.TabIndex = 5;
            this.idbox.TextChanged += new System.EventHandler(this.idbox_TextChanged);
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Location = new System.Drawing.Point(482, 79);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(53, 17);
            this.txtid.TabIndex = 6;
            this.txtid.Text = "User Id";
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.Location = new System.Drawing.Point(482, 171);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(69, 17);
            this.txtpass.TabIndex = 7;
            this.txtpass.Text = "Password";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 539);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.loginbtn);
            this.Name = "login";
            this.Text = "LogInPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Label txtpass;
    }
}