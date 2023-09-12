using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WrathForged.Database
{
    public class ForgeDBCache : MemoryCache
    {
        public ForgeDBCache(IOptions<MemoryCacheOptions> optionsAccessor) : base(optionsAccessor)
        {
        }

        public ForgeDBCache(IOptions<MemoryCacheOptions> optionsAccessor, ILoggerFactory loggerFactory) : base(optionsAccessor, loggerFactory)
        {
        }
    }
}
