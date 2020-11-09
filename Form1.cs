using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3549375_ASE_Assignment
{
    public partial class Form1 : Form
    {
        Bitmap OutputBitmap = new Bitmap(600,600);
        Canvas MainCanvas;
        Commands C;
        public Form1()
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
                String Input = CommandLine.Text;
                C.parseCommands(Input);
                CommandLine.Text = "";
                Refresh();
            }
        }
    }
}