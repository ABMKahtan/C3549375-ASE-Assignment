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
            this.CommandLineBox = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.CommandLine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisplayBox.Location = new System.Drawing.Point(666, 50);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(639, 548);
            this.DisplayBox.TabIndex = 1;
            this.DisplayBox.TabStop = false;
            this.DisplayBox.Click += new System.EventHandler(this.DisplayBox_Click);
            this.DisplayBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayBox_Paint);
            // 
            // CommandLineBox
            // 
            this.CommandLineBox.Location = new System.Drawing.Point(12, 50);
            this.CommandLineBox.Name = "CommandLineBox";
            this.CommandLineBox.Size = new System.Drawing.Size(648, 548);
            this.CommandLineBox.TabIndex = 3;
            this.CommandLineBox.Text = "";
            this.CommandLineBox.Click += new System.EventHandler(this.CommandLineBox_Click);
            this.CommandLineBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommandLineBox_MouseClick);
            this.CommandLineBox.TextChanged += new System.EventHandler(this.CommandLineBox_TextChanged);
            this.CommandLineBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandLineBox_KeyDown);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 32);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save File";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(112, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(94, 32);
            this.Load.TabIndex = 5;
            this.Load.Text = "Load File";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(12, 612);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(1088, 20);
            this.CommandLine.TabIndex = 6;
            this.CommandLine.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.CommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 652);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CommandLineBox);
            this.Controls.Add(this.DisplayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.RichTextBox CommandLineBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.TextBox CommandLine;
    }
}

