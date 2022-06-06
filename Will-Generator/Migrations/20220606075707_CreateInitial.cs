using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Will_Generator.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstateExecutors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullnames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrefferedPaymentDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateExecutors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullnames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstateValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BurialPreference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastWishes = table.Column<string>(type: "nvarchar(max)", maxLength: 20000, nullable: false),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Charity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetailID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Charity_PersonalDetails_PersonalDetailID",
                        column: x => x.PersonalDetailID,
                        principalTable: "PersonalDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalDetailID = table.Column<int>(type: "int", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Children_PersonalDetails_PersonalDetailID",
                        column: x => x.PersonalDetailID,
                        principalTable: "PersonalDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cohabit",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalDetailID = table.Column<int>(type: "int", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentificationNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cohabit", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cohabit_PersonalDetails_PersonalDetailID",
                        column: x => x.PersonalDetailID,
                        principalTable: "PersonalDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marriage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalDetailID = table.Column<int>(type: "int", nullable: false),
                    TypeOfMarriage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentificationNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marriage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Marriage_PersonalDetails_PersonalDetailID",
                        column: x => x.PersonalDetailID,
                        principalTable: "PersonalDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrefferedHeir",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetailID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrefferedHeir", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PrefferedHeir_PersonalDetails_PersonalDetailID",
                        column: x => x.PersonalDetailID,
                        principalTable: "PersonalDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Charity_PersonalDetailID",
                table: "Charity",
                column: "PersonalDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Children_PersonalDetailID",
                table: "Children",
                column: "PersonalDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Cohabit_PersonalDetailID",
                table: "Cohabit",
                column: "PersonalDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Marriage_PersonalDetailID",
                table: "Marriage",
                column: "PersonalDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_PrefferedHeir_PersonalDetailID",
                table: "PrefferedHeir",
                column: "PersonalDetailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Charity");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "Cohabit");

            migrationBuilder.DropTable(
                name: "EstateExecutors");

            migrationBuilder.DropTable(
                name: "Marriage");

            migrationBuilder.DropTable(
                name: "PrefferedHeir");

            migrationBuilder.DropTable(
                name: "PersonalDetails");
        }
    }
}
