// Title: Employee Management System
// Author : Arularasi
// Created at : 01/10/2022
// Updated at : 
// Reviewed by: 
// Reviewed at: 
using System;
class PersonalDetails{
  private string? firstName;
  private string? lastName;
  
  
  public string FirstName{
    get{  return firstName; }
    set{
      firstName = value;
    }
  }
  public string LastName{
    get{  return lastName; }
    set{
      lastName = value;
    }
  }
}

class EmployeeManagementSystem:PersonalDetails{
  private int EmployeeId;
  public static string CompanyName = "Aspire Systems";
  public int Id{
    get{ return EmployeeId; }
    set{
      EmployeeId = value;
    }
  }
}