using Wallee.CourseSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Wallee.CourseSystem.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CourseSystemController : AbpController
    {
        protected CourseSystemController()
        {
            LocalizationResource = typeof(CourseSystemResource);
        }
    }
}