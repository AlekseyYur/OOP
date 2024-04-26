namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemLable1 = new System.Windows.Forms.Label();
            this.ItemsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.ItemLable2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).BeginInit();
            this.ItemsSplitContainer.Panel1.SuspendLayout();
            this.ItemsSplitContainer.Panel2.SuspendLayout();
            this.ItemsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.AccessibleName = "";
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(2, 20);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(316, 407);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            this.ItemsListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsListBox_KeyPress);
            this.ItemsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemsListBox_MouseDown);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(107, 2);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 46);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(2, 428);
            this.ButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(316, 54);
            this.ButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // ItemLable1
            // 
            this.ItemLable1.AutoSize = true;
            this.ItemLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemLable1.Location = new System.Drawing.Point(2, 5);
            this.ItemLable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemLable1.Name = "ItemLable1";
            this.ItemLable1.Size = new System.Drawing.Size(37, 13);
            this.ItemLable1.TabIndex = 0;
            this.ItemLable1.Text = "Items";
            // 
            // ItemsSplitContainer
            // 
            this.ItemsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ItemsSplitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemsSplitContainer.MinimumSize = new System.Drawing.Size(450, 366);
            this.ItemsSplitContainer.Name = "ItemsSplitContainer";
            // 
            // ItemsSplitContainer.Panel1
            // 
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ItemLable1);
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ItemsListBox);
            // 
            // ItemsSplitContainer.Panel2
            // 
            this.ItemsSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsSplitContainer.Panel2.Controls.Add(this.CategoryComboBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.CategoryLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.DescriptionTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.DescriptionLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.NameTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.NameLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.CostLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.IDLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.CostTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.IDTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemLable2);
            this.ItemsSplitContainer.Size = new System.Drawing.Size(718, 484);
            this.ItemsSplitContainer.SplitterDistance = 321;
            this.ItemsSplitContainer.SplitterWidth = 3;
            this.ItemsSplitContainer.TabIndex = 2;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(57, 80);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(112, 21);
            this.CategoryComboBox.TabIndex = 20;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(4, 82);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 19;
            this.CategoryLabel.Text = "Category:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(5, 241);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(331, 112);
            this.DescriptionTextBox.TabIndex = 18;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_Change);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(4, 226);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 17;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(5, 125);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(331, 76);
            this.NameTextBox.TabIndex = 16;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_Change);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(4, 110);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(4, 60);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(31, 13);
            this.CostLabel.TabIndex = 14;
            this.CostLabel.Text = "Cost:";
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
            // CostTextBox
            // 
            this.CostTextBox.ForeColor = System.Drawing.Color.Black;
            this.CostTextBox.Location = new System.Drawing.Point(57, 58);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(112, 20);
            this.CostTextBox.TabIndex = 12;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTexBox_Change);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(57, 35);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(112, 20);
            this.IDTextBox.TabIndex = 11;
            // 
            // ItemLable2
            // 
            this.ItemLable2.AutoSize = true;
            this.ItemLable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemLable2.Location = new System.Drawing.Point(3, 5);
            this.ItemLable2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemLable2.Name = "ItemLable2";
            this.ItemLable2.Size = new System.Drawing.Size(71, 13);
            this.ItemLable2.TabIndex = 10;
            this.ItemLable2.Text = "Select Item";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(718, 484);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.ItemsSplitContainer.Panel1.ResumeLayout(false);
            this.ItemsSplitContainer.Panel1.PerformLayout();
            this.ItemsSplitContainer.Panel2.ResumeLayout(false);
            this.ItemsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).EndInit();
            this.ItemsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.SplitContainer ItemsSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ItemLable1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label ItemLable2;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}
