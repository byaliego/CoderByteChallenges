import java.util.*; 
import java.io.*;

class Main {

  public static String StringChallenge(String str) {
    // code goes here 
  int counter = 1;
  String newone = "";
  char c = str.charAt(0);
  for(int i = 1 ; i<str.length(); i++)
  {
    if(str.charAt(i) == c)
      counter++;
    else
    {
        newone = newone + counter + "" + c;
        c = str.charAt(i);
        counter = 1;
    }
      
  }

      
    newone = newone + counter + "" + c;
    return newone;
  }

  public static void main (String[] args) {  
    // keep this function call here     
    Scanner s = new Scanner(System.in);
    System.out.print(StringChallenge(s.nextLine())); 
  }

}
