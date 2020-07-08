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
                    ViewCount = table.Column<int>(nullable: false),
                    LikeCount = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Abstract = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsSuggested = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsInSlider = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
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
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((0))")
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
                    Message = table.Column<string>(nullable: false),
                    OfferedPrice = table.Column<long>(nullable: false),
                    IsAllow = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
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
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "SecondPageCoverDocumentID", "Sort" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), null, null, "سایت اصلی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(5961), null, null, null, 1 },
                    { 2, null, null, new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), null, null, "وبلاگ", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(7705), null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "CodeGroup",
                columns: new[] { "CodeGroupID", "CodeGroupGUID", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("5b739a57-164e-4b39-8b1c-1129bc9d8991"), "نوع فایل", "FilepondType" },
                    { 2, new Guid("2d9c9e83-39eb-42d7-b71f-ef26002c8470"), "نوع کسب و کار", "BusinessType" },
                    { 3, new Guid("a76da3ba-d12a-42c4-b7e1-732d0990af70"), "جنسیت", "Gender" },
                    { 4, new Guid("39c56245-8e42-4cef-8ddd-5e4c17782e8b"), "وضعیت سفارش", "OrderState" },
                    { 5, new Guid("7e9db57a-0c09-47ff-98b5-f49363beff67"), "نقش", "Role" },
                    { 6, new Guid("107a7244-6e66-4369-8ba6-dfb0636642c4"), "نوع کسب و کار بخش ارتباط با ما", "ContactUsBusinessType" }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceID", "Name", "ProvinceGUID" },
                values: new object[,]
                {
                    { 19, "اصفهان", new Guid("65d62146-26ae-4250-b838-71e2bb6a8423") },
                    { 20, "ايلام", new Guid("4ebcbcf8-cc09-4dab-95fa-de4dfa13b693") },
                    { 21, "تهران", new Guid("54955795-30f4-4372-91d2-7eaba3e02570") },
                    { 22, "آذربايجان شرقي", new Guid("c95709f0-0cda-4739-a4db-fb4403ec3124") },
                    { 23, "فارس", new Guid("ac1a0414-7ad7-4984-87e9-910c7031e52f") },
                    { 24, "کرمانشاه", new Guid("25e59642-63bb-4c75-9a82-b4786901b6a5") },
                    { 28, "همدان", new Guid("7222a2dd-45c1-4646-9f6b-56048fce86fa") },
                    { 26, "مرکزي", new Guid("0f0fb38b-8986-4436-bd28-8e2081fd09d0") },
                    { 27, "گيلان", new Guid("a5250fe3-6729-47a4-9438-dcc40a2b8513") },
                    { 18, "اردبيل", new Guid("fbb44744-9921-44d3-81a8-f503cd21b83d") },
                    { 29, "کرمان", new Guid("76610ed4-c3e9-4b62-8d8e-1c60f1706c9e") },
                    { 30, "سمنان", new Guid("a8cf26ab-3f6f-4501-b738-25b17df8a00c") },
                    { 31, "کهگيلويه و بويراحمد", new Guid("ef877f2f-505f-41ee-a2d6-1407f4d6c63d") },
                    { 25, "هرمزگان", new Guid("bf5616cd-d4ff-4d78-be56-17e4572a0661") },
                    { 17, "لرستان", new Guid("658d6907-6bc8-400c-893a-2572dddf4e1b") },
                    { 14, "گلستان", new Guid("c4394c1d-d2e9-414b-bac3-2e2881121dfe") },
                    { 15, "مازندران", new Guid("81a850cd-b180-4955-95ab-30cd93c07f29") },
                    { 1, "يزد", new Guid("745ee568-36ee-47d3-90b9-ecf6a39243c9") },
                    { 2, "چهار محال و بختياري", new Guid("d36409c2-2861-45dd-b8db-a6f291422a6a") },
                    { 3, "خراسان شمالي", new Guid("feb0b405-b6d5-4bb0-bab8-99902db44b6c") },
                    { 4, "البرز", new Guid("38d912fe-0d2b-4948-9f8f-fcb353fc8827") },
                    { 5, "قم", new Guid("3091ebe0-df52-48df-aafd-5187c89e6c85") },
                    { 16, "قزوين", new Guid("bbe41cc9-d5dd-4f3f-9aea-8c2266d10117") },
                    { 7, "آذربايجان غربي", new Guid("f5b2a1f4-c46b-407f-b97a-ab649d23b3b1") },
                    { 6, "کردستان", new Guid("c95d61bf-82a0-4de3-acb0-a2d83f31750a") },
                    { 9, "سيستان و بلوچستان", new Guid("cbff05bc-1132-4993-b622-15d74a89ddf7") },
                    { 10, "خراسان جنوبي", new Guid("5442e4d3-53a4-4590-9004-1e10a726e301") },
                    { 11, "خوزستان", new Guid("eaf8f0e4-7b25-4a20-a0aa-979fbff30a51") },
                    { 12, "بوشهر", new Guid("a0087e18-1e15-4a3b-b5a3-c2fac44473d0") },
                    { 13, "زنجان", new Guid("f52b39fc-41aa-4d34-8040-0b3978c4198d") },
                    { 8, "خراسان رضوي", new Guid("02f71c1a-d942-42d1-b99a-5368c20b38ab") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "DisplayName", "ModifiedDate", "Name", "RoleGUID" },
                values: new object[,]
                {
                    { 3, "سرویس گیرنده", new DateTime(2020, 7, 6, 0, 20, 47, 168, DateTimeKind.Local).AddTicks(213), "Client", new Guid("e326b332-6d38-453e-abf1-98e7210ddeed") },
                    { 1, "ادمین", new DateTime(2020, 7, 6, 0, 20, 47, 158, DateTimeKind.Local).AddTicks(8530), "Admin", new Guid("d663d37a-1ce4-4d12-93e4-0d7f5a91aeb0") },
                    { 2, "سرویس دهنده", new DateTime(2020, 7, 6, 0, 20, 47, 167, DateTimeKind.Local).AddTicks(9930), "Contractor", new Guid("21a4bd0d-b6e7-4db6-9585-c25138dfe2c6") }
                });

            migrationBuilder.InsertData(
                table: "SMSProvider",
                columns: new[] { "SMSProviderID", "Name" },
                values: new object[] { 1, "Kavenegar" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "SecondPageCoverDocumentID", "Sort" },
                values: new object[,]
                {
                    { 3, null, null, new Guid("e3b1e3a1-4d79-454d-8b1f-6c9e24e290b2"), null, null, "خانه", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(7754), 1, null, null, 1 },
                    { 4, null, null, new Guid("8270725f-1c5e-4f7a-ae91-10a533221102"), null, null, "حمل و نقل", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(7769), 1, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 826, new Guid("94cd3b54-c5e9-4b88-8ca5-84c5377e877e"), "ليلان", 22 },
                    { 825, new Guid("cbbe98b9-bc9d-41bd-8ae2-2dc378dc48cb"), "قره آغاج", 22 },
                    { 824, new Guid("94f3713b-0eae-4498-a3c5-b87ac9c61b63"), "عجب شير", 22 },
                    { 823, new Guid("e2de7de7-80ce-4570-bd1f-a12f44af1b93"), "صوفيان", 22 },
                    { 822, new Guid("ee5de72f-b683-4eea-b905-d1c3bcf348fd"), "شهر جديد سهند", 22 },
                    { 821, new Guid("5879d252-01f5-4424-951a-b651211bf14e"), "شند آباد", 22 },
                    { 820, new Guid("d436060b-8ce2-4599-8df4-cdb943013560"), "شرفخانه", 22 },
                    { 819, new Guid("0ee4e5bf-43de-4897-8635-84c62bde5f8f"), "شربيان", 22 },
                    { 818, new Guid("19e07cc2-5bc1-4114-8739-e65304537f2d"), "شبستر", 22 },
                    { 817, new Guid("76e7cf68-a6c9-48d0-8d01-284bc0a89f35"), "سيه رود", 22 },
                    { 816, new Guid("12c37d82-3190-4aa3-a43b-fef09b251970"), "سيس", 22 },
                    { 815, new Guid("a0448ea6-2189-4276-b7c6-85c5f188ed03"), "سردرود", 22 },
                    { 814, new Guid("a35b9276-30ac-437d-b428-a57f0746d7d6"), "سراب", 22 },
                    { 813, new Guid("364efab2-a6a6-4312-a9b1-f91a1e50b4bb"), "زنوز", 22 },
                    { 812, new Guid("265e8b45-5275-45c9-b0d8-b28bde59edc2"), "زرنق", 22 },
                    { 827, new Guid("51685855-fde5-4cc4-871d-996b0befb7dc"), "مبارک شهر", 22 },
                    { 828, new Guid("45178011-5476-468e-8b35-cd0296dd5a4e"), "مراغه", 22 },
                    { 829, new Guid("5cc0d8f1-c628-4895-81d4-eecbb72fa57d"), "مرند", 22 },
                    { 830, new Guid("b0ffab0e-1b6b-47fc-b204-43296af92082"), "ملکان", 22 },
                    { 846, new Guid("cb4a08b5-cb93-43e2-aa2c-1dfdf937a5bf"), "گوگان", 22 },
                    { 845, new Guid("16027765-b03f-4233-9d8f-29a957dd329d"), "کوزه کنان", 22 },
                    { 844, new Guid("6f81c7ae-9f2b-45db-9fe7-483457e4cb77"), "کليبر", 22 },
                    { 843, new Guid("fdbc021a-a850-451b-bfa2-7590d507875a"), "کلوانق", 22 },
                    { 842, new Guid("465b4c80-7ec9-41fe-a6fd-5127dfacb1d9"), "کشکسراي", 22 },
                    { 841, new Guid("22ff3e90-50b6-4ef0-815b-4df36a4f5e3e"), "يامچي", 22 },
                    { 840, new Guid("c831d572-a6e5-4795-b578-d096ac438787"), "ورزقان", 22 },
                    { 811, new Guid("1588414d-572c-4b6a-aa6e-2374abb6b189"), "دوزدوزان", 22 },
                    { 839, new Guid("5d550cd5-706d-4cd3-b387-bf6deb3cb9c2"), "وايقان", 22 },
                    { 837, new Guid("c6a70b4b-5962-4420-be24-5d2095a85976"), "هشترود", 22 },
                    { 836, new Guid("190b87cb-a208-4271-b45b-ddc68c527abf"), "هريس", 22 },
                    { 835, new Guid("c9df2c6a-67cb-4cc1-ab10-694f2b22a901"), "هاديشهر", 22 },
                    { 834, new Guid("f9ea599b-eee9-4a83-abeb-adea6009499f"), "نظرکهريزي", 22 },
                    { 833, new Guid("33622c2e-a3b5-4fcb-b1d3-f6d134b6ac06"), "ميانه", 22 },
                    { 832, new Guid("5871d83d-d083-467a-88da-c90df1a173f5"), "مهربان", 22 },
                    { 831, new Guid("6c9af9f9-2948-470c-b391-d7869309819a"), "ممقان", 22 },
                    { 838, new Guid("fbe1e441-a223-4709-aaea-2b66fdedd7e1"), "هوراند", 22 },
                    { 810, new Guid("157f6e78-4270-466b-8a36-5a0a60047c3f"), "خواجه", 22 },
                    { 809, new Guid("17397086-5d1c-4394-ade0-0b8ab2f71951"), "خمارلو", 22 },
                    { 808, new Guid("7ca9ce3d-aaa8-4e35-ac2a-aeba5a6dfdef"), "خسروشاه", 22 },
                    { 787, new Guid("d996a8dd-5259-40b6-af87-1d7c991ceb72"), "آقکند", 22 },
                    { 786, new Guid("12141fc2-7196-40f7-a324-4f3b16d56570"), "آذرشهر", 22 },
                    { 785, new Guid("43936301-e965-4626-b35f-46c6b35d1442"), "آبش احمد", 22 },
                    { 784, new Guid("71d1ae9c-8ef5-4ce5-9587-abc84c173ce7"), "گلستان", 21 },
                    { 783, new Guid("9ecc58bd-c82f-4ad5-af0a-5826c987a991"), "کيلان", 21 },
                    { 782, new Guid("0adbd14f-4880-47a7-9907-c976889356bf"), "کهريزک", 21 },
                    { 781, new Guid("ad861c92-a861-4b9a-a624-ad085f568bdf"), "چهاردانگه", 21 },
                    { 780, new Guid("06c4fe1f-6365-413b-9e48-671317a737de"), "پيشوا", 21 },
                    { 779, new Guid("8c27aa28-6bdd-4acc-bf40-bed4b3edf2eb"), "پرديس", 21 },
                    { 778, new Guid("9508accb-faca-4a56-beca-16e89a2ff632"), "پاکدشت", 21 },
                    { 777, new Guid("09de0825-1783-49de-a816-e82825f74224"), "ورامين", 21 },
                    { 776, new Guid("5704ab6a-9a7c-4141-84c5-d012f74fe583"), "وحيديه", 21 },
                    { 775, new Guid("c3c8fbda-ec4f-4e64-945c-54bf63081b83"), "نصيرشهر", 21 },
                    { 774, new Guid("e65d79c3-b3f2-4d73-ae1d-85c8d2f48700"), "نسيم شهر", 21 },
                    { 773, new Guid("061372f1-7dff-448c-8cd2-3e21a12883bf"), "ملارد", 21 },
                    { 788, new Guid("7b4ce935-5ce0-4631-89dc-1534a50ee774"), "آچاچي", 22 },
                    { 789, new Guid("7934254a-e8af-49b4-b48d-c6f76d0daac0"), "اسکو", 22 },
                    { 790, new Guid("ab2e7899-547a-48cf-8393-c114654b65d6"), "اهر", 22 },
                    { 791, new Guid("5fcf631e-c8e5-4f6e-a485-08c745e9546c"), "ايلخچي", 22 },
                    { 807, new Guid("4c4ca959-7227-4a2f-a983-bdf7b3f6d0a0"), "خداجو", 22 },
                    { 806, new Guid("0385b8f4-3563-44d5-bc78-f74d782b6e51"), "خامنه", 22 },
                    { 805, new Guid("1bdf8d37-90a2-4977-86af-910bbcc6b5b2"), "خاروانا", 22 },
                    { 804, new Guid("4ef9f046-f6fd-477f-9166-672b47c12078"), "جوان قلعه", 22 },
                    { 803, new Guid("ae273041-e2a6-4838-ad6d-40e7cea6b9d7"), "جلفا", 22 },
                    { 802, new Guid("e41c9d47-cbd4-4cde-ae72-1d52cee71b34"), "تيکمه داش", 22 },
                    { 801, new Guid("1ecaeb7c-e760-435b-b8e0-541c3ab90c0a"), "تيمورلو", 22 },
                    { 847, new Guid("bdeb1a49-0a9d-4fde-8492-5e96099bd6fa"), "آباده", 23 },
                    { 800, new Guid("53715898-7d93-4053-9a1d-4c9df51255b7"), "تسوج", 22 },
                    { 798, new Guid("9ef9d989-959e-412e-a0ee-0dd291d60656"), "ترک", 22 },
                    { 797, new Guid("c546bac8-0435-457d-9707-895fd835191d"), "تبريز", 22 },
                    { 796, new Guid("2c1aeb15-4774-4443-a414-4e15f05e1deb"), "بناب مرند", 22 },
                    { 795, new Guid("12334546-3bed-4651-856d-407ba40856f7"), "بناب", 22 },
                    { 794, new Guid("a1f44125-1e85-4f52-bba6-ef6ab6e8b317"), "بستان آباد", 22 },
                    { 793, new Guid("3f2f433e-ba66-4dc6-8660-d26eeed330e9"), "بخشايش", 22 },
                    { 792, new Guid("a6a4b405-96e7-4485-82ce-7e6e06f48e75"), "باسمنج", 22 },
                    { 799, new Guid("c34d0521-fbcc-4e38-b26e-593a84d88c02"), "ترکمانچاي", 22 },
                    { 848, new Guid("d1cbc9b3-da23-4f75-a832-4e92b470a493"), "آباده طشک", 23 },
                    { 849, new Guid("0a0f82a2-ef9b-40a8-9cfb-25dca868bb83"), "اردکان", 23 },
                    { 850, new Guid("c09bff10-c323-4cd7-99b3-c84dab177e69"), "ارسنجان", 23 },
                    { 905, new Guid("381c79af-e67e-495d-a73f-32209136082f"), "صغاد", 23 },
                    { 904, new Guid("e8485ebc-b4f2-4bb0-8d7a-3609fd7c0d7b"), "شيراز", 23 },
                    { 903, new Guid("2d96fe40-f107-4759-b8a0-27db5c6ee5b5"), "شهر پير", 23 },
                    { 902, new Guid("962cc045-8162-42b9-949e-bbed96f5c670"), "شهر جديد صدرا", 23 },
                    { 901, new Guid("d2a42057-6edd-4ed8-890c-40a01eee86f4"), "ششده", 23 },
                    { 900, new Guid("b37d0caf-fbf8-4cc0-a35d-e341d2ec335c"), "سيدان", 23 },
                    { 899, new Guid("8e2a59bc-d298-4b15-ae04-3a6b8871847b"), "سورمق", 23 },
                    { 898, new Guid("e72a25a0-d4f4-4f64-bfc6-562387f1abcd"), "سلطان شهر", 23 },
                    { 897, new Guid("f1c7c697-8fbb-431a-ab10-d464a655f325"), "سعادت شهر", 23 },
                    { 896, new Guid("f2ae5e71-b67e-4c17-891c-9481cda101c8"), "سروستان", 23 },
                    { 895, new Guid("368799f7-3a3c-4df3-bd74-07f021e99d2d"), "سده", 23 },
                    { 894, new Guid("1d8358f6-fce4-4dae-9318-80e8910f2194"), "زرقان", 23 },
                    { 893, new Guid("ac9881e0-daf7-4995-9aca-2b586e7c0aad"), "زاهد شهر", 23 },
                    { 892, new Guid("34168f13-f593-4670-8a21-33c6ad5d9717"), "رونيز", 23 },
                    { 891, new Guid("a3d3bbb0-4e93-4245-b4c9-55b17e9d8c72"), "رامجرد", 23 },
                    { 906, new Guid("ac342d36-6d2e-43c2-ad1b-95fd91db9bf5"), "صفا شهر", 23 },
                    { 907, new Guid("faf1d90d-6a35-4977-94f0-9e5fe0c83157"), "علامرودشت", 23 },
                    { 908, new Guid("20b3b16f-f474-4b05-b7b7-5ec457132776"), "عماد ده", 23 },
                    { 909, new Guid("de980118-f89f-4158-88a9-c9b8e80748f4"), "فدامي", 23 },
                    { 925, new Guid("aedfe582-2f61-4453-9460-721b3cda8207"), "مرودشت", 23 },
                    { 924, new Guid("994fa285-9e29-4687-bc38-675a4919daad"), "مبارک آباد", 23 },
                    { 923, new Guid("75a3bd3b-4076-4fc0-b0b8-8fa44b3e73fb"), "مادرسليمان", 23 },
                    { 922, new Guid("981e5289-76ac-432e-8c5d-78de3d4c6b8c"), "لپوئي", 23 },
                    { 921, new Guid("13cd962e-a0a9-478c-a819-2799d2d8eb80"), "لطيفي", 23 },
                    { 920, new Guid("af546c9a-eafa-4d9f-a5be-2424d8222d2d"), "لامرد", 23 },
                    { 919, new Guid("89f6a1a0-1535-4a35-b991-b14138aeeab9"), "لار", 23 },
                    { 890, new Guid("bd0a8c76-f8eb-4d27-96d7-5c2da57926ca"), "دژکرد", 23 },
                    { 918, new Guid("94e5248a-d07e-4da8-8c0f-76a2abcfd750"), "قير", 23 },
                    { 916, new Guid("ee9dd035-5412-4ef9-9164-51756770d153"), "قطب آباد", 23 },
                    { 915, new Guid("a6bb4c2a-3fd2-4e41-8962-02a11c57eb48"), "قره بلاغ", 23 },
                    { 914, new Guid("567d2cc0-d6a0-441d-ba33-9134db04ad24"), "قادرآباد", 23 },
                    { 913, new Guid("be37b770-0cd9-45e0-ae6a-7f2a486f1979"), "قائميه", 23 },
                    { 912, new Guid("c29b6fa7-312e-440b-a44a-f1c58c740cb3"), "فيروزآباد", 23 },
                    { 911, new Guid("6e3759c7-fb99-47b4-8fc3-fcff0a84a3ef"), "فسا", 23 },
                    { 910, new Guid("edaa045d-1ee8-4a97-878d-a70962b294e7"), "فراشبند", 23 },
                    { 917, new Guid("01a4a477-e5fe-4401-b82d-a2c8b08d2b0c"), "قطرويه", 23 },
                    { 889, new Guid("2ac736ac-fb7c-48ab-b7b6-6b88d298984d"), "دوزه", 23 },
                    { 888, new Guid("09731ed5-ac96-41bf-a8ae-a8523140af58"), "دوبرجي", 23 },
                    { 887, new Guid("8e732e50-2472-434f-91a7-5b94b74d2027"), "دهرم", 23 },
                    { 866, new Guid("819cd9cf-39d6-4cfe-9527-1c938d284dbb"), "بوانات", 23 },
                    { 865, new Guid("50ab678f-2ca8-4448-b771-18ba388ba66e"), "بهمن", 23 },
                    { 864, new Guid("62247154-b6f1-4cd7-a6fd-1d8b4fde6f04"), "بنارويه", 23 },
                    { 863, new Guid("e5189184-9d97-4b62-947e-1ff530bcd5e0"), "بالاده", 23 },
                    { 862, new Guid("3ddd5e2f-3c22-4a53-80c4-0445ac0ce128"), "بابامنير", 23 },
                    { 861, new Guid("e6e70fc4-b986-448b-a8bc-fa50a7f86ef3"), "باب انار", 23 },
                    { 860, new Guid("3e314a99-bde8-41e9-8ea8-673400a78ca6"), "ايزد خواست", 23 },
                    { 867, new Guid("5ab744ae-916e-46e7-a616-a74ff2430522"), "بيرم", 23 },
                    { 859, new Guid("5333c783-fc50-4672-9870-18b00322f7e1"), "ايج", 23 },
                    { 857, new Guid("2c06d157-adee-472d-beb5-50af654c8bf8"), "اهل", 23 },
                    { 856, new Guid("8bc356bd-28a4-4251-a77b-9aa8f4552688"), "امام شهر", 23 },
                    { 855, new Guid("52c2aff7-8a81-4543-9ab1-db59983c82a4"), "اقليد", 23 },
                    { 854, new Guid("1dc2087d-91b8-4c54-8191-d388059f0cdf"), "افزر", 23 },
                    { 853, new Guid("df2995af-475c-49cc-81cd-dc2a1889359e"), "اشکنان", 23 },
                    { 852, new Guid("c287e063-76ce-4955-bbe0-50f6b83a022e"), "اسير", 23 },
                    { 851, new Guid("9e1d56ea-3788-4829-800f-b4232b5b34b5"), "استهبان", 23 },
                    { 858, new Guid("3790fcd2-2508-43c3-ad51-7a615b18604f"), "اوز", 23 },
                    { 772, new Guid("3926b82d-e013-455e-9538-876f94abd272"), "لواسان", 21 },
                    { 868, new Guid("3001f1b9-71c2-41dc-8ffb-49da6bfd9427"), "بيضا", 23 },
                    { 870, new Guid("0efe30de-bdcf-4171-9fe9-3b48d00cd284"), "جهرم", 23 },
                    { 886, new Guid("67dfdb86-5dea-451b-aaa8-79e5df64b1dd"), "دبيران", 23 },
                    { 885, new Guid("16159ea8-5182-4570-ae5c-615e96e6569c"), "داريان", 23 },
                    { 884, new Guid("9d58ac48-ac63-49e3-9064-2b4a3a468cc0"), "داراب", 23 },
                    { 883, new Guid("588618ac-ffd4-4614-b792-2db6eae1bb09"), "خومه زار", 23 },
                    { 882, new Guid("f7c01cb5-0d5d-4ac3-8697-5226d9f6cafb"), "خوزي", 23 },
                    { 881, new Guid("e0533539-94e9-4fe4-a9c1-c18db41a0c0a"), "خور", 23 },
                    { 880, new Guid("73dcf4f7-13e4-4842-9105-bbd990212e53"), "خنج", 23 },
                    { 869, new Guid("e38684d2-2837-43c1-a854-77a0ad57b8d3"), "جنت شهر", 23 },
                    { 879, new Guid("18292d10-aaa3-434e-ba7a-b1d00e6cb6d2"), "خشت", 23 },
                    { 877, new Guid("22fe0fbe-1328-4288-97fd-0afc832554b4"), "خاوران", 23 },
                    { 876, new Guid("fa21a438-5bbb-4d99-b75f-cdc1e062734d"), "خانيمن", 23 },
                    { 875, new Guid("c60bea9f-2a00-41af-8905-018bc868980a"), "خانه زنيان", 23 },
                    { 874, new Guid("d12fa666-50f8-42cc-b9dc-dcde7fab9493"), "حسن آباد", 23 },
                    { 873, new Guid("2db44b90-efdb-4ec5-849c-061bfe43c004"), "حسامي", 23 },
                    { 872, new Guid("497eee74-7d7d-43f3-bb1b-633847753e8c"), "حاجي آباد", 23 },
                    { 871, new Guid("3973a9ed-d8db-423b-bb26-c3e2882d81d4"), "جويم", 23 },
                    { 878, new Guid("a33456d7-3c1f-4eee-8d7e-a310ee29e471"), "خرامه", 23 },
                    { 771, new Guid("e366a9f9-7ea3-42ab-997f-576458cff37c"), "قرچک", 21 },
                    { 770, new Guid("94cc8e28-4869-42c5-9cdf-08bd572797d7"), "قدس", 21 },
                    { 769, new Guid("16d80c09-bbe3-439a-9d22-4ad81fa0cb1a"), "فيروزکوه", 21 },
                    { 669, new Guid("afab0e27-773d-4110-bb18-7b936d554c55"), "عسگران", 19 },
                    { 668, new Guid("c7e301c6-b8f4-45ed-94ed-b2517e17b90c"), "طرق رود", 19 },
                    { 667, new Guid("c65f44e8-a84b-4837-86ea-0ac7e1f2ec37"), "طالخونچه", 19 },
                    { 666, new Guid("4f6a00f0-17da-43c4-a551-6fa4632b76bc"), "شهرضا", 19 },
                    { 665, new Guid("3d8df139-8a85-4608-b0e7-4b46d1d65688"), "شاپورآباد", 19 },
                    { 664, new Guid("eccd188e-392a-4944-ae3b-32a636e3b750"), "شاهين شهر", 19 },
                    { 663, new Guid("0094d56a-3f0c-4f29-a194-7314a3902923"), "سگزي", 19 },
                    { 662, new Guid("89cb644b-5606-48d3-be1c-7bbebac7635b"), "سين", 19 },
                    { 661, new Guid("81315b2a-b13c-4abf-b9cb-b2c75988878a"), "سميرم", 19 },
                    { 660, new Guid("b6acbef8-fa8e-451b-a44d-8da7ee6c38d7"), "سفيد شهر", 19 },
                    { 659, new Guid("2b5fab86-9319-41d7-806d-100e02c1f38c"), "سده لنجان", 19 },
                    { 658, new Guid("b255cc80-c10b-4a5b-8b0a-7056027c4312"), "زيباشهر", 19 },
                    { 657, new Guid("40a3f9fe-c42d-4cb0-8130-7ab8821472fc"), "زيار", 19 },
                    { 656, new Guid("cdc724b4-84cf-4535-afba-b197c56e7bf0"), "زواره", 19 },
                    { 655, new Guid("7a8a2d46-286f-4571-99a5-d7c1955420a4"), "زرين شهر", 19 },
                    { 670, new Guid("f4c65b39-cd55-4dfc-9b5c-5a68c9265b94"), "علويچه", 19 },
                    { 671, new Guid("3688e4a8-dcf4-4e1f-a82d-29e6a62943db"), "فرخي", 19 },
                    { 672, new Guid("15b14190-7ec8-4776-8f8a-20e200b05c13"), "فريدونشهر", 19 },
                    { 673, new Guid("78b2dd84-4608-4514-85a8-a4f46a82cb43"), "فلاورجان", 19 },
                    { 689, new Guid("407905cb-e694-4fad-b0f2-f0ca9614c264"), "نوش آباد", 19 },
                    { 688, new Guid("3a0f4528-1c32-40d3-aae3-074689a4e561"), "نطنز", 19 },
                    { 687, new Guid("739227be-4647-413b-bcd8-14e115312022"), "نصرآباد", 19 },
                    { 686, new Guid("8be7a5c8-7ec8-4261-a90b-8c2893e0c59f"), "نجف آباد", 19 },
                    { 685, new Guid("481fd6bc-4737-4f27-8125-3dde646f39a3"), "نائين", 19 },
                    { 684, new Guid("1a13ffc3-a5a0-4fab-8836-c2d1b2cea380"), "ميمه", 19 },
                    { 683, new Guid("f53ce04e-5c28-45cc-b3f1-2bb093ba58e8"), "مهاباد", 19 },
                    { 654, new Guid("ad236e60-b652-49c8-8e54-277891c220fb"), "زاينده رود", 19 },
                    { 682, new Guid("26c317cf-582f-4978-b148-204dcb9b3316"), "منظريه", 19 },
                    { 680, new Guid("96d5d4bb-21a4-401b-8637-ad1f779808fc"), "محمد آباد", 19 },
                    { 679, new Guid("b8e9458c-d7da-4754-a793-e559d69791a8"), "مبارکه", 19 },
                    { 678, new Guid("af76ad36-7372-4478-947e-4218ca0f4c35"), "لاي بيد", 19 },
                    { 677, new Guid("ffd359d0-6b98-41f5-8f22-af71b182d9b0"), "قهدريجان", 19 },
                    { 676, new Guid("03ed6d5b-b50d-4c19-ac12-d8078d28990a"), "قهجاورستان", 19 },
                    { 675, new Guid("80b0d82e-9309-49a8-8a9f-aea0726b17a4"), "قمصر", 19 },
                    { 674, new Guid("645d59d6-f47c-4192-8bb0-0d08faa5063f"), "فولاد شهر", 19 },
                    { 681, new Guid("e7483985-be62-4348-b6e3-6b48833e01ad"), "مشکات", 19 },
                    { 653, new Guid("2efbb881-c4f0-4dab-8d6d-d53ee2b2b211"), "زازران", 19 },
                    { 652, new Guid("4bf89ad7-a302-47a4-8b40-23f7e0391a9c"), "رضوانشهر", 19 },
                    { 651, new Guid("5c6d6129-288f-42ee-bf42-4a54dc4f9e12"), "رزوه", 19 },
                    { 630, new Guid("4e804d97-840a-4a7c-9165-06bda1f5126a"), "تودشک", 19 },
                    { 629, new Guid("58892fdc-3939-4c30-ae30-268c5ea951cd"), "بوئين مياندشت", 19 },
                    { 628, new Guid("e15aced1-87fc-4294-a4a0-5defac10560b"), "بهارستان", 19 },
                    { 627, new Guid("281d55d5-647e-416d-b572-1cc388fee95a"), "بهاران شهر", 19 },
                    { 626, new Guid("b49ece33-cd58-4b89-a3d6-1118784bd2cf"), "برف انبار", 19 },
                    { 625, new Guid("b36543bc-ef19-4786-b738-5b9d112cede3"), "برزک", 19 },
                    { 624, new Guid("31629ff8-4b65-4969-911d-faa255ed962d"), "بافران", 19 },
                    { 631, new Guid("259a08c0-6b80-4aaf-8c84-6ff1ad49e7e2"), "تيران", 19 },
                    { 623, new Guid("7930437d-1d4f-426b-bc76-fa8ebacd943b"), "باغشاد", 19 },
                    { 621, new Guid("768f9b92-494f-400a-8b52-f47266e7c55b"), "بادرود", 19 },
                    { 620, new Guid("6a2fa44c-bd54-43d2-b203-c826be05eb10"), "اژيه", 19 },
                    { 619, new Guid("f6553a5d-f643-490b-8424-b813b9409098"), "ايمانشهر", 19 },
                    { 618, new Guid("68419765-1d32-482f-987e-fde2960d707d"), "انارک", 19 },
                    { 617, new Guid("2a2cdad3-59bd-4497-8713-f6cb80ae7cf3"), "افوس", 19 },
                    { 616, new Guid("a8171d62-fe81-494c-84b3-bb36dc36df07"), "اصفهان", 19 },
                    { 615, new Guid("41d6a8c7-8dcc-45a6-add2-d5f07fb794a6"), "اصغرآباد", 19 },
                    { 622, new Guid("6ac50c6e-bc3e-42d4-af2a-df91e868b189"), "باغ بهادران", 19 },
                    { 690, new Guid("10906c78-621b-4a3b-91b6-03d1db883996"), "نياسر", 19 },
                    { 632, new Guid("c6ef1e90-a00e-4b98-832c-421adbb03644"), "جندق", 19 },
                    { 634, new Guid("795bca46-edcd-46f9-a745-033571077d12"), "جوشقان قالي", 19 },
                    { 650, new Guid("4277c5b8-648f-4963-b27e-c50d55c4e4c7"), "ديزيچه", 19 },
                    { 649, new Guid("284d1e67-087f-4c46-a19a-395a3fe97e81"), "دولت آباد", 19 },
                    { 648, new Guid("38cf261b-434e-4c8b-abb9-037e6266770b"), "دهق", 19 },
                    { 647, new Guid("75fea6bd-8d01-446d-97a8-85a0b89e9fb4"), "دهاقان", 19 },
                    { 646, new Guid("b787dd5f-fa4b-4082-85c9-2d7cb0b47f33"), "دستگرد", 19 },
                    { 645, new Guid("82d45a1e-65b0-4046-9303-45602d982abb"), "درچه پياز", 19 },
                    { 644, new Guid("4e95d7d7-110e-43bc-ad3a-e7b514b99712"), "دامنه", 19 },
                    { 633, new Guid("b6033677-de8b-49ca-b82a-6434b2058f1d"), "جوزدان", 19 },
                    { 643, new Guid("aaab9d4e-1766-45d2-ae47-83defce23846"), "داران", 19 },
                    { 641, new Guid("1e403ff0-0d76-4dc3-8759-c4f3675158b9"), "خور", 19 },
                    { 640, new Guid("ce7be261-f016-4d35-9b6f-11d4f9a87e4a"), "خوانسار", 19 },
                    { 639, new Guid("9a24670f-bcd8-43e2-9a17-e88c739fbe1c"), "خميني شهر", 19 },
                    { 638, new Guid("239a1569-d762-4a56-9376-6d88230263a3"), "خالد آباد", 19 },
                    { 637, new Guid("05ebc181-c904-4f74-8ea9-bc3f84b87c65"), "حنا", 19 },
                    { 636, new Guid("3443900b-85b5-4c64-8cc4-569913b9d633"), "حسن آباد", 19 },
                    { 635, new Guid("bbc1a726-061e-4482-a2e6-815076c76b0a"), "حبيب آباد", 19 },
                    { 642, new Guid("b6234ae9-5230-4542-b0b8-db3c8e633c61"), "خورزوق", 19 },
                    { 926, new Guid("792beea4-7b61-404f-8064-a9f7c2026706"), "مزايجان", 23 },
                    { 691, new Guid("7912d3e3-fabd-4581-aabb-8a9f0202ebc8"), "نيک آباد", 19 },
                    { 693, new Guid("6f6fc31d-6811-4b37-8fc0-c7d5a1ccc641"), "ورزنه", 19 },
                    { 748, new Guid("77ad2dcb-5115-46e6-8674-46346309db89"), "باقرشهر", 21 },
                    { 747, new Guid("bb34b700-bcb2-47cf-b64f-353ebbb4e4dc"), "باغستان", 21 },
                    { 746, new Guid("8f17bbca-91a3-4a05-b255-48e19b2f4bcd"), "انديشه", 21 },
                    { 745, new Guid("1a42fca9-f757-4266-8df0-35ba8286610c"), "اسلامشهر", 21 },
                    { 744, new Guid("d18bbecd-55ef-4763-93f9-073ecb07c613"), "ارجمند", 21 },
                    { 743, new Guid("91cca666-934d-4cf0-80cb-fded18ad428c"), "آبعلي", 21 },
                    { 742, new Guid("290d7aba-5884-4ed8-a60f-6fed4beaa95b"), "آبسرد", 21 },
                    { 741, new Guid("67471624-a05e-4e02-85e1-9c842d27170a"), "چوار", 20 },
                    { 740, new Guid("2aae739b-5492-4a95-8d21-e81ce93f4113"), "پهله", 20 },
                    { 739, new Guid("8dc1a8a1-acdb-4286-a205-29cd23eeab69"), "ميمه", 20 },
                    { 738, new Guid("0da45e59-7ab9-48a9-92c5-e34553953dd4"), "موسيان", 20 },
                    { 737, new Guid("76afe41f-3cb3-43af-858e-c0e09c31da82"), "مورموري", 20 },
                    { 736, new Guid("821e6ba6-3688-4feb-aa8f-b1f50a55183c"), "مهران", 20 },
                    { 735, new Guid("39177610-a067-4878-a877-a8a57a409808"), "مهر", 20 },
                    { 734, new Guid("a78961e7-d980-43e2-b0fe-70427f7a64d0"), "ماژين", 20 },
                    { 749, new Guid("26f19c71-bf62-4377-b103-4b003770b232"), "بومهن", 21 },
                    { 750, new Guid("28c1a721-8a4a-43de-b034-6c594b0438b2"), "تجريش", 21 },
                    { 751, new Guid("19895859-d36f-4c32-8724-5968ee231510"), "تهران", 21 },
                    { 752, new Guid("e4362abb-a93b-48fb-a5e0-a6ef421c8858"), "جواد آباد", 21 },
                    { 768, new Guid("72955749-cfcc-4501-8566-410467254cb9"), "فشم", 21 },
                    { 767, new Guid("70594768-4086-49e3-b531-d9f5cf823d5b"), "فرون آباد", 21 },
                    { 766, new Guid("704d1d2a-5902-42dc-a070-20e492c94db2"), "فردوسيه", 21 },
                    { 765, new Guid("4960605a-7660-41c9-a680-8cddb1062626"), "صفادشت", 21 },
                    { 764, new Guid("2f27a151-d6d3-477d-a3c9-9f4b0c31ecb4"), "صبا شهر", 21 },
                    { 763, new Guid("7ce8a1a9-6c19-4f3e-b50a-31d64eb62c70"), "صالحيه", 21 },
                    { 762, new Guid("f5d6791d-4f9c-457a-835f-dc3d8f5b99c8"), "شهريار", 21 },
                    { 733, new Guid("7ffbe9ae-e676-4ce7-8b1a-75ea4dd695d4"), "لومار", 20 },
                    { 761, new Guid("6f26fd95-0397-4847-b5a7-83519394cb79"), "شهر جديد پرند", 21 },
                    { 759, new Guid("23c779a4-9af1-4769-9668-778685bfab51"), "شريف آباد", 21 },
                    { 758, new Guid("76b2bbce-428d-4823-b46e-fd1cf0b8f9a6"), "شاهدشهر", 21 },
                    { 757, new Guid("6ba87ed3-dca2-434b-bd06-9b30366d2a02"), "ري", 21 },
                    { 756, new Guid("b09d427a-7577-486d-b49b-a390c0b5d764"), "رودهن", 21 },
                    { 755, new Guid("a5dad774-4fd0-44fc-87b4-9dcbfb8a6705"), "رباط کريم", 21 },
                    { 754, new Guid("e6c21c6c-19d1-4aa4-8ff5-bd692f2af0d5"), "دماوند", 21 },
                    { 753, new Guid("f5475b43-63c9-478f-932f-81b6402ca4db"), "حسن آباد", 21 },
                    { 760, new Guid("9c31a0d9-fe3d-44c3-b9eb-d38063d9d061"), "شمشک", 21 },
                    { 732, new Guid("6bfe3bb3-c4fb-4c78-b6e0-8acaa88a1820"), "صالح آباد", 20 },
                    { 731, new Guid("be73243c-c5cb-4235-89e9-e7e49da79d50"), "شباب", 20 },
                    { 730, new Guid("ce10f34b-2e66-4d6a-981e-5a323b43d8a8"), "سرابله", 20 },
                    { 709, new Guid("7051fc8b-b948-4b8b-bc5b-b607551e2f98"), "کوهپايه", 19 },
                    { 708, new Guid("6c12cf91-3615-4e88-a1eb-827a2d251b4c"), "کوشک", 19 },
                    { 707, new Guid("b73ae733-5a9c-468c-b2c9-584483f5bf39"), "کهريزسنگ", 19 },
                    { 706, new Guid("268e192c-6ef2-45bb-9efe-e5a5d78c529f"), "کمه", 19 },
                    { 705, new Guid("a0f5f597-c378-4e0f-a8be-a988f3bcd5ae"), "کمشجه", 19 },
                    { 704, new Guid("89503f22-85d8-4c89-b429-01cdb98f1134"), "کليشاد و سودرجان", 19 },
                    { 703, new Guid("26a3adf0-6816-43d5-8078-10678c56bed7"), "کرکوند", 19 },
                    { 710, new Guid("328acf6d-318b-4f77-b2d4-c15c168c6be9"), "گرگاب", 19 },
                    { 702, new Guid("7fa905ca-c87e-48fd-9282-b6445360b099"), "کامو و چوگان", 19 },
                    { 700, new Guid("8a9dce82-f491-4310-8fd6-e7f983501ab4"), "چمگردان", 19 },
                    { 699, new Guid("b522a1a5-05ce-4d70-96d8-65569d60aa95"), "چرمهين", 19 },
                    { 698, new Guid("ac523c68-b263-4e64-a9f4-d91bc299a82d"), "چادگان", 19 },
                    { 697, new Guid("3b6370e7-b0b1-4fd4-823d-c8ce19f46cf7"), "پير بکران", 19 },
                    { 696, new Guid("2040977d-5429-44be-a0d6-6e498dc4f27b"), "ونک", 19 },
                    { 695, new Guid("5d48becd-58c1-4117-8ba4-61e6e84bf15c"), "وزوان", 19 },
                    { 694, new Guid("7029681b-497d-4e70-88cc-c4e07880b850"), "ورنامخواست", 19 },
                    { 701, new Guid("04986855-7f4d-473a-9b79-dc89ad86f611"), "کاشان", 19 },
                    { 692, new Guid("15f63a52-4ea9-46fd-82d7-84bde25b07f5"), "هرند", 19 },
                    { 711, new Guid("2b17d69f-94fb-4c73-8c30-68345f1fd937"), "گز برخوار", 19 },
                    { 713, new Guid("a1eec301-eed7-4b08-834c-b12e46f958aa"), "گلشن", 19 },
                    { 729, new Guid("46a7ed57-a900-48eb-8f9f-1ff593b534c3"), "سراب باغ", 20 },
                    { 728, new Guid("01090c74-beb7-42e1-91db-1d8d6f56204a"), "زرنه", 20 },
                    { 727, new Guid("edd29c42-01cb-4681-8963-823db2ec7bea"), "دهلران", 20 },
                    { 726, new Guid("c16ebe9c-01c1-4108-959f-73f98c3fbfff"), "دلگشا", 20 },
                    { 725, new Guid("6638c673-b6aa-4bde-8138-e3d88da77204"), "دره شهر", 20 },
                    { 724, new Guid("f5f7d8a6-b98c-4257-95a4-8a7f9a7925ce"), "توحيد", 20 },
                    { 723, new Guid("c9d5eea4-4f5f-42f6-af72-c15d5f6534e2"), "بلاوه", 20 },
                    { 712, new Guid("570e3c51-402b-4203-9a70-9820715d38ae"), "گلدشت", 19 },
                    { 722, new Guid("02b400ed-d9ea-40ea-adb3-0ff7f99e947a"), "بدره", 20 },
                    { 720, new Guid("c835d437-26c6-4155-ba5f-895ce4e760a6"), "ايلام", 20 },
                    { 719, new Guid("22cc83e1-b129-497b-8b86-022fda8b07c8"), "ارکواز", 20 },
                    { 718, new Guid("cab73b70-aa8f-486e-8d43-6d1a7e3c5424"), "آسمان آباد", 20 },
                    { 717, new Guid("b724e3f7-4c79-4dc8-a0a2-f65869f04c38"), "آبدانان", 20 },
                    { 716, new Guid("35333397-beca-42c9-9d8e-de31f2488444"), "گوگد", 19 },
                    { 715, new Guid("03c8f7b9-9f5a-45fc-9efd-0a606265a9f6"), "گلپايگان", 19 },
                    { 714, new Guid("73a2f42d-11e8-4000-aa9a-8d5ae1387246"), "گلشهر", 19 },
                    { 721, new Guid("2d79cbf3-afe5-44b2-9da5-fdd40596df84"), "ايوان", 20 },
                    { 927, new Guid("95f8d2e4-b324-4106-8eaf-262f8a407ae8"), "مشکان", 23 },
                    { 928, new Guid("8d80ba88-f683-4c53-a8a4-3907930d4d1c"), "مصيري", 23 },
                    { 929, new Guid("74a16afb-2d31-4ea2-8693-420ebe49cf05"), "مهر", 23 },
                    { 1141, new Guid("e92f8a34-ba12-4983-9d69-396d69a53067"), "بردسير", 29 },
                    { 1140, new Guid("ed1ab973-7b17-496e-91d6-e6552431c498"), "بافت", 29 },
                    { 1139, new Guid("efe3daa8-827e-496d-9abb-4572ab6feebc"), "باغين", 29 },
                    { 1138, new Guid("0fa4ffa4-55e2-4885-ac4b-ac14183ddff8"), "اندوهجرد", 29 },
                    { 1137, new Guid("d25f5b5c-7559-40c4-a036-a0d759ab3fff"), "انار", 29 },
                    { 1136, new Guid("f57db02b-67a3-44f6-aa8a-b504cddb4c25"), "امين شهر", 29 },
                    { 1135, new Guid("49e21e6a-dbe5-4a08-8c62-a2cd35bca699"), "ارزوئيه", 29 },
                    { 1134, new Guid("dcafd921-1834-49dc-8a6e-29c08b6d8461"), "اختيار آباد", 29 },
                    { 1133, new Guid("812ce1df-1207-473b-af02-d082e306685a"), "گيان", 28 },
                    { 1132, new Guid("24546ba4-462a-43d9-8993-46dceb4c496d"), "گل تپه", 28 },
                    { 1131, new Guid("6fa398e4-f4d7-40af-8f61-a374a51884fd"), "کبودر آهنگ", 28 },
                    { 1130, new Guid("29f901a0-57ac-4772-9818-4b1f912b8bb0"), "همدان", 28 },
                    { 1129, new Guid("6407c976-588d-407c-9c71-5b334f6a33f8"), "نهاوند", 28 },
                    { 1128, new Guid("a96b8b76-ef4f-456c-bd7f-92eb96eceff4"), "مهاجران", 28 },
                    { 1127, new Guid("ec442dae-e683-44c2-bb54-6f2178f354f7"), "ملاير", 28 },
                    { 1142, new Guid("5121b9a0-26de-431f-b435-06790a74ea57"), "بروات", 29 },
                    { 1143, new Guid("ab9680a1-cbfb-4569-af55-77070f90a426"), "بزنجان", 29 },
                    { 1144, new Guid("eecc9fa8-a113-490b-9ead-023f104c1271"), "بلورد", 29 },
                    { 1145, new Guid("b2dd3314-1d97-46cd-b0df-d3a8f94bb341"), "بلوک", 29 },
                    { 1161, new Guid("27e2c498-882d-41fe-845d-6f25c77a82c0"), "راور", 29 },
                    { 1160, new Guid("0f42b49d-a508-42e2-b5c2-677cd1f23ae5"), "رابر", 29 },
                    { 1159, new Guid("0cc2d1cd-0210-41d4-8101-563d7a324e52"), "دوساري", 29 },
                    { 1158, new Guid("9c69b877-a241-4d1e-86dd-47204f7c2658"), "دهج", 29 },
                    { 1157, new Guid("58266613-7041-479c-a339-7ec838b66a9e"), "دشتکار", 29 },
                    { 1156, new Guid("c4f52519-3d8b-4be9-88cc-6b265ffa1fa2"), "درب بهشت", 29 },
                    { 1155, new Guid("6a905943-0f6c-4cd7-9e3c-b7fa34b7188d"), "خورسند", 29 },
                    { 1126, new Guid("e41bb6dd-28d5-47d1-acc8-c2f05e73f9f7"), "مريانج", 28 },
                    { 1154, new Guid("d9315465-e6d9-41f9-bace-621dffb89af1"), "خواجوشهر", 29 },
                    { 1152, new Guid("290a41cd-fe76-47a7-b49a-ef0947273ea2"), "خاتون آباد", 29 },
                    { 1151, new Guid("fbf4d399-d693-408b-b251-f5850b8da97c"), "جيرفت", 29 },
                    { 1150, new Guid("0a18f3ad-5ba5-48f9-bbd1-7de244de9a77"), "جوپار", 29 },
                    { 1149, new Guid("8c0fbea1-9dc5-4bc6-a03b-0ca72b2fcc2f"), "جوزم", 29 },
                    { 1148, new Guid("ebf094bd-349d-49cb-bd5c-6e72ac55081c"), "جبالبارز", 29 },
                    { 1147, new Guid("79caa436-fafb-4bf8-a378-c1edf1b14735"), "بهرمان", 29 },
                    { 1146, new Guid("79fc8d06-eb5a-4778-baeb-b387b9aa0cea"), "بم", 29 },
                    { 1153, new Guid("7aa3a032-0933-4511-ba20-f4753e523541"), "خانوک", 29 },
                    { 1162, new Guid("87d88263-64da-4e7d-bb7d-42b522fa0ff7"), "راين", 29 },
                    { 1125, new Guid("ee213eb3-ffe5-421b-96d1-d2066c2bc5d6"), "لالجين", 28 },
                    { 1123, new Guid("194716bd-5aeb-483a-a4b5-06150a594c28"), "قروه در جزين", 28 },
                    { 1102, new Guid("0f27514f-562a-4e39-875a-5f6d856e3bbc"), "کوچصفهان", 27 },
                    { 1101, new Guid("5a69b24d-6442-48d5-ae53-dcb4337e1ee1"), "کومله", 27 },
                    { 1100, new Guid("e643eff5-0d6f-49ba-ab77-18afc3cf69e7"), "کلاچاي", 27 },
                    { 1099, new Guid("edc3ba5d-d463-4c1f-9bbf-ae15f9485bcb"), "چوبر", 27 },
                    { 1098, new Guid("5b4d506c-8920-4ee1-801f-2e7576959da8"), "چاف و چمخاله", 27 },
                    { 1097, new Guid("acfb3584-ab3c-4cfa-bbe7-1f541c8fe67e"), "چابکسر", 27 },
                    { 1096, new Guid("42596159-36f8-4fe9-9752-7147c6ff160e"), "پره سر", 27 },
                    { 1095, new Guid("7d99f8b2-906a-4633-b23a-13d8b6fd015a"), "واجارگاه", 27 },
                    { 1094, new Guid("4a247e51-7eee-4c77-b8e9-a596a001f3c7"), "هشتپر", 27 },
                    { 1093, new Guid("d110e811-8494-437d-bb6a-8013ad4c4dbd"), "منجيل", 27 },
                    { 1092, new Guid("6342630d-08ab-4630-a124-2b923df2a6bf"), "مرجقل", 27 },
                    { 1091, new Guid("aba3e222-1cd1-4fc0-964d-53c6d44220bb"), "ماکلوان", 27 },
                    { 1090, new Guid("1de58900-d93a-47fd-9223-b77df9a46a0b"), "ماسوله", 27 },
                    { 1089, new Guid("cb6ab735-0e28-4afa-b824-89c485ef6e9e"), "ماسال", 27 },
                    { 1088, new Guid("6fbe511b-b7bc-412d-9f1a-5c1f050f3a52"), "ليسار", 27 },
                    { 1103, new Guid("32882e22-5d17-4bc6-8135-5154e90455bf"), "کياشهر", 27 },
                    { 1104, new Guid("2c140bc5-3c2c-4d1b-b0c0-ef4fe9e96219"), "گوراب زرميخ", 27 },
                    { 1105, new Guid("9cc75211-2d65-4d6a-ad4b-a30315acd434"), "آجين", 28 },
                    { 1106, new Guid("6e05e7cb-0dcf-4cf4-8dee-43f05d348e95"), "ازندريان", 28 },
                    { 1122, new Guid("2b245232-4bfc-4a81-ab06-fbe7285094c3"), "فيروزان", 28 },
                    { 1121, new Guid("5036385e-334e-462c-b076-c094f025a68f"), "فرسفج", 28 },
                    { 1120, new Guid("ef70f95e-3010-4313-a46e-d45bc7b10f34"), "فامنين", 28 },
                    { 1119, new Guid("d6b2edcb-75b3-433e-abac-f2f4f39664fd"), "صالح آباد", 28 },
                    { 1118, new Guid("a3c5e563-1c68-4e22-af22-fb1a56d6652c"), "شيرين سو", 28 },
                    { 1117, new Guid("a6661e76-ea5c-4244-ae5e-abdf4d6ba081"), "سرکان", 28 },
                    { 1116, new Guid("bf42ebd4-048f-47dc-b4f3-377224a4bd2a"), "سامن", 28 },
                    { 1124, new Guid("40d19556-034e-4329-b391-a6f7311cbd02"), "قهاوند", 28 },
                    { 1115, new Guid("8d86aa87-6149-4dfa-aaa5-6b22c9722ac5"), "زنگنه", 28 },
                    { 1113, new Guid("ea62bb68-d6fd-44b1-abe3-56a9bed8e5ef"), "دمق", 28 },
                    { 1112, new Guid("7c9acc9c-6023-48e2-8b57-3d35110ba123"), "جوکار", 28 },
                    { 1111, new Guid("dcaefc72-c821-49fb-b0b5-67099ae77fd4"), "جورقان", 28 },
                    { 1110, new Guid("d2ac05c3-723c-47bf-911b-5705e1b11bde"), "تويسرکان", 28 },
                    { 1109, new Guid("a85901ff-c65b-4133-abea-e89537ecaad5"), "بهار", 28 },
                    { 1108, new Guid("84944afb-6e7b-4470-98a6-cb5928d90c50"), "برزول", 28 },
                    { 1107, new Guid("e90f7b5a-70b2-4f5d-9bde-df70925f602c"), "اسد آباد", 28 },
                    { 1114, new Guid("1efc516b-cbad-493b-b16c-94b82d408242"), "رزن", 28 },
                    { 1163, new Guid("cc36fca0-d8a1-4c37-b88b-806b28170499"), "رفسنجان", 29 },
                    { 1164, new Guid("625509a1-c4e8-48e9-8587-64d9f8a43eaf"), "رودبار", 29 },
                    { 1165, new Guid("d49b402e-02af-4c0d-bb85-8fbc78d992be"), "ريحان", 29 },
                    { 1220, new Guid("fc46591c-d652-46c0-9cad-27c9c879a055"), "ميامي", 30 },
                    { 1219, new Guid("0f06a024-8519-403f-8d8b-90cd0f64f284"), "مهدي شهر", 30 },
                    { 1218, new Guid("07159a13-a5e1-431d-81a0-eb53d646030e"), "مجن", 30 },
                    { 1217, new Guid("87cf50e8-13b1-4783-9344-3901c2bfa82f"), "شهميرزاد", 30 },
                    { 1216, new Guid("9dafcb3d-f29b-4bcb-b6cb-927a0ad0dcfd"), "شاهرود", 30 },
                    { 1215, new Guid("e5d577ae-5ad9-48c0-a176-a42c961bd6b1"), "سمنان", 30 },
                    { 1214, new Guid("97e3bb4f-917b-4b0e-9997-8cba59eca918"), "سرخه", 30 },
                    { 1213, new Guid("c954ae08-7fad-4669-a2af-b3d1dadb4fd9"), "روديان", 30 },
                    { 1212, new Guid("a0c9feba-6c9d-4d98-ad1c-26fe659de1c8"), "ديباج", 30 },
                    { 1211, new Guid("0873aed9-a1b9-42cb-9d35-621295864d56"), "درجزين", 30 },
                    { 1210, new Guid("99ff8d2b-985d-45e7-a86c-dc3fb090b9e5"), "دامغان", 30 },
                    { 1209, new Guid("a36e7713-4be0-4fe5-ac0d-753354cb3cc5"), "بيارجمند", 30 },
                    { 1208, new Guid("cc89081c-9f5d-4112-8b0f-01be45ebcebc"), "بسطام", 30 },
                    { 1207, new Guid("fc8fae9c-8360-4f57-922e-0998feab65ce"), "ايوانکي", 30 },
                    { 1206, new Guid("2937bd67-9b01-4a7a-b74a-5e4c1bd2eb78"), "اميريه", 30 },
                    { 1221, new Guid("6844d7e4-fd92-42d6-bbc1-576d652062ad"), "کلاته", 30 },
                    { 1222, new Guid("e820d599-a6e2-4086-91ff-464afee563e0"), "کلاته خيج", 30 },
                    { 1223, new Guid("b99d4acf-a530-4021-a8cb-279b98e29729"), "کهن آباد", 30 },
                    { 1224, new Guid("a7760474-2bf9-44e1-a9af-71e53822f66c"), "گرمسار", 30 },
                    { 1240, new Guid("ef765cd5-d899-44ff-be4a-2cba0136e8f9"), "چيتاب", 31 },
                    { 1239, new Guid("a9239bac-7faf-474b-b8d5-1d680ecbbee0"), "چرام", 31 },
                    { 1238, new Guid("2f8c73c5-47d2-48d2-bb73-db0a8a70ab5b"), "پاتاوه", 31 },
                    { 1237, new Guid("378cdb23-1400-41e9-9369-b978e181183d"), "ياسوج", 31 },
                    { 1236, new Guid("8e8b117c-9955-47c8-ae46-6aa33be7b056"), "مارگون", 31 },
                    { 1235, new Guid("7c71b941-a568-4039-b52a-3db0c3c174a3"), "مادوان", 31 },
                    { 1234, new Guid("6daf8626-cc0d-4530-a1c1-797920b219e1"), "ليکک", 31 },
                    { 1205, new Guid("4524d8b6-a718-4729-a744-86094eb3c373"), "آرادان", 30 },
                    { 1233, new Guid("c6d8373d-ecea-4d95-bc2d-d1397951755c"), "لنده", 31 },
                    { 1231, new Guid("d60ef39c-3506-44aa-abdf-c2fce26ff43b"), "سي سخت", 31 },
                    { 1230, new Guid("1a436a23-3106-415a-acc9-a03d8cdace22"), "سوق", 31 },
                    { 1229, new Guid("7888cd53-7fd9-4602-be06-86e96811266c"), "سرفارياب", 31 },
                    { 1228, new Guid("e56395bb-8029-4091-ba21-54e1103c2b3d"), "ديشموک", 31 },
                    { 1227, new Guid("5e2e5492-9e62-434c-9025-4cf5bdac4741"), "دوگنبدان", 31 },
                    { 1226, new Guid("b65033a6-c23d-4593-82c7-676a2bd29be2"), "دهدشت", 31 },
                    { 1225, new Guid("1652cbaf-978b-4bd1-8c65-046764f2e501"), "باشت", 31 },
                    { 1232, new Guid("a3ca2bad-26e6-4bbe-846b-db551b2f43d6"), "قلعه رئيسي", 31 },
                    { 1204, new Guid("2f1401c0-0af6-41ea-ba21-164d1f8f9e34"), "گنبکي", 29 },
                    { 1203, new Guid("0d08070b-f571-4cfa-aed5-82cbc2b120cd"), "گلزار", 29 },
                    { 1202, new Guid("57751f4e-2fb0-49e6-a5ab-a19f2a32c0e3"), "گلباف", 29 },
                    { 1181, new Guid("576a2e80-6ba6-4d6a-835e-684e534eb9f1"), "محي آباد", 29 },
                    { 1180, new Guid("656984a5-520d-4f0f-be35-2da3d4047c00"), "محمد آباد", 29 },
                    { 1179, new Guid("3a93ca17-36ff-4847-9ff7-625f121d9196"), "ماهان", 29 },
                    { 1178, new Guid("44ea1fa7-6367-4b97-a779-0af300b98776"), "لاله زار", 29 },
                    { 1177, new Guid("d9da63f7-def8-4e7f-8363-b7c60be59586"), "قلعه گنج", 29 },
                    { 1176, new Guid("34920281-caca-4c01-861e-cda35561b331"), "فهرج", 29 },
                    { 1175, new Guid("e1ef6787-436a-433c-ad89-4ca39fe175bd"), "فارياب", 29 },
                    { 1182, new Guid("f21f8a41-3773-49d4-b2f0-585a5da99abb"), "مردهک", 29 },
                    { 1174, new Guid("cd0cf5e9-7093-4bae-bbd7-209638e2ffa0"), "عنبر آباد", 29 },
                    { 1172, new Guid("00a58279-7831-49f7-9712-238d563cc71c"), "شهر بابک", 29 },
                    { 1171, new Guid("552b2375-ccfa-4985-8592-3d13bf3490fe"), "شهداد", 29 },
                    { 1170, new Guid("51223798-20dd-45f6-8130-f4b99bb6f17f"), "سيرجان", 29 },
                    { 1169, new Guid("90521091-4bb1-4db2-89fd-0bd604658b73"), "زيد آباد", 29 },
                    { 1168, new Guid("e4d11a30-dcba-4837-9010-b9166f8d0542"), "زهکلوت", 29 },
                    { 1167, new Guid("2bdf7850-f23f-4102-8b40-2b285abe8913"), "زنگي آباد", 29 },
                    { 1166, new Guid("e2d16587-2a5f-4869-bd32-63788b54bb11"), "زرند", 29 },
                    { 1173, new Guid("01b42e5c-ae91-414d-ba63-88382dcf26b5"), "صفائيه", 29 },
                    { 1087, new Guid("bc223ae1-87a1-4104-9dfb-d480772fae48"), "لوندويل", 27 },
                    { 1183, new Guid("c688e675-6d2a-44be-b081-14a8875abf26"), "مس سرچشمه", 29 },
                    { 1185, new Guid("cdfa46e4-e146-46fc-a38c-b4dfa1b009ff"), "نجف شهر", 29 },
                    { 1201, new Guid("e8ca0d62-f67b-4047-85f1-f05abf62eeb3"), "کيانشهر", 29 },
                    { 1200, new Guid("c7dbcca1-931e-4c74-8ce9-75e070a7136f"), "کوهبنان", 29 },
                    { 1199, new Guid("e1dfc69f-e3c2-42a0-aedf-f1f8150980b2"), "کهنوج", 29 },
                    { 1198, new Guid("18635676-dfe6-43a5-b19e-1aeb2aaad28d"), "کشکوئيه", 29 },
                    { 1197, new Guid("6292ab9f-7f05-4750-953a-f0b0b4486529"), "کرمان", 29 },
                    { 1196, new Guid("2554a255-1d5a-40a2-a952-02187b4ba95f"), "کاظم آباد", 29 },
                    { 1195, new Guid("120ec3ae-f27d-411a-a867-b4ac5383c43c"), "چترود", 29 },
                    { 1184, new Guid("01ab0f46-f841-4851-9f00-aef087da5570"), "منوجان", 29 },
                    { 1194, new Guid("a48c35cc-c55c-48f7-9bea-b98dd264cd88"), "پاريز", 29 },
                    { 1192, new Guid("1a7176a3-76e2-4ca4-bf63-c870e504900c"), "هنزا", 29 },
                    { 1191, new Guid("2a84f38a-c1a9-4ce4-96e6-8b38368c6d6e"), "هماشهر", 29 },
                    { 1190, new Guid("4734865d-ae08-45ae-ac01-1008739b1386"), "هجدک", 29 },
                    { 1189, new Guid("484fcca8-6c00-429a-bb6e-13f2c67672b2"), "نگار", 29 },
                    { 1188, new Guid("3ba5900c-8f90-44f9-94ea-8f8b566b55b2"), "نودژ", 29 },
                    { 1187, new Guid("8613824e-a288-448b-a782-33152b5e836b"), "نظام شهر", 29 },
                    { 1186, new Guid("03841af0-65fc-42e0-be43-21d46adf781f"), "نرماشير", 29 },
                    { 1193, new Guid("aaf04eb4-3425-44e9-aafe-00e19cf2f5e5"), "يزدان شهر", 29 },
                    { 1086, new Guid("aa0b23a5-967b-4cf9-a8c0-27edced82e78"), "لولمان", 27 },
                    { 1085, new Guid("dc232ce1-87bc-466d-8cb0-fa6d0c16952a"), "لوشان", 27 },
                    { 1084, new Guid("27fe97f6-3014-4990-96e4-0c4f47eb646d"), "لنگرود", 27 },
                    { 984, new Guid("b3f0230f-a594-426c-83e1-a35a3423328e"), "بندر عباس", 25 },
                    { 983, new Guid("4f7c85d5-3f91-4b9a-b903-82bb4cae1901"), "بندر جاسک", 25 },
                    { 982, new Guid("8988e32e-f318-485e-bb4f-0ad83c6df623"), "بستک", 25 },
                    { 981, new Guid("715606c5-cbc9-4e2b-8864-ef8ecaa67e16"), "ابوموسي", 25 },
                    { 980, new Guid("afe9202f-4bd2-4faa-b32e-c2367cddbb30"), "گيلانغرب", 24 },
                    { 979, new Guid("4787efaf-48f3-412a-87b0-60d80347585d"), "گودين", 24 },
                    { 978, new Guid("7b147be6-24ce-41bc-853e-fdceb4277b00"), "گهواره", 24 },
                    { 977, new Guid("d2066247-cb18-44c1-b18b-4917d591df29"), "کوزران", 24 },
                    { 976, new Guid("3ab2bfd5-89c8-4953-9e54-da4d6c66ffe1"), "کنگاور", 24 },
                    { 975, new Guid("495a28c7-0f32-4b60-9a89-060ea225364b"), "کرند غرب", 24 },
                    { 974, new Guid("57a25ed7-2991-4872-b7d1-3d5fb5579e74"), "کرمانشاه", 24 },
                    { 973, new Guid("bc08c8cb-5afb-4c7a-9f7f-1a7aacee1a13"), "پاوه", 24 },
                    { 972, new Guid("0db12bd9-aa41-4ce4-a66e-bdbb0baa18d6"), "هلشي", 24 },
                    { 971, new Guid("64fa5060-a4ae-4a53-b3e8-fb68a0618f02"), "هرسين", 24 },
                    { 970, new Guid("4769b247-502b-45f4-ad4c-efc8a6a62a61"), "نوسود", 24 },
                    { 985, new Guid("d102949a-ca32-41bd-af06-c9dab75399df"), "بندر لنگه", 25 },
                    { 986, new Guid("d7483a18-812d-40bf-817f-c7f6b79129a7"), "بيکاه", 25 },
                    { 987, new Guid("c2b9fc04-eb62-44d3-8658-603b3796fdcc"), "تازيان پائين", 25 },
                    { 988, new Guid("7d0a9932-1e0c-4575-b603-e76216402b4f"), "تخت", 25 },
                    { 1004, new Guid("5bb1476a-b4a2-48cc-bb75-fec4a58dc16b"), "فين", 25 },
                    { 1003, new Guid("adf4f6c2-7ef1-427b-9d34-14f6e8e473e1"), "فارغان", 25 },
                    { 1002, new Guid("2701fa30-d8a5-42f7-8e87-e00ccaa9ebec"), "سيريک", 25 },
                    { 1001, new Guid("7d498ed2-7470-4f32-ad2c-f08d652ff61a"), "سوزا", 25 },
                    { 1000, new Guid("3e61682d-5792-4cc6-8858-c00c8a4379fb"), "سندرک", 25 },
                    { 999, new Guid("77236df0-e6e2-4213-8152-fcef56e7fb54"), "سرگز", 25 },
                    { 998, new Guid("86cc075a-3899-4ad8-9a0b-f8464f35ab65"), "سردشت", 25 },
                    { 969, new Guid("730c0ad5-30cd-42e0-817f-0286c8289956"), "نودشه", 24 },
                    { 997, new Guid("5a8a1bdb-b94d-4ee8-a85c-e13f04efe328"), "زيارتعلي", 25 },
                    { 995, new Guid("871020a2-dd9a-43a7-a975-904da2059ed7"), "دهبارز", 25 },
                    { 994, new Guid("75f72f34-d1e7-4b1a-8bd8-fe3bb03e37d5"), "دشتي", 25 },
                    { 993, new Guid("5cc01f5e-543b-41ac-b013-3faf95b5e9f7"), "درگهان", 25 },
                    { 992, new Guid("06318f22-1cf8-44f7-988a-30f405b284db"), "خمير", 25 },
                    { 991, new Guid("573765ba-0107-473e-bfaa-2a1a56b4b272"), "حاجي آباد", 25 },
                    { 990, new Guid("f316e59a-a0ad-4f4d-b143-0e636068b88d"), "جناح", 25 },
                    { 989, new Guid("0133819b-8931-49fc-986b-2cc6970e7527"), "تيرور", 25 },
                    { 996, new Guid("9adbc014-027c-4493-92e2-a466c6db4fe3"), "رويدر", 25 },
                    { 968, new Guid("88c932d5-5d3f-4ec1-b64e-19cb83ee2a21"), "ميان راهان", 24 },
                    { 967, new Guid("ceed451a-beb1-4d36-bb9e-a8460de51bce"), "قصر شيرين", 24 },
                    { 966, new Guid("724fb528-cb92-4fde-80dc-22ba748983db"), "صحنه", 24 },
                    { 945, new Guid("21e60bd6-a2e1-4ccf-b3c1-13cb71f15768"), "کوهنجان", 23 },
                    { 944, new Guid("fee911e5-75a3-4b40-a865-61f044958a56"), "کوار", 23 },
                    { 943, new Guid("6ca23ad9-f13c-40ed-aa99-8c534a8a40c9"), "کنار تخته", 23 },
                    { 942, new Guid("524919dc-befd-43f8-83ea-93ebc0d2e142"), "کره اي", 23 },
                    { 941, new Guid("f749ba65-4705-4a5d-8480-9864335ebfe9"), "کامفيروز", 23 },
                    { 940, new Guid("2e5b27a2-6c45-46e9-8164-c7cd5346f017"), "کازرون", 23 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 939, new Guid("2d56068c-9551-4098-b15b-d9a1f3c1c743"), "کارزين", 23 },
                    { 946, new Guid("13e3adb9-b7ea-4dee-95db-7f729b8d91a5"), "کوپن", 23 },
                    { 938, new Guid("9bbb4d41-7073-4c42-ae98-b1090fb6087c"), "وراوي", 23 },
                    { 936, new Guid("f430ef5a-91c6-40f9-a612-987d682eb6b2"), "ني ريز", 23 },
                    { 935, new Guid("e08d1b4a-333c-4e70-acb1-8a95a93197a3"), "نورآباد", 23 },
                    { 934, new Guid("682d449b-1c2b-4205-a84b-5a7f8acbbbc1"), "نودان", 23 },
                    { 933, new Guid("866bf73d-a36c-472b-bbd4-76290cc3e594"), "نوجين", 23 },
                    { 932, new Guid("723a933d-c230-4d40-8f14-481fda974d9b"), "نوبندگان", 23 },
                    { 931, new Guid("74ea0b60-db63-4fff-9f19-9e68e7ad8784"), "ميمند", 23 },
                    { 930, new Guid("95a40ccf-13ce-4b4a-882a-2eed873966a7"), "ميانشهر", 23 },
                    { 937, new Guid("b4610798-ce6e-4229-9e3c-21e90ab9a0a8"), "هماشهر", 23 },
                    { 1005, new Guid("5b4831b3-5cbd-410a-9a97-7251524c1a14"), "قشم", 25 },
                    { 947, new Guid("fc93b1e8-15ba-40f6-8470-966fbbefcfcd"), "گراش", 23 },
                    { 949, new Guid("79f36809-c3ec-46cb-849e-4f76e10ae2f1"), "ازگله", 24 },
                    { 965, new Guid("58c9ed7b-9269-487e-ad4e-a4ec8220da42"), "شاهو", 24 },
                    { 964, new Guid("9fc53595-639b-49aa-a7fd-26d261b596c1"), "سومار", 24 },
                    { 963, new Guid("7db386d8-ab84-4337-960f-2c6ad50fbc65"), "سنقر", 24 },
                    { 962, new Guid("b84441fb-c9cb-454e-899b-f1f4fa93c5ba"), "سطر", 24 },
                    { 961, new Guid("7beb93ab-6f62-4871-92a2-d44ac8f03697"), "سرمست", 24 },
                    { 960, new Guid("50242a62-e27f-488d-9b8f-b525fe764b47"), "سر پل ذهاب", 24 },
                    { 959, new Guid("85980613-3a44-4926-86c0-e6cd2490882d"), "ريجاب", 24 },
                    { 948, new Guid("f2a2389f-f45b-4c04-9439-5709e6221493"), "گله دار", 23 },
                    { 958, new Guid("19ffb245-e8b4-4812-af5a-ee1a3faca3f2"), "روانسر", 24 },
                    { 956, new Guid("c95500fc-389c-4df4-a7e6-7cc67cb4f0c4"), "حميل", 24 },
                    { 955, new Guid("744c7b15-4fc6-4e8c-98f9-f085bd80d52e"), "جوانرود", 24 },
                    { 954, new Guid("d672810f-81e1-46db-b427-5fa2fcf5f2fa"), "تازه آباد", 24 },
                    { 953, new Guid("53d42df2-658a-46ae-b82a-48919f37aae8"), "بيستون", 24 },
                    { 952, new Guid("9b4d3cda-3a53-4b12-9091-fb8e413f9b0f"), "باينگان", 24 },
                    { 951, new Guid("a7dc4839-8329-4b0b-8c33-0ab1fb568470"), "بانوره", 24 },
                    { 950, new Guid("ac0f6be8-cb09-479a-a09b-40fac628fed2"), "اسلام آباد غرب", 24 },
                    { 957, new Guid("4d03e914-66d8-4c3e-9b98-32fb25a8669f"), "رباط", 24 },
                    { 614, new Guid("168c2511-435e-4577-8944-0d8a15e54fac"), "اردستان", 19 },
                    { 1006, new Guid("ca387ca7-c819-42d5-9f3f-483e4fe81586"), "قلعه قاضي", 25 },
                    { 1008, new Guid("0f06da7e-34a1-49a0-a8e9-6139612dfc3b"), "ميناب", 25 },
                    { 1063, new Guid("1d5f1cee-4a46-4e30-8e3d-d37491349899"), "جيرنده", 27 },
                    { 1062, new Guid("cae36e26-3602-4d86-91fa-61b2399ff478"), "توتکابن", 27 },
                    { 1061, new Guid("aabd0abc-93ea-4217-98a0-bef0f3d5f0e1"), "بندر انزلي", 27 },
                    { 1060, new Guid("135a8709-92a9-4b17-a2dc-669343643956"), "بره سر", 27 },
                    { 1059, new Guid("1bf0c04b-737b-4f05-8054-7e2453d63eb3"), "بازار جمعه", 27 },
                    { 1058, new Guid("75f8d5cc-2fdb-408f-8e64-f0c24cddb834"), "املش", 27 },
                    { 1057, new Guid("8a599a94-d192-4370-83bc-b559c2c273cb"), "اطاقور", 27 },
                    { 1056, new Guid("0c63c20e-fa16-4a0b-b09d-006b85a5e8b2"), "اسالم", 27 },
                    { 1055, new Guid("940339cf-8920-4d4a-9a50-4acbd8630456"), "احمد سرگوراب", 27 },
                    { 1054, new Guid("259e20e4-e86a-4c80-a85c-ad8a8eb35278"), "آستانه اشرفيه", 27 },
                    { 1053, new Guid("c8bb3bf4-2b41-4fd9-bf23-c4a7051047dd"), "آستارا", 27 },
                    { 1052, new Guid("ab37d270-a771-4567-99a7-476f973c74b8"), "کميجان", 26 },
                    { 1051, new Guid("ff91771a-7efc-4f09-812f-45359fa3a804"), "کارچان", 26 },
                    { 1050, new Guid("c39a4133-2d6c-4f27-9101-e64a6a6c6c68"), "پرندک", 26 },
                    { 1049, new Guid("e067c5ee-7648-4be4-bdf8-6888600ec587"), "هندودر", 26 },
                    { 1064, new Guid("1cbf811e-7567-4236-8435-f721814409d7"), "حويق", 27 },
                    { 1065, new Guid("cd93b8af-0ac3-492e-8d69-1b50ed98aacf"), "خشکبيجار", 27 },
                    { 1066, new Guid("455132c4-e2f7-482f-8e69-1e9e2f41edfb"), "خمام", 27 },
                    { 1067, new Guid("34f8c17e-1e0b-45ed-8381-568bd44d73f4"), "ديلمان", 27 },
                    { 1083, new Guid("bd212641-9b33-42aa-8d68-dacb80e1713e"), "لشت نشاء", 27 },
                    { 1082, new Guid("eadc2edc-fd4d-4102-9324-9722387155fc"), "لاهيجان", 27 },
                    { 1081, new Guid("b10bba1c-2bbf-4350-99ba-d3a6854df283"), "فومن", 27 },
                    { 1080, new Guid("8e72cdae-1543-4758-bf1e-8968aa71a06b"), "صومعه سرا", 27 },
                    { 1079, new Guid("3242594d-cced-4e84-9a9a-52f721bbb0f6"), "شلمان", 27 },
                    { 1078, new Guid("ed74999b-ac87-4c14-9500-51f11b4bb4c3"), "شفت", 27 },
                    { 1077, new Guid("2876795c-dfec-456c-b46c-6cdbc4095ba5"), "سياهکل", 27 },
                    { 1048, new Guid("385e1885-7eb5-4397-997d-77c6c17bbdde"), "نيمور", 26 },
                    { 1076, new Guid("cd11d319-23cb-430e-a3fd-be9f765e5d98"), "سنگر", 27 },
                    { 1074, new Guid("54c61f30-2bff-4520-9983-a8f7c303b411"), "رودبنه", 27 },
                    { 1073, new Guid("2725d0bb-8830-46e1-a3d5-8b533a74c693"), "رودبار", 27 },
                    { 1072, new Guid("af9db1ce-9776-42d0-bd7b-0e1425660072"), "رضوانشهر", 27 },
                    { 1071, new Guid("d7755e8c-59f5-4b17-9773-e3a14b05adaf"), "رشت", 27 },
                    { 1070, new Guid("058dae54-edc1-4a6e-b2e9-a21478e35e08"), "رستم آباد", 27 },
                    { 1069, new Guid("84d4340c-440d-44e2-b1ea-bd1807255393"), "رحيم آباد", 27 },
                    { 1068, new Guid("8f21fd1e-918d-43d8-89e9-69d17899ce27"), "رانکوه", 27 },
                    { 1075, new Guid("6721f0f5-1324-4260-b8ac-0f4920fcc147"), "رودسر", 27 },
                    { 1047, new Guid("b9607574-d428-4e57-856f-9a58d2a908a0"), "نوبران", 26 },
                    { 1046, new Guid("8b25fe00-6902-4587-800d-cb8fb7ebcec2"), "نراق", 26 },
                    { 1045, new Guid("111cf00d-8835-4c00-80b4-2383e34b2d5f"), "ميلاجرد", 26 },
                    { 1024, new Guid("49ecbfc0-a66c-4407-8455-9d44d7eb9b9c"), "تفرش", 26 },
                    { 1023, new Guid("5a4cb839-1a35-46a5-806f-90ffdcdc7a38"), "اراک", 26 },
                    { 1022, new Guid("17e3221e-abd9-4d91-9941-b0da7f85cafc"), "آوه", 26 },
                    { 1021, new Guid("6922cd02-a868-448a-b728-0dab1cc4b84d"), "آشتيان", 26 },
                    { 1020, new Guid("9700afcf-ea23-4701-a7b4-011a19d1fe23"), "آستانه", 26 },
                    { 1019, new Guid("d389f5a4-18f6-47c7-9c50-8cc965cd7d62"), "گوهران", 25 },
                    { 1018, new Guid("cf30320e-29a4-40b7-bfb0-a6c69efd8204"), "گروک", 25 },
                    { 1025, new Guid("215fff21-9c2a-4dfe-b310-beb2c14cdad9"), "توره", 26 },
                    { 1017, new Guid("36f2e6e0-126a-440f-af07-f67a91f4bd47"), "کيش", 25 },
                    { 1015, new Guid("1050c4ba-4d57-41c9-9dab-31aae4ef5308"), "کوشکنار", 25 },
                    { 1014, new Guid("a15b4e39-76de-42e8-a855-a1db42a383e8"), "کوخردهرنگ", 25 },
                    { 1013, new Guid("834730cd-34a6-4b11-a19e-ccbac30ffda6"), "کنگ", 25 },
                    { 1012, new Guid("f32627f0-71fa-48f9-8431-257bbf887b47"), "چارک", 25 },
                    { 1011, new Guid("4fa54fdb-6da7-46f6-81cf-3c1121db0834"), "پارسيان", 25 },
                    { 1010, new Guid("99578009-23ee-40aa-bb86-23b2a5cbdd89"), "هشتبندي", 25 },
                    { 1009, new Guid("7dba598c-41e2-4fe6-9b30-22bafd28328c"), "هرمز", 25 },
                    { 1016, new Guid("76cb6141-008b-4760-bfd7-a459f272ae38"), "کوهستک", 25 },
                    { 1007, new Guid("dcfe360c-03d0-4b4f-8804-1a7721514fb1"), "لمزان", 25 },
                    { 1026, new Guid("5557a45d-e8ff-4cae-a3b0-570966c939c8"), "جاورسيان", 26 },
                    { 1028, new Guid("4a8e13ff-e8e5-4e3e-bfaf-a21b28d991d0"), "خمين", 26 },
                    { 1044, new Guid("4d789e14-5784-47d0-a9a2-e75b9c9301a0"), "محلات", 26 },
                    { 1043, new Guid("129eb6aa-0c2a-4a40-a3d2-fd1f32691b60"), "مامونيه", 26 },
                    { 1042, new Guid("6ec79e5e-eb7e-4730-a2c8-f1bbec15680d"), "قورچي باشي", 26 },
                    { 1041, new Guid("df399cde-f051-4fd7-8365-9f6c86582237"), "فرمهين", 26 },
                    { 1040, new Guid("ef50c0f2-bdd9-4ac8-889b-ec04e3382d23"), "غرق آباد", 26 },
                    { 1039, new Guid("4d827762-f24a-4424-a445-815ce0138027"), "شهر جديد مهاجران", 26 },
                    { 1038, new Guid("e5d89bd7-27fa-4373-99ac-174ccb1e0619"), "شهباز", 26 },
                    { 1027, new Guid("a88d07a8-a704-4451-a433-3eb4068bf433"), "خشکرود", 26 },
                    { 1037, new Guid("85045e40-7d01-4a48-8c08-78522fd2c7e9"), "شازند", 26 },
                    { 1035, new Guid("1d39db22-1767-46a9-8e76-2c7dc3615c63"), "ساروق", 26 },
                    { 1034, new Guid("f105395e-892d-4c16-8a06-fb6b6067124a"), "زاويه", 26 },
                    { 1033, new Guid("bab57eca-68ac-4525-a3ff-3f73a16f2915"), "رازقان", 26 },
                    { 1032, new Guid("97430dd5-28ba-470a-a495-631be1714fa0"), "دليجان", 26 },
                    { 1031, new Guid("c6ad8e95-74af-4b22-9498-a61ef2d6145c"), "داود آباد", 26 },
                    { 1030, new Guid("9db71ba3-a44e-4192-9173-8f6cd231ce30"), "خنداب", 26 },
                    { 1029, new Guid("9562ba3e-6e1a-4664-8409-cd048e175295"), "خنجين", 26 },
                    { 1036, new Guid("adcf3b30-0863-465e-aa1c-29485ee7ec95"), "ساوه", 26 },
                    { 613, new Guid("5c31d58d-3bb1-486f-b2ae-3b915a3cbbf6"), "ابوزيد آباد", 19 },
                    { 612, new Guid("db2c88e0-111a-4499-8ef0-54c83d474425"), "ابريشم", 19 },
                    { 611, new Guid("93b76b56-3155-4024-8128-1fab6e6b33a1"), "آران و بيدگل", 19 },
                    { 207, new Guid("a435ea6e-25e4-4704-8dae-44a97d790f26"), "سلامي", 8 },
                    { 206, new Guid("8d184e61-554f-45d7-8d3d-df0623db320b"), "سفيد سنگ", 8 },
                    { 205, new Guid("be579e1f-fad1-42df-9d18-b4de681fc4e8"), "سرخس", 8 },
                    { 204, new Guid("40dc84e8-c734-45a9-9ae8-34fad42fe5a3"), "سبزوار", 8 },
                    { 203, new Guid("15c3245d-9032-443c-8201-32347db8d90e"), "ريوش", 8 },
                    { 202, new Guid("5decad1a-5cb4-4884-bed7-39d7e3202c21"), "روداب", 8 },
                    { 201, new Guid("bc9f439e-c0d9-4496-8b31-f5704c9fcd44"), "رضويه", 8 },
                    { 200, new Guid("f8044802-964d-4c45-aa73-d48c722628fc"), "رشتخوار", 8 },
                    { 199, new Guid("22e23da8-c5b9-404b-ac4b-9c3e02d1fbf6"), "رباط سنگ", 8 },
                    { 198, new Guid("b483aac9-893b-412a-923e-c5d9724837c9"), "دولت آباد", 8 },
                    { 197, new Guid("b3dec8b1-368e-4b64-a3dc-b8f3497a837a"), "درگز", 8 },
                    { 196, new Guid("1c549cf3-627f-4209-917e-bddf35e0dce1"), "درود", 8 },
                    { 195, new Guid("ec374b07-e39f-4d31-a883-5869089d2e76"), "داورزن", 8 },
                    { 194, new Guid("60e8e52a-4636-403a-8f0f-9a967bc1cbcc"), "خواف", 8 },
                    { 193, new Guid("f6ffcc82-e67d-4f8c-9e46-5974a3d2a1f4"), "خليل آباد", 8 },
                    { 208, new Guid("a40d1a2f-c16d-40fc-9b04-842f3abbaf44"), "سلطان آباد", 8 },
                    { 192, new Guid("9f354e75-559b-4460-a2d7-446411bc3d3c"), "خرو", 8 },
                    { 209, new Guid("d37a8afe-49cc-4119-b333-02e3649238d1"), "سنگان", 8 },
                    { 211, new Guid("540e08af-41d7-419a-b12e-8f798973a5d6"), "شانديز", 8 },
                    { 226, new Guid("3859233c-7181-443b-b2d6-a6d95c90fdc1"), "لطف آباد", 8 },
                    { 225, new Guid("61b332c5-07d5-435d-a5c4-caed53c3250a"), "قوچان", 8 },
                    { 224, new Guid("c74b182a-63be-4206-887f-6b74b0624173"), "قلندر آباد", 8 },
                    { 223, new Guid("146d90c9-bbea-409f-9963-bfd93f704d85"), "قدمگاه", 8 },
                    { 222, new Guid("912f6c4f-8102-46fc-8362-046b477b4ecf"), "قاسم آباد", 8 },
                    { 221, new Guid("d1071845-51e2-44fb-aa92-36f946856b8e"), "فيض آباد", 8 },
                    { 220, new Guid("e5d727c6-c148-4b93-a3bb-b09f6535a063"), "فيروزه", 8 },
                    { 219, new Guid("29046eda-f9c3-4f1b-b9a7-62d8d3519e26"), "فريمان", 8 },
                    { 218, new Guid("61d5a02d-1917-4b55-929c-4bd3bb596e9b"), "فرهاد گرد", 8 },
                    { 217, new Guid("b8efdaf5-5657-4c3b-8cc2-f62a738e9c1d"), "عشق آباد", 8 },
                    { 216, new Guid("0653c9e0-7615-4415-adab-013098ec4854"), "طرقبه", 8 },
                    { 215, new Guid("944dc6d9-20a3-4d72-bbc0-30ccd054ba97"), "صالح آباد", 8 },
                    { 214, new Guid("e398b80d-fac3-4ca6-a6f9-1095b6bfe567"), "شهرآباد", 8 },
                    { 213, new Guid("9b686b99-cbd5-455d-aca9-fa414fd47595"), "شهر زو", 8 },
                    { 212, new Guid("33aa1fb2-459e-418d-ac1a-82fe017b4831"), "ششتمد", 8 },
                    { 210, new Guid("2ed956c4-589a-47aa-b5cc-f27f404dd913"), "شادمهر", 8 },
                    { 227, new Guid("eeea9bb2-cad6-49a9-9d08-4a8046cf1b25"), "مزدآوند", 8 },
                    { 191, new Guid("64adc117-c199-499d-b3a1-77a5e9f99cd5"), "جنگل", 8 },
                    { 189, new Guid("2e38fe67-17c7-46be-904f-02abfca82219"), "تربت حيدريه", 8 },
                    { 169, new Guid("cf24e190-2a8a-48fd-bad0-2a443dcca839"), "نازک عليا", 7 },
                    { 168, new Guid("c31be040-141d-4462-bd6d-12164409f56e"), "ميرآباد", 7 },
                    { 167, new Guid("45072e9e-5ed1-439f-8b69-af0e230bfa74"), "مياندوآب", 7 },
                    { 166, new Guid("d1447ffe-4cf6-4848-b288-37ccb558785b"), "مهاباد", 7 },
                    { 165, new Guid("7f5155c5-c531-4272-90bc-ea53128fafd0"), "مرگنلر", 7 },
                    { 164, new Guid("bf2c731e-0102-44d5-bc80-9134bbbd4f56"), "محمود آباد", 7 },
                    { 163, new Guid("cca0d177-6e24-4420-a79b-a54d41ad9194"), "محمد يار", 7 },
                    { 162, new Guid("f643bd32-a5d9-4c29-a9c7-624f217ebf85"), "ماکو", 7 },
                    { 161, new Guid("ec0375e9-735a-48e9-85ce-89b456e68c43"), "قوشچي", 7 },
                    { 160, new Guid("5b0a7285-8d4f-43e3-9337-48193a8510a9"), "قطور", 7 },
                    { 159, new Guid("a6f075a4-9c1b-42f6-85ed-70f71fd85a68"), "قره ضياء الدين", 7 },
                    { 158, new Guid("9aa34093-20cd-414a-8578-f4c0b7165100"), "فيرورق", 7 },
                    { 157, new Guid("fa0776dc-53a5-4f9f-ae9d-617d1df1ad69"), "شوط", 7 },
                    { 156, new Guid("932d69a3-7362-42a3-9159-84b22890f683"), "شاهين دژ", 7 },
                    { 155, new Guid("4869bdd6-2114-4148-a35c-8272d8d614ca"), "سيه چشمه", 7 },
                    { 170, new Guid("a37a3888-8dd9-48a0-b3e6-434bcfbcb037"), "نالوس", 7 },
                    { 190, new Guid("869711a7-34d0-4fdd-97d8-afa88d0a76d9"), "جغتاي", 8 },
                    { 171, new Guid("fea1f496-37a5-442b-b390-b801255a823f"), "نقده", 7 },
                    { 173, new Guid("2f7120ec-ff85-4f42-8abb-e466989e9575"), "پلدشت", 7 },
                    { 188, new Guid("811ef31c-c05c-49cd-bc30-50e2f7f03c04"), "تربت جام", 8 },
                    { 187, new Guid("d7b4f35d-3685-4baa-940c-afb22e82892a"), "تايباد", 8 },
                    { 186, new Guid("e8bfa03f-9238-4a9f-800b-de679ebf5928"), "بيدخت", 8 },
                    { 185, new Guid("4a28f130-a5ea-4647-ad4d-491c159652df"), "بردسکن", 8 },
                    { 184, new Guid("0bee845a-4fd2-42f2-b83e-f97393a8167c"), "بجستان", 8 },
                    { 183, new Guid("149e434f-b712-40a6-ac4f-990d62556190"), "بايک", 8 },
                    { 182, new Guid("d41187de-3403-433f-82cc-9330cc584be6"), "بار", 8 },
                    { 181, new Guid("5c0ae527-6262-4ffa-bf0a-bb7041562c83"), "باخرز", 8 },
                    { 180, new Guid("b849684a-8e0f-47a3-9b5d-c67941d9f02a"), "باجگيران", 8 },
                    { 179, new Guid("7592382e-6e3a-4d25-9152-dc46c41edb12"), "انابد", 8 },
                    { 178, new Guid("0386a732-108b-4695-9b5f-dce1de0080c0"), "احمدآباد صولت", 8 },
                    { 177, new Guid("7cf72380-abeb-4133-80ad-daeadebbaac3"), "گردکشانه", 7 },
                    { 176, new Guid("c165fb66-4337-4677-a6ee-56ad7542c7dc"), "کشاورز", 7 },
                    { 175, new Guid("38b085a5-4882-412a-8fc5-bea25e2f8b62"), "چهار برج", 7 },
                    { 174, new Guid("e5eefc42-ae75-423f-809d-1d1758157ae7"), "پيرانشهر", 7 },
                    { 172, new Guid("2ac921d3-b814-473d-8231-eb73e5200b2b"), "نوشين", 7 },
                    { 228, new Guid("158f9ee4-2f0d-43cf-a36a-7d7543086ecd"), "مشهد", 8 },
                    { 229, new Guid("b183eae4-b93c-41fe-a198-ced8b6dfbc04"), "مشهدريزه", 8 },
                    { 230, new Guid("196f4290-14c3-4f9d-8634-ed0eb47a5b49"), "ملک آباد", 8 },
                    { 284, new Guid("bd35ea6a-62d6-4923-8a0c-8df2dcf176e8"), "کنارک", 9 },
                    { 283, new Guid("884420c6-de4e-481e-9681-13e6e518ac43"), "چاه بهار", 9 },
                    { 282, new Guid("205f4e8c-1b7b-4dc7-8cfe-a8ccb8e50beb"), "پيشين", 9 },
                    { 281, new Guid("aa23ec53-5d42-4647-b95d-558c642f13a1"), "هيدوچ", 9 },
                    { 280, new Guid("599f67b3-5c08-4ae1-8e0a-8c6593c310df"), "نگور", 9 },
                    { 279, new Guid("e076a98c-d1d5-44e4-a966-cd54ffde8d8e"), "نيک شهر", 9 },
                    { 278, new Guid("4fd079ae-c794-47f3-8599-b2f2cfa79141"), "نوک آباد", 9 },
                    { 277, new Guid("2ebac2cc-25b1-4feb-9b00-bcf509366ed7"), "نصرت آباد", 9 },
                    { 276, new Guid("92bac1a6-75ee-4afb-b00c-37bc50b40fc7"), "ميرجاوه", 9 },
                    { 275, new Guid("5085d987-766a-4e26-91fc-bd11ed9f71ab"), "مهرستان", 9 },
                    { 274, new Guid("9d2dd5e2-46c9-4338-adab-f950eb94b834"), "محمدي", 9 },
                    { 273, new Guid("1a19f78a-7c50-49cc-a911-c27217945882"), "محمدان", 9 },
                    { 272, new Guid("8754402b-16f2-4fff-9bd7-f2ca3c706fbd"), "محمد آباد", 9 },
                    { 271, new Guid("4868f02c-7a86-43fc-a00c-9b2139b51af4"), "قصر قند", 9 },
                    { 270, new Guid("0110330b-748f-4a39-b34a-dd45d6b0fb4d"), "فنوج", 9 },
                    { 285, new Guid("895fe3f3-a288-4996-8adc-857755330a5e"), "گشت", 9 },
                    { 269, new Guid("9ff1a5ef-3bc3-4239-a2a0-95a3f866d479"), "علي اکبر", 9 },
                    { 286, new Guid("14756c8b-cce1-4c0e-ab71-2e7f1de2aacd"), "گلمورتي", 9 },
                    { 288, new Guid("e4e1f106-c97f-4e75-a9c3-8ce2a8b434a7"), "آيسک", 10 },
                    { 303, new Guid("4437bec3-066e-4b09-a0a3-6873feebddec"), "شوسف", 10 },
                    { 302, new Guid("fc830661-1d9f-4140-96a2-0db69c9589c7"), "سه قلعه", 10 },
                    { 301, new Guid("29ad9a91-5d09-42d6-9e4b-732d7a256fe9"), "سربيشه", 10 },
                    { 300, new Guid("928cb333-b3fd-4080-bb8b-c48c3373e5d4"), "سرايان", 10 },
                    { 299, new Guid("7b008eea-7a27-43f5-8894-c9845186cc99"), "زهان", 10 },
                    { 298, new Guid("3e6b3283-4d10-4d01-ab73-a291ccea7529"), "ديهوک", 10 },
                    { 1241, new Guid("6d6d5b30-21f5-4432-aa40-dbd76ba56ec1"), "گراب سفلي", 31 },
                    { 296, new Guid("df233655-8feb-4239-9550-926eaf980a5e"), "خضري دشت بياض", 10 },
                    { 295, new Guid("98a5e6e9-2523-4afe-b070-8f6e5cf7ff29"), "حاجي آباد", 10 },
                    { 294, new Guid("862a22ac-8968-4c8e-912c-91006e2654dd"), "بيرجند", 10 },
                    { 293, new Guid("686ac3ec-3cc7-4b28-9942-95594b1c3884"), "بشرويه", 10 },
                    { 292, new Guid("510c7781-a89d-4181-ab69-1c990fcb006c"), "اسلاميه", 10 },
                    { 291, new Guid("b9ae7ed4-f724-4592-9081-3fff3e0a5323"), "اسفدن", 10 },
                    { 290, new Guid("45197eb6-62ec-4b02-86d0-cee80ad7728e"), "اسديه", 10 },
                    { 289, new Guid("d7a0c875-624e-4437-abaf-8e9ade9fdc3e"), "ارسک", 10 },
                    { 287, new Guid("054ddacd-415e-42d8-9b06-6e35130fb960"), "آرين شهر", 10 },
                    { 268, new Guid("35c7c016-a14f-4efc-ac69-879142402f84"), "سيرکان", 9 },
                    { 267, new Guid("3b60e0f6-4587-4c15-badc-9bd66080d2fa"), "سوران", 9 },
                    { 266, new Guid("8f782c95-f643-402c-9c81-039a5b378b39"), "سرباز", 9 },
                    { 245, new Guid("09af4cf0-6aeb-4981-a112-deee20b65403"), "کدکن", 8 },
                    { 244, new Guid("841cf695-f39f-4f72-9f04-a3e7a85faeec"), "کاشمر", 8 },
                    { 243, new Guid("216d428f-7380-4ab2-9d48-7e25ab8abfb9"), "کاريز", 8 },
                    { 242, new Guid("9bc36477-e5e2-4e1d-84b4-76b969aac0ac"), "کاخک", 8 },
                    { 241, new Guid("9006c10d-164c-4e12-b2a8-9653ee7f6a4e"), "چکنه", 8 },
                    { 240, new Guid("882d8b9a-c3dd-4527-89e0-cf29386c71b0"), "چناران", 8 },
                    { 239, new Guid("c729c66c-8fa8-4a3d-b58c-a7cb38676d0e"), "چاپشلو", 8 },
                    { 238, new Guid("80ebc616-8b70-4436-9aec-00e85f0b3c94"), "يونسي", 8 },
                    { 237, new Guid("55356d92-b7b2-435f-af6b-078bf52915ba"), "همت آباد", 8 },
                    { 236, new Guid("287869fc-2f0c-4abc-8892-ad3efb4362b8"), "نيل شهر", 8 },
                    { 235, new Guid("5dd5aa2c-1cee-46a0-8cdc-abc2ef342034"), "نيشابور", 8 },
                    { 234, new Guid("2d2253bd-2e58-44b2-b1e0-e06816566330"), "نوخندان", 8 },
                    { 233, new Guid("755328e8-faef-4278-94eb-3b0040380b8c"), "نقاب", 8 },
                    { 232, new Guid("5e9f1999-195e-40da-8e63-a412caf3866e"), "نصرآباد", 8 },
                    { 231, new Guid("06b01f55-85fc-4aae-a9a4-0c33b2b379d0"), "نشتيفان", 8 },
                    { 246, new Guid("a49150c9-be1b-403a-9d45-bb91ead1279f"), "کلات", 8 },
                    { 247, new Guid("67e92a7c-1e0d-4752-940b-9d29660132b5"), "کندر", 8 },
                    { 248, new Guid("0cb51574-4ae4-4beb-b92e-bdfef41d5ce3"), "گلمکان", 8 },
                    { 249, new Guid("b7013dd4-f6b6-473f-9eeb-de7508545156"), "گناباد", 8 },
                    { 265, new Guid("b41f14fc-f96e-4b96-97ce-15da0c1b5ac4"), "سراوان", 9 },
                    { 264, new Guid("7b812d45-bf89-47ed-988a-85969ae2e3cb"), "زهک", 9 },
                    { 263, new Guid("c3cb211a-d7f2-4cab-b67f-254dea357d05"), "زرآباد", 9 },
                    { 262, new Guid("780097a7-5f89-4b25-b574-46ff1eb3a682"), "زاهدان", 9 },
                    { 261, new Guid("c618ad02-41df-424e-a9df-417552a6a5b8"), "زابل", 9 },
                    { 260, new Guid("e2e190f6-5299-4217-8ce6-d749cb17991d"), "راسک", 9 },
                    { 259, new Guid("d615a77f-ac38-45f8-a579-d41523064f67"), "دوست محمد", 9 },
                    { 154, new Guid("25ece9c4-adb5-47b7-907c-fe98bec2c4c0"), "سيمينه", 7 },
                    { 258, new Guid("004f5b0b-4d70-4737-a47b-b8fb086174fa"), "خاش", 9 },
                    { 256, new Guid("46afbdda-80ad-4a5e-96de-a09a709f5972"), "بنجار", 9 },
                    { 255, new Guid("c2396ad2-fa70-4b0a-9f96-5df17ebe7479"), "بنت", 9 },
                    { 254, new Guid("5d4d457f-62be-4844-b09a-b08139145a57"), "بمپور", 9 },
                    { 253, new Guid("e0e99495-da67-4046-bc13-23f71f4811a9"), "بزمان", 9 },
                    { 252, new Guid("8c250219-a234-40fa-bca2-6f14e97933ed"), "ايرانشهر", 9 },
                    { 251, new Guid("11854bcf-5c3e-402f-8f29-7a9a93316fb1"), "اسپکه", 9 },
                    { 250, new Guid("f73e4725-2a6d-41c3-add8-67265a32b226"), "اديمي", 9 },
                    { 257, new Guid("811a7ccf-56f0-4cc9-8f31-5b76fa9309b3"), "جالق", 9 },
                    { 153, new Guid("cf81c253-2a5f-4329-889c-912aa0a3daf0"), "سيلوانه", 7 },
                    { 152, new Guid("4d723c6c-ab49-4cf5-8ce7-19b262027d52"), "سلماس", 7 },
                    { 151, new Guid("e117ac11-97b7-4c21-803f-7f7417c1e035"), "سرو", 7 },
                    { 54, new Guid("88bbada2-08e9-4ccb-9093-0f48a5a5e752"), "پردنجان", 2 },
                    { 53, new Guid("97b441cf-a3a8-4f7e-988b-e417179771df"), "وردنجان", 2 },
                    { 52, new Guid("f1c478c2-b200-4a3a-a68b-fcdbe81780af"), "هفشجان", 2 },
                    { 51, new Guid("47b2afaa-4360-4387-b781-1ac200557293"), "هاروني", 2 },
                    { 50, new Guid("3bfbdb3f-7b91-4991-8028-1ae22ae63509"), "نقنه", 2 },
                    { 49, new Guid("70b683f0-f515-4164-b316-4051a5af5727"), "نافچ", 2 },
                    { 48, new Guid("cccafee4-e143-44b2-a859-c16f6e89bb1e"), "ناغان", 2 },
                    { 47, new Guid("3d55c5c1-c96e-4ea9-af82-0fbe1409e123"), "منج", 2 },
                    { 46, new Guid("fd5e5f9b-d093-406f-a592-77653531d999"), "مال خليفه", 2 },
                    { 45, new Guid("41749a84-25e6-42ac-b0dc-21739c2aa4b5"), "لردگان", 2 },
                    { 44, new Guid("54ae9812-52f0-47d9-8dc3-531d1b7fa53b"), "فرخ شهر", 2 },
                    { 43, new Guid("2554fba0-a7da-4906-aa6b-fb837d41324d"), "فرادنبه", 2 },
                    { 42, new Guid("6017c8dc-bdaf-44ef-9ef8-f0e1a098d687"), "فارسان", 2 },
                    { 41, new Guid("b0d692d8-a035-4f4a-af11-c85c7a696aa4"), "طاقانک", 2 },
                    { 40, new Guid("1da51473-3afd-4cf5-81c1-e31042f95daa"), "صمصامي", 2 },
                    { 55, new Guid("f63aa89c-1cd1-48d3-9c88-49640ffa281b"), "چليچه", 2 },
                    { 39, new Guid("3a55f861-1a54-49cf-9632-d5be7e84fa8c"), "شهرکرد", 2 },
                    { 56, new Guid("a6b782a2-6139-494d-9de9-63a34192e69a"), "چلگرد", 2 },
                    { 58, new Guid("a501efe8-0139-4997-9aa4-b48a705c8aa5"), "کيان", 2 },
                    { 73, new Guid("e77a1618-a841-47ff-82bd-bf64eb152e85"), "سنخواست", 3 },
                    { 72, new Guid("80eaca53-4e75-4963-8972-066fdacc5699"), "زيارت", 3 },
                    { 71, new Guid("94b0c2bf-9ee3-489e-8758-2c44266a4e9e"), "راز", 3 },
                    { 70, new Guid("87da2cbc-8f01-4019-9bfe-3f2a679e22ed"), "درق", 3 },
                    { 69, new Guid("b6c3bcfe-b111-4cfa-98c5-4a1733dd927d"), "حصارگرمخان", 3 },
                    { 68, new Guid("c58ce276-e16a-49bc-bc7d-4b68c3723867"), "جاجرم", 3 },
                    { 67, new Guid("a7addbee-2e65-490e-88bf-f80161bd1908"), "تيتکانلو", 3 },
                    { 66, new Guid("5bacfdac-6af2-4de7-b921-77f259375d35"), "بجنورد", 3 },
                    { 65, new Guid("ac883e75-b185-4b8b-8c84-778528de6b77"), "ايور", 3 },
                    { 64, new Guid("1bfe5634-f1b5-4339-93c6-afa8292f1b59"), "اسفراين", 3 },
                    { 63, new Guid("5cdfa69d-d525-43cb-96d2-fed9acb32022"), "آوا", 3 },
                    { 62, new Guid("2b72ea31-e173-436e-9476-a02ace88bd91"), "آشخانه", 3 },
                    { 61, new Guid("4d3359c3-a32a-4a2f-a1fc-57d2a946a399"), "گوجان", 2 },
                    { 60, new Guid("41f6ae5e-9d04-4d29-9ccf-28338b2cf463"), "گهرو", 2 },
                    { 59, new Guid("76342287-5fa1-45e3-ab90-3d7e8a8798dc"), "گندمان", 2 },
                    { 57, new Guid("0fd27126-fc3c-4636-a07b-17bb73dc10e9"), "کاج", 2 },
                    { 38, new Guid("e1d747ea-2a00-4fb1-87af-f9c40f5042f2"), "شلمزار", 2 },
                    { 37, new Guid("5bb7e60f-63f7-40ce-9402-eb7f83ea1383"), "سورشجان", 2 },
                    { 36, new Guid("77ca68fd-9669-4bfc-89bd-c3baa3636c59"), "سودجان", 2 },
                    { 15, new Guid("0379f825-7642-4260-b614-a1318dca7d1a"), "مهردشت", 1 },
                    { 14, new Guid("27d03816-16b3-4937-af6f-94b0137b25ca"), "مروست", 1 },
                    { 13, new Guid("142abf47-165d-406f-b2b9-b2ab3307b5f5"), "عقدا", 1 },
                    { 12, new Guid("9a536d4a-c810-40ac-b8c4-08e397df9f19"), "شاهديه", 1 },
                    { 11, new Guid("40ee300f-c619-4300-b7eb-d8b2df7e11c7"), "زارچ", 1 },
                    { 10, new Guid("fd8dae27-3b02-4244-8d80-6baa55b0932e"), "خضر آباد", 1 },
                    { 9, new Guid("539273bb-8647-4101-ace3-9882c7d6a421"), "حميديا", 1 },
                    { 8, new Guid("4aa6035b-af16-4d5d-9cbd-a00e97d986ea"), "تفت", 1 },
                    { 7, new Guid("43945b64-86f7-45ee-9713-e9709c5d6725"), "بهاباد", 1 },
                    { 6, new Guid("e072a226-d5dd-4aeb-a559-b0c4318ab41c"), "بفروئيه", 1 },
                    { 5, new Guid("2c601b47-d323-498a-abb7-850fb3c90f0d"), "بافق", 1 },
                    { 4, new Guid("59e7159b-04e3-499d-8e69-fb6f026e0b6a"), "اشکذر", 1 },
                    { 3, new Guid("28f59a58-7f95-4dd0-92c1-cc0a06e47cd1"), "اردکان", 1 },
                    { 2, new Guid("2a29e8f6-bce6-4316-8507-0c1bd8f61393"), "احمد آباد", 1 },
                    { 1, new Guid("418fdc2c-723a-4b6d-b674-5d8f7ef00f84"), "ابرکوه", 1 },
                    { 16, new Guid("399365da-6ff3-4c82-9a4c-b698c474124d"), "مهريز", 1 },
                    { 17, new Guid("4996eb6b-9df7-4f5e-a78a-6c64c1a8a566"), "ميبد", 1 },
                    { 18, new Guid("3b659f08-cb78-47ae-aa2a-d5f54b1e0d83"), "ندوشن", 1 },
                    { 19, new Guid("14d2bfd6-3476-410b-be41-3a958aa9c379"), "نير", 1 },
                    { 35, new Guid("c8177364-53f7-48ad-a9ee-1e11592276dd"), "سفيد دشت", 2 },
                    { 34, new Guid("23ab50e3-0935-4954-a874-ff142df7dc0b"), "سردشت لردگان", 2 },
                    { 33, new Guid("6f3c829c-a01e-4aed-aeea-2be516e6ea0d"), "سرخون", 2 },
                    { 32, new Guid("0a390c03-b7a2-4e2b-a3fd-7eecfe063fed"), "سامان", 2 },
                    { 31, new Guid("31958f32-a331-43b8-b222-c480022cb799"), "دشتک", 2 },
                    { 30, new Guid("617f60d5-7bec-4f54-acfa-8c30735c9094"), "دستناء", 2 },
                    { 29, new Guid("070d03f7-7a4c-4903-bd9d-6d38881a8225"), "جونقان", 2 },
                    { 74, new Guid("2b4df9d6-95fc-48bf-a903-a04ee58afad6"), "شوقان", 3 },
                    { 28, new Guid("e776a138-b843-4300-8796-c11705fca1c8"), "بن", 2 },
                    { 26, new Guid("4d8fdf30-bc84-409c-8070-1f3ea3085e5c"), "بروجن", 2 },
                    { 25, new Guid("f5c3f51f-b7c2-4da8-b540-2de1457e3b1e"), "بازفت", 2 },
                    { 24, new Guid("007db358-738a-4866-9df3-f491a590c1e3"), "باباحيدر", 2 },
                    { 23, new Guid("825c7f8a-49de-41c5-912d-dee580353405"), "اردل", 2 },
                    { 22, new Guid("48205d34-034a-414c-bb76-a6674296829b"), "آلوني", 2 },
                    { 21, new Guid("f66328bd-61d7-4f5d-b28a-b03ee3fd5fa9"), "يزد", 1 },
                    { 20, new Guid("2bea47bc-ed48-44a3-886d-7181e448f6d3"), "هرات", 1 },
                    { 27, new Guid("2b5e9d24-5bd2-414b-b7e4-d0a3deaf8fa9"), "بلداجي", 2 },
                    { 304, new Guid("cb6edfd2-0063-4831-b8fb-fdb81bf0ae0e"), "طبس", 10 },
                    { 75, new Guid("605a457b-f374-48c6-abe3-160a437a8368"), "شيروان", 3 },
                    { 77, new Guid("68a0a97b-e3c5-4d09-a276-99aa964508ee"), "فاروج", 3 },
                    { 131, new Guid("dc3b56a1-d598-4ae8-a0a7-884470032f5b"), "پيرتاج", 6 },
                    { 130, new Guid("30a85bbb-7f3b-42f2-b863-5e6da7d93501"), "ياسوکند", 6 },
                    { 129, new Guid("dc878bf5-0e66-4808-95a5-7676c7335d76"), "موچش", 6 },
                    { 128, new Guid("77b8ae4c-b41b-4138-bb3b-7ca8870a2f5c"), "مريوان", 6 },
                    { 127, new Guid("6ebd3fc6-6db6-4995-b8de-8c37dafd4696"), "قروه", 6 },
                    { 126, new Guid("db03882a-ca7d-4418-9808-994a73cfa862"), "صاحب", 6 },
                    { 125, new Guid("33a56100-9eba-45df-b416-fd8950bc8edf"), "شويشه", 6 },
                    { 124, new Guid("cdeac1db-ffe5-40e7-9e09-3c5f6ddd84eb"), "سنندج", 6 },
                    { 123, new Guid("e910a0ff-1eff-41c7-8f84-ff77bef62c13"), "سقز", 6 },
                    { 122, new Guid("0749773f-e676-4726-a19d-97297de47c01"), "سريش آباد", 6 },
                    { 121, new Guid("53440b7a-6259-49c9-a471-e7d9c753e9f9"), "سرو آباد", 6 },
                    { 120, new Guid("737eac6d-03f9-482a-94eb-d5fe43754f16"), "زرينه", 6 },
                    { 119, new Guid("0347b019-efdd-4173-b63f-bd4285199ad8"), "ديواندره", 6 },
                    { 118, new Guid("22211712-22d1-41cd-96b8-c0bec661118f"), "دهگلان", 6 },
                    { 117, new Guid("2b8741a8-2bc7-4cc1-954d-7121c80a0513"), "دلبران", 6 },
                    { 132, new Guid("12a1d82c-54cf-4036-b939-adc1d99c39b0"), "چناره", 6 },
                    { 116, new Guid("84e04d0f-d432-4a65-9e85-4d9145122621"), "دزج", 6 },
                    { 133, new Guid("7c98a4ae-ca36-43fe-94f6-4981968aa582"), "کامياران", 6 },
                    { 135, new Guid("777fc041-21e3-4e24-a387-a6bd23fc8ba4"), "کاني سور", 6 },
                    { 150, new Guid("f301e571-aaf2-491b-ad9d-689ad7c0789e"), "سردشت", 7 },
                    { 149, new Guid("f78466b5-c2bf-4468-8634-69b61fe2c878"), "زرآباد", 7 },
                    { 148, new Guid("40b05e18-7ad4-40a9-b1c4-d533b9b7c8f5"), "ربط", 7 },
                    { 147, new Guid("96daef9a-3745-4aa1-b24a-c18da7681985"), "ديزج ديز", 7 },
                    { 146, new Guid("8d86ef1e-149a-4b58-9627-4d6d9f9f65ba"), "خوي", 7 },
                    { 145, new Guid("f03aa68c-9de3-445f-be76-90f1d3e502f4"), "خليفان", 7 },
                    { 144, new Guid("dfb9a616-3aa4-4c3a-b61b-304af2d2a05c"), "تکاب", 7 },
                    { 143, new Guid("a0d53c38-2949-4428-985e-f6ed016d0174"), "تازه شهر", 7 },
                    { 142, new Guid("9fff69de-df30-4a2b-90b6-b15caf8e88d5"), "بوکان", 7 },
                    { 141, new Guid("03f48921-9b6c-408a-801c-83b4ff6cf97b"), "بازرگان", 7 },
                    { 140, new Guid("98619e77-8d42-4980-967f-d9f48eaec64e"), "باروق", 7 },
                    { 139, new Guid("c5b8b8f5-cb33-4217-8d98-c6a58d0cdfaf"), "ايواوغلي", 7 },
                    { 138, new Guid("7a0aa77f-a84f-44c6-a325-754511db61fe"), "اشنويه", 7 },
                    { 137, new Guid("2e05b2d8-c893-4b89-b3fb-a550d018214d"), "اروميه", 7 },
                    { 136, new Guid("ec399989-ddbd-40b3-a69d-1a8072599d05"), "آواجيق", 7 },
                    { 134, new Guid("2e359574-5e5d-4da4-8139-b275b51010c8"), "کاني دينار", 6 },
                    { 115, new Guid("73fb9487-a6f8-4a01-b8f8-bbb4e780209a"), "توپ آغاج", 6 },
                    { 114, new Guid("a2cfd171-e34c-4062-b303-a4115962af13"), "بيجار", 6 },
                    { 113, new Guid("68864507-990c-4424-bf42-5b74f533100f"), "بوئين سفلي", 6 },
                    { 92, new Guid("4b2af68c-a217-4e90-a323-675a5abe4093"), "مشکين دشت", 4 },
                    { 91, new Guid("7e5f98fa-53a0-4ae3-8cc3-d820ac454ae5"), "محمد شهر", 4 },
                    { 90, new Guid("454a546b-eaae-4ca9-b65c-aab27d6c2049"), "ماهدشت", 4 },
                    { 89, new Guid("2095be63-a100-4f9e-9653-588a7b749d43"), "فرديس", 4 },
                    { 88, new Guid("7825161a-60bc-4512-883a-fb895ff59743"), "طالقان", 4 },
                    { 87, new Guid("7ebcebba-d4e3-41e3-922a-9501bfb2a5a5"), "شهر جديد هشتگرد", 4 },
                    { 86, new Guid("32ed38da-cd97-4d67-98ad-f753eff1fda2"), "تنکمان", 4 },
                    { 85, new Guid("58f0c2f4-11cd-46bf-9f88-2e1db2a41e58"), "اشتهارد", 4 },
                    { 84, new Guid("497dee05-3ce4-45c5-98d8-3bfbb924dd24"), "آسارا", 4 },
                    { 83, new Guid("78e49561-2fcc-406a-9fe3-58265c4b0d42"), "گرمه", 3 },
                    { 82, new Guid("4e4a8964-c3a3-4ef7-abe9-0e46dc30c45e"), "چناران شهر", 3 },
                    { 81, new Guid("082d6996-92ab-4d3d-ae4a-d2715bc9fbf6"), "پيش قلعه", 3 },
                    { 80, new Guid("d839410a-08be-406d-8fa5-be8564ac2f3f"), "لوجلي", 3 },
                    { 79, new Guid("6c70bc13-cf02-4b8d-b231-dc78d34163be"), "قوشخانه", 3 },
                    { 78, new Guid("925e5356-c3d6-440a-a74e-9e65ede5a8db"), "قاضي", 3 },
                    { 93, new Guid("b1bc9df3-eb09-4eea-83c8-82b3e3f7cee4"), "نظر آباد", 4 },
                    { 94, new Guid("7e0a15d1-160c-477c-9ba5-59213db10c2a"), "هشتگرد", 4 },
                    { 95, new Guid("68b75e1f-b3e3-42a1-a9c9-09d78a260137"), "چهارباغ", 4 },
                    { 96, new Guid("94caede3-d28d-45d3-953c-9b2298511c83"), "کرج", 4 },
                    { 112, new Guid("4b34db7d-5015-4eb1-b366-ebd3b86f1ae1"), "بلبان آباد", 6 },
                    { 111, new Guid("df5fc1b2-ad12-4fff-bcf9-7c906affa30d"), "برده رشه", 6 },
                    { 110, new Guid("bde5e54e-5d8f-41d2-b449-9ad5440e021f"), "بانه", 6 },
                    { 109, new Guid("438b6460-37e3-4368-a03f-4943ff943767"), "بابارشاني", 6 },
                    { 108, new Guid("45db6524-c14e-46af-a5c3-a19b533ca8de"), "اورامان تخت", 6 },
                    { 107, new Guid("58fdbb46-5d37-4c11-a472-3ce95c65c0ea"), "آرمرده", 6 },
                    { 106, new Guid("650fcb07-b815-4861-aaa4-202391874a13"), "کهک", 5 },
                    { 76, new Guid("1e212304-4fcb-4c4b-ba97-637ed4917653"), "صفي آباد", 3 },
                    { 105, new Guid("4dedfaa3-30a1-4135-95af-44345eebfcc5"), "قنوات", 5 },
                    { 103, new Guid("db221c75-bbbe-493c-a51d-93b23f347513"), "سلفچگان", 5 },
                    { 102, new Guid("5ff0cf1d-549c-485b-9893-6aebf9428b69"), "دستجرد", 5 },
                    { 101, new Guid("f8ddc3ca-0405-4b68-b26d-a7784365a426"), "جعفريه", 5 },
                    { 100, new Guid("e64cca31-b9d8-4fa7-b340-a50f0e192291"), "گلسار", 4 },
                    { 99, new Guid("b2bf9e75-ef23-4c52-9459-b6b8c097132f"), "گرمدره", 4 },
                    { 98, new Guid("632977e7-c652-4463-b68b-366c9db90271"), "کوهسار", 4 },
                    { 97, new Guid("0903e582-4a89-45e8-bb95-5af4ae7615d8"), "کمال شهر", 4 },
                    { 104, new Guid("3f07eabf-4763-4e6b-b141-b3acc69611d8"), "قم", 5 },
                    { 305, new Guid("6db4e8d0-1db5-4150-abc3-db62c5b29bcf"), "طبس مسينا", 10 },
                    { 297, new Guid("a148d7af-9a27-4d14-8950-64688d9b8b5d"), "خوسف", 10 },
                    { 307, new Guid("ad322b40-e14f-40a2-9feb-d3f1d0ba7211"), "فردوس", 10 },
                    { 514, new Guid("96609439-8a0e-4529-9b09-9433a9bbc118"), "نشتارود", 15 },
                    { 513, new Guid("00ad7e46-752e-42f7-98d0-529a9da184b7"), "مرزيکلا", 15 },
                    { 512, new Guid("f2a1dd22-9e2e-4085-af7d-d45982965c18"), "مرزن آباد", 15 },
                    { 511, new Guid("3b489093-4d96-4ffb-8228-fb31075c02fd"), "محمود آباد", 15 },
                    { 510, new Guid("34aec942-e5d7-42c0-9f97-cee483277c20"), "قائم شهر", 15 },
                    { 509, new Guid("0abc795a-0416-42f5-84b5-fb1e9992dbec"), "فريم", 15 },
                    { 508, new Guid("b9d2f54f-4846-42c7-a8a2-5c47b67421f7"), "فريدونکنار", 15 },
                    { 507, new Guid("6a7c2254-00c1-4010-b0cd-d75582293a48"), "عباس آباد", 15 },
                    { 506, new Guid("f9922ee8-14a1-4084-977b-a20fe8fa621d"), "شيرگاه", 15 },
                    { 505, new Guid("90c10f6c-6626-4f2f-999d-8ef356b19e16"), "شيرود", 15 },
                    { 504, new Guid("4246552d-8d97-4292-8be0-75076d721662"), "سورک", 15 },
                    { 503, new Guid("5f277528-0d07-4997-8966-4ad89427bdc1"), "سلمان شهر", 15 },
                    { 502, new Guid("71b19be8-3374-4830-a875-d112b6ae2fb7"), "سرخرود", 15 },
                    { 501, new Guid("678c185f-d848-47f7-b7cc-0ceda7f6ac6d"), "ساري", 15 },
                    { 500, new Guid("426710ed-2554-4324-9a67-e85d131e3341"), "زيرآب", 15 },
                    { 515, new Guid("317b575c-71d2-4de4-b7ff-c4a2c2b007f8"), "نور", 15 },
                    { 499, new Guid("7c525068-0b87-4d8c-9306-8d54296babd5"), "زرگر محله", 15 },
                    { 516, new Guid("a429dd22-a60c-4c57-9107-07c8cf425e45"), "نوشهر", 15 },
                    { 518, new Guid("2237b48d-ca8a-465f-aec3-9f38257389ce"), "هادي شهر", 15 },
                    { 533, new Guid("12a9d1ff-0af9-42b9-8e1b-67299ffac97c"), "گزنک", 15 },
                    { 532, new Guid("6a5a73bd-aa39-4061-b14f-aaa3148d2a34"), "گتاب", 15 },
                    { 531, new Guid("8878c066-0297-4930-a26d-3418a1710f48"), "کياکلا", 15 },
                    { 530, new Guid("ff4c6ccb-1110-4b75-b8a9-790cb3363469"), "کياسر", 15 },
                    { 529, new Guid("cde281e2-cced-425d-82c8-d78b85a7a905"), "کوهي خيل", 15 },
                    { 528, new Guid("4a9f132f-adfe-445e-8dae-907f381c013c"), "کلاردشت", 15 },
                    { 527, new Guid("2a45cd9e-0e84-44fb-bc80-d2b3a6b25a4f"), "کلارآباد", 15 },
                    { 526, new Guid("d0b3d51d-2844-4ab7-9105-afaaf6b8cd39"), "کجور", 15 },
                    { 525, new Guid("b32582c0-dc0e-4acf-86b3-647edf253798"), "کتالم و سادات شهر", 15 },
                    { 524, new Guid("0b71186f-024a-4bfa-88fc-281feac729a0"), "چمستان", 15 },
                    { 523, new Guid("87af224a-533e-4f1f-b8ab-02466aa387a1"), "چالوس", 15 },
                    { 522, new Guid("ab1e914a-b1f3-4626-914a-ef0bb17330dd"), "پول", 15 },
                    { 521, new Guid("3d8d4ab8-aeef-49ba-86c7-e39eec74f430"), "پل سفيد", 15 },
                    { 520, new Guid("2af0a9bf-0ae9-4211-86d3-e9503a8650aa"), "پايين هولار", 15 },
                    { 519, new Guid("594570f5-5453-4e7f-ab67-c26dcd0463ef"), "هچيرود", 15 },
                    { 517, new Guid("af48fa0a-467a-4f47-bda0-e92056409674"), "نکا", 15 },
                    { 534, new Guid("c23fd187-ceb3-412b-b2d3-c7f822a5f058"), "گلوگاه", 15 },
                    { 498, new Guid("f73d46c8-8b3e-4cfd-bcfc-4c6b6b63373d"), "رينه", 15 },
                    { 496, new Guid("409bf9de-6c4f-481c-b744-a6f45fc988f4"), "رستمکلا", 15 },
                    { 476, new Guid("67ed9fb8-8c6c-4070-ad03-349ba022e581"), "گميش تپه", 14 },
                    { 475, new Guid("fdc1bd0b-3a1f-4919-8880-83e794ef613e"), "گرگان", 14 },
                    { 474, new Guid("c7d99499-946e-40ad-9d37-a2b7c6732046"), "گاليکش", 14 },
                    { 473, new Guid("22ec7146-84c2-4938-ad03-254ce03b2d86"), "کلاله", 14 },
                    { 472, new Guid("1b0cef52-770c-41db-8852-c98378dc2c80"), "کرد کوي", 14 },
                    { 471, new Guid("1fd1e0ef-eb0e-4a82-8fe4-27aadd58e342"), "نگين شهر", 14 },
                    { 470, new Guid("20883cbd-198f-4e8a-ab24-e36793d28ee0"), "نوکنده", 14 },
                    { 469, new Guid("f1da9ce2-ef54-493c-919a-69e70c7e1765"), "نوده خاندوز", 14 },
                    { 306, new Guid("6e025c68-9f1d-4108-8842-4d876b57b9e2"), "عشق آباد", 10 },
                    { 467, new Guid("617fd850-a74a-4f2b-b6f5-9d12a6b444f5"), "مزرعه", 14 },
                    { 466, new Guid("9972c7ee-4886-4839-a1d5-77ce2956179e"), "مراوه تپه", 14 },
                    { 465, new Guid("508164a6-6c90-4b55-a539-31bb5eb46b31"), "فراغي", 14 },
                    { 464, new Guid("4a9b2706-46c8-45cb-b102-207d17c1375f"), "فاضل آباد", 14 },
                    { 463, new Guid("b0da4d94-dc40-4951-8b9d-670b44ccf77d"), "علي آباد", 14 },
                    { 462, new Guid("4ebe8857-b057-470f-a51d-d6b424907968"), "سيمين شهر", 14 },
                    { 477, new Guid("2fd024e4-397d-4b9b-a9f4-6a972e5eefd3"), "گنبدکاووس", 14 },
                    { 497, new Guid("9769d09c-6694-45be-816b-848d554812fb"), "رويان", 15 },
                    { 478, new Guid("7486af02-634d-4503-87a2-bbd5671fcefc"), "آلاشت", 15 },
                    { 480, new Guid("4071a34d-1ab1-429f-af7f-4b067db1cb9a"), "ارطه", 15 },
                    { 495, new Guid("26aea2cc-0e3b-47b8-bee3-0dc3dd25b144"), "رامسر", 15 },
                    { 494, new Guid("54866f5b-7b17-4a8c-a913-66c35287e4ad"), "دابودشت", 15 },
                    { 493, new Guid("2c85d17d-d9b5-4afa-ba46-e215be90364f"), "خوش رودپي", 15 },
                    { 492, new Guid("8a5f2693-7b81-41af-9fe4-dd05c2032178"), "خليل شهر", 15 },
                    { 491, new Guid("7290bd59-7626-4458-bde0-28864501b2b3"), "خرم آباد", 15 },
                    { 490, new Guid("8263eadd-37d8-45a0-8c1e-bf1548354c7c"), "جويبار", 15 },
                    { 489, new Guid("6d008261-4e45-4626-8f99-68757f9da038"), "تنکابن", 15 },
                    { 488, new Guid("e3b8d808-ae58-47c3-813e-674d6468c051"), "بهنمير", 15 },
                    { 487, new Guid("c30392e5-759f-440d-b253-8d6ec8588ae0"), "بهشهر", 15 },
                    { 486, new Guid("66da15ed-2a81-44ca-9329-52fbbef70088"), "بلده", 15 },
                    { 485, new Guid("42974384-73de-4311-a2e7-ebe11577d57f"), "بابلسر", 15 },
                    { 484, new Guid("b0f13aef-b1be-4be5-84ac-5fe9f36190cf"), "بابل", 15 },
                    { 483, new Guid("e1398efa-c6ed-4c16-8843-e7740be8663d"), "ايزد شهر", 15 },
                    { 482, new Guid("dcf2323d-b01e-498f-abb1-245300348584"), "امير کلا", 15 },
                    { 481, new Guid("45d7c992-c11e-47e7-a328-c569424b7b1a"), "امامزاده عبدالله", 15 },
                    { 479, new Guid("b58c1b20-415a-42fc-b947-2326dfe11782"), "آمل", 15 },
                    { 535, new Guid("b07b25c8-ea80-4daa-b134-a0818f9e859e"), "آبيک", 16 },
                    { 536, new Guid("03d250d5-29dc-41e1-87d0-dd3a4fe699e1"), "آبگرم", 16 },
                    { 537, new Guid("f13ecd8c-d180-482e-a4ae-46e7f06ea2c3"), "آوج", 16 },
                    { 591, new Guid("d196c2b1-2e3e-471b-89f3-db86a2dfc915"), "تازه کند انگوت", 18 },
                    { 590, new Guid("4516b715-47e3-47b4-ab31-5c02081440e8"), "تازه کند", 18 },
                    { 589, new Guid("277a2630-763a-4cd7-823e-6a40fcdb0eb1"), "بيله سوار", 18 },
                    { 588, new Guid("ebc30eba-e817-4034-857b-736386e4d3f8"), "اصلاندوز", 18 },
                    { 587, new Guid("35e33dc0-c866-49db-9719-5bb76b55dbb7"), "اسلام آباد", 18 },
                    { 586, new Guid("67a11ee7-5533-4eeb-b861-b536f4667dbe"), "اردبيل", 18 },
                    { 585, new Guid("32336505-cec6-4df9-b599-f3258de48557"), "آبي بيگلو", 18 },
                    { 584, new Guid("f16af1c1-3d2c-490c-a3d6-bc5007074996"), "گراب", 17 },
                    { 583, new Guid("761eeff0-1027-47f2-82a2-f56ad75f73e7"), "کوهناني", 17 },
                    { 582, new Guid("3e1f51b9-22c3-496d-a063-3d2139254c02"), "کوهدشت", 17 },
                    { 581, new Guid("a6f3011c-e09a-4655-9095-0c99d72054cc"), "چقابل", 17 },
                    { 580, new Guid("33c69263-8780-4864-88dd-eefa777fc9c8"), "چالانچولان", 17 },
                    { 579, new Guid("7afc9312-78c1-4497-a009-7626f9c37bac"), "پلدختر", 17 },
                    { 578, new Guid("8f528eec-bc6e-4a55-b492-b043894d4cb8"), "ويسيان", 17 },
                    { 577, new Guid("f7f0d405-bdae-45c1-accc-c2a1cab48bcd"), "هفت چشمه", 17 },
                    { 592, new Guid("61f82fc4-436a-43d8-ac31-98fe1042b07a"), "جعفر آباد", 18 },
                    { 576, new Guid("86dd4bcd-27e1-4ddf-94ef-c5eb479b5216"), "نورآباد", 17 },
                    { 593, new Guid("430e89bf-13af-4554-87a3-e0d29a84fc85"), "خلخال", 18 },
                    { 595, new Guid("6f0b51a5-a85a-4907-8c23-9dea71c0f0b1"), "سرعين", 18 },
                    { 610, new Guid("42a49834-81ab-4ffa-804d-3fc35d4c22b7"), "گيوي", 18 },
                    { 609, new Guid("424bffde-50da-40e4-aadb-2ce86b53783f"), "گرمي", 18 },
                    { 608, new Guid("4a61559c-5406-4b8f-ab36-c8041830e38c"), "کورائيم", 18 },
                    { 607, new Guid("911b04b6-bfc4-497a-810a-1d38b0e23e7f"), "کلور", 18 },
                    { 606, new Guid("499e6107-224d-40f3-8255-1bdcc5543e53"), "پارس آباد", 18 },
                    { 605, new Guid("08785466-cc92-4eee-895b-100e75ec1f66"), "هير", 18 },
                    { 604, new Guid("111c4f4e-ed79-4018-ae22-e18e06bb4c22"), "هشتجين", 18 },
                    { 603, new Guid("62d54961-cf2b-42dd-882f-cf07de063a94"), "نير", 18 },
                    { 602, new Guid("12ca9926-664f-4742-adcb-3a9ec606bea4"), "نمين", 18 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 601, new Guid("cd2321e1-5117-46b5-99a5-070c93a66407"), "مشگين شهر", 18 },
                    { 600, new Guid("8baffc16-1f82-4e3b-bd61-86a9287363ae"), "مرادلو", 18 },
                    { 599, new Guid("33414f49-fc3f-4dcc-9ddb-715b21fc718c"), "لاهرود", 18 },
                    { 598, new Guid("7e6bded8-a31f-48d2-a506-c8c9c28dd5b6"), "قصابه", 18 },
                    { 597, new Guid("83a640d4-fa94-4a29-ae6f-aead5064db62"), "فخرآباد", 18 },
                    { 596, new Guid("7a655d83-7e3e-4d1b-8cf2-8f9bd61d6393"), "عنبران", 18 },
                    { 594, new Guid("057d220f-2725-48f1-8669-60c659d2ba0c"), "رضي", 18 },
                    { 575, new Guid("c2f6b28f-d19f-471c-97ee-660b4d9d6060"), "مومن آباد", 17 },
                    { 574, new Guid("fcd7b896-670b-49bf-a3b0-589adf6cad0c"), "معمولان", 17 },
                    { 573, new Guid("9ac10361-3c15-4ec6-bdb2-947d6b2b5170"), "فيروزآباد", 17 },
                    { 552, new Guid("78eb8489-7853-492b-a9b9-32119967807a"), "شريفيه", 16 },
                    { 551, new Guid("6f96644a-ba36-41d5-9013-66697b3d62d3"), "شال", 16 },
                    { 550, new Guid("3b5133cb-a395-48fb-8d54-6c54e8e68a03"), "سگز آباد", 16 },
                    { 549, new Guid("b87683d0-8573-45df-9d06-7e98db8537ce"), "سيردان", 16 },
                    { 548, new Guid("a6bbdb43-fa59-411e-868e-54f11c5e295b"), "رازميان", 16 },
                    { 547, new Guid("288dd13b-07c0-4e73-8899-15a66bacc6a3"), "دانسفهان", 16 },
                    { 546, new Guid("3accf2d9-b62c-4315-9b4e-39fe3336edc4"), "خرمدشت", 16 },
                    { 545, new Guid("881388fa-96e0-4da0-8696-62f6f82e1b46"), "خاکعلي", 16 },
                    { 544, new Guid("f25ee2eb-bc7c-4ee9-96c9-239473ba9b78"), "تاکستان", 16 },
                    { 543, new Guid("509ce2a5-05d2-4786-8481-b8e3fea5ee7c"), "بيدستان", 16 },
                    { 542, new Guid("c5fada0c-b1c1-457b-8c50-7b7fbd6deffc"), "بوئين زهرا", 16 },
                    { 541, new Guid("890709ba-5e5b-474b-a52d-62741d7a69e8"), "الوند", 16 },
                    { 540, new Guid("20a73d36-a8d0-4526-8e5f-00ed66d24f90"), "اقباليه", 16 },
                    { 539, new Guid("aa0e3bd8-03ca-49c2-88fa-38a01486e0e2"), "اسفرورين", 16 },
                    { 538, new Guid("5ea44b04-4c46-4338-bed0-2a1aa801fcd3"), "ارداق", 16 },
                    { 553, new Guid("247370cc-f00d-4b9c-a5a9-34c0b2782d30"), "ضياء آباد", 16 },
                    { 554, new Guid("fe163cf4-5a7a-4cfd-8d83-e88f1cdef02c"), "قزوين", 16 },
                    { 555, new Guid("d4cdc688-a706-46ba-a891-f50e2df8b22c"), "محمديه", 16 },
                    { 556, new Guid("f046d0ed-c1d5-46ce-9027-80703529664a"), "محمود آباد نمونه", 16 },
                    { 572, new Guid("947b9e06-571a-44eb-bb75-dcc488f619e8"), "شول آباد", 17 },
                    { 571, new Guid("22fdedc9-c1a3-4880-aa04-60e01586aa0e"), "سپيد دشت", 17 },
                    { 570, new Guid("aa232282-b5d2-478d-93ab-68e12c0ec1f4"), "سراب دوره", 17 },
                    { 569, new Guid("b7305e34-34e2-4cfd-978e-c1f3debdc156"), "زاغه", 17 },
                    { 568, new Guid("0041d2bd-2a4d-4a37-871b-6b79c26ca026"), "دورود", 17 },
                    { 567, new Guid("5b9b1b9e-e6ce-4fbe-8d21-f53c9376dcfb"), "درب گنبد", 17 },
                    { 566, new Guid("93f4dbc2-1661-4030-8a17-47ed1e6f12dd"), "خرم آباد", 17 },
                    { 461, new Guid("a802639a-ef4d-47bf-a1f2-882611d818d6"), "سنگدوين", 14 },
                    { 565, new Guid("899dd61b-5f26-44de-83f9-9f6dfd244b9b"), "بيرانشهر", 17 },
                    { 563, new Guid("36682303-caa2-4875-a48e-42fd49dcd477"), "اليگودرز", 17 },
                    { 562, new Guid("c8f98f4e-fc15-4548-88af-80c1c28c4bd8"), "الشتر", 17 },
                    { 561, new Guid("66adda3c-eded-48cc-a5c1-d347fcff473f"), "اشترينان", 17 },
                    { 560, new Guid("6dec025e-5561-4493-9d64-80683a53458c"), "ازنا", 17 },
                    { 559, new Guid("99c2e077-cb19-4a2f-b826-3e35fb38ccee"), "کوهين", 16 },
                    { 558, new Guid("e14364c4-404f-4f5e-a605-6b5f0997103e"), "نرجه", 16 },
                    { 557, new Guid("1968d892-175d-4f71-aac3-d3ff4b4cd82c"), "معلم کلايه", 16 },
                    { 564, new Guid("16ff1dd5-e0c6-451d-b75c-046737f9b0fa"), "بروجرد", 17 },
                    { 460, new Guid("ad19376e-e71c-4b38-956b-52b626a0641a"), "سرخنکلاته", 14 },
                    { 468, new Guid("b896c74d-4054-4f6c-852c-28db8d5f6024"), "مينودشت", 14 },
                    { 458, new Guid("179f4a85-33be-44ae-9608-26f1dfbcf7b2"), "دلند", 14 },
                    { 361, new Guid("b7f54e9c-6df6-484b-b057-bb2a62ed28c0"), "شوش", 11 },
                    { 360, new Guid("e0c16d26-ef5d-4c55-86d2-6515d0c6932e"), "شهر امام", 11 },
                    { 359, new Guid("b29d7d95-5c6b-4309-b8e9-90ea02bc2ac5"), "شمس آباد", 11 },
                    { 358, new Guid("cfb2cbfd-a8f5-4e77-8487-f38954a049d9"), "شرافت", 11 },
                    { 357, new Guid("d073e112-c40d-4763-908e-29f328682ef1"), "شاوور", 11 },
                    { 356, new Guid("338dbb3c-cde8-46e0-8d18-1c22130f0cbc"), "شادگان", 11 },
                    { 355, new Guid("05a784f4-a0dd-41d2-93ba-f03a2612df9c"), "سياه منصور", 11 },
                    { 354, new Guid("f77c4c8e-8a4b-4267-9619-898dab0e8b22"), "سوسنگرد", 11 },
                    { 353, new Guid("8698224a-4822-48c1-800b-17dc684edf91"), "سماله", 11 },
                    { 352, new Guid("1d0a7d86-f434-47a3-9f20-3bb11efd83b8"), "سردشت", 11 },
                    { 351, new Guid("de2ee1eb-a37f-4b07-a251-a4cb21cb7467"), "سرداران", 11 },
                    { 350, new Guid("c1ff4b7b-00a3-42ce-a224-315e06fa9510"), "سالند", 11 },
                    { 349, new Guid("a828bbca-6196-4efa-aa96-4828ced1091c"), "زهره", 11 },
                    { 348, new Guid("d07667e9-28c9-414a-9d51-945cf53fe17b"), "رفيع", 11 },
                    { 347, new Guid("43697adb-0560-4d67-89f1-ee89ab0e0fbf"), "رامهرمز", 11 },
                    { 362, new Guid("dc5b9457-3ca3-4ee8-bb39-7afba555a11e"), "شوشتر", 11 },
                    { 346, new Guid("39e78736-a7c7-4d10-9cea-a81bc1d7771b"), "رامشير", 11 },
                    { 363, new Guid("53479193-f7bc-46b3-bf3b-421198afe09e"), "شيبان", 11 },
                    { 365, new Guid("530b61c5-646a-4b6c-9ffe-6837f285c165"), "صفي آباد", 11 },
                    { 380, new Guid("c556fb03-447a-45cc-9403-b1e902dc2ee5"), "هنديجان", 11 },
                    { 379, new Guid("b863acb2-28b9-4362-a08f-365fd4b60639"), "هفتگل", 11 },
                    { 378, new Guid("76789763-5eb3-4c4f-8ab7-ccf5a97d415e"), "مينوشهر", 11 },
                    { 377, new Guid("73ae390a-e4dd-462c-8f0b-611a964863ca"), "ميداود", 11 },
                    { 376, new Guid("8870d989-6b16-47a2-8ed3-c5068f3bd645"), "ميانرود", 11 },
                    { 375, new Guid("99d18511-43e8-461b-b544-3193e3d81fee"), "منصوريه", 11 },
                    { 459, new Guid("e2e29bce-4ed6-4403-9168-ea7cc0ab2363"), "راميان", 14 },
                    { 373, new Guid("871eb9b5-2c07-47d0-b0b5-6d0811e011f3"), "مقاومت", 11 },
                    { 372, new Guid("fc0e4fa1-2e03-432c-8750-e9075f434378"), "مشراگه", 11 },
                    { 371, new Guid("10d056dc-c41c-49b8-bf6a-969840c3347b"), "مسجد سليمان", 11 },
                    { 370, new Guid("0caaab53-2099-47fd-a6f0-20c91473fe5d"), "لالي", 11 },
                    { 369, new Guid("0fbc602c-df22-4e04-8800-6f1fccce7089"), "قلعه خواجه", 11 },
                    { 368, new Guid("d4b14c3d-b9bc-4eaa-9f89-6ed94b0984b2"), "قلعه تل", 11 },
                    { 367, new Guid("822b8412-25b8-42b0-a18c-a7003e5267e9"), "فتح المبين", 11 },
                    { 366, new Guid("f348669b-c7e8-4573-b3de-9b6328205f25"), "صيدون", 11 },
                    { 364, new Guid("24a6e33c-3998-45be-b13e-61a1578ccccf"), "صالح شهر", 11 },
                    { 345, new Guid("7e310b4e-6b89-4174-9595-4634f81142bf"), "دهدز", 11 },
                    { 344, new Guid("a36a9d84-ded7-4e49-83c1-2fb48e6a0aed"), "دزفول", 11 },
                    { 343, new Guid("46ffa384-7cbc-4be8-9b65-6d0d80cc80ae"), "دارخوين", 11 },
                    { 322, new Guid("b7927f77-b5e7-4b96-a797-0ae65bbf6af5"), "الوان", 11 },
                    { 321, new Guid("4d3560ef-c52e-430f-a602-2024040c7ffd"), "الهايي", 11 },
                    { 320, new Guid("440ff55d-a223-408c-822d-f90c59155dc2"), "اروند کنار", 11 },
                    { 319, new Guid("e00e4d19-2616-44e9-b1b3-f5a614cea0e9"), "ابوحميظه", 11 },
                    { 318, new Guid("69392d5f-1a54-49d4-89c9-437706755f14"), "آغاجاري", 11 },
                    { 317, new Guid("e53d2519-dff0-4a45-9be8-4c49eb5a8c4c"), "آزادي", 11 },
                    { 316, new Guid("fcae1f87-45e7-49a4-9e42-bd3fe1fc96aa"), "آبژدان", 11 },
                    { 315, new Guid("4132fd0d-2a6e-4fcc-aca0-4e7037f8afdf"), "آبادان", 11 },
                    { 314, new Guid("5f9e41df-b002-40b1-9159-2a2cbfbc97e5"), "گزيک", 10 },
                    { 313, new Guid("658a9d1d-7681-40c0-aab2-f8a3a76ac84a"), "نيمبلوک", 10 },
                    { 312, new Guid("1db9492c-7b6d-437f-9f36-7607f97ce1f7"), "نهبندان", 10 },
                    { 311, new Guid("9fbca64e-ce2e-47e4-abcf-085c63b5a891"), "مود", 10 },
                    { 310, new Guid("5d3715ed-f477-4bf7-8290-ee0527ad3cae"), "محمدشهر", 10 },
                    { 309, new Guid("26e4e99c-12b7-4e40-808f-c7a3739281fa"), "قهستان", 10 },
                    { 308, new Guid("fc9d6df3-5a46-4719-a91c-7397a53455a5"), "قائن", 10 },
                    { 323, new Guid("96ec44db-4a4f-4edd-a6ab-c1e9d4777c23"), "اميديه", 11 },
                    { 324, new Guid("44a5fa39-c21e-4c93-8df6-f4563231faca"), "انديمشک", 11 },
                    { 325, new Guid("9c60c9e7-9ead-46db-8d63-c8932e0dc9d3"), "اهواز", 11 },
                    { 326, new Guid("9564425d-08a3-4128-b27f-3b59b77a4d46"), "ايذه", 11 },
                    { 342, new Guid("cf91afd2-627a-4223-86ca-15b406504da3"), "خنافره", 11 },
                    { 341, new Guid("9b2920b8-7475-4cfc-b902-8871b50a1e2a"), "خرمشهر", 11 },
                    { 340, new Guid("9a1770eb-0d30-49c1-bd8a-21dd0ca63f49"), "حميديه", 11 },
                    { 339, new Guid("954c1a42-addd-44e0-9141-9f110929328f"), "حمزه", 11 },
                    { 338, new Guid("9ed32411-429c-4af3-ac28-6967ac03a9eb"), "حسينيه", 11 },
                    { 337, new Guid("4c79d0be-c996-41bf-9441-01b86d67c9cc"), "حر", 11 },
                    { 336, new Guid("363bced2-42a4-4e90-953e-409737f020fa"), "جنت مکان", 11 },
                    { 381, new Guid("efd5dfd8-8942-4690-9264-79d332fd4baa"), "هويزه", 11 },
                    { 335, new Guid("13b1b789-d6d1-49b5-90fc-4dc923231c8c"), "جايزان", 11 },
                    { 333, new Guid("3cc629d9-31fd-456d-b9b1-84aa5768c44d"), "ترکالکي", 11 },
                    { 332, new Guid("ed79f8e5-2686-4e83-be1e-280aa1fa2652"), "بيدروبه", 11 },
                    { 331, new Guid("60e1b3ae-513f-45da-bce7-a3212b2470d3"), "بهبهان", 11 },
                    { 330, new Guid("ed165cf6-ce78-4346-a740-cb0ea08d286e"), "بندر ماهشهر", 11 },
                    { 329, new Guid("3048fe5b-2085-4bde-b182-12504cf10a0e"), "بندر امام خميني", 11 },
                    { 328, new Guid("1daed4fd-9176-45d1-8110-d328a9d0f705"), "بستان", 11 },
                    { 327, new Guid("65121292-ef71-4e43-a28f-9d83bfdd918f"), "باغ ملک", 11 },
                    { 334, new Guid("85b0e57f-ce58-412f-a9c7-bdeaeb152240"), "تشان", 11 },
                    { 382, new Guid("f3fb2350-a4ff-42e5-931e-bb8f9644f199"), "ويس", 11 },
                    { 374, new Guid("1e5fb52e-f625-4776-ad78-ec8f057354d2"), "ملاثاني", 11 },
                    { 384, new Guid("039626b1-2421-4e74-ab45-50a163426506"), "چم گلک", 11 },
                    { 438, new Guid("105aefe8-63eb-47e4-aa69-41c474d0f35d"), "سلطانيه", 13 },
                    { 437, new Guid("df8c5ee0-d274-43cc-aa9e-40d4987a564f"), "سجاس", 13 },
                    { 436, new Guid("ab9fe8b6-5343-480b-8508-751766995f72"), "زنجان", 13 },
                    { 435, new Guid("f84a91e7-5754-4705-9fa6-0cc015f7ff00"), "زرين رود", 13 },
                    { 434, new Guid("910a3adf-2552-46e5-84de-407935c11b9a"), "زرين آباد", 13 },
                    { 433, new Guid("0d63fdc2-ee6c-4129-a6ef-55f3d73704c7"), "دندي", 13 },
                    { 432, new Guid("b7a0060d-2467-4c79-89b3-cd9cad626305"), "خرمدره", 13 },
                    { 431, new Guid("5fc36326-aee9-46cc-aad9-813fe84f6d06"), "حلب", 13 },
                    { 383, new Guid("5d850abf-b238-4091-b29c-0942a1b75219"), "چغاميش", 11 },
                    { 429, new Guid("162598d3-fb5b-45a5-9dfe-7687c5111cf2"), "ابهر", 13 },
                    { 428, new Guid("1075a667-c0f7-4c89-9fff-14f6c34b32e9"), "آب بر", 13 },
                    { 427, new Guid("d1715a53-5e0c-47d9-a664-27e752fc0a5e"), "کلمه", 12 },
                    { 426, new Guid("b5648dc6-8f67-4d3a-bc53-1cd4667fde4d"), "کاکي", 12 },
                    { 425, new Guid("23b871f2-2589-4212-ab4f-7113549491cf"), "چغادک", 12 },
                    { 424, new Guid("c6847f8e-4c4d-4c24-9b17-45a9f4ff3e54"), "وحدتيه", 12 },
                    { 439, new Guid("5fdbca8a-a014-4c75-89ce-c39de444d6bd"), "سهرورد", 13 },
                    { 423, new Guid("9c4339c1-a528-4589-bcd0-b986f13b84dd"), "نخل تقي", 12 },
                    { 440, new Guid("80fcb903-7b64-410c-817e-40e6c3861fb3"), "صائين قلعه", 13 },
                    { 442, new Guid("926faa41-603e-4c54-8ec5-a571c826c04b"), "ماه نشان", 13 },
                    { 457, new Guid("3ce3d8a4-a02b-4a4d-9c68-783bc00d31f4"), "خان ببين", 14 },
                    { 456, new Guid("fd04ee5d-de3b-4e91-96dd-b81bc07a7d0b"), "جلين", 14 },
                    { 455, new Guid("e0b2e1fc-08d6-4c49-a8ae-59c3fe7d75b8"), "تاتار عليا", 14 },
                    { 454, new Guid("ec42a291-66ae-4882-ac2c-4127d8522dba"), "بندر گز", 14 },
                    { 453, new Guid("2725daa5-925e-4021-bd76-3d9cf377d14a"), "بندر ترکمن", 14 },
                    { 452, new Guid("653ccb46-99c0-4292-98c6-bd358d4b8d0c"), "اينچه برون", 14 },
                    { 451, new Guid("1063c211-f84c-4ad8-85d7-87cc5c8a4d8b"), "انبار آلوم", 14 },
                    { 450, new Guid("6fd1d6f8-b52a-4ae4-8fd9-383114b78f48"), "آق قلا", 14 },
                    { 449, new Guid("bfaba6e6-1b74-47b8-97e2-e4b7914f5e6a"), "آزاد شهر", 14 },
                    { 448, new Guid("9f199f53-2368-469c-aa75-489d46c479f5"), "گرماب", 13 },
                    { 447, new Guid("5c1100a7-2dc7-4039-af8f-7442eb437cea"), "کرسف", 13 },
                    { 446, new Guid("1b66b5fb-52dc-419b-ae39-a5f0759d49f0"), "چورزق", 13 },
                    { 445, new Guid("c216719b-f842-4400-97d0-e3c283565fce"), "هيدج", 13 },
                    { 444, new Guid("0e0fc09a-f9af-4d74-b79a-f1e33b5937cf"), "نيک پي", 13 },
                    { 443, new Guid("8cae3657-820d-43c5-8671-4879980139ed"), "نوربهار", 13 },
                    { 441, new Guid("3bc88283-47b2-4bab-9b5a-274f17c8ac44"), "قيدار", 13 },
                    { 422, new Guid("dc7af9cc-e5d5-455a-8fcd-9818883af9f2"), "عسلويه", 12 },
                    { 430, new Guid("fbb499e0-ba8e-49c9-b869-d68c7f08ddb4"), "ارمخانخانه", 13 },
                    { 420, new Guid("2f16549c-f23d-467d-ba5f-9edaf9dba8b2"), "شبانکاره", 12 },
                    { 399, new Guid("8868a631-c057-49f1-a7e4-dd525b9a7094"), "برازجان", 12 },
                    { 398, new Guid("bc51c5fa-6b3a-4d5d-8949-2c960f55ced5"), "بادوله", 12 },
                    { 397, new Guid("2b164e37-ddb3-4fcc-80bc-c2a7c7011278"), "اهرم", 12 },
                    { 396, new Guid("1a41af14-5b3e-4a65-a41d-477ae49c163d"), "انارستان", 12 },
                    { 395, new Guid("ae7d6856-148d-40c4-9e5d-346240864479"), "امام حسن", 12 },
                    { 394, new Guid("680a4ed4-8f94-4624-838d-a19d8fc94518"), "آبپخش", 12 },
                    { 421, new Guid("51c1bc17-de30-4d0c-8dc9-8442140849f8"), "شنبه", 12 },
                    { 392, new Guid("c930639b-008f-4c52-8a60-d2b1ff1bf361"), "آباد", 12 },
                    { 391, new Guid("59f33d9a-126f-45a3-83a8-0121f714b3d1"), "گوريه", 11 },
                    { 390, new Guid("098fe315-d428-436e-b30c-10bdb1780726"), "گلگير", 11 },
                    { 389, new Guid("205d2854-4f06-40a2-9a3a-88cac8b67aec"), "گتوند", 11 },
                    { 388, new Guid("c70af071-44df-4fa2-ac6b-3739d4a03520"), "کوت عبدالله", 11 },
                    { 387, new Guid("239de7ed-7075-4626-a9cf-3997246d3bf3"), "کوت سيدنعيم", 11 },
                    { 386, new Guid("e5961ffe-62b3-4f0d-9298-7b46a8e30c19"), "چوئبده", 11 },
                    { 385, new Guid("ff296c3e-d75a-4241-baed-eae38561db42"), "چمران", 11 },
                    { 400, new Guid("2ba07888-2f66-4a2a-a791-aaeecd8271d4"), "بردخون", 12 },
                    { 401, new Guid("783a4f13-8bae-4e9f-9a4d-994912fda350"), "بردستان", 12 },
                    { 393, new Guid("ed7fc667-1e44-4bf1-957a-12409b3ff377"), "آبدان", 12 },
                    { 403, new Guid("447c0217-a4a7-4023-ba7b-cd598389b6bf"), "بندر ديلم", 12 },
                    { 402, new Guid("9ff3fea1-7f0b-4a0f-8d4b-9a46f2fdae0b"), "بندر دير", 12 },
                    { 419, new Guid("6473fdd8-4d5c-4aa8-ad95-0c4dc3741db6"), "سيراف", 12 },
                    { 418, new Guid("b6b66fba-8aeb-4b35-b34d-9cca95df311a"), "سعد آباد", 12 },
                    { 417, new Guid("dfceb466-9755-498c-ab51-9ff2dee76dab"), "ريز", 12 },
                    { 416, new Guid("514e6d89-a32c-4e04-8ffe-a303012c2819"), "دوراهک", 12 },
                    { 414, new Guid("9d6743e7-0224-4ea7-834a-920e67b4191f"), "دالکي", 12 },
                    { 413, new Guid("937763b0-f1c5-44b6-a6d1-73018026d705"), "خورموج", 12 },
                    { 412, new Guid("eb043db6-a728-428e-9875-17c41f9b66c8"), "خارک", 12 },
                    { 415, new Guid("f7164ad3-37b4-411f-8adb-ec59cb5fc27f"), "دلوار", 12 },
                    { 410, new Guid("82d0901f-1665-45b9-8207-16122cd14b2b"), "تنگ ارم", 12 },
                    { 409, new Guid("b34a03d2-1ee0-42e5-9c22-304c8515a307"), "بوشکان", 12 },
                    { 408, new Guid("07f588d8-c978-42b1-a446-aa383ce33f58"), "بوشهر", 12 },
                    { 407, new Guid("f679a39b-5c80-4807-aa0e-9040eac80400"), "بنک", 12 },
                    { 406, new Guid("a68542df-4492-4348-88fe-528fb028cd3e"), "بندر گناوه", 12 },
                    { 405, new Guid("722c99fd-7cc4-4506-915d-461022c7e5b5"), "بندر کنگان", 12 },
                    { 404, new Guid("78b3a068-ac85-45bd-81a7-a0d558b65e75"), "بندر ريگ", 12 },
                    { 411, new Guid("0e7ef0d0-77e7-4a38-a370-85536c78196d"), "جم", 12 }
                });

            migrationBuilder.InsertData(
                table: "Code",
                columns: new[] { "CodeID", "CodeGroupID", "CodeGUID", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 7, 3, new Guid("2b451e4c-c9b8-415a-bcb4-05da15447b89"), "زن", "Female" },
                    { 1, 1, new Guid("fc20e91f-1eb1-4912-87be-1708f2706367"), "png", "image/png" },
                    { 2, 1, new Guid("3f009296-db7a-4fde-a659-4ca1541a2504"), "jpg", "image/jpg" },
                    { 3, 1, new Guid("3209341a-07d4-437b-9301-2d0f909ad713"), "jpeg", "image/jpeg" },
                    { 4, 2, new Guid("09cb21ac-d99e-42ba-904d-337bdd561e6e"), "به صورت شخصی فعالیت میکنم", "به صورت شخصی فعالیت میکنم" },
                    { 5, 2, new Guid("2383b70e-f41f-4b67-b0c9-c48706a70a46"), "نماینده یک شرکت هستم", "نماینده یک شرکت هستم" },
                    { 6, 2, new Guid("cf5a1929-db68-43d6-8fc7-e3b7ccc51678"), "نماینده یک واحد، آموزشگاه یا دیگر مجوز ها هستم", "نماینده یک واحد، آموزشگاه یا دیگر مجوز ها هستم" },
                    { 8, 3, new Guid("6e48b657-2c83-4481-a9c5-009ffe10158b"), "مرد", "Male" },
                    { 17, 6, new Guid("ccef9d1f-343b-442a-a041-1908e4cbc235"), "حقیقی", "Natural" },
                    { 10, 4, new Guid("10afdac9-a075-40e1-9207-1813befcf4d6"), "در حال انجام", "Doing" },
                    { 11, 4, new Guid("2b9d07c8-5535-495e-8557-da32acb58600"), "انجام شده", "Done" },
                    { 12, 4, new Guid("61960336-e912-4658-9ab3-59f4c58e0b23"), "لغو شده", "Canceled" },
                    { 13, 4, new Guid("46a09d81-c57f-4655-a8f5-027c66a6cfb1"), "ادمین", "Admin" },
                    { 14, 4, new Guid("91b3cdab-39c1-40fb-b077-a2d6e611f50a"), "سرویس گیرنده", "Client" },
                    { 15, 4, new Guid("959b10a3-b8ed-4a9d-bdf3-17ec9b2ceb15"), "سرویس دهنده", "Contractor" },
                    { 16, 6, new Guid("a05c4f54-5999-42b9-a36f-6a04aa7cd476"), "حقوقی", "Legal" },
                    { 9, 4, new Guid("b5d74bda-849b-427c-a6e0-463c1e5f615b"), "در انتظار تایید", "Waiting" }
                });

            migrationBuilder.InsertData(
                table: "SMSProviderSetting",
                columns: new[] { "SMSProviderSettingID", "APIKey", "Password", "SMSProviderID", "Username" },
                values: new object[] { 1, "532B514B4E305A456D5A737669687A5161444B355544557462576650737634545959532F76517A572B65733D", "raffi1234", 1, "raffi.hovanes@gmail.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "SecondPageCoverDocumentID", "Sort" },
                values: new object[,]
                {
                    { 5, null, null, new Guid("7ee93141-c7b2-4e2d-8c5e-eb64f2ddb1c2"), null, null, "تاسیسات", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(7777), 3, null, null, 1 },
                    { 31, null, null, new Guid("8924c59c-71a6-4393-b996-8a7da95c961e"), null, null, "سرویس و تعمیر خودرو", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8303), 4, null, null, 3 },
                    { 30, null, null, new Guid("d44b5b93-b36a-4407-ab00-92450d04f4bb"), null, null, "اجاره خودرو", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8296), 4, null, null, 2 },
                    { 29, null, null, new Guid("630783f3-6b0e-4ec9-93f8-37d3688a9032"), null, null, "اتوبار", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8288), 4, null, null, 1 },
                    { 21, null, null, new Guid("2a704f55-da53-4bd8-8c59-d203cbe6dc6b"), null, null, "کار در ارتفاع", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8221), 3, null, null, 17 },
                    { 20, null, null, new Guid("097d40ed-3050-4938-8ecf-7e5626b57631"), null, null, "آسانسور و بالابر", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8167), 3, null, null, 16 },
                    { 19, null, null, new Guid("3ebd7168-4158-49b8-9bd0-2451de7b72e1"), null, null, "نجاری", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8159), 3, null, null, 15 },
                    { 18, null, null, new Guid("9fd40e55-bef8-4599-9839-fccf0afe72ab"), null, null, "تعمیرات لوازم خانگی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8118), 3, null, null, 14 },
                    { 16, null, null, new Guid("3747f17d-3d86-4fc8-a02f-9cff39163955"), null, null, "عایق کاری", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8103), 3, null, null, 12 },
                    { 15, null, null, new Guid("951963b8-2f45-4b90-b857-3e3ff73de9b6"), null, null, "عایق کاری", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8095), 3, null, null, 11 },
                    { 17, null, null, new Guid("cef7f45c-8a60-4940-855e-4e08b64bfab6"), null, null, "نرده و حفاظ استیل", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8111), 3, null, null, 13 },
                    { 13, null, null, new Guid("0fd4bd2a-c01a-497b-afb0-2e9970da771f"), null, null, "بنایی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8079), 3, null, null, 9 },
                    { 12, null, null, new Guid("dcfbd0ac-a34d-4efd-bad6-2f76228e830d"), null, null, "دکوراسیون داخلی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8072), 3, null, null, 8 },
                    { 11, null, null, new Guid("b9339b12-fa53-4669-a360-c0c2b33bec79"), null, null, "کابینت سازی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8063), 3, null, null, 7 },
                    { 10, null, null, new Guid("7802faa4-c7b4-4680-916e-a2b7399776bb"), null, null, "شیشه بری و قابسازی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8050), 3, null, null, 6 },
                    { 9, null, null, new Guid("45bc33e5-04f2-453b-a73e-6b0386304d72"), null, null, "آلومینیوم سازی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8042), 3, null, null, 5 },
                    { 8, null, null, new Guid("ef298375-6191-40a5-a309-8b665e3f32c3"), null, null, "مبلمان", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8034), 3, null, null, 4 },
                    { 7, null, null, new Guid("4c1223c1-e2b0-4b53-9544-149394744094"), null, null, "ایمنی و امنیت", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8027), 3, null, null, 3 },
                    { 6, null, null, new Guid("998f4afc-8e4c-4cd1-a8b5-603523faa89f"), null, null, "الکتریکی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8017), 3, null, null, 2 },
                    { 14, null, null, new Guid("2e91f706-2cb6-4178-8145-a54fda3e9f32"), null, null, "آهنگری", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8087), 3, null, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "SMSTemplate",
                columns: new[] { "SMSTemplateID", "Name", "SMSProviderSettingID" },
                values: new object[,]
                {
                    { 1, "VerifyAccount", 1 },
                    { 2, "RegisterMessage", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FirstName", "GenderCodeID", "IsActive", "IsRegister", "LastName", "ModifiedDate", "PhoneNumber", "ProfileDocumentID", "RegisteredDate", "RoleID", "UserGUID" },
                values: new object[,]
                {
                    { 1, "mahdiroudaki@hotmail.com", "سید مهدی", 8, true, true, "رودکی", new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(2986), "09227204305", null, new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(2440), 1, new Guid("d6b60bd0-1c5b-46a1-9dbf-5982d1eb3ff8") },
                    { 2, "roozbehshamekhi@hotmail.com", "روزبه", 8, true, true, "شامخی", new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(5034), "09128277075", null, new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(5010), 3, new Guid("3d87ca16-0e0e-43ed-bd48-98ba0f13ef95") },
                    { 3, "dead.hh98@gmail.com", "حامد", 8, true, true, "حقیقیان", new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(5078), "09108347428", null, new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(5074), 2, new Guid("b9daf3f1-0e85-42a3-a1da-14f4a2888c62") },
                    { 4, "white.luciferrr@gmail.com", "محمد", 8, true, true, "میرزایی", new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(5091), "09147830093", null, new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(5088), 2, new Guid("0b30d230-2279-4d77-97fe-dcdf9ff2e61e") }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminGUID", "ModifiedDate", "UserID" },
                values: new object[] { 1, new Guid("8b6fb3bc-1e82-4f1e-bb0a-006822375a0a"), new DateTime(2020, 7, 6, 0, 20, 47, 170, DateTimeKind.Local).AddTicks(7533), 1 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "SecondPageCoverDocumentID", "Sort" },
                values: new object[,]
                {
                    { 22, null, null, new Guid("dc5f9986-6d42-47ef-88ee-a0bde2b84e4c"), null, null, "سرویس کولر آبی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8231), 5, null, null, 1 },
                    { 23, null, null, new Guid("66083543-b9f2-4034-a81a-e86a8b3e3a7e"), null, null, "نقاشی ساختمان", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8239), 5, null, null, 2 },
                    { 24, null, null, new Guid("b38e0332-6857-4e68-b59c-a1c095245ddd"), null, null, "رنگ کاری مبل", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8246), 8, null, null, 1 },
                    { 25, null, null, new Guid("2c5bd4a6-2971-4f83-960c-e5b0afdf568a"), null, null, "تعمیر صندلی اداری", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8254), 8, null, null, 2 },
                    { 26, null, null, new Guid("95acc1e6-bb3c-4587-a9a3-a27ccd28832b"), null, null, "ساخت مبلمان", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8263), 8, null, null, 3 },
                    { 27, null, null, new Guid("fc80df2c-1206-4bb7-9b46-6ff4dc41662e"), null, null, "دوخت کاور مبل", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8273), 8, null, null, 4 },
                    { 28, null, null, new Guid("a0581fa1-669b-46a1-9668-4502db5833e8"), null, null, "تعمیر مبل", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8280), 8, null, null, 5 },
                    { 32, null, null, new Guid("47bdfd0e-ad1d-4410-be34-1bea956ea1ea"), null, null, "وانت بار", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8311), 29, null, null, 1 },
                    { 33, null, null, new Guid("ad1f7fea-0b35-4837-a75e-6c172a6d9676"), null, null, "باربری و اتوبار", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8318), 29, null, null, 2 },
                    { 34, null, null, new Guid("5700ede0-3c45-4668-b920-be377a4e639b"), null, null, "کارگر اسباب کشی", null, true, new DateTime(2020, 7, 6, 0, 20, 47, 175, DateTimeKind.Local).AddTicks(8326), 29, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientID", "CityID", "ClientGUID", "ModifiedDate", "UserID" },
                values: new object[] { 1, 751, new Guid("494efca9-4189-4215-ab16-93c367cdf336"), new DateTime(2020, 7, 6, 0, 20, 47, 171, DateTimeKind.Local).AddTicks(2565), 2 });

            migrationBuilder.InsertData(
                table: "Contractor",
                columns: new[] { "ContractorID", "AboutMe", "Address", "AverageRate", "BusinessTypeCodeID", "CityID", "ContractorGUID", "Credit", "Instagram", "Latitude", "Longitude", "ModifiedDate", "Telephone", "UserID", "Website" },
                values: new object[,]
                {
                    { 1, null, null, null, 4, 751, new Guid("171a4ca1-0b87-4600-8b76-a456ad591344"), 0, null, "1", "2", new DateTime(2020, 7, 6, 0, 20, 47, 172, DateTimeKind.Local).AddTicks(5292), null, 3, null },
                    { 2, null, null, null, 4, 751, new Guid("78489155-c341-4394-ba16-7ff5a627918d"), 10000, null, "1", "2", new DateTime(2020, 7, 6, 0, 20, 47, 172, DateTimeKind.Local).AddTicks(5972), null, 4, null }
                });

            migrationBuilder.InsertData(
                table: "ContractorCategory",
                columns: new[] { "ContractorCategoryID", "CategoryID", "ContractorCategoryGUID", "ContractorID" },
                values: new object[,]
                {
                    { 1, 4, new Guid("a9dec979-2f61-48ce-a65c-8eb853324d02"), 1 },
                    { 2, 5, new Guid("41deeec8-204d-477e-8a33-bafd2e520efb"), 1 },
                    { 3, 14, new Guid("89b3f973-e19b-4dec-a195-585e43ef29a1"), 1 },
                    { 4, 22, new Guid("a8432ac0-786c-4480-89e5-610b632bf34a"), 1 },
                    { 5, 25, new Guid("1fbd5f88-6b64-4a1d-bb27-029c97f23092"), 1 },
                    { 6, 30, new Guid("e8d1361a-36d1-44a6-ab6b-7e7e63347060"), 1 },
                    { 7, 33, new Guid("c7c5184d-d688-476a-8356-1311feab2db1"), 1 },
                    { 8, 34, new Guid("71e3f661-e0c2-489a-8cd6-da0196e57a96"), 1 },
                    { 9, 27, new Guid("3445d369-9aeb-4b37-803f-24841e91e0a3"), 1 },
                    { 10, 20, new Guid("7b917cda-ee79-4907-b1da-0ef878dd5f13"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CategoryID", "ClientID", "Comment", "ContractorID", "Cost", "DeadlineDate", "Description", "ModifiedDate", "OrderGUID", "Rate", "StateCodeID", "Title" },
                values: new object[,]
                {
                    { 1, 14, 1, null, null, null, null, "توضیح", new DateTime(2020, 7, 6, 0, 20, 47, 173, DateTimeKind.Local).AddTicks(7026), new Guid("a4d628ef-8b81-4fd4-9cda-c2e18d0f911c"), null, 9, "تیتر" },
                    { 2, 22, 1, null, null, null, null, "کولر ماشین مشکل داره", new DateTime(2020, 7, 6, 0, 20, 47, 173, DateTimeKind.Local).AddTicks(7803), new Guid("405bc126-996f-49f0-be05-7ac46fa3234f"), null, 9, "مشکل" }
                });

            migrationBuilder.InsertData(
                table: "OrderRequest",
                columns: new[] { "OrderRequestID", "ContractorID", "IsAllow", "Message", "ModifiedDate", "OfferedPrice", "OrderID", "OrderRequestGUID" },
                values: new object[] { 1, 1, true, "پیام", new DateTime(2020, 7, 6, 0, 20, 47, 174, DateTimeKind.Local).AddTicks(3650), 250000L, 1, new Guid("e90befec-6fdc-46e4-97cc-bc29010ab2bd") });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserID",
                table: "Admin",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_DocumentID",
                table: "Advertisement",
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
