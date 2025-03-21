namespace Lab8WinForms
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripComboBox2 = new ToolStripComboBox();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripComboBox3 = new ToolStripComboBox();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripComboBox2, toolStripTextBox1, toolStripTextBox2, toolStripTextBox3, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "&Color";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Items.AddRange(new object[] { "1", "2", "4", "6", "7", "8", "9", "10" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            toolStripComboBox1.ToolTipText = "a";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox2.Items.AddRange(new object[] { "11", "12", "13", "14", "15", "16", "17" });
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            toolStripComboBox2.ToolTipText = "b";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 28);
            toolStripTextBox1.Text = "0";
            toolStripTextBox1.ToolTipText = "Красный";
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 28);
            toolStripTextBox2.Text = "0";
            toolStripTextBox2.ToolTipText = "Зеленый";
            toolStripTextBox2.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 28);
            toolStripTextBox3.Text = "0";
            toolStripTextBox3.ToolTipText = "Синий";
            toolStripTextBox3.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.Red;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(47, 28);
            toolStripMenuItem1.Text = "E&xit";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.ControlDarkDark;
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.OwnerItem = toolStripDropDownButton1;
            contextMenuStrip1.Size = new Size(182, 36);
            // 
            // toolStripComboBox3
            // 
            toolStripComboBox3.BackColor = Color.Moccasin;
            toolStripComboBox3.Items.AddRange(new object[] { "Уравнение 1", "Уравнение 2" });
            toolStripComboBox3.Name = "toolStripComboBox3";
            toolStripComboBox3.Size = new Size(121, 28);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDown = contextMenuStrip1;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 212);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.PaleGreen;
            toolStripStatusLabel1.ImageTransparentColor = Color.Blue;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(17, 20);
            toolStripStatusLabel1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(311, 192);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = ">+<";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox2;
        private Label label1;
        private ToolStripComboBox toolStripComboBox3;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label2;
    }
}
