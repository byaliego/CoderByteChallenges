using System;

class MainClass {

  public static int MathChallenge(int num1, int num2) {

    // code goes here  
    int gcd;

    gcd = 1;

    while (num1 != 1 && num2 != 1)
    {
      if(num1 % 2 == 0 && num2 % 2 == 0)
      {
        num1 = num1 / 2;
        num2 = num2 / 2;
        gcd = gcd * 2;
      }
      else if (num1 % 2 == 0 && num2 % 2 != 0)
      {
        num1 = num1 / 2;
      }
      else if (num1 % 2 != 0 && num2 % 2 == 0)
      {
        num2 = num2 / 2;
      }

      if(num1 % 3 == 0 && num2 % 3 == 0)
      {
        num1 = num1 / 3;
        num2 = num2 / 3;
        gcd = gcd * 3;
      }
      else if (num1 % 3 == 0 && num2 % 3 != 0)
      {
        num1 = num1 / 3;
      }
      else if (num1 % 3 != 0 && num2 % 3 == 0)
      {
        num2 = num2 / 3;
      }

      if(num1 % 5 == 0 && num2 % 5 == 0)
      {
        num1 = num1 / 5;
        num2 = num2 / 5;
        gcd = gcd * 5;
      }
      else if (num1 % 5 == 0 && num2 % 5 != 0)
      {
        num1 = num1 / 5;
      }
      else if (num1 % 5 != 0 && num2 % 5 == 0)
      {
        num2 = num2 / 5;
      }
      //xxx
      if(num1 % 7 == 0 && num2 % 7 == 0)
      {
        num1 = num1 / 7;
        num2 = num2 / 7;
        gcd = gcd * 7;
      }
      else if (num1 % 7 == 0 && num2 % 7 != 0)
      {
        num1 = num1 / 7;
      }
      else if (num1 % 7 != 0 && num2 % 7 == 0)
      {
        num2 = num2 / 7;
      }
      //xxx11
      if(num1 % 11 == 0 && num2 % 11 == 0)
      {
        num1 = num1 / 11;
        num2 = num2 / 11;
        gcd = gcd * 11;
      }
      else if (num1 % 11 == 0 && num2 % 11 != 0)
      {
        num1 = num1 / 11;
      }
      else if (num1 % 11 != 0 && num2 % 11 == 0)
      {
        num2 = num2 / 11;
      }

      if(num1 % 13 == 0 && num2 % 13 == 0)
      {
        num1 = num1 / 13;
        num2 = num2 / 13;
        gcd = gcd * 13;
      }
      else if (num1 % 13 == 0 && num2 % 13 != 0)
      {
        num1 = num1 / 13;
      }
      else if (num1 % 13 != 0 && num2 % 13 == 0)
      {
        num2 = num2 / 13;
      }

      if(num1 % 17 == 0 && num2 % 17 == 0)
      {
        num1 = num1 / 17;
        num2 = num2 / 17;
        gcd = gcd * 17;
      }
      else if (num1 % 17 == 0 && num2 % 17 != 0)
      {
        num1 = num1 / 17;
      }
      else if (num1 % 17 != 0 && num2 % 17 == 0)
      {
        num2 = num2 / 17;
      }

      if(num1 % 19 == 0 && num2 % 19 == 0)
      {
        num1 = num1 / 19;
        num2 = num2 / 19;
        gcd = gcd * 19;
      }
      else if (num1 % 19 == 0 && num2 % 19 != 0)
      {
        num1 = num1 / 19;
      }
      else if (num1 % 19 != 0 && num2 % 19 == 0)
      {
        num2 = num2 / 19;
      }
    }
    return gcd;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(MathChallenge(Console.ReadLine()));
  } 

}
