namespace processor_8086
{
    partial class S
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
            this.button_wykonaj1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.AX = new System.Windows.Forms.TextBox();
            this.BX = new System.Windows.Forms.TextBox();
            this.CX = new System.Windows.Forms.TextBox();
            this.DX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.DISP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.BP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SI = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_wykonaj1
            // 
            this.button_wykonaj1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_wykonaj1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_wykonaj1.ForeColor = System.Drawing.Color.Red;
            this.button_wykonaj1.Location = new System.Drawing.Point(283, 296);
            this.button_wykonaj1.Name = "button_wykonaj1";
            this.button_wykonaj1.Size = new System.Drawing.Size(176, 48);
            this.button_wykonaj1.TabIndex = 0;
            this.button_wykonaj1.Text = "EXECUTE";
            this.button_wykonaj1.UseVisualStyleBackColor = true;
            this.button_wykonaj1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "register to register";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "register to memory";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 19);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "register to memory";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // AX
            // 
            this.AX.Location = new System.Drawing.Point(103, 80);
            this.AX.MaxLength = 4;
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(100, 23);
            this.AX.TabIndex = 4;
            this.AX.Text = "0x00\r\n";
            this.AX.TextChanged += new System.EventHandler(this.AX_TextChanged);
            // 
            // BX
            // 
            this.BX.Location = new System.Drawing.Point(252, 79);
            this.BX.MaxLength = 4;
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(100, 23);
            this.BX.TabIndex = 5;
            this.BX.Text = "0x00";
            this.BX.TextChanged += new System.EventHandler(this.BX_TextChanged);
            // 
            // CX
            // 
            this.CX.Location = new System.Drawing.Point(428, 79);
            this.CX.MaxLength = 4;
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(100, 23);
            this.CX.TabIndex = 6;
            this.CX.Text = "0x00";
            this.CX.TextChanged += new System.EventHandler(this.CX_TextChanged);
            // 
            // DX
            // 
            this.DX.Location = new System.Drawing.Point(604, 79);
            this.DX.MaxLength = 4;
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(100, 23);
            this.DX.TabIndex = 7;
            this.DX.Text = "0x00";
            this.DX.TextChanged += new System.EventHandler(this.DX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "AX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "BX";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "DX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(256, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 43);
            this.label5.TabIndex = 12;
            this.label5.Text = "REGISTERS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "MOV",
            "XCHG"});
            this.listBox1.Location = new System.Drawing.Point(165, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(97, 94);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.listBox2.Location = new System.Drawing.Point(313, 196);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 14;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.listBox3.Location = new System.Drawing.Point(480, 196);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 94);
            this.listBox3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Instruction";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Source";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Target";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(59, 591);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 43);
            this.label10.TabIndex = 20;
            this.label10.Text = "MENU";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1157, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 43);
            this.label9.TabIndex = 19;
            this.label9.Text = "MEMORY";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(747, 108);
            this.panel1.MaximumSize = new System.Drawing.Size(20000, 20000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 1808);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(45, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 119);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.DISP);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Location = new System.Drawing.Point(114, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 193);
            this.panel3.TabIndex = 23;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(285, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "DI:";
            // 
            // DISP
            // 
            this.DISP.Location = new System.Drawing.Point(321, 57);
            this.DISP.Name = "DISP";
            this.DISP.Size = new System.Drawing.Size(100, 23);
            this.DISP.TabIndex = 26;
            this.DISP.Text = "0x00";
            this.DISP.TextChanged += new System.EventHandler(this.DISP_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(285, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "DISPLACMENT";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(23, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "MODE";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 78);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(116, 19);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Based addressing";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(20, 103);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(127, 19);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "Indexed addressing";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(20, 128);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(150, 19);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "Based-index addressing";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "BP";
            // 
            // BP
            // 
            this.BP.Location = new System.Drawing.Point(104, 123);
            this.BP.MaxLength = 4;
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(100, 23);
            this.BP.TabIndex = 24;
            this.BP.Text = "0x00";
            this.BP.TextChanged += new System.EventHandler(this.BP_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(209, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "SI";
            // 
            // SI
            // 
            this.SI.Location = new System.Drawing.Point(253, 123);
            this.SI.MaxLength = 4;
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(100, 23);
            this.SI.TabIndex = 27;
            this.SI.Text = "0x00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(1, -1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Created by Łukasz kutyński";
            // 
            // S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1384, 758);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_wykonaj1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DX);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.BX);
            this.Controls.Add(this.AX);
            this.Name = "S";
            this.Text = "8086 simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VScrollBar vScrollBar1;
        private Button button_wykonaj1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox AX;
        private TextBox BX;
        private TextBox CX;
        private TextBox DX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label11;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label12;
        private TextBox DISP;
        private Label label13;
        private TextBox BP;
        private Label label15;
        private TextBox SI;
        private Label label14;
        private Label label16;
    }
}