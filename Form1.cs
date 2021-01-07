using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace C3549375_ASE_Assignment
{
    public partial class Form : System.Windows.Forms.Form
    {
        //This creates the main canvas
        Bitmap OutputBitmap = new Bitmap(600,600);
        Canvas MainCanvas;
        Commands C;
        public Form()
        {
            InitializeComponent();
            MainCanvas = new Canvas(Graphics.FromImage(OutputBitmap));
            C = new Commands(MainCanvas);
        }


        private void DisplayBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is for saving the text to a file
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(CommandLineBox.Text);
                write.Dispose();
            }
        }

        private void CommandLineBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CommandLine_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void DisplayBox_Click(object sender, EventArgs e)
        {

        }

        private void CommandLineBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CommandLineBox_Click(object sender, EventArgs e)
        {

        }

        private void CommandLineBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this reads inputed commands and executes them
                String Input = CommandLine.Text;
                C.parseCommands(Input);
                CommandLine.Text = "";
                Refresh();

                if (Input.Equals("run") == true)
                {
                    using (StringReader reader = new StringReader(CommandLineBox.Text))
                    {
                        String rtLines;

                        List<String> allLines = new List<String>();
                        
                        while ((rtLines = reader.ReadLine()) != null)
                        {
 
                           allLines.Add(rtLines);
                            
                           // C.parseCommands(rtLines);
                        }
                        C.parse2(allLines);

                    }

                }
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            //this is for loading a saved file
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                CommandLineBox.Text = read.ReadToEnd();
                read.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}