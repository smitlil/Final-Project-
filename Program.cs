using System;

namespace Final_Project_
{
     struct S_P_C
    {
         public int i;

         public bool chkAgain;

         public string UserChoice;

    }
   class Program
    {
     
      // return type void means nothing 
        // 1 parameter as string UseName
        // this method is main part of this game like hart in body. 
        static void mainGame(string UserName)
        {
            S_P_C ss; // make structure object
            
            int j, x;
            Random ran = new Random(); // make rnadme class object
            string r = "";

            Console.WriteLine(" 1 -> Stone ");
            Console.WriteLine(" 2 -> Paper ");
            Console.WriteLine(" 3 -> scissors ");
            Console.WriteLine();

            Console.WriteLine(" You need to selct any one from 1 to 3 \n\n \t you have 5 second for think ");
            Console.WriteLine("\n Press any key to start game .......");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine(" 1 -> Stone ");
            Console.WriteLine(" 2 -> Paper ");
            Console.WriteLine(" 3 -> scissors ");
            Console.WriteLine();

            for(j=1; j<=5; j++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write("\t {0}...........\n",j);
            }

            Console.WriteLine();
            Console.Write("\n please enter your choice {0} from 1 - 3:->",UserName);
            ss.i = Convert.ToInt32(Console.ReadLine());

            if (ss.i == 1 || ss.i == 2 || ss.i == 3)
            {
                    r = string.Concat(r,ran.Next(1,4).ToString()); // give number form 1-3 and store in r 

                    Console.WriteLine("\n Now Computer's Turn to select ");

                    System.Threading.Thread.Sleep(2000);

                    Console.WriteLine("\n Computer's choice is :-> {0} ",r);

                    x=Convert.ToInt32(r.ToString()); // conversion

                    if(x == ss.i)
                    {
                        Console.WriteLine("\n {0}'s option :-> {1}",UserName,ss.i);
                        Console.WriteLine("\n Computer option :-> {0}",x);
                        Console.WriteLine();
                        Console.WriteLine("\n Draw game");
                    }
                    else if((ss.i == 1 && x ==2) || (ss.i ==2 && x == 1))
                    {
                        Console.WriteLine("\n {0}'s option :-> {1}",UserName,ss.i);
                        Console.WriteLine("\n Computer option :-> {0}",x);
                        Console.WriteLine();
                        Console.WriteLine("\n Paper win");
                    }
                    else if((ss.i == 1 && x == 3) || (ss.i ==3 && x == 1))
                    {
                        Console.WriteLine("\n {0}'s option :-> {1}",UserName,ss.i);
                        Console.WriteLine("\n Computer option :-> {0}",x);
                        Console.WriteLine();
                        Console.WriteLine("Stone Win");
                    }
                    else 
                    {
                        Console.WriteLine("\n {0}'s option :-> {1}",UserName,ss.i);
                        Console.WriteLine("\n Computer option :-> {0}",x);
                        Console.WriteLine();
                        Console.WriteLine("\n scissors  Win");
                    }
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\n Invalid Input");
            }
        }

        // return type void means nothing 
        // noa rgument as parameter 
        // this method will take inital information and call seccond method 
        static void fun()
        {
            String ch; // to store user choice 
            bool chk; // for check it's Yes or No 
            string UseName; // Use to store Player name.

            Console.Write("For play Stone Paper scissors Select [Y] :->");
            ch = Console.ReadLine().Trim();
            
            chk=(ch.ToUpper() == "Y");
            if(chk)
            {
                Console.Write("\n Please enter your name :->");
                UseName=Console.ReadLine();
                mainGame(UseName); //calling part send name as parameter 
            }
            else
            {
                Console.WriteLine("\n Bye ahve a good day :)");
            }
        }
       
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

             S_P_C s1; // make sturcture object 
            do
            {
            fun(); // method calling

            Console.WriteLine(" Wanna play again [Y/N]:-> ");
            s1.UserChoice = Console.ReadLine().Trim();

            s1.chkAgain=(s1.UserChoice.ToUpper() == "Y"); // check user condition 

            }while(s1.chkAgain); // loop will work till user put Y 
        }
    }
}
