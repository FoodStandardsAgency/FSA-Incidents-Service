﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSApplication
    {
        ISIMSIncidents Incidents { get; }
        ISIMSSignals Signals { get; }
        ISIMSOnlineForms OnlineForms { get; }
        ISIMSLookups Lookups { get; }
        ISIMSAddress Addresses { get; }
        ISIMSUserAuditLogger AuditLog { get; }
        // ISIMSAppAttachment AttachmentUpdates { get; }
    }
}
