namespace C3549375_ASE_Assignment
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
            this.DisplayBox = new System.Windows.Forms.PictureBox();
            this.CommandLine = new System.Windows.Forms.RichTextBox();
            this.CommandLineBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.Location = new System.Drawing.Point(666, 12);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(639, 586);
            this.DisplayBox.TabIndex = 1;
            this.DisplayBox.TabStop = false;
            this.DisplayBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayBox_Paint);
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(12, 604);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(1293, 36);
            this.CommandLine.TabIndex = 2;
            this.CommandLine.Text = "";
            this.CommandLine.TextChanged += new System.EventHandler(this.CommandLine_TextChanged);
            this.CommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandLine_KeyDown);
            // 
            // CommandLineBox
            // 
            this.CommandLineBox.Location = new System.Drawing.Point(12, 12);
            this.CommandLineBox.Name = "CommandLineBox";
            this.CommandLineBox.Size = new System.Drawing.Size(648, 586);
            this.CommandLineBox.TabIndex = 3;
            this.CommandLineBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 652);
            this.Controls.Add(this.CommandLineBox);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.DisplayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.RichTextBox CommandLine;
        private System.Windows.Forms.RichTextBox CommandLineBox;
    }
}

