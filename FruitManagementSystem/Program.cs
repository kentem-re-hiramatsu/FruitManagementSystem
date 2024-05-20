using FruitManagementSystem.Controller;

namespace FruitManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fruitController = new FruitController();
            while (true)
            {
                Console.WriteLine("りんご：１");
                Console.WriteLine("みかん：2");
                Console.WriteLine("バナナ：3");
                Console.WriteLine("グレープ：4");
                Console.WriteLine("お会計：9");

                string inputFruitNum = Console.ReadLine()!;

                if (int.TryParse(inputFruitNum, out int fruitNum))
                {
                    if(fruitNum == 1 || fruitNum == 2 || fruitNum == 3 || fruitNum == 4)
                    {
                        var program = new Program();
                        var fruitCount = program.GetFruitCount();
                        fruitController.FruitListAdd(fruitNum, fruitCount);
                    }
                    else if (fruitNum == 9)
                    {
                        Console.WriteLine("合計金額は{0}", fruitController.FruitTotalAmount());
                    }
                    else
                    {
                        Console.WriteLine("正しく入力してください。");
                        continue;
                    }
                }
            }
        }
        public int GetFruitCount()
        {
            Console.WriteLine("個数を入力してください。");
            while (true)
            {
                string inputFruitCount = Console.ReadLine()!;

                if (int.TryParse(inputFruitCount, out int fruitCount))
                    return fruitCount;
                else
                    Console.WriteLine("正しく個数が入力されていません");
            }
        }
    }
}
