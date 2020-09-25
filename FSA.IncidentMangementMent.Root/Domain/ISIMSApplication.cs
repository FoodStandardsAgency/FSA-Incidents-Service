using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSApplication
    {
        ISIMSIncidents Incidents { get; }
        ISIMSSignals Signals { get; }
        ISIMSLookups Lookups { get; }
        ISIMSAddress Addresses { get; }
        // ISIMSAppAttachment AttachmentUpdates { get; }
    }
}
