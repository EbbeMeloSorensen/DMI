using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMI.SMS.Persistence.EntityFrameworkCore.Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SensorLocations",
                columns: table => new
                {
                    GdbArchiveOid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StationidDMI = table.Column<int>(type: "INTEGER", nullable: true),
                    AccessAddress = table.Column<string>(type: "TEXT", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateTo = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    BaroLevel = table.Column<double>(type: "REAL", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: true),
                    Sl_utm = table.Column<int>(type: "INTEGER", nullable: true),
                    Sl_northing = table.Column<double>(type: "REAL", nullable: true),
                    Sl_easting = table.Column<double>(type: "REAL", nullable: true),
                    Sl_geo_lat = table.Column<double>(type: "REAL", nullable: true),
                    Sl_geo_long = table.Column<double>(type: "REAL", nullable: true),
                    GlobalId = table.Column<string>(type: "TEXT", nullable: false),
                    ObjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedUser = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastEditedUser = table.Column<string>(type: "TEXT", nullable: true),
                    LastEditedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    GdbFromDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GdbToDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorLocations", x => x.GdbArchiveOid);
                });

            migrationBuilder.CreateTable(
                name: "StationInformations",
                columns: table => new
                {
                    gdb_archive_oid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    stationname = table.Column<string>(type: "TEXT", nullable: true),
                    stationid_dmi = table.Column<int>(type: "INTEGER", nullable: true),
                    stationtype = table.Column<int>(type: "INTEGER", nullable: true),
                    accessaddress = table.Column<string>(type: "TEXT", nullable: true),
                    country = table.Column<int>(type: "INTEGER", nullable: true),
                    status = table.Column<int>(type: "INTEGER", nullable: true),
                    datefrom = table.Column<DateTime>(type: "TEXT", nullable: true),
                    dateto = table.Column<DateTime>(type: "TEXT", nullable: true),
                    stationOwner = table.Column<int>(type: "INTEGER", nullable: true),
                    comment = table.Column<string>(type: "TEXT", nullable: true),
                    stationid_icao = table.Column<string>(type: "TEXT", nullable: true),
                    referencetomaintenanceagreement = table.Column<string>(type: "TEXT", nullable: true),
                    facilityid = table.Column<string>(type: "TEXT", nullable: true),
                    si_utm = table.Column<int>(type: "INTEGER", nullable: true),
                    si_northing = table.Column<double>(type: "REAL", nullable: true),
                    si_easting = table.Column<double>(type: "REAL", nullable: true),
                    si_geo_lat = table.Column<double>(type: "REAL", nullable: true),
                    si_geo_long = table.Column<double>(type: "REAL", nullable: true),
                    serviceinterval = table.Column<int>(type: "INTEGER", nullable: true),
                    lastservicedate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    nextservicedate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    addworkforcedate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    lastvisitdate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    altstationid = table.Column<string>(type: "TEXT", nullable: true),
                    wmostationid = table.Column<string>(type: "TEXT", nullable: true),
                    regionid = table.Column<string>(type: "TEXT", nullable: true),
                    wigosid = table.Column<string>(type: "TEXT", nullable: true),
                    wmocountrycode = table.Column<string>(type: "TEXT", nullable: true),
                    hha = table.Column<double>(type: "REAL", nullable: true),
                    hhp = table.Column<double>(type: "REAL", nullable: true),
                    wmorbsn = table.Column<int>(type: "INTEGER", nullable: true),
                    wmorbcn = table.Column<int>(type: "INTEGER", nullable: true),
                    wmorbsnradio = table.Column<int>(type: "INTEGER", nullable: true),
                    wgs_lat = table.Column<double>(type: "REAL", nullable: true),
                    wgs_long = table.Column<double>(type: "REAL", nullable: true),
                    Shape = table.Column<string>(type: "TEXT", nullable: true),
                    globalid = table.Column<string>(type: "TEXT", nullable: false),
                    objectid = table.Column<int>(type: "INTEGER", nullable: false),
                    created_user = table.Column<string>(type: "TEXT", nullable: true),
                    created_date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    last_edited_user = table.Column<string>(type: "TEXT", nullable: true),
                    last_edited_date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    gdb_from_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    gdb_to_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationInformations", x => x.gdb_archive_oid);
                });

            migrationBuilder.CreateTable(
                name: "ElevationAngles",
                columns: table => new
                {
                    GdbArchiveOid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateFrom = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Angle_N = table.Column<int>(type: "INTEGER", nullable: true),
                    Angle_NE = table.Column<int>(type: "INTEGER", nullable: true),
                    Angle_E = table.Column<int>(type: "INTEGER", nullable: true),
                    Angle_SE = table.Column<int>(type: "INTEGER", nullable: true),
                    Angle_S = table.Column<int>(type: "INTEGER", nullable: true),
                    Angle_SW = table.Column<int>(type: "INTEGER", nullable: true),
                    Angle_W = table.Column<int>(type: "INTEGER", nullable: true),
                    Angle_NW = table.Column<int>(type: "INTEGER", nullable: true),
                    AngleIndex = table.Column<int>(type: "INTEGER", nullable: true),
                    AngleComment = table.Column<string>(type: "TEXT", nullable: true),
                    ServiceId = table.Column<string>(type: "TEXT", nullable: true),
                    GlobalId = table.Column<string>(type: "TEXT", nullable: false),
                    ObjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedUser = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastEditedUser = table.Column<string>(type: "TEXT", nullable: true),
                    LastEditedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    GdbFromDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GdbToDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ParentGuid = table.Column<string>(type: "TEXT", nullable: false),
                    ParentGdbArchiveOid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElevationAngles", x => x.GdbArchiveOid);
                    table.ForeignKey(
                        name: "FK_ElevationAngles_SensorLocations_ParentGdbArchiveOid",
                        column: x => x.ParentGdbArchiveOid,
                        principalTable: "SensorLocations",
                        principalColumn: "GdbArchiveOid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactPersons",
                columns: table => new
                {
                    GdbArchiveOid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    GlobalId = table.Column<string>(type: "TEXT", nullable: false),
                    ObjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedUser = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastEditedUser = table.Column<string>(type: "TEXT", nullable: true),
                    LastEditedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    GdbFromDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GdbToDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ParentGuid = table.Column<string>(type: "TEXT", nullable: false),
                    ParentGdbArchiveOid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPersons", x => x.GdbArchiveOid);
                    table.ForeignKey(
                        name: "FK_ContactPersons_StationInformations_ParentGdbArchiveOid",
                        column: x => x.ParentGdbArchiveOid,
                        principalTable: "StationInformations",
                        principalColumn: "gdb_archive_oid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceVisitReports",
                columns: table => new
                {
                    GdbArchiveOid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ServiceId = table.Column<string>(type: "TEXT", nullable: true),
                    GlobalId = table.Column<string>(type: "TEXT", nullable: false),
                    ObjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedUser = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastEditedUser = table.Column<string>(type: "TEXT", nullable: true),
                    LastEditedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    GdbFromDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GdbToDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ParentGuid = table.Column<string>(type: "TEXT", nullable: false),
                    ParentGdbArchiveOid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceVisitReports", x => x.GdbArchiveOid);
                    table.ForeignKey(
                        name: "FK_ServiceVisitReports_StationInformations_ParentGdbArchiveOid",
                        column: x => x.ParentGdbArchiveOid,
                        principalTable: "StationInformations",
                        principalColumn: "gdb_archive_oid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactPersons_ParentGdbArchiveOid",
                table: "ContactPersons",
                column: "ParentGdbArchiveOid");

            migrationBuilder.CreateIndex(
                name: "IX_ElevationAngles_ParentGdbArchiveOid",
                table: "ElevationAngles",
                column: "ParentGdbArchiveOid");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceVisitReports_ParentGdbArchiveOid",
                table: "ServiceVisitReports",
                column: "ParentGdbArchiveOid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactPersons");

            migrationBuilder.DropTable(
                name: "ElevationAngles");

            migrationBuilder.DropTable(
                name: "ServiceVisitReports");

            migrationBuilder.DropTable(
                name: "SensorLocations");

            migrationBuilder.DropTable(
                name: "StationInformations");
        }
    }
}
