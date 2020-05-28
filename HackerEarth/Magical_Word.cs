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
        bool[] arr = new bool[129];
        
        for(int i=0; i<129; i++)arr[i] = true;

        for(int p=2; p*p <= 128; p++)
        {
            if(arr[p]==true)
            {
                for(int i=p*p; i <= 128; i += p) arr[i] = false;
            }
        }
        
        int t = int.Parse(Console.ReadLine());

        
        while(t>0)
        {
            int len = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            char[] result = new char[len];

            for (int i=0; i<len; i++)
            {
                int val = (int)str[i];

                if(val <= 65) result[i]= char(67);
                else if(val >= 122) result[i]= char(113);

                else if(val>=90 && val <=97)
                {
                    int diff_a = 97 - val;
                    int diff_Z = val - 89;

                    if(diff_a < diff_Z) result[i]= char(97); 
                    else result[i] = char(89);
                }

                else 
                {   
                    if(arr[val]==true)result[i]=char(val);
                    else
                    {
                        int j=1;
                        for(int i=1; i<27; i++)
                        {
                            if(arr[val+i] == true || arr[val - j] == true )
                            {
                              if(arr[val+i]==true && arr[val-j]==false)result[i] = char(val+i);

                              else if(arr[val+i]==false && arr[val-j]==true)result[i] = char(val-j);
                              else result[i] = char(val-j);

                            }
                            j++;
                        } 
                    }
                    
                }




            }
            t--;
        }

    }
}