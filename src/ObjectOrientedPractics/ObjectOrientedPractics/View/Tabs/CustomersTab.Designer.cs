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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.LabelCustomers = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelFullname = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.LabelSelectedCustuomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.LabelCustomers);
            this.splitContainer1.Panel1.Controls.Add(this.CustomersListBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1206, 683);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.31835F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.68165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 552);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 73);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 67);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveButton.Location = new System.Drawing.Point(120, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(135, 67);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // LabelCustomers
            // 
            this.LabelCustomers.AutoSize = true;
            this.LabelCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCustomers.Location = new System.Drawing.Point(3, 6);
            this.LabelCustomers.Name = "LabelCustomers";
            this.LabelCustomers.Size = new System.Drawing.Size(65, 13);
            this.LabelCustomers.TabIndex = 1;
            this.LabelCustomers.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 22);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(401, 524);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 392);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddressTextBox);
            this.panel1.Controls.Add(this.FullnameTextBox);
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.LabelAddress);
            this.panel1.Controls.Add(this.LabelFullname);
            this.panel1.Controls.Add(this.Label);
            this.panel1.Controls.Add(this.LabelSelectedCustuomer);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 276);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(73, 107);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(401, 154);
            this.AddressTextBox.TabIndex = 6;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            this.AddressTextBox.Leave += new System.EventHandler(this.AddressTextBox_Leave);
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Location = new System.Drawing.Point(73, 69);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(401, 20);
            this.FullnameTextBox.TabIndex = 5;
            this.FullnameTextBox.TextChanged += new System.EventHandler(this.FullnameTextBox_TextChanged);
            this.FullnameTextBox.Leave += new System.EventHandler(this.FullNameTexBox_Leave);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(73, 38);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 4;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(10, 107);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(48, 13);
            this.LabelAddress.TabIndex = 3;
            this.LabelAddress.Text = "Address:";
            // 
            // LabelFullname
            // 
            this.LabelFullname.AutoSize = true;
            this.LabelFullname.Location = new System.Drawing.Point(10, 69);
            this.LabelFullname.Name = "LabelFullname";
            this.LabelFullname.Size = new System.Drawing.Size(52, 13);
            this.LabelFullname.TabIndex = 2;
            this.LabelFullname.Text = "Fullname:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(10, 38);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(21, 13);
            this.Label.TabIndex = 1;
            this.Label.Text = "ID:";
            // 
            // LabelSelectedCustuomer
            // 
            this.LabelSelectedCustuomer.AutoSize = true;
            this.LabelSelectedCustuomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelectedCustuomer.Location = new System.Drawing.Point(4, 4);
            this.LabelSelectedCustuomer.Name = "LabelSelectedCustuomer";
            this.LabelSelectedCustuomer.Size = new System.Drawing.Size(113, 13);
            this.LabelSelectedCustuomer.TabIndex = 0;
            this.LabelSelectedCustuomer.Text = "Selected Customer";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1206, 683);
            this.Load += new System.EventHandler(this.CustomersTab_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label LabelCustomers;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox FullnameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelFullname;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label LabelSelectedCustuomer;
    }
}
