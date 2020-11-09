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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CommandLine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisplayBox.Location = new System.Drawing.Point(666, 12);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(639, 586);
            this.DisplayBox.TabIndex = 1;
            this.DisplayBox.TabStop = false;
            this.DisplayBox.Click += new System.EventHandler(this.DisplayBox_Click);
            this.DisplayBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayBox_Paint);
            // 
            // CommandLineBox
            // 
            this.CommandLineBox.Location = new System.Drawing.Point(12, 12);
            this.CommandLineBox.Name = "CommandLineBox";
            this.CommandLineBox.Size = new System.Drawing.Size(648, 586);
            this.CommandLineBox.TabIndex = 3;
            this.CommandLineBox.Text = "";
            this.CommandLineBox.Click += new System.EventHandler(this.CommandLineBox_Click);
            this.CommandLineBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommandLineBox_MouseClick);
            this.CommandLineBox.TextChanged += new System.EventHandler(this.CommandLineBox_TextChanged);
            this.CommandLineBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandLineBox_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1106, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1209, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CommandLine;
    }
}

