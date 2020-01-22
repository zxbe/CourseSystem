using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Wallee.CourseSystem.AggregateRootModels.ValueObjects
{
    public class Address : ValueObject
    {
        /// <summary>
        /// 详细的家庭住址，包括小区名称、栋号以及门牌号
        /// </summary>
        public string Detail { get; private set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; private set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string Province { get; private set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; private set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string ZipCode { get; private set; }
        internal Address(string detail,
            string city,
            string province,
            string country,
            string zipCode)
        {
            Detail = detail;
            City = city;
            Province = province;
            Country = country;
            ZipCode = zipCode;
        }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Detail;
            yield return City;
            yield return Province;
            yield return Country;
            yield return ZipCode;
        }
    }
}
