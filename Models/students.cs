using System;

namespace buffteks.Models
{
    public class Students
    {
        public class Student 
        {
            //PK
            public Student PrimaryKey {get; set;}
            //first name
            public Student F_Name {get; set;}
            //last name
            public Student L_Name {get; set;}
            //phone
            public Student PhoneNumber {get; set;}
            //email
            public Student Email {get; set;}
            //role 
            public Student S_roles {get; set;}
        }
    }
}
