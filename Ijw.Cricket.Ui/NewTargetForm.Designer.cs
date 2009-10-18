namespace Ijw.Cricket.Ui
{
    partial class NewTargetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.argsBox = new System.Windows.Forms.TextBox();
            this.dirBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arguments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Working Directory";
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(130, 23);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(292, 20);
            this.commandBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(428, 21);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(25, 23);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.OnBrowseTarget);
            // 
            // argsBox
            // 
            this.argsBox.Location = new System.Drawing.Point(130, 49);
            this.argsBox.Name = "argsBox";
            this.argsBox.Size = new System.Drawing.Size(292, 20);
            this.argsBox.TabIndex = 1;
            // 
            // dirBox
            // 
            this.dirBox.Location = new System.Drawing.Point(130, 75);
            this.dirBox.Name = "dirBox";
            this.dirBox.Size = new System.Drawing.Size(292, 20);
            this.dirBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(378, 116);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startButton.Location = new System.Drawing.Point(297, 116);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // NewTargetForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(465, 151);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.dirBox);
            this.Controls.Add(this.argsBox);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTargetForm";
            this.Text = "Start New Target...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox argsBox;
        private System.Windows.Forms.TextBox dirBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button startButton;
    }
}