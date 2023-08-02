using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddIssuePatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("77c09e5a-6ffb-4f20-ac11-4dcfd75ffa0d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("80763482-7333-4a01-8fd8-f26b7a75f29d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("9875c79c-7402-4339-acd0-af0d35c9cef0"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("a1811b24-c18c-491f-af88-cd0aa2fb1f31"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("e35764c8-0092-453a-93b9-2954399a1e5b"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("e481cdb1-3997-4293-b901-b42d0b380cc2"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("ea8219c4-d796-4503-801f-3c5b1973c84b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("02d3f64b-8bac-47f6-af01-1772dc601a79"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("0363e9e8-7496-4016-b812-ea260d15d18e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("111eeca8-a8c1-416e-94f4-70d3e3db8274"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1f9a04fb-67a6-4ad6-8495-b00bd047a508"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("27745011-93d9-42d5-adca-db3a8b1c24d3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("31de0090-70e0-4ba4-9312-d6fb14bd7350"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("339c6c23-5f72-4dac-9798-4a216522067f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("67482b83-abe9-4284-9745-3b3536eeff52"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6800f603-b1f2-4c79-a7f0-0071b35a4cbf"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("79d60fef-853f-4277-aca3-fe7917477cf2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("809c8f2f-f7ab-4d21-9a2d-774104ffc690"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("84ac2c2d-5600-4fa1-a526-482c170cac6f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("8f64e8c6-3deb-42c6-82e6-9d7ed61cccf8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("93b3b5b4-2e47-47f2-ad5a-06df74cf9069"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("951a7cb0-d616-48eb-8c43-24283a49063f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9651ab33-11d6-43e9-b3d0-8f7cd610dced"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("abc4274e-cd0f-4ab1-9267-6a579a3cb0ad"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b0ff4256-29f7-4a4a-a588-a4fafbb14efd"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("c22afc5e-e2dd-40d5-9c43-be7087b25ca4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ca353e21-906e-4688-bbe2-68211a37f2d8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("cad37d55-aaf8-4658-aad9-bc8b433dec56"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("cb5687ef-fb60-4689-ac08-c711cde82aa1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("da77d4a4-b1ca-48da-9179-12c3519e7b79"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e2c2bb59-b9a9-4528-89f3-6a4ef07f5651"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e31fe1aa-7d41-4975-8af5-d34592497d9f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("eaeb6e0a-f1c7-490c-bf70-660ba9222e89"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ebad9b47-bd97-44d2-b25f-b016fc82d156"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ed1fd551-0825-43b8-9448-96d4d8db2566"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f0747687-641a-4fa8-bc5e-3698a9fd26f1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ff4fdac0-41fb-4a53-9314-916a99bca50d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0c9b8333-3133-4d48-a8e1-c1cea7531d28"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("31263557-9d5f-4122-ae33-80291ebda99b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4e5e9239-303f-4970-83fa-2c9d96501202"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7c2748f1-542e-481d-ae6f-3540363d25f2"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7f4513f5-e94c-4a28-97d3-01d2e7db429a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("962c812c-8b9f-4d0f-adbb-6687598e9686"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d07b2127-63bf-4a99-a088-1439b7abc716"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d20c0117-f1d6-47fe-847e-e54f5db5d1b2"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("dda8c822-2b70-482f-885f-f21c78b09ae0"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("def6ead3-40b8-4a09-8400-7ef4860cc3c6"));

            migrationBuilder.CreateTable(
                name: "IssuePatient",
                columns: table => new
                {
                    IssuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuePatient", x => new { x.IssuesId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_IssuePatient_Issues_IssuesId",
                        column: x => x.IssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuePatient_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerofrmancRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"), "Judy", 19, 48498m, "Dermatology" },
                    { new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"), "Rafael", 97, 12266m, "Pediatrics" },
                    { new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"), "Naomi", 27, 32145m, "Pediatrics" },
                    { new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"), "Paula", 0, 19094m, "Urology" },
                    { new Guid("7f52bb02-18b1-4408-aafe-46b78e6b1d36"), "Joann", 72, 9232m, "Hematology" },
                    { new Guid("97225962-a3e6-4164-afee-4890316219a9"), "Jessie", 65, 27064m, "Hematology" },
                    { new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"), "Alyssa", 79, 16586m, "Gastroenterology" },
                    { new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"), "Mable", 5, 33706m, "Infectious Disease" },
                    { new Guid("c48f6ce2-3d99-4292-b559-baf240066b49"), "Sara", 82, 45041m, "Pediatrics" },
                    { new Guid("cda184ab-a264-4e17-be85-936a9e48cee0"), "Judy", 32, 18711m, "Neurology" }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0b0b0a0b-da53-4479-a1f2-d7941d86e3f1"), "Flu" },
                    { new Guid("0fb93ac5-da32-4e92-9e31-37f87169212a"), "Arthritis" },
                    { new Guid("36c53a71-4207-43cb-a75e-0468b2ff07d4"), "Allergy" },
                    { new Guid("51f4b325-e243-4ff8-be07-8e9bf691a318"), "Hypertension" },
                    { new Guid("a24c44ad-95e0-4932-8bf3-ef9034b96f94"), "Diabetes" },
                    { new Guid("ca98f47e-0990-4c2d-978e-09368d4b1087"), "Asthma" },
                    { new Guid("d062eabd-5fc2-4492-b526-615c1a068f17"), "Depression" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "DoctorId", "Name" },
                values: new object[,]
                {
                    { new Guid("056a1606-1987-4c4b-b575-1b6654f57d8c"), new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"), "Orlando" },
                    { new Guid("1816d481-1111-46e8-9a58-03c8a4bbae8b"), new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"), "Tasha" },
                    { new Guid("1a4be103-2933-4535-a3e5-2b4a4e65bfe4"), new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"), "Miriam" },
                    { new Guid("20c6a260-18b2-4d05-a79a-92b9bd1b1531"), new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"), "Beth" },
                    { new Guid("26237d35-c325-4598-bf3d-fcf18b2e54a4"), new Guid("c48f6ce2-3d99-4292-b559-baf240066b49"), "Damon" },
                    { new Guid("3b5766e3-f644-445b-98bf-10c61d094d93"), new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"), "Joe" },
                    { new Guid("423afa12-31ee-4516-a1ba-f6c39d715c09"), new Guid("7f52bb02-18b1-4408-aafe-46b78e6b1d36"), "Sandy" },
                    { new Guid("550f318f-0aa2-44f8-b85b-aecc53d42cd9"), new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"), "Stephanie" },
                    { new Guid("56acd34f-2436-49b8-bfe8-5d826c8ae458"), new Guid("97225962-a3e6-4164-afee-4890316219a9"), "Erma" },
                    { new Guid("5ced8a42-b135-4d66-a860-43be12b4f778"), new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"), "Maggie" },
                    { new Guid("5eabf55d-3f3b-4a43-b67c-a2c2666b6c9c"), new Guid("97225962-a3e6-4164-afee-4890316219a9"), "Krystal" },
                    { new Guid("6450b07a-b86d-4db7-aefd-922457274719"), new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"), "Gretchen" },
                    { new Guid("6c4cb1a2-9bb6-42c1-9b37-585fc318523e"), new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"), "Marvin" },
                    { new Guid("74bea655-3096-4d4c-a42e-18dcdf27dcd1"), new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"), "Wendell" },
                    { new Guid("801a65f4-f68f-44a2-8259-e067c6b23308"), new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"), "Lloyd" },
                    { new Guid("b174ef30-6134-477a-a8a5-56cd6f63eaf7"), new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"), "Jerry" },
                    { new Guid("b1eb033a-46d4-4945-831a-44f8afcf0702"), new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"), "Mitchell" },
                    { new Guid("c3156684-7bf9-4a07-b636-e0826f61bb21"), new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"), "Sandra" },
                    { new Guid("cef3e1b5-d6d9-4300-b8b4-38cfe2282c6a"), new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"), "Lamar" },
                    { new Guid("d33c8283-652e-43a3-bcba-15a3127e9045"), new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"), "Wilbert" },
                    { new Guid("dee2daab-0f63-41a5-89f8-27c2c9471358"), new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"), "Dana" },
                    { new Guid("dfdfc5b0-cac9-44bf-8289-4699b4144a1a"), new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"), "Ervin" },
                    { new Guid("e3941d18-dbea-4987-80e5-207a95245111"), new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"), "Juan" },
                    { new Guid("e614b831-9c2d-40e7-84c1-b28318e5555c"), new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"), "Bridget" },
                    { new Guid("e7a97a6c-b75e-4fda-b857-53fd26a20079"), new Guid("cda184ab-a264-4e17-be85-936a9e48cee0"), "Roosevelt" },
                    { new Guid("e7be5cbb-1a94-48a7-a869-a352fe40f3eb"), new Guid("cda184ab-a264-4e17-be85-936a9e48cee0"), "Max" },
                    { new Guid("f1f0699f-2323-44e9-9824-3dbfbb81a141"), new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"), "Terence" },
                    { new Guid("f662257c-ea40-44e1-a9a4-3aac0ca16e8a"), new Guid("c48f6ce2-3d99-4292-b559-baf240066b49"), "Eduardo" },
                    { new Guid("f6c44400-ba1a-4e90-9546-2c77c9d56330"), new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"), "Isaac" },
                    { new Guid("fd749cfa-82f2-45b3-9bca-3fe429548879"), new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"), "Gwendolyn" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssuePatient_PatientsId",
                table: "IssuePatient",
                column: "PatientsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuePatient");

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("0b0b0a0b-da53-4479-a1f2-d7941d86e3f1"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("0fb93ac5-da32-4e92-9e31-37f87169212a"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("36c53a71-4207-43cb-a75e-0468b2ff07d4"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("51f4b325-e243-4ff8-be07-8e9bf691a318"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("a24c44ad-95e0-4932-8bf3-ef9034b96f94"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("ca98f47e-0990-4c2d-978e-09368d4b1087"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("d062eabd-5fc2-4492-b526-615c1a068f17"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("056a1606-1987-4c4b-b575-1b6654f57d8c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1816d481-1111-46e8-9a58-03c8a4bbae8b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1a4be103-2933-4535-a3e5-2b4a4e65bfe4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("20c6a260-18b2-4d05-a79a-92b9bd1b1531"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("26237d35-c325-4598-bf3d-fcf18b2e54a4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3b5766e3-f644-445b-98bf-10c61d094d93"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("423afa12-31ee-4516-a1ba-f6c39d715c09"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("550f318f-0aa2-44f8-b85b-aecc53d42cd9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("56acd34f-2436-49b8-bfe8-5d826c8ae458"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("5ced8a42-b135-4d66-a860-43be12b4f778"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("5eabf55d-3f3b-4a43-b67c-a2c2666b6c9c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6450b07a-b86d-4db7-aefd-922457274719"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6c4cb1a2-9bb6-42c1-9b37-585fc318523e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("74bea655-3096-4d4c-a42e-18dcdf27dcd1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("801a65f4-f68f-44a2-8259-e067c6b23308"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b174ef30-6134-477a-a8a5-56cd6f63eaf7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b1eb033a-46d4-4945-831a-44f8afcf0702"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("c3156684-7bf9-4a07-b636-e0826f61bb21"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("cef3e1b5-d6d9-4300-b8b4-38cfe2282c6a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d33c8283-652e-43a3-bcba-15a3127e9045"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("dee2daab-0f63-41a5-89f8-27c2c9471358"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("dfdfc5b0-cac9-44bf-8289-4699b4144a1a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e3941d18-dbea-4987-80e5-207a95245111"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e614b831-9c2d-40e7-84c1-b28318e5555c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e7a97a6c-b75e-4fda-b857-53fd26a20079"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e7be5cbb-1a94-48a7-a869-a352fe40f3eb"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f1f0699f-2323-44e9-9824-3dbfbb81a141"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f662257c-ea40-44e1-a9a4-3aac0ca16e8a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f6c44400-ba1a-4e90-9546-2c77c9d56330"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("fd749cfa-82f2-45b3-9bca-3fe429548879"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7f52bb02-18b1-4408-aafe-46b78e6b1d36"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("97225962-a3e6-4164-afee-4890316219a9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c48f6ce2-3d99-4292-b559-baf240066b49"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cda184ab-a264-4e17-be85-936a9e48cee0"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerofrmancRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("0c9b8333-3133-4d48-a8e1-c1cea7531d28"), "Sara", 82, 45041m, "Pediatrics" },
                    { new Guid("31263557-9d5f-4122-ae33-80291ebda99b"), "Mable", 5, 33706m, "Infectious Disease" },
                    { new Guid("4e5e9239-303f-4970-83fa-2c9d96501202"), "Rafael", 97, 12266m, "Pediatrics" },
                    { new Guid("7c2748f1-542e-481d-ae6f-3540363d25f2"), "Jessie", 65, 27064m, "Hematology" },
                    { new Guid("7f4513f5-e94c-4a28-97d3-01d2e7db429a"), "Alyssa", 79, 16586m, "Gastroenterology" },
                    { new Guid("962c812c-8b9f-4d0f-adbb-6687598e9686"), "Judy", 19, 48498m, "Dermatology" },
                    { new Guid("d07b2127-63bf-4a99-a088-1439b7abc716"), "Naomi", 27, 32145m, "Pediatrics" },
                    { new Guid("d20c0117-f1d6-47fe-847e-e54f5db5d1b2"), "Paula", 0, 19094m, "Urology" },
                    { new Guid("dda8c822-2b70-482f-885f-f21c78b09ae0"), "Judy", 32, 18711m, "Neurology" },
                    { new Guid("def6ead3-40b8-4a09-8400-7ef4860cc3c6"), "Joann", 72, 9232m, "Hematology" }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("77c09e5a-6ffb-4f20-ac11-4dcfd75ffa0d"), "Asthma" },
                    { new Guid("80763482-7333-4a01-8fd8-f26b7a75f29d"), "Diabetes" },
                    { new Guid("9875c79c-7402-4339-acd0-af0d35c9cef0"), "Hypertension" },
                    { new Guid("a1811b24-c18c-491f-af88-cd0aa2fb1f31"), "Arthritis" },
                    { new Guid("e35764c8-0092-453a-93b9-2954399a1e5b"), "Flu" },
                    { new Guid("e481cdb1-3997-4293-b901-b42d0b380cc2"), "Depression" },
                    { new Guid("ea8219c4-d796-4503-801f-3c5b1973c84b"), "Allergy" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "DoctorId", "Name" },
                values: new object[,]
                {
                    { new Guid("02d3f64b-8bac-47f6-af01-1772dc601a79"), new Guid("4e5e9239-303f-4970-83fa-2c9d96501202"), "Miriam" },
                    { new Guid("0363e9e8-7496-4016-b812-ea260d15d18e"), new Guid("4e5e9239-303f-4970-83fa-2c9d96501202"), "Wendell" },
                    { new Guid("111eeca8-a8c1-416e-94f4-70d3e3db8274"), new Guid("7c2748f1-542e-481d-ae6f-3540363d25f2"), "Erma" },
                    { new Guid("1f9a04fb-67a6-4ad6-8495-b00bd047a508"), new Guid("d20c0117-f1d6-47fe-847e-e54f5db5d1b2"), "Terence" },
                    { new Guid("27745011-93d9-42d5-adca-db3a8b1c24d3"), new Guid("dda8c822-2b70-482f-885f-f21c78b09ae0"), "Max" },
                    { new Guid("31de0090-70e0-4ba4-9312-d6fb14bd7350"), new Guid("0c9b8333-3133-4d48-a8e1-c1cea7531d28"), "Eduardo" },
                    { new Guid("339c6c23-5f72-4dac-9798-4a216522067f"), new Guid("7c2748f1-542e-481d-ae6f-3540363d25f2"), "Krystal" },
                    { new Guid("67482b83-abe9-4284-9745-3b3536eeff52"), new Guid("d20c0117-f1d6-47fe-847e-e54f5db5d1b2"), "Joe" },
                    { new Guid("6800f603-b1f2-4c79-a7f0-0071b35a4cbf"), new Guid("31263557-9d5f-4122-ae33-80291ebda99b"), "Stephanie" },
                    { new Guid("79d60fef-853f-4277-aca3-fe7917477cf2"), new Guid("7f4513f5-e94c-4a28-97d3-01d2e7db429a"), "Tasha" },
                    { new Guid("809c8f2f-f7ab-4d21-9a2d-774104ffc690"), new Guid("0c9b8333-3133-4d48-a8e1-c1cea7531d28"), "Damon" },
                    { new Guid("84ac2c2d-5600-4fa1-a526-482c170cac6f"), new Guid("d20c0117-f1d6-47fe-847e-e54f5db5d1b2"), "Isaac" },
                    { new Guid("8f64e8c6-3deb-42c6-82e6-9d7ed61cccf8"), new Guid("d20c0117-f1d6-47fe-847e-e54f5db5d1b2"), "Gretchen" },
                    { new Guid("93b3b5b4-2e47-47f2-ad5a-06df74cf9069"), new Guid("7f4513f5-e94c-4a28-97d3-01d2e7db429a"), "Dana" },
                    { new Guid("951a7cb0-d616-48eb-8c43-24283a49063f"), new Guid("31263557-9d5f-4122-ae33-80291ebda99b"), "Mitchell" },
                    { new Guid("9651ab33-11d6-43e9-b3d0-8f7cd610dced"), new Guid("962c812c-8b9f-4d0f-adbb-6687598e9686"), "Sandra" },
                    { new Guid("abc4274e-cd0f-4ab1-9267-6a579a3cb0ad"), new Guid("962c812c-8b9f-4d0f-adbb-6687598e9686"), "Lamar" },
                    { new Guid("b0ff4256-29f7-4a4a-a588-a4fafbb14efd"), new Guid("4e5e9239-303f-4970-83fa-2c9d96501202"), "Maggie" },
                    { new Guid("c22afc5e-e2dd-40d5-9c43-be7087b25ca4"), new Guid("d20c0117-f1d6-47fe-847e-e54f5db5d1b2"), "Ervin" },
                    { new Guid("ca353e21-906e-4688-bbe2-68211a37f2d8"), new Guid("7f4513f5-e94c-4a28-97d3-01d2e7db429a"), "Marvin" },
                    { new Guid("cad37d55-aaf8-4658-aad9-bc8b433dec56"), new Guid("d07b2127-63bf-4a99-a088-1439b7abc716"), "Bridget" },
                    { new Guid("cb5687ef-fb60-4689-ac08-c711cde82aa1"), new Guid("d07b2127-63bf-4a99-a088-1439b7abc716"), "Lloyd" },
                    { new Guid("da77d4a4-b1ca-48da-9179-12c3519e7b79"), new Guid("d07b2127-63bf-4a99-a088-1439b7abc716"), "Gwendolyn" },
                    { new Guid("e2c2bb59-b9a9-4528-89f3-6a4ef07f5651"), new Guid("4e5e9239-303f-4970-83fa-2c9d96501202"), "Wilbert" },
                    { new Guid("e31fe1aa-7d41-4975-8af5-d34592497d9f"), new Guid("dda8c822-2b70-482f-885f-f21c78b09ae0"), "Roosevelt" },
                    { new Guid("eaeb6e0a-f1c7-490c-bf70-660ba9222e89"), new Guid("def6ead3-40b8-4a09-8400-7ef4860cc3c6"), "Sandy" },
                    { new Guid("ebad9b47-bd97-44d2-b25f-b016fc82d156"), new Guid("4e5e9239-303f-4970-83fa-2c9d96501202"), "Juan" },
                    { new Guid("ed1fd551-0825-43b8-9448-96d4d8db2566"), new Guid("962c812c-8b9f-4d0f-adbb-6687598e9686"), "Beth" },
                    { new Guid("f0747687-641a-4fa8-bc5e-3698a9fd26f1"), new Guid("d20c0117-f1d6-47fe-847e-e54f5db5d1b2"), "Jerry" },
                    { new Guid("ff4fdac0-41fb-4a53-9314-916a99bca50d"), new Guid("31263557-9d5f-4122-ae33-80291ebda99b"), "Orlando" }
                });
        }
    }
}
