using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace oopLab1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*    task1();
                task2();
                task3();
                task4();
                task5();
                task6();
                task7();
                task8();
                task9();*/
               task14();
              /* task18();*/



        }
        static void task1()
        {
            Console.WriteLine("Hello world!!");
            Console.WriteLine("Hello world!!");
            Console.ReadKey();
        }
        static void task2()
        {
            int var = 12;
            Console.WriteLine("Value of int variable: ");
            Console.WriteLine(var);
            Console.ReadKey();
        }
        static void task3()
        {
            string str = "This is string";
            Console.WriteLine("String: ");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void task4()
        {
            char chr = 'D';
            Console.WriteLine("char: ");
            Console.WriteLine(chr);
            Console.ReadKey();
        }
        static void task5()
        {
            float no = 3.5F;
            Console.WriteLine("Decimal: ");
            Console.WriteLine(no);
            Console.ReadKey();
        }
        static void task6()
        {
            string input;
            Console.WriteLine("Enter string: ");
            input=Console.ReadLine();
            Console.WriteLine("You have entered following string: ");
            Console.WriteLine(input);
            Console.ReadKey();

        }
        static void task7()
        {
            string input;
            Console.WriteLine("Enter Number: ");
            input = Console.ReadLine();
            int inputInt = int.Parse(input);
            Console.WriteLine("You have entered following number: ");
            Console.WriteLine(inputInt);
            Console.ReadKey();
        }
        static void task8()
        {
            string input;
            Console.WriteLine("Enter Float Number: ");
            input = Console.ReadLine();
            float inputInt = float.Parse(input);
            Console.WriteLine("You have entered following Floating number: ");
            Console.WriteLine(inputInt);
            Console.ReadKey();
        }
        static void task9()
        {
            string input;
            Console.WriteLine("Area of Square");
            Console.WriteLine("Enter length of one side: ");
            input = Console.ReadLine();
            float inputInt = float.Parse(input);
            float area = calculateArea(inputInt);
            Console.Write("This is area of square: ");
            Console.WriteLine(area);
            Console.ReadKey();

        }
        static float calculateArea(float length)
        {
            float area = length * length;
            return area;
        }
        static void task10()
        {
            string mark;
            Console.WriteLine("Enter Your Marks: ");
            mark =Console.ReadLine();
            int marks = int.Parse(mark);
            if(marks>50)
            {
                Console.WriteLine("You Are Passed");
            }
            else
            {
                Console.WriteLine("You Are Fail");
            }
            Console.ReadKey();
        }
        static void task11()
        {
            for(int x=0;x<5;x++)
            {
                Console.WriteLine("Welcome to OOP");
            }
            Console.ReadKey();
        }
        static void task12()
        {
            int num;
            int sum = 0;
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());
            while(num!= -1)
            {
                sum = sum + num;
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is{0}", sum);
            Console.ReadKey();
        }
        static void task13()
        {
            int[] arr = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter value at {0}",i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largeNo = -1;
            for(int i=0;i<3;i++)
            {
                if(arr[i]>largeNo)
                {
                    largeNo = arr[i];
                }
            }
            Console.WriteLine("The largest number is: {0} ", largeNo);
            Console.Read();
        }
        static void task14()
        {
            int presents=0;
            float money=0;
            float presentAmount;
            float totalAmount;
            float totalprice=0;
            Console.WriteLine("Enter lilli's age: ");
            int age= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price of washing machine: ");
            float priceWash = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter price of toy: ");
            float priceToy = float.Parse(Console.ReadLine());
            for (int i=1;i<=age;i++)
            {
                if(i%2==0)
                {
                   
                    money = money + 10;
                    totalprice = totalprice + money - 1;
                 
                   // money--;
                }
                else if(i % 2 != 0)
                {
                    presents=presents+1;
                }
            }
            presentAmount = priceToy * presents;
            totalAmount = presentAmount + money;
            //Console.Write(totalAmount);
            if(totalAmount>priceWash)
            {
             float remAmount = totalAmount - priceWash;
                Console.Write("Yes! " + remAmount + "amount Left");
            }
            if(priceWash>totalAmount)
            {
                float needAmount =priceWash-totalAmount;

                Console.Write("No! " + needAmount + "amount needed");
            }
            Console.ReadKey();
        }
        static void task15()
        {
            int num=0;
            int sum=0;
            do
            {
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine("The total sum is: {0} ", sum);
            Console.Read();
        }
        static void task16()
        {
            Console.WriteLine("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = calculateSum(num1, num2);
            Console.WriteLine("The sum is: {0} ",sum);
        }
        static int calculateSum(int num1,int num2)
        {
            return num1 + num2;
        }
        static void task17()
        {
            string path = "D:\\ooplab\\oopLab1\\oopLab1\\file.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not exists");
            }
        }
        static void task18()
        {
            string path = "D:\\ooplab\\oopLab1\\oopLab1\\file.txt";
            StreamWriter fileVariable = new StreamWriter(path,true);
            fileVariable.WriteLine("Hello");
            fileVariable.Flush();
            fileVariable.Close();
        }
    }
}
