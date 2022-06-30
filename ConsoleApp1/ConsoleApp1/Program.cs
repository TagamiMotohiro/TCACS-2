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
//ハンズオン11(BMI計算アプリケーション)体重(kg)÷身長(m)2乗
//ハンズオン12(BMI計算アプリケーション改良)型キャスト;
//ハンズオン13(BMI計算アプリケーションエラーハンドリング）try-catch文
//string userweight;
//float weight;
//string userheight;
//float height;
//float BMI;
//do
//{
//    Console.WriteLine("身長(m)を入力");
//    userheight = Console.ReadLine() ?? "";
//    try
//    {
//        height = float.Parse(userheight);
//    }
//    catch
//    {
//        userheight = null;
//        Console.WriteLine("数値を入力してください");
//    }
//} while (userheight == null);
//height = float.Parse(userheight);
//Console.WriteLine("身長=" + height.ToString() + "m");
//do
//{
//    Console.WriteLine("体重(kg)を入力");
//    userweight = Console.ReadLine() ?? "";
//    try
//    {
//        weight = float.Parse(userweight);
//    }
//    catch
//    {
//        userweight = null;
//        Console.WriteLine("数値を入力してください");
//    }
//} while (userweight == null);
//weight = float.Parse(userweight);
//Console.WriteLine("体重=" + weight.ToString() + "kg");
//BMI = weight / (height * height);
//Console.WriteLine("BMI=" + BMI.ToString("F2"));

//ハンズオン14(BMI計算アプリケーション　TryParce)
//string userweight;
//string userheight;
//bool parseSuccess=false;
//float height = 0;
//while (!parseSuccess)
//{
//    Console.WriteLine("身長を入力");
//    userheight =Console.ReadLine()??"";
//    parseSuccess=float.TryParse(userheight,out height);
//    if(!parseSuccess)
//    {
//        Console.WriteLine("数値を入力してください");
//    }    
//}
//parseSuccess=false;
//float weight = 0;
//while(!parseSuccess)
//{
//    Console.WriteLine("体重を入力");
//    userweight =Console.ReadLine()??"";
//    parseSuccess =float.TryParse(userweight,out weight);
//    if (!parseSuccess)
//    {
//      Console.WriteLine("数値を入力してください");
//    }
//}
//float BMI = weight / (height * height);
//Console.WriteLine("BMI=" + BMI.ToString("F2"));

//ハンズオン15(配列とfor文)
//int[] index=new int[] {55,68,78,56,15,35,99,44,56,34,21,64,95,71};
//int min=0;
//int max=0;
//float ave=0;
//int sum = 0;
//int centernum=0;
//int center = 0;
//Array.Sort(index);
//for (int i=0; i < index.Length; i++)
//{
//    Console.WriteLine(index[i]);
//    if(index[i]>=max)
//    {
//        max=index[i];
//    }
//    sum+=index[i];
//}
//ave=(float)sum/(float)index.Length;
//min=max;
//for (int i = 0; i < index.Length; i++)
//{
//    if (index[i] <= min)
//    {
//        min = index[i];
//    }
//}
//if (index.Length / 2 == 0)
//{
//    centernum = (index.Length / 2) + ((index.Length - 1) / 2);
//}
//else
//{
//    centernum = (index.Length - 1) / 2;
//    //centernum = index.Length / 2;
//    //centernum = (float)Math.Floor(centernum);
    
//}
//Console.WriteLine("中央値="+index[centernum]);
//Console.WriteLine("最小="+min);
//Console.WriteLine("最大="+max);
//Console.WriteLine("平均="+ave);