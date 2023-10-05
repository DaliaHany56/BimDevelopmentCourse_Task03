using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ConcreteElement = new List<string>();
            Console.WriteLine("Insert the concrete element you need to know its volume(you must say done after last material");
            string Answer = Console.ReadLine();
            ConcreteElement.Add(Answer);
            double TotalVolume1 = 0;
    
            while (Answer != "Done")
            {
                Console.WriteLine("Add Concrete element");
                Answer = Console.ReadLine();
                if (Answer != "Done")
                {
                    ConcreteElement.Add(Answer);
                }
            }
            foreach (string Element in ConcreteElement)
            {
                Console.WriteLine($"For each element put its Length Width Hight in order");
                Console.WriteLine("Add lenght(m)");
                double Length = double.Parse(Console.ReadLine());
                Console.WriteLine("Length(m) = " + Length);

                Console.WriteLine("Add Width(m)");
                double Width = double.Parse(Console.ReadLine());
                Console.WriteLine("Width(m) = " + Width);

                Console.WriteLine("Add Height(m)");
                double Height = double.Parse(Console.ReadLine());
                Console.WriteLine("Height(m) = " + Height);

                double Volume = Length * Width * Height;
                Console.WriteLine("Volume(m3) =" + Volume);

                TotalVolume1 += Volume; 
            }
            Console.WriteLine("TotalVolume(m3) = " + TotalVolume1);

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////");

            Console.WriteLine("enter the Number of rooms in a building");
            int NumberOfRooms = int.Parse(Console.ReadLine());

            while (NumberOfRooms <= 0)
            {
                Console.WriteLine("enter the Number of rooms in a building");
                NumberOfRooms = int.Parse(Console.ReadLine());
            }
            int numberOfBedRoom = 0;
            int numberOfLivingRoom = 0;
            int numberOfKitchen = 0;
            int numberOfBathroom = 0;
            int numberOfOffice = 0;

            Console.WriteLine("Insert Number of Bedroom,Living Room,Kitchen,Bathroom,Office,Other");

            for (int Room = 0; Room < 6; Room++)

            {
                switch (Room)
                {
                    case 1:
                        {
                            Console.WriteLine("Bedroom");
                            Console.WriteLine("Enter Number of Bedrooms");
                            numberOfBedRoom = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Living Room");
                            Console.WriteLine("Enter Number of Living Room");
                            numberOfLivingRoom = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Kitchen");
                            Console.WriteLine("Enter Number of Kitchen");
                            numberOfKitchen = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Bathroom");
                            Console.WriteLine("Enter Number of Bathroom");
                            numberOfBathroom = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Office");
                            Console.WriteLine("Enter Number of Office ");
                            numberOfOffice = int.Parse(Console.ReadLine());
                        }
                        break;
                }
            }

            Console.WriteLine("Number of Bedroom=" + numberOfBedRoom);
            Console.WriteLine("Number of Living Room=" + numberOfLivingRoom);
            Console.WriteLine("Number of Kitchen=" + numberOfKitchen);
            Console.WriteLine("Number of Bathroom=" + numberOfBathroom);
            Console.WriteLine("Number of Office=" + numberOfOffice);































        }

    }
}
