using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sims.Application.OnlineForm
{
    class ExternalCompany
    {
        public int[] FbosTypes { get; set; }
        public string Name { get; set; }
        public ExternalContact Contact { get; set; }
        public ExternalAddress Addresses { get; set; }
    }
}
