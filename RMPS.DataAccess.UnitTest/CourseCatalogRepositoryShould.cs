using System;
using Microsoft.EntityFrameworkCore.Internal;
using RMPS.DataAccess.Entities;
using Xunit;

namespace RMPS.DataAccess.UnitTest
{
    public class CourseCatalogRepositoryShould
    {
        [Fact]
        public void ReturnAllCoureCatalogItems()
        {
            var rep = new RmpsDbContext();
            var sut = new CourseCatalogRepository(rep);

            var coures = sut.GetAll();
            var result = coures.Any();

            Assert.True(result);
        }
    }
}
