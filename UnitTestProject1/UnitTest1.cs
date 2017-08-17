using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOneNumber()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 5;

            //Act
            list.Add(5);

            //Assert
            Assert.AreEqual(expectedResult, list[0]);

        }
        [TestMethod]
        public void AddTwoNumbers()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 10;

            //Act 
            list.Add(10);

            //Assert
            Assert.AreEqual(expectedResult, firstNumber + secondNumber = 10);
        }
        [TestMethod]
        public void AddTwoWords()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = KiongLao;

            //Act 
            list.Add(KiongLao);

            //Assert
            Assert.AreEqual(expectedResult, Kiong + Lao = KiongLao);
        }
        [TestMethod]
        public void RemoveLetter()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "H";

            //Act 
            list.Remove(H);

            //Assert
            Assert.AreEqual(expectedResult, list[0]);
        }
        [TestMethod]
        public void RemoveLetterInWord()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "H";

            //Act 
            list.Remove(H);

            //Assert
            Assert.AreEqual(expectedResult, list[0]);
        }
        [TestMethod]
        public void RemoveAllWords()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = (null);

            //Act 
            list.Remove("I"; "like"; "to"; "code!";);

            //Assert
            Assert.AreEqual(expectedResult, list(null));
        }
        public void RemoveNumber()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 100;

            //Act 
            list.Remove(100);

            //Assert
            Assert.AreEqual(expectedResult, list[1]);
        }
        public void ConvertNumberToFirstNameLastName()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 1;

            //Act 
            list.ToString(1);

            //Assert
            Assert.AreEqual(expectedResult, list("Kiong" + "Lao"));
        }
        public void ConvertWordToAbbreviation()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "NFL";

            //Act 
            list.ToString("NFL");

            //Assert
            Assert.AreEqual(expectedResult, list("National Football League"));
        }
    }
}
