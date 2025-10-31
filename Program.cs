namespace c_adv2
{
    using System.Collections.Generic;

    internal class Program
    {
        static int FirstNonRepeatedCharIndex(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[input[i]] == 1)
                    return i;
            }

            return -1;
        }

        #region 2
        //static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> evenNumbers = new List<int>();

        //    foreach (int num in numbers)
        //    {
        //        if (num % 2 == 0)
        //        {
        //            evenNumbers.Add(num);
        //        }
        //    }

        //    return evenNumbers;
        //} 
        #endregion
        static void Main(string[] args)
        {

            string text = "swiss";
            int index = FirstNonRepeatedCharIndex(text);

            if (index != -1)
                Console.WriteLine($"First non-repeated character: '{text[index]}' at index {index}");
            else
                Console.WriteLine("No non-repeated character found.");
            #region 2
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> evens = GetEvenNumbers(numbers);

            //Console.WriteLine("Original list: " + string.Join(", ", numbers));
            //Console.WriteLine("Even numbers: " + string.Join(", ", evens)); 
            #endregion
            #region 1
            //    {
            //        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            //        Console.WriteLine("Before reversing: " + string.Join(", ", numbers));
            //        ReverseList(numbers);
            //        Console.WriteLine("After reversing: " + string.Join(", ", numbers));
            //    }
            //}

            //static void ReverseList<T>(List<T> list)
            //{
            //    int left = 0;
            //    int right = list.Count - 1;

            //    while (left < right)
            //    {
            //        T temp = list[left];
            //        list[left] = list[right];
            //        list[right] = temp;

            //        left++;
            //        right--;
            //    }
            //} 
            #endregion
            #region 3
            //try
            //{
            //    FixedSizeList<int> numbers = new FixedSizeList<int>(3);

            //    numbers.Add(10);
            //    numbers.Add(20);
            //    numbers.Add(30);

            //    Console.WriteLine("Items in the list:");
            //    for (int i = 0; i < numbers.Count; i++)
            //    {
            //        Console.WriteLine(numbers.Get(i));
            //    }


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //} 
            #endregion


        }
    }

    }

