namespace P5_3_1214057
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbScanner = new System.Windows.Forms.RadioButton();
            this.rbPrinter = new System.Windows.Forms.RadioButton();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.rbKeyboard = new System.Windows.Forms.RadioButton();
            this.rbMonitor = new System.Windows.Forms.RadioButton();
            this.tsGambar = new System.Windows.Forms.ToolStrip();
            this.tsbMouse = new System.Windows.Forms.ToolStripButton();
            this.tsbMonitor = new System.Windows.Forms.ToolStripButton();
            this.tsbPrinter = new System.Windows.Forms.ToolStripButton();
            this.tsbKeyboard = new System.Windows.Forms.ToolStripButton();
            this.tsbScanner = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslKetGambar = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.tsGambar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilih salah satu item berikut dan klik pada gambar yang sesuai!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbScanner);
            this.groupBox1.Controls.Add(this.rbPrinter);
            this.groupBox1.Controls.Add(this.rbMouse);
            this.groupBox1.Controls.Add(this.rbKeyboard);
            this.groupBox1.Controls.Add(this.rbMonitor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nama Gambar";
            // 
            // rbScanner
            // 
            this.rbScanner.AutoSize = true;
            this.rbScanner.Location = new System.Drawing.Point(23, 133);
            this.rbScanner.Name = "rbScanner";
            this.rbScanner.Size = new System.Drawing.Size(71, 19);
            this.rbScanner.TabIndex = 4;
            this.rbScanner.Text = "Scanner";
            this.rbScanner.UseVisualStyleBackColor = true;
            // 
            // rbPrinter
            // 
            this.rbPrinter.AutoSize = true;
            this.rbPrinter.Location = new System.Drawing.Point(23, 107);
            this.rbPrinter.Name = "rbPrinter";
            this.rbPrinter.Size = new System.Drawing.Size(61, 19);
            this.rbPrinter.TabIndex = 3;
            this.rbPrinter.Text = "Printer";
            this.rbPrinter.UseVisualStyleBackColor = true;
            // 
            // rbMouse
            // 
            this.rbMouse.AutoSize = true;
            this.rbMouse.Location = new System.Drawing.Point(23, 82);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.Size = new System.Drawing.Size(63, 19);
            this.rbMouse.TabIndex = 2;
            this.rbMouse.Text = "Mouse";
            this.rbMouse.UseVisualStyleBackColor = true;
            // 
            // rbKeyboard
            // 
            this.rbKeyboard.AutoSize = true;
            this.rbKeyboard.Location = new System.Drawing.Point(23, 56);
            this.rbKeyboard.Name = "rbKeyboard";
            this.rbKeyboard.Size = new System.Drawing.Size(77, 19);
            this.rbKeyboard.TabIndex = 1;
            this.rbKeyboard.Text = "Keyboard";
            this.rbKeyboard.UseVisualStyleBackColor = true;
            // 
            // rbMonitor
            // 
            this.rbMonitor.AutoSize = true;
            this.rbMonitor.Checked = true;
            this.rbMonitor.Location = new System.Drawing.Point(23, 30);
            this.rbMonitor.Name = "rbMonitor";
            this.rbMonitor.Size = new System.Drawing.Size(67, 19);
            this.rbMonitor.TabIndex = 0;
            this.rbMonitor.TabStop = true;
            this.rbMonitor.Text = "Monitor";
            this.rbMonitor.UseVisualStyleBackColor = true;
            // 
            // tsGambar
            // 
            this.tsGambar.AutoSize = false;
            this.tsGambar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsGambar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGambar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsGambar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMouse,
            this.tsbMonitor,
            this.tsbPrinter,
            this.tsbKeyboard,
            this.tsbScanner});
            this.tsGambar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsGambar.Location = new System.Drawing.Point(281, 39);
            this.tsGambar.Name = "tsGambar";
            this.tsGambar.Size = new System.Drawing.Size(130, 343);
            this.tsGambar.TabIndex = 3;
            this.tsGambar.Text = "toolStrip1";
            // 
            // tsbMouse
            // 
            this.tsbMouse.AutoSize = false;
            this.tsbMouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMouse.Image = ((System.Drawing.Image)(resources.GetObject("tsbMouse.Image")));
            this.tsbMouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMouse.Name = "tsbMouse";
            this.tsbMouse.Size = new System.Drawing.Size(60, 60);
            this.tsbMouse.Tag = "Mouse";
            this.tsbMouse.Text = "Mouse";
            this.tsbMouse.CheckedChanged += new System.EventHandler(this.tsbMouse_CheckedChanged);
            this.tsbMouse.Click += new System.EventHandler(this.tsbMouse_Click_1);
            // 
            // tsbMonitor
            // 
            this.tsbMonitor.AutoSize = false;
            this.tsbMonitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMonitor.Image = ((System.Drawing.Image)(resources.GetObject("tsbMonitor.Image")));
            this.tsbMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMonitor.Name = "tsbMonitor";
            this.tsbMonitor.Size = new System.Drawing.Size(60, 60);
            this.tsbMonitor.Tag = "Monitor";
            this.tsbMonitor.Text = "Monitor";
            this.tsbMonitor.CheckedChanged += new System.EventHandler(this.tsbMonitor_CheckedChanged);
            // 
            // tsbPrinter
            // 
            this.tsbPrinter.AutoSize = false;
            this.tsbPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrinter.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrinter.Image")));
            this.tsbPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrinter.Name = "tsbPrinter";
            this.tsbPrinter.Size = new System.Drawing.Size(60, 60);
            this.tsbPrinter.Tag = "Printer";
            this.tsbPrinter.Text = "Printer";
            this.tsbPrinter.CheckedChanged += new System.EventHandler(this.tsbPrinter_CheckedChanged);
            // 
            // tsbKeyboard
            // 
            this.tsbKeyboard.AutoSize = false;
            this.tsbKeyboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKeyboard.Image = ((System.Drawing.Image)(resources.GetObject("tsbKeyboard.Image")));
            this.tsbKeyboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKeyboard.Name = "tsbKeyboard";
            this.tsbKeyboard.Size = new System.Drawing.Size(60, 60);
            this.tsbKeyboard.Tag = "Keyboard";
            this.tsbKeyboard.Text = "Keyboard";
            this.tsbKeyboard.CheckedChanged += new System.EventHandler(this.tsbKeyboard_CheckedChanged);
            // 
            // tsbScanner
            // 
            this.tsbScanner.AutoSize = false;
            this.tsbScanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScanner.Image = ((System.Drawing.Image)(resources.GetObject("tsbScanner.Image")));
            this.tsbScanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScanner.Name = "tsbScanner";
            this.tsbScanner.Size = new System.Drawing.Size(60, 60);
            this.tsbScanner.Tag = "Scanner";
            this.tsbScanner.Text = "Scanner";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslKetGambar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(454, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslKetGambar
            // 
            this.tslKetGambar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslKetGambar.ForeColor = System.Drawing.Color.Red;
            this.tslKetGambar.Name = "tslKetGambar";
            this.tslKetGambar.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsGambar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsGambar.ResumeLayout(false);
            this.tsGambar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbScanner;
        private System.Windows.Forms.RadioButton rbPrinter;
        private System.Windows.Forms.RadioButton rbMouse;
        private System.Windows.Forms.RadioButton rbKeyboard;
        private System.Windows.Forms.RadioButton rbMonitor;
        private System.Windows.Forms.ToolStrip tsGambar;
        private System.Windows.Forms.ToolStripButton tsbMouse;
        private System.Windows.Forms.ToolStripButton tsbMonitor;
        private System.Windows.Forms.ToolStripButton tsbPrinter;
        private System.Windows.Forms.ToolStripButton tsbKeyboard;
        private System.Windows.Forms.ToolStripButton tsbScanner;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslKetGambar;
    }
}

