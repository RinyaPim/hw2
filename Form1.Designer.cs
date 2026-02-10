namespace MBi
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
            textweight = new TextBox();
            textheight = new TextBox();
            button1 = new Button();
            textBMI = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblResult1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textweight
            // 
            textweight.Location = new Point(102, 66);
            textweight.Name = "textweight";
            textweight.Size = new Size(149, 27);
            textweight.TabIndex = 0;
            textweight.TextChanged += textBox1_TextChanged;
            // 
            // textheight
            // 
            textheight.Location = new Point(102, 134);
            textheight.Name = "textheight";
            textheight.Size = new Size(149, 27);
            textheight.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(366, 95);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBMI
            // 
            textBMI.Location = new Point(44, 198);
            textBMI.Name = "textBMI";
            textBMI.Size = new Size(416, 27);
            textBMI.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBMI);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textheight);
            groupBox1.Controls.Add(textweight);
            groupBox1.Location = new Point(308, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 244);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวนค่า BMI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 175);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 8;
            label5.Text = "ค่า BMI ของคุณ คือ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 135);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 7;
            label4.Text = "ซ.ม.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 73);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 6;
            label3.Text = "ก.ก.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 134);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "ส่วนสูง";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 66);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "น้ำหนัก";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lblResult1);
            groupBox2.Location = new Point(310, 326);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 291);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลทดสอบ";
            // 
            // lblResult1
            // 
            lblResult1.Location = new Point(42, 26);
            lblResult1.Multiline = true;
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(438, 192);
            lblResult1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 686);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BMIForm";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textweight;
        private TextBox textheight;
        private Button button1;
        private TextBox textBMI;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox lblResult1;
    }
}
