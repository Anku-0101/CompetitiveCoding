using System;
using System.IO;
using System.Linq;
 
 
public class HelloWorld
{
    static public void Main()
    {
        string line;
        line = Console.ReadLine();
        string[] parameter = line.Split(' ');
        int n = int.Parse(parameter[0]);
        int k = int.Parse(parameter[1]);
        
        line = Console.ReadLine();
        string[] values = line.Split(' ');
        long[] arr = new long[n];
 
        int CountN=0, CountP=0;
        for(int i=0; i<n; i++) 
        {
            arr[i] = long.Parse(values[i]);
            if(arr[i]>0) CountP++;
            if(arr[i]<0) CountN++;
        }
        // Console.WriteLine(n);
        // Console.WriteLine(k);
        // for(int i=0; i<n; i++) Console.WriteLine(arr[i]);
        if(CountN > 0.8*n) 
        {
            long OutP = SolveP(k,arr);
            Console.WriteLine(OutP);
        }
        else 
        {
            long outN = SolveN(k, arr);
            Console.WriteLine(outN);
        }
    
    }
 
    static long SolveN(int k, long[] arr)
    {
        long result = 0;
        int j = k;
        int len = arr.Length;
        
        for(int i = 0; i < len; i++)
        {
            if(arr[i] < 0)
            {
                j =  k;
                while(j > 0 && arr[i] < 0 )
                {
                    if(i-j >= 0 && arr[i-j] > 0)
                    {
                        if(Math.Abs(arr[i]) >= arr[i-j] )
                        {
                            arr[i] = arr[i] + arr[i-j];
                            arr[i-j] = 0;
                        }
                        else
                        {
                            arr[i - j] = arr[i-j] + arr[i];
                            arr[i] = 0;
                            break;
                        }                        
                    }
                    j--;
                }
                j = 1;
                while(j<=k && i+j < len && arr[i] < 0)
                {
                    if( arr[i+j] > 0)
                    {
                        if(Math.Abs(arr[i]) >= arr[i+j] )
                        {
                            arr[i] = arr[i] + arr[i+j];
                            arr[i+j] = 0;
                        }
                        else
                        {
                            arr[i+j] = arr[i+j] + arr[i];
                            arr[i] = 0;
                            break;
                        }
                    }
                    j++;
                }
                
            }
        }
        for(int i=0; i<len; i++)      result += Math.Abs(arr[i]);
             
        return result;
    }
 
static long SolveP(int k, long[] arr)
    {
        long result = 0;
        int j = k;
        int len = arr.Length;
        
        for(int i = 0; i < len; i++)
        {
            if(arr[i] > 0)
            {
                j =  k;
                while(j > 0 && arr[i]>0)
                {
                    if(i-j >= 0 && arr[i-j] < 0)
                    {
                        if(Math.Abs(arr[i-j]) >= arr[i] )
                        {
                            arr[i-j] = arr[i-j] + arr[i];
                            arr[i] = 0;
                            break;
                        }
                        else
                        {
                            arr[i] = arr[i-j] + arr[i];
                            arr[i-j] = 0;
                        }                        
                    }
                    j--;
                }
                j = 1;
                while(j<=k && i+j < len && arr[i]>0)
                {
                    if( arr[i+j] < 0)
                    {
                        if(Math.Abs(arr[i+j]) >= arr[i] )
                        {
                            arr[i+j] = arr[i+j] + arr[i];
                            arr[i] = 0;
                            break;
                        }
                        else
                        {
                            arr[i] = arr[i+j] + arr[i];
                            arr[i+j] = 0;
                        }
                    }
                    j++;
                }
                
            }
        }
        
 
        for(int i=0; i<len; i++) 
        { 
            //Console.WriteLine(arr[i]);
            result += Math.Abs(arr[i]);
        }      
        
        return result;
    }
 
 }
Language: C#