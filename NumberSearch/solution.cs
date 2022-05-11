using System;

class MainClass {

  public static string SearchingChallenge(string str) {

      double length = str.Length;
      double sum = 0;
      string numbers = "0123456789";
      double result = 0;
      double resultRounded = 0;
      string message = "";

      for( int i=0 ; i<length ; i++ )
      {
        if(numbers.Contains(str[i]))
        {
          sum = sum + (str[i] - '0');
        }
      }
      result = sum/length;
      resultRounded = Math.Round(result);
      message = resultRounded.ToString();
      return message;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(SearchingChallenge(Console.ReadLine()));
  } 

}
