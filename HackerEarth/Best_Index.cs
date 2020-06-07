/*
// Sample code to perform I/O:
 
cin >> name;                            // Reading input from STDIN
cout << "Hi, " << name << ".\n";        // Writing output to STDOUT
 
// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/
 
// Write your code here
#include <bits/stdc++.h>
using namespace std;
int main()
{
    long long int n,num;  
    cin>>n;
    long long int sum[n+1];
    sum[0]=0;
    
   
    for(int i=1; i<=n+1; i++)
    {   
        cin>>num;
        sum[i] = sum[i-1] + num;
    }
    
    
    long long int ans =0;
    long long int MaxValue = LLONG_MIN;
 
    for(long long int i=1; i<=n; i++)
    {  // cout<<"CHECK";
        long long int l,r,temp =0;
        l = 1; 
        r = n;
 
        while(l<=r)
        {
            long long int mid = l+(r-l)/2 ; 
 
            if((mid*(mid+1)/2) +i -1 <= n )
            {
                temp = max(temp, mid);
                l = mid +1;
            }
            else r = mid -1;
        }
        
        long long int index = (temp*(temp+1)/2);
        ans = sum[index + i -1] - sum[i-1];
        if(ans >= MaxValue) MaxValue = ans;
    }
    cout<<MaxValue;
}