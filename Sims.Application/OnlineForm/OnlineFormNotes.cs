﻿using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class OnlineFormNotes : ISIMSNotes
    {
        private ISimsDbHost dbHost;

        public OnlineFormNotes(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<SimsNote> Add(int hostId, string note, int tags)
        {

            if (hostId == 0) throw new SimsItemMissing("No host id present.");
            return dbHost.OnlineForms.Notes.Add(hostId, note, tags);
        }

        public Task<IEnumerable<SimsNote>> GetAll(int hostId)
        {
            if (hostId == 0) throw new SimsItemMissing("No host id present.");
            return dbHost.OnlineForms.Notes.GetAll(hostId);
        }

        public Task Update(int noteId, int tags)
        {
            return dbHost.OnlineForms.Notes.Update(noteId, tags);
        }
    }
}