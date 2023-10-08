﻿namespace GoodFoodSystem.PresentationLayer
{
    partial class OrderSummary
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
            this.OrderItemListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderTotalTextbox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderItemListView
            // 
            this.OrderItemListView.BackColor = System.Drawing.Color.Pink;
            this.OrderItemListView.HideSelection = false;
            this.OrderItemListView.Location = new System.Drawing.Point(134, 62);
            this.OrderItemListView.Name = "OrderItemListView";
            this.OrderItemListView.Size = new System.Drawing.Size(523, 285);
            this.OrderItemListView.TabIndex = 0;
            this.OrderItemListView.UseCompatibleStateImageBehavior = false;
            this.OrderItemListView.SelectedIndexChanged += new System.EventHandler(this.OrderItemListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Picking List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Total";
            // 
            // OrderTotalTextbox
            // 
            this.OrderTotalTextbox.Location = new System.Drawing.Point(282, 386);
            this.OrderTotalTextbox.Name = "OrderTotalTextbox";
            this.OrderTotalTextbox.Size = new System.Drawing.Size(100, 20);
            this.OrderTotalTextbox.TabIndex = 3;
            this.OrderTotalTextbox.TextChanged += new System.EventHandler(this.OrderTotalTextbox_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(498, 384);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.OrderTotalTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderItemListView);
            this.Name = "OrderSummary";
            this.Text = "OrderSummary";
            this.Activated += new System.EventHandler(this.OrderSummary_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderSummary_FormClosed);
            this.Load += new System.EventHandler(this.OrderSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OrderItemListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderTotalTextbox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button1;
    }
}