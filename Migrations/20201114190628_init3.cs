using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OptimalApi.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "zAccountStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zAccountStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "zAccountType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zAccountType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "zAddressType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zAddressType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "zContactStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zContactStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "zFinancialInstitution",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zFinancialInstitution", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "zInviteStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zInviteStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTypeID = table.Column<int>(type: "int", nullable: false),
                    ParentAccountID = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Account_Account_ParentAccountID",
                        column: x => x.ParentAccountID,
                        principalTable: "Account",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Account_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Account_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Account_zAccountType_AccountTypeID",
                        column: x => x.AccountTypeID,
                        principalTable: "zAccountType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactStatusID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultAccountID = table.Column<int>(type: "int", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contact_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_zContactStatus_ContactStatusID",
                        column: x => x.ContactStatusID,
                        principalTable: "zContactStatus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanApplication",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessOpenDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthCredit = table.Column<int>(type: "int", nullable: false),
                    RequestCreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaamNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditTarget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditTargetDetailes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanApplication", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LoanApplication_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanApplication_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanApplication_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invite",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromContactID = table.Column<int>(type: "int", nullable: false),
                    ToMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    ExpirationInHours = table.Column<int>(type: "int", nullable: false),
                    InviteStatusID = table.Column<int>(type: "int", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invite", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Invite_Contact_FromContactID",
                        column: x => x.FromContactID,
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invite_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invite_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invite_zInviteStatus_InviteStatusID",
                        column: x => x.InviteStatusID,
                        principalTable: "zInviteStatus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanRequest",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanApplicationID = table.Column<int>(type: "int", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRequest", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LoanRequest_LoanApplication_LoanApplicationID",
                        column: x => x.LoanApplicationID,
                        principalTable: "LoanApplication",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanRequest_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanRequest_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanApplicationID = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_LoanApplication_LoanApplicationID",
                        column: x => x.LoanApplicationID,
                        principalTable: "LoanApplication",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "xAccountContact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    InviteID = table.Column<int>(type: "int", nullable: true),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xAccountContact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_xAccountContact_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_xAccountContact_Contact_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_xAccountContact_Invite_InviteID",
                        column: x => x.InviteID,
                        principalTable: "Invite",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_xAccountContact_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_xAccountContact_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_xAccountContact_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "xLoanRequestFinancialInstitution",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRequestID = table.Column<int>(type: "int", nullable: false),
                    FinancialInstitutionID = table.Column<int>(type: "int", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xLoanRequestFinancialInstitution", x => x.ID);
                    table.ForeignKey(
                        name: "FK_xLoanRequestFinancialInstitution_LoanRequest_LoanRequestID",
                        column: x => x.LoanRequestID,
                        principalTable: "LoanRequest",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_xLoanRequestFinancialInstitution_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_xLoanRequestFinancialInstitution_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_xLoanRequestFinancialInstitution_zFinancialInstitution_FinancialInstitutionID",
                        column: x => x.FinancialInstitutionID,
                        principalTable: "zFinancialInstitution",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByID1 = table.Column<int>(type: "int", nullable: true),
                    UpdatedByID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_User_CreatedByID1",
                        column: x => x.CreatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_User_UpdatedByID1",
                        column: x => x.UpdatedByID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountTypeID",
                table: "Account",
                column: "AccountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CreatedByID1",
                table: "Account",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Account_ParentAccountID",
                table: "Account",
                column: "ParentAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_UpdatedByID1",
                table: "Account",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ContactStatusID",
                table: "Contact",
                column: "ContactStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CreatedByID1",
                table: "Contact",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UpdatedByID1",
                table: "Contact",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Invite_CreatedByID1",
                table: "Invite",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Invite_FromContactID",
                table: "Invite",
                column: "FromContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Invite_InviteStatusID",
                table: "Invite",
                column: "InviteStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Invite_UpdatedByID1",
                table: "Invite",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplication_AccountID",
                table: "LoanApplication",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplication_CreatedByID1",
                table: "LoanApplication",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplication_UpdatedByID1",
                table: "LoanApplication",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequest_CreatedByID1",
                table: "LoanRequest",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequest_LoanApplicationID",
                table: "LoanRequest",
                column: "LoanApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequest_UpdatedByID1",
                table: "LoanRequest",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CreatedByID1",
                table: "Order",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_LoanApplicationID",
                table: "Order",
                column: "LoanApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UpdatedByID1",
                table: "Order",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CreatedByID1",
                table: "OrderItem",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_UpdatedByID1",
                table: "OrderItem",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CreatedByID1",
                table: "Product",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UpdatedByID1",
                table: "Product",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_xAccountContact_AccountID",
                table: "xAccountContact",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_xAccountContact_ContactID",
                table: "xAccountContact",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_xAccountContact_CreatedByID1",
                table: "xAccountContact",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_xAccountContact_InviteID",
                table: "xAccountContact",
                column: "InviteID");

            migrationBuilder.CreateIndex(
                name: "IX_xAccountContact_RoleID",
                table: "xAccountContact",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_xAccountContact_UpdatedByID1",
                table: "xAccountContact",
                column: "UpdatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_xLoanRequestFinancialInstitution_CreatedByID1",
                table: "xLoanRequestFinancialInstitution",
                column: "CreatedByID1");

            migrationBuilder.CreateIndex(
                name: "IX_xLoanRequestFinancialInstitution_FinancialInstitutionID",
                table: "xLoanRequestFinancialInstitution",
                column: "FinancialInstitutionID");

            migrationBuilder.CreateIndex(
                name: "IX_xLoanRequestFinancialInstitution_LoanRequestID",
                table: "xLoanRequestFinancialInstitution",
                column: "LoanRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_xLoanRequestFinancialInstitution_UpdatedByID1",
                table: "xLoanRequestFinancialInstitution",
                column: "UpdatedByID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "xAccountContact");

            migrationBuilder.DropTable(
                name: "xLoanRequestFinancialInstitution");

            migrationBuilder.DropTable(
                name: "zAccountStatus");

            migrationBuilder.DropTable(
                name: "zAddressType");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Invite");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "LoanRequest");

            migrationBuilder.DropTable(
                name: "zFinancialInstitution");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "zInviteStatus");

            migrationBuilder.DropTable(
                name: "LoanApplication");

            migrationBuilder.DropTable(
                name: "zContactStatus");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "zAccountType");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
