using FluentValidation;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagementDb.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.ModelValidators
{
    public class IncidentModelValidator : AbstractValidator<IncidentUpdateModel>
    {
        public IncidentModelValidator()
        {
            //RuleFor(incident => incident.IncidentCreated).NotEqual(default(DateTime));
            //RuleFor(incident => incident.LastChangedDate).NotEqual(default(DateTime)).WithMessage("Audit failure : Unknown dateTime");
            //RuleFor(incident => incident.LastChangedBy).NotNull().WithMessage("Audit failure : Unknown user specified.");
            RuleFor(incident => incident.StatusId).NotEqual(default(int)).WithMessage("Incorrect Status");

            RuleFor(incident => incident.ContactMethodId).NotEqual(default(int)).WithMessage("Incorrect ContactMethod");
            RuleFor(incident => incident.IncidentTypeId).NotEqual(default(int)).WithMessage("Incident type");

            RuleFor(incident => incident.IncidentTitle).NotNull().WithMessage("Cannot have a null title");
            //RuleFor(incident => incident.LeadOfficer).NotNull().WithMessage("Must have a lead officer assigned.");
            RuleFor(incident => incident.StatusId).NotEqual((int)IncidentStatus.Unassigned)
                    .When(incident => !String.IsNullOrEmpty(incident.LeadOfficer)).WithMessage("You must assign a lead officer to an open/closed case.");
            RuleFor(incident => incident.StatusId).Equal((int)IncidentStatus.Open)
                                                  .When(incident => String.IsNullOrEmpty(incident.LeadOfficer)).WithMessage("You must assign a lead officer before you can open an incident.");
            //RuleFor(incident => incident.LeadOffice).NotNull().WithMessage("This field cannot null.");
            //RuleFor(incident => incident.IncidentDescription).NotNull().WithMessage("Description must have a value.");
        }
    }
}
