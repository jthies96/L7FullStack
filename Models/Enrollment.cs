namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-04-jthies96-dykstra2] - create an enum that stores the letter grade values of A, B, C, D, and F
    public enum Grade
    {
        A, B, C, D, F
    }


    public class Enrollment
    {
        //tinfo200:[2021-03-04-jthies96-dykstra2] - create the properties for the Enrollment class that can be called on
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}