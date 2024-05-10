namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.ItemsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddDiscountsButton = new System.Windows.Forms.Button();
            this.RemoveDiscountsButton = new System.Windows.Forms.Button();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CustomersLable2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).BeginInit();
            this.ItemsSplitContainer.Panel1.SuspendLayout();
            this.ItemsSplitContainer.Panel2.SuspendLayout();
            this.ItemsSplitContainer.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsSplitContainer
            // 
            this.ItemsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ItemsSplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsSplitContainer.MinimumSize = new System.Drawing.Size(450, 366);
            this.ItemsSplitContainer.Name = "ItemsSplitContainer";
            // 
            // ItemsSplitContainer.Panel1
            // 
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ItemsSplitContainer.Panel1.Controls.Add(this.CustomersLabel);
            this.ItemsSplitContainer.Panel1.Controls.Add(this.CustomersListBox);
            // 
            // ItemsSplitContainer.Panel2
            // 
            this.ItemsSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsSplitContainer.Panel2.Controls.Add(this.DiscountsLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.DiscountsListBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.IsPriorityCheckBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.AddressControl);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.CostLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.IDLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.FullNameTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.IDTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.CustomersLable2);
            this.ItemsSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemsSplitContainer_Panel2_Paint);
            this.ItemsSplitContainer.Size = new System.Drawing.Size(717, 483);
            this.ItemsSplitContainer.SplitterDistance = 321;
            this.ItemsSplitContainer.SplitterWidth = 3;
            this.ItemsSplitContainer.TabIndex = 2;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(2, 427);
            this.ButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(316, 54);
            this.ButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(107, 2);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(101, 46);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(2, 2);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 46);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(2, 3);
            this.CustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(2, 19);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(318, 407);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            this.CustomersListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsListBox_KeyPress);
            this.CustomersListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemsListBox_MouseDown);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(4, 257);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(63, 13);
            this.DiscountsLabel.TabIndex = 20;
            this.DiscountsLabel.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.Location = new System.Drawing.Point(7, 274);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(273, 95);
            this.DiscountsListBox.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AddDiscountsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveDiscountsButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(286, 274);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(94, 95);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // AddDiscountsButton
            // 
            this.AddDiscountsButton.Location = new System.Drawing.Point(3, 3);
            this.AddDiscountsButton.Name = "AddDiscountsButton";
            this.AddDiscountsButton.Size = new System.Drawing.Size(88, 41);
            this.AddDiscountsButton.TabIndex = 0;
            this.AddDiscountsButton.Text = "Add";
            this.AddDiscountsButton.UseVisualStyleBackColor = true;
            this.AddDiscountsButton.Click += new System.EventHandler(this.AddDiscountsButton_Click);
            // 
            // RemoveDiscountsButton
            // 
            this.RemoveDiscountsButton.Location = new System.Drawing.Point(3, 50);
            this.RemoveDiscountsButton.Name = "RemoveDiscountsButton";
            this.RemoveDiscountsButton.Size = new System.Drawing.Size(88, 42);
            this.RemoveDiscountsButton.TabIndex = 1;
            this.RemoveDiscountsButton.Text = "Remove";
            this.RemoveDiscountsButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountsButton.Click += new System.EventHandler(this.RemoveDiscountsButton_Click);
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(62, 82);
            this.IsPriorityCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(68, 17);
            this.IsPriorityCheckBox.TabIndex = 17;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddressControl
            // 
            address1.Apartment = "-";
            address1.Building = "-";
            address1.City = "-";
            address1.Country = "-";
            address1.Index = 111111;
            address1.Street = "-";
            this.AddressControl.Address = address1;
            this.AddressControl.Location = new System.Drawing.Point(6, 103);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(350, 152);
            this.AddressControl.TabIndex = 15;
            this.AddressControl.Load += new System.EventHandler(this.AddressControl_Load);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(4, 60);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(57, 13);
            this.CostLabel.TabIndex = 14;
            this.CostLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(4, 37);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 13;
            this.IDLabel.Text = "ID:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(62, 58);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(298, 20);
            this.FullNameTextBox.TabIndex = 12;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(62, 35);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(112, 20);
            this.IDTextBox.TabIndex = 11;
            // 
            // CustomersLable2
            // 
            this.CustomersLable2.AutoSize = true;
            this.CustomersLable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLable2.Location = new System.Drawing.Point(3, 5);
            this.CustomersLable2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomersLable2.Name = "CustomersLable2";
            this.CustomersLable2.Size = new System.Drawing.Size(99, 13);
            this.CustomersLable2.TabIndex = 10;
            this.CustomersLable2.Text = "Select Customer";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(717, 483);
            this.ItemsSplitContainer.Panel1.ResumeLayout(false);
            this.ItemsSplitContainer.Panel1.PerformLayout();
            this.ItemsSplitContainer.Panel2.ResumeLayout(false);
            this.ItemsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).EndInit();
            this.ItemsSplitContainer.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ItemsSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label CustomersLable2;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddDiscountsButton;
        private System.Windows.Forms.Button RemoveDiscountsButton;
    }
}
