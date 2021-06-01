using System;
 class Bank{
 	public string name;
 	public double amount,ac_no;
    // public balance=0;

 	public void inputdata(){
 		Console.WriteLine("Enter Account NO:");
 		ac_no=Convert.ToDouble(Console.ReadLine());
 		Console.WriteLine("Enter Name ");
 		name=Console.ReadLine();
 		Console.WriteLine(" Amount available in Account");
 		amount=Convert.ToDouble(Console.ReadLine());

 	}
 	public void displaydata(){
 		Console.WriteLine("{0}\t{1}\t{2}",ac_no,name,amount);

 	}
 	// public void deposit(){
 	// 	amount=amount+deposit_amount ;
 	// 	Console.WriteLine("{0}\t{1}\t{2}\t{3}",ac_no,name,amount);
 	// }
 	// public void withdraw(){
 	// 	amount=amount-withdraw_amount ;
 	// 	Console.WriteLine("{0}\t{1}\t{2}\t{3}",ac_no,name,amount);
 	// }

 }




class BankingSystem{
	public static void Main(String [] ar){
		int n,i;
		int choice;
        String continue_or_not;
		int flag=0;
		// double balance=0;
		double account_no,deposit_amount,withdraw_amount;
		Console.WriteLine("Enter NO. of data to insert");
		n=Convert.ToInt32(Console.ReadLine());
		Bank[] obj= new Bank[n];
		for(i=0;i<n;++i){
			obj[i]= new Bank();
			obj[i].inputdata();
		}
		Console.WriteLine("Ac_NO\tName\tAmount");
		for(i=0;i<n;++i){
			obj[i].displaydata();
		}
		Console.WriteLine("---search data using account no---");
		Console.WriteLine("enter account no");
		account_no=Convert.ToDouble(Console.ReadLine());
		for(i=0;i<n;++i){
			if(obj[i].ac_no== account_no){
				flag=1;
				break;
			}

		}
		if(flag ==1){
			Console.WriteLine("Ac_NO\tName\tAmount");
			obj[i].displaydata();
		}
		else{
			Console.WriteLine("No such data ffound");
		}
	do{
		Console.WriteLine("1:Deposit\t2:Withdrawal\t3:exit");
		Console.WriteLine("Enter choice");
		choice=Convert.ToInt32(Console.ReadLine());
		

		
		switch(choice){
			case 1:
			Console.WriteLine("Enter amount to deposit");
			deposit_amount=Convert.ToDouble(Console.ReadLine());
			obj[i].amount=obj[i].amount+deposit_amount;
			Console.WriteLine("Ac_NO\tName\tAmount");
			 Console.WriteLine("{0}\t{1}\t{2}",obj[i].ac_no,obj[i].name,obj[i].amount);
			 // obj[i].deposit();
			// Console.WriteLine("Account no{0}",obj[i].ac_no);
		
			// balance=balance+obj[i].amount+deposit_amount ;
			// Console.WriteLine("balance amount is {0}",balance);

			
			break;
			case 2:
			Console.WriteLine("Enter amount to withdraw");
			withdraw_amount=Convert.ToDouble(Console.ReadLine());
			obj[i].amount=obj[i].amount-withdraw_amount;
			Console.WriteLine("Ac_NO\tName\tAmount");
			Console.WriteLine("{0}\t{1}\t{2}",obj[i].ac_no,obj[i].name,obj[i].amount);
			// obj[i].withdraw();
			// balance=balance+obj[i].amount-withdraw_amount;
			// Console.WriteLine("balance amount is {0}",balance);
			

			break;
			
			default:
			Console.WriteLine("Your input is invalid");
			break;
		}
			Console.WriteLine("Do you want to continue?Y/N");
			continue_or_not=Console.ReadLine();
		}
		
		while(continue_or_not== "Y");

		

	}
}