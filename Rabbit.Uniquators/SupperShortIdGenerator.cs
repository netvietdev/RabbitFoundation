using System;
using System.Collections.Generic;

namespace Rabbit.Uniquators
{
    public class SupperShortIdGenerator : IIdGenerator
    {
        private readonly IdBase _radix;
        private readonly DateTime _baseDate;
        private readonly IDictionary<ulong, IList<long>> _cache = new Dictionary<ulong, IList<long>>();

        public SupperShortIdGenerator(IdBase radix)
            : this(radix, new DateTime(2016, 1, 1))
        {
        }

        public SupperShortIdGenerator(IdBase radix, DateTime baseDate)
        {
            if (baseDate < _baseDate)
            {
                throw new ArgumentOutOfRangeException("baseDate", "The base date should be later than 1/1/2016");
            }

            _radix = radix;
            _baseDate = baseDate;
        }

        public string NewId()
        {
            var now = DateTime.Now.ToString("HHmmssffff");
            var daysDiff = (DateTime.Today - _baseDate).Days;
            var current = UInt64.Parse(string.Format("{0}{1}", daysDiff, now));
            return IdGeneratorHelper.NewId(_cache, current, _radix);
        }
    }
}