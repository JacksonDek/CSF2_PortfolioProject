using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace GOTDungeon
{
    class TestHarness
    {
        static void Main(string[] args)
        {

            Console.Title = @"/\/\/\/\/\The Game of Thrones/\/\/\/\/\";
            Console.WriteLine("This game is optimized in a fullscreen Console Window");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@".___________. __    __   _______      _______      ___      .___  ___.  _______      ______    _______    .___________. __    __  .______        ______   .__   __.  _______     _______.   
|           ||  |  |  | |   ____|    /  _____|    /   \     |   \/   | |   ____|    /  __  \  |   ____|   |           ||  |  |  | |   _  \      /  __  \  |  \ |  | |   ____|   /       |   
`---|  |----`|  |__|  | |  |__      |  |  __     /  ^  \    |  \  /  | |  |__      |  |  |  | |  |__      `---|  |----`|  |__|  | |  |_)  |    |  |  |  | |   \|  | |  |__     |   (----`   
    |  |     |   __   | |   __|     |  | |_ |   /  /_\  \   |  |\/|  | |   __|     |  |  |  | |   __|         |  |     |   __   | |      /     |  |  |  | |  . `  | |   __|     \   \       
    |  |     |  |  |  | |  |____    |  |__| |  /  _____  \  |  |  |  | |  |____    |  `--'  | |  |            |  |     |  |  |  | |  |\  \----.|  `--'  | |  |\   | |  |____.----)   |      
    |__|     |__|  |__| |_______|    \______| /__/     \__\ |__|  |__| |_______|    \______/  |__|            |__|     |__|  |__| | _| `._____| \______/  |__| \__| |_______|_______/       
                                                                                                                                                                                           ");

            System.Threading.Thread.Sleep(5000);
            Console.Clear();

            Console.ResetColor();
            //TODO Create an intro statement 
            Console.WriteLine("Enter the name you'll travel the kingdom with: ");
            string name = Console.ReadLine();
            Console.WriteLine("Are you a Male or a Female? M/F");
            ConsoleKey userGender = Console.ReadKey(true).Key;
            //TODO Create the Gender stat affiliation
            switch (userGender)
            {
                case ConsoleKey.M:
                    Console.Write("Male\n");
                    break;
                case ConsoleKey.F:
                    Console.Write("Female\n");
                    break;
                default:
                    Console.WriteLine("You must be mistaken, {0} was not an option at hand.", userGender);
                    break;
            }

            Weapon dagger = new Weapon("Steel Dagger", 1, 6, false, 0);
            Weapon sword = new Weapon("Trusty Steel Sword", 2, 8, false, 1);
            Weapon swordT = new Weapon("Heavy Steel Sword", 3, 12, true, 2);
            Weapon axe = new Weapon("Steady Battle Axe", 2, 5, false, -3);
            Weapon axeT = new Weapon("Strong Axe", 4, 10, true, -4);

            Console.WriteLine("Pick a Family:\nB)aratheon\nG)reyjoy\nL)annistarm\nS)tark\nT)argaryon\nW)ildling");
            ConsoleKey playerRace = Console.ReadKey(true).Key;
            switch (playerRace)
            {
                case ConsoleKey.B:
                    Player baratheon = new Player(name, 60, 5, 40, 5, 6, 5, 6, 60, HouseRace.Baratheon, sword);
                    Console.WriteLine("You have chosen House Baratheon");
                    break;
                case ConsoleKey.G:
                    Console.WriteLine("You have chosen House Greyjoy");
                    break;
                case ConsoleKey.L:
                    Console.WriteLine("You have chosen House Lannistar");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("You have chosen House Stark");
                    break;
                case ConsoleKey.T:
                    Console.WriteLine("You have chosen House Targaryon");
                    break;
                case ConsoleKey.W:
                    Console.WriteLine("You have chosen the Wildlings");
                    break;
                default:
                    Console.WriteLine($"You must be mistaken, {playerRace} was not an option. Please try again.");
                    break;
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            //Weapon dagger = new Weapon("Steel Dagger", 1, 6, false, 0);
            //Weapon sword = new Weapon("Trusty Steel Sword", 2, 8, false, 1);
            //Weapon swordT = new Weapon("Heavy Steel Sword", 3, 12, true, 2);
            //Weapon axe = new Weapon("Steady Battle Axe", 2, 5, false, -3);
            //Weapon axeT = new Weapon("Strong Axe", 4, 10, true, -4);

            //if (playerRace == ConsoleKey.B)
            //{
            //    Player baratheon = new Player(name, 60, 5, 40, 5, 6, 5, 6, 60, HouseRace.Baratheon, sword);
            //}
            //else if (playerRace == ConsoleKey.G)
            //{
            //    Player greyJoy = new Player(name, 45, 3, 45, 7, 5, 2, 6, 45, HouseRace.Greyjoy, axe);
            //}
            //else if (playerRace == ConsoleKey.L)
            //{
            //    Player lannistar = new Player(name, 55, 6, 50, 1, 7, 6, 6, 55, HouseRace.Lannistar, swordT);
            //}
            Player player = new Player(name, 60, 5, 40, 5, 6, 3, 8, 40, HouseRace.Targaryeon, sword);

            //Player[] players = { };
            //TODO Create a "King"
            //TODO Create a Weapon
            /*
             * Weapon List:
             
             * - Two Handed Sword
             * - Dagger
             * - One Handed Sword
             * - Axe Two Handed
             * - Axe One Handed 
             * - Rock (Literal Rock)
             * - Wooden Club
             * - Valyrian Steel Sword
             * - Valerian Steel Dagger
             */


            int foesDefeated = 0;

            bool exit = false;
            do
            {
                //TODO Create a Menu for Places to go 
                //TODO Create an experience System
                //TODO Create Special Foe
                Foe undeadSolider = new Foe("Undead Solider", 30, 5, 8, 0, 2, 0, 8, 3, 4, 1,
                    "This undead solider appears weak, but looks as if it is completely content with the future outcome of this fight.");
                Foe whiteWalker = new Foe("White Walker", 40, 7, 20, 0, 4, 0, 20, 8, 10, 1,
                    "The White Walker looks at you with a clear desire to kill. It stares at you with the desire to add you to its collection of soliders.");
                Foe theMountain = new Foe("The Mountain", 20, 10, 60, 3, 2, 0, 60, 5, 15, 1,
                    "Sir Gregor Clegaine. The most renowned solider in the Lannistar army, known for his sheer strength and size. Known as the mountain, this man is clearly someone to be feared all throughout the kingdom.");
                Foe dothraki = new Foe("Dothraki Blood Rider", 35, 10, 13, 0, 6, 0, 13, 8, 6, 1,
                    "This is a solider in the Dothraki Hoard. He screams on the back of his horse, ready to ride you down and take you as his prize.");
                Foe wildlingM = new Foe("Wildling", 35, 10, 17, 0, 3, 0, 17, 5, 8, 1,
                    "From beyond the Wall appears this crazy man. He looks to be just like you except, he has grown up in a world completely different from you. He readys his weapon and prepares to take your head.");
                Foe wildlingF = new Foe("Wildling Woman", 45, 10, 13, 0, 3, 0, 13, 5, 6, 1,
                    "From beyond the Wall appears this crazy woman. Do not be mistaken by her beauty, she is not as fragile as she may look. This woman is more terrifying than any southern one you may have encounter.");
                Foe[] foes = { undeadSolider, theMountain, whiteWalker, dothraki, wildlingM, wildlingF, undeadSolider, undeadSolider, undeadSolider, undeadSolider, whiteWalker, whiteWalker, wildlingF, wildlingM, wildlingM, dothraki, dothraki, dothraki };
                Console.WriteLine("You have enter a room");
                //TODO Make a room description

                bool reloadRoom = false;
                bool exitCastle = false;
                #region Combat Feature
                do
                {
                    //TODO Display a Room 
                    //TODO Make a Room Description
                    Foe foe = foes[new Random().Next(foes.Length)];
                    Console.WriteLine("\nChoose an action:\n" +
                        "A)ttack\n" +
                        "N)egotiate\n" +
                        "R)etreat from Battle\n" +
                        "K)ing Stats\n" +
                        "E)nemy Stats\n" +
                        "(Esc to exit the game)\n");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack!");
                            //TODO Create Combat Function
                            break;
                        case ConsoleKey.N:
                            Console.WriteLine("You will Negotiate");
                            //TODO Create Negotiation Function
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("RETREAT!!!");
                            //TODO Create Retreat Function
                            break;
                        case ConsoleKey.K:
                            Console.WriteLine(player + "\nFoes Defeated: " + foesDefeated);
                            break;
                        case ConsoleKey.E:
                            Console.WriteLine(foe);
                            break;
                        case ConsoleKey.Escape:
                            Console.WriteLine("You truly have given up on your family and your kingdom");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("You must be mistaken, {0} was not an option at hand.", userChoice);
                            break;
                    }
                    //TODO Create Death Feature

                } while (!reloadRoom && !exit);
                #endregion

                #region Peaceful Interaction Feature
                do
                {
                    //TODO Display Room
                    //TODO Create "Vendor"/ "Friend"
                    Console.WriteLine("You have enter a room");
                    //TODO Create Room Description

                    Console.WriteLine("Welcome weary traveler. Please let me know, Which House do you Fight for:\n" +
                        "S)tark\n" +
                        "L)annister\n" +
                        "B)aratheon\n" +
                        "T)argaryen\n" +
                        "W)ildlings\n" +
                        "G)reyjoy\n" +
                        "(Esc to exit)");

                    ConsoleKey peacefulOption = Console.ReadKey(true).Key;
                    switch (peacefulOption)
                    {
                        case ConsoleKey.S:
                            Console.WriteLine("House Stark");
                            //TODO Add Stark Interaction
                            break;

                        case ConsoleKey.L:
                            Console.WriteLine("House Lannister");
                            //TODO Add Lannister Interaction
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("House Baratheon");
                            //TODO Add Baratheon Interaction
                            break;

                        case ConsoleKey.T:
                            Console.WriteLine("House Targaryen");
                            //TODO Add Targaryen Interaction
                            break;

                        case ConsoleKey.W:
                            Console.WriteLine("You're a Wildling");
                            //TODO Add Wildling Interaction
                            break;

                        case ConsoleKey.G:
                            Console.WriteLine("You're a Greyjoy");
                            //TODO Add Greyjoy Interaction
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("You have made a grave mistake.");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("You must be mistaken, {0} was not an option at hand.", peacefulOption);
                            break;

                    }

                } while (!exitCastle && !exit);
                #endregion

            } while (!exit);



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You life has been lost on the field of battle");
        }

    }//end Class
    
}//end Namespace
