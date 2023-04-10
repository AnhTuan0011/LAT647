using System.ComponentModel.DataAnnotations;

namespace BTH2703.Models;
public class Employee
{
    [Key]

    public string EmployeeID { get;set;}
    
    public string EmployeeName{get;set;}

    public string EmployeeAddress{get;set;}
}