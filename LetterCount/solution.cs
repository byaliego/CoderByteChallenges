using System;

class MainClass {

  public static string SearchingChallenge(string str) {

      char[] seperators = {':',' ', ',',';','.','!','?'};
      string [] words = str.Split(seperators);
      int counter = 0;
      string result = "-1";

      
      foreach (string word in words){
        for(int a = 0; a < word.Length;a++){  
          int counterNew = 0;
          for(int b = a+1 ; b< word.Length; b++ ){
            if(word[a] == word[b])
            counterNew += 1;
          }
          if(counterNew>counter){
            counter = counterNew;
            result = word;
          }
        }
      }
      return result;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(SearchingChallenge(Console.ReadLine()));
  } 

}
