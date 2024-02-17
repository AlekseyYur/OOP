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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.LabelItems = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.LabelError = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelSelectedItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.LabelItems);
            this.splitContainer1.Panel1.Controls.Add(this.ItemsListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.LabelError);
            this.splitContainer1.Panel2.Controls.Add(this.DescriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.NameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CostTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.IdTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.LabelDescription);
            this.splitContainer1.Panel2.Controls.Add(this.LabelName);
            this.splitContainer1.Panel2.Controls.Add(this.LabelCost);
            this.splitContainer1.Panel2.Controls.Add(this.LabelId);
            this.splitContainer1.Panel2.Controls.Add(this.LabelSelectedItem);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1324, 672);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.04469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.95531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 577);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 75);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 69);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RemoveButton.Location = new System.Drawing.Point(138, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(140, 69);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click_1);
            // 
            // LabelItems
            // 
            this.LabelItems.AutoSize = true;
            this.LabelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelItems.Location = new System.Drawing.Point(0, 2);
            this.LabelItems.Name = "LabelItems";
            this.LabelItems.Size = new System.Drawing.Size(37, 13);
            this.LabelItems.TabIndex = 1;
            this.LabelItems.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(0, 18);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(453, 550);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.Location = new System.Drawing.Point(591, 239);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 13);
            this.LabelError.TabIndex = 9;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(18, 256);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(514, 175);
            this.DescriptionTextBox.TabIndex = 8;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            this.DescriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NameTextBox.Location = new System.Drawing.Point(18, 131);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(514, 90);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CostTextBox.Location = new System.Drawing.Point(56, 74);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 6;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            this.CostTextBox.Leave += new System.EventHandler(this.CostTextBox_Leave);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(56, 38);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 5;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(21, 240);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(63, 13);
            this.LabelDescription.TabIndex = 4;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(21, 115);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Name:";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(21, 77);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(31, 13);
            this.LabelCost.TabIndex = 2;
            this.LabelCost.Text = "Cost:";
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(21, 38);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(21, 13);
            this.LabelId.TabIndex = 1;
            this.LabelId.Text = "ID:";
            // 
            // LabelSelectedItem
            // 
            this.LabelSelectedItem.AutoSize = true;
            this.LabelSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelectedItem.Location = new System.Drawing.Point(15, 9);
            this.LabelSelectedItem.Name = "LabelSelectedItem";
            this.LabelSelectedItem.Size = new System.Drawing.Size(85, 13);
            this.LabelSelectedItem.TabIndex = 0;
            this.LabelSelectedItem.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(1324, 672);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label LabelItems;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelSelectedItem;
        private System.Windows.Forms.Label LabelError;
    }
}
