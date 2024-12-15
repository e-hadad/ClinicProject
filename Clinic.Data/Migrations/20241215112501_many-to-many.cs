using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPatient",
                table: "ListRoutes",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "IdDoctor",
                table: "ListRoutes",
                newName: "DoctorId");

            migrationBuilder.CreateTable(
                name: "DoctorClassPatientClass",
                columns: table => new
                {
                    DoctorsId = table.Column<int>(type: "int", nullable: false),
                    PatientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorClassPatientClass", x => new { x.DoctorsId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_DoctorClassPatientClass_ListDoctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "ListDoctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorClassPatientClass_ListPatient_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "ListPatient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListRoutes_DoctorId",
                table: "ListRoutes",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ListRoutes_PatientId",
                table: "ListRoutes",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClassPatientClass_PatientsId",
                table: "DoctorClassPatientClass",
                column: "PatientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListRoutes_ListDoctors_DoctorId",
                table: "ListRoutes",
                column: "DoctorId",
                principalTable: "ListDoctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListRoutes_ListPatient_PatientId",
                table: "ListRoutes",
                column: "PatientId",
                principalTable: "ListPatient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListRoutes_ListDoctors_DoctorId",
                table: "ListRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_ListRoutes_ListPatient_PatientId",
                table: "ListRoutes");

            migrationBuilder.DropTable(
                name: "DoctorClassPatientClass");

            migrationBuilder.DropIndex(
                name: "IX_ListRoutes_DoctorId",
                table: "ListRoutes");

            migrationBuilder.DropIndex(
                name: "IX_ListRoutes_PatientId",
                table: "ListRoutes");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "ListRoutes",
                newName: "IdPatient");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "ListRoutes",
                newName: "IdDoctor");
        }
    }
}
