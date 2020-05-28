/*
// Sample code to perform I/O:

name = Console.ReadLine();                  // Reading input from STDIN
Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT

// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/

// Write your code here
using System;
class Solution
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while(t>0)
        {
            string str = Console.ReadLine();
            string[] values = str.Split(' ');
            int k = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            int n = int.Parse(values[2]);
            long result = 0;
            
        //     if(k==m)
        //     {   result = 0;
        //         Console.WriteLine(result);
        //     }

        //     if(k>m)
        //     {
        //         Console.WriteLine(Solution.DiffStep(k,m));
        //     }

        //     if(k<m)
        //     {  
        //         if(m%n != 0)
        //         {
        //             if(k < m/n +1)
        //             {
        //                 while(k < m/n + 1 )
        //                 {
        //                     k = k*n;
        //                     result ++;
        //                 }

        //                 result += DiffStep(k, m/n + 1);

        //                 k = m/n + 1;
                        
        //                 while(k<m)
        //                 { 
        //                     k = k*n;
        //                     result++;
        //                 }

        //                 result += DiffStep(k,m);
        //                 Console.WriteLine(result);
                        
        //             }    

        //             else
        //             {
        //                 result += DiffStep(k, m/n + 1);
        //                 k = m/n + 1;
                        
        //                 while(k<m)
        //                 { 
        //                     k = k*n;
        //                     result++;
        //                 }

        //                 result += DiffStep(k,m);
        //                 Console.WriteLine(result);
                     
        //             }
        //         }   
                
        //         else
        //         {
        //             if(k < m/n )
        //             {
                        
        //                 while(k < m/n )
        //                 {
        //                     k = k*n;
        //                     result ++;
        //                 }
                        
        //                 result += DiffStep(k, m/n);
        //                    k = m/n;
                        
        //                 while(k<m)
        //                 { 
        //                     k = k*n;
        //                     result++;
        //                 }

        //                 result += DiffStep(k,m);
                        
        //                 Console.WriteLine(result);
                       
        //             }    

        //             else
        //             {
        //                 result += DiffStep(k, m/n );
                        
        //                 k = m/n;

        //                 while(k<m)
        //                 { 
        //                     k = k*n;
        //                     result++;
        //                 }
                        
        //                 result += DiffStep(k,m);
        //                 Console.WriteLine(result);
                        
        //             }
        //         }
        //     }
            
        //     t--;
        // }
        
        // IN THE ABOVE CODE(Without Recursion) all the test cases are passing except one or          //two in some test cases 
        result = DiffStep(k,m,n);
        Console.WriteLine(result);
        t--;
        // In recursion all test cases are passing 
    }}
    public static long DiffStep(int k, int m,int n)
    {  
        if(k>=m)
        {
            int dif = k - m;
            int value = dif/2;
            if(dif%2 == 0) return (value);
            else return (value+1);
        }

        else if(m%n == 0) return DiffStep(k, m/n, n) + 1;
        else return DiffStep(k, m/n +1, n) + DiffStep((m/n + 1)*n, m , n) + 1;

    }

}