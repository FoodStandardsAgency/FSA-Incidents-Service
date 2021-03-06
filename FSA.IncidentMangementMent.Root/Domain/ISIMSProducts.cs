﻿using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSProducts
    {
        Task<SimsProduct> Add(int hostId, SimsProduct newSimsProduct);
        Task<SimsProduct> Update(SimsProduct SimsProduct);
        Task<SimsProductDisplayModel> Get(int SimsProductId);
        Task<IEnumerable<SimsProduct>> GetAll(int incidentId);
        Task<IEnumerable<SimsProductFboAddress>> GetAddress(int SimsProductId);
        Task<IPaging<SimsProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1);
        Task AssignFbo(int SimsProductId, int addressId, SimsFboTypes types);
        Task RemoveFbo(int SimsProductId, int addressId);
        Task UpdateFbo(int SimsProductId, int addressId, SimsFboTypes fboTypes);
    }
}
