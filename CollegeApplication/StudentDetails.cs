using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeApplication
{
    public class StudentDetails
    {
        
        
        //Events
        //Indexers
       
        //Field - attributes(information storing) it's a secured element and stored in private (_camelCasing)
        private static int s_studentID=1000;
        //When declared as static and added s_, this field, _studentID will be common to all and values will increment from the previously altered value, else it will increment from it's original value (i.e., 1000)


        //Properties - a transaction element declared in public (PascalCasing)
        public string StudentID{ get; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }


        //Default Constructors
        //first, object is created and form is filles.
        public StudentDetails()
        {
            StudentName = "Enter Name:"; //Placeholder
            FatherName = "Enter FatherName";
            Gender = "Enter Gender";
        }

        //Parameterised Constructors
        //This is used in cases like filling online application, where the user enters their data first online  - the data stores in local variables first and when this constructor is called, a new form(object) is generated and added in it.
        //first, the data is collected and objected is created
        public StudentDetails(String studentName, string fatherName, string gender, DateTime dob, long phone, int physics,int chemistry, int maths)
        {
            
            s_studentID++;
            StudentID="SF"+s_studentID;

            //Assign parameter values to properties
            StudentName = studentName;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        //CONSTRUCTOR OVERLOADING: Having more constructors of the same name but different parameters

        ~StudentDetails()
        {
            System.Console.WriteLine("destructor called");
        }

        //METHODS
        public bool CheckEligibilty(double cutoff)
        {
            double average = (double)(Physics+Chemistry+Maths)/3;
            if(average>=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    



    }
}
//Epdi nalum default value dhan irukum...then why default constructor?