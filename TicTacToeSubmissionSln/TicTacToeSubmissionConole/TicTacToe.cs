using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }


        public void Run()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 16);

            Console.Write("Fred x ");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

            /////////////////////////////////////////////////////////////////////////////

            Console.SetCursorPosition(35, 16);

            Console.Write("Bob o");

            Console.SetCursorPosition(35, 20);

            Console.Write("Please Enter Row: ");
            row = Console.ReadLine();

            Console.SetCursorPosition(35, 20);


            Console.Write("Please Enter Column: ");
            column = Console.ReadLine();



            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

        }
        

        //


        // static char[] arr = {'0','1','2','3','4','5','6','7','8','9' };




    }

   
}  
