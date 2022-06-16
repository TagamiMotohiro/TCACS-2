// See https://aka.ms/new-console-template for more information


//ハンズオン02(偶数奇数判定)
//int n = 2;
//if (n % 2 == 1)
//{
//    Console.WriteLine("奇数");
//}
//else
//{
//    Console.WriteLine("偶数");
//}
//ハンズオン03(文字当て)
//string Answer = "z";
//string userAnswer;
//while (true)
//{
//    Console.WriteLine("入力");
//    userAnswer = Console.ReadLine() ?? "";
//    if (userAnswer == Answer)
//    {
//        Console.WriteLine("正解");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("不正解");
//    }
//}
//ハンズオン04(1～100の数字)
//int n = 1;
//int sum = 0;
//while (n <= 100)
//{
//    sum += n;
//    n++;
//}
//Console.WriteLine(sum);
//ハンズオン05
//string userAnswer;
//string answer = "z";
//bool count = true;
//do
//{
//    if(count==false)
//    {
//        Console.WriteLine("不正解");
//    }
//    Console.WriteLine("1文字入力");
//    userAnswer=Console.ReadLine()?? "";
//    if(count==true)
//    {
//        count = false;
//        continue;
//    }
//}
//while(userAnswer!=answer);
//Console.WriteLine("正解");
//ハンズオン06(for分1+2+3+…+100)
int n=0;
for (int i = 0;i<=100;i++)
{
    n=n+i;
}
Console.WriteLine(n);
