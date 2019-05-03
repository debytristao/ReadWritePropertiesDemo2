using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using In = NBCC_WMAD_Console.Input;
using Out = NBCC_WMAD_Console.Output;

namespace NBCC_WMAD_Console
{
    class Program
    {
        /// <summary>
        /// Menu Items are added here
        /// </summary>
        private static void LoadMenu()
        {
            Menu.menuDictionary.Add(0, "Exit");
            Menu.menuDictionary.Add(1, "About the Console");
            Menu.menuDictionary.Add(2, "Car Builder");
        }

        static void Main(string[] args)
        {
            string choice = Init();

            while (choice.ToLower() == "y")
            {
                switch (In.Get<int>(Menu.CreateMenu(), ConsoleColor.Yellow))
                {
                    case 0:
                        choice = "n";
                        break;
                    case 1:
                        AboutThisApp();
                        break;
                    //Add more options in the menu here
                    case 2:
                        CarBuilder();
                        break;
                }
            }

            Out.P("Press any key to exit.");
            Console.ReadLine();
        }

        //I want to store the cars that I've created
        static List<Car> myCars = new List<Car>();

        private static void CarBuilder()
        {
            string userCarType = In.GetString("Provice a car Type (ice Car, Truck, Van:\n");
            int userNumberOfDoors = In.GetInt("Provice the number of doors: ");
            int userCarSpeed = In.GetInt("Provide the car speed: ");
            

            Car car = new Car();

            car.CarType = userCarType;
            car.NumOffDoors = userNumberOfDoors;
            car.Speed = userCarSpeed;

            Out.P("****************************");
            Out.P($"The car created is:\nType: {car.CarType}" +
                $"\nNumber of doors: {car.NumOffDoors}" +
                $"\nSpeed: {car.Speed}" +
                $"\nPrice: {car.Price.GetValueOrDefault()}");
            Out.P("****************************");

            myCars.Add(car);
        
            //Vamos imprimir qtos carros tenho na minha colecao
            Out.P($"I have a car count in my list of: {myCars.Count}");

            string countCard = In.GetString("Do you want to list all cars? y/n:");
            if(countCard.ToLower() == "y")
            {
                foreach (Car item in myCars)
                {
                    Out.P($"Type: {item.CarType}\n Doors: {item.NumOffDoors}\n Speed: {item.Speed} km/h\n Year: {item.Yeay}\n Price: {item.Price.GetValueOrDefault().ToString("c")}");
                }
                
            }
            else
            {
                LoadMenu();
            }

        }

        #region [My Functionality]

        /*
         * My methods will be added here for executing functionality within the console
         */

        #endregion

        /// <summary>
        /// The About this App
        /// </summary>
        private static void AboutThisApp()
        {
            Out.P("\n");
            Out.P("This app is the Console Root Application. Build on it by providing new menu items and adding to the switch statement");
            Out.P("\n");
        }
        
        /// <summary>
        /// Initialize the Console
        /// </summary>
        /// <returns></returns>
        private static string Init()
        {
            LoadMenu();
            string choice = "y";
            Logo.CreateLogo("The Root App");
            return choice;
        }
    }
}
