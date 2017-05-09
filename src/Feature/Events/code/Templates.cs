using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feature.Events
{
    public struct Templates
    {
        public struct Event
        {
            public static readonly ID ID = new ID("{B7DC8CB8-94CC-4DBA-BE26-3E532A2922D1}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{FB5E01B1-9F1A-48E1-8EFC-529D7A8FB8F0}");
                public static readonly ID Description = new ID("{7CB88F21-F752-4853-B6C0-7964C2B29423}");
                public static readonly ID Date = new ID("{B2EAC18F-F5D5-49C7-91C1-F68FD8F0C9D0}");
                public static readonly ID Venue = new ID("{04196F19-F057-43FD-B0ED-30DEC1C7D316}");
                public static readonly ID VenueAddress = new ID("{FDF8EC99-38E7-4D6E-9FF2-CDB4B85D9B0B}");
            }
        }
    }
}