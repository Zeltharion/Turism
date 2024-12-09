namespace Turism
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
            всеТурыToolStripMenuItem = new ToolStripMenuItem();
            текущиеТурыToolStripMenuItem = new ToolStripMenuItem();
            архивныеТурыToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { всеТурыToolStripMenuItem, текущиеТурыToolStripMenuItem, архивныеТурыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // всеТурыToolStripMenuItem
            // 
            всеТурыToolStripMenuItem.Name = "всеТурыToolStripMenuItem";
            всеТурыToolStripMenuItem.Size = new Size(68, 20);
            всеТурыToolStripMenuItem.Text = "Все туры";
            // 
            // текущиеТурыToolStripMenuItem
            // 
            текущиеТурыToolStripMenuItem.Name = "текущиеТурыToolStripMenuItem";
            текущиеТурыToolStripMenuItem.Size = new Size(97, 20);
            текущиеТурыToolStripMenuItem.Text = "Текущие туры";
            // 
            // архивныеТурыToolStripMenuItem
            // 
            архивныеТурыToolStripMenuItem.Name = "архивныеТурыToolStripMenuItem";
            архивныеТурыToolStripMenuItem.Size = new Size(105, 20);
            архивныеТурыToolStripMenuItem.Text = "Архивные туры";
            // 
            // button1
            // 
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 1;
            button1.Text = "Новый тур";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(100, 27);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 2;
            button2.Text = "Исправить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(188, 27);
            button3.Name = "button3";
            button3.Size = new Size(82, 23);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(276, 27);
            button4.Name = "button4";
            button4.Size = new Size(82, 23);
            button4.TabIndex = 4;
            button4.Text = "Выборка";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(364, 27);
            button5.Name = "button5";
            button5.Size = new Size(82, 23);
            button5.TabIndex = 5;
            button5.Text = "Обновить";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 255);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "База данных";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Location = new Point(12, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 115);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Месячный план продаж";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 91);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 24);
            progressBar1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(521, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(527, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Поиск";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(218, 323);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(570, 115);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Туристы";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Система автоматизации продаж путёвок";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem всеТурыToolStripMenuItem;
        private ToolStripMenuItem текущиеТурыToolStripMenuItem;
        private ToolStripMenuItem архивныеТурыToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox3;
    }
}
