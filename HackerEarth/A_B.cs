using System;
class Solution
{
    static void Main()
    {
        while(true)
        {
            string str = Console.ReadLine();
            string[] values = str.Split(' ');
            string a = values[0];
            string b = values[1];

            int lenA = a.Length;
            int lenB = b.Length;
            
            int n = Math.Max(lenA,lenB);

            int[] res = new int[n+1];
            int Va =0;
            int Vb =0;
            int rem =0;
            int sum =0;
            
            for(int i=0; i<n; i++)
            {   
                Va = 0;
                Vb = 0;
                rem =0;
                if( (lenA-1-i) >= 0 ) Va = (int)str[lenA-i];
                if( (lenB-1-i) >= 0 ) Vb = (int)str[lenA-i];

                sum += Va + Vb;
                rem = sum/10;
                res[n-i] = sum%10;
                sum = rem;
            }
            res[0] = sum;
            Console.WriteLine(res);

        }
    }
}