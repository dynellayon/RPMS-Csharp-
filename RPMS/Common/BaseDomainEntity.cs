﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; } = string.Empty;

    }
}
