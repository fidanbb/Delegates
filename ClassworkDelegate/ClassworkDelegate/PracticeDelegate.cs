using System;
namespace ClassworkDelegate
{
	public class PracticeDelegate
	{

        //public delegate bool CheckNums(int num);

        //public delegate void ChangeStr(string str);

        //public delegate int CheckLenght(string str);



        public int GetLenght(string text,int num)
        {
            return text.Length + num;
        }


        //public int GetLenght(string text)
        //{
        //    return text.Length;
        //}




        //public void StrToLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}

        //public bool CheckOddNums(int num)
        //{
        //    return num % 2 == 1;
        //}



        //public bool CheckEvenNums(int num)
        //{
        //    return num % 2 == 0;
        //}


        //public bool CheckGreaterFiveNums(int num)
        //{
        //    return num >5;
        //}

        public void ExecuateMethod()
        {
            //SumOfOddNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 });
            //SumOfOddNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 },CheckOddNums);
            //SumOfNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckOddNums);
            //SumOfNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckEvenNums);
            //SumOfNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckGreaterFiveNums);

            //SumOfNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, m=>m%2==1);

            //List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9, 12 };

            //var result = numbers.Where(m => m % 2 == 1).Sum();
            //var data = numbers.FirstOrDefault(m => m > 5);
            //Console.WriteLine(result);
            //Console.WriteLine(data);

            //GetString("Salam");

            //GetString("Salam", StrToLower);
            //GetString("Salam", StrToUpper);

            //Action<string> func = new Action<string>(StrToLower);

            //func += StrToUpper;

            //func.Invoke("Salamlar");



            //Action<string> func = StrToUpper;

            //GetStringLenght("salam");
            //GetStringLenght("salam",GetLenght);

            Func<string, int, int> func = GetLenght;

            Console.WriteLine(func.Invoke("Salam", 100));


        }


        //private void GetStringLenght(string str, Func<string, int,int> func)
        //{
        //    Console.WriteLine(func(str,12));
        //}

        //private void GetStringLenght(string str, Func<string,int> func)
        //{
        //    Console.WriteLine(func(str));
        //}


        //private void GetStringLenght(string str,CheckLenght func)
        //{
        //    Console.WriteLine(func(str));
        //}

        //private void GetStringLenght(string str)
        //{
        //    Console.WriteLine(str.Length);
        //}


        //private void GetString(string str, Action<string> func)
        //{
        //    func(str);

        //}

        //private void GetString(string str,ChangeStr func)
        //{
        //    func(str);

        //}



        //private void GetString(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //    Console.WriteLine(str.ToUpper());

        //}


        //private void SumOfOddNumbers(List<int> numbers)
        //{
        //	int sum = 0;

        //	foreach (var number in numbers)
        //	{
        //		if (number % 2 == 1)
        //		{
        //			sum += number;
        //		}
        //	}

        //	Console.WriteLine(sum);
        //}


        //private void SumOfNumbers(List<int> numbers,CheckNums func)
        //{
        //    int sum = 0;

        //    foreach (var number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            sum += number;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}


        //private void SumOfNumbers(List<int> numbers, Predicate<int> func)
        //{
        //    int sum = 0;

        //    foreach (var number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            sum += number;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}


        //private void SumOfEvenNumbers(List<int> numbers)
        //{
        //    int sum = 0;

        //    foreach (var number in numbers)
        //    {
        //        if (number % 2 != 1)
        //        {
        //            sum += number;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}

        //private void SumOfGreaterFourOddNumbers(List<int> numbers)
        //{
        //    int sum = 0;

        //    foreach (var number in numbers)
        //    {
        //        if (number >4)
        //        {
        //            sum += number;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}
    }
}

