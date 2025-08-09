using System;

  namespace ActivityExample
    (
          public class Demo1
          (
              string name = "Mark";
              int number = 8;
              bool isStudent = False;
              char myChar = 'H';
              name = "Dela Cruz";
              double myDouble = 8.90;
            
              long longInteger = number;

              myDouble = myNumber; 
            
              number = Convert.ToInt32(myDouble);

              int even = 13 % 4; //1
            
              const string myConst = "Hello";
            
          )
    )


    
using System;

public class Demo
{
	public static void Main()
		{		
			int myNum = 5;
			myNum += 10; //15
			
			int myNum2 = 7;
			myNum2 -= 2; //5
			
			Console.WriteLine("This is the value of myNum: " + myNum);
			Console.WriteLine("This is the value of myNum2: " + myNum2);
			Console.ReadKey();				  
					
		}
}


using System;

class HelloWorld
{
	public static void Main()
		{		
			int myNum = 5;
			int myNum2 = 7;
			myNum += 10; //15
		
			Console.WriteLine(myNum > myNum2);
			Console.WriteLine(myNum2 > myNum);
			Console.WriteLine(myNum < myNum2);
			Console.WriteLine(myNum == myNum2);
			Console.WriteLine(myNum != myNum2);
		}
}


using System;

class HelloWorld
{
	public static void Main()
		{		
			int gradeMidterm = 85;
			int gradePrelim = 90;
		
			if (gradeMidterm > gradePrelim)
			{
				Console.WriteLine("Midterm is greater than prelim");
		    }
			else 
			{
				Console.WriteLine("Prelim is greater than midterm");
			}
		
		}
}
	
