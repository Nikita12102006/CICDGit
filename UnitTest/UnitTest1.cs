
using CICD;
using Xunit;
namespace UnitTest
{
    namespace CICD.Tests
    {
        public class Class1Tests
        {
            // Тестирование метода факториала
            [Fact]
            public void Factorial_Test()
            {
                // Arrange
                double input = 5;
                double expectedOutput = 120;

                // Act
                double actualOutput = Class1.Factorial(input);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }

            //[Fact]
            //public void Factorial_Test_fail()
            //{
            //    // Arrange
            //    double input = 6;
            //    double expectedOutput = 120;

            //    // Act
            //    double actualOutput = Class1.Factorial(input);

            //    // Assert
            //    Assert.Equal(expectedOutput, actualOutput);
            //}

            //[Fact]
            //public void Factorial_Test_otric()
            //{
            //    // Arrange
            //    double input = -1;
            //    double expectedOutput = double.NaN;

            //    // Act
            //    double actualOutput = Class1.Factorial(input);

            //    // Assert
            //    Assert.Equal(expectedOutput, actualOutput);
            //}
            // Тестирование метода логорифма
            [Fact]
            public void LogOsn_test()
            {
                // Arrange
                int input_number = 150;
                int input_osn = 14;
                double expectedOutput = 1.8986458679269176;

                // Act
                double actualOutput = Class1.LogOsn(input_number, input_osn);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }

            //[Fact]
            //public void LogOsn_test_fail()
            //{
            //    // Arrange
            //    int input_number = 15;
            //    int input_osn = 14;
            //    double expectedOutput = 1.8986458679269176;

            //    // Act
            //    double actualOutput = Class1.LogOsn(input_number, input_osn);

            //    // Assert
            //    Assert.Equal(expectedOutput, actualOutput);
            //}

            //[Fact]
            //public void LogOsn_test_null()
            //{
            //    // Arrange
            //    int input_number = 150;
            //    int input_osn = 0;
            //    double expectedOutput = 0;

            //    // Act
            //    double actualOutput = Class1.LogOsn(input_number, input_osn);

            //    // Assert
            //    Assert.Equal(expectedOutput, actualOutput);
            //}

            //[Fact]
            //public void LogOsn_test_one()
            //{
            //    // Arrange
            //    int input_number = 150;
            //    int input_osn = 1;
            //    double expectedOutput = 0;

            //    // Act
            //    double actualOutput = Class1.LogOsn(input_number, input_osn);

            //    // Assert
            //    Assert.Equal(expectedOutput, actualOutput);
            //}
            // Тестирование метода подсчета корней
            [Fact]
            public void Koren_test()
            {
                // Arrange
                double input_number = 22;
                double input_stepen = 19;
                double expectedOutput = 1.1766676817027193;

                // Act
                double actualOutput = Class1.Koren(input_number, input_stepen);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }

            
            //[Fact]
            //public void Koren_test_fail()
            //{
            //    // Arrange
            //    double input_number = 2;
            //    double input_stepen = 19;
            //    double expectedOutput = 1.1766676817027193;

            //    // Act
            //    double actualOutput = Class1.Koren(input_number, input_stepen);

            //    // Assert
            //    Assert.Equal(expectedOutput, actualOutput);
            //}

            //[Fact]
            //public void Koren_test_null()
            //{
            //    // Arrange
            //    double input_number = 22;
            //    double input_stepen = 0;
            //    double expectedOutput = 0;
            //    // Act
            //    double actualOutput = Class1.Koren(input_number, input_stepen);

            //    // Assert
            //    Assert.Equal(expectedOutput, actualOutput);
            //}
        }
    }
}
