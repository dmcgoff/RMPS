using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMPS.Business.Interface;
using RMPS.DataAccess.Entities;
using RMPS.Service.ViewModels;

namespace RMPS.Service.Controllers
{

    [Produces("application/json")]
    [Route("api/CourseCatalog")]
    public class CourseCatalogController : Controller
    {
        private readonly ICourseCatalogService _svc;

        public CourseCatalogController(ICourseCatalogService svc)
        {
            _svc = svc;
        }

        [HttpGet]
        public JsonResult Get([DataSourceRequest] DataSourceRequest request)
        {
            var r = _svc.GetFilteredCourseCatalog<DataSourceResult>
                (headersQuery => headersQuery.ToDataSourceResult(request));


            //var viewModels = new List<CourseCatalogItemViewModel>();
            //foreach (var couresCatalogItem in couresCatalogItems.Data)
            //{
            //    viewModels.Add(couresCatalogItem.ToViewModel());
            //}
            var result = Json(r);
            return result;
        }
    }
}
