namespace GoodFoodSystem.PresentationLayer
{
    partial class CreateOrder
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
            this.createOrderLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.ProductNameCombo = new System.Windows.Forms.ComboBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.availabilityTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIDTextbox = new System.Windows.Forms.TextBox();
            this.orderIDTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createOrderLabel
            // 
            this.createOrderLabel.AutoSize = true;
            this.createOrderLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderLabel.Location = new System.Drawing.Point(202, 18);
            this.createOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createOrderLabel.Name = "createOrderLabel";
            this.createOrderLabel.Size = new System.Drawing.Size(160, 32);
            this.createOrderLabel.TabIndex = 0;
            this.createOrderLabel.Text = "Create Order";
            this.createOrderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createOrderLabel.Click += new System.EventHandler(this.createOrderLabel_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.productNameLabel.Location = new System.Drawing.Point(189, 139);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(93, 16);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product Name";
            this.productNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.quantityLabel.Location = new System.Drawing.Point(188, 211);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(63, 19);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(142, 310);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 33);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(437, 310);
            this.addToOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(65, 33);
            this.addToOrderButton.TabIndex = 7;
            this.addToOrderButton.Text = "Checkout";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(350, 212);
            this.quantityTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(76, 20);
            this.quantityTextbox.TabIndex = 8;
            this.quantityTextbox.TextChanged += new System.EventHandler(this.quantityTextbox_TextChanged);
            // 
            // ProductNameCombo
            // 
            this.ProductNameCombo.FormattingEnabled = true;
            this.ProductNameCombo.Location = new System.Drawing.Point(350, 138);
            this.ProductNameCombo.Name = "ProductNameCombo";
            this.ProductNameCombo.Size = new System.Drawing.Size(121, 21);
            this.ProductNameCombo.TabIndex = 10;
            this.ProductNameCombo.SelectedIndexChanged += new System.EventHandler(this.ProductNameCombo_SelectedIndexChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(350, 254);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 11;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.PriceLabel.Location = new System.Drawing.Point(188, 255);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(39, 19);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Price";
            // 
            // availabilityTextbox
            // 
            this.availabilityTextbox.Location = new System.Drawing.Point(350, 171);
            this.availabilityTextbox.Name = "availabilityTextbox";
            this.availabilityTextbox.Size = new System.Drawing.Size(100, 20);
            this.availabilityTextbox.TabIndex = 13;
            this.availabilityTextbox.TextChanged += new System.EventHandler(this.availabilityTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label1.Location = new System.Drawing.Point(188, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Availabilty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(189, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "CustomerID";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // customerIDTextbox
            // 
            this.customerIDTextbox.Location = new System.Drawing.Point(350, 99);
            this.customerIDTextbox.Name = "customerIDTextbox";
            this.customerIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextbox.TabIndex = 16;
            this.customerIDTextbox.TextChanged += new System.EventHandler(this.customerIDTextbox_TextChanged);
            // 
            // orderIDTextbox
            // 
            this.orderIDTextbox.Location = new System.Drawing.Point(350, 66);
            this.orderIDTextbox.Name = "orderIDTextbox";
            this.orderIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.orderIDTextbox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(189, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "OrderID";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderIDTextbox);
            this.Controls.Add(this.customerIDTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availabilityTextbox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ProductNameCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.createOrderLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateOrder_FormClosed);
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createOrderLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.ComboBox ProductNameCombo;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox availabilityTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerIDTextbox;
        private System.Windows.Forms.TextBox orderIDTextbox;
        private System.Windows.Forms.Label label3;
    }
}