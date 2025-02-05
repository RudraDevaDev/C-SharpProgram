class StudentMarks{
  int markEnglish;
  int markMaths;
  int markPhysics;
  public static void Main(String[] args){
    StudentMarks obj1 = new StudentMarks ();
    obj1. markEnglish = 90;
    obj1. markMaths = 80;
    obj1. markPhysics = 93;
    StudentMarks obj2 = new StudentMarks ();
    obj2. markEnglish = 95;
    obj2. markMaths = 70;
    obj2. markPhysics = 90;
    Console.WriteLine("Marks Obtained from first object:");
    Console.WriteLine(obj1. markEnglish);
    Console.WriteLine(obj1. markMaths);
    Console.WriteLine(obj1. markPhysics);
    Console.WriteLine("Marks obtained from second object:");
    Console.WriteLine(obj2. markEnglish);
    Console.WriteLine(obj2. markMaths);
    Console.WriteLine(obj2. markPhysics);
  }
}
