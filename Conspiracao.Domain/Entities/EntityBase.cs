﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Domain.Entities
{
    public abstract class EntityBase
    {
        public long Id { get; protected set; }
    }
}
