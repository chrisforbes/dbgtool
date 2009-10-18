namespace Ijw.Cricket.Ui
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newTargetButton = new System.Windows.Forms.ToolStripButton();
            this.continueButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.detachButton = new System.Windows.Forms.ToolStripButton();
            this.collectDebugEventsTimer = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.SystemColors.Highlight;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            label1.Location = new System.Drawing.Point(2, 2);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            label1.Size = new System.Drawing.Size(795, 20);
            label1.TabIndex = 0;
            label1.Text = "Output";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(799, 547);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(799, 572);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(label1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Size = new System.Drawing.Size(799, 547);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(795, 188);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTargetButton,
            this.continueButton,
            this.stopButton,
            this.detachButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(393, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // newTargetButton
            // 
            this.newTargetButton.Image = ((System.Drawing.Image)(resources.GetObject("newTargetButton.Image")));
            this.newTargetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTargetButton.Name = "newTargetButton";
            this.newTargetButton.Size = new System.Drawing.Size(97, 22);
            this.newTargetButton.Text = "New Target...";
            this.newTargetButton.Click += new System.EventHandler(this.OnNewTargetClicked);
            // 
            // continueButton
            // 
            this.continueButton.Enabled = false;
            this.continueButton.Image = ((System.Drawing.Image)(resources.GetObject("continueButton.Image")));
            this.continueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(76, 22);
            this.continueButton.Text = "Continue";
            this.continueButton.Click += new System.EventHandler(this.OnContinueClicked);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(113, 22);
            this.stopButton.Text = "Stop Debugging";
            this.stopButton.ToolTipText = "Stops debugging, and terminates the target process";
            this.stopButton.Click += new System.EventHandler(this.OnStopDebuggingClicked);
            // 
            // detachButton
            // 
            this.detachButton.Enabled = false;
            this.detachButton.Image = ((System.Drawing.Image)(resources.GetObject("detachButton.Image")));
            this.detachButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detachButton.Name = "detachButton";
            this.detachButton.Size = new System.Drawing.Size(64, 22);
            this.detachButton.Text = "Detach";
            this.detachButton.ToolTipText = "Stops debugging, but allows the target process to keep running";
            this.detachButton.Click += new System.EventHandler(this.OnDetachClicked);
            // 
            // collectDebugEventsTimer
            // 
            this.collectDebugEventsTimer.Tick += new System.EventHandler(this.OnCollectTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 572);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "IJW Cricket";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newTargetButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer collectDebugEventsTimer;
        private System.Windows.Forms.ToolStripButton continueButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton detachButton;
    }
}

