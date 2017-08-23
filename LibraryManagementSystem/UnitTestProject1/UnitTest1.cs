using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LibraryManagementSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BookFunctionalityCheck()
        {
            List<string> authorname = new List<string>();
            authorname.Add("Eric Freeman");
            authorname.Add("Eric Lippert");
            Books books = new Books("Head First Design Pattern",Genre.Selfhelp, 13452763, authorname, "ABC publications", 5);
            Assert.AreEqual("Hallary Halamn",books.AuthorName);
           

        }
    }
}
