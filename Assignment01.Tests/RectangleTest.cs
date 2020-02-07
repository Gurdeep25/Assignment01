using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        [SetUp]
        public void SetUp()
        {
            Rectangle r = new Rectangle();
        }

        [Test]
        public void GetLength_Input1_Output1()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(1, r.GetLength(), 0);
        }
        [Test]
        public void GetWidth_Input1_Output1()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(1, r.GetWidth(), 0);
        }
        [Test]
        public void SetLength_UserInput2_Output2()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(2, r.SetLength(2), 0);
        }
        [Test]
        public void SetWidth_UserInput3_Output3()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(3, r.SetWidth(3), 0);
        }
        [Test]
        public void GetPerimeter_UserInputLength2Width2_Output8()
        {
            Rectangle r = new Rectangle(2,2);
            Assert.AreEqual(8, r.GetPerimeter(), 0);
        }
        [Test]
        public void GetArea_UserInputLength2Width2_Output4()
        {
            Rectangle r = new Rectangle(2, 2);
            Assert.AreEqual(4, r.GetArea(), 0);
        }

    }
}
