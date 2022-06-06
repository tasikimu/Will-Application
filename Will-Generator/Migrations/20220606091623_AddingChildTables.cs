using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Will_Generator.Migrations
{
    public partial class AddingChildTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_PersonalDetails_PersonalDetailID",
                table: "Children");

            migrationBuilder.DropForeignKey(
                name: "FK_Cohabit_PersonalDetails_PersonalDetailID",
                table: "Cohabit");

            migrationBuilder.DropForeignKey(
                name: "FK_Marriage_PersonalDetails_PersonalDetailID",
                table: "Marriage");

            migrationBuilder.DropIndex(
                name: "IX_Marriage_PersonalDetailID",
                table: "Marriage");

            migrationBuilder.DropColumn(
                name: "PersonalDetailID",
                table: "Marriage");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "EstateExecutors");

            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "EstateExecutors");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "EstateExecutors");

            migrationBuilder.DropColumn(
                name: "BranchCode",
                table: "EstateExecutors");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "EstateExecutors");

            migrationBuilder.DropColumn(
                name: "PrefferedPaymentDate",
                table: "EstateExecutors");

            migrationBuilder.AddColumn<int>(
                name: "MarriagesID",
                table: "PersonalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDetailID",
                table: "Cohabit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDetailID",
                table: "Children",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deductions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstateExecutorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bank_EstateExecutors_EstateExecutorID",
                        column: x => x.EstateExecutorID,
                        principalTable: "EstateExecutors",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_MarriagesID",
                table: "PersonalDetails",
                column: "MarriagesID");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_EstateExecutorID",
                table: "Bank",
                column: "EstateExecutorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_PersonalDetails_PersonalDetailID",
                table: "Children",
                column: "PersonalDetailID",
                principalTable: "PersonalDetails",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cohabit_PersonalDetails_PersonalDetailID",
                table: "Cohabit",
                column: "PersonalDetailID",
                principalTable: "PersonalDetails",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetails_Marriage_MarriagesID",
                table: "PersonalDetails",
                column: "MarriagesID",
                principalTable: "Marriage",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_PersonalDetails_PersonalDetailID",
                table: "Children");

            migrationBuilder.DropForeignKey(
                name: "FK_Cohabit_PersonalDetails_PersonalDetailID",
                table: "Cohabit");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetails_Marriage_MarriagesID",
                table: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDetails_MarriagesID",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "MarriagesID",
                table: "PersonalDetails");

            migrationBuilder.AddColumn<int>(
                name: "PersonalDetailID",
                table: "Marriage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "EstateExecutors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AccountType",
                table: "EstateExecutors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "EstateExecutors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BranchCode",
                table: "EstateExecutors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "EstateExecutors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrefferedPaymentDate",
                table: "EstateExecutors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDetailID",
                table: "Cohabit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDetailID",
                table: "Children",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marriage_PersonalDetailID",
                table: "Marriage",
                column: "PersonalDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_PersonalDetails_PersonalDetailID",
                table: "Children",
                column: "PersonalDetailID",
                principalTable: "PersonalDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cohabit_PersonalDetails_PersonalDetailID",
                table: "Cohabit",
                column: "PersonalDetailID",
                principalTable: "PersonalDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marriage_PersonalDetails_PersonalDetailID",
                table: "Marriage",
                column: "PersonalDetailID",
                principalTable: "PersonalDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
