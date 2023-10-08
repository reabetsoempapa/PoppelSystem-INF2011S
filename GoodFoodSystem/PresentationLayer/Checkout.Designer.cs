namespace GoodFoodSystem.PresentationLayer
{
    partial class Checkout
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddressT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderTotalTextbox = new System.Windows.Forms.TextBox();
            this.PaymentCombo = new System.Windows.Forms.ComboBox();
            this.SubmitB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIDTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "mm/dd/yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(400, 134);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 10, 16, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // AddressT
            // 
            this.AddressT.ForeColor = System.Drawing.SystemColors.Control;
            this.AddressT.Location = new System.Drawing.Point(400, 83);
            this.AddressT.Name = "AddressT";
            this.AddressT.Size = new System.Drawing.Size(100, 20);
            this.AddressT.TabIndex = 2;
            this.AddressT.TextChanged += new System.EventHandler(this.AddressT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label3.Location = new System.Drawing.Point(230, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label4.Location = new System.Drawing.Point(230, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Delivery Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label5.Location = new System.Drawing.Point(230, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oder Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label7.Location = new System.Drawing.Point(235, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // OrderTotalTextbox
            // 
            this.OrderTotalTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.OrderTotalTextbox.Location = new System.Drawing.Point(400, 290);
            this.OrderTotalTextbox.Name = "OrderTotalTextbox";
            this.OrderTotalTextbox.Size = new System.Drawing.Size(100, 20);
            this.OrderTotalTextbox.TabIndex = 9;
            this.OrderTotalTextbox.TextChanged += new System.EventHandler(this.OrderTotal_TextChanged);
            // 
            // PaymentCombo
            // 
            this.PaymentCombo.BackColor = System.Drawing.SystemColors.Window;
            this.PaymentCombo.FormattingEnabled = true;
            this.PaymentCombo.Items.AddRange(new object[] {
            "Cash",
            "EFT"});
            this.PaymentCombo.Location = new System.Drawing.Point(400, 178);
            this.PaymentCombo.Name = "PaymentCombo";
            this.PaymentCombo.Size = new System.Drawing.Size(121, 21);
            this.PaymentCombo.TabIndex = 12;
            // 
            // SubmitB
            // 
            this.SubmitB.BackColor = System.Drawing.Color.MistyRose;
            this.SubmitB.Location = new System.Drawing.Point(322, 375);
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.Size = new System.Drawing.Size(101, 32);
            this.SubmitB.TabIndex = 13;
            this.SubmitB.Text = "Submit Order";
            this.SubmitB.UseVisualStyleBackColor = false;
            this.SubmitB.Click += new System.EventHandler(this.SubmitB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label2.Location = new System.Drawing.Point(230, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Order ID";
            // 
            // orderIDTextbox
            // 
            this.orderIDTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.orderIDTextbox.Location = new System.Drawing.Point(400, 235);
            this.orderIDTextbox.Name = "orderIDTextbox";
            this.orderIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.orderIDTextbox.TabIndex = 15;
            this.orderIDTextbox.TextChanged += new System.EventHandler(this.orderIDTextbox_TextChanged);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderIDTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubmitB);
            this.Controls.Add(this.PaymentCombo);
            this.Controls.Add(this.OrderTotalTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressT);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox AddressT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OrderTotalTextbox;
        private System.Windows.Forms.ComboBox PaymentCombo;
        private System.Windows.Forms.Button SubmitB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderIDTextbox;
    }
}