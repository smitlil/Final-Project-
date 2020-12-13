using System;

namespace Final_Project_
{
   class Program
    {
         // Retuen type void means nothing 
        // Take 3 variable as parameters one int and 2 string 
        // Mathod Will show Title , Player name and Who's turn 
        static void Show(int PlayerNumber,string PlayerName_1, string PlayerName_2)
        {
            Console.Write("T I C  T A C  T O E");

            Console.WriteLine();

            Console.WriteLine("Final Project");
            Console.WriteLine();

            Console.WriteLine("Player 1 :-> {0} : X",PlayerName_1);
            Console.WriteLine("Player 2 :-> {0} : O",PlayerName_2);
            Console.WriteLine();

            if(PlayerNumber == 1)
                Console.WriteLine("Player {0}  \n {1} your turn, select 1 to 9.",PlayerNumber,PlayerName_1);
            else
                Console.WriteLine("Player {0} \n  {1} your turn, select 1 to 9.",PlayerNumber,PlayerName_2);

            Console.WriteLine();
        }
        
        // Retuen type char  
        // Take 1 variable as parameter one int 
        // Mathod Will return the symbol X or O 
         private static char Pos_player(int player)
        {
            if (player % 2 == 0)
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        // Retuen type int  
        // Take 1 variable as parameter one int 
        // Mathod Will used to check which player's turn 
        static int NextTurn(int player)
        {
            if (player == 2)
            {
                return 1;
            }

            return 2;
        }

        // Retuen type void means nothing   
        // Take 2 parameters one int and 1 char type array
        // Mathod Will take input from the user and check its valid or not.
        private static void LoadFun(char[] GameNum, int CurPlayer)
        {
            bool ChkVal = true;
            char Cur_Place;

            do
            {
                Console.WriteLine("Please Enter Your Choice :->");
                string userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) &&
                    (userInput =="1"||userInput =="2" ||userInput =="3" ||
                    userInput =="4" ||userInput =="5" ||userInput =="6" ||
                    userInput =="7" ||userInput =="8" ||userInput =="9" ))
                {

                    int.TryParse(userInput, out var G_Place_Pos);

                    Cur_Place = GameNum[G_Place_Pos - 1];

                    if (Cur_Place =='X' || Cur_Place =='O')
                    {
                        Console.WriteLine("Already taken select another number .");
                                                
                    }
                    else
                    {
                        GameNum[G_Place_Pos - 1] = Pos_player(CurPlayer);

                        ChkVal = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (ChkVal);
        }

        // Retuen type bool (True Or False )
        // Take 1 parameter as char type array 
        // Mathod will just return True Or Flase 
        private static bool Draw_Game(char[] GameNum)
        {
            return GameNum[0] != '1' &&GameNum[1] != '2' &&GameNum[2] != '3' &&
                   GameNum[3] != '4' &&GameNum[4] != '5' &&GameNum[5] != '6' &&
                   GameNum[6] != '7' &&GameNum[7] != '8' &&GameNum[8] != '9';
        }

        // Retuen type void means nothing  
        // Take 1 parameter as char type array
        // Mathod Will show  the Tic Tac Toi main bord 
        static void Show_bord(char[] GameNum)
        {

         Console.WriteLine();

            Console.Write("{0,30:###}",GameNum[0]);
            Console.Write("\t   | ");
            Console.Write("{0,6:###}",GameNum[1]);
            Console.Write("\t| ");
            Console.WriteLine("{0,6:###}",GameNum[2]);

            Console.WriteLine("\t\t\t  ---------------------------------");

            Console.Write("{0,30:###}",GameNum[3]);
            Console.Write("\t   | ");
            Console.Write("{0,6:###}",GameNum[4]);
            Console.Write("\t| ");
            Console.WriteLine("{0,6:###}",GameNum[5]);

            Console.WriteLine("\t\t\t  ---------------------------------");

            Console.Write("{0,30:###}",GameNum[6]);
            Console.Write("\t   | ");
            Console.Write("{0,6:###}",GameNum[7]);
            Console.Write("\t| ");
            Console.Write("{0,6:###}",GameNum[8]);

            Console.WriteLine();

        }

        // Retuen type bool (True Or False )
        // Take 4 parameters char type array and 3 int type variables.  
        // Mathod will just return True Or Flase 
         private static bool ChkSame(char[] Game_Sym, int pos1, int pos2, int pos3)
        {
            return Game_Sym[pos1] == (Game_Sym[pos2]) && Game_Sym[pos2] == (Game_Sym[pos3]);
        }

        // Retuen type bool (True Or False )
        // Take 1 parameter as char type array 
        // Mathod will check the winning  possibilities and retrun True Or False
        private static bool WinFun(char[] GameNum)
        {
            if (ChkSame(GameNum, 0, 1, 2) || ChkSame(GameNum, 3, 4, 5) || ChkSame(GameNum, 6, 7, 8) ||
                ChkSame(GameNum, 0, 3, 6) || ChkSame(GameNum, 1, 4, 7) || ChkSame(GameNum, 2, 5, 8) ||
                ChkSame(GameNum, 0, 4, 8) || ChkSame(GameNum, 2, 4, 6))  
            {
                return true;
            }
            else
            {
            return false;
            }
        }
        
        // Retuen type int   
        // Take 1 parameters as char type array
        // Mathod Will check game is draw or who is winner
        private static int Chkwin(char[] GameNum)
        {
            
            if (Draw_Game(GameNum))
                return 2;
            
            if (WinFun(GameNum))
                return 1;

            return 0;
        }
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            int gameStatus = 0,CurPlayer = -1;  // Variable Chk Win or Show_bord & Variable Chk Who's Turn 
            char[] GameNum = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Char type array For traking 
            string PlayerName_1= "",PlayerName_2= ""; // Variables For 2 Palyers Name

            Console.Write("Please Enter first Player Name :->");
            PlayerName_1 = Console.ReadLine().Trim();

            Console.Write("Please Enter Second Player Name :->");
            PlayerName_2 = Console.ReadLine().Trim();
            Console.WriteLine();

            do
            {
                CurPlayer = NextTurn(CurPlayer); // Function Calling part "CurPlayer Variable pass as argument".

                Show(CurPlayer,PlayerName_1,PlayerName_2); // Function Calling part "CurPlayer and 2 palyer name variables send asargument".
                Show_bord(GameNum); // Function Calling part  "Array send as argument".

                LoadFun(GameNum, CurPlayer); // Function Calling part "pass Char array and Curplayer Variable". 

                gameStatus = Chkwin(GameNum); // Function Calling part and store value in variable

            } while (gameStatus == 0); // loop will run till it's 1

            // Both will show final Process and player name

            Show(CurPlayer,PlayerName_1,PlayerName_2); // Function Calling part "CurPlayer and 2 palyer name variables send asargument".
            Show_bord(GameNum); // Function Calling part  "Array send as argument".

            // Nested If consdition to show player names 
            if (gameStatus == 1)
            {
                if(CurPlayer == 1 )
                {
                    Console.WriteLine("\n {0} Better luck Next time Sorry !",PlayerName_2);
                    Console.WriteLine("\n Player {0} :-> {1}is the winner!",CurPlayer,PlayerName_1);
                }
                else
                {
                    Console.WriteLine("\n {0} Better luck Next time Sorry !",PlayerName_1);
                    Console.WriteLine("\n Player {0} {1} is the winner!",CurPlayer,PlayerName_2);
                }
            }
            else if (gameStatus == 2)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Game Draw !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }
    }
}
