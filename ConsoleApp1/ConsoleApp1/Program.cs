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
//ハンズオン06(for文で1から100までの和)
//int n=0;
//for (int i = 0;i<=100;i++)
//{
//    n=n+i;
//}
//Console.WriteLine(n);
//ハンズオン07(浮動小数点)
//float n = 3.14159f;
//float a = 2.22222f;
//a=n - a;
//Console.WriteLine(a);
//ハンズオン08(浮動小数点型における誤差、桁落ち)
//float number = 0f;
//float number2 = 10000f;
//string a;
//number2 += 0.0001f;
//for (int i = 0;i<1000;i++)
//{
//    number += 0.001f;
//}
//Console.WriteLine(number);
//Console.WriteLine(number2);
//ハンズオン09(論理和を使ったif文)
//int n = 11;
//if(n>=0&&n<=10)
//{
//    Console.WriteLine("true");
//}else 
//{
//    Console.WriteLine("false");
//}
//ハンズオン10(フィボナッチ数列、整数型の限界値)
//long n1=1;
//long n2=1;
//long fib;
//Console.WriteLine("1");
//Console.WriteLine("1");
//for (int i=3;i<50;i++)
//{
//    fib = n1 + n2;
//    n1 = n2;
//    n2 = fib;
//    Console.WriteLine(fib);
//}
