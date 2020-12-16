using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SIMS.OnlineForm.Functions.Models
{
    internal class FormProcessingEntity : TableEntity
    {

        public FormProcessingEntity()
        {
        }

        public FormProcessingEntity(string partitionKey, string rowKey) : base(partitionKey, rowKey)
        {
        
        }


        public string FormData { get; set; }
    }
}
