using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PishePlus.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeGroup",
                columns: table => new
                {
                    CodeGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeGroupGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeGroup", x => x.CodeGroupID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentProvider",
                columns: table => new
                {
                    PaymentProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentProviderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProvider", x => x.PaymentProviderID);
                });

            migrationBuilder.CreateTable(
                name: "PermissionGroup",
                columns: table => new
                {
                    PermissionGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionGroupGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionGroup", x => x.PermissionGroupID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserInitialCredit = table.Column<int>(nullable: false),
                    OrderRequestPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingID);
                });

            migrationBuilder.CreateTable(
                name: "SMSProvider",
                columns: table => new
                {
                    SMSProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProvider", x => x.SMSProviderID);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Usage = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagID);
                });

            migrationBuilder.CreateTable(
                name: "Code",
                columns: table => new
                {
                    CodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CodeGroupID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Code", x => x.CodeID);
                    table.ForeignKey(
                        name: "FK_Code_CodeGroup",
                        column: x => x.CodeGroupID,
                        principalTable: "CodeGroup",
                        principalColumn: "CodeGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentProviderSetting",
                columns: table => new
                {
                    PaymentProviderSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentProviderSettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PaymentProviderID = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 128, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    APIKey = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProviderSetting", x => x.PaymentProviderSettingID);
                    table.ForeignKey(
                        name: "FK_PaymentProviderSetting_PaymentProvider",
                        column: x => x.PaymentProviderID,
                        principalTable: "PaymentProvider",
                        principalColumn: "PaymentProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionGroupID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionID);
                    table.ForeignKey(
                        name: "FK_Permission_PermissionGroup",
                        column: x => x.PermissionGroupID,
                        principalTable: "PermissionGroup",
                        principalColumn: "PermissionGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ProvinceID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_City_Province",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ProvinceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSProviderSetting",
                columns: table => new
                {
                    SMSProviderSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderSettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderID = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 128, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    APIKey = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProviderSetting", x => x.SMSProviderSettingID);
                    table.ForeignKey(
                        name: "FK_SMSProviderSetting_SMSProvider",
                        column: x => x.SMSProviderID,
                        principalTable: "SMSProvider",
                        principalColumn: "SMSProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    ContactUsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUsGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContactUsBusinessTypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 128, nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.ContactUsID);
                    table.ForeignKey(
                        name: "FK_ContactUs_Code",
                        column: x => x.ContactUsBusinessTypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Size = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_Document_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PublicDiscount",
                columns: table => new
                {
                    PublicDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(maxLength: 128, nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicDiscount", x => x.PublicDiscountID);
                    table.ForeignKey(
                        name: "FK_PublicDiscount_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Cost = table.Column<long>(nullable: false),
                    Serial = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    RolePermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolePermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.RolePermissionID);
                    table.ForeignKey(
                        name: "FK_RolePermission_Permission",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSProviderSettingNumber",
                columns: table => new
                {
                    SMSProviderSettingNumberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderSettingNumberGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderSettingID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProviderSettingNumber", x => x.SMSProviderSettingNumberID);
                    table.ForeignKey(
                        name: "FK_SMSProviderSettingNumber_SMSProviderSetting",
                        column: x => x.SMSProviderSettingID,
                        principalTable: "SMSProviderSetting",
                        principalColumn: "SMSProviderSettingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSTemplate",
                columns: table => new
                {
                    SMSTemplateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSTemplateGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderSettingID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSTemplate", x => x.SMSTemplateID);
                    table.ForeignKey(
                        name: "FK_SMSTemplate_SMSProviderSetting",
                        column: x => x.SMSProviderSettingID,
                        principalTable: "SMSProviderSetting",
                        principalColumn: "SMSProviderSettingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    AdvertisementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertisementGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    DocumentID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.AdvertisementID);
                    table.ForeignKey(
                        name: "FK_Advertisement_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    DocumentID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    VersionCode = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_Application_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ParentCategoryID = table.Column<int>(nullable: true),
                    CoverDocumentID = table.Column<int>(nullable: true),
                    SecondPageCoverDocumentID = table.Column<int>(nullable: true),
                    ActiveIconDocumentID = table.Column<int>(nullable: true),
                    InactiveIconDocumentID = table.Column<int>(nullable: true),
                    QuadMenuDocumentID = table.Column<int>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    Abstract = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Category_ActiveIconDocument",
                        column: x => x.ActiveIconDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_CoverDocument",
                        column: x => x.CoverDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_InactiveIconDocument",
                        column: x => x.InactiveIconDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_ParentCategory",
                        column: x => x.ParentCategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_QuadMenuDocument",
                        column: x => x.QuadMenuDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_SecondPageCoverDocument",
                        column: x => x.SecondPageCoverDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    RoleID = table.Column<int>(nullable: false),
                    GenderCodeID = table.Column<int>(nullable: true),
                    ProfileDocumentID = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 128, nullable: false),
                    LastName = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 128, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsRegister = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    RegisteredDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Code",
                        column: x => x.GenderCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Document_ProfileDocumentID",
                        column: x => x.ProfileDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Role",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTag",
                columns: table => new
                {
                    CategoryTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CategoryID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTag", x => x.CategoryTagID);
                    table.ForeignKey(
                        name: "FK_CategoryTag_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoryTag_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Admin_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Client_City",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comment_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    ComplaintID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(maxLength: 512, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintID);
                    table.ForeignKey(
                        name: "FK_Complaint_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contractor",
                columns: table => new
                {
                    ContractorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    BusinessTypeCodeID = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(maxLength: 128, nullable: false),
                    Longitude = table.Column<string>(maxLength: 128, nullable: false),
                    Credit = table.Column<int>(nullable: false),
                    AverageRate = table.Column<double>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AboutMe = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(maxLength: 128, nullable: true),
                    Website = table.Column<string>(maxLength: 128, nullable: true),
                    Instagram = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractor", x => x.ContractorID);
                    table.ForeignKey(
                        name: "FK_Contractor_Code",
                        column: x => x.BusinessTypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractor_City",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractor_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    DocumentID = table.Column<int>(nullable: false),
                    SliderCodeId = table.Column<int>(nullable: true),
                    ViewCount = table.Column<int>(nullable: false),
                    LikeCount = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Abstract = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsSuggested = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Post_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Code",
                        column: x => x.SliderCodeId,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSResponse",
                columns: table => new
                {
                    SMSResponseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSResponseGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSTemplateID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusText = table.Column<string>(nullable: false),
                    Sender = table.Column<string>(maxLength: 128, nullable: false),
                    Receptor = table.Column<string>(maxLength: 128, nullable: false),
                    Token = table.Column<string>(maxLength: 128, nullable: true),
                    Token1 = table.Column<string>(maxLength: 128, nullable: true),
                    Token2 = table.Column<string>(maxLength: 128, nullable: true),
                    Message = table.Column<string>(nullable: false),
                    Cost = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    SentDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSResponse", x => x.SMSResponseID);
                    table.ForeignKey(
                        name: "FK_SMSResponse_SMSTemplate",
                        column: x => x.SMSTemplateID,
                        principalTable: "SMSTemplate",
                        principalColumn: "SMSTemplateID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMSResponse_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suggestion",
                columns: table => new
                {
                    SuggestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuggestionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(maxLength: 512, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestion", x => x.SuggestionID);
                    table.ForeignKey(
                        name: "FK_Suggestion_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    TokenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    RoleCodeID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.TokenID);
                    table.ForeignKey(
                        name: "FK_Token_Code",
                        column: x => x.RoleCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Token_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPermission",
                columns: table => new
                {
                    UserPermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserPermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermission", x => x.UserPermissionID);
                    table.ForeignKey(
                        name: "FK_UserPermission_Permission",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPermission_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorCategory",
                columns: table => new
                {
                    ContractorCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorCategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorCategory", x => x.ContractorCategoryID);
                    table.ForeignKey(
                        name: "FK_ContractorCategory_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorCategory_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorDiscount",
                columns: table => new
                {
                    ContractorDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    PublicDiscountID = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorDiscount", x => x.ContractorDiscountID);
                    table.ForeignKey(
                        name: "FK_ContractorDiscount_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorDiscount_PublicDiscount",
                        column: x => x.PublicDiscountID,
                        principalTable: "PublicDiscount",
                        principalColumn: "PublicDiscountID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorDocument",
                columns: table => new
                {
                    ContractorDocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorDocumentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    TitleCodeID = table.Column<int>(nullable: false),
                    DocumentID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorDocument", x => x.ContractorDocumentID);
                    table.ForeignKey(
                        name: "FK_ContractorDocument_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorDocument_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorDocument_Code",
                        column: x => x.TitleCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ClientID = table.Column<int>(nullable: false),
                    ContractorID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    StateCodeID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Rate = table.Column<double>(nullable: true),
                    Cost = table.Column<int>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    DeadlineDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Client",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Code",
                        column: x => x.StateCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PaymentProviderSettingID = table.Column<int>(nullable: false),
                    ContractorID = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    TrackingToken = table.Column<long>(nullable: true),
                    IsSuccessful = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payment_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentProviderSetting_PaymentProviderSettingID",
                        column: x => x.PaymentProviderSettingID,
                        principalTable: "PaymentProviderSetting",
                        principalColumn: "PaymentProviderSettingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivateDiscount",
                columns: table => new
                {
                    PrivateDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivateDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(maxLength: 128, nullable: false),
                    MaximumUsesNumber = table.Column<int>(nullable: false),
                    NumberUsed = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateDiscount", x => x.PrivateDiscountID);
                    table.ForeignKey(
                        name: "FK_PrivateDiscount_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrivateDiscount_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostCategory",
                columns: table => new
                {
                    PostCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CategoryID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategory", x => x.PostCategoryID);
                    table.ForeignKey(
                        name: "FK_PostCategory_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostCategory_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    PostCommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCommentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CommentID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false),
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.PostCommentID);
                    table.ForeignKey(
                        name: "FK_PostComment_Comment",
                        column: x => x.CommentID,
                        principalTable: "Comment",
                        principalColumn: "CommentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostComment_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PostID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => x.PostTagID);
                    table.ForeignKey(
                        name: "FK_PostTag_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostTag_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderRequest",
                columns: table => new
                {
                    OrderRequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRequestGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    StateCodeID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    OfferedPrice = table.Column<long>(nullable: false),
                    IsAllow = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRequest", x => x.OrderRequestID);
                    table.ForeignKey(
                        name: "FK_OrderRequest_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRequest_Order",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRequest_StateCode",
                        column: x => x.StateCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChatMessage",
                columns: table => new
                {
                    ChatMessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatMessageGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    OrderRequestID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    IsSeen = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsModified = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    SentAt = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessage", x => x.ChatMessageID);
                    table.ForeignKey(
                        name: "FK_ChatMessage_OrderRequest",
                        column: x => x.OrderRequestID,
                        principalTable: "OrderRequest",
                        principalColumn: "OrderRequestID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatMessage_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Application",
                columns: new[] { "ApplicationID", "ApplicationGUID", "DocumentID", "Name", "VersionCode" },
                values: new object[,]
                {
                    { 1, new Guid("ea6c70be-e882-4126-9268-df9ff783a5b9"), null, "پیشیار پلاس", null },
                    { 2, new Guid("2c75afea-b9da-46c2-a378-aab8e2b9e9d0"), null, "متخصص", null }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "SecondPageCoverDocumentID", "Sort" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), null, null, "سایت اصلی", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 798, DateTimeKind.Local).AddTicks(8967), null, null, null, 1 },
                    { 2, null, null, new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), null, null, "وبلاگ", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(557), null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "CodeGroup",
                columns: new[] { "CodeGroupID", "CodeGroupGUID", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 7, new Guid("ad006ad5-56e9-46ae-96a9-5e772870ac70"), "وضعیت درخواست سفارش", "OrderRequestState" },
                    { 6, new Guid("107a7244-6e66-4369-8ba6-dfb0636642c4"), "نوع کسب و کار بخش ارتباط با ما", "ContactUsBusinessType" },
                    { 4, new Guid("39c56245-8e42-4cef-8ddd-5e4c17782e8b"), "وضعیت سفارش", "OrderState" },
                    { 5, new Guid("7e9db57a-0c09-47ff-98b5-f49363beff67"), "نقش", "Role" },
                    { 2, new Guid("2d9c9e83-39eb-42d7-b71f-ef26002c8470"), "نوع کسب و کار", "BusinessType" },
                    { 1, new Guid("5b739a57-164e-4b39-8b1c-1129bc9d8991"), "نوع فایل", "FilepondType" },
                    { 3, new Guid("a76da3ba-d12a-42c4-b7e1-732d0990af70"), "جنسیت", "Gender" }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceID", "Name", "ProvinceGUID" },
                values: new object[,]
                {
                    { 23, "فارس", new Guid("7ff8e4f6-65ae-4937-99e3-0c019c0ff03d") },
                    { 19, "اصفهان", new Guid("1d80bb98-8b4c-42f9-bbdb-8964df8c1d26") },
                    { 20, "ايلام", new Guid("533e2d8e-4733-4ee2-9779-13072cf4e07d") },
                    { 21, "تهران", new Guid("373c383a-dfde-4539-9c34-d4ffa641d9fc") },
                    { 22, "آذربايجان شرقي", new Guid("67eb9d55-7bf2-4552-9d6b-288bd4e2892f") },
                    { 24, "کرمانشاه", new Guid("d230177f-0375-43e6-98d2-46263e007894") },
                    { 30, "سمنان", new Guid("0dc78599-c499-4973-988c-80cd8719f44e") },
                    { 26, "مرکزي", new Guid("35bbea6f-c713-4075-b8b5-dfdcf5e3d3df") },
                    { 27, "گيلان", new Guid("0695b480-b891-4baa-a67e-383fe0d34d9b") },
                    { 28, "همدان", new Guid("c4769158-a759-43b6-95fa-2d09cd015ec0") },
                    { 29, "کرمان", new Guid("893c3e2a-d70c-41f1-8866-bb11da5feb29") },
                    { 18, "اردبيل", new Guid("4c449398-3c23-4844-84a5-f87e723daa83") },
                    { 31, "کهگيلويه و بويراحمد", new Guid("a7dbceee-bcc7-4fc0-8e2c-4ba1f8ffbe3b") },
                    { 25, "هرمزگان", new Guid("dc8ca021-b6ef-4638-9f01-3c4d6b7909d7") },
                    { 17, "لرستان", new Guid("f68b78aa-45f3-493e-bf0f-ddc35d85fc97") },
                    { 13, "زنجان", new Guid("20a1a328-5d5c-4996-a86f-0fa3c1924b95") },
                    { 15, "مازندران", new Guid("c6258ced-75bf-481a-8c66-e3472c88f038") },
                    { 1, "يزد", new Guid("c538a184-aa84-4dc9-aec3-84ecf61d9673") },
                    { 2, "چهار محال و بختياري", new Guid("a1693231-0b59-4553-ad8c-f042416752c0") },
                    { 3, "خراسان شمالي", new Guid("86480c5c-6920-47ba-8702-2297cb993341") },
                    { 4, "البرز", new Guid("ede206cc-e5cd-4d4f-9d6f-42375a6fc84a") },
                    { 5, "قم", new Guid("aea20862-bc42-463a-ad01-f10ebd780ed8") },
                    { 16, "قزوين", new Guid("c3df7083-d123-47cb-a7cc-2a1d2b398adc") },
                    { 7, "آذربايجان غربي", new Guid("aef751d9-e5d8-4f71-884a-c6460e8e6fdc") },
                    { 6, "کردستان", new Guid("b5d2dfc5-bc0b-44f3-837f-deab9b80ee3a") },
                    { 9, "سيستان و بلوچستان", new Guid("7653408c-51eb-4b87-9b43-169c9fefcd8b") },
                    { 10, "خراسان جنوبي", new Guid("b6cfd146-8c6b-4178-bfb4-b566db53e497") },
                    { 11, "خوزستان", new Guid("b7a71339-5670-42a6-95ba-a55ba5bc7092") },
                    { 12, "بوشهر", new Guid("df0c318c-c38f-4d47-9cb5-95ec2f86a368") },
                    { 14, "گلستان", new Guid("a533f0ed-71ea-4a23-a2c7-5b5dbfaaa867") },
                    { 8, "خراسان رضوي", new Guid("3aa05e1e-ba8f-4385-9ddb-a9a674a1c8d7") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "DisplayName", "ModifiedDate", "Name", "RoleGUID" },
                values: new object[,]
                {
                    { 1, "ادمین", new DateTime(2020, 7, 19, 10, 55, 21, 790, DateTimeKind.Local).AddTicks(9909), "Admin", new Guid("2fa4858b-0723-4ca2-8666-e0a2dd54c97d") },
                    { 2, "سرویس دهنده", new DateTime(2020, 7, 19, 10, 55, 21, 793, DateTimeKind.Local).AddTicks(4391), "Contractor", new Guid("f86d6995-dedc-407a-bcfb-c1cacb785525") },
                    { 3, "سرویس گیرنده", new DateTime(2020, 7, 19, 10, 55, 21, 793, DateTimeKind.Local).AddTicks(4462), "Client", new Guid("215637f0-0630-409b-bfcc-8e477adecc1f") }
                });

            migrationBuilder.InsertData(
                table: "SMSProvider",
                columns: new[] { "SMSProviderID", "Name" },
                values: new object[] { 1, "Kavenegar" });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "SettingID", "OrderRequestPrice", "SettingGUID", "UserInitialCredit" },
                values: new object[] { 1, 500, new Guid("0ba8108f-bd8d-46ad-860f-b2fac2e48cc5"), 10000 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "SecondPageCoverDocumentID", "Sort" },
                values: new object[,]
                {
                    { 3, null, null, new Guid("e3b1e3a1-4d79-454d-8b1f-6c9e24e290b2"), null, null, "تاسیسات", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(601), 1, null, null, 1 },
                    { 4, null, null, new Guid("ec81ce2f-8e74-4e5e-a521-e332359e7410"), null, null, "ماشین آلات صنعتی", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(617), 1, null, null, 2 },
                    { 5, null, null, new Guid("ab0e3f44-83a8-4eb4-bdf2-ef7cde86e1c9"), null, null, "تامین کالا", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(660), 1, null, null, 3 },
                    { 6, null, null, new Guid("25f8548f-af05-4348-8f93-f7ab74428d04"), null, null, "ساخت و ساز", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(668), 1, null, null, 4 },
                    { 7, null, null, new Guid("f7a1bf11-b8b1-4eab-b19a-978a9ada1f15"), null, null, "تعمیرات", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(676), 1, null, null, 5 },
                    { 8, null, null, new Guid("bfb3253b-f907-45c1-8552-87b0171165d4"), null, null, "خدمات", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(690), 1, null, null, 6 },
                    { 9, null, null, new Guid("e8dd8455-ee7e-4bcb-acc5-62af362d15a8"), null, null, "زیرساخت", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(698), 1, null, null, 7 },
                    { 10, null, null, new Guid("fed54fe5-b90a-432c-9d24-d8c7248219dd"), null, null, "حمل و نقل", null, true, new DateTime(2020, 7, 19, 10, 55, 21, 799, DateTimeKind.Local).AddTicks(705), 1, null, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 825, new Guid("49f35450-e379-420c-ae3e-7d2e41700edf"), "قره آغاج", 22 },
                    { 824, new Guid("1aaa33cd-0a66-4401-9ddf-b7cfbcb25cbd"), "عجب شير", 22 },
                    { 823, new Guid("078e33b6-61ae-4460-97e7-f57d2e24b20d"), "صوفيان", 22 },
                    { 822, new Guid("d9cc0038-38c3-4a3a-9ec0-9451a95f8306"), "شهر جديد سهند", 22 },
                    { 821, new Guid("f8bed4a0-24dd-4242-93e7-5893018b7f55"), "شند آباد", 22 },
                    { 820, new Guid("bc4b3987-dfff-4843-b2d2-ffe8ea15a06e"), "شرفخانه", 22 },
                    { 819, new Guid("3514f2af-4280-4069-aa50-2a8278fd651b"), "شربيان", 22 },
                    { 815, new Guid("15e5adb8-4042-4ab9-b649-1f2e96bf8f03"), "سردرود", 22 },
                    { 817, new Guid("c1f8c2d1-4295-4ec7-830b-3ad9ca8ff60c"), "سيه رود", 22 },
                    { 816, new Guid("4be14a60-c846-421f-b2d5-b58b5303d10b"), "سيس", 22 },
                    { 826, new Guid("b1013c87-acc4-4a02-8ec5-683ff5e298b3"), "ليلان", 22 },
                    { 814, new Guid("4994a6e3-bb4e-4ece-93db-c171603dcf0b"), "سراب", 22 },
                    { 813, new Guid("5f4373b0-e5a7-488a-91fb-e71354351617"), "زنوز", 22 },
                    { 812, new Guid("9268df14-5880-4b79-bea5-4909377f6dc9"), "زرنق", 22 },
                    { 811, new Guid("10bd148d-1778-4b35-89e0-a12191c6d69b"), "دوزدوزان", 22 },
                    { 818, new Guid("2bc9f09f-c2b2-4fca-967c-d791356e1bd0"), "شبستر", 22 },
                    { 827, new Guid("8f17ca0b-0ddd-4b9c-8e40-c2eae1d0193c"), "مبارک شهر", 22 },
                    { 831, new Guid("dc40ea8a-165d-4633-9b45-8534d63903c9"), "ممقان", 22 },
                    { 829, new Guid("3dab22d5-adca-4545-975a-bb868561ad97"), "مرند", 22 },
                    { 845, new Guid("7022ff5c-4cc9-489b-859f-62cd42de8d32"), "کوزه کنان", 22 },
                    { 844, new Guid("e7a8a2ad-a572-48c0-b2ab-101c4454bb92"), "کليبر", 22 },
                    { 843, new Guid("ef714ef0-2074-45a5-893f-ae3bad6d3f49"), "کلوانق", 22 },
                    { 842, new Guid("801d2bd9-08c5-43e8-905f-0f21b1324713"), "کشکسراي", 22 },
                    { 841, new Guid("f01a29e9-eae4-468e-8d6c-b5525e0322bb"), "يامچي", 22 },
                    { 840, new Guid("38dce676-85e0-4df0-93f3-964968e276ab"), "ورزقان", 22 },
                    { 839, new Guid("635028f7-41f5-44f3-af8b-e2adbdf6d8af"), "وايقان", 22 },
                    { 828, new Guid("119350e6-aedc-478a-8955-1091cf3b4bfa"), "مراغه", 22 },
                    { 838, new Guid("e5279268-cca8-4304-8c29-e083c079f50d"), "هوراند", 22 },
                    { 836, new Guid("3d5126dd-e90d-41bc-94d1-8f09a6179e05"), "هريس", 22 },
                    { 835, new Guid("655391a1-a750-400c-b886-bd01066ed417"), "هاديشهر", 22 },
                    { 834, new Guid("05cb1f32-dbd7-4070-acfb-9609a0aa2e48"), "نظرکهريزي", 22 },
                    { 833, new Guid("b6453c6b-01e0-48e3-bf48-58be8d228d00"), "ميانه", 22 },
                    { 832, new Guid("83af69af-5082-470b-b607-bf9a23256af6"), "مهربان", 22 },
                    { 810, new Guid("9a50cff8-f99c-48ca-998b-2c9390a07c61"), "خواجه", 22 },
                    { 830, new Guid("3e2155ae-a474-4e8e-adcc-e187e2ac7b9a"), "ملکان", 22 },
                    { 837, new Guid("5598788d-b61b-4180-9cad-6830187fb347"), "هشترود", 22 },
                    { 809, new Guid("fe713a97-ac24-4710-808b-766b9074be17"), "خمارلو", 22 },
                    { 805, new Guid("584b3814-614e-44b4-9ab6-07c8c3c11546"), "خاروانا", 22 },
                    { 807, new Guid("72308e4b-9b8f-4197-ae3c-334837ce153f"), "خداجو", 22 },
                    { 786, new Guid("40d50523-3d3b-4e20-9f84-66f6a5a89aed"), "آذرشهر", 22 },
                    { 785, new Guid("60ca6519-f526-4b0e-8eeb-77a446b655a7"), "آبش احمد", 22 },
                    { 784, new Guid("af7b0beb-f777-473d-a501-0f6b20a8022c"), "گلستان", 21 },
                    { 783, new Guid("3a0dc402-3af1-44df-9998-ae4756c3199a"), "کيلان", 21 },
                    { 782, new Guid("f38e0423-8d4e-47b6-a596-7b61e6f473fc"), "کهريزک", 21 },
                    { 781, new Guid("5f4f9545-f3ee-4e05-b528-a2b9ad62127a"), "چهاردانگه", 21 },
                    { 780, new Guid("14bf3484-a9b9-4436-8197-22a21ea4302d"), "پيشوا", 21 },
                    { 787, new Guid("f76cf3ce-b35b-498b-bf26-81d9fbf57c1e"), "آقکند", 22 },
                    { 779, new Guid("a0d2f68f-51b7-4336-8473-9110a1a87606"), "پرديس", 21 },
                    { 777, new Guid("2eb9d199-78a2-4c8e-9884-4c3da9b8020f"), "ورامين", 21 },
                    { 776, new Guid("3d08a6c4-8574-4495-a8d7-729c96e21ed4"), "وحيديه", 21 },
                    { 775, new Guid("28fd5b0e-f140-4ad5-a4a2-7f830e182e0d"), "نصيرشهر", 21 },
                    { 774, new Guid("b61d7a38-22fd-4192-baef-0cd10464ebff"), "نسيم شهر", 21 },
                    { 773, new Guid("a6556a27-f7b0-4635-978c-2d605dbe2e3c"), "ملارد", 21 },
                    { 772, new Guid("c9e2fd7a-60a2-4a99-ba7c-f4dec0cd456d"), "لواسان", 21 },
                    { 771, new Guid("a2ae04c8-5ad6-46a0-a9ae-452bfcc84517"), "قرچک", 21 },
                    { 778, new Guid("35380170-5ced-4b59-bc3f-b720b5803af7"), "پاکدشت", 21 },
                    { 808, new Guid("4e61ed8f-8c42-43ec-814d-f65120e0488a"), "خسروشاه", 22 },
                    { 788, new Guid("adacf4e9-113e-42e1-a6a0-8b5f0a391540"), "آچاچي", 22 },
                    { 790, new Guid("4acae357-eff2-47bb-9e5b-c2f3d2f7c6f4"), "اهر", 22 },
                    { 806, new Guid("23785780-0e0c-4e06-969a-501ef44bc828"), "خامنه", 22 },
                    { 846, new Guid("4da618fd-cf2b-498f-82b2-e4a3d78d954e"), "گوگان", 22 },
                    { 804, new Guid("7669a4c5-c327-44d4-93e3-05057348e7e1"), "جوان قلعه", 22 },
                    { 803, new Guid("de0786b4-c434-4a40-a143-2d7613d46eb8"), "جلفا", 22 },
                    { 802, new Guid("d395c973-c200-47a9-aadd-e60b5995baf0"), "تيکمه داش", 22 },
                    { 801, new Guid("21027d7f-99e8-496b-8d59-ca339d76e5c6"), "تيمورلو", 22 },
                    { 800, new Guid("f91a8b3f-a24b-48c8-be27-d0cddd791f07"), "تسوج", 22 },
                    { 789, new Guid("8b712b61-37e9-4ddf-be71-48d8b1cdceea"), "اسکو", 22 },
                    { 799, new Guid("8b19f8ab-0831-4075-90c0-a733b6854ad8"), "ترکمانچاي", 22 },
                    { 797, new Guid("ee1a8e29-b777-4340-82ba-86795f997817"), "تبريز", 22 },
                    { 796, new Guid("c6133322-58ce-46e3-ae88-5fdda9e33311"), "بناب مرند", 22 },
                    { 795, new Guid("cde01a93-0fd7-4048-aa85-a87d19ad1e45"), "بناب", 22 },
                    { 794, new Guid("ad693e9c-5f76-4a3f-a1f2-0bc56c930838"), "بستان آباد", 22 },
                    { 793, new Guid("e00ac588-a6ae-43f8-85b4-087793e0bfad"), "بخشايش", 22 },
                    { 792, new Guid("3f29f250-6f34-42b9-9d2e-0f42c9fadc89"), "باسمنج", 22 },
                    { 791, new Guid("6be7f0f3-8839-4589-b777-561784ba2bb1"), "ايلخچي", 22 },
                    { 798, new Guid("97cf9746-29c9-4158-97d9-98a4cc187e02"), "ترک", 22 },
                    { 847, new Guid("1d05fa7b-dbcd-4c2b-b840-2331743849d2"), "آباده", 23 },
                    { 851, new Guid("30e58e0b-64f1-4df1-9e9d-e14537c16342"), "استهبان", 23 },
                    { 849, new Guid("9184b57e-d2e7-4672-9595-5d2bbf2bae84"), "اردکان", 23 },
                    { 904, new Guid("0899b15f-7952-4741-9f69-b06ee85eb8d4"), "شيراز", 23 },
                    { 903, new Guid("c8c10a49-6fdf-4324-9ec2-648a21e7fd3e"), "شهر پير", 23 },
                    { 902, new Guid("6298c97f-49fb-4a31-8366-9877789500de"), "شهر جديد صدرا", 23 },
                    { 901, new Guid("efca5343-d156-4a09-95ae-f28ea0a80497"), "ششده", 23 },
                    { 900, new Guid("bacd06ca-d3dd-49ac-8fb5-8f59e26b797a"), "سيدان", 23 },
                    { 899, new Guid("27d091b4-98d6-40fe-b3d2-f6cfeadf66d6"), "سورمق", 23 },
                    { 898, new Guid("740b66be-ea4c-4df9-a8ca-3fa76593126b"), "سلطان شهر", 23 },
                    { 897, new Guid("528ce4c8-ff90-4ee0-90f6-4877a506430a"), "سعادت شهر", 23 },
                    { 896, new Guid("7342dbb9-5a58-4cd9-80a0-5a82e0b0467f"), "سروستان", 23 },
                    { 895, new Guid("94281ba6-3abc-4f26-89e4-0a29761527c3"), "سده", 23 },
                    { 894, new Guid("b4585524-2ade-4c65-97e4-acbafc78ba6c"), "زرقان", 23 },
                    { 893, new Guid("27041a21-be3e-4a1d-9810-a81e1f8517b5"), "زاهد شهر", 23 },
                    { 892, new Guid("5dec7bed-0e1a-4e2f-919f-3a1472476151"), "رونيز", 23 },
                    { 891, new Guid("c8f11d9f-8a06-4513-9da0-e13a99dcda54"), "رامجرد", 23 },
                    { 890, new Guid("478d167d-d87b-4c8f-bdd7-88947e3c5941"), "دژکرد", 23 },
                    { 905, new Guid("53f1a7a4-9662-49bf-bc33-50f4177bfaf5"), "صغاد", 23 },
                    { 906, new Guid("c8a18cde-9f57-4b16-9c04-f2ce8e193b84"), "صفا شهر", 23 },
                    { 907, new Guid("858e0902-84bd-40f6-ae24-5120fd8c4e36"), "علامرودشت", 23 },
                    { 908, new Guid("74371df0-06e7-4019-8cc1-a022d80c8ed9"), "عماد ده", 23 },
                    { 924, new Guid("ddba77e9-e70f-495c-93fb-a78df1d0f018"), "مبارک آباد", 23 },
                    { 923, new Guid("aea771ba-fb2a-4b5c-a151-780ba8476d65"), "مادرسليمان", 23 },
                    { 922, new Guid("53e43bd1-b47b-42f5-ba77-ef1b6c6fe21a"), "لپوئي", 23 },
                    { 921, new Guid("4f92417f-05cd-4ca3-8c46-1d03e1f85487"), "لطيفي", 23 },
                    { 920, new Guid("29464c81-84d7-4bbf-ba8b-274d0f483759"), "لامرد", 23 },
                    { 919, new Guid("b58068c5-62c5-4af6-8540-6ae4925bdeba"), "لار", 23 },
                    { 918, new Guid("4bed77d8-2a13-47e0-b72a-e76c2decba88"), "قير", 23 },
                    { 889, new Guid("66b87290-3b82-4f4d-bc88-dbb102a3296c"), "دوزه", 23 },
                    { 917, new Guid("db1beafb-d884-4d54-915e-ed1b2632b7ab"), "قطرويه", 23 },
                    { 915, new Guid("99b0de7c-3659-4688-908a-c71f5ec1d38d"), "قره بلاغ", 23 },
                    { 914, new Guid("d8cc7deb-7847-4d12-9ca1-f75fc0423dce"), "قادرآباد", 23 },
                    { 913, new Guid("d5300c11-c687-4406-8dc8-25ddf8003ce1"), "قائميه", 23 },
                    { 912, new Guid("74a5e988-ce9d-49eb-b94a-7864367aff06"), "فيروزآباد", 23 },
                    { 911, new Guid("e9634dea-b862-464d-be53-afca254bf39d"), "فسا", 23 },
                    { 910, new Guid("5cead9b1-94a3-466a-a425-a80f965a80b4"), "فراشبند", 23 },
                    { 909, new Guid("03dd7e34-5976-4fc0-ab1b-80a72f59835a"), "فدامي", 23 },
                    { 916, new Guid("364e4323-8b8f-4f6f-ab28-d6705dbeddd1"), "قطب آباد", 23 },
                    { 888, new Guid("1cbe0b33-d934-4909-bc5c-36cc12f5f177"), "دوبرجي", 23 },
                    { 887, new Guid("d75054df-8e67-4b49-84a3-eef2bfadde3d"), "دهرم", 23 },
                    { 886, new Guid("b11d56cc-3f51-4a45-b2c4-5ddcaa08a97a"), "دبيران", 23 },
                    { 865, new Guid("f9d9fb89-16a0-4875-8e57-1efec86f5419"), "بهمن", 23 },
                    { 864, new Guid("c62e1042-1369-493a-b8d8-c1b5e0501076"), "بنارويه", 23 },
                    { 863, new Guid("eacdb802-5619-4bd5-8705-308833b7db7b"), "بالاده", 23 },
                    { 862, new Guid("f3f5f303-6b75-49ec-a1b1-f3976a714f2a"), "بابامنير", 23 },
                    { 861, new Guid("d51c7e6b-bdd2-442f-82d2-d0b08ba6d3a8"), "باب انار", 23 },
                    { 860, new Guid("56f15ccb-6672-4e68-a733-05bb5f68a573"), "ايزد خواست", 23 },
                    { 859, new Guid("0a8d4c03-b37a-44b2-8d28-ce731753477b"), "ايج", 23 },
                    { 866, new Guid("42647447-b797-4dcd-9d75-30c5dc9ac735"), "بوانات", 23 },
                    { 858, new Guid("a1bca5a4-5d89-4ca8-9133-c920c60c51e6"), "اوز", 23 },
                    { 856, new Guid("6a5efc9e-3e3f-46ed-9eda-177cd0328ce6"), "امام شهر", 23 },
                    { 855, new Guid("56d7501b-2f85-4231-beeb-5cd821ba5fed"), "اقليد", 23 },
                    { 854, new Guid("0c4c533e-96e6-47d2-b906-68dbf0a6a014"), "افزر", 23 },
                    { 853, new Guid("c6609f97-eace-45d9-9ffc-925eba4fa2ca"), "اشکنان", 23 },
                    { 852, new Guid("4b38fe50-e49b-40ef-a551-9ae51212468a"), "اسير", 23 },
                    { 770, new Guid("0cc91bd1-9d88-4613-b3ad-b78563d3396d"), "قدس", 21 },
                    { 850, new Guid("50061d43-e504-451c-b3bd-90074f997f8c"), "ارسنجان", 23 },
                    { 857, new Guid("ae2b3ca4-700b-43b0-92ff-36efada185c6"), "اهل", 23 },
                    { 848, new Guid("0584569b-29f5-4b78-8375-6b552b490cf2"), "آباده طشک", 23 },
                    { 867, new Guid("5ca6fc20-b65c-48be-9e57-033cc9444875"), "بيرم", 23 },
                    { 869, new Guid("5dadf4b3-555d-4c01-bc8a-f0b18598ec2b"), "جنت شهر", 23 },
                    { 885, new Guid("549a5e47-dd7f-4043-83e0-893d2f12af07"), "داريان", 23 },
                    { 884, new Guid("b5f7639e-6a06-4655-98ca-8456a5dc9c38"), "داراب", 23 },
                    { 883, new Guid("d984d940-349c-45ff-9567-591ac45eb7a0"), "خومه زار", 23 },
                    { 882, new Guid("4e78f892-6121-4ac2-a4c3-4d313f0037a5"), "خوزي", 23 },
                    { 881, new Guid("53b9b108-836a-4a79-8fdd-68d1f13fda2d"), "خور", 23 },
                    { 880, new Guid("fdefdca4-13c1-44fe-8d96-70cc4e214724"), "خنج", 23 },
                    { 879, new Guid("ddc817a8-7841-4312-a4f7-6a0c64a6092d"), "خشت", 23 },
                    { 868, new Guid("077a8b2f-3f7b-4ec2-95e3-9bce75834563"), "بيضا", 23 },
                    { 878, new Guid("db9aaed4-0d1c-40dd-bcab-e765eb63dfc1"), "خرامه", 23 },
                    { 876, new Guid("cd1e7e86-f046-4f38-9bdb-baac0aadc662"), "خانيمن", 23 },
                    { 875, new Guid("52f37e39-1f03-4329-8fb7-b7ac682977ca"), "خانه زنيان", 23 },
                    { 874, new Guid("06b4ca57-c210-4ed1-9320-99fe22368817"), "حسن آباد", 23 },
                    { 873, new Guid("aaac7034-2e1e-462b-97ab-da339cb360e1"), "حسامي", 23 },
                    { 872, new Guid("a9e9109c-1b40-4733-8b0b-c158c1b97dcb"), "حاجي آباد", 23 },
                    { 871, new Guid("6eab83c8-ea58-4817-b021-c4c68510697b"), "جويم", 23 },
                    { 870, new Guid("6efc2f0e-dc09-4e9f-a089-509539b63743"), "جهرم", 23 },
                    { 877, new Guid("97bc6803-95e1-48f2-8953-15bd322d8f55"), "خاوران", 23 },
                    { 769, new Guid("65453327-6ca5-4afc-bd4b-d6b0800884f2"), "فيروزکوه", 21 },
                    { 765, new Guid("00b59a4b-65b5-41d8-8e1d-5a3488f83f0f"), "صفادشت", 21 },
                    { 767, new Guid("97f142f6-1ff7-459d-a28a-13c82ddb4fe8"), "فرون آباد", 21 },
                    { 667, new Guid("61a667e5-4ae8-43ab-8bfd-46581e092620"), "طالخونچه", 19 },
                    { 666, new Guid("2f365cfb-20be-4ed9-ba44-d312489c1b25"), "شهرضا", 19 },
                    { 665, new Guid("9cca6441-e33d-4572-b194-1854dd2e1fb9"), "شاپورآباد", 19 },
                    { 664, new Guid("1e34ef9c-5cd8-4156-bad5-dfbd6735e3f1"), "شاهين شهر", 19 },
                    { 663, new Guid("bb5f203a-b74e-44fd-87a1-37b89154a76b"), "سگزي", 19 },
                    { 662, new Guid("a5e7b86d-3b25-4d81-ab92-21ffcc66c9e2"), "سين", 19 },
                    { 661, new Guid("93287601-53af-4e07-b6d9-8a0ed9352162"), "سميرم", 19 },
                    { 660, new Guid("ea94d433-c5c2-4c54-8466-9988753065d0"), "سفيد شهر", 19 },
                    { 659, new Guid("61d2b650-799b-47a2-8a6e-4964de3c77a5"), "سده لنجان", 19 },
                    { 658, new Guid("3219379d-510a-4842-a432-6b2e816d2fbe"), "زيباشهر", 19 },
                    { 657, new Guid("dbd79b80-677d-41ef-a6ff-271ff8cfec48"), "زيار", 19 },
                    { 656, new Guid("d4753259-d192-4ce2-94fc-e6bb676b5e58"), "زواره", 19 },
                    { 655, new Guid("3eb4f8bd-8886-434a-94e2-c9e64aed38a2"), "زرين شهر", 19 },
                    { 654, new Guid("4a42f890-e160-47b7-903c-1d222d8bd150"), "زاينده رود", 19 },
                    { 653, new Guid("52be0a31-1076-4953-9772-25b3c14d399c"), "زازران", 19 },
                    { 668, new Guid("5ad99ae7-edb2-4bc6-87a8-195ef4b8d077"), "طرق رود", 19 },
                    { 669, new Guid("bd9c3296-1ac6-4bfc-ac09-1c10f45b5165"), "عسگران", 19 },
                    { 670, new Guid("41ff9801-0b71-40f1-89d1-90cbe7990cb2"), "علويچه", 19 },
                    { 671, new Guid("dd4f6fd2-b976-4e2a-af01-a6425f4c643f"), "فرخي", 19 },
                    { 687, new Guid("6773c760-af60-4b40-aba8-d6626a217037"), "نصرآباد", 19 },
                    { 686, new Guid("eeb846b5-3be9-4c67-a0d6-459d7e2524ba"), "نجف آباد", 19 },
                    { 685, new Guid("38ffcbf7-cc8c-45e5-aee8-e906070595ef"), "نائين", 19 },
                    { 684, new Guid("af5b8e5f-2c52-4ad5-894b-94efc1beddff"), "ميمه", 19 },
                    { 683, new Guid("feb28448-4778-4de2-84ed-4156359f161a"), "مهاباد", 19 },
                    { 682, new Guid("ecf43a39-18cb-40ec-b1ae-314fca09cf22"), "منظريه", 19 },
                    { 681, new Guid("f33e8cd8-de86-4cc8-a38f-8271373d1e28"), "مشکات", 19 },
                    { 652, new Guid("90a6842a-c1ba-4850-847f-107e091027f4"), "رضوانشهر", 19 },
                    { 680, new Guid("0e5fe6c3-4a6d-41e9-b480-33aea95c3b89"), "محمد آباد", 19 },
                    { 678, new Guid("29139e1e-b6c0-4432-8995-1b4cf6a796bb"), "لاي بيد", 19 },
                    { 677, new Guid("9931d2cc-adbe-4a1e-8d4b-3146f90a8373"), "قهدريجان", 19 },
                    { 676, new Guid("6755e16c-dcdd-4a9f-b221-bd6bd54199c6"), "قهجاورستان", 19 },
                    { 675, new Guid("a103fcfb-4725-49b2-9430-fc06dbd8b4a1"), "قمصر", 19 },
                    { 674, new Guid("1f312813-463a-43d7-8159-2480db919919"), "فولاد شهر", 19 },
                    { 673, new Guid("e5c2eb01-33cb-4add-9ea6-b477a5ef2bba"), "فلاورجان", 19 },
                    { 672, new Guid("5ec4a994-46e3-4928-90b3-6bb005d7062a"), "فريدونشهر", 19 },
                    { 679, new Guid("a8c0d4c8-a58b-4fa7-87d1-f6845c92d9f3"), "مبارکه", 19 },
                    { 651, new Guid("767fcdee-91c0-4665-9d6a-782a41705c53"), "رزوه", 19 },
                    { 650, new Guid("2e89b245-4702-4ac4-a0a8-0165922f9a45"), "ديزيچه", 19 },
                    { 649, new Guid("0500a05c-f4dd-404b-a7b1-ac1b5b489dd2"), "دولت آباد", 19 },
                    { 628, new Guid("d040a138-3eaf-46b2-8bfe-22c3a91514d6"), "بهارستان", 19 },
                    { 627, new Guid("48d6da8d-42f2-4d4e-9772-efc5fab0244c"), "بهاران شهر", 19 },
                    { 626, new Guid("62022ffc-f370-4971-8510-bbb35cb7a604"), "برف انبار", 19 },
                    { 625, new Guid("5bc3dcda-e46d-45ae-8241-a3b081c4d535"), "برزک", 19 },
                    { 624, new Guid("e6252d08-399e-4c21-ab4d-6f26d0a240bc"), "بافران", 19 },
                    { 623, new Guid("4f3fea63-e0cd-4056-9722-d1100edc71ed"), "باغشاد", 19 },
                    { 622, new Guid("0bdadf61-2161-493b-85cd-63b19e40af99"), "باغ بهادران", 19 },
                    { 629, new Guid("1447648d-97cb-4674-b457-d6a3e052ffc1"), "بوئين مياندشت", 19 },
                    { 621, new Guid("1e2ccbb4-aedc-45b9-8067-ff09c61771ac"), "بادرود", 19 },
                    { 619, new Guid("742893b4-1ad2-4f5b-bc38-702791686c60"), "ايمانشهر", 19 },
                    { 618, new Guid("997c36f2-83d3-4294-bd8d-b7e68d95a718"), "انارک", 19 },
                    { 617, new Guid("024b5490-9a49-4718-8f25-71955aa91b4b"), "افوس", 19 },
                    { 616, new Guid("c433fbe5-0164-4473-a919-3d987d640414"), "اصفهان", 19 },
                    { 615, new Guid("cd7f983b-fba9-44df-ba25-f5dd9800b97f"), "اصغرآباد", 19 },
                    { 614, new Guid("965f6095-0b13-446c-87c3-d764042f011b"), "اردستان", 19 },
                    { 613, new Guid("34f49e3b-8029-41e6-a252-625f21423864"), "ابوزيد آباد", 19 },
                    { 620, new Guid("734afe03-bdf3-45e1-a496-118bf2326c51"), "اژيه", 19 },
                    { 688, new Guid("ffaed2ab-6b39-41c7-8db0-9893ca7542d6"), "نطنز", 19 },
                    { 630, new Guid("210f2d71-9025-48ec-81e2-8dde169e455b"), "تودشک", 19 },
                    { 632, new Guid("af6b9b01-9269-4654-ac21-b5d37ae97b6e"), "جندق", 19 },
                    { 648, new Guid("5207f943-806c-4269-a2ab-1ce74d712189"), "دهق", 19 },
                    { 647, new Guid("19b9998e-47d5-4bf8-8b38-c9321f65a904"), "دهاقان", 19 },
                    { 646, new Guid("782d6a94-1d0d-45ef-a4de-0fdff71a1195"), "دستگرد", 19 },
                    { 645, new Guid("a7247380-93b5-4317-aed8-adfc8020ffa2"), "درچه پياز", 19 },
                    { 644, new Guid("4d8a1203-ed37-4b17-873b-dc3d5d974e61"), "دامنه", 19 },
                    { 643, new Guid("6a7ac63b-0e33-4bd0-9184-2d94b5c53262"), "داران", 19 },
                    { 642, new Guid("91440ab4-d8e4-49a8-a0cd-e036f42399ec"), "خورزوق", 19 },
                    { 631, new Guid("09e47d08-2791-423d-8ad5-176000ba216e"), "تيران", 19 },
                    { 641, new Guid("d0260d97-5ded-40c1-921d-61a0b5f62120"), "خور", 19 },
                    { 639, new Guid("d9fd5421-17bf-435e-8c32-914f379c1b76"), "خميني شهر", 19 },
                    { 638, new Guid("335571f4-572a-4dec-86de-fcdaa8f208ce"), "خالد آباد", 19 },
                    { 637, new Guid("7b918931-c52e-436f-93db-0ade4af7b8b2"), "حنا", 19 },
                    { 636, new Guid("96c357d4-0813-4483-ad6a-477fb4e92cd9"), "حسن آباد", 19 },
                    { 635, new Guid("241eef8d-2c35-4a3e-884c-4064ddaf39b7"), "حبيب آباد", 19 },
                    { 634, new Guid("4500c9e4-f15b-4d58-883e-05d72253b606"), "جوشقان قالي", 19 },
                    { 633, new Guid("3f01856f-3ba2-4293-bdd5-599b54437b43"), "جوزدان", 19 },
                    { 640, new Guid("db5bdfaa-5cd1-4aad-9201-8f3b4ef4d1b8"), "خوانسار", 19 },
                    { 768, new Guid("83b3822a-bf7d-4b3b-a9d5-e05e4816690f"), "فشم", 21 },
                    { 689, new Guid("abf5ec85-1a0c-4dd8-b834-9e4dbf8dc998"), "نوش آباد", 19 },
                    { 691, new Guid("cc033a34-0e52-406c-a532-5ef7afd1b8a5"), "نيک آباد", 19 },
                    { 746, new Guid("5da9d49c-3c93-412a-869a-3827babbf578"), "انديشه", 21 },
                    { 745, new Guid("dc172e77-641f-4f7f-9e0f-fb0a6554adf7"), "اسلامشهر", 21 },
                    { 744, new Guid("b8b25d87-cecd-4b9a-90be-2ca1cdbe8bfd"), "ارجمند", 21 },
                    { 743, new Guid("053379ef-2c43-438e-ac32-3d3285939880"), "آبعلي", 21 },
                    { 742, new Guid("4a4d58dc-e2a6-4c55-89e3-a46cfa551d25"), "آبسرد", 21 },
                    { 741, new Guid("a305ba99-13fb-449b-9d62-23c2a51197b4"), "چوار", 20 },
                    { 740, new Guid("b801a1f9-2a4e-42de-a5f5-d758dd51abad"), "پهله", 20 },
                    { 739, new Guid("498b6532-519a-4292-85e1-fe73937ec054"), "ميمه", 20 },
                    { 738, new Guid("29e1a551-fb6e-4928-81e0-32f962edaee8"), "موسيان", 20 },
                    { 737, new Guid("c86cd0b1-b199-4bbc-b206-a03328bc619b"), "مورموري", 20 },
                    { 736, new Guid("43a701f9-d8f8-4893-8d08-400b9d22fbbf"), "مهران", 20 },
                    { 735, new Guid("e86af3d7-bb59-4057-a1b5-4859a05ae542"), "مهر", 20 },
                    { 734, new Guid("e9252526-c2a2-4d66-ae3e-ca4b883e4554"), "ماژين", 20 },
                    { 733, new Guid("dbb730dc-ae4f-43d1-a039-3aed0592eaa9"), "لومار", 20 },
                    { 732, new Guid("2adca0db-7125-4e53-a0c6-1985c5868890"), "صالح آباد", 20 },
                    { 747, new Guid("4c819cae-87e5-4db4-a0d6-1f16decd4d08"), "باغستان", 21 },
                    { 748, new Guid("8b49edcd-c592-4a42-95e0-8d48cae2ce83"), "باقرشهر", 21 },
                    { 749, new Guid("c0f1243a-b7d4-439e-b853-33436a4b1941"), "بومهن", 21 },
                    { 750, new Guid("1fdb29ad-a070-40a0-996e-4043797d738c"), "تجريش", 21 },
                    { 766, new Guid("caa2889a-2a57-4b4f-b7fa-4833d7238a78"), "فردوسيه", 21 },
                    { 925, new Guid("54911ede-1276-4e86-a7fd-5dd9659dffdb"), "مرودشت", 23 },
                    { 764, new Guid("6bd42b9c-4652-4b42-bec4-701176e54861"), "صبا شهر", 21 },
                    { 763, new Guid("4308724e-5a1f-4dbf-bcb3-0bd7e966c050"), "صالحيه", 21 },
                    { 762, new Guid("ef0ab504-336d-427f-b88e-5eec370e2689"), "شهريار", 21 },
                    { 761, new Guid("d1738080-832a-4b46-9c19-1972caf17fe3"), "شهر جديد پرند", 21 },
                    { 760, new Guid("6d71e4fb-02c3-4278-8a21-fdd87b9787a1"), "شمشک", 21 },
                    { 731, new Guid("324901e4-893c-478d-84e4-3eff4887f29a"), "شباب", 20 },
                    { 759, new Guid("8f19ea1c-e929-4c8c-b72c-9f190c56aca1"), "شريف آباد", 21 },
                    { 757, new Guid("6fbbf55a-621f-4df6-b8cb-c7ded4b43a7e"), "ري", 21 },
                    { 756, new Guid("63062728-e9ad-490c-b881-f17dac84e116"), "رودهن", 21 },
                    { 755, new Guid("80dbc2c7-2d84-4f7e-89b0-0d13275b3ab9"), "رباط کريم", 21 },
                    { 754, new Guid("9ef10362-f5c9-414b-aeb8-bc7aced67f03"), "دماوند", 21 },
                    { 753, new Guid("12276e22-3211-4e95-816d-084e1950f29b"), "حسن آباد", 21 },
                    { 752, new Guid("c6b8002b-f8fa-4053-aa34-efe7d936d1af"), "جواد آباد", 21 },
                    { 751, new Guid("8b47e02f-3e42-4ab7-b19a-d880d94fcc9c"), "تهران", 21 },
                    { 758, new Guid("fb4049df-7dbd-40a5-b8ed-08cd953a3485"), "شاهدشهر", 21 },
                    { 730, new Guid("8c64e0a1-985d-4c2b-97af-7a91b97a566a"), "سرابله", 20 },
                    { 729, new Guid("3ab1437a-03ca-400d-80a8-276122ef6ad9"), "سراب باغ", 20 },
                    { 728, new Guid("bb25a776-7314-4a4e-975a-57b266ba8e54"), "زرنه", 20 },
                    { 707, new Guid("581d2284-d62b-497e-b698-18782f1f29eb"), "کهريزسنگ", 19 },
                    { 706, new Guid("74f264bf-0d14-44a2-8d9c-697193fa2547"), "کمه", 19 },
                    { 705, new Guid("d0ce5966-2bee-4401-8dd2-5b0a4baf256b"), "کمشجه", 19 },
                    { 704, new Guid("e8872255-334b-4bde-8424-e351e1acf655"), "کليشاد و سودرجان", 19 },
                    { 703, new Guid("b232dbfe-2d1c-40e4-ae07-9d0095d1c99d"), "کرکوند", 19 },
                    { 702, new Guid("beb3393b-dddd-4cfd-801e-124615fd29cc"), "کامو و چوگان", 19 },
                    { 701, new Guid("17aa4716-eabe-4014-8118-be4bab3ef0b9"), "کاشان", 19 },
                    { 708, new Guid("dc0e01e9-215b-4137-91fd-8624e4c02f8d"), "کوشک", 19 },
                    { 700, new Guid("1cee4f01-c78d-4901-975d-df649baabb89"), "چمگردان", 19 },
                    { 698, new Guid("f55f4156-4313-412e-a556-072623d1e8ff"), "چادگان", 19 },
                    { 697, new Guid("60f251f0-64b4-4c5e-be5a-c8fb57f1e293"), "پير بکران", 19 },
                    { 696, new Guid("cbcad023-64b0-48f6-8d3d-3a652c73619a"), "ونک", 19 },
                    { 695, new Guid("4c8af575-5bb1-497e-bdc3-8b1d5fac2b11"), "وزوان", 19 },
                    { 694, new Guid("4b7b81d6-5a11-480a-8fbf-988482ce35df"), "ورنامخواست", 19 },
                    { 693, new Guid("373607ce-640f-44a5-bef7-07df9a9e15c9"), "ورزنه", 19 },
                    { 692, new Guid("c8882918-5b7f-4e00-822a-83b6257d1a1d"), "هرند", 19 },
                    { 699, new Guid("001e790a-1f3d-48e6-a4b5-f2c2d705a5ed"), "چرمهين", 19 },
                    { 690, new Guid("de7ea082-4956-45a4-82e1-06884145e31c"), "نياسر", 19 },
                    { 709, new Guid("a5ea44e3-e80f-4c20-9b7a-15dc490d62bc"), "کوهپايه", 19 },
                    { 711, new Guid("8a0c21c1-d37c-489e-935d-de7a967a0166"), "گز برخوار", 19 },
                    { 727, new Guid("2b9991ba-2d31-4778-9a11-07a982453093"), "دهلران", 20 },
                    { 726, new Guid("6cf08333-4434-4aeb-b8ad-2041a4eb9367"), "دلگشا", 20 },
                    { 725, new Guid("32df7e12-71fb-4143-9dfd-ca08338052c5"), "دره شهر", 20 },
                    { 724, new Guid("dc8927ba-5d59-414b-89a2-11ed4e77464f"), "توحيد", 20 },
                    { 723, new Guid("c51b34cc-746f-4765-8533-270d88dfba8e"), "بلاوه", 20 },
                    { 722, new Guid("c0e9c639-dca8-412a-9a5d-9bb3e08e055c"), "بدره", 20 },
                    { 721, new Guid("1f976cc4-f4a9-4bb3-9181-97d7a60fa99c"), "ايوان", 20 },
                    { 710, new Guid("5e95593e-138c-4408-9301-d05bd77b05d5"), "گرگاب", 19 },
                    { 720, new Guid("50206bcc-84b0-4e63-84d0-cd44496fd4e8"), "ايلام", 20 },
                    { 718, new Guid("2d4a3bd2-b41e-43ff-8521-92e15dfabd8a"), "آسمان آباد", 20 },
                    { 717, new Guid("5685b8d5-bf91-4dc0-8d3d-ed2ef329eab9"), "آبدانان", 20 },
                    { 716, new Guid("0802be1a-3cee-4d52-b72c-f65286d3c35f"), "گوگد", 19 },
                    { 715, new Guid("a39b01dc-3c21-4f90-b266-63256d4abae5"), "گلپايگان", 19 },
                    { 714, new Guid("c0ce8317-5d55-4bf1-9d77-f11d95d988f6"), "گلشهر", 19 },
                    { 713, new Guid("a807d438-8056-45cb-bf6e-ec1eccda5b2e"), "گلشن", 19 },
                    { 712, new Guid("edb9bdf1-b0dd-4a07-b081-68f412abbe78"), "گلدشت", 19 },
                    { 719, new Guid("ab93f9a3-974f-4fbc-898e-36441a318811"), "ارکواز", 20 },
                    { 926, new Guid("f4d29b55-782a-47b9-91d8-f7ad11771655"), "مزايجان", 23 },
                    { 930, new Guid("dc8051b4-ee55-429f-ab7d-bab86ebc073d"), "ميانشهر", 23 },
                    { 928, new Guid("87325303-376f-45ea-94b2-f4b74d2546aa"), "مصيري", 23 },
                    { 1141, new Guid("d4aad52a-4fac-4238-8923-76401e5e493d"), "بردسير", 29 },
                    { 1140, new Guid("0394ac25-cc51-478e-891d-08af99e9c58d"), "بافت", 29 },
                    { 1139, new Guid("df806a81-c914-4344-a333-b97982ed95e5"), "باغين", 29 },
                    { 1138, new Guid("33dd964d-dbbd-460a-b270-f69a5aa97bea"), "اندوهجرد", 29 },
                    { 1137, new Guid("f7ae64eb-bc66-4518-a872-795f66ba95aa"), "انار", 29 },
                    { 1136, new Guid("d1bf6b1f-fd61-410b-99f4-745783058dae"), "امين شهر", 29 },
                    { 1135, new Guid("1577a860-3896-4cdc-bc0a-59bad83b15b7"), "ارزوئيه", 29 },
                    { 1134, new Guid("a4f1509c-1d7c-4abd-a3f1-fd4bb546d0ee"), "اختيار آباد", 29 },
                    { 1133, new Guid("64511135-ae2f-46a4-8383-2eb209ce6d45"), "گيان", 28 },
                    { 1132, new Guid("1db273e5-f8e0-4d99-a321-1cb2c884be11"), "گل تپه", 28 },
                    { 1131, new Guid("a21a611e-8169-4078-92ce-e1b57cab1872"), "کبودر آهنگ", 28 },
                    { 1130, new Guid("f022d06d-fa95-4645-a631-c22752f3a957"), "همدان", 28 },
                    { 1129, new Guid("8790c372-1ae5-423b-90bd-fe2490ad5902"), "نهاوند", 28 },
                    { 1128, new Guid("349f204b-2a9f-4631-b511-734e52ec77ba"), "مهاجران", 28 },
                    { 1127, new Guid("ca7182a4-9034-4cc3-a113-7e0a6126af4d"), "ملاير", 28 },
                    { 1142, new Guid("00d25ffa-4871-4b7b-8361-b9c229f2a850"), "بروات", 29 },
                    { 1143, new Guid("b0160cee-a256-4433-8a33-cc8541be30a0"), "بزنجان", 29 },
                    { 1144, new Guid("9560e7a2-9c7e-4ab3-ba6f-8a509caf46c7"), "بلورد", 29 },
                    { 1145, new Guid("b2866fd9-336e-4dee-bf7c-287b322c993c"), "بلوک", 29 },
                    { 1161, new Guid("cf804410-f5ff-450b-9c0f-ea1c5f1db6b2"), "راور", 29 },
                    { 1160, new Guid("a9a911d0-7e9b-4b1b-8bd6-23f1b50ceb13"), "رابر", 29 },
                    { 1159, new Guid("1a7785d0-f103-4bc3-88e2-7e7a56561183"), "دوساري", 29 },
                    { 1158, new Guid("ea8fab59-70d6-472b-959f-f0e69e33d98d"), "دهج", 29 },
                    { 1157, new Guid("65976242-d73b-49d3-8baa-883c6839f0a1"), "دشتکار", 29 },
                    { 1156, new Guid("dbb6d6fd-a500-457b-bf2e-535ad3d868ef"), "درب بهشت", 29 },
                    { 1155, new Guid("2f58e1d9-3087-4b5c-aef3-27664f5c2737"), "خورسند", 29 },
                    { 1126, new Guid("6191c0c0-c033-4431-925d-2d499f2b7d83"), "مريانج", 28 },
                    { 1154, new Guid("07e4f85c-7575-4658-b1e1-154533ac2dd2"), "خواجوشهر", 29 },
                    { 1152, new Guid("0bc3e8a9-dde8-4246-859a-ccf2fd08d0b7"), "خاتون آباد", 29 },
                    { 1151, new Guid("df7f6d5e-cac8-4d87-bc04-01d61f820efa"), "جيرفت", 29 },
                    { 1150, new Guid("285b1a05-1b0d-49fd-b317-6bf386688d65"), "جوپار", 29 },
                    { 1149, new Guid("00be4073-bba3-44ac-a38c-75fccbee6b9b"), "جوزم", 29 },
                    { 1148, new Guid("08910234-477e-4fb5-bbc4-8a809c725b9b"), "جبالبارز", 29 },
                    { 1147, new Guid("3c54eb37-898c-4057-b645-74a7965f51ba"), "بهرمان", 29 },
                    { 1146, new Guid("035a831f-d791-4503-8d95-f407d12f7799"), "بم", 29 },
                    { 1153, new Guid("26471805-f899-40c0-839e-a766f8b3395e"), "خانوک", 29 },
                    { 1125, new Guid("0d4db7d2-9e9a-4988-bc82-f643d90a59cc"), "لالجين", 28 },
                    { 1124, new Guid("18450d12-4c84-423e-bba2-397b4fa00a29"), "قهاوند", 28 },
                    { 1123, new Guid("ae914427-213b-4714-b7e0-e5a6a51ba728"), "قروه در جزين", 28 },
                    { 1102, new Guid("a569c283-bd4c-4ec9-90a2-6c6f62eee52b"), "کوچصفهان", 27 },
                    { 1101, new Guid("aad1c090-a951-49c7-b11b-b9b7c0eaf2c2"), "کومله", 27 },
                    { 1100, new Guid("4d5e9b20-91c8-4c7b-afa2-3cf9d6d51fe9"), "کلاچاي", 27 },
                    { 1099, new Guid("68700e15-8054-403c-97bd-7227b694e83e"), "چوبر", 27 },
                    { 1098, new Guid("6ba144bd-c6ef-4b2e-92e9-1da3f9fe8d72"), "چاف و چمخاله", 27 },
                    { 1097, new Guid("5888861c-f547-4744-a8e1-641153ded1a3"), "چابکسر", 27 },
                    { 1096, new Guid("02ec1a60-81b1-428a-a531-92d98d6acb5e"), "پره سر", 27 },
                    { 1103, new Guid("2782b130-72cb-4788-8f77-d91a5e12b196"), "کياشهر", 27 },
                    { 1095, new Guid("23371951-3e0c-44ec-81d1-4f7fa36e99c0"), "واجارگاه", 27 },
                    { 1093, new Guid("298e6af7-39af-46cf-bf0a-dcfd9c768ce9"), "منجيل", 27 },
                    { 1092, new Guid("33bdb192-b0f6-4b11-99e4-5b6c2b6f02ff"), "مرجقل", 27 },
                    { 1091, new Guid("c24635e1-2bb6-4f90-b74b-c6b333cf6e6d"), "ماکلوان", 27 },
                    { 1090, new Guid("806813a3-579c-48f6-b1ba-7dfd1e5f7710"), "ماسوله", 27 },
                    { 1089, new Guid("6634b89d-8a52-400f-bab1-ea9f4ded9ab1"), "ماسال", 27 },
                    { 1088, new Guid("d273f363-523b-4852-bd8d-6ccdc183c38c"), "ليسار", 27 },
                    { 1087, new Guid("8602c1ed-5dc2-4b9a-b548-35f410784771"), "لوندويل", 27 },
                    { 1094, new Guid("a3f0ea18-7148-4d5c-8c99-4610471588c9"), "هشتپر", 27 },
                    { 1162, new Guid("fd4e72db-7738-4866-8e66-5c8b750afdd3"), "راين", 29 },
                    { 1104, new Guid("9e3f655e-08ce-4b7e-b49a-b59dde44d5b4"), "گوراب زرميخ", 27 },
                    { 1106, new Guid("ebef5b70-8150-44f4-8a28-034cb918a99a"), "ازندريان", 28 },
                    { 1122, new Guid("14524524-f4f8-4938-a21c-1119c935017d"), "فيروزان", 28 },
                    { 1121, new Guid("68b0c678-6bfb-4bc4-99c6-b0624d3af3e8"), "فرسفج", 28 },
                    { 1120, new Guid("491c0cbc-27ea-4a7d-8a8d-029a7a810b09"), "فامنين", 28 },
                    { 1119, new Guid("eaf44903-3cdf-4560-9a0d-2aefc8aa91bc"), "صالح آباد", 28 },
                    { 1118, new Guid("ca6f2a4e-65d4-4d81-a63e-2a7c8b19b37a"), "شيرين سو", 28 },
                    { 1117, new Guid("2fe1606a-a7f0-4f76-8e95-505fc2c2a772"), "سرکان", 28 },
                    { 1116, new Guid("0a241ec7-b5af-4ea2-aa9b-c7798aac4013"), "سامن", 28 },
                    { 1105, new Guid("563389c7-db1e-4346-8c19-bcb9b9f54d69"), "آجين", 28 },
                    { 1115, new Guid("014f90b8-edbe-4af1-b8a3-b2c46e391aa9"), "زنگنه", 28 },
                    { 1113, new Guid("ddc556ac-6d63-484c-98d1-8cd9f082d87a"), "دمق", 28 },
                    { 1112, new Guid("9bba38ab-7003-433c-bfa8-d87ccc1b3d4b"), "جوکار", 28 },
                    { 1111, new Guid("03d1f5db-4cbb-49a3-9c84-104462afdbd8"), "جورقان", 28 },
                    { 1110, new Guid("5cc3f7c6-e617-4580-a9fb-3a433c133cbd"), "تويسرکان", 28 },
                    { 1109, new Guid("59c2f759-d153-43f6-be5e-c62fe57f1478"), "بهار", 28 },
                    { 1108, new Guid("53deed69-98c1-4ca5-9a39-7e4d2821ac77"), "برزول", 28 },
                    { 1107, new Guid("5e7c0900-f678-4689-99e7-4f03255f4198"), "اسد آباد", 28 },
                    { 1114, new Guid("577efd6c-749d-408d-b644-3e3d8d50d3c9"), "رزن", 28 },
                    { 1086, new Guid("a49641d0-ada2-4cf6-919d-793b5c662c74"), "لولمان", 27 },
                    { 1163, new Guid("796889b4-1e97-4fe7-89cc-b6340a458343"), "رفسنجان", 29 },
                    { 1165, new Guid("b5ad1524-2ccd-4215-a016-bf9f9dde999b"), "ريحان", 29 },
                    { 1220, new Guid("068d0cfc-88bd-45b2-ad78-893931c9e977"), "ميامي", 30 },
                    { 1219, new Guid("3a333e1f-0fcc-4264-a00c-3ffc8e534f56"), "مهدي شهر", 30 },
                    { 1218, new Guid("a30bd28b-8c46-4acc-9792-c40ef31da048"), "مجن", 30 },
                    { 1217, new Guid("ad64798f-277b-4ad7-b3d8-9c0c041774ea"), "شهميرزاد", 30 },
                    { 1216, new Guid("490254d1-b2a8-42b2-99dd-fa6aa4b97edc"), "شاهرود", 30 },
                    { 1215, new Guid("da39696a-fbda-4cc1-85c5-0784034fc654"), "سمنان", 30 },
                    { 1214, new Guid("fe53300d-b178-426d-be3a-77786b39d745"), "سرخه", 30 },
                    { 1213, new Guid("a971b317-4f6d-4033-99de-7ce8f02c0f83"), "روديان", 30 },
                    { 1212, new Guid("0f81f6a5-897c-4161-8091-f5149a0ccb84"), "ديباج", 30 },
                    { 1211, new Guid("f7f14cf6-7e52-4ae4-9d5c-e3a00191b9bb"), "درجزين", 30 },
                    { 1210, new Guid("8bb137fe-bd9e-434f-9aa7-736325a6d11f"), "دامغان", 30 },
                    { 1209, new Guid("0630eae7-66e2-4401-8fec-382e6a645e60"), "بيارجمند", 30 },
                    { 1208, new Guid("b3450081-0907-40e7-88f7-cf62dc480c4d"), "بسطام", 30 },
                    { 1207, new Guid("e3133524-6bf6-498a-9aa9-b0ef314bbc87"), "ايوانکي", 30 },
                    { 1206, new Guid("9980c2c6-600d-419c-89b6-71f7fc4c0bf0"), "اميريه", 30 },
                    { 1221, new Guid("574f8932-0e0d-4bad-badd-80cc37c945bc"), "کلاته", 30 },
                    { 1222, new Guid("2f48eb9b-d8b7-4794-9d46-8ac7bffc04c3"), "کلاته خيج", 30 },
                    { 1223, new Guid("5205b6fc-5267-4aa2-9f35-278d22f40649"), "کهن آباد", 30 },
                    { 1224, new Guid("b118237b-f651-4744-81e7-65fd2033cfbc"), "گرمسار", 30 },
                    { 1240, new Guid("8e089384-257c-46a0-a578-3da739b0cbd9"), "چيتاب", 31 },
                    { 1239, new Guid("6b7423fa-9ee6-425c-990d-2a8ffd8ba8cb"), "چرام", 31 },
                    { 1238, new Guid("d37f867b-a8d2-43f5-baa1-0470bf0794dc"), "پاتاوه", 31 },
                    { 1237, new Guid("b75855cc-113c-4d90-9ae6-e27f3c4757e6"), "ياسوج", 31 },
                    { 1236, new Guid("50ffae11-1ee7-42a3-86fe-cc2ad56c05a8"), "مارگون", 31 },
                    { 1235, new Guid("092f24b8-3bf0-4d9c-94f3-4049e8c5ed78"), "مادوان", 31 },
                    { 1234, new Guid("ed740476-8a62-49df-a98a-a2722cbe229e"), "ليکک", 31 },
                    { 1205, new Guid("ad3510d2-f899-4866-8769-e1c0b6b53600"), "آرادان", 30 },
                    { 1233, new Guid("0f904daf-af34-4c43-9ead-995cd20b0ee3"), "لنده", 31 },
                    { 1231, new Guid("c3c69435-1cb4-436e-adb0-ae18cd962ba1"), "سي سخت", 31 },
                    { 1230, new Guid("9ccd14be-d203-46fa-b16f-0dc7faaf2696"), "سوق", 31 },
                    { 1229, new Guid("2823453d-5afb-4a52-9793-cfdf51cad52b"), "سرفارياب", 31 },
                    { 1228, new Guid("549522aa-d3c6-403b-804c-2fa83f371689"), "ديشموک", 31 },
                    { 1227, new Guid("44ea9dd7-d65b-4c9e-941b-4bf89941b1c4"), "دوگنبدان", 31 },
                    { 1226, new Guid("a5bbe7b1-df81-48ef-9e77-63881546c93c"), "دهدشت", 31 },
                    { 1225, new Guid("6d06e470-6728-4426-85fb-51c8d2676b63"), "باشت", 31 },
                    { 1232, new Guid("de701557-ca2c-4353-9e2b-934650ec7484"), "قلعه رئيسي", 31 },
                    { 1204, new Guid("fec09ed3-3f0a-4570-a039-b2d33c293c66"), "گنبکي", 29 },
                    { 1203, new Guid("74ea6825-7655-423a-aff6-80aaeb507459"), "گلزار", 29 },
                    { 1202, new Guid("1e202b3e-e676-40d2-a034-eecc805d55d5"), "گلباف", 29 },
                    { 1181, new Guid("1b01f451-d580-4456-95aa-08f9ce5ead1a"), "محي آباد", 29 },
                    { 1180, new Guid("4e5dfc52-bccc-4370-9b0a-b925c19757e7"), "محمد آباد", 29 },
                    { 1179, new Guid("ee4558df-eda8-455c-ac8a-62b9ac5a2722"), "ماهان", 29 },
                    { 1178, new Guid("8434bec1-8758-4b8e-9df8-41d6c5fa78c1"), "لاله زار", 29 },
                    { 1177, new Guid("38dd5e83-3435-4529-8dbe-3fd37b02a04c"), "قلعه گنج", 29 },
                    { 1176, new Guid("32ce745d-600a-4125-ad5e-ae36126a057a"), "فهرج", 29 },
                    { 1175, new Guid("3d892ab0-9a3d-4a6c-ad7f-d1d1958936a3"), "فارياب", 29 },
                    { 1182, new Guid("98770168-da2f-423e-9870-8be29f31b75f"), "مردهک", 29 },
                    { 1174, new Guid("ea15b087-9e40-4365-a02d-85e5d4d1abd7"), "عنبر آباد", 29 },
                    { 1172, new Guid("1b389dc0-a12f-432e-9875-9f20fd573cd4"), "شهر بابک", 29 },
                    { 1171, new Guid("98c208a1-4ee8-4b01-b833-cd039551b23f"), "شهداد", 29 },
                    { 1170, new Guid("e1180eba-1cb0-4b22-ab2b-c9c789a0f135"), "سيرجان", 29 },
                    { 1169, new Guid("9e5e0d89-da47-4934-a025-ebdbe8b617fb"), "زيد آباد", 29 },
                    { 1168, new Guid("142ac332-85b4-4da1-8624-cdd7e1f50fe6"), "زهکلوت", 29 },
                    { 1167, new Guid("c6e9863b-aeaa-492b-8acb-6b2b49f768a9"), "زنگي آباد", 29 },
                    { 1166, new Guid("15520b89-6144-4384-aafe-27cf7b605a8c"), "زرند", 29 },
                    { 1173, new Guid("ab2acd3e-988c-4133-81de-9f39c9e5f6b9"), "صفائيه", 29 },
                    { 1164, new Guid("9ecbac21-7fa5-44e4-af08-a85de78ff4e2"), "رودبار", 29 },
                    { 1183, new Guid("b1fee716-7c01-4d63-a9c1-cb63a6b96105"), "مس سرچشمه", 29 },
                    { 1185, new Guid("8b5052f7-4450-4a8c-b2dc-bbe89fe07b27"), "نجف شهر", 29 },
                    { 1201, new Guid("67b13cda-7dec-49fc-8609-c6637b0114c9"), "کيانشهر", 29 },
                    { 1200, new Guid("cb98a0b4-d014-42e3-be1d-9209d2abbefe"), "کوهبنان", 29 },
                    { 1199, new Guid("3457793b-a617-4108-bc96-e856a76c3764"), "کهنوج", 29 },
                    { 1198, new Guid("607f8077-dd8f-4351-80d1-261ff744c73d"), "کشکوئيه", 29 },
                    { 1197, new Guid("d8b59463-5481-40bb-bd1c-e1189bd85a4a"), "کرمان", 29 },
                    { 1196, new Guid("980eb3cd-1921-4eff-b427-443c0fb4ab5e"), "کاظم آباد", 29 },
                    { 1195, new Guid("71c16fd9-fad6-4726-be65-077fe531e5fa"), "چترود", 29 },
                    { 1184, new Guid("2739ff0d-5093-4cc5-8a37-86e1589c0f83"), "منوجان", 29 },
                    { 1194, new Guid("a71e820d-9b6b-4065-9d6d-55a05e258335"), "پاريز", 29 },
                    { 1192, new Guid("f060f7c2-f283-4be1-91e5-bd4f1cb93685"), "هنزا", 29 },
                    { 1191, new Guid("3626ff1b-d5d6-4d13-ab30-951ba6b44091"), "هماشهر", 29 },
                    { 1190, new Guid("158972fd-3cb3-4896-b6e5-8aeb8fb9bcb6"), "هجدک", 29 },
                    { 1189, new Guid("1d50004d-c553-4e82-9c61-a4c0eb1fb74e"), "نگار", 29 },
                    { 1188, new Guid("16a24f45-2f93-483a-bead-2e0a1ba5182f"), "نودژ", 29 },
                    { 1187, new Guid("62127aaf-6a9a-4fea-ab41-6a03bbbc5628"), "نظام شهر", 29 },
                    { 1186, new Guid("bc0d012e-72d8-482e-a73b-74efa2e750e7"), "نرماشير", 29 },
                    { 1193, new Guid("ba768f3e-d1fc-4293-9df7-e3bb6b9f651e"), "يزدان شهر", 29 },
                    { 927, new Guid("e0d0b64d-5ad7-4bed-b4f2-3017ab708cac"), "مشکان", 23 },
                    { 1085, new Guid("31ae6e4a-6a24-42df-ad48-ab9e1eedec78"), "لوشان", 27 },
                    { 1083, new Guid("1c90d0ca-55ab-46dc-b033-d3b3a2c1981a"), "لشت نشاء", 27 },
                    { 983, new Guid("17117169-1c0e-4a0a-84c3-e0892504e1e5"), "بندر جاسک", 25 },
                    { 982, new Guid("c04f2175-baa3-44cf-b56e-27bcc1760db5"), "بستک", 25 },
                    { 981, new Guid("3f631071-2396-4086-b09b-d14f3110290e"), "ابوموسي", 25 },
                    { 980, new Guid("90c95740-1bbb-4992-90eb-878b6d441749"), "گيلانغرب", 24 },
                    { 979, new Guid("a0f09aa6-d9e6-4724-b713-5c51201ad053"), "گودين", 24 },
                    { 978, new Guid("1a9812a2-2e35-4d7a-b7ac-7febc208f492"), "گهواره", 24 },
                    { 977, new Guid("778178f8-5ed3-4597-a564-b9918e0afac6"), "کوزران", 24 },
                    { 976, new Guid("bb6e61f2-c3c6-4f7d-ae39-3b23cc8715d8"), "کنگاور", 24 },
                    { 975, new Guid("7ce36f3b-e309-4833-816c-fdb22165ed13"), "کرند غرب", 24 },
                    { 974, new Guid("16dcad8b-1bd9-466a-99ac-5633e4fe3640"), "کرمانشاه", 24 },
                    { 973, new Guid("ff45d337-ba21-4c20-bfb7-1c7ec0c53ce5"), "پاوه", 24 },
                    { 972, new Guid("c2783f4b-52c3-4789-bcc7-190ab78ae9cb"), "هلشي", 24 },
                    { 971, new Guid("b1c8b9c8-4fe1-4af9-9ab9-e0d8f85425c7"), "هرسين", 24 },
                    { 970, new Guid("6a779493-d08e-4d06-b64d-d98a536f98ab"), "نوسود", 24 },
                    { 969, new Guid("b03bada2-67fa-4210-bc58-78bd129cfea3"), "نودشه", 24 },
                    { 984, new Guid("e39c1f59-7077-497a-8ecc-96987cfa1c57"), "بندر عباس", 25 },
                    { 985, new Guid("132af833-13b5-4766-b8eb-4764c4a1e950"), "بندر لنگه", 25 },
                    { 986, new Guid("b3401583-8cca-4c82-9ade-5d384cac470f"), "بيکاه", 25 },
                    { 987, new Guid("bf8db34d-f9c6-4467-b866-5cf86cca87b8"), "تازيان پائين", 25 },
                    { 1003, new Guid("ebf8c0a0-f9d1-4f65-958e-a8c97b7db2c8"), "فارغان", 25 },
                    { 1002, new Guid("cd4dd473-9a59-4641-87ce-5193c2e3dcea"), "سيريک", 25 },
                    { 1001, new Guid("15040389-b7a1-4be2-9d55-29ef7485c21d"), "سوزا", 25 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 1000, new Guid("15e8ac23-0df6-4b69-8d6a-b553d381c7f1"), "سندرک", 25 },
                    { 999, new Guid("3314586d-d981-4541-886a-bf88415796b4"), "سرگز", 25 },
                    { 998, new Guid("16aea7e5-02bf-4303-83c8-0a7eaeb56c06"), "سردشت", 25 },
                    { 997, new Guid("ab8db490-dd79-40d2-8c82-4ca8c4da5303"), "زيارتعلي", 25 },
                    { 968, new Guid("f01b48aa-0186-42fe-9acc-d2c0b1386aa4"), "ميان راهان", 24 },
                    { 996, new Guid("a23b040f-b747-43f0-a151-77b004f56c91"), "رويدر", 25 },
                    { 994, new Guid("b148b894-937a-44de-b905-9f82282fa03a"), "دشتي", 25 },
                    { 993, new Guid("573ec643-afd9-40d1-9e01-40f1a4ceb659"), "درگهان", 25 },
                    { 992, new Guid("72d31835-6a35-45ff-928d-7a0e3be7d6b1"), "خمير", 25 },
                    { 991, new Guid("1bf1f729-d095-4d04-bf93-93c271c21abd"), "حاجي آباد", 25 },
                    { 990, new Guid("f83db645-f410-4d79-ba3b-73e892043e4c"), "جناح", 25 },
                    { 989, new Guid("5f002026-17d9-44e0-bab2-5ffc28be5e29"), "تيرور", 25 },
                    { 988, new Guid("8b91f657-a726-4e8e-943f-e415df7ace83"), "تخت", 25 },
                    { 995, new Guid("155c6ebb-4b30-4086-a623-8b3d72f827fa"), "دهبارز", 25 },
                    { 967, new Guid("037d4238-64e3-4242-8560-ece4ec56c556"), "قصر شيرين", 24 },
                    { 966, new Guid("613c1f39-6178-4299-b492-b6cf883fa1d9"), "صحنه", 24 },
                    { 965, new Guid("ffbddcbe-7d50-4603-b89a-7f1dbeb6af97"), "شاهو", 24 },
                    { 944, new Guid("d0a9bb43-891d-49c9-906f-c058edf825a9"), "کوار", 23 },
                    { 943, new Guid("8914affd-191d-4c98-bf52-ba4890c424fc"), "کنار تخته", 23 },
                    { 942, new Guid("c49cd702-462f-4ad6-8c41-e2c62ca179d2"), "کره اي", 23 },
                    { 941, new Guid("9fe117ca-3c0f-4476-b66d-3c750dec7073"), "کامفيروز", 23 },
                    { 940, new Guid("9d0cf152-916a-48b8-bdc4-55063b023edb"), "کازرون", 23 },
                    { 939, new Guid("40f4b982-2b2e-4edb-a17b-f4f2163e658b"), "کارزين", 23 },
                    { 938, new Guid("33ff73e0-d9f5-4b91-9d72-735f3459b4f1"), "وراوي", 23 },
                    { 945, new Guid("672fbebb-d85c-43a0-9c3d-742c1b8a450f"), "کوهنجان", 23 },
                    { 937, new Guid("dd6e36f3-b8e1-46a1-a556-c79048c3f3ad"), "هماشهر", 23 },
                    { 935, new Guid("84b3e03e-5703-4e91-bb7e-aaaeb4a8d887"), "نورآباد", 23 },
                    { 934, new Guid("972da54f-32d0-417a-be93-72e923b0f021"), "نودان", 23 },
                    { 933, new Guid("436bc6e3-d518-491a-95da-b5514d18fe8f"), "نوجين", 23 },
                    { 932, new Guid("da13581f-c31f-4371-948f-83c066ddd0c3"), "نوبندگان", 23 },
                    { 931, new Guid("62535f78-24fb-4dac-9d13-c350e0bb1512"), "ميمند", 23 },
                    { 612, new Guid("65e76395-3284-4868-8a57-0d0a52655f70"), "ابريشم", 19 },
                    { 929, new Guid("7aee8b3b-7e8e-4f9b-b22e-74e717d8ddbc"), "مهر", 23 },
                    { 936, new Guid("e826448c-cfe6-4793-8d9f-543d2acb6b86"), "ني ريز", 23 },
                    { 1004, new Guid("bd978888-69a9-4d5f-9c3a-c3e9d30b8968"), "فين", 25 },
                    { 946, new Guid("fb13930a-e9b8-4f2b-95a3-d8022ad5b76f"), "کوپن", 23 },
                    { 948, new Guid("c07ad08b-b5f6-4899-b9d1-9f4d0372b203"), "گله دار", 23 },
                    { 964, new Guid("71a4e691-cf91-4c90-9e39-ba81ed8c31cb"), "سومار", 24 },
                    { 963, new Guid("0e7ef518-dc2e-4315-aad2-350f56a6968b"), "سنقر", 24 },
                    { 962, new Guid("426fe8ee-6a57-4879-b08d-64e1642dc146"), "سطر", 24 },
                    { 961, new Guid("9d841cdf-32d5-4bf2-afd7-6c3ae473be89"), "سرمست", 24 },
                    { 960, new Guid("d6c8f66d-391c-40ed-995c-564f0518d761"), "سر پل ذهاب", 24 },
                    { 959, new Guid("36f07fe2-feec-4f46-84ce-0dea65cf6e24"), "ريجاب", 24 },
                    { 958, new Guid("2da439b0-6678-4edc-aaa1-3d7ec8cb4dac"), "روانسر", 24 },
                    { 947, new Guid("7a0b6b8b-a28f-495c-8974-23af6f73ee67"), "گراش", 23 },
                    { 957, new Guid("126f220a-f396-4866-9842-78d196c5d16c"), "رباط", 24 },
                    { 955, new Guid("9e44f7d4-d98a-4c46-8257-e9b7868443a8"), "جوانرود", 24 },
                    { 954, new Guid("9884b722-e895-4415-9092-839ef4fe4691"), "تازه آباد", 24 },
                    { 953, new Guid("726cdc3a-7c5f-4710-a943-a7a092c1ee0e"), "بيستون", 24 },
                    { 952, new Guid("757e8d99-54cf-4fde-ad37-f492e9f0ab08"), "باينگان", 24 },
                    { 951, new Guid("39d722f5-fb3d-404d-89c7-683986cdc9b9"), "بانوره", 24 },
                    { 950, new Guid("d1ee7367-95f0-4f65-8ca0-f6ab6d5faa09"), "اسلام آباد غرب", 24 },
                    { 949, new Guid("49fbb630-8f14-4e74-b7cf-e544b873d2c4"), "ازگله", 24 },
                    { 956, new Guid("c809fef8-7e73-43a9-b5a7-48b3257f01df"), "حميل", 24 },
                    { 1084, new Guid("65922e59-baa1-4738-b2d3-48513aa7e6e5"), "لنگرود", 27 },
                    { 1005, new Guid("5c6f7b94-ada7-4cc2-96b6-56b2a9a9f8eb"), "قشم", 25 },
                    { 1007, new Guid("34b42a8e-e735-470e-9ff9-65ce1ca25adc"), "لمزان", 25 },
                    { 1062, new Guid("fd54b926-ff7b-47e4-9ee3-6d8e20093e1e"), "توتکابن", 27 },
                    { 1061, new Guid("35ebe0f9-4b1c-4e46-b4e8-807ce6871376"), "بندر انزلي", 27 },
                    { 1060, new Guid("71f323ad-d4fb-4ef5-8df2-81ed4ce9a580"), "بره سر", 27 },
                    { 1059, new Guid("86790019-03c8-474f-88cc-307b38cb35df"), "بازار جمعه", 27 },
                    { 1058, new Guid("fa9d2634-b7ec-42ee-8277-b8b9ae0c85f6"), "املش", 27 },
                    { 1057, new Guid("99e5888a-1383-4c42-b16c-4243b7ad5f3e"), "اطاقور", 27 },
                    { 1056, new Guid("bd6c53c1-a3d3-4ff2-8a59-31b08cb550b6"), "اسالم", 27 },
                    { 1055, new Guid("d0016a7e-ba6e-4743-a041-d37b08598e50"), "احمد سرگوراب", 27 },
                    { 1054, new Guid("e366a5a4-5d65-4280-ab95-2b188b60504e"), "آستانه اشرفيه", 27 },
                    { 1053, new Guid("e00e6c21-c7fb-4c06-bee3-60b894f49bf3"), "آستارا", 27 },
                    { 1052, new Guid("a36bd5d8-7a33-4f4d-91ff-ea89a8a5fe6b"), "کميجان", 26 },
                    { 1051, new Guid("d4d2b870-0dbd-456c-a901-2792c4535d16"), "کارچان", 26 },
                    { 1050, new Guid("bd058a5e-893e-437c-b224-bc0ce283277b"), "پرندک", 26 },
                    { 1049, new Guid("ca033650-1b42-4a9a-9610-130d432c548e"), "هندودر", 26 },
                    { 1048, new Guid("2bb78386-eba8-461f-9582-24ac20d4951c"), "نيمور", 26 },
                    { 1063, new Guid("30ea6a3e-c646-4759-9245-7510fca7a1e1"), "جيرنده", 27 },
                    { 1064, new Guid("ab83ff64-34a7-46f4-9281-60b0776aea48"), "حويق", 27 },
                    { 1065, new Guid("31f49345-449d-41f9-a10e-d220cdb91ed9"), "خشکبيجار", 27 },
                    { 1066, new Guid("c6b626f3-0b59-4b9b-9a0d-97a4d76ee8cb"), "خمام", 27 },
                    { 1082, new Guid("f8a60602-80ea-480e-8291-47aa072d21e0"), "لاهيجان", 27 },
                    { 1081, new Guid("95858191-49c1-4bfc-9667-10e2bf6e0e98"), "فومن", 27 },
                    { 1080, new Guid("b3212f32-ff89-4694-886c-8b981ad98b70"), "صومعه سرا", 27 },
                    { 1079, new Guid("17d6763c-bbaf-4bda-b9f6-5bbea96bdeba"), "شلمان", 27 },
                    { 1078, new Guid("f4638825-47d9-436c-9850-de31d20cc567"), "شفت", 27 },
                    { 1077, new Guid("3cdb6bef-6004-41bb-84dd-95aabdc6cbcc"), "سياهکل", 27 },
                    { 1076, new Guid("93302f07-e22b-4d4c-a463-ce3d125772ce"), "سنگر", 27 },
                    { 1047, new Guid("d4204956-773c-4bc0-a66d-f4c2d9a7bfb6"), "نوبران", 26 },
                    { 1075, new Guid("f8347988-3c47-4663-bf3e-493ad1114223"), "رودسر", 27 },
                    { 1073, new Guid("0498a864-4358-4f01-8daf-eb238a18974f"), "رودبار", 27 },
                    { 1072, new Guid("d9c6c6a3-a8eb-4a9c-a7c9-dc27edfe1ccd"), "رضوانشهر", 27 },
                    { 1071, new Guid("ccf6d130-6c20-4675-bf0c-2b16d42f2630"), "رشت", 27 },
                    { 1070, new Guid("d9c8d458-5967-4362-972d-08b568123dc2"), "رستم آباد", 27 },
                    { 1069, new Guid("c58f1e3d-3534-4a91-af8a-89840b7d0abb"), "رحيم آباد", 27 },
                    { 1068, new Guid("a84efa51-bb23-429f-a1ef-0f2464b2e5a6"), "رانکوه", 27 },
                    { 1067, new Guid("1be1a065-1283-4b68-aeeb-ceb4b8e9c4e6"), "ديلمان", 27 },
                    { 1074, new Guid("0e77e2a1-1249-493a-b587-90f0170e1782"), "رودبنه", 27 },
                    { 1046, new Guid("ffb5fe06-7147-43da-8efd-d87fcfe1bd08"), "نراق", 26 },
                    { 1045, new Guid("4a177511-80a0-4d76-8753-a252592217c3"), "ميلاجرد", 26 },
                    { 1044, new Guid("08a2a95a-a252-4734-b6b9-7dee84d9b181"), "محلات", 26 },
                    { 1023, new Guid("594e4c40-7b80-4804-ae2f-352ae35f3c0c"), "اراک", 26 },
                    { 1022, new Guid("e08174c2-7408-447c-9051-0581ce238ff9"), "آوه", 26 },
                    { 1021, new Guid("c0b36621-0058-4505-9087-c47a46d9d2d3"), "آشتيان", 26 },
                    { 1020, new Guid("bde70db1-bcb4-4efc-baea-6e141b649bd4"), "آستانه", 26 },
                    { 1019, new Guid("ef649bb4-152b-461c-99f5-359d783f739b"), "گوهران", 25 },
                    { 1018, new Guid("c441fffa-d203-4018-8814-02473fcaf850"), "گروک", 25 },
                    { 1017, new Guid("d12fbe8b-626f-4836-a3d4-a3062f339707"), "کيش", 25 },
                    { 1024, new Guid("91812b24-10dc-4114-9d9f-edf251d3d0db"), "تفرش", 26 },
                    { 1016, new Guid("663dbfab-6484-4b07-9635-b016d712e32a"), "کوهستک", 25 },
                    { 1014, new Guid("408ff580-1590-41aa-b0a7-97b638cdc2ae"), "کوخردهرنگ", 25 },
                    { 1013, new Guid("c46fd6d4-7a1a-4868-b16d-a407acfe2ae8"), "کنگ", 25 },
                    { 1012, new Guid("60db2141-0e03-4204-9368-a99a550ba979"), "چارک", 25 },
                    { 1011, new Guid("8a061a66-7b90-4d92-ae62-9f353dc32418"), "پارسيان", 25 },
                    { 1010, new Guid("d9a07e0e-4265-4431-b518-130a59c2c329"), "هشتبندي", 25 },
                    { 1009, new Guid("8bb6a163-ecb4-4091-9828-d6c3faa6bef1"), "هرمز", 25 },
                    { 1008, new Guid("d1296f34-e842-42f7-94dc-10d6ea9b0cc8"), "ميناب", 25 },
                    { 1015, new Guid("36986d33-fca5-4922-96b2-fc2452d8ddfb"), "کوشکنار", 25 },
                    { 1006, new Guid("d7216fab-02ff-46dd-8814-856db757a2c7"), "قلعه قاضي", 25 },
                    { 1025, new Guid("c248f68b-a4c8-4265-8781-d9ed10c190f7"), "توره", 26 },
                    { 1027, new Guid("8fce1946-1532-4446-ab93-c458b3845ac1"), "خشکرود", 26 },
                    { 1043, new Guid("447c04f8-8c4d-4089-8195-471e55616877"), "مامونيه", 26 },
                    { 1042, new Guid("b891f685-1d14-48d6-9b22-e2a19a719050"), "قورچي باشي", 26 },
                    { 1041, new Guid("3e17a2d5-30ee-434c-bdb4-027d4f1f1eea"), "فرمهين", 26 },
                    { 1040, new Guid("98c11ebb-97de-404d-b4f5-05a15ff7b356"), "غرق آباد", 26 },
                    { 1039, new Guid("26134761-0aa6-48d8-aa2e-9dfd3c882ded"), "شهر جديد مهاجران", 26 },
                    { 1038, new Guid("23f3c082-2685-4303-b3fb-2cf58512b8a6"), "شهباز", 26 },
                    { 1037, new Guid("a9e26371-7769-496f-912a-a9a2ded8ca02"), "شازند", 26 },
                    { 1026, new Guid("aa745320-7ff5-45a0-8b0c-519aebda5227"), "جاورسيان", 26 },
                    { 1036, new Guid("6143448a-cb6c-421a-9e12-aa51f2c3e5d1"), "ساوه", 26 },
                    { 1034, new Guid("d96b92b6-d247-431d-a27c-6c5fa1c073bf"), "زاويه", 26 },
                    { 1033, new Guid("30c539a8-f293-4755-90ae-43ce6f24f09c"), "رازقان", 26 },
                    { 1032, new Guid("625a390c-8c56-48e3-927e-48894b8791c4"), "دليجان", 26 },
                    { 1031, new Guid("91d47ec6-54ce-427f-a5aa-c9a6583f860f"), "داود آباد", 26 },
                    { 1030, new Guid("9507fafa-10b5-4157-88f7-2c09e39724b4"), "خنداب", 26 },
                    { 1029, new Guid("3ffab637-510a-4bfa-813e-60cd9f188884"), "خنجين", 26 },
                    { 1028, new Guid("ab2c46b3-7456-4d3e-8378-17b87169cb9e"), "خمين", 26 },
                    { 1035, new Guid("072ca074-6555-49a6-a4fe-709660c70d9d"), "ساروق", 26 },
                    { 611, new Guid("998b2cf6-bb9b-4956-ae66-dd46523da975"), "آران و بيدگل", 19 },
                    { 607, new Guid("12783810-0d40-46c4-a598-337f8ca2209b"), "کلور", 18 },
                    { 609, new Guid("ac41b8ce-6456-4c8f-8949-9c7793779492"), "گرمي", 18 },
                    { 206, new Guid("81970b31-c0c6-4e76-b56d-b7d6c5c61001"), "سفيد سنگ", 8 },
                    { 205, new Guid("f613a365-aa08-4e63-a45d-36ddc420e92a"), "سرخس", 8 },
                    { 204, new Guid("e2574745-b0a1-4d2e-80fe-3121511535cc"), "سبزوار", 8 },
                    { 203, new Guid("34521c1c-b073-415c-bfb0-ce6258237933"), "ريوش", 8 },
                    { 202, new Guid("404a49a0-453d-414b-88e6-ccfac301f839"), "روداب", 8 },
                    { 201, new Guid("1c529eb9-ce62-4048-adf8-00249b89ef8c"), "رضويه", 8 },
                    { 200, new Guid("d9b2af43-81d7-4a07-85d1-214c690d44bd"), "رشتخوار", 8 },
                    { 199, new Guid("c6553f4a-a79d-4b19-b2c5-355cd1e70d7e"), "رباط سنگ", 8 },
                    { 198, new Guid("0e0c4c81-bc6a-4829-a451-57c009a9526f"), "دولت آباد", 8 },
                    { 197, new Guid("d0751691-71a1-43aa-9188-5f97999651b3"), "درگز", 8 },
                    { 196, new Guid("037a0c3a-9965-4fe1-b988-3c31a6c5f1d5"), "درود", 8 },
                    { 195, new Guid("d819a958-76c7-4b38-afe4-c0ce0439f050"), "داورزن", 8 },
                    { 194, new Guid("767e1120-418e-4c88-a480-96cb0615e043"), "خواف", 8 },
                    { 193, new Guid("efff712c-9836-4e45-937c-2bc9223241e8"), "خليل آباد", 8 },
                    { 192, new Guid("5ab0a5d4-0438-45b1-849f-841193e9bbb1"), "خرو", 8 },
                    { 207, new Guid("06c6bac5-07d4-4414-9fec-1e47f346d02e"), "سلامي", 8 },
                    { 191, new Guid("c45d3a40-41ef-43e3-be0c-9bacb0b0e400"), "جنگل", 8 },
                    { 208, new Guid("15e5f67a-1729-4698-b4e2-ab981371297f"), "سلطان آباد", 8 },
                    { 210, new Guid("98bcf1df-4e79-422f-a720-77ee7c704d18"), "شادمهر", 8 },
                    { 225, new Guid("96f45243-7227-4428-862f-42f448e0747b"), "قوچان", 8 },
                    { 224, new Guid("988ca3b1-1e10-456a-aca9-6e3776ed8931"), "قلندر آباد", 8 },
                    { 223, new Guid("2245bde4-b5d7-4035-ad14-f641e3b9406f"), "قدمگاه", 8 },
                    { 222, new Guid("325bfca2-e335-4bfd-92e4-4cc58e0a98ed"), "قاسم آباد", 8 },
                    { 221, new Guid("c4b8d902-5b17-4bb2-a6b4-c7d810cbfa5d"), "فيض آباد", 8 },
                    { 220, new Guid("b39a5783-e626-4985-98a1-53592caf4ef4"), "فيروزه", 8 },
                    { 219, new Guid("b583a854-df7a-4558-9e35-926cd6993fd2"), "فريمان", 8 },
                    { 218, new Guid("1aeb06d9-5ca9-460d-8924-5e29fbe69ef8"), "فرهاد گرد", 8 },
                    { 217, new Guid("deface1d-b918-44fd-b6af-10f73314bd2d"), "عشق آباد", 8 },
                    { 216, new Guid("46f84f1a-3f6f-443b-846f-cf231fd65cf1"), "طرقبه", 8 },
                    { 215, new Guid("5a35b716-8a22-48fa-9e3f-33b9f7b00f07"), "صالح آباد", 8 },
                    { 214, new Guid("0526cc0e-ef75-442f-af07-ab311823ff0e"), "شهرآباد", 8 },
                    { 213, new Guid("b386337a-4d23-46f9-b306-a2a1b09f88cf"), "شهر زو", 8 },
                    { 212, new Guid("321007f7-6683-4e5d-b88c-ce2f5d3cd054"), "ششتمد", 8 },
                    { 211, new Guid("aa051f91-5312-488f-89a9-dc57d61e00ec"), "شانديز", 8 },
                    { 209, new Guid("bc0b9fa4-c89d-475c-9ee7-a64b50fec654"), "سنگان", 8 },
                    { 226, new Guid("e5d51b49-d6dd-4eb4-beee-4d99c60e7988"), "لطف آباد", 8 },
                    { 190, new Guid("127283f2-8efb-4cf7-ac4a-aa18323d089d"), "جغتاي", 8 },
                    { 188, new Guid("4a338d00-ab28-4469-88b6-09c0543d535a"), "تربت جام", 8 },
                    { 168, new Guid("471a3858-442d-4c7d-8f83-b3ed2027f153"), "ميرآباد", 7 },
                    { 167, new Guid("2fdf3d24-1fc1-4ba6-af87-b50ea2b4af80"), "مياندوآب", 7 },
                    { 166, new Guid("9ecb69d0-d750-4832-b6d7-9a73eec3b0ba"), "مهاباد", 7 },
                    { 165, new Guid("b222c7e2-30a4-40aa-863b-b5ce49fb9307"), "مرگنلر", 7 },
                    { 164, new Guid("9feb221a-2385-4939-84d0-df9c35945208"), "محمود آباد", 7 },
                    { 163, new Guid("b16cf072-6027-4e9c-8669-3404fc8886e1"), "محمد يار", 7 },
                    { 162, new Guid("f3998949-54f5-43a4-928d-a66e6930bb09"), "ماکو", 7 },
                    { 161, new Guid("0c6f8bfa-9292-4a09-aaec-93c4933bfc6d"), "قوشچي", 7 },
                    { 160, new Guid("1140cd99-f052-43bb-a5e9-4eeb2c16c7fd"), "قطور", 7 },
                    { 159, new Guid("4c606405-5927-4f00-9f2f-4e51f384bb02"), "قره ضياء الدين", 7 },
                    { 158, new Guid("c4467076-d258-450e-99a9-a585abb157da"), "فيرورق", 7 },
                    { 157, new Guid("00af2665-6685-4262-a9bd-f3ed7fd1f69b"), "شوط", 7 },
                    { 156, new Guid("2376d917-55b4-4dbc-a71f-5e3198c1a02a"), "شاهين دژ", 7 },
                    { 155, new Guid("d0de3966-2260-457c-b59e-b403958c6638"), "سيه چشمه", 7 },
                    { 154, new Guid("3af32bc4-316e-4c7d-9be4-cb9e72ec294e"), "سيمينه", 7 },
                    { 169, new Guid("fc683e8d-76c5-4940-ad87-c5b3d927d997"), "نازک عليا", 7 },
                    { 189, new Guid("c0aa7ed0-9393-465a-99e4-3bfa9cdea23a"), "تربت حيدريه", 8 },
                    { 170, new Guid("ba5c08b4-388a-498d-acff-cb0fe1d2ca06"), "نالوس", 7 },
                    { 172, new Guid("e02c0fd0-5d9e-43fd-9ade-37a995e16b41"), "نوشين", 7 },
                    { 187, new Guid("e0f58e38-3f1e-4d06-9c49-05d480078dc1"), "تايباد", 8 },
                    { 186, new Guid("ff2ff63c-2e09-46e4-a4a4-25248e49397b"), "بيدخت", 8 },
                    { 185, new Guid("3a3ca82f-c6d0-4e04-8e83-a2d4be1444da"), "بردسکن", 8 },
                    { 184, new Guid("a2de8ae2-788b-4efd-94a3-c85fede6bc71"), "بجستان", 8 },
                    { 183, new Guid("4dc59397-8f24-48cc-a9f9-f6636c58d5a9"), "بايک", 8 },
                    { 182, new Guid("21bdcf02-c8de-4354-be0f-b6cac013b58c"), "بار", 8 },
                    { 181, new Guid("e2f74ee9-1f41-49cb-a1ce-be9bcec81f1a"), "باخرز", 8 },
                    { 180, new Guid("4e1255cf-2f1f-4450-9435-01794fdee556"), "باجگيران", 8 },
                    { 179, new Guid("e04c20bd-20d2-4460-ba09-83587fe9042c"), "انابد", 8 },
                    { 178, new Guid("236e9303-7376-4587-89c6-b0eea55dd634"), "احمدآباد صولت", 8 },
                    { 177, new Guid("5274aac3-b946-4492-ac82-ce51da2624bc"), "گردکشانه", 7 },
                    { 176, new Guid("8c9525c1-56b9-4b1e-8f2a-51047cf88028"), "کشاورز", 7 },
                    { 175, new Guid("dd64c276-e2e4-46d6-b5e4-5c32ad675618"), "چهار برج", 7 },
                    { 174, new Guid("87e88a6b-d590-422c-9ced-65b6c4ffacab"), "پيرانشهر", 7 },
                    { 173, new Guid("a64f69b4-0d83-4518-849c-caceeaedd031"), "پلدشت", 7 },
                    { 171, new Guid("7bb6cf3f-bce8-4e89-8e28-5b09242ae6fe"), "نقده", 7 },
                    { 227, new Guid("30a93b61-fb8a-4851-9370-2e0855266578"), "مزدآوند", 8 },
                    { 228, new Guid("fca13616-a79b-4f34-bafe-6217b85cbc3d"), "مشهد", 8 },
                    { 229, new Guid("9566d2eb-e859-4136-846f-9c93b05d92a6"), "مشهدريزه", 8 },
                    { 283, new Guid("10ab5c10-d6af-4afa-9cb3-9e5240f69c58"), "چاه بهار", 9 },
                    { 282, new Guid("9f694bd9-6e80-483e-a439-d51b76fd270c"), "پيشين", 9 },
                    { 281, new Guid("77ee509b-1fc0-4ae6-84eb-f1ba2bd2f1f9"), "هيدوچ", 9 },
                    { 280, new Guid("37b94591-f25b-4e71-bcbd-fb638e136958"), "نگور", 9 },
                    { 279, new Guid("4cea2cad-d4be-4654-9a5b-733a1a743087"), "نيک شهر", 9 },
                    { 278, new Guid("0bb8ed12-d214-4adf-a441-efc25fdb2fa7"), "نوک آباد", 9 },
                    { 277, new Guid("d4ba621f-e9c6-4192-9640-2f14cbcc96e2"), "نصرت آباد", 9 },
                    { 276, new Guid("1746bf84-ab06-42f7-9f05-05b02fecb859"), "ميرجاوه", 9 },
                    { 275, new Guid("04b264df-a842-4177-9d22-92d80b73b7ef"), "مهرستان", 9 },
                    { 274, new Guid("e47b49d2-22d4-4cef-9c17-10a7d5649e86"), "محمدي", 9 },
                    { 273, new Guid("c684e752-4ef3-4aa8-86a6-c065887f10b3"), "محمدان", 9 },
                    { 272, new Guid("7850e9f0-e4fe-46f6-974d-a719a02f13cc"), "محمد آباد", 9 },
                    { 271, new Guid("0b4901e5-1bb0-45e4-8ddc-788b12653539"), "قصر قند", 9 },
                    { 270, new Guid("72a535c5-0b16-4544-bee7-600558e8dd35"), "فنوج", 9 },
                    { 269, new Guid("2d48803a-2e32-48f4-9428-d73fb7d088e6"), "علي اکبر", 9 },
                    { 284, new Guid("81537529-23df-4f33-bd91-a7d79b4ce8d6"), "کنارک", 9 },
                    { 268, new Guid("3659ee27-dfc3-4333-8316-2e6a10e5385e"), "سيرکان", 9 },
                    { 285, new Guid("f3548043-c0cf-45d3-be39-f640a2705d1d"), "گشت", 9 },
                    { 287, new Guid("8293a773-5e1f-4020-85b4-5d9a3e69a2f7"), "آرين شهر", 10 },
                    { 302, new Guid("f652d3ef-1517-4503-bec3-653e71dbdaf9"), "سه قلعه", 10 },
                    { 301, new Guid("be1c2ca6-f47d-4db9-bf56-db8e3c8b6442"), "سربيشه", 10 },
                    { 300, new Guid("34becbb1-78bf-4650-8571-c47d64ac5e0e"), "سرايان", 10 },
                    { 299, new Guid("5317b8b7-b750-4b08-9459-1291b4690523"), "زهان", 10 },
                    { 298, new Guid("cf75857d-552a-4f15-9167-93e64d79f526"), "ديهوک", 10 },
                    { 297, new Guid("326a3673-e59d-4061-8754-70a4aee5b8be"), "خوسف", 10 },
                    { 296, new Guid("d9b1fd2e-be4e-4e47-bd0a-f52b85f29389"), "خضري دشت بياض", 10 },
                    { 295, new Guid("fd4897fa-aeda-4e64-b3c6-f7afefff1c15"), "حاجي آباد", 10 },
                    { 610, new Guid("58ec6444-f77f-4d2c-9bc5-14b939632723"), "گيوي", 18 },
                    { 293, new Guid("f19f8a1b-5f5c-4d9d-9fe2-6f34ba1bddb7"), "بشرويه", 10 },
                    { 292, new Guid("de9d28e3-c5ad-4172-8639-55bf4f5374ac"), "اسلاميه", 10 },
                    { 291, new Guid("6f9fb9a2-ca66-4c53-ac53-5ed0e084794d"), "اسفدن", 10 },
                    { 290, new Guid("43efb4b1-67ad-41e7-a9b3-e32b523e9116"), "اسديه", 10 },
                    { 289, new Guid("a91ad76f-e009-4503-a2ed-d3e27724b5c7"), "ارسک", 10 },
                    { 288, new Guid("9072cc64-bea8-4945-b261-6fbdc6756eff"), "آيسک", 10 },
                    { 286, new Guid("ff443024-4871-4502-ac41-6e218463ef6c"), "گلمورتي", 9 },
                    { 267, new Guid("6bb913ae-dab8-4395-a801-96b09ac23905"), "سوران", 9 },
                    { 266, new Guid("0fefb8fc-b07d-48fa-949a-c4f894b48601"), "سرباز", 9 },
                    { 265, new Guid("1e9c9a7a-dfaa-44a3-a4b0-39cdb9b3fe94"), "سراوان", 9 },
                    { 244, new Guid("42ba1068-450f-4a05-85f3-3012cf860fd4"), "کاشمر", 8 },
                    { 243, new Guid("6a363f6f-b4de-4f88-a714-91886fbd29c3"), "کاريز", 8 },
                    { 242, new Guid("e7165d67-2e08-466d-943b-206375a07be9"), "کاخک", 8 },
                    { 241, new Guid("140ab7d7-f594-4686-ae71-621ec0cc32dc"), "چکنه", 8 },
                    { 240, new Guid("c942fb77-3d15-4b82-a9d6-c8140b947d52"), "چناران", 8 },
                    { 239, new Guid("e3c41557-b0f2-4701-9584-3cfa358b797c"), "چاپشلو", 8 },
                    { 238, new Guid("67ae0dfe-ee5a-4123-a6de-e3f6c5a1845e"), "يونسي", 8 },
                    { 237, new Guid("17b00a47-36ba-45c4-966e-6d28e40bedfc"), "همت آباد", 8 },
                    { 236, new Guid("b2daa5e7-1f5a-4fb1-88d8-ad0715cf9eed"), "نيل شهر", 8 },
                    { 235, new Guid("e7021fe1-c16b-443f-a6e0-09a36f6c8d8a"), "نيشابور", 8 },
                    { 234, new Guid("24c61ca2-8cdf-4f8c-8de4-a82a5286a63d"), "نوخندان", 8 },
                    { 233, new Guid("035f6c1b-fc79-454a-97eb-75897a684741"), "نقاب", 8 },
                    { 232, new Guid("f1fa137f-fa96-4669-bd8a-44902a832200"), "نصرآباد", 8 },
                    { 231, new Guid("d75b9aaa-ca8a-4cbf-93de-8683cce7fabf"), "نشتيفان", 8 },
                    { 230, new Guid("4e97ae1b-7c34-49ac-b71c-4d05588d0ddd"), "ملک آباد", 8 },
                    { 245, new Guid("479b6909-6e9c-42ae-9bc3-2f8481f746ea"), "کدکن", 8 },
                    { 246, new Guid("221f3c16-8f24-4d51-8e57-476b5e67eec3"), "کلات", 8 },
                    { 247, new Guid("3ea9f24d-3a3f-44b6-804d-fdb35c26afd7"), "کندر", 8 },
                    { 248, new Guid("07303bbd-e9e9-4d9c-a870-a42291b87d83"), "گلمکان", 8 },
                    { 264, new Guid("726cac01-4e2b-451a-97e8-2c590e5023e2"), "زهک", 9 },
                    { 263, new Guid("eda00af0-1cac-40a8-8731-31d3872c6d9a"), "زرآباد", 9 },
                    { 262, new Guid("6b5ac3d7-21ac-4025-b4d8-6faa2dec60bf"), "زاهدان", 9 },
                    { 261, new Guid("03b68502-c80c-42af-bfad-446d94d75d36"), "زابل", 9 },
                    { 260, new Guid("3a8e7d42-e870-4dfb-bfbb-d2ff1b3f6c0b"), "راسک", 9 },
                    { 259, new Guid("03b931e2-97db-48ec-a4af-2ba294785fe6"), "دوست محمد", 9 },
                    { 258, new Guid("83e73ddc-7167-4469-aead-5e6b45d492c5"), "خاش", 9 },
                    { 153, new Guid("7dd629b8-9d9d-4602-85aa-be3799666f33"), "سيلوانه", 7 },
                    { 257, new Guid("26f0b748-3a2b-47b3-b10b-cc29b2783d79"), "جالق", 9 },
                    { 255, new Guid("187d1229-ef7c-480f-82fa-13530316525f"), "بنت", 9 },
                    { 254, new Guid("d0a3e788-7cc5-41d2-8c28-a4fe58e90ecc"), "بمپور", 9 },
                    { 253, new Guid("423a837b-fe10-4a37-a2c0-f8f238549cac"), "بزمان", 9 },
                    { 252, new Guid("85fe63e5-8313-4448-b8ba-589a36a9b6dd"), "ايرانشهر", 9 },
                    { 251, new Guid("bab41f9a-dd4c-42df-9639-f9c95ae13961"), "اسپکه", 9 },
                    { 250, new Guid("d30bb869-ec15-4337-96cc-bbcce9125181"), "اديمي", 9 },
                    { 249, new Guid("e5fcc17c-5d46-415b-8b74-695a0a1bb8b3"), "گناباد", 8 },
                    { 256, new Guid("f398755d-ab10-42b3-a984-8cea7ee6d46b"), "بنجار", 9 },
                    { 303, new Guid("2bf57ccf-eef4-4b7e-9d7e-c8fc438685fe"), "شوسف", 10 },
                    { 152, new Guid("2d00f614-5a17-4551-b17e-9a589a29b4a9"), "سلماس", 7 },
                    { 150, new Guid("d87f32ef-26f8-4837-a55f-3e6981712bcc"), "سردشت", 7 },
                    { 53, new Guid("93ff133b-7d4e-48ef-93db-6f9c0c1b76d6"), "وردنجان", 2 },
                    { 52, new Guid("4be366da-44bb-4cc7-a3b8-5dca18e8458f"), "هفشجان", 2 },
                    { 51, new Guid("5f43176a-176a-42ae-ba4e-b7edb41aa897"), "هاروني", 2 },
                    { 50, new Guid("f35e15dd-bd79-48e9-bc3f-20628f60d928"), "نقنه", 2 },
                    { 49, new Guid("d6505e16-9f22-49f0-bcfc-6988efc4d585"), "نافچ", 2 },
                    { 48, new Guid("65770de0-eef3-4034-943a-8e8be7b1fdae"), "ناغان", 2 },
                    { 47, new Guid("2f72b8c8-1ece-4033-a949-5cbf6371f198"), "منج", 2 },
                    { 46, new Guid("0b62c866-5058-4f73-a7d1-7a96af5b7fa0"), "مال خليفه", 2 },
                    { 45, new Guid("aab7c587-8f60-42a1-846e-5b6132100240"), "لردگان", 2 },
                    { 44, new Guid("f2e1041e-e2c5-4de2-b46f-da2c897e1d7c"), "فرخ شهر", 2 },
                    { 43, new Guid("173631d1-75e9-4db0-954c-18e165ed0d78"), "فرادنبه", 2 },
                    { 42, new Guid("c9cf840b-ee81-4ab9-ba90-e627911a4ddd"), "فارسان", 2 },
                    { 41, new Guid("5b42550a-5394-4145-a81a-578ae48d19f0"), "طاقانک", 2 },
                    { 40, new Guid("ddf4ee5f-434c-44b4-83c7-da5b1f5dbe7f"), "صمصامي", 2 },
                    { 39, new Guid("c7639160-2d16-4925-940f-ca05c99bfc18"), "شهرکرد", 2 },
                    { 54, new Guid("3a2092f8-bff5-44f4-82a6-b40c9fbeebfa"), "پردنجان", 2 },
                    { 38, new Guid("d2c96d1b-ad37-4859-a06f-1fee7af41f8a"), "شلمزار", 2 },
                    { 55, new Guid("9c819b76-ddfc-4ad5-aeab-537365aeeeb8"), "چليچه", 2 },
                    { 57, new Guid("b909cfa9-bbbe-4a5d-a8f2-a04127547cfe"), "کاج", 2 },
                    { 72, new Guid("f3b3027e-7398-4221-8c16-7ce0e6ff0b27"), "زيارت", 3 },
                    { 71, new Guid("8800a261-7fea-4e5d-b1d5-3aadc80f8cc5"), "راز", 3 },
                    { 70, new Guid("590aa95c-2b82-46ce-bd1d-f95bf859fe31"), "درق", 3 },
                    { 69, new Guid("7eb9cd0e-0151-40bb-9f21-cc75e8020726"), "حصارگرمخان", 3 },
                    { 68, new Guid("092f1fe0-825e-4281-b38d-bd8154717550"), "جاجرم", 3 },
                    { 67, new Guid("c076c3f9-d98d-4b5e-bfe9-839a2b04419f"), "تيتکانلو", 3 },
                    { 66, new Guid("34966919-16db-426a-ae0e-de7af6ea75af"), "بجنورد", 3 },
                    { 65, new Guid("48c6ee9c-a5a0-48d2-9306-8a2bb0f90897"), "ايور", 3 },
                    { 64, new Guid("402fa0c1-7c14-4ea9-8249-dc8fc34ff744"), "اسفراين", 3 },
                    { 63, new Guid("d92f291e-db23-4fef-b528-55c96e21ce7a"), "آوا", 3 },
                    { 62, new Guid("58841b9e-0e07-47a3-94f0-d893d7e703d0"), "آشخانه", 3 },
                    { 61, new Guid("c567105c-50fd-42be-9678-eaa0995cdf20"), "گوجان", 2 },
                    { 60, new Guid("1450e687-e128-482e-8fa8-c617148dd1e8"), "گهرو", 2 },
                    { 59, new Guid("1c8ba35e-07ab-4d20-a9b8-aeb4eb7b9ba3"), "گندمان", 2 },
                    { 58, new Guid("ed52b6b1-c10a-44bf-b8be-557477191bbd"), "کيان", 2 },
                    { 56, new Guid("754004df-6359-464a-b7c4-7c18477f5f5f"), "چلگرد", 2 },
                    { 73, new Guid("c5d54b79-ff47-430a-94d4-c81d16c9b5d5"), "سنخواست", 3 },
                    { 37, new Guid("185e38bb-e093-47df-b24a-60bd5d78a22c"), "سورشجان", 2 },
                    { 35, new Guid("273787b3-2ef3-4998-ab88-0c67b5c03174"), "سفيد دشت", 2 },
                    { 15, new Guid("00e5de49-5d5e-4d75-a00c-14a5d85fcd95"), "مهردشت", 1 },
                    { 14, new Guid("5e29045c-4cc2-48b9-a934-1e8793e756ee"), "مروست", 1 },
                    { 13, new Guid("70c8bcb4-15f3-4647-84e0-a46f3c489291"), "عقدا", 1 },
                    { 12, new Guid("629c7455-8d76-4064-a434-ea7e1841bad2"), "شاهديه", 1 },
                    { 11, new Guid("85dc1a95-4e99-4e75-a745-5a3f4f885cf8"), "زارچ", 1 },
                    { 10, new Guid("e5554e77-3f29-4bf2-ad86-431b91b6a73b"), "خضر آباد", 1 },
                    { 9, new Guid("41fd13c0-718c-440b-b6ac-cd0c341fee61"), "حميديا", 1 },
                    { 8, new Guid("a69f42fd-50ff-4198-b21f-1f3cec6bc2ca"), "تفت", 1 },
                    { 7, new Guid("9350cc32-8ef1-4b27-baf6-9f53bdbdd73c"), "بهاباد", 1 },
                    { 6, new Guid("e753a5fd-8225-4478-8667-05c957d77da2"), "بفروئيه", 1 },
                    { 5, new Guid("51ac354b-9734-47bd-af47-68f753cc5a01"), "بافق", 1 },
                    { 4, new Guid("439b5657-8c6f-426a-bc5f-33918b363e1a"), "اشکذر", 1 },
                    { 3, new Guid("91997e71-9989-40da-9c1a-a75b9973cee8"), "اردکان", 1 },
                    { 2, new Guid("c8682a14-2338-4c18-ac8a-8ef626c5addb"), "احمد آباد", 1 },
                    { 1, new Guid("df8ad70a-fe9d-42b8-b83b-cec8297bc92b"), "ابرکوه", 1 },
                    { 16, new Guid("73152067-2195-4d3a-9cd5-2fa1a11134c1"), "مهريز", 1 },
                    { 36, new Guid("364a35c5-ccdc-42ad-8c3a-42ce9ab1dab0"), "سودجان", 2 },
                    { 17, new Guid("73352d81-f653-4ffc-b946-730c475ff408"), "ميبد", 1 },
                    { 19, new Guid("2d3bbbb7-6811-4f0a-a90d-71ad32c2c9fa"), "نير", 1 },
                    { 34, new Guid("a39c7f87-6293-42f2-83f7-8be7a2516108"), "سردشت لردگان", 2 },
                    { 33, new Guid("cd0f981e-88c3-49a4-b825-6220df657867"), "سرخون", 2 },
                    { 32, new Guid("98ad7a90-ab8d-4bac-bcb6-e19739a8d93e"), "سامان", 2 },
                    { 31, new Guid("2a7f752b-b7fc-44a7-8d43-41a462c6fc25"), "دشتک", 2 },
                    { 30, new Guid("61d75ee5-3338-49d7-ad69-f6829bba9232"), "دستناء", 2 },
                    { 29, new Guid("bcf6632e-be7b-4d17-bceb-11e15e59b3fd"), "جونقان", 2 },
                    { 28, new Guid("619f32ba-57ca-4e99-b0f3-b0767e10b08f"), "بن", 2 },
                    { 27, new Guid("f37ca548-9995-4f0c-8fe4-72b6b0fb7d54"), "بلداجي", 2 },
                    { 26, new Guid("f6893275-3bf1-4ad7-9b36-b14956ab6614"), "بروجن", 2 },
                    { 25, new Guid("c2efa543-9967-402a-96ac-3190405dacfe"), "بازفت", 2 },
                    { 24, new Guid("e33c08f9-3fa8-438c-9854-83c11660f307"), "باباحيدر", 2 },
                    { 23, new Guid("ae01dbd9-ed51-4bf0-aed1-3a2f6118585c"), "اردل", 2 },
                    { 22, new Guid("6b9b2851-32d5-4088-80f7-d383bb69dd9b"), "آلوني", 2 },
                    { 21, new Guid("6376d749-fb05-45eb-8681-c9af0e902276"), "يزد", 1 },
                    { 20, new Guid("4fe0298e-0313-47df-99ff-d8742597dd9c"), "هرات", 1 },
                    { 18, new Guid("8881250b-00c4-4777-ae9a-cf410350c90a"), "ندوشن", 1 },
                    { 74, new Guid("aadca2fe-2608-4f95-ae05-8610a6e643f0"), "شوقان", 3 },
                    { 75, new Guid("726a750b-5987-4a30-b300-1ed420872980"), "شيروان", 3 },
                    { 76, new Guid("4767e0b4-3d67-484b-bd31-5df47ec7825a"), "صفي آباد", 3 },
                    { 130, new Guid("78162d4e-6a3a-4379-a090-b8138ef1c202"), "ياسوکند", 6 },
                    { 129, new Guid("a90ebda3-5f1d-43df-baff-740cfc3b86b0"), "موچش", 6 },
                    { 128, new Guid("be4465fa-57b9-4f09-96d6-11967885a66f"), "مريوان", 6 },
                    { 127, new Guid("4266d62e-7dea-4882-83ce-1bf80938441f"), "قروه", 6 },
                    { 126, new Guid("b6ed0e5b-5601-4125-bdcb-95a157734a95"), "صاحب", 6 },
                    { 125, new Guid("62f0f4a4-4ace-4898-bf47-7c8d0789fb60"), "شويشه", 6 },
                    { 124, new Guid("b20e5b98-a393-424f-b000-5b29e456bf8d"), "سنندج", 6 },
                    { 123, new Guid("286951d4-f625-4f25-9a5b-a17b04fadd88"), "سقز", 6 },
                    { 122, new Guid("a1fe1698-3931-4c8a-9365-7eb6004f9717"), "سريش آباد", 6 },
                    { 121, new Guid("3597e143-0194-4dc2-b688-e56c39a881a1"), "سرو آباد", 6 },
                    { 120, new Guid("4b306cdb-9fc8-4cc8-ab81-88b5346304e1"), "زرينه", 6 },
                    { 119, new Guid("0729c074-f332-45ec-b5a5-2ffc4e11eede"), "ديواندره", 6 },
                    { 118, new Guid("aed12665-28c7-400b-bc92-d46d6b9a6820"), "دهگلان", 6 },
                    { 117, new Guid("23a611ae-a5bb-474c-a0b5-8d31ced2bfe8"), "دلبران", 6 },
                    { 116, new Guid("b54db2a0-7257-4050-9553-da0a01d5c7da"), "دزج", 6 },
                    { 131, new Guid("a8d168b6-de91-48bb-93e8-2ffa0ce3e324"), "پيرتاج", 6 },
                    { 115, new Guid("50b6dab9-e4f9-4f4c-9f29-0710107b45a1"), "توپ آغاج", 6 },
                    { 132, new Guid("a3544f7b-85bc-40b7-b0c6-0d219f6b23cf"), "چناره", 6 },
                    { 134, new Guid("78dee6a4-c8d4-4b87-81de-d829d801cfe0"), "کاني دينار", 6 },
                    { 149, new Guid("ec27b0e7-8fbf-4e0d-9ebe-f2b3dab61edb"), "زرآباد", 7 },
                    { 148, new Guid("d2ed68a6-5392-433c-8397-8b152c55e8bd"), "ربط", 7 },
                    { 147, new Guid("00ef1ff4-5bb7-40a2-973a-e91e8b6781ff"), "ديزج ديز", 7 },
                    { 146, new Guid("b7e79e4c-ddb3-4607-87b1-c994e4cd5bbe"), "خوي", 7 },
                    { 145, new Guid("cf5710a8-51a9-4e85-9735-75d5bf6a56a2"), "خليفان", 7 },
                    { 144, new Guid("17449c33-cf0d-401d-9551-e5655d966eeb"), "تکاب", 7 },
                    { 143, new Guid("777c82a9-0711-446d-88f3-5c13f8c47767"), "تازه شهر", 7 },
                    { 142, new Guid("c5290c1d-e29d-4516-99b4-4fc322ed8494"), "بوکان", 7 },
                    { 141, new Guid("1509a517-1b06-4273-ad26-cbfd2e494377"), "بازرگان", 7 },
                    { 140, new Guid("3f8c24cd-f20c-4636-ab8d-badd500a2b75"), "باروق", 7 },
                    { 139, new Guid("56e274a2-74cd-4022-a45f-beac595b7442"), "ايواوغلي", 7 },
                    { 138, new Guid("c1089931-a61b-4c51-814c-80d0f6d94910"), "اشنويه", 7 },
                    { 137, new Guid("c8c54914-69f0-48f3-93ce-008584f867ed"), "اروميه", 7 },
                    { 136, new Guid("4afc920c-7572-474d-a31c-8417d8fe981b"), "آواجيق", 7 },
                    { 135, new Guid("58bfcc5c-6601-4a60-9c27-7ac64bd0eb1d"), "کاني سور", 6 },
                    { 133, new Guid("1a91c33d-dd6c-4af0-913f-e44ea1f47e1c"), "کامياران", 6 },
                    { 114, new Guid("edf770dc-1c5a-420d-b6bd-8336f6e60d0f"), "بيجار", 6 },
                    { 113, new Guid("f7307297-63a5-422c-98d1-eb99cad89322"), "بوئين سفلي", 6 },
                    { 112, new Guid("06190e35-2016-4309-815f-dba12bdcf1f0"), "بلبان آباد", 6 },
                    { 91, new Guid("afb3fbba-d7ca-4214-9d05-7feb37fa0ce8"), "محمد شهر", 4 },
                    { 90, new Guid("c52e3d04-cd34-4d52-94f3-3141f2d6d2c7"), "ماهدشت", 4 },
                    { 89, new Guid("1e8fa1b0-c336-4237-9cc8-87f42226cce2"), "فرديس", 4 },
                    { 88, new Guid("fd53edbc-176b-4318-9f84-69998fd23f54"), "طالقان", 4 },
                    { 87, new Guid("c69bb3f1-1ab2-4399-ad76-42cdcf77b3d1"), "شهر جديد هشتگرد", 4 },
                    { 86, new Guid("b207ede8-8854-4a5f-8ba4-eeb1dfeb5781"), "تنکمان", 4 },
                    { 85, new Guid("95d13f1e-5b91-47b9-871a-9955977267c5"), "اشتهارد", 4 },
                    { 84, new Guid("3262fcf7-9c29-466f-a2c6-ec036b1b8260"), "آسارا", 4 },
                    { 83, new Guid("0bcf133e-24d0-4bb6-a417-c90a89c167ee"), "گرمه", 3 },
                    { 82, new Guid("2712cde1-10b7-471b-85be-9b05b641bdce"), "چناران شهر", 3 },
                    { 81, new Guid("249c771e-0604-4e77-9a07-64dea3805533"), "پيش قلعه", 3 },
                    { 80, new Guid("63a72917-9ee3-495a-b447-01809d132a8c"), "لوجلي", 3 },
                    { 79, new Guid("cb4e2e91-56e0-40f4-bc74-05a91fc077c3"), "قوشخانه", 3 },
                    { 78, new Guid("ede02915-09a1-4723-b6e8-00fdfe10b77f"), "قاضي", 3 },
                    { 77, new Guid("9d8ac2df-82a3-4c96-a82c-a528d3e4b248"), "فاروج", 3 },
                    { 92, new Guid("18a32eb1-8010-4326-ae0e-dde5f361ae7e"), "مشکين دشت", 4 },
                    { 93, new Guid("baaf6a60-fe2f-4d11-8661-7dc8e64e4e2c"), "نظر آباد", 4 },
                    { 94, new Guid("a8104492-98ef-422d-a2a5-a79fdd6a439a"), "هشتگرد", 4 },
                    { 95, new Guid("7cbcd186-7075-4dfb-b7e0-3e825ef22ae0"), "چهارباغ", 4 },
                    { 111, new Guid("84dacf64-b52f-417f-b846-bb13230dcacc"), "برده رشه", 6 },
                    { 110, new Guid("fdc10836-2ed1-47e0-9cec-a6e43279b2e7"), "بانه", 6 },
                    { 109, new Guid("586ed95c-9eeb-462f-9541-3a82e7cf0669"), "بابارشاني", 6 },
                    { 108, new Guid("0083b9cd-285c-4756-8e54-cbb000aff931"), "اورامان تخت", 6 },
                    { 107, new Guid("0af80cc3-abca-4ed7-a3d6-3ca1af222533"), "آرمرده", 6 },
                    { 106, new Guid("b3d7160c-e73c-44c7-8c1a-91ac84f9d356"), "کهک", 5 },
                    { 105, new Guid("ba84576c-7cc4-437b-ac49-de1a92f98d48"), "قنوات", 5 },
                    { 151, new Guid("a80850fc-7f77-49d6-a786-a00254c08a3b"), "سرو", 7 },
                    { 104, new Guid("1da28175-0bce-4c70-bd9c-174a8cbb9a02"), "قم", 5 },
                    { 102, new Guid("e8c18d9d-33b0-478f-95f4-b099ad62f105"), "دستجرد", 5 },
                    { 101, new Guid("b55ce0fe-ee47-45e1-a174-1583515d0dc6"), "جعفريه", 5 },
                    { 100, new Guid("b7216fc4-6065-42d7-9776-c05fa0aee3bd"), "گلسار", 4 },
                    { 99, new Guid("4ce9725d-f518-40b0-90b8-a178f960867b"), "گرمدره", 4 },
                    { 98, new Guid("11f79458-ac71-4b61-8fd3-404c7d516042"), "کوهسار", 4 },
                    { 97, new Guid("d98d14fa-2ce7-4500-8623-13e5ab6da5d0"), "کمال شهر", 4 },
                    { 96, new Guid("693470c2-d9cd-4236-896d-ba89788662fd"), "کرج", 4 },
                    { 103, new Guid("13126edf-5526-49d0-8c3c-53d37e3e534b"), "سلفچگان", 5 },
                    { 304, new Guid("1b2d5e4f-e374-41fb-a088-5a8b3f65034e"), "طبس", 10 },
                    { 294, new Guid("afcbbca9-485b-4c6b-88ea-734fc034b3a3"), "بيرجند", 10 },
                    { 306, new Guid("3513cf00-ce12-4ddb-97e3-7b95fddf4523"), "عشق آباد", 10 },
                    { 512, new Guid("32293f4a-eec3-4cbf-b785-180e468a3e27"), "مرزن آباد", 15 },
                    { 511, new Guid("18138b21-00b9-448a-935e-1ee11b071fbe"), "محمود آباد", 15 },
                    { 510, new Guid("a07e9270-e18b-425d-a768-f2f4f09f4b82"), "قائم شهر", 15 },
                    { 509, new Guid("4e34e454-efdc-4d11-8558-f1510c08ef7f"), "فريم", 15 },
                    { 508, new Guid("225b0af9-45ea-477f-86dc-3206736dd8d3"), "فريدونکنار", 15 },
                    { 507, new Guid("49786bf3-03d2-425e-9d8b-a5c883282663"), "عباس آباد", 15 },
                    { 506, new Guid("7fe14b57-9ecf-4a38-8f09-d014e8b71efd"), "شيرگاه", 15 },
                    { 505, new Guid("bdefa81e-af4d-4324-979a-45422de59d8e"), "شيرود", 15 },
                    { 504, new Guid("033f49d0-bc1e-41f6-9ea2-8066526f7410"), "سورک", 15 },
                    { 503, new Guid("85674da9-23c3-40ec-b6ce-a17c3905c011"), "سلمان شهر", 15 },
                    { 502, new Guid("af4e7e3a-c569-4a18-915d-a17a2e60364d"), "سرخرود", 15 },
                    { 501, new Guid("3ae67f54-7693-40df-b6d4-0d0bc3743f7a"), "ساري", 15 },
                    { 500, new Guid("bff0bdc2-ead8-4746-9abd-e4c16f8e204c"), "زيرآب", 15 },
                    { 499, new Guid("d35f5710-ead8-471e-ab89-3b6b02a511bb"), "زرگر محله", 15 },
                    { 498, new Guid("c8ae7dfe-5eab-43e0-9676-f356f913ef18"), "رينه", 15 },
                    { 513, new Guid("d995275a-4506-4c30-86ce-edf1a9d34b95"), "مرزيکلا", 15 },
                    { 497, new Guid("6cd891e3-cf10-4c0e-a3a9-0969a7854b49"), "رويان", 15 },
                    { 514, new Guid("17c22f4c-ab43-4322-800c-e6dc2fa083bc"), "نشتارود", 15 },
                    { 516, new Guid("1bab0ae4-7016-40de-9932-1592b96c9daa"), "نوشهر", 15 },
                    { 531, new Guid("3067b266-7356-48aa-b88e-721c34a7dc67"), "کياکلا", 15 },
                    { 530, new Guid("481c7140-b29b-4953-8b8d-d5403e401ffe"), "کياسر", 15 },
                    { 529, new Guid("150b538b-870c-4fbc-b8a2-e4f61cdb47a3"), "کوهي خيل", 15 },
                    { 528, new Guid("957e2f02-a597-45fa-a989-7efd25482ded"), "کلاردشت", 15 },
                    { 527, new Guid("426d7a2c-831a-4a8c-9030-9488f9d93375"), "کلارآباد", 15 },
                    { 526, new Guid("b410c940-b530-497e-b261-746c94b755ae"), "کجور", 15 },
                    { 525, new Guid("ff41a21d-7403-4413-9939-e1f760bb2fb9"), "کتالم و سادات شهر", 15 },
                    { 524, new Guid("3b22066b-9255-47ba-86dc-3f205d74af4d"), "چمستان", 15 },
                    { 523, new Guid("71785b2b-112e-4198-90a6-4312d3463fac"), "چالوس", 15 },
                    { 522, new Guid("c55a9ae1-e1b3-48ba-a16f-d94ee4e172ee"), "پول", 15 },
                    { 521, new Guid("5c9a86cb-c12f-4090-8f0c-b11afab5906f"), "پل سفيد", 15 },
                    { 520, new Guid("fbef2401-496c-4e8c-a29e-c92c5cd8b806"), "پايين هولار", 15 },
                    { 519, new Guid("5e8d7aae-facf-48af-a3af-b64c536b5f7e"), "هچيرود", 15 },
                    { 518, new Guid("5e6d65d3-028c-400f-ba40-aec86a1e2102"), "هادي شهر", 15 },
                    { 517, new Guid("04fa8681-9175-456c-90ef-eb18f5bd9fbf"), "نکا", 15 },
                    { 515, new Guid("9f484a3d-dbcf-49b6-8ae8-323da7b55c99"), "نور", 15 },
                    { 532, new Guid("ff324af8-470c-454c-82b3-d633689f9139"), "گتاب", 15 },
                    { 496, new Guid("4668132e-3306-4002-8f70-0881a7526189"), "رستمکلا", 15 },
                    { 494, new Guid("b44ec8bc-fe3d-4660-90b1-a23a6c705fc1"), "دابودشت", 15 },
                    { 474, new Guid("c508b540-4240-4949-b6ad-6f79d7a55422"), "گاليکش", 14 },
                    { 473, new Guid("2d57fa57-5cfe-487c-8868-d4f59ae9ab0a"), "کلاله", 14 },
                    { 472, new Guid("002591c3-4665-4b40-84d6-9da8bf40f9f2"), "کرد کوي", 14 },
                    { 471, new Guid("588d73c8-fba7-4f91-ac10-a313d6dc4e33"), "نگين شهر", 14 },
                    { 470, new Guid("282f8f20-81ad-4175-a8c9-355eb50316ab"), "نوکنده", 14 },
                    { 469, new Guid("8f428fa4-72c2-436c-a373-bb28344c1cdb"), "نوده خاندوز", 14 },
                    { 305, new Guid("b905f561-9a8d-44cf-86ee-481decf976a1"), "طبس مسينا", 10 },
                    { 467, new Guid("805ae57c-731c-4a31-a02b-ca7150fc87aa"), "مزرعه", 14 },
                    { 466, new Guid("57518a9c-3863-43f6-8278-ae14f6e21128"), "مراوه تپه", 14 },
                    { 465, new Guid("5c9ba683-a84c-44bc-802a-0fa70c587ccf"), "فراغي", 14 },
                    { 464, new Guid("09682334-3c77-4cff-94fa-b00820734729"), "فاضل آباد", 14 },
                    { 463, new Guid("ed2b86c2-db02-4566-990b-0ae9fc102fd7"), "علي آباد", 14 },
                    { 462, new Guid("5fcde61a-cadc-4cb6-bea8-324c5215c8ff"), "سيمين شهر", 14 },
                    { 461, new Guid("3fb001c4-d1eb-40ab-9d0f-39993101566a"), "سنگدوين", 14 },
                    { 460, new Guid("56a15545-11d3-4233-abf0-ec3d9362acd1"), "سرخنکلاته", 14 },
                    { 475, new Guid("d7907e30-2a1f-4a45-aa71-4ef0f3930e99"), "گرگان", 14 },
                    { 495, new Guid("161585e2-e8a2-47b4-80fa-b9e199a7df1e"), "رامسر", 15 },
                    { 476, new Guid("0e4f946d-7e91-4afd-bf73-e1670b6e5c0c"), "گميش تپه", 14 },
                    { 478, new Guid("cedd3c5f-6e21-4ee2-aaae-c18957c3463e"), "آلاشت", 15 },
                    { 493, new Guid("e0dbbab8-b6d4-450a-a966-7f70c73cbaf1"), "خوش رودپي", 15 },
                    { 492, new Guid("b1e4ed29-9b7f-445f-9d6a-ecb979080fdc"), "خليل شهر", 15 },
                    { 491, new Guid("dc045142-bcdf-49ca-a85d-010bc8bf11e9"), "خرم آباد", 15 },
                    { 490, new Guid("f9a4c433-e126-4769-b8d7-7789351844a3"), "جويبار", 15 },
                    { 489, new Guid("f9d2f7ae-85d6-41b6-8695-daba9907c396"), "تنکابن", 15 },
                    { 488, new Guid("edaaa912-5e38-4aab-9640-acdc2a2ef09f"), "بهنمير", 15 },
                    { 487, new Guid("9d5af6c0-a06f-47f2-975a-c10c6db3bec8"), "بهشهر", 15 },
                    { 486, new Guid("5d60b268-f8f2-45bb-b4cd-12ee4497650c"), "بلده", 15 },
                    { 485, new Guid("0bd33004-a3d4-4e41-8413-27b58b5b55e9"), "بابلسر", 15 },
                    { 484, new Guid("22584c2e-d535-4f2d-bf29-273e49cb6ceb"), "بابل", 15 },
                    { 483, new Guid("cc61a145-f512-45a9-9047-3957640d656d"), "ايزد شهر", 15 },
                    { 482, new Guid("b908065f-384a-4098-9b68-140f68937a20"), "امير کلا", 15 },
                    { 481, new Guid("b675065c-8ee3-4686-9ba6-ab95e41eacaf"), "امامزاده عبدالله", 15 },
                    { 480, new Guid("57b89931-103a-49e1-b20d-07228715789e"), "ارطه", 15 },
                    { 479, new Guid("34d9d9ac-31ab-4d61-9f32-fd43352302a5"), "آمل", 15 },
                    { 477, new Guid("49726170-1799-41cd-a6e9-0fcf2c39edb6"), "گنبدکاووس", 14 },
                    { 533, new Guid("313283db-9ad8-43e0-bf03-8124321ff1c3"), "گزنک", 15 },
                    { 534, new Guid("d20cc475-a7ce-4a58-b8c3-ce77a2febf02"), "گلوگاه", 15 },
                    { 535, new Guid("bf7d8e44-63c5-49f9-a6b4-6ced08a7d900"), "آبيک", 16 },
                    { 589, new Guid("3ec92125-14f2-4a87-a764-695232f562fa"), "بيله سوار", 18 },
                    { 588, new Guid("9eefd425-6baf-4c7a-b31e-d609ed2e41fe"), "اصلاندوز", 18 },
                    { 587, new Guid("210530f2-1452-4a12-8c22-8bba26eecc16"), "اسلام آباد", 18 },
                    { 586, new Guid("ed118d3c-9b8e-4357-acb3-ca424ba240eb"), "اردبيل", 18 },
                    { 585, new Guid("d0675246-223e-4198-b517-0d42dd7e771e"), "آبي بيگلو", 18 },
                    { 584, new Guid("aad81ce4-6894-47bf-8287-896c15e0d967"), "گراب", 17 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 583, new Guid("6c596fc3-8f1c-4930-9341-13e28696db61"), "کوهناني", 17 },
                    { 582, new Guid("8e80cc35-b793-4a07-bc48-852ef7d5d500"), "کوهدشت", 17 },
                    { 581, new Guid("3d088dc8-111c-4257-b893-0db4f6af32fb"), "چقابل", 17 },
                    { 580, new Guid("668f2caa-0544-46e3-b204-85bf61ff0c5d"), "چالانچولان", 17 },
                    { 579, new Guid("6e1eede7-7ccb-40c7-a8fe-3df3155eda83"), "پلدختر", 17 },
                    { 578, new Guid("ce16bfec-a8e7-4189-a254-c00516487c6d"), "ويسيان", 17 },
                    { 577, new Guid("8f5b610a-09f0-41fe-8b2d-a8d43c0e640e"), "هفت چشمه", 17 },
                    { 576, new Guid("2f6a98fd-a071-4478-b924-8fb74e4ed6c9"), "نورآباد", 17 },
                    { 575, new Guid("df866769-5056-4d6a-878e-dd70ff2d3198"), "مومن آباد", 17 },
                    { 590, new Guid("bcaca71f-81e3-4991-9ee2-e6ea1c9d40ea"), "تازه کند", 18 },
                    { 574, new Guid("dfd27780-5497-4f5a-b25a-f6c047a23587"), "معمولان", 17 },
                    { 591, new Guid("dec54b7e-19e6-4b1f-8a0a-7a0879a1ec7e"), "تازه کند انگوت", 18 },
                    { 593, new Guid("946f7369-bae4-4b19-8bb4-479f5921b839"), "خلخال", 18 },
                    { 608, new Guid("eb873cc6-2c07-4cab-91a6-d581c8576914"), "کورائيم", 18 },
                    { 1241, new Guid("58e301e2-e285-4c0d-911b-e598b157472c"), "گراب سفلي", 31 },
                    { 606, new Guid("aaa90f7e-65cc-41d8-81c6-d299ec86b360"), "پارس آباد", 18 },
                    { 605, new Guid("8e946657-fbbf-4c0a-a523-9c6d61813898"), "هير", 18 },
                    { 604, new Guid("f3ba19ac-6928-468a-b582-123fe00f28d3"), "هشتجين", 18 },
                    { 603, new Guid("59748898-7f4e-4d7a-a95a-4cf66a69b633"), "نير", 18 },
                    { 602, new Guid("29250e24-4f79-44d1-9eaf-b1018a5640d0"), "نمين", 18 },
                    { 601, new Guid("cafb2d22-2962-46e8-a8d5-bb540343bcb3"), "مشگين شهر", 18 },
                    { 600, new Guid("48ed3481-c276-43f5-aec6-72cdaa6235d8"), "مرادلو", 18 },
                    { 599, new Guid("268af097-66d6-43e6-a15d-e4bcbb998847"), "لاهرود", 18 },
                    { 598, new Guid("909e725d-f275-4456-8979-d6883281a6de"), "قصابه", 18 },
                    { 597, new Guid("e060b61a-e5be-4251-99c7-d9ee456015cd"), "فخرآباد", 18 },
                    { 596, new Guid("af464fdf-a695-4212-8cb2-1a651b6de24d"), "عنبران", 18 },
                    { 595, new Guid("3ab5209e-d095-4da3-94e7-de798630278f"), "سرعين", 18 },
                    { 594, new Guid("2ea3df23-e620-459a-9a89-15b2007a7cf5"), "رضي", 18 },
                    { 592, new Guid("3a51f654-db2e-4306-a961-e17e045019fc"), "جعفر آباد", 18 },
                    { 573, new Guid("05292bc6-8591-475a-96c6-9a7980bf8a0d"), "فيروزآباد", 17 },
                    { 572, new Guid("28f29999-4636-42e0-8b21-e5bab8495972"), "شول آباد", 17 },
                    { 571, new Guid("de002367-1616-4e38-971e-45513818e04d"), "سپيد دشت", 17 },
                    { 550, new Guid("ae544c7c-55da-4bbe-a560-e3e72c5eb821"), "سگز آباد", 16 },
                    { 549, new Guid("ae38e2a5-cd39-4d92-ba71-633cee758463"), "سيردان", 16 },
                    { 548, new Guid("6339e456-90a3-463b-9f1c-2878413469e4"), "رازميان", 16 },
                    { 547, new Guid("289d0747-b4bb-4996-9ddc-f0581e6f9269"), "دانسفهان", 16 },
                    { 546, new Guid("664e3d4c-282d-49bb-acac-3118bd9bcb14"), "خرمدشت", 16 },
                    { 545, new Guid("5f9a387f-7204-4494-ae7a-897a890938a5"), "خاکعلي", 16 },
                    { 544, new Guid("b365c6ac-c4f2-4f13-a85b-7420d296496f"), "تاکستان", 16 },
                    { 543, new Guid("8f2b12eb-30c0-4c48-85c8-9e5bb0da10d8"), "بيدستان", 16 },
                    { 542, new Guid("fea81ab5-1261-42db-9ca1-db7f7b440149"), "بوئين زهرا", 16 },
                    { 541, new Guid("e3f475e5-ea4d-4348-b452-2d0102314455"), "الوند", 16 },
                    { 540, new Guid("1e846ac9-564a-4128-b28f-6ef1681b2b71"), "اقباليه", 16 },
                    { 539, new Guid("5a53de04-157b-4f9e-8cfb-e9fb6e390b2e"), "اسفرورين", 16 },
                    { 538, new Guid("d694e7c6-fdac-46de-aa68-1325d454cdc5"), "ارداق", 16 },
                    { 537, new Guid("1903f231-0621-4194-811b-73a8bcf5d450"), "آوج", 16 },
                    { 536, new Guid("c95ac872-7e91-4b97-9f1d-b15aa599b9ac"), "آبگرم", 16 },
                    { 551, new Guid("f9afcf1e-9cbb-44f4-9d1b-800865fb6793"), "شال", 16 },
                    { 552, new Guid("9edb2bad-f880-4805-9ca7-d9f291e23f10"), "شريفيه", 16 },
                    { 553, new Guid("2725c2ca-bcdd-4208-b7fd-119fee1d9b72"), "ضياء آباد", 16 },
                    { 554, new Guid("befb244a-b55c-4dd9-8bc5-95d21868796f"), "قزوين", 16 },
                    { 570, new Guid("c693c7ea-3b62-421d-9407-cdd84a71c235"), "سراب دوره", 17 },
                    { 569, new Guid("42c1befd-bdfb-4b26-abce-1655db2751ba"), "زاغه", 17 },
                    { 568, new Guid("eb7b410d-a482-4934-a8e4-bebab6701114"), "دورود", 17 },
                    { 567, new Guid("35ad1bc5-2670-48bb-b241-257aa4ce23dc"), "درب گنبد", 17 },
                    { 566, new Guid("9305c823-9ce7-49de-9d69-45b29bf09d1f"), "خرم آباد", 17 },
                    { 565, new Guid("25349847-0a42-44f3-975a-418d476ded68"), "بيرانشهر", 17 },
                    { 564, new Guid("e0899563-70d4-425d-83f2-a0d6541aa7e0"), "بروجرد", 17 },
                    { 459, new Guid("1251144c-a771-47ac-8c09-7745cddba677"), "راميان", 14 },
                    { 563, new Guid("3580c4af-5e1e-42b0-b758-fe5fe4a42d31"), "اليگودرز", 17 },
                    { 561, new Guid("ad24b6d1-fc95-4e73-aaef-acb0b85a53db"), "اشترينان", 17 },
                    { 560, new Guid("6fbb1202-d2ba-45ce-9dae-bbd33be28315"), "ازنا", 17 },
                    { 559, new Guid("50f75c21-c7c2-4962-8413-a70abc095c43"), "کوهين", 16 },
                    { 558, new Guid("9131f59c-e6ac-420a-8e38-dc09f73dfaca"), "نرجه", 16 },
                    { 557, new Guid("921c717c-9d72-4961-aaac-10bcd5f620fd"), "معلم کلايه", 16 },
                    { 556, new Guid("cc40203e-13eb-4afa-8f4f-87c8041dda01"), "محمود آباد نمونه", 16 },
                    { 555, new Guid("c0b3f76c-e088-4dc5-bb17-d7da947e50f5"), "محمديه", 16 },
                    { 562, new Guid("86afa84b-ba3a-4263-952c-372c1a1e05d4"), "الشتر", 17 },
                    { 458, new Guid("228a6061-e960-427d-a551-1fd77390eddc"), "دلند", 14 },
                    { 468, new Guid("cfc8d3f5-c087-4672-9996-c160bd00549b"), "مينودشت", 14 },
                    { 456, new Guid("e0e3d00d-1b33-41d7-bfd7-0149a254925c"), "جلين", 14 },
                    { 359, new Guid("420a3d62-a4ba-46ca-8149-b9f0131ef51b"), "شمس آباد", 11 },
                    { 358, new Guid("d992e9a3-39b1-45ac-898a-5a01ac29dbd1"), "شرافت", 11 },
                    { 357, new Guid("97235b2b-0aa5-4ed0-b169-59cc95e141f4"), "شاوور", 11 },
                    { 356, new Guid("2d53fff2-6323-4fa9-a17e-ba7c498adf5e"), "شادگان", 11 },
                    { 355, new Guid("3ac2015b-1d22-4ac5-87aa-a792d4cb0415"), "سياه منصور", 11 },
                    { 354, new Guid("d89c79b6-a924-4432-a65f-d1fd9e54ee0f"), "سوسنگرد", 11 },
                    { 353, new Guid("89bd6b42-2b0b-49b8-b9c2-0bd3db911555"), "سماله", 11 },
                    { 352, new Guid("5588baa7-7aac-4925-814a-33b8313dcf4f"), "سردشت", 11 },
                    { 351, new Guid("bb03a395-b238-47af-b099-af01da70f490"), "سرداران", 11 },
                    { 350, new Guid("ccdd2b5c-5f76-42c8-b3fe-438dd53a8343"), "سالند", 11 },
                    { 349, new Guid("ed8616da-cc3d-433f-86b5-1a6a1cce58c1"), "زهره", 11 },
                    { 348, new Guid("eb611cca-1650-4694-8a62-3c72dc7e2cb6"), "رفيع", 11 },
                    { 347, new Guid("ba722e95-40e6-4ff2-ac56-d90a5479144a"), "رامهرمز", 11 },
                    { 346, new Guid("10dd8d75-63c6-4cfe-836b-f15698760b6b"), "رامشير", 11 },
                    { 345, new Guid("7e35acb2-79ae-4bf4-a47c-cfd211b22c5c"), "دهدز", 11 },
                    { 360, new Guid("faad8760-4278-4248-aee9-874c1a5b589b"), "شهر امام", 11 },
                    { 344, new Guid("78b5d321-3cf5-4264-9ce0-513312eaf963"), "دزفول", 11 },
                    { 361, new Guid("88245154-0856-4f90-ae62-2d0bba9732d6"), "شوش", 11 },
                    { 363, new Guid("1c648a64-f2e1-4c35-8675-f139a55e511b"), "شيبان", 11 },
                    { 378, new Guid("4ad57d85-2ea6-4061-a4d1-bd1ebd48b9f5"), "مينوشهر", 11 },
                    { 377, new Guid("cb3fc0fa-e022-4a63-9ef2-0d376f1e56bb"), "ميداود", 11 },
                    { 376, new Guid("5fef0f22-f456-4b0c-8a3e-55f13caaa108"), "ميانرود", 11 },
                    { 375, new Guid("8f0cbf39-c5fa-40c9-a1e5-a3b1768548d3"), "منصوريه", 11 },
                    { 374, new Guid("d5f7b7cd-2783-4ae8-8818-eedfbc456bed"), "ملاثاني", 11 },
                    { 373, new Guid("b3b76cb0-d3f8-483a-9412-de79cfb84de1"), "مقاومت", 11 },
                    { 372, new Guid("b6040dc6-4ff7-4423-8739-cc761f735f04"), "مشراگه", 11 },
                    { 457, new Guid("8dc884bf-9eb3-4d20-b683-341722fe98ad"), "خان ببين", 14 },
                    { 370, new Guid("3cb3d44d-5a84-4160-bc75-3234989fbd65"), "لالي", 11 },
                    { 369, new Guid("31c7dd83-202a-4f05-b8d2-ab04942314f2"), "قلعه خواجه", 11 },
                    { 368, new Guid("78a424d7-7cdb-4ebc-aecf-cc9d3a61399c"), "قلعه تل", 11 },
                    { 367, new Guid("b16bac1a-c4fb-411f-87fb-7f235aee3a43"), "فتح المبين", 11 },
                    { 366, new Guid("fdeefa25-fb61-486a-8eb1-bf33615c8e11"), "صيدون", 11 },
                    { 365, new Guid("099a7ec5-d5bf-4f55-8c6e-b3ff54d849c1"), "صفي آباد", 11 },
                    { 364, new Guid("0c5370fb-bdbc-441b-a5a8-31fd1d054758"), "صالح شهر", 11 },
                    { 362, new Guid("4ca3c469-f926-4e31-b821-e09506fb9070"), "شوشتر", 11 },
                    { 379, new Guid("078efadc-e428-469d-abc6-0ca0b36c50e6"), "هفتگل", 11 },
                    { 343, new Guid("593ee3a7-34cc-4e82-b1af-e55691ef8b6f"), "دارخوين", 11 },
                    { 341, new Guid("377e800d-0709-48b8-8a4a-3a137f2aaed6"), "خرمشهر", 11 },
                    { 321, new Guid("0343c844-c6cb-467e-a195-db4a0019e348"), "الهايي", 11 },
                    { 320, new Guid("48de3cf0-d69f-4ee5-8173-2b8f78ad4709"), "اروند کنار", 11 },
                    { 319, new Guid("8f295819-0122-41eb-86b8-62a988402eba"), "ابوحميظه", 11 },
                    { 318, new Guid("43d6cf66-6779-44b6-8cb8-7a30a5e72d93"), "آغاجاري", 11 },
                    { 317, new Guid("537bfa00-a94b-4316-88fb-de64d1382419"), "آزادي", 11 },
                    { 316, new Guid("940e47d4-c076-4fb7-aed5-f2c7d66445f6"), "آبژدان", 11 },
                    { 315, new Guid("8605e420-bc90-44c0-8aaf-9e284a9e3d04"), "آبادان", 11 },
                    { 314, new Guid("c7387954-98bb-472e-b81d-534fee948177"), "گزيک", 10 },
                    { 313, new Guid("fd600c11-0509-4e2c-8735-9da51b5b0a64"), "نيمبلوک", 10 },
                    { 312, new Guid("be4b75d1-5b24-4c42-8a65-7fa8486102f0"), "نهبندان", 10 },
                    { 311, new Guid("d192cca4-3793-4eed-8495-7dd2b6a7fff1"), "مود", 10 },
                    { 310, new Guid("a87161a1-7856-47ab-9144-8c3e395a0f9f"), "محمدشهر", 10 },
                    { 309, new Guid("50fc9405-fc2e-438c-9a41-77d2aed4ff08"), "قهستان", 10 },
                    { 308, new Guid("883874f0-f75c-470d-a633-4ce51e97308f"), "قائن", 10 },
                    { 307, new Guid("d6f7cf69-ff32-44c2-a8e0-f35f09feb604"), "فردوس", 10 },
                    { 322, new Guid("9d7e2814-e534-4e42-8c71-5097ebb74dbe"), "الوان", 11 },
                    { 342, new Guid("a8f15ffd-6a0f-4500-a3d7-38ddecff8652"), "خنافره", 11 },
                    { 323, new Guid("a2b8e3d8-c23c-41d7-8141-9f0924724ce1"), "اميديه", 11 },
                    { 325, new Guid("e85e07d5-43f4-4f0c-b31a-d4a466b7ea84"), "اهواز", 11 },
                    { 340, new Guid("00e8be9f-aa07-41fb-80e2-68dc3368ad60"), "حميديه", 11 },
                    { 339, new Guid("b1c000fe-9b72-4aff-a613-e27bd9272bca"), "حمزه", 11 },
                    { 338, new Guid("386b9e10-b528-4206-a2c2-ad4e8fbb51e2"), "حسينيه", 11 },
                    { 337, new Guid("acbd3171-42db-45ad-a5ac-1386ae29c1b0"), "حر", 11 },
                    { 336, new Guid("f100d3df-c255-4aa9-a7b0-91647f50f3a1"), "جنت مکان", 11 },
                    { 335, new Guid("38b5904c-82de-44cf-8127-85bd73ff8edf"), "جايزان", 11 },
                    { 334, new Guid("e84aa1ad-425a-49b5-a0ce-3321905c533f"), "تشان", 11 },
                    { 333, new Guid("622c575f-31bc-434e-b143-e1539b5a380c"), "ترکالکي", 11 },
                    { 332, new Guid("521d0224-e2c3-49de-8fb5-efb2376e81b0"), "بيدروبه", 11 },
                    { 331, new Guid("76e11906-0a03-44f0-8d07-f33a722caf7b"), "بهبهان", 11 },
                    { 330, new Guid("e1fc41d8-835a-4bfc-bcc5-312e15ac5fd4"), "بندر ماهشهر", 11 },
                    { 329, new Guid("bb39f9e1-d18d-4b8f-8b7e-c70d100e41d5"), "بندر امام خميني", 11 },
                    { 328, new Guid("fa61d1fe-5352-4622-b275-f682ecc1c212"), "بستان", 11 },
                    { 327, new Guid("4f3ab093-299f-4405-a67f-72c5e73f20ce"), "باغ ملک", 11 },
                    { 326, new Guid("54583562-3f22-4acb-88a9-fd79e3aae6f4"), "ايذه", 11 },
                    { 324, new Guid("e5da4c3d-ffd6-4a39-8e8d-08e870a11776"), "انديمشک", 11 },
                    { 380, new Guid("887a12e5-7a3d-4a4e-b342-a076a2c879c8"), "هنديجان", 11 },
                    { 371, new Guid("8db8f10c-1809-4652-a209-31fe2ceb9889"), "مسجد سليمان", 11 },
                    { 382, new Guid("23f9cb7e-2390-4b60-b82d-e5041383e323"), "ويس", 11 },
                    { 436, new Guid("6aee3d66-c37c-4ba7-8b3e-e380dc15e67b"), "زنجان", 13 },
                    { 435, new Guid("33bf8d07-69c9-4f51-a1ad-c58ff35a1eda"), "زرين رود", 13 },
                    { 434, new Guid("19bf5f2a-6177-4377-9aed-e027fc9c1a71"), "زرين آباد", 13 },
                    { 433, new Guid("983013c6-9c26-4f2b-90ef-af5a3ba05337"), "دندي", 13 },
                    { 432, new Guid("11e86f59-3456-4455-9a6d-85faddaf6c4b"), "خرمدره", 13 },
                    { 431, new Guid("e39070eb-3f60-496c-a3f4-d0a2c55d670f"), "حلب", 13 },
                    { 430, new Guid("42543183-5f29-4985-b6fa-603b584dc9ed"), "ارمخانخانه", 13 },
                    { 381, new Guid("b3850e6e-a949-432d-af54-3be9eaaba15e"), "هويزه", 11 },
                    { 428, new Guid("f9b12706-2d77-4426-a5f6-8034c756cd2a"), "آب بر", 13 },
                    { 427, new Guid("52f45e83-9d60-4f9c-969a-45f0450c8216"), "کلمه", 12 },
                    { 426, new Guid("661e17fa-4b58-4251-9af9-5d915d7afa2e"), "کاکي", 12 },
                    { 425, new Guid("ed13f571-d641-45fd-95e5-652c31c7108b"), "چغادک", 12 },
                    { 424, new Guid("4a620a8b-a55f-4fa1-8784-3370ca7c032d"), "وحدتيه", 12 },
                    { 423, new Guid("a416bc19-3a60-4e0b-a947-07a7d382e582"), "نخل تقي", 12 },
                    { 422, new Guid("2408c875-dd22-4118-8c6f-ba218919c220"), "عسلويه", 12 },
                    { 437, new Guid("a8475d69-0c9f-4347-b6cf-1b910a9f1798"), "سجاس", 13 },
                    { 421, new Guid("ff38476f-1cea-4008-a075-b2db8fc14289"), "شنبه", 12 },
                    { 438, new Guid("f13b47be-2ff5-4068-805c-dbb1c47ce089"), "سلطانيه", 13 },
                    { 440, new Guid("0a11236b-4145-4fce-abb2-f9a7854a4bdf"), "صائين قلعه", 13 },
                    { 455, new Guid("5340df51-043b-444c-b94b-186602e9daf4"), "تاتار عليا", 14 },
                    { 454, new Guid("ec8fa059-692f-46f7-abd4-babdd7e56462"), "بندر گز", 14 },
                    { 453, new Guid("6ee71a37-f8d8-41a8-9903-25092a21c291"), "بندر ترکمن", 14 },
                    { 452, new Guid("4ce406a0-7616-47b1-8f74-3011d2809414"), "اينچه برون", 14 },
                    { 451, new Guid("6339d724-d544-4f33-be7d-26562e991834"), "انبار آلوم", 14 },
                    { 450, new Guid("93ce36c9-0b98-4f95-bd6d-55d389cebd3b"), "آق قلا", 14 },
                    { 449, new Guid("2ab1a77b-bbc7-4afd-974a-ecdd514ef834"), "آزاد شهر", 14 },
                    { 448, new Guid("3727e68f-7d60-4328-b285-d48d56e2243a"), "گرماب", 13 },
                    { 447, new Guid("86afcd5f-2ab7-4477-8d74-67f736742f4e"), "کرسف", 13 },
                    { 446, new Guid("c5891ad4-9cde-4fa7-a854-ed8468185848"), "چورزق", 13 },
                    { 445, new Guid("d99197c0-b0e9-4b55-9799-4a1acd2712be"), "هيدج", 13 },
                    { 444, new Guid("a30e22b9-128f-4195-b649-29d601442cda"), "نيک پي", 13 },
                    { 443, new Guid("bda4d73f-2953-4017-a972-e0e16193c226"), "نوربهار", 13 },
                    { 442, new Guid("5562897c-9148-49b0-a391-19b8f71b4f5f"), "ماه نشان", 13 },
                    { 441, new Guid("a501d4be-ba8b-400d-904e-c82f06f37439"), "قيدار", 13 },
                    { 439, new Guid("1471bb2f-2dfb-4e17-9347-93e0c3a3898a"), "سهرورد", 13 },
                    { 420, new Guid("060a7290-5213-4bdd-812f-f520802c5e4b"), "شبانکاره", 12 },
                    { 429, new Guid("17b126ac-c6ef-4860-964d-c0331aef1d5f"), "ابهر", 13 },
                    { 418, new Guid("06b2b847-97c0-475a-be33-b08cb48acb5e"), "سعد آباد", 12 },
                    { 397, new Guid("6e7d443c-22e1-469e-bd8c-62f735cdd620"), "اهرم", 12 },
                    { 396, new Guid("b90a7160-ed5b-40b6-a800-0ae2fffc6022"), "انارستان", 12 },
                    { 395, new Guid("8cdf9959-5209-4d75-9ea2-8106869fde2f"), "امام حسن", 12 },
                    { 394, new Guid("8c243b9c-d36a-4b4a-a6eb-64948432a9f8"), "آبپخش", 12 },
                    { 393, new Guid("c99e91f6-5515-4196-bc76-e275c92d7e93"), "آبدان", 12 },
                    { 392, new Guid("eb25b13a-8916-4d57-b5ea-da996bab3a6a"), "آباد", 12 },
                    { 391, new Guid("992d1ce5-d71d-49cc-9ad2-d6f160651aad"), "گوريه", 11 },
                    { 419, new Guid("3a1d83b2-67c9-4cd8-93b8-e8b3d0f92cd6"), "سيراف", 12 },
                    { 389, new Guid("b869051a-9831-4c26-bd40-57dbe2a111d6"), "گتوند", 11 },
                    { 388, new Guid("d21284a4-a479-4eb1-a043-c0addb7ad104"), "کوت عبدالله", 11 },
                    { 387, new Guid("4522eb3c-013b-4b8c-b89b-9c742cb1f606"), "کوت سيدنعيم", 11 },
                    { 386, new Guid("4b2ee664-90fa-48ff-91ab-a84ac8c0461a"), "چوئبده", 11 },
                    { 385, new Guid("02c96958-95bf-401a-8ec2-56cba20e660d"), "چمران", 11 },
                    { 384, new Guid("1e3cd8b9-f0c4-454c-87db-67932b127a1e"), "چم گلک", 11 },
                    { 383, new Guid("f832d8e4-6d78-4e51-9b09-dc16f4795525"), "چغاميش", 11 },
                    { 398, new Guid("ce9f5fe7-1a4a-418f-9c0b-2414c403ef89"), "بادوله", 12 },
                    { 399, new Guid("719dcf9c-48c2-40f4-9394-8208887f5612"), "برازجان", 12 },
                    { 390, new Guid("d812ad7a-e4d7-44c2-808b-9bef4dbe4a12"), "گلگير", 11 },
                    { 401, new Guid("f06ef718-d5fb-43fc-be6a-37a16b0670a7"), "بردستان", 12 },
                    { 400, new Guid("26b228bb-141b-43eb-bda7-169cc0e5d500"), "بردخون", 12 },
                    { 417, new Guid("4d90a9b1-b8e9-4581-9d7b-f94beaca1bff"), "ريز", 12 },
                    { 416, new Guid("231dbb4c-8bdd-4b36-8a6d-4a00e48cc80e"), "دوراهک", 12 },
                    { 415, new Guid("9dc90671-1e46-4dde-b4a4-ff9f55ef3e07"), "دلوار", 12 },
                    { 413, new Guid("5e5fcce6-1bab-4de7-877b-45f570244faf"), "خورموج", 12 },
                    { 412, new Guid("77027590-7598-4be4-82e4-228b04a0d860"), "خارک", 12 },
                    { 411, new Guid("05dfb02f-c6a2-4393-a652-c9371c531fd7"), "جم", 12 },
                    { 410, new Guid("048eef50-d206-43c5-a0a0-9b4de922ee7a"), "تنگ ارم", 12 },
                    { 414, new Guid("1a04b218-6ebc-4b6b-abef-ee7866bb58fd"), "دالکي", 12 },
                    { 408, new Guid("47f816d0-a5f5-4374-abb0-7aac621afbc4"), "بوشهر", 12 },
                    { 407, new Guid("ee8d4012-7b6f-4530-a069-c2f8cc2537aa"), "بنک", 12 },
                    { 406, new Guid("f324b9a6-afe9-464e-aa21-c7ffd6281828"), "بندر گناوه", 12 },
                    { 405, new Guid("e0cd5aa7-dc63-4fe0-a763-8531f804ebbd"), "بندر کنگان", 12 },
                    { 404, new Guid("91b5cd72-3794-4a80-97e6-cb9b4e36bc76"), "بندر ريگ", 12 },
                    { 403, new Guid("df523549-26e6-4f3f-a282-a7166e5de6f5"), "بندر ديلم", 12 },
                    { 409, new Guid("5987d456-e787-49f7-8913-00d97e3044c4"), "بوشکان", 12 },
                    { 402, new Guid("77e98e2f-a148-4820-8c49-9e3d731788bf"), "بندر دير", 12 }
                });

            migrationBuilder.InsertData(
                table: "Code",
                columns: new[] { "CodeID", "CodeGroupID", "CodeGUID", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 7, 3, new Guid("2b451e4c-c9b8-415a-bcb4-05da15447b89"), "زن", "Female" },
                    { 6, 2, new Guid("cf5a1929-db68-43d6-8fc7-e3b7ccc51678"), "نماینده یک واحد، آموزشگاه یا دیگر مجوز ها هستم", "نماینده یک واحد، آموزشگاه یا دیگر مجوز ها هستم" },
                    { 5, 2, new Guid("2383b70e-f41f-4b67-b0c9-c48706a70a46"), "نماینده یک شرکت هستم", "نماینده یک شرکت هستم" },
                    { 2, 1, new Guid("3f009296-db7a-4fde-a659-4ca1541a2504"), "jpg", "image/jpg" },
                    { 3, 1, new Guid("3209341a-07d4-437b-9301-2d0f909ad713"), "jpeg", "image/jpeg" },
                    { 1, 1, new Guid("fc20e91f-1eb1-4912-87be-1708f2706367"), "png", "image/png" },
                    { 8, 3, new Guid("6e48b657-2c83-4481-a9c5-009ffe10158b"), "مرد", "Male" },
                    { 4, 2, new Guid("09cb21ac-d99e-42ba-904d-337bdd561e6e"), "به صورت شخصی فعالیت میکنم", "به صورت شخصی فعالیت میکنم" },
                    { 9, 4, new Guid("b5d74bda-849b-427c-a6e0-463c1e5f615b"), "در انتظار تایید", "WaitingForAcceptance" },
                    { 18, 7, new Guid("17fd4e57-b4ad-43e1-86ed-faa934d722b8"), "تایید شده", "Accepted" },
                    { 11, 4, new Guid("2b9d07c8-5535-495e-8557-da32acb58600"), "انجام شده", "Done" },
                    { 12, 4, new Guid("61960336-e912-4658-9ab3-59f4c58e0b23"), "لغو شده", "Canceled" },
                    { 13, 4, new Guid("46a09d81-c57f-4655-a8f5-027c66a6cfb1"), "ادمین", "Admin" },
                    { 14, 4, new Guid("91b3cdab-39c1-40fb-b077-a2d6e611f50a"), "سرویس گیرنده", "Client" },
                    { 15, 4, new Guid("959b10a3-b8ed-4a9d-bdf3-17ec9b2ceb15"), "سرویس دهنده", "Contractor" },
                    { 16, 6, new Guid("a05c4f54-5999-42b9-a36f-6a04aa7cd476"), "حقوقی", "Legal" },
                    { 17, 6, new Guid("ccef9d1f-343b-442a-a041-1908e4cbc235"), "حقیقی", "Natural" },
                    { 19, 7, new Guid("f4b3ed17-b25b-4f87-a6f3-7c48dfa1f103"), "در انتظار تایید", "WaitingForAcceptance" },
                    { 20, 7, new Guid("6351b22a-74dc-4d54-81aa-23a06beb2d36"), "لغو شده", "Canceled" },
                    { 10, 4, new Guid("10afdac9-a075-40e1-9207-1813befcf4d6"), "در حال انجام", "Doing" }
                });

            migrationBuilder.InsertData(
                table: "SMSProviderSetting",
                columns: new[] { "SMSProviderSettingID", "APIKey", "Password", "SMSProviderID", "Username" },
                values: new object[] { 1, "532B514B4E305A456D5A737669687A5161444B355544557462576650737634545959532F76517A572B65733D", "raffi1234", 1, "raffi.hovanes@gmail.com" });

            migrationBuilder.InsertData(
                table: "SMSTemplate",
                columns: new[] { "SMSTemplateID", "Name", "SMSProviderSettingID" },
                values: new object[,]
                {
                    { 1, "VerifyAccount", 1 },
                    { 2, "RegisterMessage", 1 },
                    { 3, "NewOrderNotification", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FirstName", "GenderCodeID", "IsActive", "IsRegister", "LastName", "ModifiedDate", "PhoneNumber", "ProfileDocumentID", "RegisteredDate", "RoleID", "UserGUID" },
                values: new object[,]
                {
                    { 1, "mahdiroudaki@hotmail.com", "سید مهدی", 8, true, true, "رودکی", new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(1222), "09126842446", null, new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(678), 1, new Guid("ab3ecdab-8c23-4648-88a5-5c9c22e70a05") },
                    { 2, "roozbehshamekhi@hotmail.com", "روزبه", 8, true, true, "شامخی", new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3287), "09128277075", null, new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3265), 3, new Guid("2ebc1527-ee8b-4d4a-bc04-109dcfc53f85") },
                    { 3, "mahdiih@ymail.com", "مهدی", 8, true, true, "حکمی زاده", new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3345), "09199390494", null, new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3341), 1, new Guid("d3e8a320-2cdd-45bb-abfa-b38f7b47a31f") },
                    { 4, "white.luciferrr@gmail.com", "محمد", 8, true, true, "میرزایی", new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3359), "09147830093", null, new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3355), 1, new Guid("b4acfdeb-9522-4f10-8f4e-aed27c614a42") },
                    { 5, "raffi.hovanes@gmail.com", "رافی", 8, true, true, "اوانسیان", new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3501), "09125344652", null, new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3497), 1, new Guid("c9b3340e-22fc-40a7-9618-98b5bacbead8") },
                    { 6, "dead.hh98@gmail.com", "حامد", 8, true, true, "حقیقیان", new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3515), "09108347428", null, new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(3511), 2, new Guid("990f1dbb-c595-4ebe-895e-f7d7ee584cc1") }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminGUID", "ModifiedDate", "UserID" },
                values: new object[,]
                {
                    { 1, new Guid("883b726f-baec-4cee-b2d4-3d15cbecf577"), new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(5883), 1 },
                    { 2, new Guid("bee2abd9-846c-4207-9c8b-60f4221ab817"), new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(7371), 3 },
                    { 3, new Guid("104aab39-38d1-47f4-8ef6-225d480c5320"), new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(7400), 4 },
                    { 4, new Guid("5f0ffe90-6276-48c7-8007-be176f55743e"), new DateTime(2020, 7, 19, 10, 55, 21, 795, DateTimeKind.Local).AddTicks(7405), 5 }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientID", "CityID", "ClientGUID", "ModifiedDate", "UserID" },
                values: new object[] { 1, 751, new Guid("29db54b0-4936-4a1b-a12c-d646ff596de6"), new DateTime(2020, 7, 19, 10, 55, 21, 796, DateTimeKind.Local).AddTicks(1490), 2 });

            migrationBuilder.InsertData(
                table: "Contractor",
                columns: new[] { "ContractorID", "AboutMe", "Address", "AverageRate", "BusinessTypeCodeID", "CityID", "ContractorGUID", "Credit", "Instagram", "Latitude", "Longitude", "ModifiedDate", "Telephone", "UserID", "Website" },
                values: new object[] { 1, null, null, null, 4, 751, new Guid("8087a607-8021-45ad-85eb-bbcd6bbda11c"), 0, null, "111", "222", new DateTime(2020, 7, 19, 10, 55, 21, 797, DateTimeKind.Local).AddTicks(4178), null, 6, null });

            migrationBuilder.InsertData(
                table: "ContractorCategory",
                columns: new[] { "ContractorCategoryID", "CategoryID", "ContractorCategoryGUID", "ContractorID" },
                values: new object[] { 1, 3, new Guid("1ec62a66-0e16-4165-808c-399b673ad18c"), 1 });

            migrationBuilder.InsertData(
                table: "ContractorCategory",
                columns: new[] { "ContractorCategoryID", "CategoryID", "ContractorCategoryGUID", "ContractorID" },
                values: new object[] { 2, 4, new Guid("a5c03712-2748-4799-a03d-85f89f9d910e"), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserID",
                table: "Admin",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_DocumentID",
                table: "Advertisement",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Application_DocumentID",
                table: "Application",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ActiveIconDocumentID",
                table: "Category",
                column: "ActiveIconDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CoverDocumentID",
                table: "Category",
                column: "CoverDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_InactiveIconDocumentID",
                table: "Category",
                column: "InactiveIconDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryID",
                table: "Category",
                column: "ParentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_QuadMenuDocumentID",
                table: "Category",
                column: "QuadMenuDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_SecondPageCoverDocumentID",
                table: "Category",
                column: "SecondPageCoverDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTag_CategoryID",
                table: "CategoryTag",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTag_TagID",
                table: "CategoryTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_OrderRequestID",
                table: "ChatMessage",
                column: "OrderRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_UserID",
                table: "ChatMessage",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceID",
                table: "City",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_CityID",
                table: "Client",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_UserID",
                table: "Client",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Code_Code_CGID",
                table: "Code",
                column: "CodeGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_UserID",
                table: "Complaint",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_ContactUsBusinessTypeCodeID",
                table: "ContactUs",
                column: "ContactUsBusinessTypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_BusinessTypeCodeID",
                table: "Contractor",
                column: "BusinessTypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_CityID",
                table: "Contractor",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_UserID",
                table: "Contractor",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorCategory_CategoryID",
                table: "ContractorCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorCategory_ContractorID",
                table: "ContractorCategory",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDiscount_ContractorID",
                table: "ContractorDiscount",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDiscount_PublicDiscountID",
                table: "ContractorDiscount",
                column: "PublicDiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDocument_ContractorID",
                table: "ContractorDocument",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDocument_DocumentID",
                table: "ContractorDocument",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDocument_TitleCodeID",
                table: "ContractorDocument",
                column: "TitleCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Document_Document_TypeCodeID",
                table: "Document",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CategoryID",
                table: "Order",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientID",
                table: "Order",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ContractorID",
                table: "Order",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StateCodeID",
                table: "Order",
                column: "StateCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequest_ContractorID",
                table: "OrderRequest",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequest_OrderID",
                table: "OrderRequest",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequest_StateCodeID",
                table: "OrderRequest",
                column: "StateCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ContractorID",
                table: "Payment",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentProviderSettingID",
                table: "Payment",
                column: "PaymentProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProviderSetting_PaymentProviderID",
                table: "PaymentProviderSetting",
                column: "PaymentProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_PermissionGroupID",
                table: "Permission",
                column: "PermissionGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_DocumentID",
                table: "Post",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_SliderCodeId",
                table: "Post",
                column: "SliderCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserID",
                table: "Post",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_CategoryID",
                table: "PostCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_PostID",
                table: "PostCategory",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_CommentID",
                table: "PostComment",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostID",
                table: "PostComment",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_PostID",
                table: "PostTag",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagID",
                table: "PostTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateDiscount_ContractorID",
                table: "PrivateDiscount",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateDiscount_TypeCodeID",
                table: "PrivateDiscount",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_PublicDiscount_TypeCodeID",
                table: "PublicDiscount",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_RolePermission_RP_PermissionID",
                table: "RolePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_RolePermission_RP_RoleID",
                table: "RolePermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSProviderSetting_SMSProviderID",
                table: "SMSProviderSetting",
                column: "SMSProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSProviderNumber_SPN_SPCID",
                table: "SMSProviderSettingNumber",
                column: "SMSProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSResponse_SMS_STID",
                table: "SMSResponse",
                column: "SMSTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSResponse_UserID",
                table: "SMSResponse",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSTemplate_ST_SSID",
                table: "SMSTemplate",
                column: "SMSProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestion_UserID",
                table: "Suggestion",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Token_RoleCodeID",
                table: "Token",
                column: "RoleCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Token_UserID",
                table: "Token",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TypeCodeID",
                table: "Transaction",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_GenderCodeID",
                table: "User",
                column: "GenderCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfileDocumentID",
                table: "User",
                column: "ProfileDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserPermission_UP_PermissionID",
                table: "UserPermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_UserID",
                table: "UserPermission",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "CategoryTag");

            migrationBuilder.DropTable(
                name: "ChatMessage");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "ContractorCategory");

            migrationBuilder.DropTable(
                name: "ContractorDiscount");

            migrationBuilder.DropTable(
                name: "ContractorDocument");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PostCategory");

            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "PrivateDiscount");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "SMSProviderSettingNumber");

            migrationBuilder.DropTable(
                name: "SMSResponse");

            migrationBuilder.DropTable(
                name: "Suggestion");

            migrationBuilder.DropTable(
                name: "Token");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "UserPermission");

            migrationBuilder.DropTable(
                name: "OrderRequest");

            migrationBuilder.DropTable(
                name: "PublicDiscount");

            migrationBuilder.DropTable(
                name: "PaymentProviderSetting");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "SMSTemplate");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PaymentProvider");

            migrationBuilder.DropTable(
                name: "SMSProviderSetting");

            migrationBuilder.DropTable(
                name: "PermissionGroup");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Contractor");

            migrationBuilder.DropTable(
                name: "SMSProvider");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Code");

            migrationBuilder.DropTable(
                name: "CodeGroup");
        }
    }
}
