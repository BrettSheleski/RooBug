using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.EntityFrameworkCore
{
    [TestClass]
    public class SqliteTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // setup
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite($"Data Source=my.db");


            using (var dbContext = new TestDbContext(optionsBuilder.Options))
            {

                // act
                dbContext.Database.EnsureCreated();

                // verify
            }





        }
    }
}
