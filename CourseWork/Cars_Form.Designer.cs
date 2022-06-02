
namespace CourseWork
{
    partial class Cars_Form
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
            this.Exit_To_Menu_Button = new System.Windows.Forms.Button();
            this.brand_listBox = new System.Windows.Forms.ListBox();
            this.release_year_listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cylinder_amount_listBox = new System.Windows.Forms.ListBox();
            this.volume_listBox = new System.Windows.Forms.ListBox();
            this.horse_power_listBox = new System.Windows.Forms.ListBox();
            this.transmission_type_listBox = new System.Windows.Forms.ListBox();
            this.length_listBox = new System.Windows.Forms.ListBox();
            this.width_listBox = new System.Windows.Forms.ListBox();
            this.height_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.peculiarities_listBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.condition_listBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.price_listBox = new System.Windows.Forms.ListBox();
            this.Add_Car_Button = new System.Windows.Forms.Button();
            this.Delete_Car_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_To_Menu_Button
            // 
            this.Exit_To_Menu_Button.Location = new System.Drawing.Point(809, 0);
            this.Exit_To_Menu_Button.Name = "Exit_To_Menu_Button";
            this.Exit_To_Menu_Button.Size = new System.Drawing.Size(129, 23);
            this.Exit_To_Menu_Button.TabIndex = 0;
            this.Exit_To_Menu_Button.Text = "повернутися до меню";
            this.Exit_To_Menu_Button.UseVisualStyleBackColor = true;
            this.Exit_To_Menu_Button.Click += new System.EventHandler(this.Exit_To_Menu_Button_Click);
            // 
            // brand_listBox
            // 
            this.brand_listBox.AccessibleName = "";
            this.brand_listBox.FormattingEnabled = true;
            this.brand_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.brand_listBox.Location = new System.Drawing.Point(12, 70);
            this.brand_listBox.Name = "brand_listBox";
            this.brand_listBox.Size = new System.Drawing.Size(120, 472);
            this.brand_listBox.TabIndex = 3;
            this.brand_listBox.SelectedIndexChanged += new System.EventHandler(this.brand_listBox_SelectedIndexChanged);
            // 
            // release_year_listBox
            // 
            this.release_year_listBox.AccessibleName = "";
            this.release_year_listBox.FormattingEnabled = true;
            this.release_year_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.release_year_listBox.Location = new System.Drawing.Point(138, 70);
            this.release_year_listBox.Name = "release_year_listBox";
            this.release_year_listBox.Size = new System.Drawing.Size(44, 472);
            this.release_year_listBox.TabIndex = 4;
            this.release_year_listBox.SelectedIndexChanged += new System.EventHandler(this.release_year_listBox_SelectedIndexChanged);
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
            this.cylinder_amount_listBox.AccessibleName = "";
            this.cylinder_amount_listBox.FormattingEnabled = true;
            this.cylinder_amount_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.cylinder_amount_listBox.Location = new System.Drawing.Point(188, 70);
            this.cylinder_amount_listBox.Name = "cylinder_amount_listBox";
            this.cylinder_amount_listBox.Size = new System.Drawing.Size(44, 472);
            this.cylinder_amount_listBox.TabIndex = 6;
            this.cylinder_amount_listBox.SelectedIndexChanged += new System.EventHandler(this.cylinder_amount_listBox_SelectedIndexChanged);
            // 
            // volume_listBox
            // 
            this.volume_listBox.AccessibleName = "";
            this.volume_listBox.FormattingEnabled = true;
            this.volume_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.volume_listBox.Location = new System.Drawing.Point(238, 70);
            this.volume_listBox.Name = "volume_listBox";
            this.volume_listBox.Size = new System.Drawing.Size(44, 472);
            this.volume_listBox.TabIndex = 7;
            this.volume_listBox.SelectedIndexChanged += new System.EventHandler(this.volume_listBox_SelectedIndexChanged);
            // 
            // horse_power_listBox
            // 
            this.horse_power_listBox.AccessibleName = "";
            this.horse_power_listBox.FormattingEnabled = true;
            this.horse_power_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.horse_power_listBox.Location = new System.Drawing.Point(288, 70);
            this.horse_power_listBox.Name = "horse_power_listBox";
            this.horse_power_listBox.Size = new System.Drawing.Size(59, 472);
            this.horse_power_listBox.TabIndex = 8;
            this.horse_power_listBox.SelectedIndexChanged += new System.EventHandler(this.horse_power_listBox_SelectedIndexChanged);
            // 
            // transmission_type_listBox
            // 
            this.transmission_type_listBox.AccessibleName = "";
            this.transmission_type_listBox.FormattingEnabled = true;
            this.transmission_type_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.transmission_type_listBox.Location = new System.Drawing.Point(353, 70);
            this.transmission_type_listBox.Name = "transmission_type_listBox";
            this.transmission_type_listBox.Size = new System.Drawing.Size(56, 472);
            this.transmission_type_listBox.TabIndex = 9;
            this.transmission_type_listBox.SelectedIndexChanged += new System.EventHandler(this.transmission_type_listBox_SelectedIndexChanged);
            // 
            // length_listBox
            // 
            this.length_listBox.AccessibleName = "";
            this.length_listBox.FormattingEnabled = true;
            this.length_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.length_listBox.Location = new System.Drawing.Point(415, 70);
            this.length_listBox.Name = "length_listBox";
            this.length_listBox.Size = new System.Drawing.Size(44, 472);
            this.length_listBox.TabIndex = 10;
            this.length_listBox.SelectedIndexChanged += new System.EventHandler(this.length_listBox_SelectedIndexChanged);
            // 
            // width_listBox
            // 
            this.width_listBox.AccessibleName = "";
            this.width_listBox.FormattingEnabled = true;
            this.width_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.width_listBox.Location = new System.Drawing.Point(465, 70);
            this.width_listBox.Name = "width_listBox";
            this.width_listBox.Size = new System.Drawing.Size(44, 472);
            this.width_listBox.TabIndex = 11;
            this.width_listBox.SelectedIndexChanged += new System.EventHandler(this.width_listBox_SelectedIndexChanged);
            // 
            // height_listBox
            // 
            this.height_listBox.AccessibleName = "";
            this.height_listBox.FormattingEnabled = true;
            this.height_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.height_listBox.Location = new System.Drawing.Point(515, 70);
            this.height_listBox.Name = "height_listBox";
            this.height_listBox.Size = new System.Drawing.Size(44, 472);
            this.height_listBox.TabIndex = 12;
            this.height_listBox.SelectedIndexChanged += new System.EventHandler(this.height_listBox_SelectedIndexChanged);
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
            this.peculiarities_listBox.AccessibleName = "";
            this.peculiarities_listBox.FormattingEnabled = true;
            this.peculiarities_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.peculiarities_listBox.Location = new System.Drawing.Point(565, 70);
            this.peculiarities_listBox.Name = "peculiarities_listBox";
            this.peculiarities_listBox.Size = new System.Drawing.Size(218, 472);
            this.peculiarities_listBox.TabIndex = 20;
            this.peculiarities_listBox.SelectedIndexChanged += new System.EventHandler(this.peculiarities_listBox_SelectedIndexChanged);
            this.peculiarities_listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.peculiarities_listBox_MouseDoubleClick);
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
            this.condition_listBox.AccessibleName = "";
            this.condition_listBox.FormattingEnabled = true;
            this.condition_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.condition_listBox.Location = new System.Drawing.Point(789, 70);
            this.condition_listBox.Name = "condition_listBox";
            this.condition_listBox.Size = new System.Drawing.Size(63, 472);
            this.condition_listBox.TabIndex = 22;
            this.condition_listBox.SelectedIndexChanged += new System.EventHandler(this.condition_listBox_SelectedIndexChanged);
            this.condition_listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.condition_listBox_MouseDoubleClick);
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
            this.price_listBox.AccessibleName = "";
            this.price_listBox.FormattingEnabled = true;
            this.price_listBox.Items.AddRange(new object[] {
            "123",
            "456"});
            this.price_listBox.Location = new System.Drawing.Point(858, 70);
            this.price_listBox.Name = "price_listBox";
            this.price_listBox.Size = new System.Drawing.Size(63, 472);
            this.price_listBox.TabIndex = 24;
            this.price_listBox.SelectedIndexChanged += new System.EventHandler(this.price_listBox_SelectedIndexChanged);
            this.price_listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.price_listBox_MouseDoubleClick);
            // 
            // Add_Car_Button
            // 
            this.Add_Car_Button.Location = new System.Drawing.Point(0, 0);
            this.Add_Car_Button.Name = "Add_Car_Button";
            this.Add_Car_Button.Size = new System.Drawing.Size(87, 35);
            this.Add_Car_Button.TabIndex = 26;
            this.Add_Car_Button.Text = "додати авто";
            this.Add_Car_Button.UseVisualStyleBackColor = true;
            this.Add_Car_Button.Click += new System.EventHandler(this.Add_Car_Button_Click);
            // 
            // Delete_Car_Button
            // 
            this.Delete_Car_Button.Location = new System.Drawing.Point(93, 0);
            this.Delete_Car_Button.Name = "Delete_Car_Button";
            this.Delete_Car_Button.Size = new System.Drawing.Size(89, 35);
            this.Delete_Car_Button.TabIndex = 27;
            this.Delete_Car_Button.Text = "видалити авто";
            this.Delete_Car_Button.UseVisualStyleBackColor = true;
            this.Delete_Car_Button.Click += new System.EventHandler(this.Delete_Car_Button_Click);
            // 
            // Cars_Form
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 558);
            this.Controls.Add(this.Delete_Car_Button);
            this.Controls.Add(this.Add_Car_Button);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.price_listBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.condition_listBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.peculiarities_listBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.height_listBox);
            this.Controls.Add(this.width_listBox);
            this.Controls.Add(this.length_listBox);
            this.Controls.Add(this.transmission_type_listBox);
            this.Controls.Add(this.horse_power_listBox);
            this.Controls.Add(this.volume_listBox);
            this.Controls.Add(this.cylinder_amount_listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.release_year_listBox);
            this.Controls.Add(this.brand_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit_To_Menu_Button);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Cars_Form";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cars_Form_FormClosing);
            this.Load += new System.EventHandler(this.Cars_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_To_Menu_Button;
        private System.Windows.Forms.ListBox brand_listBox;
        private System.Windows.Forms.ListBox release_year_listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox cylinder_amount_listBox;
        private System.Windows.Forms.ListBox volume_listBox;
        private System.Windows.Forms.ListBox horse_power_listBox;
        private System.Windows.Forms.ListBox transmission_type_listBox;
        private System.Windows.Forms.ListBox length_listBox;
        private System.Windows.Forms.ListBox width_listBox;
        private System.Windows.Forms.ListBox height_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox peculiarities_listBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox condition_listBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox price_listBox;
        private System.Windows.Forms.Button Add_Car_Button;
        private System.Windows.Forms.Button Delete_Car_Button;
    }
}