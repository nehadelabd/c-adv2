namespace c_adv2
{
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        #region 4
        //static int FirstNonRepeatedCharIndex(string input)
        //{
        //    Dictionary<char, int> charCount = new Dictionary<char, int>();

        //    foreach (char c in input)
        //    {
        //        if (charCount.ContainsKey(c))
        //            charCount[c]++;
        //        else
        //            charCount[c] = 1;
        //    }

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (charCount[input[i]] == 1)
        //            return i;
        //    }

        //    return -1;
        //} 
        #endregion

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
        #region 7
        //static void ReverseQueue<T>(Queue<T> queue)
        //{
        //    Stack<T> stack = new Stack<T>();

        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }

        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }
        //} 
        #endregion
        #region 8
        //static bool IsBalanced(string input)
        //{
        //    Stack<char> stack = new Stack<char>();

        //    foreach (char ch in input)
        //    {

        //        if (ch == '(' || ch == '[' || ch == '{')
        //        {
        //            stack.Push(ch);
        //        }

        //        else if (ch == ')' || ch == ']' || ch == '}')
        //        {
        //            if (stack.Count == 0)
        //                return false;

        //            char top = stack.Pop();

        //            if ((ch == ')' && top != '(') ||
        //                (ch == ']' && top != '[') ||
        //                (ch == '}' && top != '{'))
        //            {
        //                return false;
        //            }
        //        }
        //   return stack.Count == 0;

        //    } 
        #endregion


        #region 9
        //static int[] RemoveDuplicates(int[] arr)
        //{
        //    HashSet<int> uniqueElements = new HashSet<int>();

        //    foreach (int num in arr)
        //    {
        //        uniqueElements.Add(num);
        //    }

        //    return uniqueElements.ToArray();

        //} 
        #endregion
        #region 10
        //static void RemoveOddNumbers(List<int> list)
        //{
        //    list.RemoveAll(n => n % 2 != 0);
        //} 
        #endregion
        #region 12
        //static void SearchInStack(Stack<int> stack, int target)
        //{
        //    int count = 0;
        //    bool found = false;

        //    Stack<int> tempStack = new Stack<int>(stack);

        //    while (tempStack.Count > 0)
        //    {
        //        int top = tempStack.Pop();
        //        count++;

        //        if (top == target)
        //        {
        //            Console.WriteLine($"Target was found successfully and the count = {count}");
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (!found)
        //    {
        //        Console.WriteLine("Target was not found");
        //    }
        //} 
        #endregion
        #region 13
        static int[] FindIntersection(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in arr1)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (int num in arr2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--;
                }
            }

            return result.ToArray();
        } 
        #endregion
        static void Main(string[] args)
        {
            #region 4

            //string text = "swiss";
            //int index = FirstNonRepeatedCharIndex(text);

            //if (index != -1)
            //    Console.WriteLine($"First non-repeated character: '{text[index]}' at index {index}");
            //else
            //    Console.WriteLine("No non-repeated character found."); 
            #endregion
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
            #region 5
            //string[] firstLine = Console.ReadLine().Split();
            //int n = int.Parse(firstLine[0]);
            //int q = int.Parse(firstLine[1]);

            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //for (int i = 0; i < q; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int count = 0;

            //    foreach (int num in arr)
            //    {
            //        if (num > x)
            //            count++;
            //    }

            //    Console.WriteLine(count); 
            #endregion
            #region 6
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //bool isPalindrome = true;

            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arr[i] != arr[n - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");

            #endregion
            #region 7
            //Queue<int> numbers = new Queue<int>();

            //numbers.Enqueue(10);
            //numbers.Enqueue(20);
            //numbers.Enqueue(30);
            //numbers.Enqueue(40);

            //Console.WriteLine("Original Queue:");
            //foreach (var num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //ReverseQueue(numbers);

            //Console.WriteLine("\nReversed Queue:");
            //foreach (var num in numbers)
            //{
            //    Console.Write(num + " ");
            //} 
            #endregion
            #region 8
            //string input = "[()]{ }".Replace(" ", ""); // Remove spaces if any

            //if (IsBalanced(input))
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced"); 
            #endregion
            #region 11
            //Queue queue = new Queue();


            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Console.WriteLine("Queue contents:");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item + " (Type: " + item.GetType().Name + ")");
            //} 
            #endregion
            #region 10
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            //Console.WriteLine("Original List: " + string.Join(", ", numbers));
            //RemoveOddNumbers(numbers);
            //Console.WriteLine("After Removing Odd Numbers: " + string.Join(", ", numbers)); 
            #endregion
            #region 9
            //int[] arr = { 1, 3, 5, 3, 1, 7, 5, 9 };

            //int[] result = RemoveDuplicates(arr);

            //Console.WriteLine("Original Array: " + string.Join(", ", arr));
            //Console.WriteLine("Array without duplicates: " + string.Join(", ", result));
            #endregion
            #region 12
            //Stack<int> numbers = new Stack<int>();

            //numbers.Push(10);
            //numbers.Push(20);
            //numbers.Push(30);
            //numbers.Push(40);
            //numbers.Push(50);

            //Console.WriteLine("Stack contents (top to bottom):");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.Write("\nEnter the target number to search for: ");
            //int target = int.Parse(Console.ReadLine());

            //SearchInStack(numbers, target); 
            #endregion
            #region 13
            string[] sizes = Console.ReadLine().Split(',');
            int n1 = int.Parse(sizes[0]);
            int n2 = int.Parse(sizes[1]);

            int[] arr1 = Console.ReadLine()
                                .Trim('[', ']', ' ')
                                .Split(',')
                                .Select(int.Parse)
                                .ToArray();

            int[] arr2 = Console.ReadLine()
                                .Trim('[', ']', ' ')
                                .Split(',')
                                .Select(int.Parse)
                                .ToArray();

            int[] intersection = FindIntersection(arr1, arr2);

            Console.WriteLine("[" + string.Join(",", intersection) + "]");
        
        #endregion

    }

    }
}


        

    
  

   

