using FSA.IncidentsManagement.Root.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class ProductsController :ControllerBase
    {
        private ILogger<LookupsController> log;
        private readonly IFSAIncidentsData fsaData;

        public ProductsController(ILogger<LookupsController> log, IFSAIncidentsData fsaData)
        {
            this.log = log;
            this.fsaData = fsaData;
        }


    }
}
