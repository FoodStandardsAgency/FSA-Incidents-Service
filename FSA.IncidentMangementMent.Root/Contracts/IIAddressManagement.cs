﻿using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IIAddressManagement
    {
        //Task<FboAddress> GetFbo(int FboId);
        //Task<FboAddress> AddFbo(FboAddress newAddress);
        //Task<FboAddress> UpdateFbo(FboAddress address);
        //Task AssignFbos(FboTypes fboTypes, IEnumerable<int> addressesId);
        //Task<int> AssignFbo(FboTypes notifier, int addressId);
        //Task<int> AddNotifier(NotifierTypes notifier, SimsAddress newAddress);
        //Task<int> AssignNotifier(NotifierTypes notifier, int addressId);
        //Task AssignNotifiers(NotifierTypes fboTypes, IEnumerable<int> addressesId);
        //Task<NotifierAddress> GetNotifier(int NotifierId);
        

        Task<Address> Get(int OrganisationId);
        Task<Address> Add(Address address);
        Task<Address> Update(Address address);

        Task Add(IEnumerable<Address> addresses);


        Task<IEnumerable<Address>> FindAddress(string search);



    }
}
