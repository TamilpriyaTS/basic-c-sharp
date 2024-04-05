using System;
using System.Collections.Generic;
namespace CollegeApplication;

class Program
{
    public static void Main(string[] args)
    {

        List<StudentDetails> studentList = new List<StudentDetails>(); //no limited size
        string option = string.Empty;

        do
        {
        System.Console.WriteLine("Student Registration Form");

        //STUDENT x
        //OBJECT IS THE RUNTIME ENTITY
        //StudentDetails student = new StudentDetails(); //Printout form for each student
        //If line 19(object creation syntax is outside the loop, the last entered value will override the previous data rather than creating new form for each)

        
        
        // System.Console.Write("Enter Your Name: ");
        // student.StudentName = Console.ReadLine();

        // System.Console.Write("Enter Your Father Name: ");
        // student.FatherName = Console.ReadLine();

        // System.Console.Write("Enter Your Gender:");
        // student.Gender = Console.ReadLine(); 

        // System.Console.Write("Enter Your DOB dd/mm/yyy: ");
        // student.DOB = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        // System.Console.Write("Enter Your phone Number: ");
        // student.Phone = long.Parse(Console.ReadLine());

        // System.Console.Write("Enter Your Physics Mark: ");
        // student.Physics = int.Parse(Console.ReadLine());

        // System.Console.Write("Enter Your Chem Mark: ");
        // student.Chemistry = int.Parse(Console.ReadLine());

        // System.Console.Write("Enter Your Maths Mark: ");
        // student.Maths = int.Parse(Console.ReadLine());

        System.Console.Write("Enter Your Name: ");
        string studentName = Console.ReadLine();

        System.Console.Write("Enter Your Father Name: ");
        string fatherName = Console.ReadLine();

        System.Console.Write("Enter Your Gender:");
        string gender = Console.ReadLine(); 

        System.Console.Write("Enter Your DOB dd/mm/yyy: ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.Write("Enter Your phone Number: ");
        long phone = long.Parse(Console.ReadLine());

        System.Console.Write("Enter Your Physics Mark: ");
        int physics = int.Parse(Console.ReadLine());

        System.Console.Write("Enter Your Chem Mark: ");
        int chemistry = int.Parse(Console.ReadLine());

        System.Console.Write("Enter Your Maths Mark: ");
        int maths = int.Parse(Console.ReadLine());

        StudentDetails student = new StudentDetails(studentName,fatherName, gender, dob, phone, physics, chemistry, maths);
        System.Console.WriteLine("You have registered successfully. Your ID"+student.StudentID);

        studentList.Add(student); //you can create and add n number of objects based upon your computer's memory space

        //Loop Breaker
        Console.WriteLine("Do you want to continue? ");
        option = Console.ReadLine();


        }while(option=="yes");
        
        
        //*******REPLACED THE BELOW COMMENTED CODES WITH LIST METHOD ABOVE*********
        // STUDENT 2
        // //Printout form for 1st student
        // StudentDetails student1 = new StudentDetails();
        // System.Console.WriteLine("Enter Your Name: ");
        // student1.StudentName = Console.ReadLine();

        // System.Console.WriteLine("Enter Your Father Name: ");
        // student1.FatherName = Console.ReadLine();

        // System.Console.WriteLine("Enter Your Gender:");
        // student1.Gender = Console.ReadLine(); 

        // System.Console.WriteLine("Enter Your DOB dd/mm/yyy: ");
        // student1.DOB = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        // System.Console.WriteLine("Enter Your phone Number: ");
        // student1.Phone = long.Parse(Console.ReadLine());

        // System.Console.WriteLine("Enter Your Physics Mark: ");
        // student1.Physics = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Enter Your Chem Mark: ");
        // student1.Chemistry = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Enter Your Maths Mark: ");
        // student1.Maths = int.Parse(Console.ReadLine());

        // studentList.Add(student1);


        // STUDENT 2
        // //Printout form for 2nd student
        // StudentDetails student2 = new StudentDetails();
        // System.Console.WriteLine("Enter Your Name: ");
        // student2.StudentName = Console.ReadLine();

        // System.Console.WriteLine("Enter Your Father Name: ");
        // student2.FatherName = Console.ReadLine();

        // System.Console.WriteLine("Enter Your Gender:");
        // student2.Gender = Console.ReadLine(); 

        // System.Console.WriteLine("Enter Your DOB dd/mm/yyy: ");
        // student2.DOB = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        // System.Console.WriteLine("Enter Your phone Number: ");
        // student2.Phone = long.Parse(Console.ReadLine());

        // System.Console.WriteLine("Enter Your Physics Mark: ");
        // student2.Physics = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Enter Your Chem Mark: ");
        // student2.Chemistry = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Enter Your Maths Mark: ");
        // student2.Maths = int.Parse(Console.ReadLine());

        // studentList.Add(student2);

       Console.WriteLine("Enter your student id to login:");
       string loginID = Console.ReadLine().ToUpper();


        foreach(StudentDetails student in studentList)
        {
            if(loginID == student.StudentID)
            {
                Console.WriteLine($"Your Name: {student.StudentName}");
                Console.WriteLine($"Your Father's Name: {student.FatherName}");
                Console.WriteLine($"Your Gender: {student.FatherName}");
                Console.WriteLine($"Your DOB: {student.DOB}");
                Console.WriteLine($"Your Phone: {student.Phone}");
                Console.WriteLine($"Your Physics: {student.Physics}");
                Console.WriteLine($"Your DOB: {student.Chemistry}");

                bool eligibility = student.CheckEligibilty(75); //Calling the method with .object because it is a non static method
                if(eligibility)
                {
                    Console.WriteLine("You are eligible for admission");
                }
                else
                {
                    Console.WriteLine("You are not eligible for admission");
                }
            }
            else
            {
                Console.WriteLine("Invalid User ID");
            }
        

        //*******REPLACED THE BELOW COMMENTED CODES WITH FOREACH LOOP ABOVE*********
        // Console.WriteLine($"Your Name: {student2.StudentName}");
        // Console.WriteLine($"Your Father's Name: {student2.FatherName}");
        // Console.WriteLine($"Your Gender: {student2.FatherName}");
        // Console.WriteLine($"Your DOB: {student2.DOB}");
        // Console.WriteLine($"Your Phone: {student2.Phone}");
        // Console.WriteLine($"Your Physics: {student2.Physics}");
        // Console.WriteLine($"Your DOB: {student2.Chemistry}");

        // Console.WriteLine($"Your Name: {student3.StudentName}");
        // Console.WriteLine($"Your Father's Name: {student3.FatherName}");
        // Console.WriteLine($"Your Gender: {student.FatherName}");
        // Console.WriteLine($"Your DOB: {student3.DOB}");
        // Console.WriteLine($"Your Phone: {student3.Phone}");
        // Console.WriteLine($"Your Physics: {student3.Physics}");
        // Console.WriteLine($"Your DOB: {student3.Chemistry}");

        
        }

        

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("code ending");


        

    }
}