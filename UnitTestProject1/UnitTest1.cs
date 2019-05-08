using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3.Utilities;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PäivämääräTestit()
        {
            //kelvollinen päivämäärä
            string syöte = "7.5.2019";
            DateTime tulos = DateParsing.ParseFinnishDate(syöte);
            DateTime odotettu = new DateTime(2019, 5, 7);
            Assert.AreEqual(odotettu, tulos);

            //karkauspäivämäärä
            syöte = "29.2.2016";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = new DateTime(2016, 2, 29);
            Assert.AreEqual(odotettu, tulos);

            //virheellinen syöte
            syöte = "";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            //virheellinen syöte 2
            syöte = null;
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            //virheellinen päivämäärä
            syöte = "7/25/2019";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);
        }

        [TestMethod]
        public void ViikkonumeroTestit()
        {
            DateTime pvm = new DateTime(2019, 5, 8);
            int tulos = DateParsing.GetWeekNumber(pvm);
            int odotettu = 19;
            Assert.AreEqual(odotettu, tulos);
        }
    }
}
