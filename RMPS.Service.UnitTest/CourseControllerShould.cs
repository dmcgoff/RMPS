using Kendo.Mvc.UI;
using Microsoft.EntityFrameworkCore.Internal;
using RMPS.Business.Logic;
using RMPS.DataAccess;
using RMPS.Service.Controllers;
using RMPS.Services.Api.Controllers;
using Xunit;

namespace RMPS.Service.UnitTest
{
    public class CourseControllerShould
    {
        [Fact]
        public void Return10Courses()
        {
            var ctx = new RmpsDbContext();
            var rep = new CourseRepository(ctx);
            var svc = new CourseService(rep);
            var sut = new CourseController(svc);
            var dsreq = new DataSourceRequest
            {
                Page = 1,
                PageSize = 10
            };

            var dsres = sut.Get(dsreq);
            var result = ((DataSourceResult)dsres.Value).Data.Any();

            Assert.True(result);
        }
    }
}
