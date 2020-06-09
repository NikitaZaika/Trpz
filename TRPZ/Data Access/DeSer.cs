using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TRPZ
{
    class DeSer
    {
        private void ReadFile_Dish()
        {
            string[] file_dish = File.ReadAllLines(@"C:\Users\Никита\source\repos\TRPZ\Dish.txt", Encoding.Default);
            int i = 0;
            while(i < file_dish.Length)
            {

                InfoOffice.Restaurants[0].AddDish(file_dish[i], int.Parse(file_dish[i+1]), int.Parse(file_dish[i + 2]), file_dish[i + 3]);
                i += 4;
            }
        }
        private void ReadFile_Cook()
        {
            string[] file_cook = File.ReadAllLines(@"C:\Users\Никита\source\repos\TRPZ\Cook.txt", Encoding.Default);
            int i = 0;
            while (i < file_cook.Length)
            {


                InfoOffice.Restaurants[0].AddCook(file_cook[i], int.Parse(file_cook[i + 1]));
                i += 4;
            }
        }
    }
}
