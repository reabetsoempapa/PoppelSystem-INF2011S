namespace GoodFoodSystem.PresentationLayer
{
    partial class ProductListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListingForm));
            this.productListLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.ListView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.generateExpiredListButton = new System.Windows.Forms.Button();
            this.printReportButton = new System.Windows.Forms.Button();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // productListLabel
            // 
            this.productListLabel.AutoSize = true;
            this.productListLabel.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold);
            this.productListLabel.Location = new System.Drawing.Point(427, 9);
            this.productListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productListLabel.Name = "productListLabel";
            this.productListLabel.Size = new System.Drawing.Size(131, 30);
            this.productListLabel.TabIndex = 1;
            this.productListLabel.Text = "Product List";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(950, 474);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(67, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // productListView
            // 
            this.productListView.BackColor = System.Drawing.Color.Pink;
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(41, 41);
            this.productListView.Margin = new System.Windows.Forms.Padding(2);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(945, 392);
            this.productListView.TabIndex = 3;
            this.productListView.UseCompatibleStateImageBehavior = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // generateExpiredListButton
            // 
            this.generateExpiredListButton.Location = new System.Drawing.Point(833, 474);
            this.generateExpiredListButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateExpiredListButton.Name = "generateExpiredListButton";
            this.generateExpiredListButton.Size = new System.Drawing.Size(99, 37);
            this.generateExpiredListButton.TabIndex = 4;
            this.generateExpiredListButton.Text = "Generate Expired List Report";
            this.generateExpiredListButton.UseVisualStyleBackColor = true;
            this.generateExpiredListButton.Click += new System.EventHandler(this.generateExpiredListButton_Click);
            // 
            // printReportButton
            // 
            this.printReportButton.Location = new System.Drawing.Point(714, 474);
            this.printReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(100, 37);
            this.printReportButton.TabIndex = 5;
            this.printReportButton.Text = "Print Expired List Report";
            this.printReportButton.UseVisualStyleBackColor = true;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // ProductListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1028, 522);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.generateExpiredListButton);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productListLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductListingForm";
            this.Text = "ProductListingForm";
            this.Activated += new System.EventHandler(this.ProductListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductListingForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label productListLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView productListView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button generateExpiredListButton;
        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}