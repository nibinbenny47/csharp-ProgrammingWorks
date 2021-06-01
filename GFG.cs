using System; 
  
public class GFG { 
  
    // Main Method 
    static public void Main() 
    { 
  
        int n = 10; 
        int[] arr = new int[n]; 
        int i; 
  
        // initial array of size 10 
        for (i = 0; i < n; i++) 
            arr[i] = i + 1; 
  
        // print the original array 
        for (i = 0; i < n; i++) 
            Console.Write(arr[i] + " "); 
        Console.WriteLine(); 
int j;

//Iterate through the items of array
for (int k = 0; k < arr.Length; k++)
{

// see if num is evenly divisible
for ( j = 2; j < arr[k]; j++)
if((arr[k]%j ==0))
{
// element to be inserted 
        int x = arr[k]; 
  
        // position at which element  
        // is to be inserted 
        int pos = n+1; 
  
        // create a new array of size n+1 
	int[] newarr = new int[n + 1]; 
	//int[] newarr = new int[20];
  
        // insert the elements from the  
        // old array into the new array 
        // insert all elements till pos 
        // then insert x at pos 
        // then insert rest of the elements 
        for (i = 0; i < n + 1; i++) { 
            if (i < pos - 1) 
                newarr[i] = arr[i]; 
            else if (i == pos - 1) 
                newarr[i] = x; 
            else
                newarr[i] = arr[i - 1]; 
        } 
  
        // print the updated array 
        //for (i = 0; i < n + 1; i++) 
           
Console.Write(newarr[n] + " "); 

// num is evenly divisible -- not prime
//Console.WriteLine("{0} : Is NOT a primenumber", + arr[k]);
break;
}
if (j== arr[k])
{
//Console.WriteLine("{0} : Is a primenumber", +arr[k]);

}
}



  
       
    } 
} 