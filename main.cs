using System;

class MainClass {
  public static void Main (string[] args) {

   // TODO: get the user salary, and then print out if they will get a bonus or not
   // if salary = 1200, then you get a 20% bonus 

     int yearsOfService;


     
     Console.WriteLine("Please Enter years Of service");
     yearsOfService = int.Parse(Console.ReadLine());
     
     if (yearsOfService>=9) 
     {
      
      Console.WriteLine($"Your Bonus is 5%");

     }

     else if (yearsOfService>=5 && yearsOfService <9 )
     {

      Console.WriteLine($"Your Bonus is 15%");

     }

     else if (yearsOfService>=2 && yearsOfService <5 )
     {

      Console.WriteLine($"Your Bonus is 25%");

     }

     else
     {

         Console.WriteLine("Sorry, no bonus!"); 

     }

  }
}