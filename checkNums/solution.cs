using System;

class MainClass {

  public static int CheckNums(int num1, int num2) {

    if(num2 > num1)
    Console.WriteLine("true");
    else if(num1>num2)
    Console.WriteLine("false");
    else
    Console.WriteLine("-1");
    return num1;

  }

  static void Main() {  
    
    CheckNums(Console.ReadLine());
  } 

}
