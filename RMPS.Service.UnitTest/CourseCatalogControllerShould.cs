using Kendo.Mvc.UI;
using Microsoft.EntityFrameworkCore.Internal;
using RMPS.Business.Logic;
using RMPS.DataAccess;
using RMPS.Service.Controllers;
using Xunit;

namespace RMPS.Service.UnitTest
{
    public class CourseCatalogControllerShould
    {
        [Fact]
        public void ReturnAllCoureCatalogItems()
        {
            var ctx = new RmpsDbContext();
            var rep = new CourseCatalogRepository(ctx);
            var svc = new CourseCatalogService(rep);
            var sut = new CourseCatalogController(svc);
            var dsreq = new DataSourceRequest
            {
                Page = 1,
                PageSize = 10
            };

            var dsres = sut.Post(dsreq);
            var result = dsres.Data.Any();

            Assert.True(result);
        }
    }
}
