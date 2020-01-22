using System;
using System.Collections.Generic;
using System.Text;
using Wallee.CourseSystem.Localization;
using Volo.Abp.Application.Services;

namespace Wallee.CourseSystem
{
    /* Inherit your application services from this class.
     */
    public abstract class CourseSystemAppService : ApplicationService
    {
        protected CourseSystemAppService()
        {
            LocalizationResource = typeof(CourseSystemResource);
        }
    }
}
