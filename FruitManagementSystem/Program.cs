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
                    if(fruitNum >= 1 && fruitNum <= 4)
                    {
                        string messageCount = "個数を入力してください。";
                        string errorMessage = "正しく個数が入力されていません";

                        var fruitCount = fruitController.GetFruitCount(messageCount, errorMessage);
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

    }
}
