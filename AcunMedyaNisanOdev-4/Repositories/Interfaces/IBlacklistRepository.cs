﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBlacklistRepository : IRepository<Blacklist>
    {
        Task<IEnumerable<Blacklist>> GetByApplicantIdAsync(int applicantId);
        Task<bool> IsBlacklistedAsync(int applicantId);
    }
}
