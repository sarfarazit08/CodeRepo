using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Fees_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            //students.Add();

        }
    }

    public class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int rollno;

        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        }
        private int calculateFee;

        public int CalculateFee
        {
            get { return calculateFee; }
            set { calculateFee = value; }
        }
        public static int counter = 1000 ;

        public Student()
        {
            
        }

        public Student(string name, int rollno, string CalculateFees)
        {
            ++counter;
            this.Name = name;
            this.Rollno = rollno;
            this.CalculateFee = calculateFee;
        }

        
    }

    public class BusStudent : Student, IStudent
    {
        private string busType;

        public string BusType
        {
            get { return busType; }
            set { busType = value; }
        }

       
        private int busFee;

        public int BusFee
        {
            get { return busFee; }
            set { busFee = value; }
        }

        public void CalculateFees()
        {
            throw new NotImplementedException();
        }

        public BusStudent()
        {
            throw new System.NotImplementedException();
        }
    }

    public class HostelStudent : Student, IStudent
    {
        private string sharingType;

        public string SharingType
        {
            get { return sharingType; }
            set { sharingType = value; }
        }
        private int hostelFee;

        public int HostelFee
        {
            get { return hostelFee; }
            set { hostelFee = value; }
        }

        public void CalculateFees()
        {
            throw new NotImplementedException();
        }

        public HostelStudent()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IStudent
    {
        void CalculateFees();
    }

    public class StudentFeeExceptions : Exception
    {
        
    }

    
}
