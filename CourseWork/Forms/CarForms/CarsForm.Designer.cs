
namespace CourseWork
{
    partial class CarsForm
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
            this.ExitToMenuButton = new System.Windows.Forms.Button();
            this.brandListBox = new System.Windows.Forms.ListBox();
            this.releaseYearListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cylinderAmountListBox = new System.Windows.Forms.ListBox();
            this.volumeListBox = new System.Windows.Forms.ListBox();
            this.horsePowerListBox = new System.Windows.Forms.ListBox();
            this.transmissionTypeListBox = new System.Windows.Forms.ListBox();
            this.lengthListBox = new System.Windows.Forms.ListBox();
            this.widthListBox = new System.Windows.Forms.ListBox();
            this.heightListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.peculiaritiesListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.conditionListBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.DeleteCarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_To_Menu_Button
            // 
            this.ExitToMenuButton.Location = new System.Drawing.Point(809, 0);
            this.ExitToMenuButton.Name = "ExitToMenuButton";
            this.ExitToMenuButton.Size = new System.Drawing.Size(129, 23);
            this.ExitToMenuButton.TabIndex = 0;
            this.ExitToMenuButton.Text = "повернутися до меню";
            this.ExitToMenuButton.UseVisualStyleBackColor = true;
            this.ExitToMenuButton.Click += new System.EventHandler(this.ExitToMenuButton_Click);
            // 
            // brand_listBox
            // 
            this.brandListBox.AccessibleName = "";
            this.brandListBox.FormattingEnabled = true;
            this.brandListBox.Items.AddRange(new object[] { "123", "456" });
            this.brandListBox.Location = new System.Drawing.Point(12, 70);
            this.brandListBox.Name = "brandListBox";
            this.brandListBox.Size = new System.Drawing.Size(120, 472);
            this.brandListBox.TabIndex = 3;
            this.brandListBox.SelectedIndexChanged += new System.EventHandler(this.brandListBox_SelectedIndexChanged);
            // 
            // release_year_listBox
            // 
            this.releaseYearListBox.AccessibleName = "";
            this.releaseYearListBox.FormattingEnabled = true;
            this.releaseYearListBox.Items.AddRange(new object[] { "123", "456" });
            this.releaseYearListBox.Location = new System.Drawing.Point(138, 70);
            this.releaseYearListBox.Name = "releaseYearListBox";
            this.releaseYearListBox.Size = new System.Drawing.Size(44, 472);
            this.releaseYearListBox.TabIndex = 4;
            this.releaseYearListBox.SelectedIndexChanged += new System.EventHandler(this.releaseYearListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Рік\r\nвипуску";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Марка";
            // 
            // cylinder_amount_listBox
            // 
            this.cylinderAmountListBox.AccessibleName = "";
            this.cylinderAmountListBox.FormattingEnabled = true;
            this.cylinderAmountListBox.Items.AddRange(new object[] { "123", "456" });
            this.cylinderAmountListBox.Location = new System.Drawing.Point(188, 70);
            this.cylinderAmountListBox.Name = "cylinderAmountListBox";
            this.cylinderAmountListBox.Size = new System.Drawing.Size(44, 472);
            this.cylinderAmountListBox.TabIndex = 6;
            this.cylinderAmountListBox.SelectedIndexChanged += new System.EventHandler(this.cylinderAmountListBox_SelectedIndexChanged);
            // 
            // volume_listBox
            // 
            this.volumeListBox.AccessibleName = "";
            this.volumeListBox.FormattingEnabled = true;
            this.volumeListBox.Items.AddRange(new object[] { "123", "456" });
            this.volumeListBox.Location = new System.Drawing.Point(238, 70);
            this.volumeListBox.Name = "volumeListBox";
            this.volumeListBox.Size = new System.Drawing.Size(44, 472);
            this.volumeListBox.TabIndex = 7;
            this.volumeListBox.SelectedIndexChanged += new System.EventHandler(this.volumeListBox_SelectedIndexChanged);
            // 
            // horse_power_listBox
            // 
            this.horsePowerListBox.AccessibleName = "";
            this.horsePowerListBox.FormattingEnabled = true;
            this.horsePowerListBox.Items.AddRange(new object[] { "123", "456" });
            this.horsePowerListBox.Location = new System.Drawing.Point(288, 70);
            this.horsePowerListBox.Name = "horsePowerListBox";
            this.horsePowerListBox.Size = new System.Drawing.Size(59, 472);
            this.horsePowerListBox.TabIndex = 8;
            this.horsePowerListBox.SelectedIndexChanged += new System.EventHandler(this.horsePowerListBox_SelectedIndexChanged);
            // 
            // transmission_type_listBox
            // 
            this.transmissionTypeListBox.AccessibleName = "";
            this.transmissionTypeListBox.FormattingEnabled = true;
            this.transmissionTypeListBox.Items.AddRange(new object[] { "123", "456" });
            this.transmissionTypeListBox.Location = new System.Drawing.Point(353, 70);
            this.transmissionTypeListBox.Name = "transmissionTypeListBox";
            this.transmissionTypeListBox.Size = new System.Drawing.Size(56, 472);
            this.transmissionTypeListBox.TabIndex = 9;
            this.transmissionTypeListBox.SelectedIndexChanged += new System.EventHandler(this.transmissionTypeListBox_SelectedIndexChanged);
            // 
            // length_listBox
            // 
            this.lengthListBox.AccessibleName = "";
            this.lengthListBox.FormattingEnabled = true;
            this.lengthListBox.Items.AddRange(new object[] { "123", "456" });
            this.lengthListBox.Location = new System.Drawing.Point(415, 70);
            this.lengthListBox.Name = "lengthListBox";
            this.lengthListBox.Size = new System.Drawing.Size(44, 472);
            this.lengthListBox.TabIndex = 10;
            this.lengthListBox.SelectedIndexChanged += new System.EventHandler(this.lengthListBox_SelectedIndexChanged);
            // 
            // width_listBox
            // 
            this.widthListBox.AccessibleName = "";
            this.widthListBox.FormattingEnabled = true;
            this.widthListBox.Items.AddRange(new object[] { "123", "456" });
            this.widthListBox.Location = new System.Drawing.Point(465, 70);
            this.widthListBox.Name = "widthListBox";
            this.widthListBox.Size = new System.Drawing.Size(44, 472);
            this.widthListBox.TabIndex = 11;
            this.widthListBox.SelectedIndexChanged += new System.EventHandler(this.widthListBox_SelectedIndexChanged);
            // 
            // height_listBox
            // 
            this.heightListBox.AccessibleName = "";
            this.heightListBox.FormattingEnabled = true;
            this.heightListBox.Items.AddRange(new object[] { "123", "456" });
            this.heightListBox.Location = new System.Drawing.Point(515, 70);
            this.heightListBox.Name = "heightListBox";
            this.heightListBox.Size = new System.Drawing.Size(44, 472);
            this.heightListBox.TabIndex = 12;
            this.heightListBox.SelectedIndexChanged += new System.EventHandler(this.heightListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Кількість \r\nциліндрів\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "об\'єм";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "потужність";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "тип\r\nтрансміссії";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "довжина";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ширина";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "висота";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // peculiarities_listBox
            // 
            this.peculiaritiesListBox.AccessibleName = "";
            this.peculiaritiesListBox.FormattingEnabled = true;
            this.peculiaritiesListBox.Items.AddRange(new object[] { "123", "456" });
            this.peculiaritiesListBox.Location = new System.Drawing.Point(565, 70);
            this.peculiaritiesListBox.Name = "peculiaritiesListBox";
            this.peculiaritiesListBox.Size = new System.Drawing.Size(218, 472);
            this.peculiaritiesListBox.TabIndex = 20;
            this.peculiaritiesListBox.SelectedIndexChanged += new System.EventHandler(this.peculiaritiesListBox_SelectedIndexChanged);
            this.peculiaritiesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.peculiaritiesListBox_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "особливості";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(806, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "стан";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // condition_listBox
            // 
            this.conditionListBox.AccessibleName = "";
            this.conditionListBox.FormattingEnabled = true;
            this.conditionListBox.Items.AddRange(new object[] { "123", "456" });
            this.conditionListBox.Location = new System.Drawing.Point(789, 70);
            this.conditionListBox.Name = "conditionListBox";
            this.conditionListBox.Size = new System.Drawing.Size(63, 472);
            this.conditionListBox.TabIndex = 22;
            this.conditionListBox.SelectedIndexChanged += new System.EventHandler(this.conditionListBox_SelectedIndexChanged);
            this.conditionListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.conditionListBox_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(875, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "ціна";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // price_listBox
            // 
            this.priceListBox.AccessibleName = "";
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Items.AddRange(new object[] { "123", "456" });
            this.priceListBox.Location = new System.Drawing.Point(858, 70);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(63, 472);
            this.priceListBox.TabIndex = 24;
            this.priceListBox.SelectedIndexChanged += new System.EventHandler(this.priceListBox_SelectedIndexChanged);
            this.priceListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.priceListBox_MouseDoubleClick);
            // 
            // Add_Car_Button
            // 
            this.AddCarButton.Location = new System.Drawing.Point(0, 0);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(87, 35);
            this.AddCarButton.TabIndex = 26;
            this.AddCarButton.Text = "додати авто";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // Delete_Car_Button
            // 
            this.DeleteCarButton.Location = new System.Drawing.Point(93, 0);
            this.DeleteCarButton.Name = "DeleteCarButton";
            this.DeleteCarButton.Size = new System.Drawing.Size(89, 35);
            this.DeleteCarButton.TabIndex = 27;
            this.DeleteCarButton.Text = "видалити авто";
            this.DeleteCarButton.UseVisualStyleBackColor = true;
            this.DeleteCarButton.Click += new System.EventHandler(this.DeleteCarButton_Click);
            // 
            // Cars_Form
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 558);
            this.Controls.Add(this.DeleteCarButton);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.priceListBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.conditionListBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.peculiaritiesListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightListBox);
            this.Controls.Add(this.widthListBox);
            this.Controls.Add(this.lengthListBox);
            this.Controls.Add(this.transmissionTypeListBox);
            this.Controls.Add(this.horsePowerListBox);
            this.Controls.Add(this.volumeListBox);
            this.Controls.Add(this.cylinderAmountListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.releaseYearListBox);
            this.Controls.Add(this.brandListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExitToMenuButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "CarsForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarsForm_FormClosing);
            this.Load += new System.EventHandler(this.CarsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ExitToMenuButton;
        private System.Windows.Forms.ListBox brandListBox;
        private System.Windows.Forms.ListBox releaseYearListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox cylinderAmountListBox;
        private System.Windows.Forms.ListBox volumeListBox;
        private System.Windows.Forms.ListBox horsePowerListBox;
        private System.Windows.Forms.ListBox transmissionTypeListBox;
        private System.Windows.Forms.ListBox lengthListBox;
        private System.Windows.Forms.ListBox widthListBox;
        private System.Windows.Forms.ListBox heightListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox peculiaritiesListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox conditionListBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button DeleteCarButton;
    }
}