namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.AddressControllPanel = new System.Windows.Forms.Panel();
            this.WrongInputLabel = new System.Windows.Forms.Label();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.AddressControllPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressControllPanel
            // 
            this.AddressControllPanel.Controls.Add(this.WrongInputLabel);
            this.AddressControllPanel.Controls.Add(this.ApartmentTextBox);
            this.AddressControllPanel.Controls.Add(this.ApartmentLabel);
            this.AddressControllPanel.Controls.Add(this.CityTextBox);
            this.AddressControllPanel.Controls.Add(this.CityLabel);
            this.AddressControllPanel.Controls.Add(this.BuildingTextBox);
            this.AddressControllPanel.Controls.Add(this.StreetTextBox);
            this.AddressControllPanel.Controls.Add(this.CountryTextBox);
            this.AddressControllPanel.Controls.Add(this.PostIndexTextBox);
            this.AddressControllPanel.Controls.Add(this.BuildingLabel);
            this.AddressControllPanel.Controls.Add(this.StreetLabel);
            this.AddressControllPanel.Controls.Add(this.CountryLabel);
            this.AddressControllPanel.Controls.Add(this.PostIndexLabel);
            this.AddressControllPanel.Controls.Add(this.DeliveryAddressLabel);
            this.AddressControllPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressControllPanel.Location = new System.Drawing.Point(0, 0);
            this.AddressControllPanel.Name = "AddressControllPanel";
            this.AddressControllPanel.Size = new System.Drawing.Size(467, 187);
            this.AddressControllPanel.TabIndex = 0;
            // 
            // WrongInputLabel
            // 
            this.WrongInputLabel.AutoSize = true;
            this.WrongInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongInputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WrongInputLabel.Location = new System.Drawing.Point(3, 149);
            this.WrongInputLabel.Name = "WrongInputLabel";
            this.WrongInputLabel.Size = new System.Drawing.Size(0, 20);
            this.WrongInputLabel.TabIndex = 13;
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(264, 121);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(100, 22);
            this.ApartmentTextBox.TabIndex = 12;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            this.ApartmentTextBox.Leave += new System.EventHandler(this.ApartmentTextBox_Leave);
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(187, 124);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(71, 16);
            this.ApartmentLabel.TabIndex = 11;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(281, 65);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(165, 22);
            this.CityTextBox.TabIndex = 10;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            this.CityTextBox.Leave += new System.EventHandler(this.CityTextBox_Leave);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(243, 68);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(32, 16);
            this.CityLabel.TabIndex = 9;
            this.CityLabel.Text = "City:";
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(81, 121);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(100, 22);
            this.BuildingTextBox.TabIndex = 8;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            this.BuildingTextBox.Leave += new System.EventHandler(this.BuildingTextBox_Leave);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(81, 93);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(365, 22);
            this.StreetTextBox.TabIndex = 7;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            this.StreetTextBox.Leave += new System.EventHandler(this.StreetTextBox_Leave);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(81, 65);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(156, 22);
            this.CountryTextBox.TabIndex = 6;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            this.CountryTextBox.Leave += new System.EventHandler(this.CountryTextBox_Leave);
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Location = new System.Drawing.Point(81, 37);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(100, 22);
            this.PostIndexTextBox.TabIndex = 5;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            this.PostIndexTextBox.Leave += new System.EventHandler(this.PostIndexTextBox_Leave);
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(3, 124);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(58, 16);
            this.BuildingLabel.TabIndex = 4;
            this.BuildingLabel.Text = "Building:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(3, 96);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(45, 16);
            this.StreetLabel.TabIndex = 3;
            this.StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(3, 68);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(55, 16);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Location = new System.Drawing.Point(3, 40);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(72, 16);
            this.PostIndexLabel.TabIndex = 1;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(3, 0);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(127, 16);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressControllPanel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(467, 187);
            this.AddressControllPanel.ResumeLayout(false);
            this.AddressControllPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label PostIndexLabel;
        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.Label WrongInputLabel;
        private System.Windows.Forms.Panel AddressControllPanel;
    }
}
