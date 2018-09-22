using System;

namespace buffteks.Models
{
    public class Client
    {
        //project list
        public Client P_list {get; set;}
        //PK
        public Client P_key {get; set;}
        //first name
        public Client F_Name {get; set;}
        //last name
        public Client L_Name {get; set;}
        //phone number
        public Client Phone_Num {get; set;}
        //email
        public Client C_Email {get; set;}
        //organization
        public Client Org {get; set;}
    }
}