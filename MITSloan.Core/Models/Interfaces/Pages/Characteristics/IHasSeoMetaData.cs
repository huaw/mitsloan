﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MITSloan.Core.Models.Interfaces.Pages.Characteristics
{
    using EPiServer.Core;

    public interface IHasSeoMetaData
    {
        string SeoTitle { get; }
        string SeoKeywords { get; }
        string SeoDescription { get; }
    }
}
