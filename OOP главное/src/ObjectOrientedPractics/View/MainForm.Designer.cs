namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Items = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.Customers = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.Carts = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.Orders = new System.Windows.Forms.TabPage();
            this.ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.tabControl1.SuspendLayout();
            this.Items.SuspendLayout();
            this.Customers.SuspendLayout();
            this.Carts.SuspendLayout();
            this.Orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Items);
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.Carts);
            this.tabControl1.Controls.Add(this.Orders);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 515);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_TabIndexChanged);
            // 
            // Items
            // 
            this.Items.Controls.Add(this.itemsTab1);
            this.Items.Location = new System.Drawing.Point(4, 22);
            this.Items.Margin = new System.Windows.Forms.Padding(2);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(2);
            this.Items.Size = new System.Drawing.Size(662, 489);
            this.Items.TabIndex = 0;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(2, 2);
            this.itemsTab1.Margin = new System.Windows.Forms.Padding(2);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(658, 485);
            this.itemsTab1.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.customersTab1);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Margin = new System.Windows.Forms.Padding(2);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(2);
            this.Customers.Size = new System.Drawing.Size(662, 489);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(2, 2);
            this.customersTab1.Margin = new System.Windows.Forms.Padding(2);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(658, 485);
            this.customersTab1.TabIndex = 0;
            // 
            // Carts
            // 
            this.Carts.Controls.Add(this.cartsTab1);
            this.Carts.Location = new System.Drawing.Point(4, 22);
            this.Carts.Name = "Carts";
            this.Carts.Size = new System.Drawing.Size(662, 489);
            this.Carts.TabIndex = 2;
            this.Carts.Text = "Carts";
            this.Carts.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            this.cartsTab1.Customers = null;
            this.cartsTab1.Items = null;
            this.cartsTab1.Location = new System.Drawing.Point(0, 0);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(662, 489);
            this.cartsTab1.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.ordersTab1);
            this.Orders.Location = new System.Drawing.Point(4, 22);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(706, 489);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            this.ordersTab1.Customers = null;
            this.ordersTab1.Location = new System.Drawing.Point(0, 0);
            this.ordersTab1.Name = "ordersTab1";
            this.ordersTab1.Size = new System.Drawing.Size(662, 489);
            this.ordersTab1.TabIndex = 0;
            this.ordersTab1.Load += new System.EventHandler(this.ordersTab1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 515);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(454, 495);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.tabControl1.ResumeLayout(false);
            this.Items.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.Carts.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Items;
        private System.Windows.Forms.TabPage Customers;
        private View.Tabs.CustomersTab customersTab1;
        private View.Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabPage Carts;
        private View.Tabs.CartsTab cartsTab1;
        private System.Windows.Forms.TabPage Orders;
        private View.Tabs.OrdersTab ordersTab1;
    }
}

