
#include<bits/stdc++.h>
using namespace std;
 
int main()
{
	int n;
	cin>>n;
	int a[n], b[n];
 
	int minNum = INT_MAX;
	for(int i=0; i<n; i++)
	{
		cin>>a[i];
		
		if(a[i] < minNum) minNum = a[i];
	}
 
	for(int i =0 ; i<n; i++) 
	{
		cin>>b[i];
		
	}
 
	int result=0; 
 
	for(int i=0; i<n; i++)
	{ 
		if(a[i] == minNum) continue;
 
		while(a[i] >= b[i] && b[i]!=0)
		{
			a[i] = a[i] - b[i];
			result ++;
			if(a[i] == minNum)
			{
				break;
			}
			if(minNum > a[i])
			{
				minNum = a[i];
				i = -1;
				break;
			}
 
		}
		
	}
	    for(int i=0 ; i<n-1; i++)
		{ 
			if(a[i] != a[i+1])
			{
				cout<<-1;
				return 0;
			}
		}
		cout<<result;
}


/*
using System;


class Solution
{
    static bool CheckEquality(int[] arr)
    {
        int len = arr.Length;
        bool res = true;
        int x = arr[0];
        foreach (int i in arr)
        {
            if( i != x)
            {
                res = false;
                break;
            }
        }
        return res;
    }

    static int[] MinNumber(int[] arr)
    {
        int[] res = new int[2];
        int MinNum = int.MaxValue;
        int len = arr.Length;
        int index=0;
        
        for(int i=0; i<len ;i++)
        {
            if(i < MinNum) 
            {
                MinNum = arr[i];
                index =i;
            }
        }
        res[0] = MaxNum;
        res[1] = index;
        return res;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];

        string str = Console.ReadLine();
        string[] values = str.Split(' ');
        for(int i=0; i<n; i++) a[i] = int.Parse(values[i]);
        
        str = Console.ReadLine();
        values = str.Split(' ');
        for(int i=0; i<n; i++) b[i] = int.Parse(values[i]);

        
        bool found = true;

        int result = 0;
        while(true)
        {
            int[] minimum = new int[2];
            minimum = MinNumber(a);
            
        
            
            if( minimum[0] < b[minimum[1]])
            {
                for(int i=0; i<n; i++)
                {
                    if(a[i]>minimum[0])
                    {
                        int num = a[i] - minimum[0];

                        if( num % b[i] == 0) result =                         
                    }
                }

            }       
            
            
            
        }
        if(found)Console.WriteLine(result);
    
    }
}

*/