using System;
using Microsoft.EntityFrameworkCore.Internal;
using RMPS.DataAccess.Entities;
using Xunit;

namespace RMPS.DataAccess.UnitTest
{
    public class CourseRepositoryShould
    {
        [Fact]
        public void ReturnAllCoures()
        {
            var rep = new RmpsDbContext();
            var sut = new CourseRepository(rep);

            var coures = sut.GetAllCoures();
            var result = coures.Any();

            Assert.True(result);
        }
    }
}
