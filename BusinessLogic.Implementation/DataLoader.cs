using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Implementation
{
    public class DataLoader
    {
        public void LoadData()
        { 
            Storage.AddClient("Игорб",1);
            Storage.AddClient("Вася", 2);
            Storage.AddClient("Петя", 3);
            Storage.AddCook("Миша", "шеф",1);
            Storage.AddCook("Влад", "су-шеф",2);
            Storage.AddDish("макарохи", 20, 30, 1);
            Storage.AddDish("Пюреха", 45, 50, 2);
            Storage.AddDish("Каклеты", 52, 100, 3);
            Storage.AddOrder(1, 1, 1, 30,1);
        }
            
    }
}
