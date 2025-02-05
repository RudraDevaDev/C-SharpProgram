using System;
class Branch{
    int BranchCode;
    string? BranchName, BranchAddress;
    public void GetBranchData(){
        Console.WriteLine("ENTER BRANCH DETAILS");
        Console.WriteLine("\nEnter Branch Code: ");
        BranchCode = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Branch Name: ");
        BranchName = Console.ReadLine();
        Console.WriteLine("Enter Branch Address: ");
        BranchAddress = Console.ReadLine();
    }
    public void DisplayBranchData(){
        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("BRANCH DETAILS");
        Console.WriteLine("BRANCH CODE IS : " + BranchCode);
        Console.WriteLine("BRANCH NAME IS : " + BranchName);
        Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
        Console.WriteLine("--------------------------------");
    }
 }
 class Employee : Branch{
    int EmployeeId, EmployeeAge;
    string? EmployeeName, EmployeeAddress;
    public void GetEmployeeData(){
        Console.WriteLine("\nENTER EMPLYEE DETAILS");
        Console.WriteLine("\nEnter Employee ID: ");
        EmployeeId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Age: ");
        EmployeeAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name: ");
        EmployeeName = Console.ReadLine();
        Console.WriteLine("Enter Employee Address: ");
        EmployeeAddress = Console.ReadLine();
    }
    public void DisplayEmployeeData(){
        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("EMPLOYEE DETAILS");
        Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
        Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
        Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
        Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
        Console.WriteLine("--------------------------------");
    }
}
class Program{
    static void Main(string[] args){
        Employee obj1 = new Employee();
        obj1.GetBranchData();
        obj1.GetEmployeeData();
        obj1.DisplayBranchData();
        obj1.DisplayEmployeeData();
        Console.WriteLine("\nPress Any Key To Exit.");
        Console.ReadKey();
    }
}
