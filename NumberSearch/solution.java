import java.util.*; 
import java.io.*;

class Main {

  public static int SearchingChallenge(String str) {
    // code goes here
    int number;
    int result;
    int strLen;
    int letter;

    strLen = str.length();
    number = 0;
    letter = 0;
    for(int i = 0 ; i < strLen ; i++)
    {
        if(Character.isDigit(str.charAt(i)))
        {
          //System.out.print("I am digit in string:" + str.charAt(i) + "\n");
          number = number + (str.charAt(i) - '0');
        }       
        else if(Character.isLetter(str.charAt(i)))
        {
          letter = letter + 1;
        }
    } 
    //System.out.print("this is number:" + number + "\n");
    result = (int)Math.rint(number/letter);
    return result;
  }

  public static void main (String[] args) {  
    // keep this function call here     
    Scanner s = new Scanner(System.in);
    System.out.print(SearchingChallenge(s.nextLine())); 
  }

}
