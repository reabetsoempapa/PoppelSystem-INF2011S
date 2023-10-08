namespace GoodFoodSystem.PresentationLayer
{
    partial class CustomerListingForm
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
            this.customerListLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold);
            this.customerListLabel.Location = new System.Drawing.Point(448, 9);
            this.customerListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(147, 30);
            this.customerListLabel.TabIndex = 1;
            this.customerListLabel.Text = "Customer List";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(939, 467);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 39);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerListView
            // 
            this.customerListView.BackColor = System.Drawing.Color.Pink;
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(53, 41);
            this.customerListView.Margin = new System.Windows.Forms.Padding(2);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(973, 422);
            this.customerListView.TabIndex = 3;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            // 
            // CustomerListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1028, 517);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customerListLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerListingForm";
            this.Text = "CustomerListingForm";
            this.Activated += new System.EventHandler(this.CustomerListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerListingForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView customerListView;
    }
}