using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingManagement.WebApi.Migrations
{
    public partial class AddReferentialEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DegreeUv");

            migrationBuilder.DropTable(
                name: "ProjectTrainingTeamMember");

            migrationBuilder.DropTable(
                name: "Run_EvaluationIndividualProjectSkill");

            migrationBuilder.DropTable(
                name: "Run_ProjectTrainingTeamMember");

            migrationBuilder.DropTable(
                name: "Run_StudentGroup");

            migrationBuilder.DropTable(
                name: "Run_UeSkill");

            migrationBuilder.DropTable(
                name: "TagSkill");

            migrationBuilder.DropTable(
                name: "TagTrainingTeamMember");

            migrationBuilder.DropTable(
                name: "TrainingYearUv");

            migrationBuilder.DropTable(
                name: "UeSkill");

            migrationBuilder.DropTable(
                name: "Run_EvaluationIndividual");

            migrationBuilder.DropTable(
                name: "Run_ProjectSkill");

            migrationBuilder.DropTable(
                name: "Run_Ue");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Run_EvaluationGroup");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Run_SkillRatingLevel");

            migrationBuilder.DropTable(
                name: "ProjectSkill");

            migrationBuilder.DropTable(
                name: "Run_Uv");

            migrationBuilder.DropTable(
                name: "Ue");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Run_Promotion");

            migrationBuilder.DropTable(
                name: "Run_RatingLevel");

            migrationBuilder.DropTable(
                name: "Run_Skill");

            migrationBuilder.DropTable(
                name: "SkillRatingLevel");

            migrationBuilder.DropTable(
                name: "Uv");

            migrationBuilder.DropTable(
                name: "Run_EducationalManager");

            migrationBuilder.DropTable(
                name: "Run_Project");

            migrationBuilder.DropTable(
                name: "Run_TrainingYear");

            migrationBuilder.DropTable(
                name: "RatingLevel");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "TrainingYear");

            migrationBuilder.DropTable(
                name: "TrainingTeamMember");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "TrainingCenter");

            migrationBuilder.CreateTable(
                name: "Ref_RatingLevel",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_RatingLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Tag",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ref_TrainingCenter",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_TrainingCenter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Block",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Coefficient = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Ref_TrainingCenterId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Block", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_Block_Ref_TrainingCenter_Ref_TrainingCenterId",
                        column: x => x.Ref_TrainingCenterId,
                        principalTable: "Ref_TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Degree",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ref_TrainingCenterId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Degree", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_Degree_Ref_TrainingCenter_Ref_TrainingCenterId",
                        column: x => x.Ref_TrainingCenterId,
                        principalTable: "Ref_TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Skill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Ref_TrainingCenterId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_Skill_Ref_TrainingCenter_Ref_TrainingCenterId",
                        column: x => x.Ref_TrainingCenterId,
                        principalTable: "Ref_TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Student",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Ref_TrainingCenterId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_Student_Ref_TrainingCenter_Ref_TrainingCenterId",
                        column: x => x.Ref_TrainingCenterId,
                        principalTable: "Ref_TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_TrainingTeamMember",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Ref_TrainingCenterId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_TrainingTeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_TrainingTeamMember_Ref_TrainingCenter_Ref_TrainingCenterId",
                        column: x => x.Ref_TrainingCenterId,
                        principalTable: "Ref_TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Uv",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Coefficient = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Ref_BlockId = table.Column<long>(nullable: true),
                    Ref_UvParentId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Uv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_Uv_Ref_Block_Ref_BlockId",
                        column: x => x.Ref_BlockId,
                        principalTable: "Ref_Block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ref_Uv_Ref_Uv_Ref_UvParentId",
                        column: x => x.Ref_UvParentId,
                        principalTable: "Ref_Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ref_DegreeBlock",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ref_DegreeId = table.Column<long>(nullable: false),
                    Ref_BlockId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_DegreeBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_DegreeBlock_Ref_Block_Ref_BlockId",
                        column: x => x.Ref_BlockId,
                        principalTable: "Ref_Block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_DegreeBlock_Ref_Degree_Ref_DegreeId",
                        column: x => x.Ref_DegreeId,
                        principalTable: "Ref_Degree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_TrainingYear",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    YearNumber = table.Column<int>(nullable: false),
                    Ref_DegreeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_TrainingYear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_TrainingYear_Ref_Degree_Ref_DegreeId",
                        column: x => x.Ref_DegreeId,
                        principalTable: "Ref_Degree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_SkillRatingLevel",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Coefficient = table.Column<int>(nullable: false),
                    Ref_RatingLevelId = table.Column<long>(nullable: false),
                    Ref_SkillId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_SkillRatingLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_SkillRatingLevel_Ref_RatingLevel_Ref_RatingLevelId",
                        column: x => x.Ref_RatingLevelId,
                        principalTable: "Ref_RatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_SkillRatingLevel_Ref_Skill_Ref_SkillId",
                        column: x => x.Ref_SkillId,
                        principalTable: "Ref_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_TagSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ref_TagId = table.Column<long>(nullable: false),
                    Ref_SkillId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_TagSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_TagSkill_Ref_Skill_Ref_SkillId",
                        column: x => x.Ref_SkillId,
                        principalTable: "Ref_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_TagSkill_Ref_Tag_Ref_TagId",
                        column: x => x.Ref_TagId,
                        principalTable: "Ref_Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Project",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    Ref_TrainingCenterId = table.Column<long>(nullable: false),
                    Ref_TrainingTeamMemberId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_Project_Ref_TrainingCenter_Ref_TrainingCenterId",
                        column: x => x.Ref_TrainingCenterId,
                        principalTable: "Ref_TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_Project_Ref_TrainingTeamMember_Ref_TrainingTeamMemberId",
                        column: x => x.Ref_TrainingTeamMemberId,
                        principalTable: "Ref_TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ref_TagTrainingTeamMember",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ref_TagId = table.Column<long>(nullable: false),
                    Ref_TrainingTeamMemberId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_TagTrainingTeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_TagTrainingTeamMember_Ref_Tag_Ref_TagId",
                        column: x => x.Ref_TagId,
                        principalTable: "Ref_Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_TagTrainingTeamMember_Ref_TrainingTeamMember_Ref_TrainingTeamMemberId",
                        column: x => x.Ref_TrainingTeamMemberId,
                        principalTable: "Ref_TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Ue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Coefficient = table.Column<int>(nullable: false),
                    Ref_UvId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Ue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_Ue_Ref_Uv_Ref_UvId",
                        column: x => x.Ref_UvId,
                        principalTable: "Ref_Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ref_TrainingYearBlock",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ref_BlockId = table.Column<long>(nullable: false),
                    Ref_TrainingYearId = table.Column<long>(nullable: false),
                    Ref_UvId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_TrainingYearBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_TrainingYearBlock_Ref_Block_Ref_TrainingYearId",
                        column: x => x.Ref_TrainingYearId,
                        principalTable: "Ref_Block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_TrainingYearBlock_Ref_TrainingYear_Ref_TrainingYearId",
                        column: x => x.Ref_TrainingYearId,
                        principalTable: "Ref_TrainingYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_TrainingYearBlock_Ref_Uv_Ref_UvId",
                        column: x => x.Ref_UvId,
                        principalTable: "Ref_Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_ProjectSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Coefficient = table.Column<long>(nullable: false),
                    Ref_ProjectId = table.Column<long>(nullable: false),
                    Ref_SkillRatingLevelId = table.Column<long>(nullable: false),
                    Ref_SkillId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_ProjectSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_ProjectSkill_Ref_Project_Ref_ProjectId",
                        column: x => x.Ref_ProjectId,
                        principalTable: "Ref_Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_ProjectSkill_Ref_Skill_Ref_SkillId",
                        column: x => x.Ref_SkillId,
                        principalTable: "Ref_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_ProjectSkill_Ref_SkillRatingLevel_Ref_SkillRatingLevelId",
                        column: x => x.Ref_SkillRatingLevelId,
                        principalTable: "Ref_SkillRatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_ProjectTrainingTeamMember",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Role = table.Column<string>(nullable: true),
                    Ref_TrainingTeamMemberId = table.Column<long>(nullable: false),
                    Ref_ProjectId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_ProjectTrainingTeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_ProjectTrainingTeamMember_Ref_Project_Ref_ProjectId",
                        column: x => x.Ref_ProjectId,
                        principalTable: "Ref_Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_ProjectTrainingTeamMember_Ref_TrainingTeamMember_Ref_TrainingTeamMemberId",
                        column: x => x.Ref_TrainingTeamMemberId,
                        principalTable: "Ref_TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_UeSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ref_SkillId = table.Column<long>(nullable: false),
                    Ref_UeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_UeSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ref_UeSkill_Ref_Skill_Ref_SkillId",
                        column: x => x.Ref_SkillId,
                        principalTable: "Ref_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ref_UeSkill_Ref_Ue_Ref_UeId",
                        column: x => x.Ref_UeId,
                        principalTable: "Ref_Ue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Block_Ref_TrainingCenterId",
                table: "Ref_Block",
                column: "Ref_TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Degree_Ref_TrainingCenterId",
                table: "Ref_Degree",
                column: "Ref_TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_DegreeBlock_Ref_BlockId",
                table: "Ref_DegreeBlock",
                column: "Ref_BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_DegreeBlock_Ref_DegreeId",
                table: "Ref_DegreeBlock",
                column: "Ref_DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Project_Ref_TrainingCenterId",
                table: "Ref_Project",
                column: "Ref_TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Project_Ref_TrainingTeamMemberId",
                table: "Ref_Project",
                column: "Ref_TrainingTeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_ProjectSkill_Ref_ProjectId",
                table: "Ref_ProjectSkill",
                column: "Ref_ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_ProjectSkill_Ref_SkillId",
                table: "Ref_ProjectSkill",
                column: "Ref_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_ProjectSkill_Ref_SkillRatingLevelId",
                table: "Ref_ProjectSkill",
                column: "Ref_SkillRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_ProjectTrainingTeamMember_Ref_ProjectId",
                table: "Ref_ProjectTrainingTeamMember",
                column: "Ref_ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_ProjectTrainingTeamMember_Ref_TrainingTeamMemberId",
                table: "Ref_ProjectTrainingTeamMember",
                column: "Ref_TrainingTeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Skill_Ref_TrainingCenterId",
                table: "Ref_Skill",
                column: "Ref_TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_SkillRatingLevel_Ref_RatingLevelId",
                table: "Ref_SkillRatingLevel",
                column: "Ref_RatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_SkillRatingLevel_Ref_SkillId",
                table: "Ref_SkillRatingLevel",
                column: "Ref_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Student_Ref_TrainingCenterId",
                table: "Ref_Student",
                column: "Ref_TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_TagSkill_Ref_SkillId",
                table: "Ref_TagSkill",
                column: "Ref_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_TagSkill_Ref_TagId",
                table: "Ref_TagSkill",
                column: "Ref_TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_TagTrainingTeamMember_Ref_TagId",
                table: "Ref_TagTrainingTeamMember",
                column: "Ref_TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_TagTrainingTeamMember_Ref_TrainingTeamMemberId",
                table: "Ref_TagTrainingTeamMember",
                column: "Ref_TrainingTeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_TrainingTeamMember_Ref_TrainingCenterId",
                table: "Ref_TrainingTeamMember",
                column: "Ref_TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_TrainingYear_Ref_DegreeId",
                table: "Ref_TrainingYear",
                column: "Ref_DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_TrainingYearBlock_Ref_TrainingYearId",
                table: "Ref_TrainingYearBlock",
                column: "Ref_TrainingYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_TrainingYearBlock_Ref_UvId",
                table: "Ref_TrainingYearBlock",
                column: "Ref_UvId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Ue_Ref_UvId",
                table: "Ref_Ue",
                column: "Ref_UvId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_UeSkill_Ref_SkillId",
                table: "Ref_UeSkill",
                column: "Ref_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_UeSkill_Ref_UeId",
                table: "Ref_UeSkill",
                column: "Ref_UeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Uv_Ref_BlockId",
                table: "Ref_Uv",
                column: "Ref_BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Uv_Ref_UvParentId",
                table: "Ref_Uv",
                column: "Ref_UvParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ref_DegreeBlock");

            migrationBuilder.DropTable(
                name: "Ref_ProjectSkill");

            migrationBuilder.DropTable(
                name: "Ref_ProjectTrainingTeamMember");

            migrationBuilder.DropTable(
                name: "Ref_Student");

            migrationBuilder.DropTable(
                name: "Ref_TagSkill");

            migrationBuilder.DropTable(
                name: "Ref_TagTrainingTeamMember");

            migrationBuilder.DropTable(
                name: "Ref_TrainingYearBlock");

            migrationBuilder.DropTable(
                name: "Ref_UeSkill");

            migrationBuilder.DropTable(
                name: "Ref_SkillRatingLevel");

            migrationBuilder.DropTable(
                name: "Ref_Project");

            migrationBuilder.DropTable(
                name: "Ref_Tag");

            migrationBuilder.DropTable(
                name: "Ref_TrainingYear");

            migrationBuilder.DropTable(
                name: "Ref_Ue");

            migrationBuilder.DropTable(
                name: "Ref_RatingLevel");

            migrationBuilder.DropTable(
                name: "Ref_Skill");

            migrationBuilder.DropTable(
                name: "Ref_TrainingTeamMember");

            migrationBuilder.DropTable(
                name: "Ref_Degree");

            migrationBuilder.DropTable(
                name: "Ref_Uv");

            migrationBuilder.DropTable(
                name: "Ref_Block");

            migrationBuilder.DropTable(
                name: "Ref_TrainingCenter");

            migrationBuilder.CreateTable(
                name: "RatingLevel",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Run_EducationalManager",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    IntervenerId = table.Column<long>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_EducationalManager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCenter",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCenter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Run_RatingLevel",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    RatingLevelId = table.Column<long>(nullable: true),
                    SkillLevelId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_RatingLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_RatingLevel_RatingLevel_RatingLevelId",
                        column: x => x.RatingLevelId,
                        principalTable: "RatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TrainingCenterId = table.Column<int>(nullable: false),
                    TrainingCenterId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Degree_TrainingCenter_TrainingCenterId1",
                        column: x => x.TrainingCenterId1,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    TrainingCenterId = table.Column<long>(nullable: false),
                    Validated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_TrainingCenter_TrainingCenterId",
                        column: x => x.TrainingCenterId,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingTeamMember",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    TrainingCenterId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingTeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingTeamMember_TrainingCenter_TrainingCenterId",
                        column: x => x.TrainingCenterId,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uv",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coefficient = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    TrainingCenterId = table.Column<long>(nullable: true),
                    UvId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uv_TrainingCenter_TrainingCenterId",
                        column: x => x.TrainingCenterId,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uv_Uv_UvId",
                        column: x => x.UvId,
                        principalTable: "Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingYear",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    DegreeId = table.Column<long>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    YearNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingYear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingYear_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Run_Skill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    SkillId = table.Column<long>(nullable: false),
                    TrainingCenterId = table.Column<long>(nullable: false),
                    Validated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_Skill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_Skill_TrainingCenter_TrainingCenterId",
                        column: x => x.TrainingCenterId,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillRatingLevel",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coefficient = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IdSkill = table.Column<long>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    RatingLevelId = table.Column<int>(nullable: false),
                    RatingLevelId1 = table.Column<long>(nullable: true),
                    SkillId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillRatingLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillRatingLevel_RatingLevel_RatingLevelId1",
                        column: x => x.RatingLevelId1,
                        principalTable: "RatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillRatingLevel_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TagSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkillId = table.Column<long>(nullable: false),
                    TagId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagSkill_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    IntervenerId = table.Column<long>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    TrainingCenterId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_TrainingTeamMember_IntervenerId",
                        column: x => x.IntervenerId,
                        principalTable: "TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_TrainingCenter_TrainingCenterId",
                        column: x => x.TrainingCenterId,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagTrainingTeamMember",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagId = table.Column<long>(nullable: false),
                    TrainingTeamMemberId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagTrainingTeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagTrainingTeamMember_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagTrainingTeamMember_TrainingTeamMember_TrainingTeamMemberId",
                        column: x => x.TrainingTeamMemberId,
                        principalTable: "TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeUv",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DegreeId = table.Column<long>(nullable: false),
                    UvId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeUv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DegreeUv_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DegreeUv_Uv_UvId",
                        column: x => x.UvId,
                        principalTable: "Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coefficient = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    UvId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ue_Uv_UvId",
                        column: x => x.UvId,
                        principalTable: "Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Run_TrainingYear",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ScholarYearId = table.Column<long>(nullable: false),
                    TrainingYearId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_TrainingYear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_TrainingYear_TrainingYear_TrainingYearId",
                        column: x => x.TrainingYearId,
                        principalTable: "TrainingYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingYearUv",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrainingYearId = table.Column<long>(nullable: false),
                    UvId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingYearUv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingYearUv_TrainingYear_TrainingYearId",
                        column: x => x.TrainingYearId,
                        principalTable: "TrainingYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingYearUv_Uv_UvId",
                        column: x => x.UvId,
                        principalTable: "Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Run_SkillRatingLevel",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coefficient = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Run_RatingLevelId = table.Column<long>(nullable: false),
                    Run_SkillId = table.Column<long>(nullable: true),
                    SkillRatingLevelId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_SkillRatingLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_SkillRatingLevel_Run_RatingLevel_Run_RatingLevelId",
                        column: x => x.Run_RatingLevelId,
                        principalTable: "Run_RatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_SkillRatingLevel_Run_Skill_Run_SkillId",
                        column: x => x.Run_SkillId,
                        principalTable: "Run_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_SkillRatingLevel_SkillRatingLevel_SkillRatingLevelId",
                        column: x => x.SkillRatingLevelId,
                        principalTable: "SkillRatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coefficient = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    ProjectId = table.Column<long>(nullable: false),
                    RequiredLevelId = table.Column<long>(nullable: false),
                    SkillId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectSkill_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkill_SkillRatingLevel_RequiredLevelId",
                        column: x => x.RequiredLevelId,
                        principalTable: "SkillRatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTrainingTeamMember",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<long>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    TrainingTeamMemberId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTrainingTeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTrainingTeamMember_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTrainingTeamMember_TrainingTeamMember_TrainingTeamMemberId",
                        column: x => x.TrainingTeamMemberId,
                        principalTable: "TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Run_Project",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    ProjectId = table.Column<long>(nullable: false),
                    StartDate = table.Column<string>(nullable: true),
                    TrainingCenterId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_Project_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_Project_TrainingCenter_TrainingCenterId",
                        column: x => x.TrainingCenterId,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UeSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkillId = table.Column<int>(nullable: false),
                    SkillId1 = table.Column<long>(nullable: true),
                    UeId = table.Column<int>(nullable: false),
                    UeId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UeSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UeSkill_Skill_SkillId1",
                        column: x => x.SkillId1,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UeSkill_Ue_UeId1",
                        column: x => x.UeId1,
                        principalTable: "Ue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Run_Promotion",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    RunTrainingYearId = table.Column<long>(nullable: false),
                    Run_TrainingYearId = table.Column<long>(nullable: true),
                    TrainingCenterId = table.Column<long>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_Promotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_Promotion_Run_TrainingYear_Run_TrainingYearId",
                        column: x => x.Run_TrainingYearId,
                        principalTable: "Run_TrainingYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_Promotion_TrainingCenter_TrainingCenterId",
                        column: x => x.TrainingCenterId,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Run_Uv",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coefficient = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    DegreeId = table.Column<long>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Run_TrainingYearId = table.Column<long>(nullable: false),
                    TrainingCenterId = table.Column<long>(nullable: false),
                    UvId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_Uv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_Uv_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_Uv_Run_TrainingYear_Run_TrainingYearId",
                        column: x => x.Run_TrainingYearId,
                        principalTable: "Run_TrainingYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_Uv_TrainingCenter_TrainingCenterId",
                        column: x => x.TrainingCenterId,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_Uv_Uv_UvId",
                        column: x => x.UvId,
                        principalTable: "Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Run_EducationalManagerId = table.Column<long>(nullable: true),
                    Run_ProjectId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Run_EducationalManager_Run_EducationalManagerId",
                        column: x => x.Run_EducationalManagerId,
                        principalTable: "Run_EducationalManager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_Run_Project_Run_ProjectId",
                        column: x => x.Run_ProjectId,
                        principalTable: "Run_Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Run_ProjectSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coefficient = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    RequiredLevelId = table.Column<long>(nullable: false),
                    Run_ProjectId = table.Column<long>(nullable: false),
                    Run_RequiredLevelId = table.Column<long>(nullable: true),
                    Run_SkillId = table.Column<long>(nullable: true),
                    SkillId = table.Column<long>(nullable: false),
                    projectSkillId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_ProjectSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_ProjectSkill_Run_Project_Run_ProjectId",
                        column: x => x.Run_ProjectId,
                        principalTable: "Run_Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_ProjectSkill_Run_SkillRatingLevel_Run_RequiredLevelId",
                        column: x => x.Run_RequiredLevelId,
                        principalTable: "Run_SkillRatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_ProjectSkill_Run_Skill_Run_SkillId",
                        column: x => x.Run_SkillId,
                        principalTable: "Run_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_ProjectSkill_ProjectSkill_projectSkillId",
                        column: x => x.projectSkillId,
                        principalTable: "ProjectSkill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Run_ProjectTrainingTeamMember",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    ProjectId = table.Column<long>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    TrainingTeamMemberId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_ProjectTrainingTeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_ProjectTrainingTeamMember_Run_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Run_Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_ProjectTrainingTeamMember_TrainingTeamMember_TrainingTeamMemberId",
                        column: x => x.TrainingTeamMemberId,
                        principalTable: "TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Run_PromotionId = table.Column<long>(nullable: true),
                    Run_TrainingYearId = table.Column<long>(nullable: true),
                    TrainingCenterId = table.Column<int>(nullable: false),
                    TrainingCenterId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Run_Promotion_Run_PromotionId",
                        column: x => x.Run_PromotionId,
                        principalTable: "Run_Promotion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Run_TrainingYear_Run_TrainingYearId",
                        column: x => x.Run_TrainingYearId,
                        principalTable: "Run_TrainingYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_TrainingCenter_TrainingCenterId1",
                        column: x => x.TrainingCenterId1,
                        principalTable: "TrainingCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Run_Ue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coefficient = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    Run_UvId = table.Column<long>(nullable: true),
                    UeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_Ue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_Ue_Run_Uv_Run_UvId",
                        column: x => x.Run_UvId,
                        principalTable: "Run_Uv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_Ue_Ue_UeId",
                        column: x => x.UeId,
                        principalTable: "Ue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Run_EvaluationGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EducationalManagerId = table.Column<long>(nullable: true),
                    GroupId = table.Column<long>(nullable: true),
                    IntervenerId = table.Column<long>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    ParentEvaluationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_EvaluationGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationGroup_Run_EducationalManager_EducationalManagerId",
                        column: x => x.EducationalManagerId,
                        principalTable: "Run_EducationalManager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationGroup_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationGroup_TrainingTeamMember_IntervenerId",
                        column: x => x.IntervenerId,
                        principalTable: "TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationGroup_Run_EvaluationGroup_ParentEvaluationId",
                        column: x => x.ParentEvaluationId,
                        principalTable: "Run_EvaluationGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Run_StudentGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    ProjectGroupId = table.Column<int>(nullable: false),
                    ProjetGroupId = table.Column<long>(nullable: true),
                    StudentId = table.Column<int>(nullable: false),
                    StudentId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_StudentGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_StudentGroup_Group_ProjetGroupId",
                        column: x => x.ProjetGroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_StudentGroup_Student_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Run_UeSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Run_SkillId = table.Column<int>(nullable: false),
                    Run_UeId = table.Column<int>(nullable: false),
                    SkillId = table.Column<long>(nullable: true),
                    UeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_UeSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_UeSkill_Run_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Run_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_UeSkill_Run_Ue_UeId",
                        column: x => x.UeId,
                        principalTable: "Run_Ue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Run_EvaluationIndividual",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    EducationalManagerId = table.Column<long>(nullable: true),
                    IntervenerId = table.Column<long>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    ParentEvaluationGroupId = table.Column<int>(nullable: true),
                    ParentGroupEvaluationId = table.Column<long>(nullable: true),
                    StudentId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_EvaluationIndividual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationIndividual_Run_EducationalManager_EducationalManagerId",
                        column: x => x.EducationalManagerId,
                        principalTable: "Run_EducationalManager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationIndividual_TrainingTeamMember_IntervenerId",
                        column: x => x.IntervenerId,
                        principalTable: "TrainingTeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationIndividual_Run_EvaluationGroup_ParentEvaluationGroupId",
                        column: x => x.ParentEvaluationGroupId,
                        principalTable: "Run_EvaluationGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationIndividual_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Run_EvaluationIndividualProjectSkill",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatorLogin = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LastUpdaterLogin = table.Column<string>(nullable: true),
                    LevelReachedId = table.Column<long>(nullable: true),
                    RunProjectSkill_Id = table.Column<long>(nullable: false),
                    Run_EvaluationGroupId = table.Column<int>(nullable: true),
                    Run_EvaluationIndividualId = table.Column<long>(nullable: false),
                    Run_ProjectSkillId = table.Column<long>(nullable: true),
                    Run_SkillRatingLevelId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run_EvaluationIndividualProjectSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationIndividualProjectSkill_Run_EvaluationGroup_Run_EvaluationGroupId",
                        column: x => x.Run_EvaluationGroupId,
                        principalTable: "Run_EvaluationGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationIndividualProjectSkill_Run_EvaluationIndividual_Run_EvaluationIndividualId",
                        column: x => x.Run_EvaluationIndividualId,
                        principalTable: "Run_EvaluationIndividual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationIndividualProjectSkill_Run_ProjectSkill_Run_ProjectSkillId",
                        column: x => x.Run_ProjectSkillId,
                        principalTable: "Run_ProjectSkill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Run_EvaluationIndividualProjectSkill_Run_SkillRatingLevel_Run_SkillRatingLevelId",
                        column: x => x.Run_SkillRatingLevelId,
                        principalTable: "Run_SkillRatingLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Degree_TrainingCenterId1",
                table: "Degree",
                column: "TrainingCenterId1");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeUv_DegreeId",
                table: "DegreeUv",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeUv_UvId",
                table: "DegreeUv",
                column: "UvId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Run_EducationalManagerId",
                table: "Group",
                column: "Run_EducationalManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Run_ProjectId",
                table: "Group",
                column: "Run_ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_IntervenerId",
                table: "Project",
                column: "IntervenerId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_TrainingCenterId",
                table: "Project",
                column: "TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkill_ProjectId",
                table: "ProjectSkill",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkill_RequiredLevelId",
                table: "ProjectSkill",
                column: "RequiredLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkill_SkillId",
                table: "ProjectSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTrainingTeamMember_ProjectId",
                table: "ProjectTrainingTeamMember",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTrainingTeamMember_TrainingTeamMemberId",
                table: "ProjectTrainingTeamMember",
                column: "TrainingTeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationGroup_EducationalManagerId",
                table: "Run_EvaluationGroup",
                column: "EducationalManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationGroup_GroupId",
                table: "Run_EvaluationGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationGroup_IntervenerId",
                table: "Run_EvaluationGroup",
                column: "IntervenerId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationGroup_ParentEvaluationId",
                table: "Run_EvaluationGroup",
                column: "ParentEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationIndividual_EducationalManagerId",
                table: "Run_EvaluationIndividual",
                column: "EducationalManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationIndividual_IntervenerId",
                table: "Run_EvaluationIndividual",
                column: "IntervenerId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationIndividual_ParentEvaluationGroupId",
                table: "Run_EvaluationIndividual",
                column: "ParentEvaluationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationIndividual_StudentId",
                table: "Run_EvaluationIndividual",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationIndividualProjectSkill_Run_EvaluationGroupId",
                table: "Run_EvaluationIndividualProjectSkill",
                column: "Run_EvaluationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationIndividualProjectSkill_Run_EvaluationIndividualId",
                table: "Run_EvaluationIndividualProjectSkill",
                column: "Run_EvaluationIndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationIndividualProjectSkill_Run_ProjectSkillId",
                table: "Run_EvaluationIndividualProjectSkill",
                column: "Run_ProjectSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_EvaluationIndividualProjectSkill_Run_SkillRatingLevelId",
                table: "Run_EvaluationIndividualProjectSkill",
                column: "Run_SkillRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Project_ProjectId",
                table: "Run_Project",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Project_TrainingCenterId",
                table: "Run_Project",
                column: "TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_ProjectSkill_Run_ProjectId",
                table: "Run_ProjectSkill",
                column: "Run_ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_ProjectSkill_Run_RequiredLevelId",
                table: "Run_ProjectSkill",
                column: "Run_RequiredLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_ProjectSkill_Run_SkillId",
                table: "Run_ProjectSkill",
                column: "Run_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_ProjectSkill_projectSkillId",
                table: "Run_ProjectSkill",
                column: "projectSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_ProjectTrainingTeamMember_ProjectId",
                table: "Run_ProjectTrainingTeamMember",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_ProjectTrainingTeamMember_TrainingTeamMemberId",
                table: "Run_ProjectTrainingTeamMember",
                column: "TrainingTeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Promotion_Run_TrainingYearId",
                table: "Run_Promotion",
                column: "Run_TrainingYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Promotion_TrainingCenterId",
                table: "Run_Promotion",
                column: "TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_RatingLevel_RatingLevelId",
                table: "Run_RatingLevel",
                column: "RatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Skill_SkillId",
                table: "Run_Skill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Skill_TrainingCenterId",
                table: "Run_Skill",
                column: "TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_SkillRatingLevel_Run_RatingLevelId",
                table: "Run_SkillRatingLevel",
                column: "Run_RatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_SkillRatingLevel_Run_SkillId",
                table: "Run_SkillRatingLevel",
                column: "Run_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_SkillRatingLevel_SkillRatingLevelId",
                table: "Run_SkillRatingLevel",
                column: "SkillRatingLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_StudentGroup_ProjetGroupId",
                table: "Run_StudentGroup",
                column: "ProjetGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_StudentGroup_StudentId1",
                table: "Run_StudentGroup",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Run_TrainingYear_TrainingYearId",
                table: "Run_TrainingYear",
                column: "TrainingYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Ue_Run_UvId",
                table: "Run_Ue",
                column: "Run_UvId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Ue_UeId",
                table: "Run_Ue",
                column: "UeId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_UeSkill_SkillId",
                table: "Run_UeSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_UeSkill_UeId",
                table: "Run_UeSkill",
                column: "UeId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Uv_DegreeId",
                table: "Run_Uv",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Uv_Run_TrainingYearId",
                table: "Run_Uv",
                column: "Run_TrainingYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Uv_TrainingCenterId",
                table: "Run_Uv",
                column: "TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Run_Uv_UvId",
                table: "Run_Uv",
                column: "UvId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_TrainingCenterId",
                table: "Skill",
                column: "TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillRatingLevel_RatingLevelId1",
                table: "SkillRatingLevel",
                column: "RatingLevelId1");

            migrationBuilder.CreateIndex(
                name: "IX_SkillRatingLevel_SkillId",
                table: "SkillRatingLevel",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Run_PromotionId",
                table: "Student",
                column: "Run_PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Run_TrainingYearId",
                table: "Student",
                column: "Run_TrainingYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_TrainingCenterId1",
                table: "Student",
                column: "TrainingCenterId1");

            migrationBuilder.CreateIndex(
                name: "IX_TagSkill_SkillId",
                table: "TagSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_TagSkill_TagId",
                table: "TagSkill",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TagTrainingTeamMember_TagId",
                table: "TagTrainingTeamMember",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TagTrainingTeamMember_TrainingTeamMemberId",
                table: "TagTrainingTeamMember",
                column: "TrainingTeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingTeamMember_TrainingCenterId",
                table: "TrainingTeamMember",
                column: "TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingYear_DegreeId",
                table: "TrainingYear",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingYearUv_TrainingYearId",
                table: "TrainingYearUv",
                column: "TrainingYearId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingYearUv_UvId",
                table: "TrainingYearUv",
                column: "UvId");

            migrationBuilder.CreateIndex(
                name: "IX_Ue_UvId",
                table: "Ue",
                column: "UvId");

            migrationBuilder.CreateIndex(
                name: "IX_UeSkill_SkillId1",
                table: "UeSkill",
                column: "SkillId1");

            migrationBuilder.CreateIndex(
                name: "IX_UeSkill_UeId1",
                table: "UeSkill",
                column: "UeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Uv_TrainingCenterId",
                table: "Uv",
                column: "TrainingCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Uv_UvId",
                table: "Uv",
                column: "UvId");
        }
    }
}
