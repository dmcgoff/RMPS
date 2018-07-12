using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using RMPS.Business.Interface;
using RMPS.DataAccess.Entities;
using RMPS.Services.Api.ViewModels;
using RMPS.Services.Api.Mappers;

namespace RMPS.Services.Api.Controllers
{

    [Produces("application/json")]
    [Route("api/Course")]
    public class CourseController : Controller
    {
        private readonly ICourseService _svc;

        public CourseController(ICourseService svc)
        {
            _svc = svc;
        }

        [HttpGet]
        public JsonResult Get([DataSourceRequest] DataSourceRequest request)
        {
            var r = _svc.GetFilteredCourses<DataSourceResult>
                (headersQuery => headersQuery.ToDataSourceResult(request));

            /* Figure out:
                - How/if we still return response codes
                - How we will handle errors
             
             */


            var entities = r.Data as IEnumerable<Modality>;
            var viewModels = entities != null ? entities.Select(course => course.ToNewViewModel()).ToList() : null;
            r.Data = viewModels.AsEnumerable();

            var result = Json(r);

            return result;
        }
    }
}
