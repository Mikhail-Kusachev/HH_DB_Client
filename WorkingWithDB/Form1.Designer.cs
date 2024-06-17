namespace WorkingWithDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip3 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tabPage7 = new TabPage();
            dataGridView3 = new DataGridView();
            tabPage6 = new TabPage();
            button4 = new Button();
            label13 = new Label();
            textBox13 = new TextBox();
            textBox15 = new TextBox();
            button6 = new Button();
            label15 = new Label();
            tabPage5 = new TabPage();
            button2 = new Button();
            label12 = new Label();
            textBox12 = new TextBox();
            textBox14 = new TextBox();
            button5 = new Button();
            label14 = new Label();
            tabPage4 = new TabPage();
            label6 = new Label();
            button3 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label11 = new Label();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            menuStrip3.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage6.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1062, 28);
            menuStrip3.TabIndex = 2;
            menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dataGridView3);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1054, 552);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "JOIN";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1048, 546);
            dataGridView3.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label15);
            tabPage6.Controls.Add(button6);
            tabPage6.Controls.Add(textBox15);
            tabPage6.Controls.Add(textBox13);
            tabPage6.Controls.Add(label13);
            tabPage6.Controls.Add(button4);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1054, 552);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "EXPORT SCV";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(898, 11);
            button4.Name = "button4";
            button4.Size = new Size(148, 29);
            button4.TabIndex = 0;
            button4.Text = "Export COMPANIES";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 15);
            label13.Name = "label13";
            label13.Size = new Size(61, 20);
            label13.TabIndex = 13;
            label13.Text = "csv Path";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(75, 12);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(817, 27);
            textBox13.TabIndex = 1;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(75, 45);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(817, 27);
            textBox15.TabIndex = 14;
            // 
            // button6
            // 
            button6.Location = new Point(898, 44);
            button6.Name = "button6";
            button6.Size = new Size(148, 29);
            button6.TabIndex = 15;
            button6.Text = "Export EMPLOYEES";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 48);
            label15.Name = "label15";
            label15.Size = new Size(61, 20);
            label15.TabIndex = 16;
            label15.Text = "csv Path";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(textBox14);
            tabPage5.Controls.Add(textBox12);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(button2);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1054, 552);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "IMPORT CSV";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(900, 11);
            button2.Name = "button2";
            button2.Size = new Size(148, 29);
            button2.TabIndex = 1;
            button2.Text = "Import COMPANIES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 15);
            label12.Name = "label12";
            label12.Size = new Size(61, 20);
            label12.TabIndex = 12;
            label12.Text = "csv Path";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(73, 12);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(821, 27);
            textBox12.TabIndex = 0;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(73, 45);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(821, 27);
            textBox14.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(900, 44);
            button5.Name = "button5";
            button5.Size = new Size(148, 29);
            button5.TabIndex = 14;
            button5.Text = "Import EMPLOYEES";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 48);
            label14.Name = "label14";
            label14.Size = new Size(61, 20);
            label14.TabIndex = 15;
            label14.Text = "csv Path";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(textBox11);
            tabPage4.Controls.Add(textBox10);
            tabPage4.Controls.Add(textBox5);
            tabPage4.Controls.Add(textBox7);
            tabPage4.Controls.Add(textBox8);
            tabPage4.Controls.Add(textBox9);
            tabPage4.Controls.Add(textBox6);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(label6);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1054, 552);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "INSERT EMPLOYEE";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 15);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 11;
            label6.Text = "FIRST_NAME";
            // 
            // button3
            // 
            button3.Location = new Point(591, 244);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 12;
            button3.Text = "Add employee";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 48);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 15;
            label9.Text = "MIDDLE_NAME";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(115, 82);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 16;
            label8.Text = "SURNAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 115);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 18;
            label7.Text = "BIRTH_DATE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 148);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 20;
            label5.Text = "PASSPORT_SERIES";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 181);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 22;
            label10.Text = "PASSPORT_NUMBER";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(199, 12);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(517, 27);
            textBox6.TabIndex = 10;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(199, 45);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(517, 27);
            textBox9.TabIndex = 13;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(199, 79);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(517, 27);
            textBox8.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(199, 112);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(517, 27);
            textBox7.TabIndex = 17;
            textBox7.Text = "1999-12-31";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(199, 145);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(517, 27);
            textBox5.TabIndex = 19;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(199, 178);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(517, 27);
            textBox10.TabIndex = 21;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(199, 211);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(517, 27);
            textBox11.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(82, 214);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 24;
            label11.Text = "INN (10 NUMS)";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1054, 552);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "INSERT COMPANY";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 15);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 2;
            label1.Text = "COMPANY_NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 49);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "INN";
            // 
            // button1
            // 
            button1.Location = new Point(591, 145);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 4;
            button1.Text = "Add company";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 82);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 6;
            label3.Text = "REGISTRATION_ADDRESS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(517, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(517, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(517, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(199, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(517, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 115);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 8;
            label4.Text = "OPERATIONAL_ADDRESS";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1054, 552);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "SELECT EMPLOYEES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1054, 552);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1054, 552);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SELECT COMPANIES";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1048, 546);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1062, 585);
            tabControl1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 613);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip3);
            Name = "Form1";
            Text = "HH Data Base Client";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip3;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabPage tabPage7;
        private DataGridView dataGridView3;
        private TabPage tabPage6;
        private Label label15;
        private Button button6;
        private TextBox textBox15;
        private TextBox textBox13;
        private Label label13;
        private Button button4;
        private TabPage tabPage5;
        private Label label14;
        private Button button5;
        private TextBox textBox14;
        private TextBox textBox12;
        private Label label12;
        private Button button2;
        private TabPage tabPage4;
        private Label label11;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox6;
        private Label label10;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button3;
        private Label label6;
        private TabPage tabPage2;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
    }
}
