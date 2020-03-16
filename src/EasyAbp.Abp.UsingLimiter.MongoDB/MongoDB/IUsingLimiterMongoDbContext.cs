﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace EasyAbp.Abp.UsingLimiter.MongoDB
{
    [ConnectionStringName(UsingLimiterDbProperties.ConnectionStringName)]
    public interface IUsingLimiterMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
