using System;
using System.Collections;
namespace SnakeLadderApp
{
    class SnakeLadder
    {
        /// <summary>
        /// Constance variables
        /// </summary>
        /// <param name="args"></param>

        const int INIIAL_POSITION = 0;
        const int FINAL_POSITION = 100;
        const int LADDER = 1;
        const int SNAKE = 2;
        const int NO_PLAY = 3;
        /// <summary>
        /// Static method for dieRoall and position
        /// </summary>
        
        static int diceRoll()
        {

            Random randomNumber = new Random();
            int die = randomNumber.Next(1, 7);
            return die;
        }
            static int optionCheck(int dieRoll, int position)
        {
            Random randomNumber = new Random();
            int option = randomNumber.Next(1, 4);

            switch (option)
            {
                case NO_PLAY:
                    position = position;
                    break;
                case SNAKE:
                    position -= dieRoll;
                    break;
                case LADDER:
                    int dieRoll1 = diceRoll();
                    if (position + dieRoll > 100)
                        position = position;
                    else
                        position += dieRoll;
                   
                    break;
            }
            if (position < 0)
                position = 0;
            return position;
        }

        public static void game()
        {
            int position = 0;
            int positionA = 0;
            int count = 0;
            int positionB = 0;
            
            ArrayList posA = new ArrayList();
            ArrayList posB = new ArrayList();
            
            while (position < 100)
            {
                int dieRollA = diceRoll();
                int dieRollB = diceRoll();
                positionA = optionCheck(dieRollA, positionA);
                positionB = optionCheck(dieRollB, positionB);
                posB.Add(positionB);
                posA.Add(positionA);
                if (positionA > positionB)
                    position = positionA;
                else
                    position = positionB;
                count++;
            }
            if (positionA > positionB)
                Console.WriteLine("Player A is winner");

          else
            Console.WriteLine("Player B is winner");
            Console.WriteLine("position of A: " + positionA + " position of B: " + positionB);
            Console.WriteLine("number of times each player rolled die rolled:" + count);
            //Console.WriteLine("position of A after every roll:" + posA);
            Console.Write("position of A after every roll: ");
            foreach (int i in posA)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // Console.WriteLine("position of B after every roll:" + posB);
            Console.Write("position of B after every roll: ");
            foreach (int i in posB)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulation");
            game();

        }//main method
    }//snakeladder class
}//namespace
