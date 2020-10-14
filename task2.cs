using System;


namespace task2
{
    class lab2
    {
        static void Main(string[] args)
        {
            int n = 99;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even : " + i);
            }

            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("X0X0X0");
                    Console.WriteLine("0X0X0X");
                }
            }
            
            
            
            {
                int rows = 5;
                int cols = 5;
                int k;
                int m;
                for (k = 1; k <= rows; k++)
                {
                    for (m = k; m < k + cols; m++)
                    {
                        Console.Write(m);
                    }
                    Console.WriteLine("\n");

                }
            }
          
            
            {
                int i, odd_sum = 0, even_sum = 0, num = 100;

                for (i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                        even_sum = even_sum + i;
                    else
                        odd_sum = odd_sum + i;
                }
                Console.WriteLine("Sum of all odd numbers  = " + odd_sum + "\n");
                Console.WriteLine("Sum of all even numbers = " + even_sum + "\n");
            }
            
            
            {
                int i, j, rows5 = 5;
                for (i = 1; i <= rows5; ++i)
                {
                    for (j = 1; j <= i; ++j)
                    {
                        if (j == i)
                        {
                            for (int t = 1; t <= j; t++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(j);
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
          
            
            
            {
                int num = 5, sum = 1;
                for (int i = 1; i <= num; i++)
                {
                    sum = sum * i;
                }
                Console.WriteLine("Factorial : " + sum);
            }
          
            
            
            {
                int i, j, N = 5;
                for (i = 1; i <= N; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("\n");
                }
                for (i = N - 1; i >= 1; i--)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("\n");
                }
            }
        }

    }
}


