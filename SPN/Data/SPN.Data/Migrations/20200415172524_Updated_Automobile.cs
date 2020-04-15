using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class Updated_Automobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Address = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProfileImage = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtraFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    KeylessEntry = table.Column<bool>(nullable: true),
                    KeylessIgnition = table.Column<bool>(nullable: true),
                    LowGear = table.Column<bool>(nullable: true),
                    PanoramicRoof = table.Column<bool>(nullable: true),
                    RoofRack = table.Column<bool>(nullable: true),
                    ElectricTailgate = table.Column<bool>(nullable: true),
                    LongBase = table.Column<bool>(nullable: true),
                    ShortBase = table.Column<bool>(nullable: true),
                    Registered = table.Column<bool>(nullable: true),
                    MOT = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    ImageUrl1 = table.Column<string>(nullable: true),
                    ImageUrl2 = table.Column<string>(nullable: true),
                    ImageUrl3 = table.Column<string>(nullable: true),
                    ImageUrl4 = table.Column<string>(nullable: true),
                    ImageUrl5 = table.Column<string>(nullable: true),
                    ImageUrl6 = table.Column<string>(nullable: true),
                    ImageUrl7 = table.Column<string>(nullable: true),
                    ImageUrl8 = table.Column<string>(nullable: true),
                    ImageUrl9 = table.Column<string>(nullable: true),
                    ImageUrl10 = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InteriorMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    LeatherSteeringWheel = table.Column<bool>(nullable: true),
                    LeatherSeats = table.Column<bool>(nullable: true),
                    ClothSeats = table.Column<bool>(nullable: true),
                    Alcantara = table.Column<bool>(nullable: true),
                    Velour = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteriorMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interiors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Bluetooth = table.Column<bool>(nullable: true),
                    DVDPlayer = table.Column<bool>(nullable: true),
                    PaddleShifters = table.Column<bool>(nullable: true),
                    USBAux = table.Column<bool>(nullable: true),
                    BoardComputer = table.Column<bool>(nullable: true),
                    PowerMirrors = table.Column<bool>(nullable: true),
                    PowerWindows = table.Column<bool>(nullable: true),
                    ElectronicSeatControl = table.Column<bool>(nullable: true),
                    AmbientLighting = table.Column<bool>(nullable: true),
                    Navigation = table.Column<bool>(nullable: true),
                    HeatedSteeringWheel = table.Column<bool>(nullable: true),
                    Fridge = table.Column<bool>(nullable: true),
                    HeatedSeats = table.Column<bool>(nullable: true),
                    Stereo = table.Column<bool>(nullable: true),
                    AutoPilot = table.Column<bool>(nullable: true),
                    AndroidAuto = table.Column<bool>(nullable: true),
                    AppleCarPlay = table.Column<bool>(nullable: true),
                    PowerSteering = table.Column<bool>(nullable: true),
                    AirConditioning = table.Column<bool>(nullable: true),
                    MultiFunctionalSteeringWheel = table.Column<bool>(nullable: true),
                    HeadUpDisplay = table.Column<bool>(nullable: true),
                    SmokerPackage = table.Column<bool>(nullable: true),
                    ArmRest = table.Column<bool>(nullable: true),
                    HeatedWindshield = table.Column<bool>(nullable: true),
                    StartStopSystem = table.Column<bool>(nullable: true),
                    RainSensor = table.Column<bool>(nullable: true),
                    CentralLocking = table.Column<bool>(nullable: true),
                    MassageSeats = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interiors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryProperties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Mileage = table.Column<string>(nullable: true),
                    Horsepower = table.Column<int>(nullable: false),
                    Engine = table.Column<int>(nullable: false),
                    GearBox = table.Column<int>(nullable: false),
                    Condition = table.Column<int>(nullable: false),
                    Body = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Region = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SafetyFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    GPS = table.Column<bool>(nullable: true),
                    StabilityControl = table.Column<bool>(nullable: true),
                    TractionControl = table.Column<bool>(nullable: true),
                    AdaptiveHeadlights = table.Column<bool>(nullable: true),
                    AutomaticBrakeSystem = table.Column<bool>(nullable: true),
                    FrontAirbags = table.Column<bool>(nullable: true),
                    RearAirbags = table.Column<bool>(nullable: true),
                    SideAirbags = table.Column<bool>(nullable: true),
                    FourWheelSteering = table.Column<bool>(nullable: true),
                    ElectronicStabilityProgram = table.Column<bool>(nullable: true),
                    TirePressureMonitoringSystem = table.Column<bool>(nullable: true),
                    RearParkingSensor = table.Column<bool>(nullable: true),
                    FrontParkingSensor = table.Column<bool>(nullable: true),
                    ISOFIX = table.Column<bool>(nullable: true),
                    ForwardCollisionWarning = table.Column<bool>(nullable: true),
                    AutomaticEmergencyBraking = table.Column<bool>(nullable: true),
                    PedestrianDetection = table.Column<bool>(nullable: true),
                    BlindSpotMonitoring = table.Column<bool>(nullable: true),
                    LaneKeepingAssistance = table.Column<bool>(nullable: true),
                    AdaptiveCruiseControl = table.Column<bool>(nullable: true),
                    LaneCenteringAssist = table.Column<bool>(nullable: true),
                    HillDescendAssist = table.Column<bool>(nullable: true),
                    DistTronic = table.Column<bool>(nullable: true),
                    FourWheelDrive = table.Column<bool>(nullable: true),
                    AlarmSystem = table.Column<bool>(nullable: true),
                    EmergencyCallSystem = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafetyFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecializedFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    DisabledAccessible = table.Column<bool>(nullable: true),
                    Taxi = table.Column<bool>(nullable: true),
                    Ambulance = table.Column<bool>(nullable: true),
                    Hearse = table.Column<bool>(nullable: true),
                    Learner = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializedFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suspensions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    ElectronicSuspensionControl = table.Column<bool>(nullable: true),
                    AdaptiveAirSuspension = table.Column<bool>(nullable: true),
                    LockingDifferential = table.Column<bool>(nullable: true),
                    ActiveSuspension = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Views = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    MakeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Makes_MakeId",
                        column: x => x.MakeId,
                        principalTable: "Makes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostLikes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLikes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Replies_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Replies_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Automobiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    MakeId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    PrimaryPropertiesId = table.Column<int>(nullable: true),
                    SafetyId = table.Column<int>(nullable: true),
                    InteriorsId = table.Column<int>(nullable: true),
                    InteriorMaterialsId = table.Column<int>(nullable: true),
                    SuspensionsId = table.Column<int>(nullable: true),
                    SpecializedFeaturesId = table.Column<int>(nullable: true),
                    ExtraFeaturesId = table.Column<int>(nullable: true),
                    ImagesId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Automobiles_ExtraFeatures_ExtraFeaturesId",
                        column: x => x.ExtraFeaturesId,
                        principalTable: "ExtraFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Automobiles_InteriorMaterials_InteriorMaterialsId",
                        column: x => x.InteriorMaterialsId,
                        principalTable: "InteriorMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_Interiors_InteriorsId",
                        column: x => x.InteriorsId,
                        principalTable: "Interiors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_Makes_MakeId",
                        column: x => x.MakeId,
                        principalTable: "Makes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_PrimaryProperties_PrimaryPropertiesId",
                        column: x => x.PrimaryPropertiesId,
                        principalTable: "PrimaryProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_SafetyFeatures_SafetyId",
                        column: x => x.SafetyId,
                        principalTable: "SafetyFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_SpecializedFeatures_SpecializedFeaturesId",
                        column: x => x.SpecializedFeaturesId,
                        principalTable: "SpecializedFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_Suspensions_SuspensionsId",
                        column: x => x.SuspensionsId,
                        principalTable: "Suspensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    ReplyId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quotes_Replies_ReplyId",
                        column: x => x.ReplyId,
                        principalTable: "Replies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReplyLikes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ReplyId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplyLikes_Replies_ReplyId",
                        column: x => x.ReplyId,
                        principalTable: "Replies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReplyLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuoteLikes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    QuoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuoteLikes_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuoteLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_ExtraFeaturesId",
                table: "Automobiles",
                column: "ExtraFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_ImagesId",
                table: "Automobiles",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_InteriorMaterialsId",
                table: "Automobiles",
                column: "InteriorMaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_InteriorsId",
                table: "Automobiles",
                column: "InteriorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_MakeId",
                table: "Automobiles",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_ModelId",
                table: "Automobiles",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_PrimaryPropertiesId",
                table: "Automobiles",
                column: "PrimaryPropertiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_SafetyId",
                table: "Automobiles",
                column: "SafetyId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_SpecializedFeaturesId",
                table: "Automobiles",
                column: "SpecializedFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_SuspensionsId",
                table: "Automobiles",
                column: "SuspensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_UserId",
                table: "Automobiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_MakeId",
                table: "Models",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_PostId",
                table: "PostLikes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_UserId",
                table: "PostLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_QuoteLikes_QuoteId",
                table: "QuoteLikes",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_QuoteLikes_UserId",
                table: "QuoteLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_AuthorId",
                table: "Quotes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_ReplyId",
                table: "Quotes",
                column: "ReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_AuthorId",
                table: "Replies",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_PostId",
                table: "Replies",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyLikes_ReplyId",
                table: "ReplyLikes",
                column: "ReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyLikes_UserId",
                table: "ReplyLikes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Automobiles");

            migrationBuilder.DropTable(
                name: "PostLikes");

            migrationBuilder.DropTable(
                name: "QuoteLikes");

            migrationBuilder.DropTable(
                name: "ReplyLikes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ExtraFeatures");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "InteriorMaterials");

            migrationBuilder.DropTable(
                name: "Interiors");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "PrimaryProperties");

            migrationBuilder.DropTable(
                name: "SafetyFeatures");

            migrationBuilder.DropTable(
                name: "SpecializedFeatures");

            migrationBuilder.DropTable(
                name: "Suspensions");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "Makes");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
