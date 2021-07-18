using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessing
{
    class Student
    {
        string firstName; //default visibility is private
        public string FirstName // property
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => id; set => id = value; }
        public int Test1 { get => test1; set => test1 = value; }
        public int Test2 { get => test2; set => test2 = value; }

        public string Major { get => major; set => major = value; }

        public string Degree { get => degree; set => degree = value; }
        public double Gpa { get => gpa; set => gpa = value; }
        public string Grade { get; set; }

        double gpa;
        private string lastName;

        int id;
        string major;
        string degree;
        int test1;
        int test2;

        public string ComputeGrade()
        {
            try
            {
                string grade = "";
                //if ((test1 == 0) || test2 == 0)
                //    throw new Exception("test score is 0");
                //double avg = 0.6 * test1 + 0.4 * test2;
                double avg = MyCompute.ComputeWeightedAvg(major, test1, test2);
                if (avg >= 93)
                    grade = "A";
                else if (avg >= 90)
                    grade = "A-";
                else if (avg >= 87)
                    grade = "B+";
                else if (avg >= 83)
                    grade = "B";
                else if (avg >= 80)
                    grade = "B-";
                else if (avg >= 77)
                    grade = "C+";
                else if (avg >= 73)
                    grade = "C";
                else if (avg >= 70)
                    grade = "C-";
                else if (avg >= 67)
                    grade = "D+";
                else if (avg >= 63)
                    grade = "D";
                else if (avg >= 60)
                    grade = "D-";
                else
                    grade = "F";

                return grade;
            }catch (Exception)
            {
                throw; // throw;
            }
        }

        public override string ToString()
        {
            return firstName + " "+lastName + " "+id.ToString()+" "+test1.ToString()+" "+test2.ToString();
        }

    }//end of class
}//end of namespace
