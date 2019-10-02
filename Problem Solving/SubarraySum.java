//Subarray with given sum
//Problem :https://practice.geeksforgeeks.org/problems/subarray-with-given-sum/
import java.util.*;
import java.lang.*;
import java.io.*;

class GFG {
	public static void main (String[] args) throws IOException {
		BufferedReader br=new BufferedReader(new InputStreamReader(System.in));
		int t=Integer.parseInt(br.readLine());
		while(t-->0)
		{
		    String sarr[]=br.readLine().split(" ");
		    int size=Integer.parseInt(sarr[0]);
		    int sum=Integer.parseInt(sarr[1]);
		    String ar[]=br.readLine().split(" ");
		    int arr[]=new int[size];
		    int tsum=0;
		    int start=1;
		    int end=0;
		    for(int i=0; i<size; i++)
		    {
		        arr[i]=Integer.parseInt(ar[i]);
		        tsum+=arr[i];
		        if(tsum==sum)
		        {
		            end=i+1;
		            break;
		        }
		        else
		        {
		            while(tsum>sum)
		            {
		                tsum-=arr[start-1];
		                start++;
		            }
		            
		            if(tsum==sum)
    		        {
    		            end=i+1;
    		            break;
    		        }
		        }
		    }
		    if(end==0)
		    {
		        System.out.println("-1");
		    }
		    else System.out.println(start+" "+end);
		}
	}
}
