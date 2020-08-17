using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    /// <summary>
    /// These must match with the 'StakeholdersDiscriminatorsDb' table list
    /// 
    /// </summary>
    public enum StakeholderTypes
    {
        Unknown =0,
        FSA=1,
        LocalAuthority=2,
        OtherGovDept=3,
        Fbo_Febo=4
    }
}
