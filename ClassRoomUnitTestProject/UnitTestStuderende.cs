using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;
namespace ClassRoomUnitTestProject
{
    [TestClass]
    public class ClassRoomTest
    {
        [DataTestMethod]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void TestStuderende_Årstid_vinter(int value)
        {
            //Arrange
            studerende studerende = new studerende("test", value, 12);
            //Act
            string årstid = studerende.Årstid();
            //Assert
            Assert.AreEqual("Vinter", årstid);
        }

        [DataTestMethod]
        [DataRow(11)]
        [DataRow(3)]
        public void TestStuderende_grænser_Ikke_Årstid_vinter(int value)
        {
            //Arrange
            studerende studerende = new studerende("test", value, 12);
            //Act
            string årstid = studerende.Årstid();
            //Assert
            Assert.AreNotEqual("Vinter", årstid);
        }


    }
}
