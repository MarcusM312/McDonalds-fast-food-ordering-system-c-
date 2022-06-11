/*
MARCUS MAHLATJIE & TSHIAMO MOGOAI & MPHO RAMATSUI
PROGRAMMING 182 PROJECT 2
10 JUNE 2022
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARCUS_and_TSHIAMO_MPHO_PRG182_Project2
{
    internal class Program
    {
        public static int total;
        public static ArrayList orders = new ArrayList();

        enum Menu
        {
            KIDS_MENU,
            REGULAR_MENU,
            VEGETERIAN_MENU,
            EXTRAS_MENU,
            CHECKOUT,
            Back,
            EXIT
        }
        enum KidsMeals
        {
            Happy_Meal,
            Kids_Sharebox,
            Junior_Hamburger
        }
        enum RegularMeals
        {
            Big_Mac,
            BigMac_Deluxe,
            McFeast,
            McFeast_Spicy,
            Double_Hamburger,
            McRoyal_Spicy
        }
        enum VegeterianMeals
        {
            Corn,
            Veggie_Burger,
            Green_Salad
        }
        enum ExtraItems
        {
            Oreo_McFlurry,
            Milkshake,
        }
        static void Main(string[] args)
        {
            Greeting();
            MainMenu();
            Console.ReadKey();
        }

        // WELCOME GREETING
        static void Greeting()
        {
            Console.WriteLine("Welcome to McDonalds :)");
            Console.WriteLine("***********************");
        }

        //OPENING MENU
        static void MainMenu()
        {
            Console.WriteLine("WHICH MENU WOULD YOU LIKE TO VIEW ?");
            Console.WriteLine("\n(1)"+Menu.KIDS_MENU);
            Console.WriteLine("(2)"+Menu.REGULAR_MENU);
            Console.WriteLine("(3)"+Menu.VEGETERIAN_MENU);
            Console.WriteLine("(4)"+Menu.EXTRAS_MENU);
            Console.WriteLine("(5)"+Menu.CHECKOUT);
            Console.WriteLine("(6)"+Menu.EXIT);
            Console.WriteLine("******************");
            Console.Write("Menu: ");

            int mainMenu = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Clear();

            switch (mainMenu)
            {
                case 1:
                    KidsMenu(orders);
                    break;
                case 2:
                    RegularMenu();
                    break;
                case 3:
                    VegeterianMenu();
                    break;
                case 4:
                    Extras();
                    break;
                case 5:
                    Checkout(orders);
                    break;
                case 6:
                    Exit();
                    break;
                default:
                    Console.WriteLine("You have selected an invalid option, Please select the correct option ");
                    MainMenu();

                    break;
                    

                       
                    
            }
        }

        public static void KidsMenu(ArrayList orders)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the kids menu, what would you like to order");
                Console.WriteLine("******************************************************");
                Console.WriteLine("");

                Console.WriteLine("(1)" + KidsMeals.Happy_Meal + "      R30");
                Console.WriteLine("(2)" + KidsMeals.Kids_Sharebox +"    R60");
                Console.WriteLine("(3)" + KidsMeals.Junior_Hamburger+"  R40");
                Console.WriteLine("(4)" + Menu.Back);
                Console.WriteLine("");
                Console.Write("Meal: ");

                int orderCart = int.Parse(Console.ReadLine());
                if (orderCart == 1)
                {
                    orders.Add("Happy Meal");
                    total += 30;
                }
                else if (orderCart == 2)
                {
                    orders.Add("Kids Sharebox");
                    total += 60;
                }
                else if (orderCart == 3)
                {
                    total += 40;
                    orders.Add("Junior Hamburger");
                }
                else if(orderCart == 4)
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("You have entered an INVALID option, Please select a valid option.");
                    KidsMenu(orders);

                }

                Console.Clear();

                Console.WriteLine("Would you like to order anything else ? y/n");
                string continueOrdering = Console.ReadLine();
                Console.WriteLine("");

                if (continueOrdering == "y" || continueOrdering.Equals("Yes") || continueOrdering.Equals("YES") || continueOrdering.Equals("yes") || continueOrdering.Equals("Y"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("You have ordered:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order);
                    }
                }

                Console.WriteLine("**********************");
                    MainMenu();
            }
        }

        static void RegularMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the regular menu, what would you like to order");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("");

                Console.WriteLine("(1)" + RegularMeals.Big_Mac+"         R65");
                Console.WriteLine("(2)" + RegularMeals.BigMac_Deluxe +"  R74");
                Console.WriteLine("(3)" + RegularMeals.McFeast+"         R120");
                Console.WriteLine("(4)" + RegularMeals.McFeast_Spicy+"   R150");
                Console.WriteLine("(5)" + RegularMeals.McRoyal_Spicy+"   R60");
                Console.WriteLine("(6)" + RegularMeals.Double_Hamburger+"R40");
                Console.WriteLine("(7)" + Menu.Back);
                Console.WriteLine("");
                Console.Write("Meal: ");

                int orderCart = int.Parse(Console.ReadLine());
                if (orderCart == 1)
                {
                    orders.Add("Big Mac");
                    total += 65;
                }
                else if (orderCart == 2)
                {
                    orders.Add("Bic Mac Deluxe");
                    total += 74;
                }
                else if (orderCart == 3)
                {
                    total += 120;
                    orders.Add("McFeast");
                }
                else if (orderCart == 4)
                {
                    total += 150;
                    orders.Add("McFeast Spicy");
                }
                else if (orderCart == 5)
                {
                    total += 60;
                    orders.Add("McRoyal Spicy");
                }
                else if (orderCart == 6)
                {
                    total += 40;
                    orders.Add("Double Hamburger");
                }
                else if (orderCart == 7)
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("You have entered an INVALID option, Please select a valid option.");
                    RegularMenu();

                }

                Console.Clear();

                Console.WriteLine("Would you like to order anything else ? y/n");
                string continueOrdering = Console.ReadLine();
                Console.WriteLine("");

                if (continueOrdering == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("You have ordered:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order);
                    }
                }
                Console.WriteLine("**********************");
                
                Console.WriteLine("");
                    MainMenu();
            }
        }

        static void VegeterianMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the vegeterian menu, what would you like to order");
                Console.WriteLine("************************************************************");
                Console.WriteLine("");

                Console.WriteLine("(1)" + VegeterianMeals.Corn+"            R20");
                Console.WriteLine("(2)" + VegeterianMeals.Green_Salad+"     R40");
                Console.WriteLine("(3)" + VegeterianMeals.Veggie_Burger+"   R45");
                Console.WriteLine("(4)" + Menu.Back);
                Console.WriteLine("");
                Console.Write("Meal: ");

                int orderCart = int.Parse(Console.ReadLine());
                if (orderCart == 1)
                {
                    orders.Add("Corn");
                    total += 20;
                }
                else if (orderCart == 2)
                {
                    orders.Add("Green Salad");
                    total += 40;
                }
                else if (orderCart == 3)
                {
                    total += 45;
                    orders.Add("Veggie Burger");
                }
                else if(orderCart == 4)
                {
                    MainMenu();
                }
                else
                {
                     Console.WriteLine("You have entered an INVALID option, Please select a valid option.");
                    VegeterianMenu();



                }

                Console.Clear();

                Console.WriteLine("Would you like to order anything else ? y/n");
                string continueOrdering = Console.ReadLine();
                Console.WriteLine("");

                if (continueOrdering == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("You have ordered:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order);
                    }
                }
                Console.WriteLine("**********************");
         
                Console.WriteLine("");
                 MainMenu();
            }
        }

        static void Extras()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Extra's menu, what would you like to order");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("");

                Console.WriteLine("(1)" + ExtraItems.Milkshake+"        R35");
                Console.WriteLine("(2)" + ExtraItems.Oreo_McFlurry+"    R44");
                Console.WriteLine("(3)" + Menu.Back);

                Console.WriteLine("");
                Console.Write("Meal: ");


                int orderCart = int.Parse(Console.ReadLine());
                if (orderCart == 1)
                {
                    orders.Add("Milkshake");
                    total += 35;
                }
                else if (orderCart == 2)
                {
                    orders.Add("Oreo McFlurry");
                    total += 44;
                }
                else if (orderCart == 3)
                {
                    MainMenu();
                }

                else
                {
                    Console.WriteLine("You have entered an INVALID option, Please select a valid option.");
                    Extras();

                }
                Console.Clear();


                Console.WriteLine("Would you like to order anything else ? y/n");
                string continueOrdering = Console.ReadLine();
                Console.WriteLine("");

                if (continueOrdering == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("You have ordered:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order);
                    }
                }
                Console.WriteLine("**********************");
                Console.WriteLine("");
                MainMenu();          
            }
        }

        static void Exit()
        {
            Console.WriteLine("Program will close in 3 seconds...");
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();
            Environment.Exit(0);
        }

        public static void Checkout(ArrayList orders)
        {
            Console.WriteLine("Your cart:");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
            Console.WriteLine("");
            Console.WriteLine("Your total due is: R" + total);
            Console.WriteLine("************************");
            Console.WriteLine("");

            if (total.Equals(0))
            {
                Console.WriteLine("You Have\'nt ordered anything, Please Order below :");
                MainMenu();
            }

            Console.WriteLine("Confirm checkout? y/n");
            string confirmCheckout = Console.ReadLine();

            if (confirmCheckout == "y" || confirmCheckout.Equals("Yes") || confirmCheckout.Equals("YES") || confirmCheckout.Equals("yes") || confirmCheckout.Equals("Y"))
            {
                orders.Clear();
                total = 0;
                Console.Clear();
                MainMenu();
            }
            else
            {
                MainMenu();
            }
        }


    }
}
