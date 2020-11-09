using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C3549375_ASE_Assignment
{
    class Canvas
    {
        Graphics g;
        Pen Pen;
        int valX, valY;
        int penheight = 5;
        int penlength = 5;

        //This creates the main canvas that is used in the form with its functions
        public Canvas(Graphics g)
        {
            this.g = g;
            valX = valY = 0;
            Pen = new Pen(Color.Black, 2);
            g.DrawRectangle(Pen, valX, valY, penheight, penlength);
        }
        //This is the draw line function
        public void DrawTo(int toX, int toY)
        {
            g.DrawLine(Pen, valX, valY, toX, toY);
            valX = toX;
            valY = toY;
            g.DrawRectangle(Pen, valX, valY, penheight, penlength);
        }
        //This is the draws square function
        public void DrawSquare(int length)
        {
            g.DrawRectangle(Pen, valX, valY, valX+length, valY+length);
        }
        //This is the draw rectangle function
        public void DrawRectangle(int length, int width)
        {
            g.DrawRectangle(Pen, valX, valY, valX + length, valY + width);
        }
        //This is the draw trangle function
        public void DrawTriangle(int length)
        {
            this.DrawTo(valX, valY + length);
            this.DrawTo(valX + length, valY);
            this.DrawTo(valX - length, valY - length);
        }
        //This is to move the pen to a position.
        public void MoveTo(int xPosition,int yPosition)
        {
            valX = xPosition;
            valY = yPosition;
            g.DrawRectangle(Pen, valX, valY, penheight, penlength);

        }
        //This is for drawing a circle
        public void DrawCircle(int radius)
        {
            g.DrawEllipse(Pen, valX, valY, valX + (radius * 2), valY + (radius * 2));
        }
        //This is for clearing the canvas
        public void ClearArea()
        {
            g.Clear(Color.White);
            g.DrawRectangle(Pen, valX, valY, penheight, penlength);
        }
        //This is for resetting the canvas
        public void Reset()
        {
            g.Clear(Color.White);
            g.DrawRectangle(Pen, 0, 0, penheight, penlength);
        }
    }
}
