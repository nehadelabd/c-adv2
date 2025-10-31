namespace c_adv2
{
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                Console.WriteLine("Before reversing: " + string.Join(", ", numbers));
                ReverseList(numbers);
                Console.WriteLine("After reversing: " + string.Join(", ", numbers));
            }
        }
        static void ReverseList<T>(List<T> list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                // Swap elements
                T temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
    
}
}
