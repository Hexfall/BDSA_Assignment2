using System;

namespace Assignment02
{
    public record ImmutableStudent
    {
        public int Id { get; init; }
        public string GivenName { get; init; }
        public string SurName { get; init; }
        public StudentStatus Status
        {
            get
            {
                if (GraduationDate != null)
                    return StudentStatus.Graduated;
                if (EndDate != null)
                    return StudentStatus.Dropout;
                if (StartDate < DateTime.Now.Add(new TimeSpan(30, 0, 0, 0)))
                    return StudentStatus.New;
                return StudentStatus.Active;
            }
        }
        public DateTime StartDate { get; init; }
        public DateTime? EndDate { get; init; }
        public DateTime? GraduationDate { get; init; }
    }
}