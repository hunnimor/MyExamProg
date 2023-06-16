namespace exam
{
    partial class Auth
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 39);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(88, 319);
            button1.Name = "button1";
            button1.Size = new Size(329, 46);
            button1.TabIndex = 2;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(500, 319);
            button2.Name = "button2";
            button2.Size = new Size(329, 46);
            button2.TabIndex = 5;
            button2.Text = "Зарегистрироваться";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(500, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(329, 39);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(500, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(329, 39);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(88, 68);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(329, 54);
            textBox5.TabIndex = 6;
            textBox5.Text = "Войти в аккаунт";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Enabled = false;
            textBox6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(500, 68);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(329, 54);
            textBox6.TabIndex = 7;
            textBox6.Text = "Регистрация";
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 443);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Auth";
            Text = "Auth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}