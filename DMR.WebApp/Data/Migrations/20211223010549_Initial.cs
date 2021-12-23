using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMR.WebApp.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<int>(type: "int", nullable: false),
                    UriSmutosaurWiki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UriRevampWikia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    LevelMinimum = table.Column<int>(type: "int", nullable: false),
                    LevelMaximum = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationTemplate_Location_Id",
                        column: x => x.Id,
                        principalTable: "Location",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CharacterTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group = table.Column<int>(type: "int", nullable: false),
                    Parent = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    SaveStateId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moment_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaveStateTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveStateTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false),
                    Style = table.Column<int>(type: "int", nullable: false),
                    Subgroup = table.Column<int>(type: "int", nullable: false),
                    RankMax = table.Column<int>(type: "int", nullable: false),
                    RankCurrent = table.Column<int>(type: "int", nullable: false),
                    Prerequisites = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelRequired = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    EffectImmediateId = table.Column<int>(type: "int", nullable: true),
                    EffectOverTimeId = table.Column<int>(type: "int", nullable: true),
                    CastTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TravelTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProcsPerMinute = table.Column<int>(type: "int", nullable: false),
                    CooldownDisplay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Torso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Shoulder = table.Column<int>(type: "int", nullable: false),
                    Chest = table.Column<int>(type: "int", nullable: false),
                    Waist = table.Column<int>(type: "int", nullable: false),
                    Hips = table.Column<int>(type: "int", nullable: false),
                    Abdomen = table.Column<int>(type: "int", nullable: false),
                    Naval = table.Column<int>(type: "int", nullable: false),
                    Back = table.Column<int>(type: "int", nullable: false),
                    Stomach = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    EmailPublic = table.Column<bool>(type: "bit", nullable: false),
                    Theme = table.Column<int>(type: "int", nullable: false),
                    LoginPrevious = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HideTutorialTips = table.Column<bool>(type: "bit", nullable: false),
                    ShowAdvancedTooltips = table.Column<bool>(type: "bit", nullable: false),
                    FormatTime = table.Column<int>(type: "int", nullable: false),
                    FormatTemperature = table.Column<int>(type: "int", nullable: false),
                    SaveCurrentId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaveState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    EncounterCurrentId = table.Column<int>(type: "int", nullable: false),
                    EncounterPreviousId = table.Column<int>(type: "int", nullable: false),
                    ComsumablesForced = table.Column<int>(type: "int", nullable: false),
                    ComsumablesTaken = table.Column<int>(type: "int", nullable: false),
                    Explored = table.Column<int>(type: "int", nullable: false),
                    Eaten = table.Column<int>(type: "int", nullable: false),
                    Exercised = table.Column<int>(type: "int", nullable: false),
                    Slept = table.Column<int>(type: "int", nullable: false),
                    Meditated = table.Column<int>(type: "int", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaveState_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMomId = table.Column<int>(type: "int", nullable: false),
                    ParentDadId = table.Column<int>(type: "int", nullable: false),
                    SoulOwnerId = table.Column<int>(type: "int", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UriSmutosaurWiki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UriRevampWikia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    SpeciesId = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    Temperment = table.Column<int>(type: "int", nullable: false),
                    CampRecruit = table.Column<bool>(type: "bit", nullable: false),
                    Follower = table.Column<bool>(type: "bit", nullable: false),
                    Lover = table.Column<bool>(type: "bit", nullable: false),
                    Slave = table.Column<bool>(type: "bit", nullable: false),
                    TorsoId = table.Column<int>(type: "int", nullable: true),
                    HeroicDeeds = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Masculinity = table.Column<int>(type: "int", nullable: false),
                    Femininity = table.Column<int>(type: "int", nullable: false),
                    Fitness = table.Column<int>(type: "int", nullable: false),
                    Fatness = table.Column<int>(type: "int", nullable: false),
                    MomentId = table.Column<int>(type: "int", nullable: true),
                    SaveStateId = table.Column<int>(type: "int", nullable: true),
                    SaveStateId1 = table.Column<int>(type: "int", nullable: true),
                    SaveStateId2 = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Character_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Character_Moment_MomentId",
                        column: x => x.MomentId,
                        principalTable: "Moment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Character_SaveState_SaveStateId",
                        column: x => x.SaveStateId,
                        principalTable: "SaveState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Character_SaveState_SaveStateId1",
                        column: x => x.SaveStateId1,
                        principalTable: "SaveState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Character_SaveState_SaveStateId2",
                        column: x => x.SaveStateId2,
                        principalTable: "SaveState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Character_Torso_TorsoId",
                        column: x => x.TorsoId,
                        principalTable: "Torso",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Sale = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    CharacterId1 = table.Column<int>(type: "int", nullable: true),
                    SaveStateId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Character_CharacterId1",
                        column: x => x.CharacterId1,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_SaveState_SaveStateId",
                        column: x => x.SaveStateId,
                        principalTable: "SaveState",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Attribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Format = table.Column<int>(type: "int", nullable: false),
                    Style = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attribute_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attribute_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Effect",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Element = table.Column<int>(type: "int", nullable: false),
                    AmountMinimum = table.Column<int>(type: "int", nullable: false),
                    AmountMaximum = table.Column<int>(type: "int", nullable: false),
                    CastTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Cooldown = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    IsHarmful = table.Column<bool>(type: "bit", nullable: false),
                    IsDispellable = table.Column<bool>(type: "bit", nullable: false),
                    IsTargetted = table.Column<bool>(type: "bit", nullable: false),
                    IsSpell = table.Column<bool>(type: "bit", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    CharacterId1 = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    SaveStateId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Effect_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Effect_Character_CharacterId1",
                        column: x => x.CharacterId1,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Effect_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Effect_SaveState_SaveStateId",
                        column: x => x.SaveStateId,
                        principalTable: "SaveState",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: true),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    EffectId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    MomentId = table.Column<int>(type: "int", nullable: true),
                    SaveStateId = table.Column<int>(type: "int", nullable: true),
                    SkillTemplateId = table.Column<int>(type: "int", nullable: true),
                    UserProfileId = table.Column<int>(type: "int", nullable: true),
                    UserProfileId1 = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Dimension = table.Column<int>(type: "int", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tag_Attribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attribute",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_Effect_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effect",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_Moment_MomentId",
                        column: x => x.MomentId,
                        principalTable: "Moment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_SaveState_SaveStateId",
                        column: x => x.SaveStateId,
                        principalTable: "SaveState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_SkillTemplate_SkillTemplateId",
                        column: x => x.SkillTemplateId,
                        principalTable: "SkillTemplate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tag_UserProfile_UserProfileId1",
                        column: x => x.UserProfileId1,
                        principalTable: "UserProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Arm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Elbow = table.Column<int>(type: "int", nullable: false),
                    Wrist = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arm_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Arm_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Breast",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Nipples = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Breast_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Breast_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Butt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Butt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Butt_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Butt_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Ankle = table.Column<int>(type: "int", nullable: false),
                    Heel = table.Column<int>(type: "int", nullable: false),
                    Arch = table.Column<int>(type: "int", nullable: false),
                    Ball = table.Column<int>(type: "int", nullable: false),
                    Toes = table.Column<int>(type: "int", nullable: false),
                    Nails = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foot_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Foot_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Palm = table.Column<int>(type: "int", nullable: false),
                    Fingers = table.Column<int>(type: "int", nullable: false),
                    Nails = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hand_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hand_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Head",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Horn = table.Column<int>(type: "int", nullable: false),
                    Hair = table.Column<int>(type: "int", nullable: false),
                    Face = table.Column<int>(type: "int", nullable: false),
                    Eye = table.Column<int>(type: "int", nullable: false),
                    Eyebrow = table.Column<int>(type: "int", nullable: false),
                    Ear = table.Column<int>(type: "int", nullable: false),
                    Cheeks = table.Column<int>(type: "int", nullable: false),
                    Jaw = table.Column<int>(type: "int", nullable: false),
                    Beard = table.Column<int>(type: "int", nullable: false),
                    Neck = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Head", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Head_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Head_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Thigh = table.Column<int>(type: "int", nullable: false),
                    Knee = table.Column<int>(type: "int", nullable: false),
                    Calf = table.Column<int>(type: "int", nullable: false),
                    Shin = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leg_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Leg_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Penis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Penis_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Penis_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Recharge = table.Column<int>(type: "int", nullable: false),
                    Venom = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tail_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tail_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vagina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Looseness = table.Column<int>(type: "int", nullable: false),
                    Wetness = table.Column<int>(type: "int", nullable: false),
                    Virgin = table.Column<bool>(type: "bit", nullable: false),
                    Fullness = table.Column<int>(type: "int", nullable: false),
                    LabiaPierced = table.Column<bool>(type: "bit", nullable: false),
                    LabiaPShort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabiaPLong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClitPierced = table.Column<bool>(type: "bit", nullable: false),
                    ClitPShort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClitPLong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vagina_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vagina_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wing_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Wing_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mouth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Skin = table.Column<int>(type: "int", nullable: false),
                    Tongue = table.Column<int>(type: "int", nullable: false),
                    Teeth = table.Column<int>(type: "int", nullable: false),
                    HeadId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Who = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    What = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mouth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mouth_Head_HeadId",
                        column: x => x.HeadId,
                        principalTable: "Head",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mouth_Tag_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Attribute",
                columns: new[] { "Id", "Abbreviation", "CharacterId", "Description", "Dimension", "Format", "IsLive", "ItemId", "Release", "Stage", "Style", "Title", "Value", "What", "When", "Who" },
                values: new object[,]
                {
                    { 1, "AGI", null, "Dexterity and speed", 0, 0, false, null, "v0.0.0", 0, 0, "Agility", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, "STR", null, "Ability to weild grander weapons and strike with greater efficiency", 0, 0, false, null, "v0.0.0", 0, 0, "Strength", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, "SPE", null, "Hastens the pace of combat flow", 0, 0, false, null, "v0.0.0", 0, 0, "Speed", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, "VIT", null, "Toughness and resilience", 0, 0, false, null, "v0.0.0", 0, 0, "Vitality", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, "INT", null, "Boosts attack of spells and ability to cast more effectively (conjuration, alchemy, alteration, illusion)", 0, 0, false, null, "v0.0.0", 0, 0, "Intelligence", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, "WIL", null, "Increases mana capacity and regen (restoration, mysticism)", 0, 0, false, null, "v0.0.0", 0, 0, "Willpower", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, "LUK", null, "Effects nearly everything nominally", 0, 0, false, null, "v0.0.0", 0, 0, "Luck", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, "EST", null, "Enhances personality, charisma, and confidence (tease)", 0, 0, false, null, "v0.0.0", 0, 0, "Esteem", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, "str", null, null, 3, 0, false, null, "0.9.4", 0, 0, "Strength", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, "tou", null, null, 3, 0, false, null, "0.9.4", 0, 0, "Toughness", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, "spe", null, null, 3, 0, false, null, "0.9.4", 0, 0, "Speed", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, "inte", null, null, 3, 0, false, null, "0.9.4", 0, 0, "Intelligence", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, "sens", null, null, 3, 0, false, null, "0.9.4", 0, 0, "Sensitivity", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, "lib", null, null, 3, 0, false, null, "0.9.4", 0, 0, "Libido", 15, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, "cor", null, null, 3, 0, false, null, "0.9.4", 0, 0, "Corruption", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, "lust", null, null, 3, 0, false, null, "0.9.4", 0, 4, "Lust", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, "XP", null, null, 3, 0, false, null, "0.9.4", 0, 3, "Experience", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, "lvl", null, null, 3, 0, false, null, "0.9.4", 0, 3, "Level", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, "HP", null, null, 3, 0, false, null, "0.9.4", 0, 2, "HP", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, "gems", null, null, 3, 0, false, null, "0.9.4", 0, 3, "Gems", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, "fati", null, null, 3, 0, false, null, "0.9.4", 0, 3, "Fatigue", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, "cumx", null, null, 3, 0, false, null, "0.9.4", 0, 4, "cumMultiplier", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, "tcum", null, null, 3, 0, false, null, "0.9.4", 0, 4, "hoursSinceCum", 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "Birthdate", "CampRecruit", "Description", "Dimension", "Fatness", "Femininity", "Fitness", "Follower", "Gender", "HeroicDeeds", "IsLive", "Job", "LocationId", "Lover", "Masculinity", "MomentId", "Nickname", "ParentDadId", "ParentMomId", "Release", "SaveStateId", "SaveStateId1", "SaveStateId2", "Skin", "Slave", "SoulOwnerId", "SpeciesId", "Stage", "Temperment", "Title", "TorsoId", "UriRevampWikia", "UriSmutosaurWiki", "What", "When", "Who" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 0, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "v0.0.0", null, null, null, 0, false, 0, null, 0, 0, "David Default", null, null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 0, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "v0.0.0", null, null, null, 0, false, 0, null, 0, 0, "Miia", null, null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 0, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "v0.0.0", null, null, null, 0, false, 0, null, 0, 0, "Papi", null, null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 0, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "v0.0.0", null, null, null, 0, false, 0, null, 0, 0, "Centorea", null, null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 0, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "v0.0.0", null, null, null, 0, false, 0, null, 0, 0, "Suu", null, null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 0, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "v0.0.0", null, null, null, 0, false, 0, null, 0, 0, "Mero", null, null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 0, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "v0.0.0", null, null, null, 0, false, 0, null, 0, 0, "Rachnera", null, null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 0, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "v0.0.0", null, null, null, 0, false, 0, null, 0, 0, "Lala", null, null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, true, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Rathazul", null, "http://coc-revamp.wikia.com/wiki/Rathazul", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, true, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Shouldra", null, "http://coc-revamp.wikia.com/wiki/Shouldra", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, true, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Valeria", null, "http://coc-revamp.wikia.com/wiki/Valeria", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, true, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Helspawn", null, "http://coc-revamp.wikia.com/wiki/Helspawn", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, true, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Ember", null, "http://coc-revamp.wikia.com/wiki/Ember", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, true, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, true, 0, null, 0, 0, "Sophie", null, "http://coc-revamp.wikia.com/wiki/Sophie", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, true, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, true, 0, null, 0, 0, "Jojo", null, "http://coc-revamp.wikia.com/wiki/Jojo", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, true, 0, null, 0, 0, "Bath Girl", null, "http://coc-revamp.wikia.com/wiki/Bath_Girl", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, true, 0, null, 0, 0, "Ceraph", null, "http://coc-revamp.wikia.com/wiki/Ceraph", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, true, 0, null, 0, 0, "Vapula", null, "http://coc-revamp.wikia.com/wiki/Vapula", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, true, 0, null, 0, 0, "Latex Girl", null, "http://coc-revamp.wikia.com/wiki/Latex_Goo-Girl", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "Birthdate", "CampRecruit", "Description", "Dimension", "Fatness", "Femininity", "Fitness", "Follower", "Gender", "HeroicDeeds", "IsLive", "Job", "LocationId", "Lover", "Masculinity", "MomentId", "Nickname", "ParentDadId", "ParentMomId", "Release", "SaveStateId", "SaveStateId1", "SaveStateId2", "Skin", "Slave", "SoulOwnerId", "SpeciesId", "Stage", "Temperment", "Title", "TorsoId", "UriRevampWikia", "UriSmutosaurWiki", "What", "When", "Who" },
                values: new object[,]
                {
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, true, 0, null, 0, 0, "Amily", null, "http://coc-revamp.wikia.com/wiki/Amily", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Arian", null, "http://coc-revamp.wikia.com/wiki/Arian", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Isabella", null, "http://coc-revamp.wikia.com/wiki/Isabella", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Izma", null, "http://coc-revamp.wikia.com/wiki/Izma", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Kiha", null, "http://coc-revamp.wikia.com/wiki/Kiha", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Marble", null, "", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Nieve", null, "http://coc-revamp.wikia.com/wiki/Marble", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Phylla", null, "http://coc-revamp.wikia.com/wiki/Phylla", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, true, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Helia", null, "http://coc-revamp.wikia.com/wiki/Helia", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Hollicynthia", null, "http://coc-revamp.wikia.com/wiki/Holli", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Anemone kid", null, "http://coc-revamp.wikia.com/wiki/Kid_A", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Champion", null, "http://coc-revamp.wikia.com/wiki/Champion", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Akbal", null, "http://coc-revamp.wikia.com/wiki/Akbal", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Benoit", null, "http://coc-revamp.wikia.com/wiki/Benoit", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Brooke", null, "http://coc-revamp.wikia.com/wiki/Brooke", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Callu", null, "http://coc-revamp.wikia.com/wiki/Callu", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Ceraph", null, "http://coc-revamp.wikia.com/wiki/Ceraph", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Cinnabar", null, "http://coc-revamp.wikia.com/wiki/Cinnabar", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Cotton", null, "http://coc-revamp.wikia.com/wiki/Cotton", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Edryn", null, "http://coc-revamp.wikia.com/wiki/Edryn", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Erlking", null, "http://coc-revamp.wikia.com/wiki/Erlking", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Essrayle", null, "http://coc-revamp.wikia.com/wiki/Essrayle", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Faerie", null, "http://coc-revamp.wikia.com/wiki/Faerie", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Frosty", null, "http://coc-revamp.wikia.com/wiki/Frosty", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Gargoyle", null, "http://coc-revamp.wikia.com/wiki/Gargoyle", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Giacomo", null, "http://coc-revamp.wikia.com/wiki/Giacomo", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Greta", null, "http://coc-revamp.wikia.com/wiki/Greta", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Heckel", null, "http://coc-revamp.wikia.com/wiki/Heckel", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Hellhound Master", null, "http://coc-revamp.wikia.com/wiki/Hellhound_Master", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Ifris", null, "http://coc-revamp.wikia.com/wiki/Ifris", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Izumi", null, "http://coc-revamp.wikia.com/wiki/Izumi", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Jasun", null, "http://coc-revamp.wikia.com/wiki/Jasun", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Kami", null, "http://coc-revamp.wikia.com/wiki/Kami", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Katherine", null, "http://coc-revamp.wikia.com/wiki/Katherine", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Kelt", null, "http://coc-revamp.wikia.com/wiki/Kelt", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Loppe", null, "http://coc-revamp.wikia.com/wiki/Loppe", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Lottie", null, "http://coc-revamp.wikia.com/wiki/Lottie", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Lucia", null, "http://coc-revamp.wikia.com/wiki/Lucia", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Lumi", null, "http://coc-revamp.wikia.com/wiki/Lumi", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Lynette", null, "http://coc-revamp.wikia.com/wiki/Lynette", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Maddie", null, "http://coc-revamp.wikia.com/wiki/Madeleine", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Minerva", null, "http://coc-revamp.wikia.com/wiki/Minerva", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "Birthdate", "CampRecruit", "Description", "Dimension", "Fatness", "Femininity", "Fitness", "Follower", "Gender", "HeroicDeeds", "IsLive", "Job", "LocationId", "Lover", "Masculinity", "MomentId", "Nickname", "ParentDadId", "ParentMomId", "Release", "SaveStateId", "SaveStateId1", "SaveStateId2", "Skin", "Slave", "SoulOwnerId", "SpeciesId", "Stage", "Temperment", "Title", "TorsoId", "UriRevampWikia", "UriSmutosaurWiki", "What", "When", "Who" },
                values: new object[,]
                {
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Marcus", null, "http://coc-revamp.wikia.com/wiki/Marcus", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Naga", null, "http://coc-revamp.wikia.com/wiki/Naga", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Nancy", null, "http://coc-revamp.wikia.com/wiki/Aunt_Nancy", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Niamh", null, "http://coc-revamp.wikia.com/wiki/Niamh", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Oswald", null, "http://coc-revamp.wikia.com/wiki/Oswald", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Quinn", null, "http://coc-revamp.wikia.com/wiki/Quinn", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Raphael", null, "http://coc-revamp.wikia.com/wiki/Raphael", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Rebecc", null, "http://coc-revamp.wikia.com/wiki/Rebecc", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Ro'Gar", null, "http://coc-revamp.wikia.com/wiki/Ro%27Gar", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Roxanne", null, "http://coc-revamp.wikia.com/wiki/Roxanne_Poisontail", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Rubi", null, "http://coc-revamp.wikia.com/wiki/Rubi", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Sanura", null, "http://coc-revamp.wikia.com/wiki/Sanura", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Scylla", null, "http://coc-revamp.wikia.com/wiki/Scylla", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Sheila", null, "http://coc-revamp.wikia.com/wiki/Sheila", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Tamani", null, "http://coc-revamp.wikia.com/wiki/Tamani", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Tamani's Daughters", null, "http://coc-revamp.wikia.com/wiki/Tamani%27s_Daughters", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Urta", null, "http://coc-revamp.wikia.com/wiki/Urta", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Vala", null, "http://coc-revamp.wikia.com/wiki/Vala", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Venus", null, "http://coc-revamp.wikia.com/wiki/Venus", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Victoria", null, "http://coc-revamp.wikia.com/wiki/Victoria", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Whitney", null, "http://coc-revamp.wikia.com/wiki/Whitney", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Yara", null, "http://coc-revamp.wikia.com/wiki/Yara", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Yvonne", null, "http://coc-revamp.wikia.com/wiki/Yvonne", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3, 0, 0, 0, false, 0, 0, false, null, null, false, 0, null, null, 0, 0, "0.9.4", null, null, null, 0, false, 0, null, 0, 0, "Zetaz", null, "http://coc-revamp.wikia.com/wiki/Zetaz", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Effect",
                columns: new[] { "Id", "AmountMaximum", "AmountMinimum", "Area", "CastTime", "CharacterId", "CharacterId1", "Cooldown", "Description", "Dimension", "Duration", "Element", "IsDispellable", "IsHarmful", "IsLive", "IsSpell", "IsTargetted", "ItemId", "Range", "Release", "SaveStateId", "Stage", "Title", "What", "When", "Who" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Character suffers health loss", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Damage", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Perform a healing act upon another character.  Not unlike reversing damage though often accompanied with benefits.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Heal", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Character is overcome by an intense, persuasive influence to slumber.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Sleep", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Character drops like a rock.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Knockout", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Character's chance to hit is reduced 50% with 5% chance of harming self or ally.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Blind", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Character has fumbled their weapon/shield; unable to perform physical abilities for duration.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Disarm", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Mouth sealed like Neo (woah); unable to perform magic abilities for duration.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Silence", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Character is unable to act, immobilized by fear, shackles, or some other force at work.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Stun", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Prevent incoming damage or healing.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Absorb", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Provides you with instant travel across the world.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Solar Teleportation", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "You can freely shift among parallel dimensions.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Lunar Teleportation", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Take damage after every action", 0, 0, 5, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Burn", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Action speed greatly reduced", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Chill", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Unable to take actions", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Freeze", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Unable to take actions; melee against shocked opponent may cause feedback", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Shock", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Stun", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Daze", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Attack accuracy greatly reduced", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Dizzy", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Effect",
                columns: new[] { "Id", "AmountMaximum", "AmountMinimum", "Area", "CastTime", "CharacterId", "CharacterId1", "Cooldown", "Description", "Dimension", "Duration", "Element", "IsDispellable", "IsHarmful", "IsLive", "IsSpell", "IsTargetted", "ItemId", "Range", "Release", "SaveStateId", "Stage", "Title", "What", "When", "Who" },
                values: new object[,]
                {
                    { 19, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Unable to use skills", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Forget", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Unable to take actions; HP/MP slowly restore", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Sleep", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Throw away gold/item, attack ally, do nothing", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Confuse", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "High chance of ignoring commands, chance of running from battle", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Fear", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Unable to cast, MP depleats; character is incapacitated after too many turns", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Despair", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "AP increased, defense decreased; character won't listen to orders, auto-melee", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Rage", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "Heal an enemy, attack ally, or support enemy", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Brainwash", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Amenable", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Flustered", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Tender", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "It grants absorb based on 100% of Max HP.", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Bubble", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Neutralized", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Asleep", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Restrained", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, 0, 0, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, 0, "", 0, 0, 0, false, false, false, false, false, null, 0, "v0.0.0", null, 0, "Frog", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "CharacterId", "CharacterId1", "Cost", "Description", "Dimension", "Group", "IsLive", "Origin", "Release", "Sale", "SaveStateId", "Stage", "Title", "What", "When", "Who" },
                values: new object[,]
                {
                    { 1, null, null, 0, null, 3, 6, false, 2, "0.9.4", 0, null, 0, "Comfortable Under Clothes", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, null, null, 0, null, 3, 6, false, 2, "0.9.4", 0, null, 0, "Comfortable Clothes", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, null, null, 0, null, 3, 6, false, 3, "0.9.4", 0, null, 0, "Fur Loincloth", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, null, null, 0, null, 3, 6, false, 3, "0.9.4", 0, null, 0, "Goo Armor", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, null, null, 0, null, 3, 6, false, 3, "0.9.4", 0, null, 0, "Inquisitor's Corset", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, null, null, 0, null, 3, 6, false, 3, "0.9.4", 0, null, 0, "Inquisitor's Robes", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, null, null, 0, null, 3, 6, false, 3, "0.9.4", 0, null, 0, "Leather Armor Segments", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, null, null, 0, null, 3, 6, false, 3, "0.9.4", 0, null, 0, "Lusty Maiden's Armor", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, null, null, 0, null, 3, 6, false, 3, "0.9.4", 0, null, 0, "Seductive Armor", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, null, null, 0, null, 3, 6, false, 3, "0.9.4", 0, null, 0, "Slutty Swimwear", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Beautiful Sword", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Dragon Shell Shield", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Eldritch Staff", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Fists", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Huge Warhammer", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Jeweled Rapier", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Large Claymore", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Large Hammer", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Raphael's Rapier", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Spellblade", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, null, null, 0, null, 3, 5, false, 3, "0.9.4", 0, null, 0, "Wizard's Staff", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Bee Honey", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Bimbo Liqueur", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "De Bimbo", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Gro Plus", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Hair Extension Serum", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Kitsune Gift", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "CharacterId", "CharacterId1", "Cost", "Description", "Dimension", "Group", "IsLive", "Origin", "Release", "Sale", "SaveStateId", "Stage", "Title", "What", "When", "Who" },
                values: new object[,]
                {
                    { 28, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Lust Stick", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Oviposition Elixir", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Phouka Whiskey", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Reducto", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Rizza Root", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, null, null, 0, null, 3, 2, false, 3, "0.9.4", 0, null, 0, "Wing Stick", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, null, null, 0, null, 1, 3, false, 2, "v0.0.0", 0, null, 0, "Iridescent Anklet", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, null, null, 0, "You can no longer be bothered by death or much else for that matter.  You take on an undamaged undead form, emotionless and cold.  Immune to cold and poison damage.", 1, 7, false, 0, "v0.0.0", 0, null, 0, "The Ancient Scroll of a Thousand Whatevers", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, null, null, 0, null, 1, 3, false, 0, "v0.0.0", 0, null, 0, "Negligee", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, null, null, 0, null, 1, 5, false, 0, "v0.0.0", 0, null, 0, "Lightning Daggers", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Dimension", "Group", "IsLive", "Latitude", "LevelMaximum", "LevelMinimum", "Longitude", "Nickname", "ParentId", "Release", "Stage", "Title", "UriRevampWikia", "UriSmutosaurWiki", "What", "When", "Who" },
                values: new object[,]
                {
                    { 1, "Mareth is the world in which the story of Corruption of Champions takes place. It is an entirely different world to that from which the Champion comes, and the game opens with them being transported there via an interplanar portal.", 3, 1, false, 0.0, 0, 0, 0.0, null, 0, "0.9.4", 0, "Mareth", "http://coc-revamp.wikia.com/wiki/Mareth", "https://wiki.smutosaur.us/CoC/Mareth", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, "This is a pre-portal, gem and information gathering prologue to the Corruption of Champions main plot.", 3, 1, false, 0.0, 0, 0, 0.0, null, 0, "0.9.4", 0, "Ingnam", "http://coc-revamp.wikia.com/wiki/Ingnam", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, "An old looking forest, inhabited by a variety of (generally low level) enemies.", 3, 2, false, 0.0, 0, 0, 0.0, null, 1, "0.9.4", 0, "Forest", "http://coc-revamp.wikia.com/wiki/Forest", "https://wiki.smutosaur.us/CoC/Forest", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, "The shores of a freshwater lake, it is generally considered the lowest level area due to a lack of enemies at level 1. The lake itself can be explored with the lake boat.", 3, 2, false, 0.0, 0, 0, 0.0, null, 1, "0.9.4", 0, "Lake", "http://coc-revamp.wikia.com/wiki/Lake", "https://wiki.smutosaur.us/CoC/Lake", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, "A wide desert hiding the city of Tel'Adre.", 3, 2, false, 0.0, 0, 0, 0.0, null, 1, "0.9.4", 0, "Desert", "http://coc-revamp.wikia.com/wiki/Desert", "https://wiki.smutosaur.us/CoC/Desert", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, "A tall mountain and home to several higher-level enemies.", 3, 2, false, 0.0, 0, 0, 0.0, null, 1, "0.9.4", 0, "Mountain", "http://coc-revamp.wikia.com/wiki/Mountain", "https://wiki.smutosaur.us/CoC/Mountain", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, "Wide grasslands, and home to some of the tougher enemies in the game.", 3, 2, false, 0.0, 0, 0, 0.0, null, 1, "0.9.4", 0, "Plains", "http://coc-revamp.wikia.com/wiki/Plains", "https://wiki.smutosaur.us/CoC/Plains", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, "A sweltering and stagnant swamp, home to male and female spider-morphs.", 3, 2, false, 0.0, 0, 0, 0.0, null, 1, "0.9.4", 0, "Swamp", "http://coc-revamp.wikia.com/wiki/Swamp", "https://wiki.smutosaur.us/CoC/Swamp", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, "A region of forest hidden behind a wall of trees.", 3, 2, false, 0.0, 0, 0, 0.0, null, 3, "0.9.4", 0, "Deepwoods", "http://coc-revamp.wikia.com/wiki/Deepwoods", "https://wiki.smutosaur.us/CoC/Deepwoods", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, "A higher region of the Mountains and home to even tougher foes.", 3, 2, false, 0.0, 0, 0, 0.0, null, 6, "0.9.4", 0, "High Mountain", "http://coc-revamp.wikia.com/wiki/High_Mountain", "https://wiki.smutosaur.us/CoC/High_Mountain", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, "A particularly dark and humid area inside the Swamp.", 3, 2, false, 0.0, 0, 0, 0.0, null, 8, "0.9.4", 0, "Bog", "http://coc-revamp.wikia.com/wiki/Bog", "https://wiki.smutosaur.us/CoC/Bog", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, "Built around the portal where you first enter Mareth, the Campsite is a relatively safe place where you can rest and recover between adventures and store some of the items you don't need to bring along on your journeys.", 3, 3, false, 0.0, 0, 0, 0.0, null, 3, "0.9.4", 0, "Campsite", "http://coc-revamp.wikia.com/wiki/Camp", "https://wiki.smutosaur.us/CoC/Campsite", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, "", 3, 3, false, 0.0, 0, 0, 0.0, null, 4, "0.9.4", 0, "Boat", "http://coc-revamp.wikia.com/wiki/Boat", "https://wiki.smutosaur.us/CoC/Boat", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, "It is home to Marble the cow-girl and Kelt the centaur.", 3, 3, false, 0.0, 0, 0, 0.0, null, 4, "0.9.4", 0, "Farm", "http://coc-revamp.wikia.com/wiki/Whitney%27s_Farm", "https://wiki.smutosaur.us/CoC/Whitney%27s_Farm", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, "The Town Ruins is a run down town or village near the Lake.", 3, 3, false, 0.0, 0, 0, 0.0, null, 4, "0.9.4", 0, "Town Ruins", "http://coc-revamp.wikia.com/wiki/Town_Ruins", "https://wiki.smutosaur.us/CoC/Town_Ruins", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, "The ruins of a Cathedral", 3, 3, false, 0.0, 0, 0, 0.0, null, 5, "0.9.4", 0, "Cathedral", "http://coc-revamp.wikia.com/wiki/Cathedral", "https://wiki.smutosaur.us/CoC/Gargoyle", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, "Tel'Adre is a hidden city, relatively free of and concealed from corruption, located in the desert. The city owes its freedom to the Covenant, a powerful group of magic-users who reside in the city.", 3, 3, false, 0.0, 0, 0, 0.0, null, 5, "0.9.4", 0, "Tel'Adre", "http://coc-revamp.wikia.com/wiki/Tel%27Adre", "https://wiki.smutosaur.us/CoC/Tel%27Adre", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, "The Champion can discover a cleverly concealed doorway hidden within the Mountain, from which they can hear the sounds of blades being sharpened.", 3, 3, false, 0.0, 0, 0, 0.0, null, 6, "0.9.4", 0, "Salon", "http://coc-revamp.wikia.com/wiki/Salon", "https://wiki.smutosaur.us/CoC/Salon", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, "A settlement formed in the Plains from a ring of brightly colored wagons. It serves as a counter to Tel'Adre, in that it welcomes those who are corrupt and rejects those who are pure.", 3, 3, false, 0.0, 0, 0, 0.0, null, 7, "0.9.4", 0, "Bizarre Bazaar", "http://coc-revamp.wikia.com/wiki/Bizarre_Bazaar", "https://wiki.smutosaur.us/CoC/Bizarre_Bazaar", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, "Owca (aka Gang-bang Village) is a hidden village located in the plains.", 3, 3, false, 0.0, 0, 0, 0.0, null, 7, "0.9.4", 0, "Owca", "http://coc-revamp.wikia.com/wiki/Owca_Village", "https://wiki.smutosaur.us/CoC/Owca", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, "The Demon Factory (aka D1) sits at the foot of the Mountain. It can be found after visiting Marae by using the Boat found at the Lake.", 3, 5, false, 0.0, 0, 0, 0.0, null, 6, "0.9.4", 0, "Demon Factory", "http://coc-revamp.wikia.com/wiki/Demon_Factory", "https://wiki.smutosaur.us/CoC/Demon_Factory", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, "Deep Cave lies within the Deepwoods. It can be found once the Demon Factory is completed.", 3, 5, false, 0.0, 0, 0, 0.0, null, 9, "0.9.4", 0, "Deep Cave", "http://coc-revamp.wikia.com/wiki/Deep_Cave", "https://wiki.smutosaur.us/CoC/Deep_Cave", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, "The final dungeon in the game. It's located in the High Mountain and can only be found after clearing the Deep Cave.", 3, 5, false, 0.0, 0, 0, 0.0, null, 10, "0.9.4", 0, "Lethice's Stronghold", "http://coc-revamp.wikia.com/wiki/Lethice%27s_Stronghold", "https://wiki.smutosaur.us/CoC/Lethice%E2%80%99s_Stronghold", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, "Sand Witch's Dungeon (aka home of the sand witches)", 3, 5, false, 0.0, 0, 0, 0.0, null, 5, "0.9.4", 0, "Desert Cave", "http://coc-revamp.wikia.com/wiki/Desert_Cave", "https://wiki.smutosaur.us/CoC/Sand_Witch%27s_Dungeon", " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, "", 4, 2, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Glacial Rift", "http://coc-revamp.wikia.com/wiki/Glacial_Rift", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, "", 4, 2, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Volcanic Crag", "http://coc-revamp.wikia.com/wiki/Volcanic_Crag", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, "(Found under Dungeons)", 4, 3, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Anzu's Palace", "http://coc-revamp.wikia.com/wiki/Anzu", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, "Visit Minerva the Siren in High Mountain.", 4, 3, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Oasis Tower", "http://coc-revamp.wikia.com/wiki/Minerva", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, "Prison is a place that's the home of Mistress Elly, Scruffy the Imp, and more.", 4, 3, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Prison", "http://coc-revamp.wikia.com/wiki/Prison", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, "", 4, 5, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Tower of the Phoenix", "http://coc-revamp.wikia.com/wiki/Tower_of_the_Phoenix", null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, "Pocket dimension safe zone, smells like cookies", 1, 3, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Agora", null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, "", 1, 3, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Colosseum", null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Dimension", "Group", "IsLive", "Latitude", "LevelMaximum", "LevelMinimum", "Longitude", "Nickname", "ParentId", "Release", "Stage", "Title", "UriRevampWikia", "UriSmutosaurWiki", "What", "When", "Who" },
                values: new object[,]
                {
                    { 33, "", 1, 3, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Amphitheater", null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, "Indoor arena and horse racing complex", 1, 3, false, 0.0, 0, 0, 0.0, null, 0, "v0.0.0", 0, "Ak-Sar-Ben", null, null, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Abbreviation", "AttributeId", "CharacterId", "Description", "Dimension", "EffectId", "Group", "IsActive", "IsLive", "ItemId", "LocationId", "MomentId", "Release", "SaveStateId", "SkillTemplateId", "Stage", "Title", "UserProfileId", "UserProfileId1", "Value", "What", "When", "Who" },
                values: new object[,]
                {
                    { 10, null, null, null, "Chicks who get fucked silly. Tongues hanging out, eyes rolling back, that good stuff!", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Ahegao", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, null, null, null, "The wrong hole, but it feels so right.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Anal", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, null, null, null, "Ropes, leather suits, chains, total domination.  What more do you want? -cracks whip-", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "BDSM", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, null, null, null, "", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Big Ass", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, null, null, null, "", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Big Dick", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, null, null, null, "Oppai is love, oppai is life.  Unless you don't like big breasts I suppose.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Big Tits", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, null, null, null, "Oral sex, where guys get to relax, sit back and take in the view.  I heard it's quite a mouthful.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Blow Job", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, null, null, null, "BDSM without a ton of accessories.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Bondage", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, null, null, null, "Boobs on your dick.  Sound good?", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Boob Job", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, null, null, null, "Who said hentai couldn't be funny and sexy at the same time?", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Comedy", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, null, null, null, "How you were made.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Creampie", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, null, null, null, "Several dicks in a character.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Multiple Penetration", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, null, null, null, "Involves a dude ejaculating on a chick's face.  Mostly cause she ain't up for swallowing...", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Facial", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, null, null, null, "Guess who wears the pants in this relationship? Not you.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Femdom", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, null, null, null, "Who knew someone's feet could be put to good use...", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Foot Job", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, null, null, null, "Chicks with dicks.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Futanari", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, null, null, null, "When 3 or more people gang up on a single person of the opposite sex, we have this lovely situation play out.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Gangbang", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, null, null, null, "Allows NPCs to transition to another gender.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Gender Bender", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, null, null, null, "We're talking about a rain of liquid, and it's not gold.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Golden Shower", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, null, null, null, "Probably the best place a chick's hand can be.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Hand Job", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, null, null, null, "1 guy, multiple mates.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Harem", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, null, null, null, "Involves gore, spooky vibes or other horrifying things.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Horror", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, null, null, null, "Wincest", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Incest", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, null, null, null, "When someone's stomach or boobs get bigger due to magic or cum overload.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Inflation", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, null, null, null, "Breast milk anyone?", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Lactation", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, null, null, null, "Going down on some pussay!", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Licking", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, null, null, null, "", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Massocism", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, null, null, null, "Helping/watching without touching.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Masturbation", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, null, null, null, "Hot older women.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Milf", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, null, null, null, "Corrupting the innocent and turning them into sex crazed fiends, what more could you possibly ask for?", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Mind Break", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, null, null, null, "Sometimes matchmaking isn't easy... unless we involve drugs and magic! (Side effects might include getting raped.)", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Mind Control", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, null, null, null, "When the person you love cheats on you with someone else - willingly or unwillingly.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Netorare", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, null, null, null, "When you steal someone else's partner - opposite of netorare.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Netori", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, null, null, null, "A lot of people.  A lot of sex.  Enough said.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Orgy", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, null, null, null, "No need to wear a condom.  How much more pregnant could they get...?", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Pregnant", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, null, null, null, "Let's do it out here in broad daylight; there's no way someone will see us!", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Public Sex", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, null, null, null, "", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Rape", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, null, null, null, "Licking ass is never a good idea, butt fuck it...", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Rimjob", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, null, null, null, "", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Saddism", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, null, null, null, "If it looks like shit, smells like shit, and tastes like shit, it probably is shit.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Scat", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Abbreviation", "AttributeId", "CharacterId", "Description", "Dimension", "EffectId", "Group", "IsActive", "IsLive", "ItemId", "LocationId", "MomentId", "Release", "SaveStateId", "SkillTemplateId", "Stage", "Title", "UserProfileId", "UserProfileId1", "Value", "What", "When", "Who" },
                values: new object[,]
                {
                    { 50, null, null, null, "Do I really need to explain?", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Tentacle", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, null, null, null, "Like bringing a plus 1 to a 2-person party, but less awkward, more fun.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Threesome", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, null, null, null, "Vibrators, dildos, and all kinds of Nintendo type shit.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Toys", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, null, null, null, "We all know a tsundere chick.  They hate you at first, but then in a bizarre turn of events, end up fucking you in a closet.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Tsundere", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, null, null, null, "Someone untouched... until now.", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Virgin", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, null, null, null, "Creepin without sleepin", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Voyeur", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, null, null, null, "", 0, null, "TagGroup.Fetish", false, false, null, null, null, "v0.0.0", null, null, 0, "Weight Gain", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 100, null, null, null, null, 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Human", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 101, null, null, null, "Goo", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Slime", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 102, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Lamia", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 103, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Harpy", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 104, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Centaur", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 105, null, null, null, "Bunny Rabbit", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Lagomorph", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 106, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Dragon", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 107, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Fox", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 108, null, null, null, "Puppy Dog", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Wolf", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 109, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Cat", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 110, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Pony", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 111, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Raccoon", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 112, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Lizard", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 113, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Bee", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 114, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Goblin", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 115, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Shark", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 116, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Spider", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 117, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Kangaroo", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 118, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Mouse", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 119, null, null, null, "", 0, null, "TagGroup.EffectLimiter", false, false, null, null, null, "v0.0.0", null, null, 0, "Demon", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 120, null, null, null, "", 0, null, "TagGroup.EffectLimiter", false, false, null, null, null, "v0.0.0", null, null, 0, "Ghost", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 121, null, null, null, "", 0, null, "TagGroup.EffectLimiter", false, false, null, null, null, "v0.0.0", null, null, 0, "Mummy", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 122, null, null, null, "", 0, null, "TagGroup.EffectLimiter", false, false, null, null, null, "v0.0.0", null, null, 0, "Flying", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 123, null, null, null, "", 0, null, "TagGroup.EffectLimiter", false, false, null, null, null, "v0.0.0", null, null, 0, "Invisible", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 124, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Alien", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 125, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Cow", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 126, null, null, null, "", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Minotaur", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 127, null, null, null, "Has a natural affinity for the void.  Very curvatious with long, pointed back ears.", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Lunar Elf", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 128, null, null, null, "Has a natural affinity for the light.  Delightfully lithe and perky with long, pointed up ears.", 0, null, "TagGroup.CharacterSpecies", false, false, null, null, null, "v0.0.0", null, null, 0, "Solar Elf", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 129, null, null, null, "", 0, null, "TagGroup.Location", false, false, null, null, null, "v0.0.0", null, null, 0, "Explored", null, null, 0, " ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "Id", "Description", "Dimension", "DisplayName", "Email", "EmailPublic", "EmailVerified", "FormatTemperature", "FormatTime", "HideTutorialTips", "IsLive", "LoginPrevious", "Release", "SaveCurrentId", "ShowAdvancedTooltips", "Stage", "Theme", "Title", "What", "When", "Who" },
                values: new object[] { 1, "Primary profile for DMR development", 0, null, "rhodair@gmail.com", false, false, 1, 0, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "v0.0.0", null, false, 0, 0, "007", " ", new DateTime(2021, 12, 23, 1, 5, 48, 490, DateTimeKind.Utc).AddTicks(7706), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "CharacterTemplate",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    11,
                    12,
                    13,
                    14,
                    15,
                    16,
                    17,
                    18,
                    19,
                    20,
                    21,
                    22,
                    23,
                    24,
                    25,
                    26,
                    27,
                    28,
                    29,
                    30,
                    31,
                    32,
                    33,
                    34,
                    35,
                    36,
                    37,
                    38,
                    39,
                    40,
                    41,
                    42
                });

            migrationBuilder.InsertData(
                table: "CharacterTemplate",
                column: "Id",
                values: new object[]
                {
                    43,
                    44,
                    45,
                    46,
                    47,
                    48,
                    49,
                    50,
                    51,
                    52,
                    53,
                    54,
                    55,
                    56,
                    57,
                    58,
                    59,
                    60,
                    61,
                    62,
                    63,
                    64,
                    65,
                    66,
                    67,
                    68,
                    69,
                    70,
                    71,
                    72,
                    73,
                    74,
                    75,
                    76,
                    77,
                    78,
                    79,
                    80,
                    81,
                    82,
                    83,
                    84
                });

            migrationBuilder.InsertData(
                table: "CharacterTemplate",
                column: "Id",
                value: 85);

            migrationBuilder.InsertData(
                table: "ItemTemplate",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    11,
                    12,
                    13,
                    14,
                    15,
                    16,
                    17,
                    18,
                    19,
                    20,
                    21,
                    22,
                    23,
                    24,
                    25,
                    26,
                    27,
                    28,
                    29,
                    30,
                    31,
                    32,
                    33,
                    34,
                    35,
                    36,
                    37
                });

            migrationBuilder.InsertData(
                table: "LocationTemplate",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4
                });

            migrationBuilder.InsertData(
                table: "LocationTemplate",
                column: "Id",
                values: new object[]
                {
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    11,
                    12,
                    13,
                    14,
                    15,
                    16,
                    17,
                    18,
                    19,
                    20,
                    21,
                    22,
                    23,
                    24,
                    25,
                    26,
                    27,
                    28,
                    29,
                    30,
                    31,
                    32,
                    33,
                    34
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arm_CharacterId",
                table: "Arm",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Arm_SpeciesId",
                table: "Arm",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Attribute_CharacterId",
                table: "Attribute",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Attribute_ItemId",
                table: "Attribute",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Breast_CharacterId",
                table: "Breast",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Breast_SpeciesId",
                table: "Breast",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Butt_CharacterId",
                table: "Butt",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Butt_SpeciesId",
                table: "Butt",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_LocationId",
                table: "Character",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_MomentId",
                table: "Character",
                column: "MomentId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_SaveStateId",
                table: "Character",
                column: "SaveStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_SaveStateId1",
                table: "Character",
                column: "SaveStateId1");

            migrationBuilder.CreateIndex(
                name: "IX_Character_SaveStateId2",
                table: "Character",
                column: "SaveStateId2");

            migrationBuilder.CreateIndex(
                name: "IX_Character_SpeciesId",
                table: "Character",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_TorsoId",
                table: "Character",
                column: "TorsoId");

            migrationBuilder.CreateIndex(
                name: "IX_Effect_CharacterId",
                table: "Effect",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Effect_CharacterId1",
                table: "Effect",
                column: "CharacterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Effect_ItemId",
                table: "Effect",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Effect_SaveStateId",
                table: "Effect",
                column: "SaveStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Foot_CharacterId",
                table: "Foot",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Foot_SpeciesId",
                table: "Foot",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Hand_CharacterId",
                table: "Hand",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Hand_SpeciesId",
                table: "Hand",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Head_CharacterId",
                table: "Head",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Head_SpeciesId",
                table: "Head",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CharacterId",
                table: "Item",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CharacterId1",
                table: "Item",
                column: "CharacterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SaveStateId",
                table: "Item",
                column: "SaveStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Leg_CharacterId",
                table: "Leg",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Leg_SpeciesId",
                table: "Leg",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Moment_LocationId",
                table: "Moment",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Moment_SaveStateId",
                table: "Moment",
                column: "SaveStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Mouth_HeadId",
                table: "Mouth",
                column: "HeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Mouth_SpeciesId",
                table: "Mouth",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Penis_CharacterId",
                table: "Penis",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Penis_SpeciesId",
                table: "Penis",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_SaveState_PlayerId",
                table: "SaveState",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_SaveState_UserProfileId",
                table: "SaveState",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillTemplate_EffectImmediateId",
                table: "SkillTemplate",
                column: "EffectImmediateId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillTemplate_EffectOverTimeId",
                table: "SkillTemplate",
                column: "EffectOverTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_AttributeId",
                table: "Tag",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_CharacterId",
                table: "Tag",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_EffectId",
                table: "Tag",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_ItemId",
                table: "Tag",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_LocationId",
                table: "Tag",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_MomentId",
                table: "Tag",
                column: "MomentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_SaveStateId",
                table: "Tag",
                column: "SaveStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_SkillTemplateId",
                table: "Tag",
                column: "SkillTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_Title",
                table: "Tag",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_UserProfileId",
                table: "Tag",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_UserProfileId1",
                table: "Tag",
                column: "UserProfileId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tail_CharacterId",
                table: "Tail",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Tail_SpeciesId",
                table: "Tail",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Torso_SpeciesId",
                table: "Torso",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_SaveCurrentId",
                table: "UserProfile",
                column: "SaveCurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagina_CharacterId",
                table: "Vagina",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagina_SpeciesId",
                table: "Vagina",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Wing_CharacterId",
                table: "Wing",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Wing_SpeciesId",
                table: "Wing",
                column: "SpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTemplate_Character_Id",
                table: "CharacterTemplate",
                column: "Id",
                principalTable: "Character",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTemplate_Item_Id",
                table: "ItemTemplate",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moment_SaveState_SaveStateId",
                table: "Moment",
                column: "SaveStateId",
                principalTable: "SaveState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaveStateTemplate_SaveState_Id",
                table: "SaveStateTemplate",
                column: "Id",
                principalTable: "SaveState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillTemplate_Effect_EffectImmediateId",
                table: "SkillTemplate",
                column: "EffectImmediateId",
                principalTable: "Effect",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillTemplate_Effect_EffectOverTimeId",
                table: "SkillTemplate",
                column: "EffectOverTimeId",
                principalTable: "Effect",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Torso_Tag_SpeciesId",
                table: "Torso",
                column: "SpeciesId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_SaveState_SaveCurrentId",
                table: "UserProfile",
                column: "SaveCurrentId",
                principalTable: "SaveState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaveState_Character_PlayerId",
                table: "SaveState",
                column: "PlayerId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Tag_SpeciesId",
                table: "Character",
                column: "SpeciesId",
                principalTable: "Tag",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Torso_TorsoId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Tag_SpeciesId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_SaveState_Character_PlayerId",
                table: "SaveState");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_SaveState_SaveCurrentId",
                table: "UserProfile");

            migrationBuilder.DropTable(
                name: "Arm");

            migrationBuilder.DropTable(
                name: "Breast");

            migrationBuilder.DropTable(
                name: "Butt");

            migrationBuilder.DropTable(
                name: "CharacterTemplate");

            migrationBuilder.DropTable(
                name: "Foot");

            migrationBuilder.DropTable(
                name: "Hand");

            migrationBuilder.DropTable(
                name: "ItemTemplate");

            migrationBuilder.DropTable(
                name: "Leg");

            migrationBuilder.DropTable(
                name: "LocationTemplate");

            migrationBuilder.DropTable(
                name: "Mouth");

            migrationBuilder.DropTable(
                name: "Penis");

            migrationBuilder.DropTable(
                name: "SaveStateTemplate");

            migrationBuilder.DropTable(
                name: "Tail");

            migrationBuilder.DropTable(
                name: "Vagina");

            migrationBuilder.DropTable(
                name: "Wing");

            migrationBuilder.DropTable(
                name: "Head");

            migrationBuilder.DropTable(
                name: "Torso");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "SkillTemplate");

            migrationBuilder.DropTable(
                name: "Effect");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "Moment");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "SaveState");

            migrationBuilder.DropTable(
                name: "UserProfile");
        }
    }
}
