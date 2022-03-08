using System;

class MainClass {

  public static string Reverse(string text)
{
    char[] cArray = text.ToCharArray();
    string reverse = String.Empty;
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }
    return reverse;
}
  
  public static  string PalindromeTwo(string str) {

    string str1 = str.Replace(" ","");
    string str2 = str1.Replace("-","");
    string strNew = Reverse(str2);
    string strNewL = strNew.ToLower();
    string strLow = str2.ToLower();

  

    if(String.Compare(strNewL, strLow)==0)
    Console.WriteLine("true");
    else if(String.Compare(strNewL, strLow)!=0)
    Console.WriteLine("false");
   
    return str;
  }

  static void Main() {  
    
    PalindromeTwo(Console.ReadLine());
  } 

}
