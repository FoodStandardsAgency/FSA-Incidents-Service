using Microsoft.Graph;
using System.Collections.Generic;

namespace Sims.Application.OnlineForm
{
    class ExternalCompany
    {
        public ExternalCompany()
        {
            FbosTypes = new List<int>();
        }
        public List<int> FbosTypes { get; set; }
        public string ProductName { get; set; }
        public string Name { get; set; }
        public ExternalContact Contact { get; set; }
        public ExternalAddress Addresses { get; set; }
    }
}
