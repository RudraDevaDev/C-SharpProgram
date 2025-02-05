class Employee {
  int eid, eage;
  String eaddress, ename;
  public Employee(int id, int age, string name, string address){
    this.eid = id;
    this.eage = age;
    this.ename = name;
    this.eaddress = address;
 }
 public void Display(){
   Console.WriteLine("employee id is: " + this.eid);
   Console.WriteLine("employee name is: " + this.ename);
   Console.WriteLine("employee age is: " + this.eage);
   Console.WriteLine("employee address is: " + this.eaddress);
 }
}
class Test{
  static void Main(string[] args){
    Employee e1 = new Employee(101, 30, "Pranaya", "Mumbai");
    Employee e2 = new Employee(101, 28, "Rout", "BBSR");
    e1.Display();
    e2.Display();
    Console.ReadKey();
   }
}
