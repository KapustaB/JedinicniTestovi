using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom;

namespace Testovi
{
    /// <summary>
    /// Summary description for TestKompleksnostBroja
    /// </summary>
    [TestClass]
    public class TestKompleksnostBroja
    {
        public TestKompleksnostBroja()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PozivKonstruktoraKompleksnogBrojaKaoRealniDioPostavljaPrviArg()
        {
            KompleksniBroj kb = new KompleksniBroj(4, 7);
            Assert.AreEqual(4, kb.RealniDio);
        }
        [TestMethod]
        public void PozivKonstruktoraKompleksnogBrojaKaoImaginarniDioPostavljaDrugiArg()
        {
            KompleksniBroj kb = new KompleksniBroj(4, 7);
            Assert.AreEqual(7, kb.ImaginarniDio);
        }
        [TestMethod]
        public void ZbrojDvaKompleksnaBrojaSaRealnimDijelomJednakimZbrojuRealnihDijelova()
        {
            KompleksniBroj kb1 = new KompleksniBroj(4, 7);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(11, (kb1+kb2).RealniDio);
        }
        [TestMethod]
        public void ZbrojDvaKompleksnaBrojaSaImaginarnimDijelomJednakimZbrojuImaginarnihDijelova()
        {
            KompleksniBroj kb1 = new KompleksniBroj(4, 7);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(16, (kb1 + kb2).ImaginarniDio);
        }
    }
}
