using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADOUnitTesting
{
    [TestClass]
    public class AdoUnitTest
    {
        #region Unit Test Life Cycle
        //Initialize (Top To Bottom)
        //AssemblyInitialize
        //ClassInitialize
        //MethodInitializa

        //Cleanup
        //MethodCleanup
        //ClassCleanup
        //AssemblyCleanup 
        #endregion



        [AssemblyInitialize]
        public static void AssemblyInitializeMethod(TestContext context)
        {
            Console.WriteLine("I AM Assembly Initialize METHOD");
        }

            

                [TestInitialize]
                public void TestInitializeMethod()
                {
                    Console.WriteLine("I AM Test Initialize METHOD");
                }

                    [TestMethod]
                    public void TestMethodADO()
                    {
                        Console.WriteLine("I AM TEST METHOD");
                        Assert.AreEqual(5,5);
                    }

                [TestCleanup]
                public void TestCleanupMethod()
                {
                    Console.WriteLine("I AM Test Cleanup METHOD");
                }

            [ClassCleanup]
            public static void ClassCleanupMethod()
            {
                Console.WriteLine("I AM Class Cleanup METHOD");
            }

        [AssemblyCleanup]
        public static void AssemblyCleanupMethod()
        {
            Console.WriteLine("I AM Assembly Cleanup METHOD");
        }
    }
}
