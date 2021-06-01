using System;

class marklist{
	public int rollNo;
	public double m1,m2,m3,total,per;
	public string grade,name;
	
	public void inputDetails(){
		Console.WriteLine("entr roll no");
		rollNo=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("entr name");
		name=Console.ReadLine();
		Console.WriteLine("marks of 3 subjects");
		m1=Convert.ToDouble(Console.ReadLine());
		m2=Convert.ToDouble(Console.ReadLine());
		m3=Convert.ToDouble(Console.ReadLine());
	}
	
	public void calculateData(){
		total=m1+m2+m3;
		per=(total/300)*100;
		if(per>=80){
			grade="A";
		}
		else if(per>=60){
			grade="B";
		}
		else if(per>=50){
			grade="C";
		}
		else{
			grade="D";
		}

	}
	

	public void displayRecord(){            
		Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",rollNo,name,m1,m2,m3,total,per,grade);
	
		
	}
}

class ArrayOfObject{
	public static void Main(String [] ar){

		int i,n,j,searchRollNo;
		int flag=0;
		//double temp,tempm1,tempm2,tempm3,tempper;
		
		//string tempname,tempgrade;
		

		Console.WriteLine("Enter Number of Studetns");
		n=Convert.ToInt32(Console.ReadLine());

		marklist[] obj= new marklist[n];
		marklist temp= new marklist();

		Console.WriteLine("Enter Details");

		for(i=0;i<n;i++)
		{
			obj[i]=new marklist();

			obj[i].inputDetails();
			obj[i].calculateData();
		}

		Console.WriteLine("Roll\tName\tM1\tM2\tM3\tTotal\t%\tGrade");
	
		for(i=0;i<n;i++)
		{
			
			obj[i].displayRecord();
		}
		Console.WriteLine("----search details of student using rollno-----");
		Console.WriteLine("Enter rollno to search");
		searchRollNo=Convert.ToInt32(Console.ReadLine());
		

		for(i=0;i<n;++i){
			if(obj[i].rollNo == searchRollNo){
				flag=1;
				break;
			}

		}

		if(flag==1){
			Console.WriteLine("-----Rollno found----");
			Console.WriteLine("----Details of student of rollNo{0}",searchRollNo);
			Console.WriteLine("Roll\tName\tM1\tM2\tM3\tTotal\t%\tGrade");
			Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",obj[i].rollNo,obj[i].name,obj[i].m1,obj[i].m2,obj[i].m3,obj[i].total,obj[i].per,obj[i].grade);
		}
		else{
			Console.WriteLine("-------no such-----");
		}
		Console.WriteLine("--Sort By RankList---");
		for(i=0;i<n;++i){
			for(j=i+1;j<n;++j){
				if(obj[i].total < obj[j].total){
					temp=obj[i];
					obj[i]=obj[j];
					obj[j]=temp;
					// tempname=obj[i].name;
					// obj[i].name=obj[j].name;
					// obj[j].name=tempname;
					// tempm1=obj[i].m1;
					// obj[i].m1=obj[j].m1;
					// obj[j].m1=tempm1;
					// tempm2=obj[i].m2;
					// obj[i].m2=obj[j].m2;
					// obj[j].m2=tempm2;
					// tempm3=obj[i].m3;
					// obj[i].m3=obj[j].m3;
					// obj[j].m3=tempm3;
					// tempper=obj[i].per;
					// obj[i].per=obj[j].per;
					// obj[j].per=tempper;
					// tempgrade=obj[i].grade;
					// obj[i].grade=obj[j].grade;
					// obj[j].grade=tempgrade;

					//Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",obj[i].rollNo,obj[i].name,obj[i].m1,obj[i].m2,obj[i].m3,obj[i].total,obj[i].per,obj[i].grade);
				}
			}
		}
		Console.WriteLine("--new student table---");
		Console.WriteLine("Roll\tName\tM1\tM2\tM3\tTotal\t%\tGrade");
	
		for(i=0;i<n;i++)
		{
			
			obj[i].displayRecord();
		}

		


	}
}