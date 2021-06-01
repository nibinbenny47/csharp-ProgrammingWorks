using System;
class symmetric{
	public static void Main(String [] ar){
		int[,] a=new int[3,3];
		int i,j,n;
		int c=1;
		Console.WriteLine("entr n");
		n=Convert.ToInt32(Console.ReadLine());
		for(i=0;i<n;++i){
			for(j=0;j<n;++j){
				a[i,j] = Convert.ToInt32(Console.ReadLine());

			}
			for(i=0;i<n;++i){
				for(j=0;j<n;++j){
					Console.WriteLine(a[i,j]+" ");
				}
				Console.WriteLine();
			}

			for(i=0;i<n;++i){
				for(j=0;j<n;++j){
					if(a[i,j] != a[j,i]){
						c=0;
						break;
					}
				}
			}
			if(c == 1){
				Console.WriteLine("summmmm");

			}
			else{
				Console.WriteLine("no sym");
			}

			
		}
	}
}