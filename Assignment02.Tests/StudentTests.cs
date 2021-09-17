using System;
using Xunit;

namespace Assignment02.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Student_Instantiates_Default_Correctly()
        {
            Student s = new Student();
            Assert.Equal(0, s.Id);
            Assert.Null(s.GivenName);
            Assert.Null(s.SurName);
            Assert.Equal(StudentStatus.New, s.Status);
            Assert.Null(s.EndDate);
            Assert.Null(s.GraduationDate);
        }

        [Fact]
        public void Student_New_Student_Has_New_Status()
        {
            // Arrange
            Student s = new Student();
            
            // Act
            StudentStatus status = s.Status;

            // Assert
            Assert.Equal(StudentStatus.New, status);
        }

        [Fact]
        public void Student_With_StartDate_Is_Active()
        {
            // Arrange
            Student s = new Student {
                StartDate = DateTime.Now.Add(new TimeSpan(-40, 0, 0, 0))
            };
            
            // Act
            StudentStatus status = s.Status;

            // Assert
            Assert.Equal(StudentStatus.Active, status);
        }

        [Fact]
        public void Student_With_EndDate_Is_Dropout()
        {
            // Arrange
            Student s = new Student {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };
            
            // Act
            StudentStatus status = s.Status;

            // Assert
            Assert.Equal(StudentStatus.Dropout, status);
        }

        [Fact]
        public void ToString_Given_Dropout_Student_Compute_ToString()
        {
            // Arrange
            Student s = new Student {
                Id = 42,
                GivenName = "First",
                SurName = "Second",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };
            
            // Act
            String output = s.ToString();

            // Assert
            Assert.Equal("Student (ID: 42, Name: First Second, Status: Dropout)", output);
        }
    }
}
