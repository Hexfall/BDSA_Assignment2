using System;
using Xunit;

//Write a couple of tests where you test the built-in equality comparer
// and to string properties of a record

namespace Assignment02.Tests
{
    public class ImmutableStudentTests
    {
        [Fact]
        public void ImmutableStudent_two_students_with_equal_values()
        {
            //Arrange
            ImmutableStudent IS1 = new ImmutableStudent {
                Id = 0,
                GivenName = "First",
                SurName = "Second",
                StartDate = new DateTime(2021, 9, 17) // 17th september 2021
            };
            
            ImmutableStudent IS2 = new ImmutableStudent {
                Id = 0,
                GivenName = "First",
                SurName = "Second",
                StartDate = new DateTime(2021, 9, 17) // 17th september 2021
            };
        
            //Act
            var output = IS1 == IS2;
        
            //Assert
            Assert.Equal(true, output);
        }

        [Fact]
        public void ImmutableStudent_two_students_without_equal_values()
        {
            //Arrange
            ImmutableStudent IS1 = new ImmutableStudent {
                Id = 0,
                GivenName = "First",
                SurName = "Second",
                StartDate = new DateTime(2021, 9, 17) // 17th september 2021
            };
            
            ImmutableStudent IS2 = new ImmutableStudent {
                Id = 0,
                GivenName = "First",
                SurName = "Invariant",
                StartDate = new DateTime(2021, 9, 17) // 17th september 2021
            };
        
            //Act
            var output = IS1 == IS2;
        
            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void ImmutableStudent_ToString_With_Null_Variables()
        {
            //Arrange
            var startDate = new DateTime(2021, 9, 17); // 17th september 2021
            
            ImmutableStudent IS1 = new ImmutableStudent {
                Id = 42,
                GivenName = "First",
                SurName = "Second",
                StartDate = startDate
            };
            
            //Act
            string s = IS1.ToString();

            //Assert
            Assert.Equal($"ImmutableStudent { Id = 42, GivenName = First, SurName = Second, Status = New, StartDate = {startDate}, EndDate = , GraduationDate =  }", s);
        }
    }
}

