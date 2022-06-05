namespace Saper
{
    partial class Saper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saper));
            this.Topbar = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.easyDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.hardDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.expertDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.hardcoreDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.Topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.CanOverflow = false;
            this.Topbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Topbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(612, 25);
            this.Topbar.TabIndex = 0;
            this.Topbar.Text = "Topbar";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.easyDiff,
            this.mediumDiff,
            this.hardDiff,
            this.expertDiff,
            this.hardcoreDiff});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripDropDownButton1.Text = "New game";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(125, 16);
            this.toolStripTextBox1.Text = "Choose difficulty level";
            // 
            // easyDiff
            // 
            this.easyDiff.Name = "easyDiff";
            this.easyDiff.Size = new System.Drawing.Size(185, 22);
            this.easyDiff.Text = "Easy";
            this.easyDiff.Click += new System.EventHandler(this.easyDiff_Click);
            // 
            // mediumDiff
            // 
            this.mediumDiff.Name = "mediumDiff";
            this.mediumDiff.Size = new System.Drawing.Size(185, 22);
            this.mediumDiff.Text = "Medium";
            this.mediumDiff.Click += new System.EventHandler(this.mediumDiff_Click);
            // 
            // hardDiff
            // 
            this.hardDiff.Name = "hardDiff";
            this.hardDiff.Size = new System.Drawing.Size(185, 22);
            this.hardDiff.Text = "Hard";
            this.hardDiff.Click += new System.EventHandler(this.hardDiff_Click);
            // 
            // expertDiff
            // 
            this.expertDiff.Name = "expertDiff";
            this.expertDiff.Size = new System.Drawing.Size(185, 22);
            this.expertDiff.Text = "Expert";
            this.expertDiff.Click += new System.EventHandler(this.expertDiff_Click);
            // 
            // hardcoreDiff
            // 
            this.hardcoreDiff.Name = "hardcoreDiff";
            this.hardcoreDiff.Size = new System.Drawing.Size(185, 22);
            this.hardcoreDiff.Text = "Hardcore";
            this.hardcoreDiff.Click += new System.EventHandler(this.hardcoreDiff_Click);
            // 
            // Saper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(612, 637);
            this.Controls.Add(this.Topbar);
            this.Name = "Saper";
            this.Text = "Saper";
            this.Load += new System.EventHandler(this.Saper_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip Topbar;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem easyDiff;
        private ToolStripMenuItem mediumDiff;
        private ToolStripMenuItem hardDiff;
        private ToolStripMenuItem expertDiff;
        private ToolStripMenuItem hardcoreDiff;
    }
}