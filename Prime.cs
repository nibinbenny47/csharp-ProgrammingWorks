using System;
class Prime{
public static void Main(String[] ar){

int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13};
int[] a=new int[20];
int[] b=new int[20];
Console.WriteLine("*********Pick prime numbers from the given array *********************\n");

int j;
//Iterate through the items of array
for (int i = 0; i < nums.Length; i++)
{

// see if num is evenly divisible
for ( j = 2; j < nums[i]; j++)
if((nums[i]%j ==0))
{

// num is evenly divisible -- not prime
Console.WriteLine("{0} : Is NOT a primenumber", + nums[i]);
break;
}
if (j== nums[i])
{
Console.WriteLine("{0} : Is a primenumber", +nums[i]);

}
}


}
}
