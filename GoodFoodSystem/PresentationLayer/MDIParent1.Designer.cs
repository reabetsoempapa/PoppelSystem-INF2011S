namespace GoodFoodSystem.PresentationLayer
{
    partial class MDIParent1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.createOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.custListToolStripMenuItem,
            this.createNewCustomerToolStripMenuItem});
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.CustomerToolStripMenuItem.Text = "Customer";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // custListToolStripMenuItem
            // 
            this.custListToolStripMenuItem.Name = "custListToolStripMenuItem";
            this.custListToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.custListToolStripMenuItem.Text = "List";
            this.custListToolStripMenuItem.Click += new System.EventHandler(this.custrListToolStripMenuItem_Click);
            // 
            // createNewCustomerToolStripMenuItem
            // 
            this.createNewCustomerToolStripMenuItem.Name = "createNewCustomerToolStripMenuItem";
            this.createNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.createNewCustomerToolStripMenuItem.Text = "Create New Customer";
            this.createNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.createNewCustomerToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productListToolStripMenuItem1});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // productListToolStripMenuItem1
            // 
            this.productListToolStripMenuItem1.Name = "productListToolStripMenuItem1";
            this.productListToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.productListToolStripMenuItem1.Text = "List";
            this.productListToolStripMenuItem1.Click += new System.EventHandler(this.productListToolStripMenuItem1_Click);
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.createOrderToolStripMenuItem.Text = "Create Order";
            this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::GoodFoodSystem.Properties.Resources.Poppel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 428);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
    }
}