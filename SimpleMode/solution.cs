using System;

class MainClass {

  public static int ArrayChallenge(int[] arr) {

    // code goes here  
    int counter;
    int repeated;
    int winner;

    repeated = 1;
    winner = 0;

    for(int i = 0 ; i<arr.Length ; i++)
    {
      counter = 0;
      for(int j = 0 ; j<arr.Length ; j++)
      {
        if (arr[i] == arr[j])
        {
          counter++;
        }
      }
      if(counter > repeated)
      {
          repeated = counter;
          winner = arr[i];
      }
    }

    if (repeated == 1)
      winner = -1;

    return winner;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(ArrayChallenge(Console.ReadLine()));
  } 

}
