using FruitManagementSystem.Model;
using static FruitManagementSystem.Enums.FruitNameEnum;
using static FruitManagementSystem.Enums.FruitPriceEnum;

namespace FruitManagementSystem.Controller
{
    public class FruitController
    {
        List<Fruit> fruitList = new List<Fruit>();

        public void FruitListAdd(int fruitNum, int fruitCount)
        {
            var fruit = new Fruit();
            FruitName fruitname = (FruitName) fruitNum;
            fruit._name = fruitname;
            fruit._count = fruitCount;
            fruitList.Add(fruit);
        }

        public FruitPrice GetFruitPrice(FruitName fruitName)
        {
            switch (fruitName)
            {
                case FruitName.りんご:
                    return FruitPrice.りんご;
                case FruitName.みかん:
                    return FruitPrice.みかん;
                case FruitName.バナナ:
                    return FruitPrice.バナナ;
                case FruitName.グレープ:
                    return FruitPrice.グレープ;
                default:
                    return 0;
            }
        }

        public int FruitTotalAmount()
        {
            var fruitTotalAmount = 0;
            foreach (var item in fruitList)
            {
                var fruitPrice = GetFruitPrice(item._name);
                fruitTotalAmount += (int)fruitPrice * item._count;
            }
            return fruitTotalAmount;
        }

        public int GetFruitCount(string messageCount, string errorMessage)
        {
            Console.WriteLine(messageCount);
            while (true)
            {
                string inputFruitCount = Console.ReadLine()!;

                if (int.TryParse(inputFruitCount, out int fruitCount))
                    return fruitCount;
                else
                    Console.WriteLine(errorMessage);
            }
        }
    }
}
