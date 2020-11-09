using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3549375_ASE_Assignment
{
    class Commands
    {
        int[] parameterInts;
        string[] split;
        string Cmd;
        String[] parameters;
        Canvas Canvas;
        string Command;

        public Commands(Canvas MainCanvas)
        {
            this.Canvas = MainCanvas;
            parameterInts = new int[2];
        }

        public void parseCommands(String Input)
        {
            Input = Input.ToLower().Trim();
            split = Input.Split(' ');
            Command = split[0];
            if(split.Length > 1)
            {
                parameters = split[1].Split(',');
                for (int i = 0; i <parameters.Length; i++)
                {
                    parameterInts[i] = int.Parse(parameters[i]);
                }
            }
            //These are going to be the commands that you can imput for the shapes and lines for the program.

            //First one is for a line
            if (Command.Equals("line") == true)
            {
                Canvas.DrawTo(parameterInts[0], parameterInts[1]);
            }
            //This one is for a Square
            else if (Command.Equals("square") == true)
            {
                Canvas.DrawSquare(parameterInts[0]);
            }
            //This one is for a Circle
            else if (Command.Equals("circle") == true)
            {
                Canvas.DrawCircle(parameterInts[0]);
            }
            //This one is for a Triangle
            else if (Command.Equals("triangle") == true)
            {
                Canvas.DrawTriangle(parameterInts[0]);
            }
            //This is the command for moving the pen to a different spot
            else if (Command.Equals("moveto") == true)
            {
                if (int.TryParse(parameters[0], out int x) && int.TryParse(parameters[1], out int y))
                {
                    Canvas.MoveTo(x, y);
                }
            }
            }
    }
}
