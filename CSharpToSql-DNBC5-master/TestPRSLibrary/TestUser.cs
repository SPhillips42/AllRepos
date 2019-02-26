using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpToSql;

namespace TestPRSLibrary
{
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void TestGetAllUsers()
        {
            try
            {
                var users = CSharpToSql.User.GetAllUsers();
                Assert.IsInstanceOfType(users, typeof(User[]), "User Message");
                Assert.AreEqual(4, users.Length, "Should be 9 users");
                var firstuser = users[0];
                Assert.AreEqual(1, firstuser.Id);
                Assert.AreEqual("Sirchef", firstuser.Username);
                Assert.AreEqual("guest", firstuser.Password);
                Assert.IsNull(firstuser.Phone);
                Assert.IsTrue(firstuser.IsReviewer);
            }
            catch (Exception)
            {
                Assert.Fail("May have an open connection problem");
            }
        }
            [TestMethod]
        public void SecondTestGetAllUsers()
        {
            try
            {
                var users = CSharpToSql.User.GetAllUsers();
                Assert.IsInstanceOfType(users, typeof(User[]), "User Message");
                Assert.AreEqual(4, users.Length, "Should be 9 users");
                var firstuser = users[3];
                Assert.AreEqual(4, firstuser.Id);
                Assert.AreEqual("xxx8", firstuser.Username);
                Assert.AreEqual("xxx2", firstuser.Password);
                Assert.AreEqual(5135552323, firstuser.Phone);
                Assert.IsTrue(firstuser.IsReviewer);
            }
            catch (Exception)
            {
                Assert.Fail("May have an open connection problem");
            }

        }
    }
}
