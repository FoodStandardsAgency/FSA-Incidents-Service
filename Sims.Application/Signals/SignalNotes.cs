﻿using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalNotes : ISIMSNotes
    {
        private ISimsDbHost dbHost;

        public SignalNotes(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<SimsNote> Add(int hostId, string note, SimsNoteTagTypes tags)
        {

            if (hostId == 0) throw new SimsItemMissing("No host id present.");
            return dbHost.Signals.Notes.Add(hostId, note, (int) tags);
        }

        public Task<IEnumerable<SimsNote>> GetAll(int hostId)
        {
            if (hostId == 0) throw new SimsItemMissing("No host id present.");
            return dbHost.Signals.Notes.GetAll(hostId);
        }

        public Task Update(int noteId, SimsNoteTagTypes tags)
        {
            return dbHost.Signals.Notes.Update(noteId, (int)tags);
        }

    }
}