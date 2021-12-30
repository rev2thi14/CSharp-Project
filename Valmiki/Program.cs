﻿using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails ChinnaStudentDetails = new StudentDetails(1001, "Chinna", "c#");
            StudentDetails RaviStudentDetails = new StudentDetails(1002, "Ravi", "ASP.NET");
            ChinnaStudentDetails.Payment(200);
            RaviStudentDetails.Payment(100);
            ChinnaStudentDetails.Print();

            Console.WriteLine("\n");


           RaviStudentDetails.Print();
        }
    }
    class StudentDetails
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string CourseJoined { get; set; }
        public int FeePaidSoFar { get; set; }
        public int DueAmount
        {
            get
            {
                return TotalFee - FeePaidSoFar;
            }
        }
        public int TotalFee
        {
            get
            {
                if (CourseJoined.ToLower() == "c#")
                    return 2000;
                else if (CourseJoined.ToLower() == "asp.net")
                    return 3000;
                return 0;
            }
        }
public StudentDetails(int rollNo, string name, string courseJoined)
        {
            RollNo = rollNo;
            Name = name;
            CourseJoined = courseJoined;
        }
        public void Payment(int amount)
        {
            FeePaidSoFar += amount;
        }
public void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Course Joined: {CourseJoined}");
            Console.WriteLine($"Total Fee: {TotalFee}");
            Console.WriteLine($"Fee Paid So Far: {FeePaidSoFar}");
            Console.WriteLine($"Due Amount: {DueAmount}");
        }
    }
}
    
    

