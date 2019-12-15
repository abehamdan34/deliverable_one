using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of vacation are you looking to go on, musical, tropical, or adventurous?");
            string vacationType = Console.ReadLine();
            Console.WriteLine("How many are in your group?");
            int groupSize = int.Parse(Console.ReadLine());
            string result = "";
            if (groupSize == 1 || groupSize == 2)
            {
                if (vacationType == "musical")
                {
                    result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a First Class flight to New Orleans.";
                }
                if (vacationType == "tropical")
                {
                    result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a First Class flight to a beach vacation in Mexico.";
                }
                if (vacationType == "adventurous")
                {
                    result = "Since you're a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a First Class flight to whitewater rafting in the Grand Canyon.";
                }
            }
            else if (groupSize >= 3 && groupSize <= 5)
            {
                if (vacationType == "musical")
                {
                    result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a Helicopter to New Orleans.";
                }
                if (vacationType == "tropical")
                {
                    result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a Helicopter to a beach vacation in Mexico.";
                }
                if (vacationType == "adventurous")
                {
                    result = "Since you're a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a Helicopter to whitewater rafting in the Grand Canyon.";
                }
            }
            else
            {
                if (vacationType == "musical")
                {
                    result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight to New Orleans.";
                }
                if (vacationType == "tropical")
                {
                    result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight to a beach vacation in Mexico.";
                }
                if (vacationType == "adventurous")
                {
                    result = "Since you're a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a charter flight to whitewater rafting in the Grand Canyon.";
                }
            }


            Console.WriteLine(result);
        }




    
    }
}
