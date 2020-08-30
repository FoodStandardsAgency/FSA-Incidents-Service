using FluentValidation;
using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.ModelValidators
{
    public class StakeholderModelValidator : AbstractValidator<SimsStakeholder>
    {
        public StakeholderModelValidator()
        {
        }
    }
}
