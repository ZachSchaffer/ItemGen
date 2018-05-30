namespace ItemGen
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UniversalPropertiesBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxWeight = new System.Windows.Forms.TextBox();
            this.boxCost = new System.Windows.Forms.TextBox();
            this.boxDR = new System.Windows.Forms.TextBox();
            this.boxRules = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxAvail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.SpecialPropertiesBox = new System.Windows.Forms.GroupBox();
            this.ModSlotsBox = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.slbl8 = new System.Windows.Forms.Label();
            this.slbl7 = new System.Windows.Forms.Label();
            this.sdrop1 = new System.Windows.Forms.ComboBox();
            this.sdrop2 = new System.Windows.Forms.ComboBox();
            this.slbl6 = new System.Windows.Forms.Label();
            this.slbl5 = new System.Windows.Forms.Label();
            this.slbl4 = new System.Windows.Forms.Label();
            this.slbl3 = new System.Windows.Forms.Label();
            this.slbl2 = new System.Windows.Forms.Label();
            this.slbl1 = new System.Windows.Forms.Label();
            this.sbox6 = new System.Windows.Forms.TextBox();
            this.sbox5 = new System.Windows.Forms.TextBox();
            this.sbox4 = new System.Windows.Forms.TextBox();
            this.sbox3 = new System.Windows.Forms.TextBox();
            this.sbox2 = new System.Windows.Forms.TextBox();
            this.sbox1 = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.UniversalPropertiesBox.SuspendLayout();
            this.SpecialPropertiesBox.SuspendLayout();
            this.ModSlotsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.CheckOnClick = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::ItemGen.Properties.Resources.page;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::ItemGen.Properties.Resources.folder_page;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::ItemGen.Properties.Resources.disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // UniversalPropertiesBox
            // 
            this.UniversalPropertiesBox.Controls.Add(this.label7);
            this.UniversalPropertiesBox.Controls.Add(this.label6);
            this.UniversalPropertiesBox.Controls.Add(this.label5);
            this.UniversalPropertiesBox.Controls.Add(this.boxWeight);
            this.UniversalPropertiesBox.Controls.Add(this.boxCost);
            this.UniversalPropertiesBox.Controls.Add(this.boxDR);
            this.UniversalPropertiesBox.Controls.Add(this.boxRules);
            this.UniversalPropertiesBox.Controls.Add(this.label4);
            this.UniversalPropertiesBox.Controls.Add(this.boxAvail);
            this.UniversalPropertiesBox.Controls.Add(this.label3);
            this.UniversalPropertiesBox.Controls.Add(this.label2);
            this.UniversalPropertiesBox.Controls.Add(this.boxDesc);
            this.UniversalPropertiesBox.Controls.Add(this.label1);
            this.UniversalPropertiesBox.Controls.Add(this.boxName);
            this.UniversalPropertiesBox.Location = new System.Drawing.Point(12, 27);
            this.UniversalPropertiesBox.Name = "UniversalPropertiesBox";
            this.UniversalPropertiesBox.Size = new System.Drawing.Size(355, 499);
            this.UniversalPropertiesBox.TabIndex = 1;
            this.UniversalPropertiesBox.TabStop = false;
            this.UniversalPropertiesBox.Text = "Universal Item Properties";
            this.UniversalPropertiesBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Device Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cost";
            // 
            // boxWeight
            // 
            this.boxWeight.Location = new System.Drawing.Point(245, 88);
            this.boxWeight.Name = "boxWeight";
            this.boxWeight.Size = new System.Drawing.Size(100, 20);
            this.boxWeight.TabIndex = 10;
            // 
            // boxCost
            // 
            this.boxCost.Location = new System.Drawing.Point(43, 88);
            this.boxCost.Name = "boxCost";
            this.boxCost.Size = new System.Drawing.Size(100, 20);
            this.boxCost.TabIndex = 9;
            // 
            // boxDR
            // 
            this.boxDR.Location = new System.Drawing.Point(245, 62);
            this.boxDR.Name = "boxDR";
            this.boxDR.Size = new System.Drawing.Size(100, 20);
            this.boxDR.TabIndex = 2;
            // 
            // boxRules
            // 
            this.boxRules.Location = new System.Drawing.Point(6, 324);
            this.boxRules.Multiline = true;
            this.boxRules.Name = "boxRules";
            this.boxRules.Size = new System.Drawing.Size(339, 156);
            this.boxRules.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Avail";
            // 
            // boxAvail
            // 
            this.boxAvail.Location = new System.Drawing.Point(43, 62);
            this.boxAvail.Name = "boxAvail";
            this.boxAvail.Size = new System.Drawing.Size(100, 20);
            this.boxAvail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // boxDesc
            // 
            this.boxDesc.Location = new System.Drawing.Point(10, 138);
            this.boxDesc.Multiline = true;
            this.boxDesc.Name = "boxDesc";
            this.boxDesc.Size = new System.Drawing.Size(335, 156);
            this.boxDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(87, 36);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(204, 20);
            this.boxName.TabIndex = 0;
            // 
            // SpecialPropertiesBox
            // 
            this.SpecialPropertiesBox.Controls.Add(this.ModSlotsBox);
            this.SpecialPropertiesBox.Controls.Add(this.slbl8);
            this.SpecialPropertiesBox.Controls.Add(this.slbl7);
            this.SpecialPropertiesBox.Controls.Add(this.sdrop1);
            this.SpecialPropertiesBox.Controls.Add(this.sdrop2);
            this.SpecialPropertiesBox.Controls.Add(this.slbl6);
            this.SpecialPropertiesBox.Controls.Add(this.slbl5);
            this.SpecialPropertiesBox.Controls.Add(this.slbl4);
            this.SpecialPropertiesBox.Controls.Add(this.slbl3);
            this.SpecialPropertiesBox.Controls.Add(this.slbl2);
            this.SpecialPropertiesBox.Controls.Add(this.slbl1);
            this.SpecialPropertiesBox.Controls.Add(this.sbox6);
            this.SpecialPropertiesBox.Controls.Add(this.sbox5);
            this.SpecialPropertiesBox.Controls.Add(this.sbox4);
            this.SpecialPropertiesBox.Controls.Add(this.sbox3);
            this.SpecialPropertiesBox.Controls.Add(this.sbox2);
            this.SpecialPropertiesBox.Controls.Add(this.sbox1);
            this.SpecialPropertiesBox.Location = new System.Drawing.Point(373, 27);
            this.SpecialPropertiesBox.Name = "SpecialPropertiesBox";
            this.SpecialPropertiesBox.Size = new System.Drawing.Size(244, 499);
            this.SpecialPropertiesBox.TabIndex = 2;
            this.SpecialPropertiesBox.TabStop = false;
            this.SpecialPropertiesBox.Text = "Special Properties";
            // 
            // ModSlotsBox
            // 
            this.ModSlotsBox.Controls.Add(this.checkBox6);
            this.ModSlotsBox.Controls.Add(this.checkBox5);
            this.ModSlotsBox.Controls.Add(this.checkBox4);
            this.ModSlotsBox.Controls.Add(this.checkBox3);
            this.ModSlotsBox.Controls.Add(this.checkBox2);
            this.ModSlotsBox.Controls.Add(this.checkBox1);
            this.ModSlotsBox.Location = new System.Drawing.Point(6, 393);
            this.ModSlotsBox.Name = "ModSlotsBox";
            this.ModSlotsBox.Size = new System.Drawing.Size(231, 100);
            this.ModSlotsBox.TabIndex = 17;
            this.ModSlotsBox.TabStop = false;
            this.ModSlotsBox.Text = "Mod Slots";
            this.ModSlotsBox.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(155, 70);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(48, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Misc";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(155, 47);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(55, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Under";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(155, 24);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(45, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Top";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 70);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Barrel";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Side";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Stock";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // slbl8
            // 
            this.slbl8.AutoSize = true;
            this.slbl8.Location = new System.Drawing.Point(30, 358);
            this.slbl8.Name = "slbl8";
            this.slbl8.Size = new System.Drawing.Size(41, 13);
            this.slbl8.TabIndex = 16;
            this.slbl8.Text = "label15";
            this.slbl8.Visible = false;
            // 
            // slbl7
            // 
            this.slbl7.AutoSize = true;
            this.slbl7.Location = new System.Drawing.Point(30, 308);
            this.slbl7.Name = "slbl7";
            this.slbl7.Size = new System.Drawing.Size(41, 13);
            this.slbl7.TabIndex = 15;
            this.slbl7.Text = "label14";
            this.slbl7.Visible = false;
            // 
            // sdrop1
            // 
            this.sdrop1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sdrop1.FormattingEnabled = true;
            this.sdrop1.Location = new System.Drawing.Point(116, 305);
            this.sdrop1.Name = "sdrop1";
            this.sdrop1.Size = new System.Drawing.Size(121, 21);
            this.sdrop1.TabIndex = 13;
            this.sdrop1.Visible = false;
            // 
            // sdrop2
            // 
            this.sdrop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sdrop2.FormattingEnabled = true;
            this.sdrop2.Location = new System.Drawing.Point(116, 355);
            this.sdrop2.Name = "sdrop2";
            this.sdrop2.Size = new System.Drawing.Size(121, 21);
            this.sdrop2.TabIndex = 12;
            this.sdrop2.Visible = false;
            // 
            // slbl6
            // 
            this.slbl6.AutoSize = true;
            this.slbl6.Location = new System.Drawing.Point(14, 250);
            this.slbl6.Name = "slbl6";
            this.slbl6.Size = new System.Drawing.Size(41, 13);
            this.slbl6.TabIndex = 11;
            this.slbl6.Text = "label13";
            this.slbl6.Visible = false;
            // 
            // slbl5
            // 
            this.slbl5.AutoSize = true;
            this.slbl5.Location = new System.Drawing.Point(30, 207);
            this.slbl5.Name = "slbl5";
            this.slbl5.Size = new System.Drawing.Size(41, 13);
            this.slbl5.TabIndex = 10;
            this.slbl5.Text = "label12";
            this.slbl5.Visible = false;
            // 
            // slbl4
            // 
            this.slbl4.AutoSize = true;
            this.slbl4.Location = new System.Drawing.Point(30, 164);
            this.slbl4.Name = "slbl4";
            this.slbl4.Size = new System.Drawing.Size(41, 13);
            this.slbl4.TabIndex = 9;
            this.slbl4.Text = "label11";
            this.slbl4.Visible = false;
            // 
            // slbl3
            // 
            this.slbl3.AutoSize = true;
            this.slbl3.Location = new System.Drawing.Point(30, 121);
            this.slbl3.Name = "slbl3";
            this.slbl3.Size = new System.Drawing.Size(41, 13);
            this.slbl3.TabIndex = 8;
            this.slbl3.Text = "label10";
            this.slbl3.Visible = false;
            // 
            // slbl2
            // 
            this.slbl2.AutoSize = true;
            this.slbl2.Location = new System.Drawing.Point(30, 78);
            this.slbl2.Name = "slbl2";
            this.slbl2.Size = new System.Drawing.Size(35, 13);
            this.slbl2.TabIndex = 7;
            this.slbl2.Text = "label9";
            this.slbl2.Visible = false;
            // 
            // slbl1
            // 
            this.slbl1.AutoSize = true;
            this.slbl1.Location = new System.Drawing.Point(30, 39);
            this.slbl1.Name = "slbl1";
            this.slbl1.Size = new System.Drawing.Size(35, 13);
            this.slbl1.TabIndex = 6;
            this.slbl1.Text = "label8";
            this.slbl1.Visible = false;
            // 
            // sbox6
            // 
            this.sbox6.Location = new System.Drawing.Point(116, 247);
            this.sbox6.Name = "sbox6";
            this.sbox6.Size = new System.Drawing.Size(100, 20);
            this.sbox6.TabIndex = 5;
            this.sbox6.Visible = false;
            // 
            // sbox5
            // 
            this.sbox5.Location = new System.Drawing.Point(116, 204);
            this.sbox5.Name = "sbox5";
            this.sbox5.Size = new System.Drawing.Size(100, 20);
            this.sbox5.TabIndex = 4;
            this.sbox5.Visible = false;
            // 
            // sbox4
            // 
            this.sbox4.Location = new System.Drawing.Point(116, 161);
            this.sbox4.Name = "sbox4";
            this.sbox4.Size = new System.Drawing.Size(100, 20);
            this.sbox4.TabIndex = 3;
            this.sbox4.Visible = false;
            // 
            // sbox3
            // 
            this.sbox3.Location = new System.Drawing.Point(116, 118);
            this.sbox3.Name = "sbox3";
            this.sbox3.Size = new System.Drawing.Size(100, 20);
            this.sbox3.TabIndex = 2;
            this.sbox3.Visible = false;
            // 
            // sbox2
            // 
            this.sbox2.Location = new System.Drawing.Point(116, 75);
            this.sbox2.Name = "sbox2";
            this.sbox2.Size = new System.Drawing.Size(100, 20);
            this.sbox2.TabIndex = 1;
            this.sbox2.Visible = false;
            // 
            // sbox1
            // 
            this.sbox1.Location = new System.Drawing.Point(116, 32);
            this.sbox1.Name = "sbox1";
            this.sbox1.Size = new System.Drawing.Size(100, 20);
            this.sbox1.TabIndex = 0;
            this.sbox1.Visible = false;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(18, 532);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(592, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set All";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 566);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.SpecialPropertiesBox);
            this.Controls.Add(this.UniversalPropertiesBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Item Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.UniversalPropertiesBox.ResumeLayout(false);
            this.UniversalPropertiesBox.PerformLayout();
            this.SpecialPropertiesBox.ResumeLayout(false);
            this.SpecialPropertiesBox.PerformLayout();
            this.ModSlotsBox.ResumeLayout(false);
            this.ModSlotsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox UniversalPropertiesBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxWeight;
        private System.Windows.Forms.TextBox boxCost;
        private System.Windows.Forms.TextBox boxDR;
        private System.Windows.Forms.TextBox boxRules;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxAvail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.GroupBox SpecialPropertiesBox;
        private System.Windows.Forms.Label slbl8;
        private System.Windows.Forms.Label slbl7;
        private System.Windows.Forms.ComboBox sdrop1;
        private System.Windows.Forms.ComboBox sdrop2;
        private System.Windows.Forms.Label slbl6;
        private System.Windows.Forms.Label slbl5;
        private System.Windows.Forms.Label slbl4;
        private System.Windows.Forms.Label slbl3;
        private System.Windows.Forms.Label slbl2;
        private System.Windows.Forms.Label slbl1;
        private System.Windows.Forms.TextBox sbox6;
        private System.Windows.Forms.TextBox sbox5;
        private System.Windows.Forms.TextBox sbox4;
        private System.Windows.Forms.TextBox sbox3;
        private System.Windows.Forms.TextBox sbox2;
        private System.Windows.Forms.TextBox sbox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox ModSlotsBox;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

