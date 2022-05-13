using System;

class MainClass {

  public static int MathChallenge(int num) {

    // code goes here  
    int result;

    result = 1;

    if (num == 2 || num == 3 || num == 5 || num == 7 || num == 11 || num == 13)
    {
      result = 1;
    }

    else if (num > 9 && num <100)
    {
      int first = 0;
      int second = 0;
      int newNumber = 0;

      first = num / 10;
      second = num % 10;
      newNumber = (10 * second) + first;
    if (newNumber % 3 != 0 && newNumber % 2 != 0 && newNumber % 5 != 0 && newNumber % 4 != 0 && newNumber != 7)
      {
      result = 1;
      //Console.WriteLine("Nanik1");
      }
    else if (num % 3 != 0 && num % 2 != 0 && num % 5 != 0 && num % 4 != 0 && num != 7)
    {
      result = 1;
      //Console.WriteLine("Nanik2");
    }
    else
      result = 0;
      //Console.WriteLine("Nanik3");
    }

    else if (num > 100)
    {
      int first = 0;
      int second = 0;
      int third = 0;
      int newNumber1 = 0;
      int newNumber2 = 0;
      int newNumber3 = 0;
      int newNumber4 = 0;
      int newNumber5 = 0;
      int newNumber6 = 0;

      first = num / 100;
      second = num / 10;
      third = num % 10;
      newNumber1 = (third * 10) + first;
      newNumber2 = (third * 10) + second;
      newNumber3 = (second * 10) + first;
      newNumber4 = (second * 10) + third;
      newNumber5 = (first * 10) + second;
      newNumber6 = (first * 10) + third;

      if (newNumber1 % 3 != 0 && newNumber1 % 2 != 0 && newNumber1 % 5 != 0 && newNumber1 % 4 != 0 && newNumber1 != 7)
        result = 1;
      else if (newNumber2 % 3 != 0 && newNumber2 % 2 != 0 && newNumber2 % 5 != 0 && newNumber2 % 4 != 0 && newNumber2 != 7)
        result = 1;
      else if (newNumber3 % 3 != 0 && newNumber3 % 2 != 0 && newNumber3 % 5 != 0 && newNumber3 % 4 != 0 && newNumber3 != 7)
        result = 1;
      else if (newNumber4 % 3 != 0 && newNumber4 % 2 != 0 && newNumber4 % 5 != 0 && newNumber4 % 4 != 0 && newNumber4 != 7)
        result = 1;
      else if (newNumber5 % 3 != 0 && newNumber5 % 2 != 0 && newNumber5 % 5 != 0 && newNumber5 % 4 != 0 && newNumber5 != 7)
        result = 1;
      else if (newNumber6 % 3 != 0 && newNumber6 % 2 != 0 && newNumber6 % 5 != 0 && newNumber6 % 4 != 0 && newNumber6 != 7)
        result = 1;
      else
        result = 0;
    }
    return result;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(MathChallenge(Console.ReadLine()));
  } 

}
