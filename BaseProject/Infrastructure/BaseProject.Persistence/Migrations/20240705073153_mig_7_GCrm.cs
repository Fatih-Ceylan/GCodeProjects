using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_7_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GCrm_ProductBrands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductBrandCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductBrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryTopCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryTopCodeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProductMainCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProductMainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProductManufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductManufacturerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductManufacturerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProductManufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProductModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductModelCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProductModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProductSubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProductSubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProductTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductServiceEnum = table.Column<int>(type: "int", nullable: false),
                    ProductMainCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductBrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForeignName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EANNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPCCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarcodeTypeEnum = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropductDimensions = table.Column<int>(type: "int", nullable: false),
                    PiecesBox = table.Column<int>(type: "int", nullable: false),
                    WarehouseLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkingConditionEnum = table.Column<int>(type: "int", nullable: false),
                    ProductStatuEnum = table.Column<int>(type: "int", nullable: false),
                    ProductCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductUnitEnum = table.Column<int>(type: "int", nullable: false),
                    StandartCost = table.Column<int>(type: "int", nullable: false),
                    CurrencyTypeEnum = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<int>(type: "int", nullable: false),
                    SpecialPurchasePrice = table.Column<int>(type: "int", nullable: false),
                    PurchaseDiscount = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<int>(type: "int", nullable: false),
                    SalePriceA = table.Column<int>(type: "int", nullable: false),
                    SalePriceB = table.Column<int>(type: "int", nullable: false),
                    SalePriceC = table.Column<int>(type: "int", nullable: false),
                    SalePriceD = table.Column<int>(type: "int", nullable: false),
                    SalesDiscount = table.Column<int>(type: "int", nullable: false),
                    ProductKdvEnum = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_Products_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_Products_GCrm_ProductBrands_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "GCrm_ProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Products_GCrm_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "GCrm_ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Products_GCrm_ProductMainCategories_ProductMainCategoryId",
                        column: x => x.ProductMainCategoryId,
                        principalTable: "GCrm_ProductMainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Products_GCrm_ProductManufacturers_ProductManufacturerId",
                        column: x => x.ProductManufacturerId,
                        principalTable: "GCrm_ProductManufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Products_GCrm_ProductModels_ProductModelId",
                        column: x => x.ProductModelId,
                        principalTable: "GCrm_ProductModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Products_GCrm_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "GCrm_ProductSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Products_GCrm_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "GCrm_ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Products_BranchId",
                table: "GCrm_Products",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Products_ProductBrandId",
                table: "GCrm_Products",
                column: "ProductBrandId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Products_ProductCategoryId",
                table: "GCrm_Products",
                column: "ProductCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Products_ProductMainCategoryId",
                table: "GCrm_Products",
                column: "ProductMainCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Products_ProductManufacturerId",
                table: "GCrm_Products",
                column: "ProductManufacturerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Products_ProductModelId",
                table: "GCrm_Products",
                column: "ProductModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Products_ProductSubCategoryId",
                table: "GCrm_Products",
                column: "ProductSubCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Products_ProductTypeId",
                table: "GCrm_Products",
                column: "ProductTypeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GCrm_Products");

            migrationBuilder.DropTable(
                name: "GCrm_ProductBrands");

            migrationBuilder.DropTable(
                name: "GCrm_ProductCategories");

            migrationBuilder.DropTable(
                name: "GCrm_ProductMainCategories");

            migrationBuilder.DropTable(
                name: "GCrm_ProductManufacturers");

            migrationBuilder.DropTable(
                name: "GCrm_ProductModels");

            migrationBuilder.DropTable(
                name: "GCrm_ProductSubCategories");

            migrationBuilder.DropTable(
                name: "GCrm_ProductTypes");
        }
    }
}
