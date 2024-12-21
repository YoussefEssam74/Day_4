using System.Drawing;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region q2
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{i} x 5 = {i * 5}");
            //}
            #endregion
            #region q3
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    if(i%2==0)
            //    Console.WriteLine(i);
            //}
            #endregion
            #region q4
            //Console.WriteLine("Enter the base");
            //int basee = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the power");
            //int pow = int.Parse(Console.ReadLine());
            //long res = 1;
            //int i = 1;
            //for (; i <=pow; i++)
            //{
            //    res *=basee;
            //}
            //Console.WriteLine($"{basee}^{pow} = {res} ");
            #endregion
            #region q5
            //Console.WriteLine("Enter Your string");
            //string s=Console.ReadLine();
            //for(int i = s.Length-1; i >= 0; i--)
            //{
            //    Console.Write(s[i]);
            //}
            #endregion
            #region q6
            //Console.WriteLine("Entere Start Number");
            //int s = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entere End Number");
            //int e = int.Parse(Console.ReadLine());
            //for (int num = s; num <= e; num++)
            //{
            //    bool fl = true;

            //    if (num <= 1)
            //    {
            //        fl = false;

            //    }

            //        for (int i = 2; i * i <= num; i++)
            //        {
            //            if (num % i == 0)
            //            {
            //                fl = false;
            //                break;
            //            }
            //        }

            //        if (fl)
            //        {
            //            Console.WriteLine($"{num}");
            //        }
            //}
            #endregion
            #region q7
            //Console.WriteLine("Enter a number to convert");
            //int n = int.Parse(Console.ReadLine());
            //string binary = "";
            //if (n == 0)
            //{
            //    binary ="0";
            //}
            //while (n > 0)
            //{
            //    binary=(n%2)+binary;
            //    n /= 2;
            //}
            //Console.WriteLine(binary);

            #endregion
            #region q8
            //Console.WriteLine("Enter the size of the matrix");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("$");
            //        }
            //        else
            //        {
            //            Console.Write("0");
            //        }
            //    }
            //    Console.WriteLine();

            //}
            #endregion
            #region q9
            //string input = "Youssef Essam";
            //string output = input.Substring(7, 6);
            //Console.WriteLine($"Extracted Substring =>{output}");
            #endregion
            #region q10
            //string s1 = "Youssef", s2 = "Essam";
            //string s3= string.Concat(s1, " ", s2);
            //Console.WriteLine(s3);


            #endregion
            #region q11
            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //long sum = 0;
            //Console.WriteLine("Enter the elements of the array");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Sum = {sum}");
            #endregion
            #region q12
            //Console.WriteLine("Enter the size of the array1");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //Console.WriteLine("Enter the elements of the array1");
            //for (int i = 0; i < n; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter the size of the array2");
            //int n2 = int.Parse(Console.ReadLine());
            //int[] arr2 = new int[n];
            //Console.WriteLine("Enter the elements of the array2");
            //for (int i = 0; i < n; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] mergedArray = new int[n * 2];
            //arr1.CopyTo(mergedArray, 0);  
            //arr2.CopyTo(mergedArray, n); 
            //Array.Sort(mergedArray);
            //Console.WriteLine("mergedArray is");
            //foreach (var value in mergedArray)
            //{
            //    Console.Write(value + " ");
            //}
            #endregion
            #region q13
            //int[] arr = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            //int[] frequency = new int[arr.Length+1];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    frequency[arr[i]]++;
            //}
            //Console.WriteLine("Element Frequency:");
            //for (int i = 0; i < frequency.Length; i++)
            //{
            //    if (frequency[i] > 0) 
            //    {
            //        Console.WriteLine($"Element {i}==> {frequency[i]} times");
            //    }
            //}
            #endregion
            #region q14
            //int[] arr = { 2, 5, 5, 100,90, 8, 9,1};
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i]; 
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i]; 
            //    }
            //}
            //Console.WriteLine($"Maximum element ==> {max}");
            //Console.WriteLine($"Minimum element ==>{min}");
            #endregion
            #region q15
            //int[] arr = { 2, 5, 5, 100, 90, 8, 9, 1 };
            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        secondLargest = largest;  
            //        largest = arr[i];  
            //    }
            //    else if (arr[i] > secondLargest && arr[i] != largest)
            //    {
            //        secondLargest = arr[i];  
            //    }
            //}
            //Console.WriteLine($"Second largest element ==> {secondLargest}");
            #endregion
            #region q16
            //int[] arr = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            //int n = arr.Length;
            //int maxDistance = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i;
            //            maxDistance = Math.Max(maxDistance, distance);
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine($"The longest distance between two equal cells is ==> {maxDistance}");

            #endregion
            #region q17
            //Console.WriteLine("Enter the number of rows");
            //int rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of columns");
            //int columns = int.Parse(Console.ReadLine());
            //int[,] array1 = new int[rows, columns];
            //int[,] array2 = new int[rows, columns];
            //Console.WriteLine("Enter the elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.WriteLine($"Enter element at position ({i}, {j}):");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Array.Copy(array1, array2, array1.Length);
            //Console.WriteLine("The elements of the second array after copying ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region q18
            //int[] arr = { 100,20,2 };
            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
        }
    }
}
