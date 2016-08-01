using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {

        ///----Calling Classes
        
        static void Main(string[] args)
        {
            AppasActions AppasMove = new AppasActions();
            Console.WriteLine("********** Appa + Aang ********");// Main menu for Loop
            List<string> menu = new List<string>();
            menu.Add("\n1. Feed");//Hunger
            menu.Add("2. Fight");//STRENGTH
            menu.Add("3. Fly");//Happiness
            menu.Add("4. Drink");//Thirst
            menu.Add("5. Exit");

            bool looptyLoop = true;

            while (looptyLoop)
            {
                mainMenu(menu);
                Console.Write("\nAang, what would you like to do with Appa?\nPlease select from the numbers above: ");
                int numberSelection = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (numberSelection)
                {
                    case 1:// Feed
                        Console.WriteLine("Feed");
                        Console.WriteLine("Aang, would you like to feed to Appa? YES or NO");
                        string answerEat = Console.ReadLine().ToUpper();
                        if (answerEat == "YES")
                        {
                            AppasMove.Eat();//Eat
                            Console.WriteLine("Appa: Blllwaaaahh ....Burp");
                            Console.WriteLine("Aang: Jeez Appa, I think you need to lay off on the cabbage, you seem gasier more then usual.");
                            Console.WriteLine("");
                            Console.WriteLine("Please select the Enter Key");
                            //Console.WriteLine("");
                            AppasMove.StatLevels();
                            Console.ReadKey();
                        }
                        else if (answerEat == "NO")
                        {
                            AppasMove.DontEat();//Does not eat

                            Console.WriteLine("\nAppa: Awwwwwrrgghhhhhhhhhhhhhhh \nAang: I hope you don't try to eat MoMo again.");
                            AppasMove.StatLevels();
                            Console.ReadKey();
                        }
                        break;

                    case 2: //Fight
                        Console.WriteLine("Fight");
                        Console.WriteLine("Aang, would you like to train Appa to fight? YES or NO");
                        string answerFight = Console.ReadLine().ToUpper();
                        if (answerFight == "YES")
                        {
                            AppasMove.Fight(); // Does not fight
                            Console.WriteLine("\nAanng: Appa attack!!!\nAppa: GRRAAAgghhhh!!!\n");
                            AppasMove.StatLevels();
                            Console.ReadKey();

                        }
                        else if (answerFight == "NO")
                        {
                            AppasMove.DontFight();
                            Console.WriteLine("\nAang: Appa Hault!!\n");
                            AppasMove.StatLevels();
                            Console.ReadKey();
                        }

                        break;
                    case 3: //Fly
                        Console.WriteLine("Fly");
                        Console.WriteLine("Aang, would you like for Appa to fly? YES or NO");
                        string answerFly = Console.ReadLine().ToUpper();
                        if (answerFly == "YES")
                        {
                            AppasMove.Fly();
                            Console.WriteLine("\nAang: Yip-Yip!!! Appa lets go.\n");
                            Console.ReadKey();
                        }
                        else if(answerFly == "NO")
                        {
                            AppasMove.DontFly();//Does not fly
                            Console.WriteLine("\nAang: Appa STAY!\n");
                            AppasMove.StatLevels();
                            Console.ReadKey();
                        }
                        break;
                    case 4: //Drink
                        Console.WriteLine("Drink");
                        Console.WriteLine("Aang, Would you like to give Appa water? YES or NO");
                        string answerDrink = Console.ReadLine().ToUpper();
                        if (answerDrink == "YES")
                        {
                            AppasMove.Drink();
                            Console.WriteLine("\nAppa: Gulp, Gulp, Gulp...Burrrppp");
                            AppasMove.StatLevels();
                            Console.ReadKey();
                        }
                        else if (answerDrink == "NO")
                        {
                            AppasMove.DontDrink(); //Does not eat
                            Console.WriteLine("\nAang: Appa don't drink. Appa: ........sigh\n");
                            AppasMove.StatLevels();
                            Console.ReadKey();
                        }
                        break;
                    case 5://Exit Application
                        Console.WriteLine("Exit");
                        Console.WriteLine("Appa: GWaahaaaaa");
                        Console.WriteLine("Aang: See you later Appa!");
                        Console.ReadKey();
                        looptyLoop = false;
                        break;

                }
               
            }

        }


        
        static void mainMenu(List <string> menu) //Method for main menu
        {
           foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
        }

        

    }
}
