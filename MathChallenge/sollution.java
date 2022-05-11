import java.util.*; 
import java.io.*;

class Main {

  public static String MathChallenge(String str) {
    // code goes here 
    int strLen;
    int num1;
    int num2;
    char op;
    int result;
    List<String> newStr = new ArrayList<String>(Arrays.asList(str.split("")));

    result = 0;
    num1 = 0;
    num2 = 0;
    strLen = str.length();
    while(str.contains("("))
    {
     for(int i = 0 ; i<strLen ; i++)
      {
      if(str.charAt(i) == '(')
      {
        num1 = str.charAt(i+1) - '0';
        num2 = str.charAt(i+3) - '0';
        op = str.charAt(i+2);
        if(op == '+')
          result = num1 + num2;
        else if(op == '-')
          result = num1 - num2;
        else if (op == '*')
          result = num1 * num2;
        else if (op == '/')
          result = num1 / num2;
        newStr.remove(i+1);
        newStr.remove(i+2);
        newStr.remove(i+3);
        newStr.remove(i+4);
                newStr.set(i,Integer.toString(result)); 
        str = newStr.toString();
      }
      }
    }

      //break

    while(str.contains("*") || str.contains("/"))
    {
     for(int i = 0 ; i<strLen ; i++)
      {
      if(str.charAt(i) == '*')
      {
        num1 = str.charAt(i-1) - '0';
        num2 = str.charAt(i+1) - '0';
        result = num1 * num2;
        newStr.remove(i-1);
        newStr.remove(i+1);
        newStr.set(i , Integer.toString(result) ); 
        str = newStr.toString();
      }
      else if(str.charAt(i) == '/')
      {
        num1 = str.charAt(i-1) - '0';
        num2 = str.charAt(i+1) - '0';
        result = num1 / num2;
        newStr.remove(i-1);
        newStr.remove(i+1);
        newStr.set(i , Integer.toString(result) ); 
        str = newStr.toString();
      }
      }
    }

    //break

        while(str.contains("+") || str.contains("-"))
    {
     for(int i = 0 ; i<strLen ; i++)
      {
       if(str.charAt(i) == '+')
       {
        num1 = str.charAt(i-1) - '0';
        num2 = str.charAt(i+1) - '0';
        result = num1 + num2;
        newStr.remove(i-1);
        newStr.remove(i+1);
        newStr.set(i , Integer.toString(result)); 
        str = newStr.toString();
       }
       else if(str.charAt(i) == '-')
       {
        num1 = str.charAt(i-1) - '0';
        num2 = str.charAt(i+1) - '0';
        result = num1 - num2;
        newStr.remove(i-1);
        newStr.remove(i+1);
        newStr.set(i , Integer.toString(result) ); 
        str = newStr.toString();
       }
      }
    }
    
    return str;
  }

  public static void main (String[] args) {  
    // keep this function call here     
    Scanner s = new Scanner(System.in);
    System.out.print(MathChallenge(s.nextLine())); 
  }

}
