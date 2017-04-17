namespace PaintPencil
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseLocationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lineBtn = new System.Windows.Forms.Button();
            this.freeBtn = new System.Windows.Forms.Button();
            this.Rectbtn = new System.Windows.Forms.Button();
            this.Ellipsebtn = new System.Windows.Forms.Button();
            this.Fillbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Scroll = new System.Windows.Forms.VScrollBar();
            this.Size1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.spraybtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(76, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 257);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(14, 68);
            this.colorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(57, 31);
            this.colorBtn.TabIndex = 1;
            this.colorBtn.Text = "color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseLocationLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mouseLocationLabel
            // 
            this.mouseLocationLabel.Name = "mouseLocationLabel";
            this.mouseLocationLabel.Size = new System.Drawing.Size(89, 17);
            this.mouseLocationLabel.Text = "mouseLocation";
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(14, 103);
            this.lineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(57, 28);
            this.lineBtn.TabIndex = 3;
            this.lineBtn.Text = "line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // freeBtn
            // 
            this.freeBtn.Location = new System.Drawing.Point(14, 135);
            this.freeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.freeBtn.Name = "freeBtn";
            this.freeBtn.Size = new System.Drawing.Size(57, 28);
            this.freeBtn.TabIndex = 4;
            this.freeBtn.Text = "free";
            this.freeBtn.UseVisualStyleBackColor = true;
            this.freeBtn.Click += new System.EventHandler(this.freeBtn_Click);
            // 
            // Rectbtn
            // 
            this.Rectbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rectbtn.Location = new System.Drawing.Point(14, 168);
            this.Rectbtn.Name = "Rectbtn";
            this.Rectbtn.Size = new System.Drawing.Size(57, 27);
            this.Rectbtn.TabIndex = 5;
            this.Rectbtn.Text = "Rect";
            this.Rectbtn.UseVisualStyleBackColor = true;
            this.Rectbtn.Click += new System.EventHandler(this.Rectbtn_Click);
            // 
            // Ellipsebtn
            // 
            this.Ellipsebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ellipsebtn.Location = new System.Drawing.Point(14, 201);
            this.Ellipsebtn.Name = "Ellipsebtn";
            this.Ellipsebtn.Size = new System.Drawing.Size(57, 24);
            this.Ellipsebtn.TabIndex = 6;
            this.Ellipsebtn.Text = "Ellipse";
            this.Ellipsebtn.UseVisualStyleBackColor = true;
            this.Ellipsebtn.Click += new System.EventHandler(this.Ellipsebtn_Click);
            // 
            // Fillbtn
            // 
            this.Fillbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fillbtn.Location = new System.Drawing.Point(14, 231);
            this.Fillbtn.Name = "Fillbtn";
            this.Fillbtn.Size = new System.Drawing.Size(57, 24);
            this.Fillbtn.TabIndex = 7;
            this.Fillbtn.Text = "Fill";
            this.Fillbtn.UseVisualStyleBackColor = true;
            this.Fillbtn.Click += new System.EventHandler(this.Fillbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saToolStripMenuItem,
            this.saToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saToolStripMenuItem.Text = "Save";
            this.saToolStripMenuItem.Click += new System.EventHandler(this.saToolStripMenuItem_Click);
            // 
            // saToolStripMenuItem1
            // 
            this.saToolStripMenuItem1.Name = "saToolStripMenuItem1";
            this.saToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saToolStripMenuItem1.Text = "Open";
            this.saToolStripMenuItem1.Click += new System.EventHandler(this.saToolStripMenuItem1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Scroll
            // 
            this.Scroll.AccessibleName = "Scroll1";
            this.Scroll.LargeChange = 5;
            this.Scroll.Location = new System.Drawing.Point(636, 60);
            this.Scroll.Minimum = 1;
            this.Scroll.Name = "Scroll";
            this.Scroll.Size = new System.Drawing.Size(61, 234);
            this.Scroll.TabIndex = 9;
            this.Scroll.Value = 1;
            this.Scroll.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // Size1
            // 
            this.Size1.Location = new System.Drawing.Point(612, 297);
            this.Size1.Name = "Size1";
            this.Size1.Size = new System.Drawing.Size(100, 20);
            this.Size1.TabIndex = 10;
            this.Size1.Text = "Size = 1";
            this.Size1.TextChanged += new System.EventHandler(this.Size1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(14, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Triangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // spraybtn
            // 
            this.spraybtn.Location = new System.Drawing.Point(15, 299);
            this.spraybtn.Margin = new System.Windows.Forms.Padding(2);
            this.spraybtn.Name = "spraybtn";
            this.spraybtn.Size = new System.Drawing.Size(57, 28);
            this.spraybtn.TabIndex = 13;
            this.spraybtn.Text = "Spray";
            this.spraybtn.UseVisualStyleBackColor = true;
            this.spraybtn.Click += new System.EventHandler(this.spraybtn_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.spraybtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Size1);
            this.Controls.Add(this.Scroll);
            this.Controls.Add(this.Fillbtn);
            this.Controls.Add(this.Ellipsebtn);
            this.Controls.Add(this.Rectbtn);
            this.Controls.Add(this.freeBtn);
            this.Controls.Add(this.lineBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouseLocationLabel;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button freeBtn;
        private System.Windows.Forms.Button Rectbtn;
        private System.Windows.Forms.Button Ellipsebtn;
        private System.Windows.Forms.Button Fillbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.VScrollBar Scroll;
        private System.Windows.Forms.TextBox Size1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button spraybtn;
        private System.Windows.Forms.Timer timer1;
    }
}

