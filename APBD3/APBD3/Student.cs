
namespace APBD3
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string idStudent { get; set; }
        public string faculty { get; set; }
        public string mode { get; set; }
        public string birthDay { get; set; }
        public string mail { get; set; }
        public string motherName { get; set; }
        public string fatherName { get; set; }

        public string toString()
        {
            return firstName + "," + lastName + "," + idStudent + "," + birthDay + "," + faculty + "," + mode + "," + mail + "," + motherName + "," + fatherName;
        }
    }
}
