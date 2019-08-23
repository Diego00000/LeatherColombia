using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeatherColombia.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    CiudadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.CiudadID);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPago",
                columns: table => new
                {
                    MetodoPagoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Referencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPago", x => x.MetodoPagoID);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    PaisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.PaisID);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreProducto = table.Column<string>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoID);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaisID = table.Column<int>(nullable: false),
                    CiudadID = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_Cliente_Ciudad_CiudadID",
                        column: x => x.CiudadID,
                        principalTable: "Ciudad",
                        principalColumn: "CiudadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_Pais_PaisID",
                        column: x => x.PaisID,
                        principalTable: "Pais",
                        principalColumn: "PaisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    PedidoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteID = table.Column<int>(nullable: false),
                    MetodoPagoID = table.Column<int>(nullable: false),
                    NumPedido = table.Column<int>(nullable: false),
                    FechaSolicitud = table.Column<DateTime>(nullable: false),
                    FechaEnvio = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.PedidoID);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_MetodoPago_MetodoPagoID",
                        column: x => x.MetodoPagoID,
                        principalTable: "MetodoPago",
                        principalColumn: "MetodoPagoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedido",
                columns: table => new
                {
                    DetallePedidoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductoID = table.Column<int>(nullable: false),
                    PedidoID = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedido", x => x.DetallePedidoID);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Pedido_PedidoID",
                        column: x => x.PedidoID,
                        principalTable: "Pedido",
                        principalColumn: "PedidoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Producto_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Producto",
                        principalColumn: "ProductoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CiudadID",
                table: "Cliente",
                column: "CiudadID");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PaisID",
                table: "Cliente",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_PedidoID",
                table: "DetallePedido",
                column: "PedidoID");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_ProductoID",
                table: "DetallePedido",
                column: "ProductoID");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteID",
                table: "Pedido",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_MetodoPagoID",
                table: "Pedido",
                column: "MetodoPagoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePedido");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "MetodoPago");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
