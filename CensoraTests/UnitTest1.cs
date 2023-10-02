using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryCensora;

namespace CensoraTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Censora_Lowwer_ReturnTrue()
        {
            // Arrange
            string textString = "Этот текст содержит слово редиска";
            string expected = "Этот текст содержит слово ***";

            // Act
            string actual = CensoraClass.Censore(textString);

            // Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void Censora_Upper_ReturnTrue()
        {
            // Arrange
            string textString = "Этот текст содержит слово РЕДИСКА";
            string expected = "Этот текст содержит слово ***";

            // Act
            string actual = CensoraClass.Censore(textString);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Censora_ManyRediska_ReturnTrue()
        {
            // Arrange
            string textString = "редиска текст Редиска слово РЕДИСКА";
            string expected = "*** текст *** слово ***";

            // Act
            string actual = CensoraClass.Censore(textString);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Censora_Notrediska_ReturnFalse()
        {
            // Arrange
            string textString = " текст  содержит слово овощ";
            string expected = "текст содержит слово ***";

            // Act
            string actual = CensoraClass.Censore(textString);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
