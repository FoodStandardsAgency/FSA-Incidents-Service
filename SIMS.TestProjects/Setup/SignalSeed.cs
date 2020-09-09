using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;
using System;
using Csv;
using System.IO;
using System.Linq;

namespace SIMS.TestProjects.Seeeds
{
    public static class SignalSeed
    {
        public static List<SimsSignal> Signals()
        {
            var csv = File.ReadAllText("./Setup/signals.csv");
            var results = new List<SimsSignal>();
            foreach (var line in CsvReader.ReadFromText(csv))
            {
                var rawSptId = line["ID"];
                var sptId = rawSptId.Contains("-") ? int.Parse( rawSptId.Split('-')[0]) : int.Parse(rawSptId);
                var title = line["Incident Title"].Replace("\"", @"\""");

                var cofO = line["Country of Origin"] ?? "";
                var notifiedBy = line["Notified by"] ?? "";
                var isEU = true;
                if (line.Values.Count() < line.Headers.Count())
                    isEU = false;
                else
                    isEU = (line["Eu/non-EU Country of Origin"] == "EU" ? true : false);
                var manu = line["Manufacturer"];
                var DateOfPublishing = String.IsNullOrEmpty(line["Date of Publishing"]) ? DateTime.Parse(line["Date of Publishing"]) : DateTime.MinValue;
                var DateAdded = String.IsNullOrEmpty(line["Date Added"]) ? DateTime.Parse(line["Date of Publishing"]) : DateTime.MinValue;
                var lnk = line["Link"];

                var newSIgnal = new SimsSignal
                {
                    CommonId = 0,
                    SPTId = sptId,
                    Title = title,
                    SignalStatusId = 1,
                    Priority = line["Prioritisation"],
                    LeadOfficer = "",
                    CountryOfOrigin = cofO,
                    NotifyingCountry = notifiedBy,
                    IsEu = isEU,
                    AlertType = line["Alert Type"],
                    Hazard = line["Hazard Description"],
                    HazardGroup = line["Hazard Group"],
                    BaseProduct = line["Commodity / Product"],
                    Manufacturer = (manu.ToLowerInvariant() == "na" || String.IsNullOrEmpty(manu) ? "" : manu),
                    FoodOrFeed = line["Food, Feed or FCM"],
                    DataSource = line["Data Source"],
                    SourceType = line["Source Type"],
                    PublishedDate = DateOfPublishing,
                    InsertedDate = DateAdded,
                    SourceLink = lnk
                };
                results.Add(newSIgnal);
            }
            return results;
        }
    }
}