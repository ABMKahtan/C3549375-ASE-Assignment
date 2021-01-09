using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

namespace C3549375_ASE_Assignment {
  class Commands {
    int[] parameterInts;
    string[] split;
    string[] parameters;
    Canvas Canvas;
    string Command;

    public Commands(Canvas MainCanvas) {
      this.Canvas = MainCanvas;
      parameterInts = new int[2];
    }

    public void parse2(List < String > allLines) {

      //foreach(string var_name in allLines)
      // {
      //     Debug.WriteLine("parse2: "+var_name);
      // }

      int loopStart = 0;
      int loopEnd = 0;
      int ifStart = 0;
      int ifEnd = 0;

      //define position of = variable as above array
      for (int i = 0; i < allLines.Count; i++) {
        string tempString = (string) allLines[i];

        if (tempString.Contains("loop") && !tempString.Contains("endloop")) {
          loopStart = i;
        }
        if (tempString == "endloop") {
          loopEnd = i;
        }
        if (tempString.Contains("if") && !tempString.Contains("endif")) {
          ifStart = i;
        }
        if (tempString == "endif") {
          ifEnd = i;
        }

        // if tempstring contains an '='
        // add position of variable to array

      }

      /*   example list of commands:
       *   x = 10
       *   triangle 40
            loop x
            triangle 59
            circle 50
            endloop
            rectangle 50,50
            if 5>60
            rectangle 30,90
            circle 40
            endif
         */
      if (allLines[loopStart].Contains("loop")) {
        //for loop for 'loop'
        string loopLine = (string) allLines[loopStart];
        // Debug.WriteLine(allLines[loopStart].Split(' '));
        string[] splitloop = loopLine.Split(' ');
        for (int k = 0; k < Int32.Parse(splitloop[1]); k++) {

          for (int j = loopStart + 1; j < loopEnd; j++) {
            createImages(allLines[j]);
          }
        }
      } else if (allLines[ifStart].Contains("if")) {
        if (allLines[ifStart].Contains('<')) {

          String[] splitA = allLines[ifStart].Split(' ');
          String[] parametersIf = splitA[1].Split('<');

          if (Int32.Parse(parametersIf[0]) < Int32.Parse(parametersIf[1])) {

            for (int i = ifStart + 1; i < ifEnd; i++) {

              createImages(allLines[i]);
            }
          } else {}
        } else if (allLines[ifStart].Contains('>')) {

          String[] splitA = allLines[ifStart].Split(' ');
          String[] parametersIf = splitA[1].Split('>');

          if (Int32.Parse(parametersIf[0]) > Int32.Parse(parametersIf[1])) {

            for (int i = ifStart + 1; i < ifEnd; i++) {

              createImages(allLines[i]);
            }
          } else {}
        } else if (allLines[ifStart].Contains('=')) {

          String[] splitA = allLines[ifStart].Split(' ');
          String[] parametersIf = splitA[1].Split('=');

          if (Int32.Parse(parametersIf[0]) > Int32.Parse(parametersIf[1])) {

            for (int i = ifStart + 1; i < ifEnd; i++) {

              createImages(allLines[i]);
            }
          } else {}

        }

      }

      // line will look like varname = 10
      // split after '='

      // define inProgramVariable
      // String inProgramVariable = 
      // <key, value> research maps in C#

    }

    public void createImages(String input) {

      /* Small issue if there isnt a loop the program breaks!!! figure this one out
       * 
       * making if statement work 
       * 
       * make sure its formatted properly and commented correctly
       *and make sure types are correct as well V IMPORTANT
       */

      if (input.Contains("circle") || input.Contains("triangle") || input.Contains("square")) {
        String inputType = "";
        int inputParameter = 0;

        String[] temp = input.Split(' ');
        inputType = temp[0];
        inputParameter = Int32.Parse(temp[1]);

        //This one is for a Circle (Inside the Loop)
        if (inputType == "circle") {
          Canvas.DrawCircle(inputParameter);
        }
        //This one is for a Triangle (Inside the Loop)
        else if (inputType == "triangle") {
          Canvas.DrawTriangle(inputParameter);
        }
        //This one is for a Square (Inside the Loop)
        else if (inputType == "square") {
          Canvas.DrawSquare(inputParameter);
        }
      } else if (input.Contains("moveto") || input.Contains("rectangle") || input.Contains("line")) {
        String inputType = "";
        int inputParameter1 = 0;
        int inputParameter2 = 0;

        String[] temp = input.Split(' ');
        String[] temp2 = temp[1].Split(',');
        inputType = temp[0];
        inputParameter1 = Int32.Parse(temp2[0]);
        inputParameter2 = Int32.Parse(temp2[1]);

        //First one is for a line (Inside the Loop)
        if (inputType == "line") {
          Canvas.DrawTo(inputParameter1, inputParameter2);
        }
        //This is for the rectangle (Inside the Loop)
        else if (inputType == "rectangle") {
          Canvas.DrawRectangle(inputParameter1, inputParameter2);
        }
        //This is the command for moving the pen to a different spot (Inside the Loop)
        else if (inputType == "moveto") {
          if (int.TryParse(temp2[0], out int x) && int.TryParse(temp2[1], out int y)) {
            Canvas.MoveTo(x, y);
          }
        }
      } else if (input.Contains("pen") || input.Contains("clear") || input.Contains("reset")) {
        String inputType = "";
        String penParameter = "";

        String[] step = input.Split(' ');
        inputType = step[0];
        penParameter = step[1];

        //this section is for changing the pen colours (Inside the Loop)
        if (inputType == "pen") {
          if (penParameter == "red") {
            Canvas.pColours(Color.Red);
          } else if (penParameter == "blue") {
            Canvas.pColours(Color.Blue);
          } else if (penParameter == "green") {
            Canvas.pColours(Color.Green);
          } else if (penParameter == "yellow") {
            Canvas.pColours(Color.Yellow);
          }
          //This section is for reset (Inside the Loop)
          else if (inputType == "reset") {
            Canvas.Reset();
            Canvas.MoveTo(0, 0);
          }
          //This section is for Clear Area (Inside the Loop)
          else if (inputType == "clear") {
            Canvas.ClearArea();
          }
        }
      }

    }

    public void parseCommands(String Input) {
      //this splits incoming commands and finds parameters
      Input = Input.ToLower().Trim();
      // Debug.WriteLine("input: "+ Input);
      split = Input.Split(' ');
      Command = split[0];
      if (split.Length > 1)
      //if(Input.Length > 1)
      {
        parameters = split[1].Split(',');
        if (split[0] != "pen") {
          for (int i = 0; i < parameters.Length; i++) {
            parameterInts[i] = int.Parse(parameters[i]);
          }
        }
      }

      //These are going to be the commands that you can imput for the shapes and lines for the program.
      //First one is for a line
      if (Command.Equals("line") == true) {
        Canvas.DrawTo(parameterInts[0], parameterInts[1]);
      }
      //This one is for a Square
      else if (Command.Equals("square") == true) {
        Canvas.DrawSquare(parameterInts[0]);
      }
      //This is for the rectangle
      else if (Command.Equals("rectangle") == true) {
        Canvas.DrawRectangle(parameterInts[0], parameterInts[1]);
      }
      //This one is for a Circle
      else if (Command.Equals("circle") == true) {
        Canvas.DrawCircle(parameterInts[0]);
      }
      //This one is for a Triangle
      else if (Command.Equals("triangle") == true) {
        Canvas.DrawTriangle(parameterInts[0]);
      }
      //This is the command for moving the pen to a different spot
      else if (Command.Equals("moveto") == true) {
        if (int.TryParse(parameters[0], out int x) && int.TryParse(parameters[1], out int y)) {
          Canvas.MoveTo(x, y);
        }
      }
      //This section is for reset
      else if (Command.Equals("reset") == true) {
        Canvas.Reset();
        Canvas.MoveTo(0, 0);
      }
      //This section is for Clear Area
      else if (Command.Equals("clear") == true) {
        Canvas.ClearArea();
      }
      //this section is for changing the pen colours
      else if (Command.Equals("pen") == true) {
        if (parameters[0] == "red") {
          Canvas.pColours(Color.Red);
        } else if (parameters[0] == "blue") {
          Canvas.pColours(Color.Blue);
        } else if (parameters[0] == "green") {
          Canvas.pColours(Color.Green);
        } else if (parameters[0] == "yellow") {
          Canvas.pColours(Color.Yellow);
        }
      }
    }
  }
}