﻿using Stats.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stats.DataAccess.Repositories
{
    public class PlayerRepository: Repository<Player>
    {
        public PlayerRepository(StatsDbContext context) : base(context) {}
    }
}