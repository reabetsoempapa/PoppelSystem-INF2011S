namespace GoodFoodSystem.PresentationLayer
{
    partial class PickingList
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
            this.pickingListLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.supplierTextbox = new System.Windows.Forms.TextBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.productIDTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.expiryDateTextbox = new System.Windows.Forms.TextBox();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.pickingListView = new System.Windows.Forms.ListView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pickingListLabel
            // 
            this.pickingListLabel.AutoSize = true;
            this.pickingListLabel.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold);
            this.pickingListLabel.Location = new System.Drawing.Point(327, 9);
            this.pickingListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickingListLabel.Name = "pickingListLabel";
            this.pickingListLabel.Size = new System.Drawing.Size(180, 30);
            this.pickingListLabel.TabIndex = 1;
            this.pickingListLabel.Text = "Expired Products";
            this.pickingListLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(87, 378);
            this.productIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(55, 13);
            this.productIDLabel.TabIndex = 2;
            this.productIDLabel.Text = "ProductID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(87, 414);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(87, 453);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(87, 489);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(88, 527);
            this.supplierLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(45, 13);
            this.supplierLabel.TabIndex = 6;
            this.supplierLabel.Text = "Supplier";
            this.supplierLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(87, 562);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(272, 557);
            this.quantityTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(220, 20);
            this.quantityTextbox.TabIndex = 8;
            // 
            // supplierTextbox
            // 
            this.supplierTextbox.Location = new System.Drawing.Point(272, 522);
            this.supplierTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.supplierTextbox.Name = "supplierTextbox";
            this.supplierTextbox.Size = new System.Drawing.Size(220, 20);
            this.supplierTextbox.TabIndex = 9;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(272, 489);
            this.priceTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(220, 20);
            this.priceTextbox.TabIndex = 10;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(272, 453);
            this.descriptionTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(220, 20);
            this.descriptionTextbox.TabIndex = 11;
            // 
            // productIDTextbox
            // 
            this.productIDTextbox.Location = new System.Drawing.Point(272, 373);
            this.productIDTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.productIDTextbox.Name = "productIDTextbox";
            this.productIDTextbox.Size = new System.Drawing.Size(220, 20);
            this.productIDTextbox.TabIndex = 12;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(272, 412);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(220, 20);
            this.nameTextbox.TabIndex = 13;
            // 
            // expiryDateTextbox
            // 
            this.expiryDateTextbox.Location = new System.Drawing.Point(274, 599);
            this.expiryDateTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.expiryDateTextbox.Name = "expiryDateTextbox";
            this.expiryDateTextbox.Size = new System.Drawing.Size(220, 20);
            this.expiryDateTextbox.TabIndex = 15;
            this.expiryDateTextbox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Location = new System.Drawing.Point(88, 599);
            this.expiryDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(61, 13);
            this.expiryDateLabel.TabIndex = 14;
            this.expiryDateLabel.Text = "Expiry Date";
            this.expiryDateLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(626, 551);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 37);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(540, 551);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(64, 37);
            this.confirmButton.TabIndex = 17;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // pickingListView
            // 
            this.pickingListView.BackColor = System.Drawing.Color.Pink;
            this.pickingListView.HideSelection = false;
            this.pickingListView.Location = new System.Drawing.Point(25, 46);
            this.pickingListView.Margin = new System.Windows.Forms.Padding(2);
            this.pickingListView.Name = "pickingListView";
            this.pickingListView.Size = new System.Drawing.Size(716, 305);
            this.pickingListView.TabIndex = 18;
            this.pickingListView.UseCompatibleStateImageBehavior = false;
            this.pickingListView.SelectedIndexChanged += new System.EventHandler(this.pickingListView_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(707, 551);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 37);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PickingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(776, 609);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pickingListView);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.expiryDateTextbox);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.productIDTextbox);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.supplierTextbox);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.pickingListLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PickingList";
            this.Text = "PickingList";
            this.Activated += new System.EventHandler(this.PickingList_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PickingList_FormClosed);
            this.Load += new System.EventHandler(this.PickingList_Load);
            this.Click += new System.EventHandler(this.deleteButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pickingListLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.TextBox supplierTextbox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.TextBox productIDTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox expiryDateTextbox;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ListView pickingListView;
        private System.Windows.Forms.Button cancelButton;
    }
}