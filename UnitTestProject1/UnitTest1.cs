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
        [TestMethod]
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
        [TestMethod]
        public void ConvertWordToAbbreviation()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "M";

            //Act 
            list.Add("NFL");
            list.Add("MLB");
            string newStringLeagues = list.ToString();

            //"NFL MLB"
            
            //Assert
            Assert.AreEqual(expectedResult, newStringLeagues[4]);
        }
        public void IterrateThroughWeekdays()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "Monday, Tuesday, Wednesday, Thursday, Friday";
           
            //Act
            list.Iterrate("Monday, Tuesday, Wednesday, Thursday, Friday");


            //Assert
            Assert.AreEqual(expectedResult, list[0, 1, 2, 3, 4]);
        }
        public void IterrateEvenNumbersFromZeroToTwelve()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expectedResult = ("0, 2, 4, 6, 8, 10, 12;");

            //Act
            list.Add("0, 2, 4, 6, 8, 10, 12;");


            //Assert
            Assert.AreEqual(expectedResult, list[0, 1, 2, 3, 4, 5, 6, 7]);
        }
        public void IterrateFromAThroughI()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = ("A, B, C, D, E, F, G, H, I");

            //Act
            list.Iterrate("A, B, C, D, E, F, G, H, I");


            //Assert
            Assert.AreEqual(expectedResult, list[0, 1, 2, 3, 4, 5, 6, 7, 8]);
        }
        public void ZipWords()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "Coding[0], is[1], very[2], fun![3]";

            //Act
            list.Zip((0 + 2) + (1 + 3));


            //Assert
            Assert.AreEqual(expectedResult, list(0 + 2) + (1 + 3));
        }

    }
}
