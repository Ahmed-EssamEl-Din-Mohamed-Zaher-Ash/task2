namespace Assignment_02
{
   internal class Program
   {
      static void Main(string[] args)
      {


         //1------------------
         bool flag0;
         int Number;
         do
         {
            Console.WriteLine("Enter Number : ");
            flag0 = int.TryParse(Console.ReadLine(), out Number);
         }
         while (!flag0);

         if (Number % 3 == 0 && Number % 4 == 0)
            Console.WriteLine("Yes");
         else
            Console.WriteLine("No");


         //2------------------
         bool flag1;
         int Number1;

         do
         {
            Console.WriteLine("Enter Number : ");
            flag1 = int.TryParse(Console.ReadLine(), out Number1);
         }
         while (!flag1);

         if (Number1 > 0)
            Console.WriteLine("Positive");
         else
            Console.WriteLine("Negative");

         //3------------------



         bool flag2, flag3, flag4;
         int Number2, Number3, Number4;

         do
         {
            Console.WriteLine("Enter first num : ");
            flag2 = int.TryParse(Console.ReadLine(), out Number2);

            Console.WriteLine("Enter sec Num : ");
            flag3 = int.TryParse(Console.ReadLine(), out Number3);

            Console.WriteLine("Enter third Num  : ");
            flag4 = int.TryParse(Console.ReadLine(), out Number4);
         }
         while (!flag2 && flag3 && flag4);

         if (Number2 > Number3 && Number2 > Number4)
         {
            if (Number3 > Number4)
               Console.WriteLine($"MaxNumber : {Number2} MinNumber : {Number4}");
            else
               Console.WriteLine($"MaxNumber : {Number2} MinNumber : {Number3}");
         }
         else if (Number3 > Number2 && Number3 > Number4)
         {
            if (Number2 > Number4)
               Console.WriteLine($"MaxNumber : {Number3} MinNumber : {Number4}");
            else
               Console.WriteLine($"MaxNumber : {Number3} MinNumber : {Number2}");
         }
         else if (Number4 > Number2 && Number4 > Number3)
         {
            if (Number2 > Number3)
               Console.WriteLine($"MaxNumber : {Number4} MinNumber : {Number3}");
            else
               Console.WriteLine($"MaxNumber : {Number4} MinNumber : {Number2}");
         }
         else
         {
            Console.WriteLine("Numbers Are Equals");
         }

         //4------------------

         bool flag5;
         int Number5;

         do
         {
            Console.WriteLine("Enter Num : ");
            flag5 = int.TryParse(Console.ReadLine(), out Number5);
         }
         while (!flag5);

         if (Number5 % 2 == 0)
            Console.WriteLine("Even");
         else
            Console.WriteLine("Odd");



         //5------------------



         Console.WriteLine("Enter Your Char : ");
         string word = Console.ReadLine();

         if (word.ToLower() == "a" || word.ToLower() == "e" || word.ToLower() == "i" || word.ToLower() == "o" || word.ToLower() == "u")
            Console.WriteLine("Vowel");
         else
            Console.WriteLine("Consonant");



         //6------------------
         bool flag8;
         int Number8;

         do
         {
            Console.WriteLine("Enter Num : ");
            flag8 = int.TryParse(Console.ReadLine(), out Number8);
         }
         while (!flag8);

         for (int i = 1; i <= Number8; i++)
         {
            Console.WriteLine(i);
         }



         //7------------------
         bool flag11;
         int Number11;

         do
         {
            Console.WriteLine("Enter Num : ");
            flag11 = int.TryParse(Console.ReadLine(), out Number11);
         }
         while (!flag11);

         for (int i = 1; i <= 12; i++)
         {
            Console.WriteLine(Number11 * i);
         }

         //8------------------

         bool flag13;
         int Number13;

         do
         {
            Console.WriteLine("Enter Num : ");
            flag13 = int.TryParse(Console.ReadLine(), out Number13);
         }
         while (!flag13);

         if (Number13 > 0)
         {
            for (int i = 1; i < Number13; i++)
            {
               if (i % 2 == 0)
                  Console.WriteLine(i);
            }
         }
         //9------------------
         int res = 0;
         Console.WriteLine("Enter Base Num : ");
         int baseNum = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Base Exponent : ");
         int exp = int.Parse(Console.ReadLine());
         for (int i = 1; i < exp; i++)
         {
            res *= baseNum;
         }
         Console.WriteLine(res);
         //11------------
         bool flag16;
         int Number16;
         do
         {
            Console.WriteLine("Enter Number : ");
            flag16 = int.TryParse(Console.ReadLine(), out Number16);
         }
         while (!flag16);
         switch (Number16)
         {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
               Console.WriteLine($"The Number of Dayes in Month Number {Number16} is 31 Days");
               break;
            case 2:
               Console.WriteLine($"The Number of Dayes in Month Number {Number16} is 28 Day");
               break;
            case 4:
            case 6:
            case 9:
            case 11:
               Console.WriteLine($"The Number of Dayes in Month Number {Number16} is 30 Days");
               break;
            default:
               Console.WriteLine("Wrong Input");
               break;
         }
         //12------------------
         bool flag_one, flag_two;
         int num1, num2;
         char operation;
         do
         {
            Console.WriteLine("Enter first number: ");
            flag_one = int.TryParse(Console.ReadLine(), out num1);
         }
         while (!flag_one);
         do
         {
            Console.WriteLine("Enter second number: ");
            flag_two = int.TryParse(Console.ReadLine(), out num2);
         }
         while (!flag_two);
         Console.WriteLine("Enter operation (+, -, *, /): ");
         operation = Console.ReadLine()[0];
         Console.WriteLine();
         if (operation == '+')
         {
            Console.WriteLine($"Result: {num1 + num2}");
         }
         else if (operation == '-')
         {
            Console.WriteLine($"Result: {num1 - num2}");
         }
         else if (operation == '*')
         {
            Console.WriteLine($"Result: {num1 * num2}");
         }
         else if (operation == '/')
         {
            if (num2 != 0)
               Console.WriteLine($"Result: {num1 / num2}");
            else
               Console.WriteLine("Cannot divide by zero");
         }
         else
         {
            Console.WriteLine("Invalid operation");
         }
         //13------------------
         Console.WriteLine("Enter a string: ");
         string input = Console.ReadLine();
         string reversedString = "";
         for (int i = input.Length - 1; i >= 0; i--)
         {
            reversedString += input[i];
         }
         Console.WriteLine($"Reversed string: {reversedString}");
         //************************
         int x1, x2, x3, y1, y2, y3;
         double m1, m2, m3;
         Console.WriteLine("Enter Point01");
         x1 = int.Parse(Console.ReadLine());
         y1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Point02");
         x2 = int.Parse(Console.ReadLine());
         y2 = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Point03");
         x3 = int.Parse(Console.ReadLine());
         y3 = int.Parse(Console.ReadLine());
         m1 = (double)(y2 - y1) / (x2 - x1);
         m2 = (double)(y3 - y1) / (x3 - x1);
         m3 = (double)(y3 - y2) / (x3 - x2);
         if (m1 == m2 && m1 == m3)
         {
            Console.WriteLine("These points lie on a single straight line");
         }
         else
         {
            Console.WriteLine("These points do not lie on a single straight line");
         }
         //************************
         bool flag30;
         int size30;
         do
         {
            Console.WriteLine("Enter Size Of Array ");
            flag30 = int.TryParse(Console.ReadLine(), out size30);
         } while (!flag30);
         int[] arr01 = new int[size30];
         for (int x = 0; x < size30; x++)
         {
            do
            {
               Console.WriteLine($"Enter Number : {x + 1}");
               flag30 = int.TryParse(Console.ReadLine(), out arr01[x]);
            } while (!flag30);
         }
         int largest01 = arr01[0];
         for (int i = 0; i < arr01.Length; i++)
         {
            if (largest01 < arr01[i])
            {
               largest01 = arr01[i];
            }
         }
         int largest02 = 0;
         for (int i = 0; i < arr01.Length; i++)
         {
            if (arr01[i] > largest02 && largest01 > arr01[i])
            {
               largest02 = arr01[i];
            }
         }
         Console.WriteLine($"Second Largest : {largest02}");
         //************************
         string sen;
         Console.WriteLine("Enter Sentence");
         sen = Console.ReadLine();
         string result = "";
         string[] str = sen.Split(" ");
         for (int i = str.Length - 1; i >= 0; i--)
         {
            result += str[i] + " ";
         }
         Console.WriteLine($"Reverse Sentence : {result}");
         //************************
         int[] arr = { 1, 2, 3, 4, 5 };
         for (int i = arr.Length - 1; i >= 0; i--)
         {
            Console.Write($" {arr[i]} ");
         }
      }

   }
}