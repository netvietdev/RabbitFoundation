using System;
using System.Collections.Generic;

namespace Rabbit.Uniquators
{
    /// <summary>
    /// TESTED: In a second, it can generates 15K ID(s) on a dev computer
    /// </summary>
    public class SlimHexIdGenerator : IIdGenerator
    {
        private readonly DateTime _baseDate = new DateTime(2016, 1, 1);
        private readonly IDictionary<ulong, IList<long>> _cache = new Dictionary<ulong, IList<long>>();

        public SlimHexIdGenerator()
        {
        }

        public SlimHexIdGenerator(DateTime baseDate)
        {
            if (baseDate < _baseDate)
            {
                throw new ArgumentOutOfRangeException("baseDate", "The base date should be later than 1/1/2016");
            }

            _baseDate = baseDate;
        }

        public string NewId()
        {
            var now = DateTime.Now.ToString("HHmmssfff");
            var daysDiff = (DateTime.Today - _baseDate).Days;
            var current = UInt64.Parse(string.Format("{0}{1}", daysDiff, now));
            return IdGeneratorHelper.NewId(_cache, current);
        }
    }
}