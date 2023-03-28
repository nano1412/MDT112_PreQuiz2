using System;

  public class Program{
    static void Main(string[] args){
      int number1 = 1;
      int number2 = 2;
      int number3 = 3;
      int number4 = 4;
      int number5 = 5;
      int number6 = 6;
      int number7 = 7;
      int number8 = 8;

      int maxof8 = Max8(number1,number2,number3,number4,number5,number6,number7,number8);
      Console.WriteLine(maxof8);

    }
    static int Max8(int num1, int num2,int num3, int num4,int num5, int num6,int num7, int num8){
      int a = Max4(num1,num2, num3, num4);
      int b = Max4(num5,num6, num7, num8);
      return Max2(a,b);
    }

    public static int Max4(int num1, int num2,int num3, int num4){
      int x = Max2(num1, num2);
      int y = Max2(num3, num4);
      return Max2(x,y);
    }

    public static int Max2(int num1, int num2){
      if(num1 > num2){
        return num1;
      }
      return num2;

    }

    public static bool Is2NumberEqual(int num1,int num2){
      if(num1 == num2){
        return true;
      }
      return false;
    }

  }