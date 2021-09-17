using System;

namespace Assignment02
{
    public enum StudentStatus
    {
        New,
        Active,
        Dropout,
        Graduated
    }

    public class Student
    {
        public int Id { get; init; }
        public string GivenName { get; set; }
        public string SurName { get; set; }
        public StudentStatus Status
        {
            get
            {
                if (GraduationDate != null)
                    return StudentStatus.Graduated;
                if (EndDate != null)
                    return StudentStatus.Dropout;
                if (StartDate > DateTime.Now.Add(new TimeSpan(-30, 0, 0, 0)))
                    return StudentStatus.New;
                return StudentStatus.Active;
            }
        }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
        public DateTime? GraduationDate { get; set; }

        public string ToString()
        {
            return $"Student (ID: {Id}, Name: {GivenName} {SurName}, Status: {Status})";
        }
    }
}
