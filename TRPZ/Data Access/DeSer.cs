using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BusinessLogic.Implementation;
using Models;

namespace TRPZ
{
    public static class DeSer
    {
        public static void ReadFile_Client()
        {
            string[] file_client = File.ReadAllLines(@"C:\Users\Никита\source\repos\TRPZ\Client.txt", Encoding.Default);
            int i = 0;
            int number = 1;
            while (i < file_client.Length)
            {
                Storage.AddClient(file_client[i], number);
                i ++;
                number++;
            }
        }
        public static void ReadFile_Cook()
        {
            string[] file_cook = File.ReadAllLines(@"C:\Users\Никита\source\repos\TRPZ\Cook.txt", Encoding.Default);
            int i = 0;
            int number = 1;
            while (i < file_cook.Length)
            {
                Storage.AddCook(file_cook[i], file_cook[i + 1], number);
                number ++;
                i += 2;
            }
        }
        public static void ReadFile_Dish()
        {
            string[] file_dish = File.ReadAllLines(@"C:\Users\Никита\source\repos\TRPZ\Dish.txt", Encoding.Default);
            int i = 0;
            int number = 1;
            while (i < file_dish.Length)
            {
                Storage.AddDish(file_dish[i], int.Parse(file_dish[i + 1]), int.Parse(file_dish[i + 2]), number);
                number++;
                i += 3;
            }
        }
        public static void ReadFile_Order()
        {
            string[] file_order = File.ReadAllLines(@"C:\Users\Никита\source\repos\TRPZ\Order.txt", Encoding.Default);
            int i = 0;
            int number = 1;
            while (i < file_order.Length)
            {
                Storage.AddOrder(int.Parse(file_order[i]), int.Parse(file_order[i + 1]), int.Parse(file_order[i + 2]), int.Parse(file_order[i + 3]), int.Parse(file_order[i + 4]));
                number++;
                i += 4;
            }
        }
        public static void LoadData()
        {

            ReadFile_Order();
            ReadFile_Cook();
            ReadFile_Dish();
            ReadFile_Client();
        }
    }
}
