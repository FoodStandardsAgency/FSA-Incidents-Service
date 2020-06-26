using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class Seeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AdminLeads",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "Paul", "Paul", "Incidents Branch London" },
                    { 2, "Paul", "Paul", "Incidents Branch Northern Ireland" },
                    { 3, "Paul", "Paul", "Incidents Branch Wales" },
                    { 4, "Paul", "Paul", "Incidents Food Standards Scotland" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 25, "Paul", "Paul", "Feed Additives" },
                    { 26, "Paul", "Paul", "Food Additives & Flavourings" },
                    { 27, "Paul", "Paul", "Foreign Bodies" },
                    { 28, "Paul", "Paul", "Heavy Metals" },
                    { 29, "Paul", "Paul", "Industrial Contaminants" },
                    { 30, "Paul", "Paul", "Labelling Absent / Incomplete / Incorrect" },
                    { 31, "Paul", "Paul", "Migration" },
                    { 32, "Paul", "Paul", "Mycotoxins" },
                    { 33, "Paul", "Paul", "Non-Pathogenic Micro-Organisims" },
                    { 34, "Paul", "Paul", "Not Determined / Other" },
                    { 36, "Paul", "Paul", "Organoleptic Aspects" },
                    { 24, "Paul", "Paul", "Composition" },
                    { 37, "Paul", "Paul", "Packaging Defective / Incorrect" },
                    { 38, "Paul", "Paul", "Parasitic Infestation" },
                    { 39, "Paul", "Paul", "Pathogenic Micro-Organisms" },
                    { 40, "Paul", "Paul", "Pesticide Residues" },
                    { 41, "Paul", "Paul", "Poor or Insufficient Controls" },
                    { 42, "Paul", "Paul", "Radiation" },
                    { 43, "Paul", "Paul", "Residues of Veterinary Medicinal Products" },
                    { 44, "Paul", "Paul", "TSE`s" },
                    { 35, "Paul", "Paul", "Novel Food" },
                    { 23, "Paul", "Paul", "Chemical Contamination (other)" },
                    { 21, "Paul", "Paul", "Clandestine Detection" },
                    { 45, "Paul", "Paul", "Undefined" },
                    { 1, "Paul", "Paul", "Adulteration / Fraud" },
                    { 2, "Paul", "Paul", "ALLERGEN: Multiple Allergens" },
                    { 3, "Paul", "Paul", "ALLERGEN: Cereals containing gluten" },
                    { 4, "Paul", "Paul", "ALLERGEN: Celery" },
                    { 5, "Paul", "Paul", "ALLERGEN: Crustaceans" },
                    { 6, "Paul", "Paul", "ALLERGEN: Eggs" },
                    { 7, "Paul", "Paul", "ALLERGEN: Fish" },
                    { 8, "Paul", "Paul", "ALLERGEN: Lupin" },
                    { 9, "Paul", "Paul", "ALLERGEN: Milk" },
                    { 22, "Paul", "Paul", "CHEMET" },
                    { 10, "Paul", "Paul", "ALLERGEN: Molluscs" },
                    { 12, "Paul", "Paul", "ALLERGEN: Nuts" },
                    { 13, "Paul", "Paul", "ALLERGEN: Peanuts" },
                    { 14, "Paul", "Paul", "ALLERGEN: Sesame seeds" },
                    { 15, "Paul", "Paul", "ALLERGEN: Soya" },
                    { 16, "Paul", "Paul", "ALLERGEN: Sulphur dioxide / Sulphites" },
                    { 17, "Paul", "Paul", "ALLERGEN: Non-regulated allergen reactions" },
                    { 18, "Paul", "Paul", "Allergens" },
                    { 19, "Paul", "Paul", "Biocontaminants" },
                    { 20, "Paul", "Paul", "Biotoxins (other)" },
                    { 11, "Paul", "Paul", "ALLERGEN: Mustard" },
                    { 46, "Paul", "Paul", "Unmapped SPT Signal Value" }
                });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 2, "Paul", "Paul", "Non-Routine" },
                    { 1, "Paul", "Paul", "Routine" }
                });

            migrationBuilder.InsertData(
                table: "ContactMethods",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "Paul", "Paul", "Email" },
                    { 2, "Paul", "Paul", "Telephone" },
                    { 3, "Paul", "Paul", "Fax" },
                    { 4, "Paul", "Paul", "No Preference" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 148, "Paul", "Paul", "Mongolia (MN)" },
                    { 127, "Paul", "Paul", "Libyan Arab Jamahirya (LY)" },
                    { 128, "Paul", "Paul", "Liechtenstien (LI)" },
                    { 129, "Paul", "Paul", "Lithuania (LT)" },
                    { 130, "Paul", "Paul", "Luxembourg (LU)" },
                    { 131, "Paul", "Paul", "Macao (MO)" },
                    { 132, "Paul", "Paul", "Macedonia The Former Yugoslav Republic of (MK)" },
                    { 133, "Paul", "Paul", "Madagascar (MG)" },
                    { 134, "Paul", "Paul", "Malawi (MW)" },
                    { 135, "Paul", "Paul", "Malaysia (MY)" },
                    { 136, "Paul", "Paul", "Maldives (MV)" },
                    { 139, "Paul", "Paul", "Marshall Islands (MH)" },
                    { 138, "Paul", "Paul", "Malta (ML)" },
                    { 140, "Paul", "Paul", "Martinique (MQ)" },
                    { 141, "Paul", "Paul", "Mauritania (MR)" },
                    { 142, "Paul", "Paul", "Mauritius (MU)" },
                    { 143, "Paul", "Paul", "Mayotte (YT)" },
                    { 144, "Paul", "Paul", "Mexico (MX)" },
                    { 145, "Paul", "Paul", "Micronesia Federated States of (FM)" },
                    { 146, "Paul", "Paul", "Moldova Republic of (MD)" },
                    { 147, "Paul", "Paul", "Monaco (MC)" },
                    { 137, "Paul", "Paul", "Mali (ML)" },
                    { 126, "Paul", "Paul", "Liberia (LR)" },
                    { 123, "Paul", "Paul", "Latvia (LV)" },
                    { 124, "Paul", "Paul", "Lebanon (LB)" },
                    { 102, "Paul", "Paul", "Hungary (HU)" },
                    { 103, "Paul", "Paul", "Iceland (IS)" },
                    { 104, "Paul", "Paul", "Ilse of Man (IM)" },
                    { 105, "Paul", "Paul", "India (IN)" },
                    { 106, "Paul", "Paul", "Indonesia (ID)" },
                    { 107, "Paul", "Paul", "Iran Islamic Republic of (IR)" },
                    { 108, "Paul", "Paul", "Iraq (IQ)" },
                    { 109, "Paul", "Paul", "Ireland (IE)" },
                    { 110, "Paul", "Paul", "Israel (IL)" },
                    { 111, "Paul", "Paul", "Italy (IT)" },
                    { 112, "Paul", "Paul", "Jamacia (JM)" },
                    { 113, "Paul", "Paul", "Japan (JP)" },
                    { 114, "Paul", "Paul", "Jersey (JE)" },
                    { 115, "Paul", "Paul", "Jordan (JO)" },
                    { 116, "Paul", "Paul", "Kiribati (KI)" },
                    { 117, "Paul", "Paul", "Korea Democratic People`s Republic of (KP)" },
                    { 118, "Paul", "Paul", "Korea Republic of (KR)" },
                    { 119, "Paul", "Paul", "Kosovo Autonomous Region of (KS)" },
                    { 120, "Paul", "Paul", "Kuwait (KW)" },
                    { 121, "Paul", "Paul", "Kyrgyzstan (KG)" },
                    { 122, "Paul", "Paul", "Lao People`s Democratic Republic (LA)" },
                    { 125, "Paul", "Paul", "Lesotho (LS)" },
                    { 149, "Paul", "Paul", "Montenegro (ME)" },
                    { 178, "Paul", "Paul", "Poland (PL)" },
                    { 152, "Paul", "Paul", "Mozambique (MZ)" },
                    { 179, "Paul", "Paul", "Portugal (PT)" },
                    { 180, "Paul", "Paul", "Puerto Rico (PR)" },
                    { 181, "Paul", "Paul", "Qatar (QA)" },
                    { 182, "Paul", "Paul", "Reunion (RE)" },
                    { 183, "Paul", "Paul", "Romania (RO)" },
                    { 184, "Paul", "Paul", "Russian Federation (RU)" },
                    { 185, "Paul", "Paul", "Rwanda (RO)" },
                    { 186, "Paul", "Paul", "Saint Barthelemy (BL)" },
                    { 187, "Paul", "Paul", "Saint Helena (SH)" },
                    { 188, "Paul", "Paul", "Saint Kitts & Nevis (KN)" },
                    { 189, "Paul", "Paul", "Saint Lucia (LC)" },
                    { 190, "Paul", "Paul", "Saint Martin (MF)" },
                    { 191, "Paul", "Paul", "Saint Pierre & Miquelon (PM)" },
                    { 192, "Paul", "Paul", "Saint Vincent & the Grenadines (VC)" },
                    { 193, "Paul", "Paul", "Samoa (WS)" },
                    { 194, "Paul", "Paul", "San Marino (SM)" },
                    { 195, "Paul", "Paul", "Sao Tome & Principe (ST)" },
                    { 196, "Paul", "Paul", "Saudi Arabia (SA)" },
                    { 197, "Paul", "Paul", "Senegal (SN)" },
                    { 198, "Paul", "Paul", "Serbia (RS)" },
                    { 199, "Paul", "Paul", "Seychelles (SC)" },
                    { 101, "Paul", "Paul", "Hong Kong (HK)" },
                    { 177, "Paul", "Paul", "Pitcairn (PN)" },
                    { 176, "Paul", "Paul", "Philippines (PH)" },
                    { 175, "Paul", "Paul", "Peru (PE)" },
                    { 153, "Paul", "Paul", "Myanimar (MM)" },
                    { 154, "Paul", "Paul", "Nambia (NA)" },
                    { 155, "Paul", "Paul", "Nauru (NR)" },
                    { 156, "Paul", "Paul", "Nepal (NP)" },
                    { 157, "Paul", "Paul", "Netherlands (NL)" },
                    { 158, "Paul", "Paul", "Netherlands Antilles (AN)" },
                    { 159, "Paul", "Paul", "New Caledonia (NC)" },
                    { 160, "Paul", "Paul", "New Zealand (NZ)" },
                    { 161, "Paul", "Paul", "Nicaragua ((NI)" },
                    { 162, "Paul", "Paul", "Niger (NE)" },
                    { 150, "Paul", "Paul", "Montserrat (MS)" },
                    { 163, "Paul", "Paul", "Nigeria (NG)" },
                    { 165, "Paul", "Paul", "Norfolk Island (NF)" },
                    { 166, "Paul", "Paul", "Northern Mariana Islands (MP)" },
                    { 167, "Paul", "Paul", "Norway (NO)" },
                    { 168, "Paul", "Paul", "Oman (OM)" },
                    { 169, "Paul", "Paul", "Pakistan (PK)" },
                    { 170, "Paul", "Paul", "Palau (PW)" },
                    { 171, "Paul", "Paul", "Palestinian Territory Occupied (PS)" },
                    { 172, "Paul", "Paul", "Panama (PA)" },
                    { 173, "Paul", "Paul", "Papua New Guinea (PG)" },
                    { 174, "Paul", "Paul", "Paraguay (PY)" },
                    { 164, "Paul", "Paul", "Niue (NU)" },
                    { 100, "Paul", "Paul", "Honduras (HN)" },
                    { 151, "Paul", "Paul", "Morocco (MA)" },
                    { 98, "Paul", "Paul", "Heatrd Island & McDonald Islands (HM)" },
                    { 26, "Paul", "Paul", "Bhutan (BT)" },
                    { 27, "Paul", "Paul", "Bolivia (BO)" },
                    { 28, "Paul", "Paul", "Bosnia & Herzegovina (BA)" },
                    { 29, "Paul", "Paul", "Botswana (BW)" },
                    { 30, "Paul", "Paul", "Bouvet Island (BV)" },
                    { 31, "Paul", "Paul", "Brazil (BR)" },
                    { 32, "Paul", "Paul", "British Indian Ocean Territory (IO)" },
                    { 33, "Paul", "Paul", "Brunei Darussalam (BN)" },
                    { 34, "Paul", "Paul", "Bulgaria (BG)" },
                    { 35, "Paul", "Paul", "Burkina Faso (BF)" },
                    { 99, "Paul", "Paul", "Holy See (Vatican City State) (VA)" },
                    { 37, "Paul", "Paul", "Cambodia (KH)" },
                    { 38, "Paul", "Paul", "Cameroon (CM)" },
                    { 39, "Paul", "Paul", "Canada (CA)" },
                    { 40, "Paul", "Paul", "Cape Verde (CV)" },
                    { 41, "Paul", "Paul", "Cayman Islands (KY)" },
                    { 42, "Paul", "Paul", "Central African Republic (CF)" },
                    { 43, "Paul", "Paul", "Chad (TD)" },
                    { 44, "Paul", "Paul", "Chile (CL)" },
                    { 45, "Paul", "Paul", "China (CX)" },
                    { 46, "Paul", "Paul", "Christmas Island (CX)" },
                    { 25, "Paul", "Paul", "Bermuda (BM)" },
                    { 47, "Paul", "Paul", "Cocos (Keeling) Islands (CC)" },
                    { 24, "Paul", "Paul", "Benin (BJ)" },
                    { 22, "Paul", "Paul", "Belgium (BE)" },
                    { 1, "Paul", "Paul", "Afganistan (AF)" },
                    { 2, "Paul", "Paul", "Aland Islands (AX)" },
                    { 3, "Paul", "Paul", "Albania (AL)" },
                    { 4, "Paul", "Paul", "Algeria (DZ)" },
                    { 5, "Paul", "Paul", "America Samoa (AS)" },
                    { 6, "Paul", "Paul", "Andorra (AD)" },
                    { 7, "Paul", "Paul", "Angola (AO)" },
                    { 8, "Paul", "Paul", "Anguilla (AI)" },
                    { 9, "Paul", "Paul", "Antarctica (AQ)" },
                    { 10, "Paul", "Paul", "Antigua & Barbuda (AG)" },
                    { 11, "Paul", "Paul", "Argentina (AR)" },
                    { 12, "Paul", "Paul", "Armenia (AM)" },
                    { 13, "Paul", "Paul", "Aruba (AW)" },
                    { 14, "Paul", "Paul", "Australia (AU)" },
                    { 15, "Paul", "Paul", "Austria (AT)" },
                    { 16, "Paul", "Paul", "Azerbaijan (AZ)" },
                    { 17, "Paul", "Paul", "Bahamas (BS)" },
                    { 18, "Paul", "Paul", "Bahrain (BH)" },
                    { 19, "Paul", "Paul", "Bangladesh (BD)" },
                    { 20, "Paul", "Paul", "Barbados (BB)" },
                    { 21, "Paul", "Paul", "Belarus (BY)" },
                    { 23, "Paul", "Paul", "Belize (BZ)" },
                    { 48, "Paul", "Paul", "Columbia (CO)" },
                    { 36, "Paul", "Paul", "Burundi (BI)" },
                    { 87, "Paul", "Paul", "Gibraltar (GI)" },
                    { 76, "Paul", "Paul", "Fiji (FJ)" },
                    { 77, "Paul", "Paul", "Finland (FI)" },
                    { 78, "Paul", "Paul", "France (FR)" },
                    { 80, "Paul", "Paul", "French Polynesia (PF)" },
                    { 81, "Paul", "Paul", "French Southern Territories (TF)" },
                    { 82, "Paul", "Paul", "Gabon (GA)" },
                    { 83, "Paul", "Paul", "Gambia (GM)" },
                    { 84, "Paul", "Paul", "Georgia (GE)" },
                    { 85, "Paul", "Paul", "Germany (DE)" },
                    { 86, "Paul", "Paul", "Ghana GH)" },
                    { 49, "Paul", "Paul", "Commission Services (CS)" },
                    { 88, "Paul", "Paul", "Greece (GR)" },
                    { 89, "Paul", "Paul", "Greenland (GL)" },
                    { 90, "Paul", "Paul", "Grenada (GD)" },
                    { 91, "Paul", "Paul", "Guadeloupe (GP)" },
                    { 92, "Paul", "Paul", "Guam (GU)" },
                    { 93, "Paul", "Paul", "Guatemala (GT)" },
                    { 94, "Paul", "Paul", "Guernsey (GG)" },
                    { 95, "Paul", "Paul", "Guinea-Bissau (GW)" },
                    { 96, "Paul", "Paul", "Guyana (GY)" },
                    { 97, "Paul", "Paul", "Haiti (HT)" },
                    { 75, "Paul", "Paul", "Faroe Islands (FO)" },
                    { 74, "Paul", "Paul", "Falkland Islands (Malvinas) (FK)" },
                    { 79, "Paul", "Paul", "French Guiana (GF)" },
                    { 72, "Paul", "Paul", "Estonia (EE)" },
                    { 50, "Paul", "Paul", "Comoros (KM)" },
                    { 51, "Paul", "Paul", "Congo The Democratic Rebulic of the (CD)" },
                    { 52, "Paul", "Paul", "Congo-Brazzaville (CG)" },
                    { 53, "Paul", "Paul", "Cook Islands (CK)" },
                    { 54, "Paul", "Paul", "Costa Rica (CR)" },
                    { 73, "Paul", "Paul", "Eygypt (EG)" },
                    { 56, "Paul", "Paul", "Country Not mentioned (NM)" },
                    { 57, "Paul", "Paul", "Croatia (HR)" },
                    { 58, "Paul", "Paul", "Cuba (CU)" },
                    { 59, "Paul", "Paul", "Cyprus (CY)" },
                    { 60, "Paul", "Paul", "Czech Republic (DO)" },
                    { 55, "Paul", "Paul", "Cote D`Ivoire (CI)" },
                    { 62, "Paul", "Paul", "Djibouti (DJ)" },
                    { 63, "Paul", "Paul", "Dominica (DM)" },
                    { 64, "Paul", "Paul", "Dominican Republic (DO)" },
                    { 65, "Paul", "Paul", "Eathiopia (ET)" },
                    { 66, "Paul", "Paul", "Ecuador (EC)" },
                    { 67, "Paul", "Paul", "EFSA (FS)" },
                    { 68, "Paul", "Paul", "El Salvador (SV)" },
                    { 69, "Paul", "Paul", "Equatorial Guinea (GQ)" },
                    { 70, "Paul", "Paul", "Eritrea (ER)" },
                    { 71, "Paul", "Paul", "ESA (EF)" },
                    { 61, "Paul", "Paul", "Denmark (DK)" }
                });

            migrationBuilder.InsertData(
                table: "DataSources",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 41, "Paul", "Paul", "National Food Crime Unit (NFCU)" },
                    { 40, "Paul", "Paul", "National Crime Agency (NCA)" },
                    { 39, "Paul", "Paul", "Met Office" },
                    { 38, "Paul", "Paul", "Medicines & Healthcare products Regulatory Agency (MHRA)" },
                    { 37, "Paul", "Paul", "Maritime & Costguard Agency (MCA)" },
                    { 31, "Paul", "Paul", "Health Protection Scotland (HPS)" },
                    { 35, "Paul", "Paul", "Local Authority" },
                    { 34, "Paul", "Paul", "INFOSAN" },
                    { 33, "Paul", "Paul", "Industry" },
                    { 32, "Paul", "Paul", "Health & Safety Executive" },
                    { 42, "Paul", "Paul", "National Food Crime Unit (NFCU) - NFCU INTEL Report" },
                    { 36, "Paul", "Paul", "Marine Management Organisation (MMO)" },
                    { 43, "Paul", "Paul", "National Food Crime Unit (NFCU) - DIM Referral" },
                    { 57, "Paul", "Paul", "Unmapped SPT Signal Value" },
                    { 45, "Paul", "Paul", "Nuclear Power Station" },
                    { 46, "Paul", "Paul", "Other" },
                    { 47, "Paul", "Paul", "Police" },
                    { 48, "Paul", "Paul", "Port Health Authority (PHA)" },
                    { 49, "Paul", "Paul", "Public Analyst / Laboratory" },
                    { 50, "Paul", "Paul", "Public Health England (PHE)" },
                    { 51, "Paul", "Paul", "RASFF" },
                    { 52, "Paul", "Paul", "SAC (Scottish Agricultural College)" },
                    { 53, "Paul", "Paul", "SOCA" },
                    { 54, "Paul", "Paul", "Third Country" },
                    { 55, "Paul", "Paul", "Water Company" },
                    { 56, "Paul", "Paul", "Veterinary Medicines Directorate" },
                    { 44, "Paul", "Paul", "National Health Service (NHS)" },
                    { 29, "Paul", "Paul", "Home Office / Border Force" },
                    { 30, "Paul", "Paul", "Health Protection Agency (HPA)" },
                    { 27, "Paul", "Paul", "FSA Unannounced Inspector" },
                    { 28, "Paul", "Paul", "General Public" },
                    { 1, "Paul", "Paul", "Web Form" },
                    { 2, "Paul", "Paul", "Administrative Assistance & Cooperation System (AAC)" },
                    { 3, "Paul", "Paul", "Animal & Plant Health Agency (APHA)" },
                    { 4, "Paul", "Paul", "Border Inspection Posts (BIPs)" },
                    { 5, "Paul", "Paul", "Department of Agriculture & Rural Development (DARD)" },
                    { 6, "Paul", "Paul", "Department of Health (DH)" },
                    { 8, "Paul", "Paul", "Environment Agency (EA)" },
                    { 9, "Paul", "Paul", "EU Member States" },
                    { 10, "Paul", "Paul", "European Commission (EC)" },
                    { 11, "Paul", "Paul", "Fire Services" },
                    { 12, "Paul", "Paul", "Food Standards Scotland (FSS)" },
                    { 13, "Paul", "Paul", "FSA Business Assurance Auditors" },
                    { 7, "Paul", "Paul", "Department for Environment Food & Rural Affairs (Defra)" },
                    { 15, "Paul", "Paul", "FSA England" },
                    { 14, "Paul", "Paul", "FSA Dairy Inspector" },
                    { 25, "Paul", "Paul", "FSA Wales (FSAW)" },
                    { 24, "Paul", "Paul", "FSA Survey" },
                    { 23, "Paul", "Paul", "FSA RAM Referral" },
                    { 22, "Paul", "Paul", "FSA Poultry Hygiene Inspector" },
                    { 21, "Paul", "Paul", "FSA Policy" },
                    { 26, "Paul", "Paul", "FSA Wine Inspector" },
                    { 19, "Paul", "Paul", "FSA Meat Hygiene Inspector" },
                    { 18, "Paul", "Paul", "FSA Field Operations - FVC" },
                    { 17, "Paul", "Paul", "FSA Field Operations - FVL" },
                    { 16, "Paul", "Paul", "FSA Operations Group" },
                    { 20, "Paul", "Paul", "FSA Northern Ireland (FSANI)" }
                });

            migrationBuilder.InsertData(
                table: "DeathIllnesss",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "Paul", "Paul", "Abdominal Pain" },
                    { 2, "Paul", "Paul", "Diarrhoea" },
                    { 3, "Paul", "Paul", "Vomiting" }
                });

            migrationBuilder.InsertData(
                table: "FBOTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 9, "Paul", "Paul", "Packer/filler" },
                    { 10, "Paul", "Paul", "Processor" },
                    { 11, "Paul", "Paul", "Producer" },
                    { 12, "Paul", "Paul", "Retailer" },
                    { 14, "Paul", "Paul", "Supplier" },
                    { 15, "Paul", "Paul", "Trader/Broker" },
                    { 16, "Paul", "Paul", "Transporter" },
                    { 17, "Paul", "Paul", "Wholesaler" },
                    { 13, "Paul", "Paul", "Storage" },
                    { 8, "Paul", "Paul", "Manufacturer" },
                    { 6, "Paul", "Paul", "Hospitality/Food service" },
                    { 5, "Paul", "Paul", "Farmer" },
                    { 4, "Paul", "Paul", "Exporter" },
                    { 3, "Paul", "Paul", "e-trader" },
                    { 2, "Paul", "Paul", "e-platform/e-market place" },
                    { 1, "Paul", "Paul", "Consignor" },
                    { 7, "Paul", "Paul", "Importer" }
                });

            migrationBuilder.InsertData(
                table: "IncidentStatus",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "Paul", "Paul", "Open" },
                    { 2, "Paul", "Paul", "Closed" },
                    { 3, "Paul", "Paul", "No wait!" }
                });

            migrationBuilder.InsertData(
                table: "NotifierTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 2, "Paul", "Paul", "Local Authority" },
                    { 1, "Paul", "Paul", "Public individual" },
                    { 4, "Paul", "Paul", "Manufacturer" },
                    { 3, "Paul", "Paul", "Retailer" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 4, "Paul", "Paul", "High" },
                    { 2, "Paul", "Paul", "Low" },
                    { 1, "Paul", "Paul", "Unclassified" },
                    { 3, "Paul", "Paul", "Medium" }
                });

            migrationBuilder.InsertData(
                table: "ProductDateTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "Paul", "Paul", "Use By Date" },
                    { 2, "Paul", "Paul", "Best before" },
                    { 3, "Paul", "Paul", "Best before End" },
                    { 4, "Paul", "Paul", "Display Until" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 22, "Paul", "Paul", "Herbs & Spices" },
                    { 23, "Paul", "Paul", "Honey & Royal Jelly" },
                    { 24, "Paul", "Paul", "Ices & Desserts" },
                    { 25, "Paul", "Paul", "Meat & Meat Products (other than poultry)" },
                    { 26, "Paul", "Paul", "Milk & Milk Products" },
                    { 27, "Paul", "Paul", "N/A" },
                    { 28, "Paul", "Paul", "Non-Alcoholic Beverages" },
                    { 29, "Paul", "Paul", "Nuts / Nut Products / Seeds" },
                    { 21, "Paul", "Paul", "Gastropods" },
                    { 31, "Paul", "Paul", "Pet Food" },
                    { 32, "Paul", "Paul", "Poultry Meat & Poultry Meat Products" },
                    { 33, "Paul", "Paul", "Prepared Dishes & Snacks" },
                    { 34, "Paul", "Paul", "Soups / Broths / Sauces & Condiments" },
                    { 35, "Paul", "Paul", "Water" },
                    { 37, "Paul", "Paul", "Unmapped SPT Signal Value" },
                    { 36, "Paul", "Paul", "Wine" },
                    { 30, "Paul", "Paul", "Other Food Product / Mixed" },
                    { 20, "Paul", "Paul", "Fruits & Vegetables" },
                    { 2, "Paul", "Paul", "Animal by-Products" },
                    { 18, "Paul", "Paul", "Food Additives & Flavourings" },
                    { 1, "Paul", "Paul", "Undefined" },
                    { 3, "Paul", "Paul", "Alcoholic Beverages" },
                    { 4, "Paul", "Paul", "Bivalve Molluscs & Products Thereof" },
                    { 5, "Paul", "Paul", "Cephalopods & Products Thereof" },
                    { 6, "Paul", "Paul", "Cereals & Bakery Products" },
                    { 7, "Paul", "Paul", "Cocoa / Cocoa Preparations / Coffee / Tea" },
                    { 9, "Paul", "Paul", "Confectionery" },
                    { 8, "Paul", "Paul", "Compound Feeds" },
                    { 11, "Paul", "Paul", "Dietetic Foods / Food Supplements / Fortified Foods" },
                    { 12, "Paul", "Paul", "Egg & Egg Products" },
                    { 13, "Paul", "Paul", "Fats & Oils" },
                    { 14, "Paul", "Paul", "Feed Additives" },
                    { 15, "Paul", "Paul", "Feed Materials" },
                    { 16, "Paul", "Paul", "Feed Premixtures" },
                    { 17, "Paul", "Paul", "Fish & Fish Products" },
                    { 10, "Paul", "Paul", "Crustaceans & Products Thereof" },
                    { 19, "Paul", "Paul", "Food Contact Materials" }
                });

            migrationBuilder.InsertData(
                table: "SignalStatus",
                columns: new[] { "Id", "CreatedBy", "IsOpen", "IsUnassigned", "ModifiedBy", "ParentId", "Title" },
                values: new object[,]
                {
                    { 7, "Paul", false, false, "Paul", null, "Associated to Incident" },
                    { 10, "Paul", false, false, "Paul", null, "Merged to Incident" },
                    { 9, "Paul", false, false, "Paul", null, "Associated to Signal" },
                    { 8, "Paul", false, false, "Paul", null, "Converted to Signal" },
                    { 6, "Paul", false, false, "Paul", null, "Converted to Incident" },
                    { 4, "Paul", false, false, "Paul", null, "Duplicate" },
                    { 3, "Paul", false, false, "Paul", null, "Closed" },
                    { 2, "Paul", false, false, "Paul", null, "Open" },
                    { 1, "Paul", false, false, "Paul", null, "Unassigned" },
                    { 5, "Paul", false, false, "Paul", null, "Rejected" }
                });

            migrationBuilder.InsertData(
                table: "UnitQuantities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 17, "Paul", "Paul", "ppm" },
                    { 16, "Paul", "Paul", "ppb" },
                    { 15, "Paul", "Paul", "nSv" },
                    { 14, "Paul", "Paul", "mSv" },
                    { 13, "Paul", "Paul", "mg/litre" },
                    { 12, "Paul", "Paul", "mg/kg" },
                    { 11, "Paul", "Paul", "Litres" },
                    { 10, "Paul", "Paul", "kg" },
                    { 7, "Paul", "Paul", "Bq/M3" },
                    { 8, "Paul", "Paul", "Gallons" },
                    { 6, "Paul", "Paul", "Bq/M2" },
                    { 5, "Paul", "Paul", "Bq/l" },
                    { 4, "Paul", "Paul", "Bq/Kg" },
                    { 3, "Paul", "Paul", "µSv" },
                    { 2, "Paul", "Paul", "µg/kg" },
                    { 1, "Paul", "Paul", "Undefined" },
                    { 18, "Paul", "Paul", "ppt" },
                    { 9, "Paul", "Paul", "Grams" },
                    { 19, "Paul", "Paul", "tonnes" }
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
                keyValue: 3);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 17);

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
                keyValue: 3);

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
