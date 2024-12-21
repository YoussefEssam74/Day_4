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
            /*
             * -------------------------------------------------
             */
            #region Loop Statements
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");
            //100
            //For Loop 
            //for(int i=1; i<= 1000000;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] array = { 1, 2, 3, 4, 5 };
            //for(int i = 0; i <=5; i++)//0 
            //{
            //    array[i] += 1;
            //    Console.WriteLine(array[5]);
            //}

            ////foreach => Display --
            //foreach (int num in array)
            //{
            //    //num += 1;
            //    Console.WriteLine(num);
            //}



            #endregion
            #region While/Do While
            //While 
            //Do While 
            //int num;
            //bool flag;
            //do
            //{
            //    Console.Write("Please Enter An Even Number: ");
            //    flag = int.TryParse(Console.ReadLine(),out num);//1
            //} while (num %2 ==1 || !flag);//True ///False

            //while (DBConnection)XXX
            //{

            //}


            #endregion
            #region String Format
            // 1.Concat 
            //Equation = 4 + 6 = 10
            //Immutable Type => Can't Change at the address
            //int x = 4;
            //int y = 6;
            ////string message = "Equation = " + x + " + " + y + " = " + (x + y);
            ////Console.WriteLine(message);
            ////2.
            ////string message = string.Format("Equation:{0} + {1} = {2}", x, y, x + y);
            ////Console.WriteLine(message);
            ////3. String Interpolation
            ////$
            //string message = $"Equation : {x} + {y} = {x+y}";
            //Console.WriteLine(message);
            #endregion
            #region String vs String Builder
            //string name;
            ////ClR Allocate 4 byte at stack
            //// Allocate 0 bytes at heap
            //name = "Ahmed";
            ////CLR Allocate 10 byte at Heap
            ////NAME assign to it's Object 
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //string name2 = name;
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            //name2 = "Ali";
            //Console.WriteLine("==================================");
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            //StringBuilder Class
            //Console.WriteLine("=================String ===================");
            //string name = "Ahmed";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //name = "Ali";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine("=================String StringBuilder===================");
            //StringBuilder message = new StringBuilder();
            //message.Append("Hello");
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            //message.Append("Route :)");
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            #endregion

            #region One D Array
            //Array Reference Type
            //int[] nums;//Reference at Stack  4 byte
            ////0 Bytes at Heap 
            //nums = new int[3];//clr 12 Byte at Heap 
            //Nums assign it's Object
            // 0 0 0

            //nums[0] = 1; //base 0 => First Element
            //nums[1] = 2; //Second Element
            ////nums[2] = 3; //thir
            //  int[] nums = { 1, 2, 3 };
            ////foreach (int i in nums)
            ////    Console.WriteLine(i);

            //for(int i  =0;i <nums.Length;i++)//Property =>KeyWord Count Elements
            //{
            //    Console.WriteLine(nums[i]);
            //}
            // Console.WriteLine($"Lenth of Array: {nums.Length} & Rank : {nums.Rank}");

            #endregion
            #region 2D Array
            //int[,] Marks = new int[3, 5];//1
            //bool flag = false;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Please Enter Grades of Student Number {i + 1}");
            //    Console.WriteLine("================================================");
            //    for (int j = 0; j < 5;)//5
            //    {
            //        Console.WriteLine($"Enter Subject Number {j + 1}");
            //        flag = int.TryParse(Console.ReadLine(), out Marks[i, j]);
            //        if (flag)
            //            j++;
            //    }
            //}
            //Console.Clear();    
            //for(int i = 0; i<Marks.GetLength(0);i++)
            //{
            //    Console.WriteLine($"Grades of Student Number {i + 1}");
            //    Console.WriteLine("================================================");
            //    for(int j=0;j<Marks.GetLength(1);j++)
            //    {
            //        Console.WriteLine($"Subject Number{j + 1}:{Marks[i,j]}");
            //    }
            //} 
            // //
            #endregion    

        }
    }
}
