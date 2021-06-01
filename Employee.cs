using System;

class EmployeeDetails{
	public int empid;
	public double BasicSalary;
	public string name,department;
	public double DA,HRA,TA,LIC,PF,NetSalary;
	
	public void inputDetails(){
		Console.WriteLine("entr Employee id");
		empid=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter name");
		name=Console.ReadLine();
		Console.WriteLine("enter Employee department");
		department=Console.ReadLine();
		Console.WriteLine("Enter Basic Salary");
		BasicSalary=Convert.ToDouble(Console.ReadLine());
		
	}
	
	public void CalculateNetsalary(){
		if(BasicSalary >=15000){
			TA=(40/BasicSalary) * 100;
			DA=(35/BasicSalary)*100;
			HRA=(30/BasicSalary)*100;
			LIC=(15/BasicSalary)*100;
			PF=(10/BasicSalary)*100;
		}
		else if(BasicSalary >=10000){
			TA=(35/BasicSalary) * 100;
			DA=(30/BasicSalary)*100;
			HRA=(25/BasicSalary)*100;
			LIC=(5/BasicSalary)*100;
			PF=(8/BasicSalary)*100;
		}
		else if(BasicSalary >=5000){
		TA=(30/BasicSalary) * 100;
			DA=(25/BasicSalary)*100;
			HRA=(20/BasicSalary)*100;
			LIC=(5/BasicSalary)*100;
			PF=(6/BasicSalary)*100;
		}
		else{
			TA=(25/BasicSalary) * 100;
			DA=(20/BasicSalary)*100;
			HRA=(15/BasicSalary)*100;
			LIC=(5/BasicSalary)*100;
			PF=(3/BasicSalary)*100;
		}
		NetSalary=BasicSalary+TA+DA+HRA+LIC+PF;
	}
	
	

	public void displayRecord(){            
		Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}",empid,name,department,BasicSalary,TA,DA,HRA,LIC,PF,NetSalary);
	
		
	}
}

class Employee{
	public static void Main(String [] ar){

		int i,n,j;
		int searchEmpid;
		int flag=0;
		// //double temp,tempm1,tempm2,tempm3,tempper;
		// int temp;
		// string tempname,tempgrade;
		

		Console.WriteLine("Enter Number of Employee");
		n=Convert.ToInt32(Console.ReadLine());

		EmployeeDetails[] obj= new EmployeeDetails[n];
		EmployeeDetails temp=new EmployeeDetails() ;
		

		Console.WriteLine("Enter Details");

		for(i=0;i<n;i++)
		{
			obj[i]=new EmployeeDetails();

			obj[i].inputDetails();
			obj[i].CalculateNetsalary();
		}

		Console.WriteLine("empid\tName\tDepartment\tsalary\tTA\tDA\tHRA\tLIC\tPF\tNetSalary");
	
		for(i=0;i<n;i++)
		{
			
			obj[i].displayRecord();
		}
		 Console.WriteLine("----search details of student using rollno-----");
		 Console.WriteLine("Enter empid to search");
		 searchEmpid=Convert.ToInt32(Console.ReadLine());
		

		for(i=0;i<n;++i){
			if(obj[i].empid == searchEmpid){
				flag=1;
				break;
			}

		 }

		if(flag==1){
			Console.WriteLine("-----Empid found----");
			Console.WriteLine("----Details of Employee of Empid{0}",searchEmpid);
		Console.WriteLine("empid\tName\tDepartment\tsalary\tTA\tDA\tHRA\tLIC\tPF\tNetSalary");
		Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}",obj[i].empid,obj[i].name,obj[i].department,obj[i].BasicSalary,obj[i].TA,obj[i].DA,obj[i].HRA,obj[i].LIC,obj[i].PF,obj[i].NetSalary);
		}
		else{
			Console.WriteLine("-------no such-----");
		}
		Console.WriteLine("--sort by highest to lowest salary--");
		for(i=0;i<n;++i){
			for(j=i+1;j<n;++j){
				if(obj[i].NetSalary <obj[j].NetSalary){
					temp=obj[i];
					obj[i]=obj[j];
					obj[j]=temp;
				}

			}
		}
		for(i=0;i<n;i++)
		{
			
			obj[i].displayRecord();
		}

		


	}
}