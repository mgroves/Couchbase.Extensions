﻿using System;
using System.Collections.Generic;
using System.Text;
using Couchbase.Linq.Filters;

namespace Couchbase.Extensions.Identity
{
    [DocumentTypeFilter("identityrole")]
    public class IdentityRole
    {
        public IdentityRole()
        {
        }

        public IdentityRole(string roleName) : this()
        {
            Name = roleName;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string Type { get; set; }

        public override string ToString() => Name;
    }
}
