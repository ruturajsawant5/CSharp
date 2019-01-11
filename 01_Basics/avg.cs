using D=System.Console;

class alias {
	public static void Main(string[] a){
		D.WriteLine("Enter Roll No :");
		int rollNo=int.Parse(D.ReadLine());
					

		D.WriteLine("Enter Name :");
		string name=D.ReadLine();

			
		D.WriteLine("Enter Marks of five subjetcs one by one :");
		int sub1=int.Parse(D.ReadLine());
		int sub2=int.Parse(D.ReadLine());
		int sub3=int.Parse(D.ReadLine());
		int sub4=int.Parse(D.ReadLine());
		int sub5=int.Parse(D.ReadLine());




		int total = sub1+sub2+sub3+sub4+sub5;
		double avg=total/5;

		D.WriteLine("Roll No :"+rollNo);
		D.WriteLine("Name :"+name);
		D.WriteLine("Average :"+avg);

	}
}

//C:\Windows\Microsoft.NET\Framework64\v3.5