using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class Blerg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AdminLeads",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Branch London" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Branch Northern Ireland" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Branch Wales" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Food Standards Scotland" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Additives & Flavourings" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Foreign Bodies" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Heavy Metals" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Industrial Contaminants" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Labelling Absent / Incomplete / Incorrect" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Migration" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mycotoxins" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Non-Pathogenic Micro-Organisims" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Not Determined / Other" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Novel Food" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Packaging Defective / Incorrect" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Additives" },
                    { 38, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Parasitic Infestation" },
                    { 39, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pathogenic Micro-Organisms" },
                    { 40, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pesticide Residues" },
                    { 41, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poor or Insufficient Controls" },
                    { 43, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Residues of Veterinary Medicinal Products" },
                    { 44, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TSE`s" },
                    { 45, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 46, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unmapped SPT Signal Value" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Organoleptic Aspects" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Composition" },
                    { 42, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Radiation" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CHEMET" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chemical Contamination (other)" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Multiple Allergens" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Cereals containing gluten" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Celery" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Crustaceans" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Eggs" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Fish" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Lupin" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Milk" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Molluscs" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Adulteration / Fraud" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Nuts" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Peanuts" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Sesame seeds" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Soya" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Sulphur dioxide / Sulphites" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Non-regulated allergen reactions" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Clandestine Detection" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Allergens" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Biocontaminants" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Biotoxins (other)" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ALLERGEN: Mustard" }
                });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Non-Routine" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Routine" }
                });

            migrationBuilder.InsertData(
                table: "ContactMethods",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Email" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Telephone" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "No Preference" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedBy", "KeyField", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 213, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Netherlands" },
                    { 212, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nicaragua" },
                    { 211, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nigeria" },
                    { 210, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Norfolk Island" },
                    { 214, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Norway" },
                    { 209, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Niger" },
                    { 208, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "New Caledonia" },
                    { 201, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mauritius" },
                    { 206, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mozambique" },
                    { 205, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Malaysia" },
                    { 204, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MX", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mexico" },
                    { 203, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Malawi" },
                    { 202, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Maldives" },
                    { 215, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nepal" },
                    { 200, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Malta" },
                    { 207, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Namibia" },
                    { 216, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nauru" },
                    { 230, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Occupied Palestinian Territories" },
                    { 218, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "New Zealand" },
                    { 199, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Montserrat" },
                    { 234, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "QA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Qatar" },
                    { 233, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Paraguay" },
                    { 232, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Palau" },
                    { 231, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Portugal" },
                    { 229, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Puerto Rico" },
                    { 228, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pitcairn, Henderson, Ducie and Oeno Islands" },
                    { 217, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Niue" },
                    { 227, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saint Pierre and Miquelon" },
                    { 225, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pakistan" },
                    { 224, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Philippines" },
                    { 223, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Papua New Guinea" },
                    { 222, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "French Polynesia" },
                    { 221, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Peru" },
                    { 220, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Panama" },
                    { 219, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "OM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Oman" },
                    { 226, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poland" },
                    { 198, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mauritania" },
                    { 170, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kuwait" },
                    { 196, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Northern Mariana Islands" },
                    { 175, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "St Lucia" },
                    { 174, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LB", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Lebanon" },
                    { 173, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Laos" },
                    { 172, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kazakhstan" },
                    { 171, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cayman Islands" },
                    { 235, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Reunion" },
                    { 169, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Korea" },
                    { 176, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Liechtenstein" },
                    { 168, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "North Korea" },
                    { 166, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Comoros" },
                    { 165, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kiribati" },
                    { 164, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cambodia" },
                    { 163, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kyrgyzstan" },
                    { 162, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kenya" },
                    { 161, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "JP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Japan" },
                    { 160, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "JO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Jordan" },
                    { 167, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "St Kitts and Nevis" },
                    { 197, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Martinique" },
                    { 177, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sri Lanka" },
                    { 179, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Lesotho" },
                    { 195, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Macao" },
                    { 194, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mongolia" },
                    { 193, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Burma" },
                    { 192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ML", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mali" },
                    { 191, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Macedonia" },
                    { 190, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Marshall Islands" },
                    { 189, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Madagascar" },
                    { 178, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Liberia" },
                    { 188, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saint-Martin (French part)" },
                    { 186, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Moldova" },
                    { 185, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Monaco" },
                    { 184, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Morocco" },
                    { 183, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Libya" },
                    { 182, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Latvia" },
                    { 181, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Luxembourg" },
                    { 180, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Lithuania" },
                    { 187, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ME", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Montenegro" },
                    { 237, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Serbia" },
                    { 264, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chad" },
                    { 239, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Rwanda" },
                    { 294, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "St Vincent" },
                    { 293, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Vatican City" },
                    { 292, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Uzbekistan" },
                    { 291, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Uruguay" },
                    { 290, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "US", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "United States" },
                    { 289, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-95", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Palmyra Atoll" },
                    { 288, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-89", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kingman Reef" },
                    { 287, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-86", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Jarvis Island" },
                    { 286, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-84", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Howland Island" },
                    { 285, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-81", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Baker Island" },
                    { 284, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-79", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wake Island" },
                    { 283, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-76", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Navassa Island" },
                    { 282, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-71", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Midway Islands" },
                    { 281, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-67", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Johnston Atoll" },
                    { 280, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Uganda" },
                    { 295, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Venezuela" },
                    { 296, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "British Virgin Islands" },
                    { 297, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "United States Virgin Islands" },
                    { 298, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Vietnam" },
                    { 314, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "territory", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Territory" },
                    { 313, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "other", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 312, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "not-easily-identified", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Not Easily Identified" },
                    { 311, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "non-EU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "non-EU" },
                    { 310, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "country", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Country" },
                    { 309, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ZW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Zimbabwe" },
                    { 308, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ZM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Zambia" },
                    { 279, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ukraine" },
                    { 307, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ZA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Africa" },
                    { 305, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "YE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Yemen" },
                    { 304, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "XXD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dhekelia" },
                    { 303, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "XQZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Akrotiri" },
                    { 302, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "XK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kosovo" },
                    { 301, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "WS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Samoa" },
                    { 300, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "WF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wallis and Futuna" },
                    { 299, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Vanuatu" },
                    { 306, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "YT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mayotte" },
                    { 278, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tanzania" },
                    { 277, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Taiwan" },
                    { 276, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tuvalu" },
                    { 255, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Somalia" },
                    { 254, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Senegal" },
                    { 253, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "San Marino" },
                    { 252, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sierra Leone" },
                    { 251, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Slovakia" },
                    { 250, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Svalbard and Jan Mayen" },
                    { 249, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Slovenia" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Suriname" },
                    { 248, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SH-TA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tristan da Cunha" },
                    { 246, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SH-AC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ascension" },
                    { 245, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Singapore" },
                    { 244, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sweden" },
                    { 243, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sudan" },
                    { 242, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Seychelles" },
                    { 241, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SB", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Solomon Islands" },
                    { 240, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saudi Arabia" },
                    { 247, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SH-HL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saint Helena" },
                    { 238, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Russia" },
                    { 257, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Sudan" },
                    { 259, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "El Salvador" },
                    { 275, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Trinidad and Tobago" },
                    { 274, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Turkey" },
                    { 273, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tonga" },
                    { 272, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tunisia" },
                    { 271, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Turkmenistan" },
                    { 270, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "East Timor" },
                    { 269, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tokelau" },
                    { 258, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ST", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sao Tome and Principe" },
                    { 268, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tajikistan" },
                    { 266, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Togo" },
                    { 265, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "French Southern Territories" },
                    { 159, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "JM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Jamaica" },
                    { 263, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Turks and Caicos Islands" },
                    { 262, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Swaziland" },
                    { 261, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Syria" },
                    { 260, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SX", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sint Maarten (Dutch part)" },
                    { 267, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Thailand" },
                    { 158, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "JE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Jersey" },
                    { 236, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Romania" },
                    { 156, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iceland" },
                    { 55, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BAT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "British Antarctic Territory" },
                    { 54, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bosnia and Herzegovina" },
                    { 53, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Azerbaijan" },
                    { 52, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AX", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Aland Islands" },
                    { 51, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Aruba" },
                    { 50, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Australia" },
                    { 49, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Austria" },
                    { 48, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "American Samoa" },
                    { 47, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Argentina" },
                    { 46, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Antarctica" },
                    { 45, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Angola" },
                    { 44, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Armenia" },
                    { 43, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Albania" },
                    { 42, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Anguilla" },
                    { 41, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Antigua and Barbuda" },
                    { 56, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BB", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Barbados" },
                    { 57, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bangladesh" },
                    { 58, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Belgium" },
                    { 59, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Burkina Faso" },
                    { 76, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Belarus" },
                    { 75, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Botswana" },
                    { 74, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bouvet Island" },
                    { 73, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bhutan" },
                    { 72, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "The Bahamas" },
                    { 71, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Brazil" },
                    { 70, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BQ-SE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sint Eustatius" },
                    { 40, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Afghanistan" },
                    { 69, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BQ-SA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saba" },
                    { 67, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bolivia" },
                    { 66, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Brunei" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saint Barthelemy" },
                    { 63, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Benin" },
                    { 62, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Burundi" },
                    { 61, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bahrain" },
                    { 60, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bulgaria" },
                    { 68, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BQ-BO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bonaire" },
                    { 39, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-UQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Umm al-Quwain" },
                    { 38, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-SH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sharjah" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-RK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ras al-Khaimah" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guyana" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guinea-Bissau" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guam" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guatemala" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Georgia and South Sandwich Islands" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Greece" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Equatorial Guinea" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hong Kong" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guadeloupe" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "The Gambia" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Greenland" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gibraltar" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ghana" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guernsey" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "French Guiana" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Georgia" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guinea" },
                    { 77, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Belize" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Heard Island and McDonald Islands" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Croatia" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-FU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fujairah" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-DU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dubai" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-AZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Abu Dhabi" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-AJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ajman" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "United Arab Emirates" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Andorra" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iran" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Honduras" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iraq" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "India" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Isle of Man" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Israel" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ireland" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ID", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Indonesia" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hungary" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Haiti" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "British Indian Ocean Territory" },
                    { 78, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Canada" },
                    { 65, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bermuda" },
                    { 79, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cocos (Keeling) Islands" },
                    { 135, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Equatorial Guinea" },
                    { 134, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guadeloupe" },
                    { 133, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guinea" },
                    { 132, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "The Gambia" },
                    { 131, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Greenland" },
                    { 129, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ghana" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guernsey" },
                    { 136, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Greece" },
                    { 127, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "French Guiana" },
                    { 125, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Grenada" },
                    { 124, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB-WLS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wales" },
                    { 123, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB-SCT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Scotland" },
                    { 122, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB-NIR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Northern Ireland" },
                    { 121, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB-ENG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "England" },
                    { 120, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "United Kingdom" },
                    { 119, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gabon" },
                    { 126, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Georgia" },
                    { 118, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "France" },
                    { 137, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Georgia and South Sandwich Islands" },
                    { 139, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guam" },
                    { 155, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iran" },
                    { 154, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iraq" },
                    { 153, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "British Indian Ocean Territory" },
                    { 152, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "India" },
                    { 151, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Isle of Man" },
                    { 150, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Israel" },
                    { 149, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ireland" },
                    { 138, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guatemala" },
                    { 148, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ID", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Indonesia" },
                    { 146, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Haiti" },
                    { 145, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Croatia" },
                    { 144, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Honduras" },
                    { 143, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Heard Island and McDonald Islands" },
                    { 142, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hong Kong" },
                    { 141, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guyana" },
                    { 140, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guinea-Bissau" },
                    { 147, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hungary" },
                    { 117, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Faroe Islands" },
                    { 130, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gibraltar" },
                    { 115, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Falkland Islands" },
                    { 95, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cyprus" },
                    { 94, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CX", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Christmas Island" },
                    { 93, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Curacao" },
                    { 92, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cape Verde" },
                    { 91, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cuba" },
                    { 90, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Costa Rica" },
                    { 89, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Colombia" },
                    { 96, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Czechia" },
                    { 88, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "China" },
                    { 86, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chile" },
                    { 116, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Micronesia" },
                    { 84, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ivory Coast" },
                    { 83, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Switzerland" },
                    { 82, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Congo" },
                    { 81, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Central African Republic" },
                    { 80, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Congo (Democratic Republic)" },
                    { 87, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cameroon" },
                    { 97, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Germany" },
                    { 85, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cook Islands" },
                    { 99, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Denmark" },
                    { 98, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Djibouti" },
                    { 114, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fiji" },
                    { 113, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Finland" },
                    { 112, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "European Union" },
                    { 111, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ET", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ethiopia" },
                    { 110, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ES-ML", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Melilla" },
                    { 109, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ES-CE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ceuta" },
                    { 108, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ES", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Spain" },
                    { 107, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ER", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Eritrea" },
                    { 157, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Italy" },
                    { 105, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Egypt" },
                    { 104, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Estonia" },
                    { 106, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Western Sahara" },
                    { 103, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ecuador" },
                    { 102, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Algeria" },
                    { 101, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dominican Republic" },
                    { 100, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dominica" }
                });

            migrationBuilder.InsertData(
                table: "DataSources",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 41, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU)" },
                    { 40, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Crime Agency (NCA)" },
                    { 39, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Met Office" },
                    { 38, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Medicines & Healthcare products Regulatory Agency (MHRA)" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Maritime & Costguard Agency (MCA)" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Local Authority" },
                    { 42, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU) - NFCU INTEL Report" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "INFOSAN" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Industry" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health & Safety Executive" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health Protection Scotland (HPS)" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Marine Management Organisation (MMO)" },
                    { 43, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU) - DIM Referral" },
                    { 46, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 45, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nuclear Power Station" },
                    { 47, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Police" },
                    { 48, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Port Health Authority (PHA)" },
                    { 49, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public Analyst / Laboratory" },
                    { 50, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public Health England (PHE)" },
                    { 51, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RASFF" },
                    { 53, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SOCA" },
                    { 54, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Third Country" },
                    { 55, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Water Company" },
                    { 56, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Veterinary Medicines Directorate" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health Protection Agency (HPA)" },
                    { 57, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unmapped SPT Signal Value" },
                    { 44, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Health Service (NHS)" },
                    { 52, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SAC (Scottish Agricultural College)" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "General Public" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Unannounced Inspector" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Home Office / Border Force" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Web Form" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Administrative Assistance & Cooperation System (AAC)" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Animal & Plant Health Agency (APHA)" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Border Inspection Posts (BIPs)" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Department of Agriculture & Rural Development (DARD)" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Department of Health (DH)" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Department for Environment Food & Rural Affairs (Defra)" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EU Member States" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "European Commission (EC)" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fire Services" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Standards Scotland (FSS)" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Business Assurance Auditors" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Environment Agency (EA)" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA England" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Wine Inspector" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Dairy Inspector" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Survey" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA RAM Referral" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Poultry Hygiene Inspector" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Policy" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Wales (FSAW)" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Meat Hygiene Inspector" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Field Operations - FVC" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Field Operations - FVL" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Operations Group" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Northern Ireland (FSANI)" }
                });

            migrationBuilder.InsertData(
                table: "DeathIllnesss",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Abdominal Pain" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Diarrhoea" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Vomiting" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTags",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Picture" },
                    { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 2048, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Translation" },
                    { 1024, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Screenshot" },
                    { 512, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk assessment" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Recipients List" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public warning / Press release" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Phytosanitary Certifcate" },
                    { 4096, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Video File" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Follow up notification" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bill / Delivery Document" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Analytical report" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CVED/CED" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health certifiacte" }
                });

            migrationBuilder.InsertData(
                table: "FBOTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 4096, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Storage" },
                    { 2048, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Retailer" },
                    { 1024, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Producer" }
                });

            migrationBuilder.InsertData(
                table: "FBOTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 512, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Processor" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Packer/filler" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Manufacturer" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Importer" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hospitality/Food service" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "e-trader" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Exporter" },
                    { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Supplier" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "e-platform/e-market place" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Consignor" },
                    { 32768, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Transporter" },
                    { 65536, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wholesaler" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Farmer" },
                    { 16384, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Trader/Broker" }
                });

            migrationBuilder.InsertData(
                table: "IncidentStatus",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 200, "Open" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 500, "Unassigned" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 100, "Closed" }
                });

            migrationBuilder.InsertData(
                table: "NotifierTypes",
                columns: new[] { "Id", "Created", "CreatedBy", "Modified", "ModifiedBy", "Timestamp", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Public individual" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Local Authority" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Retailer" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Manufacturer" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "High" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TBC" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Medium" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Low" }
                });

            migrationBuilder.InsertData(
                table: "ProductDateTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Best before" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Best before End" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Display Until" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Use By Date" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Meat & Meat Products (other than poultry)" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ices & Desserts" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Honey & Royal Jelly" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gastropods" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Herbs & Spices" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Milk & Milk Products" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unmapped SPT Signal Value" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "N/A" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Soups / Broths / Sauces & Condiments" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nuts / Nut Products / Seeds" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other Food Product / Mixed" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pet Food" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poultry Meat & Poultry Meat Products" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Prepared Dishes & Snacks" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Water" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wine" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Non-Alcoholic Beverages" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fruits & Vegetables" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Materials" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Additives & Flavourings" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Contact Materials" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Animal by-Products" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Alcoholic Beverages" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bivalve Molluscs & Products Thereof" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cephalopods & Products Thereof" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cereals & Bakery Products" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Compound Feeds" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cocoa / Cocoa Preparations / Coffee / Tea" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Crustaceans & Products Thereof" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dietetic Foods / Food Supplements / Fortified Foods" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Egg & Egg Products" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fats & Oils" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Additives" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Premixtures" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fish & Fish Products" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Confectionery" }
                });

            migrationBuilder.InsertData(
                table: "SignalStatus",
                columns: new[] { "Id", "CreatedBy", "IsOpen", "IsUnassigned", "ModifiedBy", "ParentId", "Title" },
                values: new object[,]
                {
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Converted to Signal" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Merged to Incident" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Associated to Signal" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Converted to Incident" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Associated to Incident" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Duplicate" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Rejected" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Closed" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Open" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Unassigned" }
                });

            migrationBuilder.InsertData(
                table: "StakeholderDiscriminatorDb",
                columns: new[] { "Id", "Created", "CreatedBy", "Modified", "ModifiedBy", "Timestamp", "Title" },
                values: new object[,]
                {
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Other government department" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Food/Feed Business Operator (FBO/FeBO)" },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Food Standards Agency (FSA)" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Local Authority" }
                });

            migrationBuilder.InsertData(
                table: "StakeholderIncidentRoles",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dairy Inspector" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Incident Oversight Group (SIOG)" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chair, SIOG" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Advisior" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Stakeholder Engagement (SHE) Officer" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy Lead - Other Government Department" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Director" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Field Operations - FVC" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poultry Hygiene Inspector" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Business Assurance Auditors" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Meat Hygiene Inspector" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wine Inspector" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Receipt & Management  (RAM) Lead" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Stakeholder  Engagement  (SHE) Lead" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Receipt & Management (RAM ) Officer" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy Lead - FSA" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Field Operations - FVL" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chair, IMCG" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSS/FSA Liason" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Operational Incident Management Team (OIMT)" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Management Co-ordination Group (IMCG)" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Briefing Cell" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Briefing Cell Manager" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Situation Report (SITREP) Lead" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Q&A lead" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Communications Lead" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Press Officer" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Legal Advisior" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Official Note Taker" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy/Science Lead" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ministerial Submission Lead" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk Manager" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk Assesor" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Manager" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Lead?" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Support?" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Admin Support" }
                });

            migrationBuilder.InsertData(
                table: "UnitQuantities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Litres" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppm" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppb" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "nSv" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mSv" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mg/litre" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mg/kg" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "kg" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gallons" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/M3" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/M2" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/l" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/Kg" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "µSv" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "µg/kg" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppt" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Grams" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "tonnes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminLeads",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdminLeads",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdminLeads",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdminLeads",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContactMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContactMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContactMethods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "DataSources",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "DeathIllnesss",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeathIllnesss",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeathIllnesss",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 4096);

            migrationBuilder.DeleteData(
                table: "DocumentTags",
                keyColumn: "Id",
                keyValue: 8192);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 4096);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 8192);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 16384);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 32768);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 65536);

            migrationBuilder.DeleteData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductDateTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductDateTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductDateTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductDateTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StakeholderDiscriminatorDb",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StakeholderDiscriminatorDb",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StakeholderDiscriminatorDb",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StakeholderDiscriminatorDb",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
