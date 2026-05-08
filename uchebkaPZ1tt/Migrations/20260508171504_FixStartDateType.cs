using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uchebkaPZ1tt.Migrations
{
    /// <inheritdoc />
    public partial class FixStartDateType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inputDataUsers",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false),
                    fio = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<long>(type: "bigint", nullable: true),
                    login = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.userID);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "inputDataRequests",
                columns: table => new
                {
                    requestID = table.Column<int>(type: "int", nullable: false),
                    startDate = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computerTechType = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computerTechModel = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    problemDescryption = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    requestStatus = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    completionDate = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    repairParts = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    masterID = table.Column<int>(type: "int", nullable: true),
                    clientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.requestID);
                    table.ForeignKey(
                        name: "FK_KID",
                        column: x => x.clientID,
                        principalTable: "inputDataUsers",
                        principalColumn: "userID");
                    table.ForeignKey(
                        name: "FK_MIDD",
                        column: x => x.masterID,
                        principalTable: "inputDataUsers",
                        principalColumn: "userID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "inputDataComments",
                columns: table => new
                {
                    commentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    message = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    masterID = table.Column<int>(type: "int", nullable: true),
                    requestID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.commentID);
                    table.ForeignKey(
                        name: "FK_MID",
                        column: x => x.masterID,
                        principalTable: "inputDataUsers",
                        principalColumn: "userID");
                    table.ForeignKey(
                        name: "FK_RID",
                        column: x => x.requestID,
                        principalTable: "inputDataRequests",
                        principalColumn: "requestID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "FK_MID_idx",
                table: "inputDataComments",
                column: "masterID");

            migrationBuilder.CreateIndex(
                name: "FK_MIDD_idx",
                table: "inputDataComments",
                column: "requestID");

            migrationBuilder.CreateIndex(
                name: "FK_KID_idx",
                table: "inputDataRequests",
                column: "clientID");

            migrationBuilder.CreateIndex(
                name: "FK_MIDD_idx1",
                table: "inputDataRequests",
                column: "masterID");

            migrationBuilder.CreateIndex(
                name: "phone_UNIQUE",
                table: "inputDataUsers",
                column: "phone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inputDataComments");

            migrationBuilder.DropTable(
                name: "inputDataRequests");

            migrationBuilder.DropTable(
                name: "inputDataUsers");
        }
    }
}
