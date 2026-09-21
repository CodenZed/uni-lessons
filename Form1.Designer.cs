namespace lesson1_Z
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
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(30, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(92, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 331);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 23);
            textBox4.TabIndex = 4;
            textBox4.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(30, 281);
            button1.Name = "button1";
            button1.Size = new Size(198, 23);
            button1.TabIndex = 7;
            button1.Text = "Sumbit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 3;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(48, 157);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Show password";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Location = new Point(458, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 275);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sign In";
            // 
            // button2
            // 
            button2.Location = new Point(41, 182);
            button2.Name = "button2";
            button2.Size = new Size(197, 23);
            button2.TabIndex = 8;
            button2.Text = "Sumbit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(41, 106);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(197, 23);
            textBox6.TabIndex = 6;
            textBox6.UseSystemPasswordChar = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(41, 54);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(197, 23);
            textBox5.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sign in or Sing up";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
    }
}
