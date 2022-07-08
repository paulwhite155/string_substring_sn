namespace string_substring_practise
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.birthyear_label2 = new System.Windows.Forms.Label();
            this.birthdayYear_TextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdate_TB = new System.Windows.Forms.MaskedTextBox();
            this.birth_MOnth_TB = new System.Windows.Forms.Label();
            this.birthMonth_TextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthday_TextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(41, 68);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(155, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "birhtday date";
            // 
            // birthyear_label2
            // 
            this.birthyear_label2.AutoSize = true;
            this.birthyear_label2.Location = new System.Drawing.Point(238, 255);
            this.birthyear_label2.Name = "birthyear_label2";
            this.birthyear_label2.Size = new System.Drawing.Size(67, 13);
            this.birthyear_label2.TabIndex = 6;
            this.birthyear_label2.Text = "birhtday year";
            // 
            // birthdayYear_TextBox3
            // 
            this.birthdayYear_TextBox3.Location = new System.Drawing.Point(323, 248);
            this.birthdayYear_TextBox3.Name = "birthdayYear_TextBox3";
            this.birthdayYear_TextBox3.Size = new System.Drawing.Size(155, 20);
            this.birthdayYear_TextBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "birhtday date";
            // 
            // birthdate_TB
            // 
            this.birthdate_TB.Location = new System.Drawing.Point(323, 219);
            this.birthdate_TB.Name = "birthdate_TB";
            this.birthdate_TB.Size = new System.Drawing.Size(155, 20);
            this.birthdate_TB.TabIndex = 7;
            this.birthdate_TB.Text = "25/12/1981";
            // 
            // birth_MOnth_TB
            // 
            this.birth_MOnth_TB.AutoSize = true;
            this.birth_MOnth_TB.Location = new System.Drawing.Point(238, 296);
            this.birth_MOnth_TB.Name = "birth_MOnth_TB";
            this.birth_MOnth_TB.Size = new System.Drawing.Size(76, 13);
            this.birth_MOnth_TB.TabIndex = 13;
            this.birth_MOnth_TB.Text = "birhtday month";
            // 
            // birthMonth_TextBox5
            // 
            this.birthMonth_TextBox5.Location = new System.Drawing.Point(323, 296);
            this.birthMonth_TextBox5.Name = "birthMonth_TextBox5";
            this.birthMonth_TextBox5.Size = new System.Drawing.Size(155, 20);
            this.birthMonth_TextBox5.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "birhtday day";
            // 
            // birthday_TextBox6
            // 
            this.birthday_TextBox6.Location = new System.Drawing.Point(323, 334);
            this.birthday_TextBox6.Name = "birthday_TextBox6";
            this.birthday_TextBox6.Size = new System.Drawing.Size(155, 20);
            this.birthday_TextBox6.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "show result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "string.substring(location,length)";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(503, 248);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(155, 20);
            this.maskedTextBox2.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(503, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = " month name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "switch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.birth_MOnth_TB);
            this.Controls.Add(this.birthMonth_TextBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthday_TextBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthdate_TB);
            this.Controls.Add(this.birthyear_label2);
            this.Controls.Add(this.birthdayYear_TextBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birthyear_label2;
        private System.Windows.Forms.MaskedTextBox birthdayYear_TextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox birthdate_TB;
        private System.Windows.Forms.Label birth_MOnth_TB;
        private System.Windows.Forms.MaskedTextBox birthMonth_TextBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox birthday_TextBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

