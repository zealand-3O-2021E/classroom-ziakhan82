using ClassRoom;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestClassRoom
{
    [TestClass]
    public class ClassRoomTest
    {
        

        [DataTestMethod]
        [DataRow(12,"Winter")]
        [DataRow(1,"Winter")]
        [DataRow(2,"Winter")]
        [DataRow(3, "Spring")]
        [DataRow(4, "Spring")]
        [DataRow(5, "Spring")]
        [DataRow(6, "Summer")]
        [DataRow(7, "Summer")]
        [DataRow(8, "Summer")]
        [DataRow(9, "Autumn")]
        [DataRow(10, "Autumn")]
        [DataRow(11, "Autumn")]

        public void TestStudent_Season(int month, string season)
        {
            //Arrange
            var student = new Student("test", month, 12);
            //Act
            string årstid = student.Season();
            //Assert
            Assert.AreEqual(season, årstid);
        }


        [DataTestMethod]
        [DataRow(11)]
        [DataRow(3)]
        public void TestStudent_Boundaries_Not_Season_Winter(int value)
        {
            //Arrange
            var student = new Student("test", value, 12);
            //Act
            string årstid = student.Season();
            //Assert
            Assert.AreNotEqual("Winter", årstid);
        }


    }
}
