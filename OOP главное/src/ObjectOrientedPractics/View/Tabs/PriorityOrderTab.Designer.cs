namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrderTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.AmountHeaderLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.CartButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.CartButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressControl1
            // 
            address1.Apartment = "-";
            address1.Building = "-";
            address1.City = "-";
            address1.Country = "-";
            address1.Index = 666666;
            address1.Street = "-";
            this.addressControl1.Address = address1;
            this.addressControl1.Location = new System.Drawing.Point(23, 130);
            this.addressControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(487, 152);
            this.addressControl1.TabIndex = 27;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AmountLabel.Location = new System.Drawing.Point(-79, 481);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(589, 21);
            this.AmountLabel.TabIndex = 26;
            this.AmountLabel.Text = "49 999,90";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(23, 303);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.OrderItemsListBox.Size = new System.Drawing.Size(490, 160);
            this.OrderItemsListBox.TabIndex = 25;
            this.OrderItemsListBox.SelectedIndexChanged += new System.EventHandler(this.OrderItemsListBox_SelectedIndexChanged);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(86, 104);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(137, 21);
            this.StatusComboBox.TabIndex = 24;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Enabled = false;
            this.CreatedTextBox.Location = new System.Drawing.Point(86, 74);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.Size = new System.Drawing.Size(137, 20);
            this.CreatedTextBox.TabIndex = 23;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(86, 44);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(137, 20);
            this.IdTextBox.TabIndex = 22;
            // 
            // AmountHeaderLabel
            // 
            this.AmountHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountHeaderLabel.AutoSize = true;
            this.AmountHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AmountHeaderLabel.Location = new System.Drawing.Point(441, 466);
            this.AmountHeaderLabel.Name = "AmountHeaderLabel";
            this.AmountHeaderLabel.Size = new System.Drawing.Size(53, 13);
            this.AmountHeaderLabel.TabIndex = 21;
            this.AmountHeaderLabel.Text = "Amount:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(20, 107);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(20, 77);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 19;
            this.CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(20, 47);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(24, 13);
            this.IdLabel.TabIndex = 18;
            this.IdLabel.Text = "ID: ";
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(20, 287);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(72, 13);
            this.OrderItemsLabel.TabIndex = 17;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(20, 17);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(92, 13);
            this.SelectedOrderLabel.TabIndex = 16;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(259, 17);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(93, 13);
            this.PriorityOptionsLabel.TabIndex = 16;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(342, 43);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(137, 21);
            this.DeliveryTimeComboBox.TabIndex = 24;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(259, 47);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(77, 13);
            this.DeliveryTimeLabel.TabIndex = 18;
            this.DeliveryTimeLabel.Text = "Delivery Time: ";
            this.DeliveryTimeLabel.Click += new System.EventHandler(this.DeliveryTimeLabel_Click);
            // 
            // CartButtonsPanel
            // 
            this.CartButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartButtonsPanel.ColumnCount = 4;
            this.CartButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CartButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CartButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CartButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CartButtonsPanel.Controls.Add(this.RemoveItemButton, 0, 0);
            this.CartButtonsPanel.Controls.Add(this.AddItemButton, 0, 0);
            this.CartButtonsPanel.Controls.Add(this.ClearOrderButton, 3, 0);
            this.CartButtonsPanel.Location = new System.Drawing.Point(23, 505);
            this.CartButtonsPanel.Name = "CartButtonsPanel";
            this.CartButtonsPanel.RowCount = 1;
            this.CartButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CartButtonsPanel.Size = new System.Drawing.Size(490, 45);
            this.CartButtonsPanel.TabIndex = 28;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveItemButton.Location = new System.Drawing.Point(125, 3);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(116, 39);
            this.RemoveItemButton.TabIndex = 5;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddItemButton.Location = new System.Drawing.Point(3, 3);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(116, 39);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearOrderButton.Location = new System.Drawing.Point(369, 3);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(118, 39);
            this.ClearOrderButton.TabIndex = 4;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PriorityOrderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartButtonsPanel);
            this.Controls.Add(this.addressControl1);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.DeliveryTimeComboBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.CreatedTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.AmountHeaderLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.DeliveryTimeLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.PriorityOptionsLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Name = "PriorityOrderTab";
            this.Size = new System.Drawing.Size(547, 588);
            this.CartButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label AmountHeaderLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.TableLayoutPanel CartButtonsPanel;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
    }
}
