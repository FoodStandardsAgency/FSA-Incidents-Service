﻿namespace FSA.IncidentsManagementDb.Entities
{
    internal class DocumentTagDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}