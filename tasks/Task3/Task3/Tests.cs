using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task3;

namespace Tests
{
    [TestFixture]

    public class ComputerTests
    {
        [Test]
        public void CanCreatComputer()
        {
            var x = new Computer("Asus", "Zenbook UX330UA", 7, 1200);

            Assert.IsTrue(x.Company == "Asus");
            Assert.IsTrue(x.Model == "Zenbook UX330UA");
            Assert.IsTrue(x.Pieces == 7);
            Assert.IsTrue(x.Price == 1200);
        }

        [Test]
        public void CannotCreateCompanyWithEmptyTitle()
        {
            var x = new Computer(null, "xxx", 0, 0);
        }

        [Test]
        public void CannotCreateModelWithEmptyTitle()
        {
            var x = new Computer("xxx", null, 0, 0);
        }

        [Test]
        public void CannotCreatePiecesGreatherThan99()
        {
            var x = new Computer("xxx", "xxx", 100, 0);
        }

        [Test]
        public void CannotCreatePriceNotInRange()
        {
            var lowestPrice = new Computer("xxx", "xxx", 0, -5);
            var highestPrice = new Computer("xxx", "xxx", 0, 100000);
        }

    }
    public class PrinterTests
    {
        [Test]
        public void CanCreatPrinter()
        {
            var x = new Printer("Canon", "MG5350", 8, 300);

            Assert.IsTrue(x.Company == "Canon");
            Assert.IsTrue(x.Model == "MG5350");
            Assert.IsTrue(x.Pieces == 8);
            Assert.IsTrue(x.Price == 300);
        }

        [Test]
        public void CannotCreateCompanyWithEmptyTitle()
        {
            var x = new Printer(null, "xxx", 0, 0);
        }

        [Test]
        public void CannotCreateModelWithEmptyTitle()
        {
            var x = new Printer("xxx", null, 0, 0);
        }

        [Test]
        public void CannotCreatePiecesGreatherThan99()
        {
            var x = new Printer("xxx", "xxx", 100, 0);
        }

        [Test]
        public void CannotCreatePriceNotInRange()
        {
            var lowestPrice = new Printer("xxx", "xxx", 0, -5);
            var highestPrice = new Printer("xxx", "xxx", 0, 100000);
        }

    }
}
