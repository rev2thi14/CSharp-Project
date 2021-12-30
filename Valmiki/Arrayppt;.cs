using System;
/*SingleDimensional Array 
DataTpe[] VariableName=new
DataType[number];           
In tha above declaration DataType*/

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            /*foreach(int a in arr)
            {
                Console.WriteLine(a);
            }*/
            Console.ReadLine();


            // MultiDimensional Array
             
             

            /*int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadKey();*/



        
            //Jagged Array
            
            /*int[][] arr = new int[][]
           {
                new int[] { 0, 1 },
                new int[] { 10, 11 },
                new int[] { 100, 101, 110, 111 }
           };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();*/
        }
    }
}
