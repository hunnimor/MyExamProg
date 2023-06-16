namespace exam
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            информацияОбАккаунтеToolStripMenuItem = new ToolStripMenuItem();
            выйтиИзАккаунтаToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 40);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1128, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { информацияОбАккаунтеToolStripMenuItem, выйтиИзАккаунтаToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1128, 40);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // информацияОбАккаунтеToolStripMenuItem
            // 
            информацияОбАккаунтеToolStripMenuItem.Name = "информацияОбАккаунтеToolStripMenuItem";
            информацияОбАккаунтеToolStripMenuItem.Size = new Size(318, 36);
            информацияОбАккаунтеToolStripMenuItem.Text = "Информация об аккаунте";
            информацияОбАккаунтеToolStripMenuItem.Click += информацияОбАккаунтеToolStripMenuItem_Click;
            // 
            // выйтиИзАккаунтаToolStripMenuItem
            // 
            выйтиИзАккаунтаToolStripMenuItem.Name = "выйтиИзАккаунтаToolStripMenuItem";
            выйтиИзАккаунтаToolStripMenuItem.Size = new Size(238, 36);
            выйтиИзАккаунтаToolStripMenuItem.Text = "Выйти из аккаунта";
            выйтиИзАккаунтаToolStripMenuItem.Click += выйтиИзАккаунтаToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(36, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1057, 818);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(371, 910);
            button1.Name = "button1";
            button1.Size = new Size(367, 46);
            button1.TabIndex = 3;
            button1.Text = "Нарисовать график";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 968);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem информацияОбАккаунтеToolStripMenuItem;
        private ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
    }
}