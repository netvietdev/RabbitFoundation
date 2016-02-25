using System;
using System.Collections.Generic;

namespace Rabbit.Uniquators
{
    /// <summary>
    /// TESTED: In a second, it can generates 7837 ID(s) on a dev computer
    /// </summary>
    public class TimebaseHexIdGenerator : IIdGenerator
    {
        private readonly IDictionary<ulong, IList<long>> _cache = new Dictionary<ulong, IList<long>>();
        private readonly long _baseValue = new DateTime(2016, 1, 1).Ticks;

        public TimebaseHexIdGenerator()
        {
        }

        public TimebaseHexIdGenerator(DateTime baseDate)
        {
            if (baseDate < new DateTime(_baseValue))
            {
                throw new ArgumentOutOfRangeException("baseDate", "The base date should be later than 1/1/2016");
            }

            _baseValue = baseDate.Ticks;
        }

        public string NewId()
        {
            var current = (ulong)(DateTime.Now.Ticks - _baseValue);
            return IdGeneratorHelper.NewId(_cache, current);
        }
    }
}