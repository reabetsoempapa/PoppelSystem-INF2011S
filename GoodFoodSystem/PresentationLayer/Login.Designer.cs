namespace GoodFoodSystem.PresentationLayer
{
    partial class Login
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
            this.loginButton = new System.Windows.Forms.Button();
            this.customerIDTextbox = new System.Windows.Forms.TextBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(155, 225);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(165, 27);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // customerIDTextbox
            // 
            this.customerIDTextbox.Location = new System.Drawing.Point(233, 114);
            this.customerIDTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDTextbox.Name = "customerIDTextbox";
            this.customerIDTextbox.Size = new System.Drawing.Size(161, 20);
            this.customerIDTextbox.TabIndex = 3;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.customerIDLabel.Location = new System.Drawing.Point(104, 113);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(82, 19);
            this.customerIDLabel.TabIndex = 4;
            this.customerIDLabel.Text = "EmployeeID";
            this.customerIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.Location = new System.Drawing.Point(131, 23);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(213, 30);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Welcome to Poppel!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label1.Location = new System.Drawing.Point(104, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 169);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(480, 297);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.customerIDTextbox);
            this.Controls.Add(this.loginButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox customerIDTextbox;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}