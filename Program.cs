using System;
using static System.Console;

class CreateStudents
{
    static void Main()
    {
        Student first = new Student();
        first.IdNumber = 123;
        first.LastName = "Anderson";
        first.GradePointAverage = 3.5;
        Display(first);

        Student second = new Student();
        second.IdNumber = 789;
        second.LastName = "Daniels";
        second.GradePointAverage = 4.1;
        Display(second);
    }

    static void Display(Student stu)
    {
        WriteLine($"{stu.IdNumber} {stu.LastName} {stu.GradePointAverage}");
    }
}

class Student
{
    private double gradePointAverage;
    private int idNumber;
    private string lastName;

    public const double HIGHEST_GPA = 4.0;
    public const double LOWEST_GPA = 0.0;

    public int IdNumber
    {
        get 
        {
            return idNumber; 
        }
        set 
        { 
            idNumber = value; 
        }
    }

    public string LastName
    {
        get 
        { 
            return lastName; 
        }
        set 
        { 
            lastName = value; 
        }
    }

    public double GradePointAverage
    {
        get 
        { 
            return gradePointAverage; 
        }
        set
        {
            if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
            {
                gradePointAverage = value;
            }
            else
            {
                gradePointAverage = 0.0;
            }
        }
    }
}
