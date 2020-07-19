using System;
 
class Solution
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());
 
        while( t > 0)
        {
            string str = Console.ReadLine();
            string[] val = str.Split(" ");
 
            int c0 = int.Parse(val[0]);
            int c1 = int.Parse(val[1]);
            int c2 = int.Parse(val[2]);
            int c3 = int.Parse(val[3]);
 
            int[,] arr = new int[2,2];
 
            arr[0,0] = c0;
            arr[0,1] = c1;
            arr[1,0] = c2;
            arr[1,1] = c3;
 
            bool flag = true;
 
            for(int i =0; i<2;i++)
            {
                for(int j=0; j<2; j++)
                {
                    for(int k =0; k<2; k++)
                    {
                        if(arr[k,arr[i,j]] != arr[arr[k,i],j])
                        {
                            flag = false;
                            break;
                        }
                    }
                }
            }
 
            if(flag == true)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }
            
            t-- ;
        }
    }
}
