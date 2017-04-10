﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Core;

namespace MITSloan.Core.Models.Interfaces.Pages
{
    public interface IStartPage
    {
        ContentReference ContentLink { get; }
        PageReference SettingsPageReference { get; }

    }
}
