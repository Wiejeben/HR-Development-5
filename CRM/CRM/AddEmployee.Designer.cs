namespace CRM
{
    partial class AddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bsnInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addresses = new System.Windows.Forms.TabPage();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addAddress = new System.Windows.Forms.Button();
            this.additionInput = new System.Windows.Forms.TextBox();
            this.residenceCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.streetInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.provinceInput = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.residence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.province = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.degrees = new System.Windows.Forms.TabPage();
            this.courseInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.levelInput = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.schoolInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.school = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addDegree = new System.Windows.Forms.Button();
            this.positions = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hourFee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removePositionButton = new System.Windows.Forms.Button();
            this.addPositionButton = new System.Windows.Forms.Button();
            this.hourFeeInput = new System.Windows.Forms.TextBox();
            this.positionInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.addresses.SuspendLayout();
            this.degrees.SuspendLayout();
            this.positions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // bsnInput
            // 
            this.bsnInput.Location = new System.Drawing.Point(26, 72);
            this.bsnInput.Name = "bsnInput";
            this.bsnInput.Size = new System.Drawing.Size(100, 22);
            this.bsnInput.TabIndex = 3;
            this.bsnInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bsnInput_KeyPress);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(26, 125);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 22);
            this.nameInput.TabIndex = 4;
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(26, 182);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(100, 22);
            this.surnameInput.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addresses);
            this.tabControl1.Controls.Add(this.degrees);
            this.tabControl1.Controls.Add(this.positions);
            this.tabControl1.Location = new System.Drawing.Point(211, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 394);
            this.tabControl1.TabIndex = 6;
            // 
            // addresses
            // 
            this.addresses.Controls.Add(this.numberInput);
            this.addresses.Controls.Add(this.button2);
            this.addresses.Controls.Add(this.addAddress);
            this.addresses.Controls.Add(this.additionInput);
            this.addresses.Controls.Add(this.residenceCheckbox);
            this.addresses.Controls.Add(this.label8);
            this.addresses.Controls.Add(this.cityInput);
            this.addresses.Controls.Add(this.label7);
            this.addresses.Controls.Add(this.label6);
            this.addresses.Controls.Add(this.streetInput);
            this.addresses.Controls.Add(this.label5);
            this.addresses.Controls.Add(this.provinceInput);
            this.addresses.Controls.Add(this.listView1);
            this.addresses.Controls.Add(this.label4);
            this.addresses.Controls.Add(this.countryInput);
            this.addresses.Location = new System.Drawing.Point(4, 25);
            this.addresses.Name = "addresses";
            this.addresses.Padding = new System.Windows.Forms.Padding(3);
            this.addresses.Size = new System.Drawing.Size(483, 365);
            this.addresses.TabIndex = 0;
            this.addresses.Text = "Addresses";
            this.addresses.UseVisualStyleBackColor = true;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(7, 263);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(40, 22);
            this.numberInput.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(71, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(3, 336);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(62, 23);
            this.addAddress.TabIndex = 15;
            this.addAddress.Text = "Add";
            this.addAddress.UseVisualStyleBackColor = true;
            // 
            // additionInput
            // 
            this.additionInput.Location = new System.Drawing.Point(53, 263);
            this.additionInput.Name = "additionInput";
            this.additionInput.Size = new System.Drawing.Size(69, 22);
            this.additionInput.TabIndex = 13;
            // 
            // residenceCheckbox
            // 
            this.residenceCheckbox.AutoSize = true;
            this.residenceCheckbox.Location = new System.Drawing.Point(7, 300);
            this.residenceCheckbox.Name = "residenceCheckbox";
            this.residenceCheckbox.Size = new System.Drawing.Size(93, 20);
            this.residenceCheckbox.TabIndex = 12;
            this.residenceCheckbox.Text = "Residence";
            this.residenceCheckbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "City";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(3, 148);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 22);
            this.cityInput.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number + Addition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Street";
            // 
            // streetInput
            // 
            this.streetInput.Location = new System.Drawing.Point(3, 207);
            this.streetInput.Name = "streetInput";
            this.streetInput.Size = new System.Drawing.Size(100, 22);
            this.streetInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Province";
            // 
            // provinceInput
            // 
            this.provinceInput.Location = new System.Drawing.Point(3, 92);
            this.provinceInput.Name = "provinceInput";
            this.provinceInput.Size = new System.Drawing.Size(100, 22);
            this.provinceInput.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.residence,
            this.addition,
            this.number,
            this.street,
            this.city,
            this.province,
            this.country});
            this.listView1.Location = new System.Drawing.Point(148, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(329, 346);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // residence
            // 
            this.residence.Text = "Residence";
            this.residence.Width = 81;
            // 
            // addition
            // 
            this.addition.DisplayIndex = 6;
            this.addition.Text = "Addition";
            // 
            // number
            // 
            this.number.DisplayIndex = 5;
            this.number.Text = "Number";
            // 
            // street
            // 
            this.street.DisplayIndex = 4;
            this.street.Text = "Street";
            // 
            // city
            // 
            this.city.DisplayIndex = 3;
            this.city.Text = "City";
            // 
            // province
            // 
            this.province.DisplayIndex = 2;
            this.province.Text = "Province";
            // 
            // country
            // 
            this.country.DisplayIndex = 1;
            this.country.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Country";
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(3, 35);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(100, 22);
            this.countryInput.TabIndex = 0;
            // 
            // degrees
            // 
            this.degrees.Controls.Add(this.courseInput);
            this.degrees.Controls.Add(this.label10);
            this.degrees.Controls.Add(this.levelInput);
            this.degrees.Controls.Add(this.levelLabel);
            this.degrees.Controls.Add(this.schoolInput);
            this.degrees.Controls.Add(this.label9);
            this.degrees.Controls.Add(this.listView2);
            this.degrees.Controls.Add(this.addDegree);
            this.degrees.Location = new System.Drawing.Point(4, 25);
            this.degrees.Name = "degrees";
            this.degrees.Padding = new System.Windows.Forms.Padding(3);
            this.degrees.Size = new System.Drawing.Size(483, 365);
            this.degrees.TabIndex = 1;
            this.degrees.Text = "Degrees";
            this.degrees.UseVisualStyleBackColor = true;
            // 
            // courseInput
            // 
            this.courseInput.Location = new System.Drawing.Point(9, 135);
            this.courseInput.Name = "courseInput";
            this.courseInput.Size = new System.Drawing.Size(100, 22);
            this.courseInput.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Course";
            // 
            // levelInput
            // 
            this.levelInput.Location = new System.Drawing.Point(9, 78);
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(100, 22);
            this.levelInput.TabIndex = 11;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(6, 58);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(41, 16);
            this.levelLabel.TabIndex = 10;
            this.levelLabel.Text = "Level";
            // 
            // schoolInput
            // 
            this.schoolInput.Location = new System.Drawing.Point(9, 26);
            this.schoolInput.Name = "schoolInput";
            this.schoolInput.Size = new System.Drawing.Size(100, 22);
            this.schoolInput.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "School";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.school,
            this.level,
            this.course});
            this.listView2.Location = new System.Drawing.Point(154, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(323, 353);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // school
            // 
            this.school.Text = "School";
            this.school.Width = 112;
            // 
            // level
            // 
            this.level.Text = "Level";
            this.level.Width = 107;
            // 
            // course
            // 
            this.course.Text = "Course";
            this.course.Width = 96;
            // 
            // addDegree
            // 
            this.addDegree.Location = new System.Drawing.Point(6, 336);
            this.addDegree.Name = "addDegree";
            this.addDegree.Size = new System.Drawing.Size(75, 23);
            this.addDegree.TabIndex = 0;
            this.addDegree.Text = "Add";
            this.addDegree.UseVisualStyleBackColor = true;
            // 
            // positions
            // 
            this.positions.Controls.Add(this.listView3);
            this.positions.Controls.Add(this.removePositionButton);
            this.positions.Controls.Add(this.addPositionButton);
            this.positions.Controls.Add(this.hourFeeInput);
            this.positions.Controls.Add(this.positionInput);
            this.positions.Controls.Add(this.descriptionInput);
            this.positions.Controls.Add(this.label13);
            this.positions.Controls.Add(this.label12);
            this.positions.Controls.Add(this.label11);
            this.positions.Location = new System.Drawing.Point(4, 25);
            this.positions.Name = "positions";
            this.positions.Padding = new System.Windows.Forms.Padding(3);
            this.positions.Size = new System.Drawing.Size(483, 365);
            this.positions.TabIndex = 2;
            this.positions.Text = "Positions";
            this.positions.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.position,
            this.description,
            this.hourFee});
            this.listView3.Location = new System.Drawing.Point(112, 6);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(365, 324);
            this.listView3.TabIndex = 16;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // position
            // 
            this.position.Text = "Position";
            this.position.Width = 108;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 139;
            // 
            // hourFee
            // 
            this.hourFee.Text = "Hour fee";
            this.hourFee.Width = 91;
            // 
            // removePositionButton
            // 
            this.removePositionButton.Enabled = false;
            this.removePositionButton.Location = new System.Drawing.Point(408, 336);
            this.removePositionButton.Name = "removePositionButton";
            this.removePositionButton.Size = new System.Drawing.Size(69, 23);
            this.removePositionButton.TabIndex = 15;
            this.removePositionButton.Text = "Remove";
            this.removePositionButton.UseVisualStyleBackColor = true;
            // 
            // addPositionButton
            // 
            this.addPositionButton.Location = new System.Drawing.Point(6, 336);
            this.addPositionButton.Name = "addPositionButton";
            this.addPositionButton.Size = new System.Drawing.Size(73, 23);
            this.addPositionButton.TabIndex = 14;
            this.addPositionButton.Text = "Add";
            this.addPositionButton.UseVisualStyleBackColor = true;
            // 
            // hourFeeInput
            // 
            this.hourFeeInput.Location = new System.Drawing.Point(6, 135);
            this.hourFeeInput.Name = "hourFeeInput";
            this.hourFeeInput.Size = new System.Drawing.Size(100, 22);
            this.hourFeeInput.TabIndex = 13;
            // 
            // positionInput
            // 
            this.positionInput.Location = new System.Drawing.Point(6, 25);
            this.positionInput.Name = "positionInput";
            this.positionInput.Size = new System.Drawing.Size(100, 22);
            this.positionInput.TabIndex = 11;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(6, 78);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(100, 22);
            this.descriptionInput.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Position";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Hour fee";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(26, 383);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 428);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.bsnInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "Add an employee";
            this.tabControl1.ResumeLayout(false);
            this.addresses.ResumeLayout(false);
            this.addresses.PerformLayout();
            this.degrees.ResumeLayout(false);
            this.degrees.PerformLayout();
            this.positions.ResumeLayout(false);
            this.positions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bsnInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addresses;
        private System.Windows.Forms.TabPage degrees;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader residence;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox additionInput;
        private System.Windows.Forms.CheckBox residenceCheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox streetInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox provinceInput;
        private System.Windows.Forms.Button addAddress;
        private System.Windows.Forms.TextBox courseInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox levelInput;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox schoolInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader school;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.ColumnHeader course;
        private System.Windows.Forms.Button addDegree;
        private System.Windows.Forms.ColumnHeader addition;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader street;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader province;
        private System.Windows.Forms.ColumnHeader country;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage positions;
        private System.Windows.Forms.TextBox hourFeeInput;
        private System.Windows.Forms.TextBox positionInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader hourFee;
        private System.Windows.Forms.Button removePositionButton;
        private System.Windows.Forms.Button addPositionButton;
        private System.Windows.Forms.TextBox numberInput;
    }
}