public class MyClass{
  public static void Main(){
    int num1 = 6;
    int num2 = 23;
    int res = num1 + num2;
    if (res > 25){
      res = res - 5;
      Console.WriteLine("Result is more then 25");
    }
    else{
      res = 25;
      Console.WriteLine("Result is less then 25");  
    }
    bool b = true;
    if (res > 25 || b)
      Console.WriteLine("Res > 25 or b is true");
    else if ( (res>25) && !b )
      Console.WriteLine("Res > 25 and b is false");
    else
      Console.WriteLine("else condition");
  
  }
}
