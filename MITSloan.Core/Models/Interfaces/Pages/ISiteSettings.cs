using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Core;

namespace MITSloan.Core.Models.Interfaces.Pages
{
    public interface ISiteSettings
    {
        ContentReference ContentLink { get; }

        string ApplicationTitle { get; set; }

        string TrackingScript { get; set; }

        PageReference ApplyAcadamyOverlayPageReference { get; set; }
    }
}
