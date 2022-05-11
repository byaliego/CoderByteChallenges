import java.util.*; 
import java.io.*;

class Main {

  public static String StringChallenge(int num) {
    // code goes here  
    int hour;
    int minute;
    String result;

    hour = 0;
    minute = 0;
    result="";
    if(num>59)
    {
      hour = num/60;
      minute = num%60;
    }
    else
    {
      minute = num;
    }
      result = hour + ":" + minute;

    return result;
  }

  public static void main (String[] args) {  
    // keep this function call here     
    Scanner s = new Scanner(System.in);
    System.out.print(StringChallenge(s.nextLine())); 
  }

}
