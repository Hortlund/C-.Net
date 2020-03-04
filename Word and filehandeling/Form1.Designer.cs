namespace Word_and_filehandeling
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.counter = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCount2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rowCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ny = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.counter,
            this.fileStatus,
            this.wordCount,
            this.charCount,
            this.charCount2,
            this.rowCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // counter
            // 
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(0, 17);
            // 
            // fileStatus
            // 
            this.fileStatus.Name = "fileStatus";
            this.fileStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // wordCount
            // 
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(47, 17);
            this.wordCount.Text = "Words: ";
            // 
            // charCount
            // 
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(88, 17);
            this.charCount.Text = "Chars w space: ";
            // 
            // charCount2
            // 
            this.charCount2.Name = "charCount2";
            this.charCount2.Size = new System.Drawing.Size(100, 17);
            this.charCount2.Text = "Chars w/o space: ";
            // 
            // rowCount
            // 
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(41, 17);
            this.rowCount.Text = "Rows: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ny,
            this.open,
            this.save,
            this.toolStripMenuItem5,
            this.close});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Arkiv";
            // 
            // ny
            // 
            this.ny.Name = "ny";
            this.ny.Size = new System.Drawing.Size(129, 22);
            this.ny.Text = "Ny";
            this.ny.Click += new System.EventHandler(this.ny_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(129, 22);
            this.open.Text = "Öppna";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(129, 22);
            this.save.Text = "Spara";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem5.Text = "Spara som";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(129, 22);
            this.close.Text = "Stäng";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(12, 27);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(776, 398);
            this.textArea.TabIndex = 2;
            this.textArea.Text = "";
            this.textArea.WordWrap = false;
            this.textArea.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "WordSmith 1.0";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel counter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem ny;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripStatusLabel fileStatus;
        private System.Windows.Forms.ToolStripStatusLabel wordCount;
        private System.Windows.Forms.ToolStripStatusLabel charCount;
        private System.Windows.Forms.ToolStripStatusLabel charCount2;
        private System.Windows.Forms.ToolStripStatusLabel rowCount;
    }
}

