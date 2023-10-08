namespace GoodFoodSystem.PresentationLayer
{
    partial class ExpiredProducts
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
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.headingExpiredLabel = new System.Windows.Forms.Label();
            this.expiredProductListView = new System.Windows.Forms.ListView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(676, 419);
            this.printButton.Margin = new System.Windows.Forms.Padding(2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(61, 37);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(803, 419);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headingExpiredLabel
            // 
            this.headingExpiredLabel.AutoSize = true;
            this.headingExpiredLabel.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold);
            this.headingExpiredLabel.Location = new System.Drawing.Point(380, 9);
            this.headingExpiredLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headingExpiredLabel.Name = "headingExpiredLabel";
            this.headingExpiredLabel.Size = new System.Drawing.Size(253, 30);
            this.headingExpiredLabel.TabIndex = 3;
            this.headingExpiredLabel.Text = "Expired Products Report";
            this.headingExpiredLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // expiredProductListView
            // 
            this.expiredProductListView.BackColor = System.Drawing.Color.Pink;
            this.expiredProductListView.HideSelection = false;
            this.expiredProductListView.Location = new System.Drawing.Point(28, 46);
            this.expiredProductListView.Margin = new System.Windows.Forms.Padding(2);
            this.expiredProductListView.Name = "expiredProductListView";
            this.expiredProductListView.Size = new System.Drawing.Size(1057, 369);
            this.expiredProductListView.TabIndex = 4;
            this.expiredProductListView.UseCompatibleStateImageBehavior = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ExpiredProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1096, 498);
            this.Controls.Add(this.expiredProductListView);
            this.Controls.Add(this.headingExpiredLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExpiredProducts";
            this.Text = "ExpiredProducts";
            this.Activated += new System.EventHandler(this.ExpiredProducts_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpiredProducts_FormClosed);
            this.Load += new System.EventHandler(this.ExpiredProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label headingExpiredLabel;
        private System.Windows.Forms.ListView expiredProductListView;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}