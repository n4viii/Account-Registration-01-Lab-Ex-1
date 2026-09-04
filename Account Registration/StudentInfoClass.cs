using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{
    // Delegates matching Step 3 requirements
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);

    public class StudentInfoClass
    {
        // Static Variables
        public static string FirstName = string.Empty;
        public static string LastName = string.Empty;
        public static string MiddleName = string.Empty;
        public static string Address = string.Empty;
        public static string Program = string.Empty;

        public static int Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        // Static Methods accepting parameters to match delegates
        public static string GetFirstName(string txt) => FirstName;
        public static string GetLastName(string txt) => LastName;
        public static string GetMiddleName(string txt) => MiddleName;
        public static string GetAddress(string txt) => Address;
        public static string GetProgram(string txt) => Program;

        public static long GetAge(long number) => Age;
        public static long GetContactNo(long number) => ContactNo;
        public static long GetStudentNo(long number) => StudentNo;
    }
}