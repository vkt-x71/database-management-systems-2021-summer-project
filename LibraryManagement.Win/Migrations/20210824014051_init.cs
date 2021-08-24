using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LibraryManagement.Win.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbperson",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    surname = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbperson", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbpublicationtype",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbpublicationtype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbpublishhome",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbpublishhome", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbrole",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    add = table.Column<bool>(nullable: true),
                    edit = table.Column<bool>(nullable: false),
                    delete = table.Column<bool>(nullable: false),
                    bookGive = table.Column<bool>(nullable: false),
                    bookReturn = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbrole", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbsettings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    readDayLimit = table.Column<int>(nullable: false),
                    libraryName = table.Column<string>(unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbsettings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbmember",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personId = table.Column<int>(nullable: false),
                    registerDate = table.Column<DateTime>(type: "timestamp", nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbmember", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbmember_tbperson",
                        column: x => x.personId,
                        principalTable: "tbperson",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbwriter",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personId = table.Column<int>(nullable: false),
                    biography = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbwriter", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbwriter_tbperson",
                        column: x => x.personId,
                        principalTable: "tbperson",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbpublication",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    publishHomeId = table.Column<int>(nullable: false),
                    publicationTypeId = table.Column<int>(nullable: false),
                    name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    registerNumber = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    classifcationNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    pageCount = table.Column<int>(nullable: false),
                    ISBN = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbpublication", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbpublication_tbpublication",
                        column: x => x.publicationTypeId,
                        principalTable: "tbpublication",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbpublication_tbpublishhome",
                        column: x => x.publishHomeId,
                        principalTable: "tbpublishhome",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbmanager",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personId = table.Column<int>(nullable: false),
                    roleId = table.Column<int>(nullable: false),
                    userName = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    pass = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbmanager", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbmanager_tbperson",
                        column: x => x.personId,
                        principalTable: "tbperson",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbmanager_tbrole",
                        column: x => x.roleId,
                        principalTable: "tbrole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbaction",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personId = table.Column<int>(nullable: false),
                    publicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbaction", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbaction_tbperson",
                        column: x => x.personId,
                        principalTable: "tbperson",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbaction_tbpublication",
                        column: x => x.publicationId,
                        principalTable: "tbpublication",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbbook",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    publicationId = table.Column<int>(nullable: false),
                    coverText = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbook", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbbook_tbpublication",
                        column: x => x.publicationId,
                        principalTable: "tbpublication",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbmagazine",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    publicationId = table.Column<int>(nullable: false),
                    period = table.Column<int>(nullable: false),
                    number = table.Column<int>(nullable: false),
                    publishDate = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbmagazine", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbmagazine_tbpublication",
                        column: x => x.publicationId,
                        principalTable: "tbpublication",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbpenalty",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personId = table.Column<int>(nullable: false),
                    actionId = table.Column<int>(nullable: false),
                    penaltyTime = table.Column<DateTime>(type: "timestamp", nullable: false),
                    penaltyEndTime = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbpenalty", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbpenalty_tbaction",
                        column: x => x.actionId,
                        principalTable: "tbaction",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbpenalty_tbperson",
                        column: x => x.personId,
                        principalTable: "tbperson",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbbookwriter",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bookId = table.Column<int>(nullable: false),
                    writerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbookwriter", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbbookwriter_tbbook",
                        column: x => x.bookId,
                        principalTable: "tbbook",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbbookwriter_tbwriter",
                        column: x => x.writerId,
                        principalTable: "tbwriter",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbaction_personId",
                table: "tbaction",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_tbaction_publicationId",
                table: "tbaction",
                column: "publicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbbook_publicationId",
                table: "tbbook",
                column: "publicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbbookwriter_bookId",
                table: "tbbookwriter",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_tbbookwriter_writerId",
                table: "tbbookwriter",
                column: "writerId");

            migrationBuilder.CreateIndex(
                name: "IX_tbmagazine_publicationId",
                table: "tbmagazine",
                column: "publicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbmanager_personId",
                table: "tbmanager",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_tbmanager_roleId",
                table: "tbmanager",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbmember_personId",
                table: "tbmember",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_tbpenalty_actionId",
                table: "tbpenalty",
                column: "actionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbpenalty_personId",
                table: "tbpenalty",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_tbpublication_publicationTypeId",
                table: "tbpublication",
                column: "publicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbpublication_publishHomeId",
                table: "tbpublication",
                column: "publishHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbwriter_personId",
                table: "tbwriter",
                column: "personId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbbookwriter");

            migrationBuilder.DropTable(
                name: "tbmagazine");

            migrationBuilder.DropTable(
                name: "tbmanager");

            migrationBuilder.DropTable(
                name: "tbmember");

            migrationBuilder.DropTable(
                name: "tbpenalty");

            migrationBuilder.DropTable(
                name: "tbpublicationtype");

            migrationBuilder.DropTable(
                name: "tbsettings");

            migrationBuilder.DropTable(
                name: "tbbook");

            migrationBuilder.DropTable(
                name: "tbwriter");

            migrationBuilder.DropTable(
                name: "tbrole");

            migrationBuilder.DropTable(
                name: "tbaction");

            migrationBuilder.DropTable(
                name: "tbperson");

            migrationBuilder.DropTable(
                name: "tbpublication");

            migrationBuilder.DropTable(
                name: "tbpublishhome");
        }
    }
}
