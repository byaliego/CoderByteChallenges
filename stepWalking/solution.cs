using System;

class MainClass {

  public static int StepWalking(int num) {

    int N1 = 1;
    int N2 = 2;
    int N3 = 0;

      if (num == 1)
        {
            N3 = 1;
        }
        
      else if (num == 2)
        {
            N3 = 2;
        }
     else
        {
            for (int i = 2; i < num; i++)
            {
                N3 = N1 + N2;
                N1 = N2;
                N2 = N3;
            }
        }  
    
          return N3;


  }

  static void Main() {  
    Console.WriteLine(StepWalking(Console.ReadLine()));
  } 

}
