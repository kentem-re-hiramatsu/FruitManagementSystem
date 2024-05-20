using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitManagementSystem.Enums;
using static FruitManagementSystem.Enums.FruitEnum;
using FruitManagementSystem.Model;

namespace FruitManagementSystem.Controller
{
    public class FruitController
    {
        private static FruitController _instance = null;
        List<Fruit> fruitList = new List<Fruit>();

        public static FruitController Ins
        {
            get
            {
                if (_instance == null)
                    _instance = new FruitController();

                return _instance;
            }
        }

        public void FruitListAdd(int fruitNum, int fruitCount)
        {
            var fruit = new Fruit();
            fruit._pricenum = fruitNum;
            fruit._count = fruitCount;
            fruitList.Add(fruit);
        }
    }
}
