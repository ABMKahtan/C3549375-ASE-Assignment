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
        //SORT OUT SIZING
        Bitmap OutputBitmap = new Bitmap(,);
        Canvass MyCanvass;
        public Form1()
        {
            InitializeComponent();
            MyCanvass = new Canvass(Graphics.FromImage(OutputBitmap));
        }

        private void CommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //HERE IS WHERE TO SPLIT THE INPUTED TEXT ON FROM THE TEXT BOX.
                String Command = CommandLine.Text.Trim().ToLower();
                if (Command.Equals("line") == True)
                {
                    MyCanvass.DrawLine(160, 120);
                }
                else if (Command.Equals("square") == true)
                {
                    MyCanvass.DrawSquare(25);
                    Console.WriteLine("Line");
                }
                CommandLine.Text = "";
                Refresh();
            }
        }

        private void DisplayBox_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CommandLine_TextChanged(object sender, EventArgs e)
        {

        }
    }

