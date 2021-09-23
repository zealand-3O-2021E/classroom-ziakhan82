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
        public void TestStuderende_�rstid_vinter(int value)
        {
            //Arrange
            studerende studerende = new studerende("test", value, 12);
            //Act
            string �rstid = studerende.�rstid();
            //Assert
            Assert.AreEqual("Vinter", �rstid);
        }

        [DataTestMethod]
        [DataRow(11)]
        [DataRow(3)]
        public void TestStuderende_gr�nser_Ikke_�rstid_vinter(int value)
        {
            //Arrange
            studerende studerende = new studerende("test", value, 12);
            //Act
            string �rstid = studerende.�rstid();
            //Assert
            Assert.AreNotEqual("Vinter", �rstid);
        }


    }
}
