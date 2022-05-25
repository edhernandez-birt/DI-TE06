using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.DTO;
using Utilidades.VO;

namespace DAL_Northwind
{
    public class ConsultasSQL
    {

        /// <summary>
        /// Método que consulta en la BD la suma de todos los ingresos de Northwind
        /// </summary>
        /// <returns>double</returns>
        public static double IngresosTotales()
        {
            double ingresos;
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "SELECT SUM(od.UnitPrice * (1 - od.Discount) * od.Quantity)  FROM [Order Details] as od";            
            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                ingresos = (double)command.ExecuteScalar();
                Console.WriteLine("Query realizada con exito");
                command.Dispose();
                return ingresos;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Método que consulta en la BD la suma de todos los pedidos de los clientes sin repetir
        /// </summary>
        /// <returns>int</returns>
        public static int VentasTotales()
        {
            int ventas;
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "SELECT COUNT(DISTINCT OrderID) FROM [Order Details]";
            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                ventas = (int)command.ExecuteScalar();
                Console.WriteLine("Query realizada con exito");
                command.Dispose();
                return ventas;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// Método que consulta en la BD la suma de ingresos conseguidos por las ventas a un cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>double</returns>
        public static double IngresosPorCliente(string cliente)
        {
            double ingresos;
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "SELECT SUM([Order Details].UnitPrice*(1 -[Order Details].Discount)*[Order Details].Quantity) " +
                "FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID WHERE Orders.CustomerID = '"+cliente+"'";
            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                //Evitar valores NULL
                if (command.ExecuteScalar() == DBNull.Value)
                {
                    ingresos = 0.0;
                }else
                {
                    ingresos = (double)command.ExecuteScalar();
                }
                Console.WriteLine("Query realizada con exito");
                command.Dispose();
                return ingresos;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// Método que consulta en la BD el número de pedidos vendidos a un cliente concreto
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>int</returns>
        public static int VentasPorCliente(string cliente)
        {
            int ventas;
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "SELECT COUNT(DISTINCT OrderID) FROM [Orders] WHERE CustomerID='"+cliente+"'";
            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                ventas = (int)command.ExecuteScalar();
                Console.WriteLine("Query realizada con exito");
                command.Dispose();
                return ventas;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        /// <summary>
        /// Método que consulta la información de un cliente en concreto dependiendo de su CustomerID
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>ClienteVO</returns>
        public static ClienteVO ConsultarInfoCliente(string cliente)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "select * from dbo.Customers where CustomerID='"+cliente+"'";
            SqlDataReader datos;

            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                ClienteVO clienteVO = new ClienteVO();
                while (datos.Read())
                {
                    clienteVO.IdCliente = datos.GetValue(0).ToString();
                    clienteVO.NombreEmpresa = datos.GetValue(1).ToString();
                    clienteVO.NombreContacto = datos.GetValue(2).ToString();
                    clienteVO.CategoriaContacto = datos.GetValue(3).ToString();
                    clienteVO.Direccion = datos.GetValue(4).ToString();
                    clienteVO.Ciudad = datos.GetValue(5).ToString();
                    clienteVO.Region = datos.GetValue(6).ToString();
                    clienteVO.CodigoPostal = datos.GetValue(7).ToString();
                    clienteVO.Pais = datos.GetValue(8).ToString();
                    clienteVO.Telefono = datos.GetValue(9).ToString();
                    clienteVO.Fax = datos.GetValue(10).ToString();
                }
                Console.WriteLine("Query realizada con exito");
                datos.Close();
                command.Dispose();
                return clienteVO;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// Método que devuelve una lista con todos los clientes 
        /// </summary>
        /// <returns>ClienteVO</returns>
        public static List<ClienteVO> RealizarConsultaClientes()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "select * from dbo.Customers";
            SqlDataReader datos;

            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                List<ClienteVO> clientes = new List<ClienteVO>();
                while (datos.Read())
                {
                    ClienteVO cliente = new ClienteVO();

                    cliente.IdCliente = datos.GetValue(0).ToString();
                    cliente.NombreEmpresa = datos.GetValue(1).ToString();
                    cliente.NombreContacto = datos.GetValue(2).ToString();
                    cliente.CategoriaContacto = datos.GetValue(3).ToString();
                    cliente.Direccion = datos.GetValue(4).ToString();
                    cliente.Ciudad = datos.GetValue(5).ToString();
                    cliente.Region = datos.GetValue(6).ToString();
                    cliente.CodigoPostal = datos.GetValue(7).ToString();
                    cliente.Pais = datos.GetValue(8).ToString();
                    cliente.Telefono = datos.GetValue(9).ToString();
                    cliente.Fax = datos.GetValue(10).ToString();

                    clientes.Add(cliente);

                }
                Console.WriteLine("Query realizada con exito");
                datos.Close();
                command.Dispose();
                return clientes;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Devuelve lista con los pedidos de un cliente concreto
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>List<PedidoVO></returns>
        public static List<PedidoVO> ListaPedidosCliente(string cliente)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "select * from dbo.Orders where CustomerID='" + cliente + "'";
            SqlDataReader datos;

            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                List<PedidoVO> pedidos = new List<PedidoVO>();
                while (datos.Read())
                {
                    PedidoVO pedido = new PedidoVO();

                    pedido.IdPedido = (int)Int64.Parse(datos.GetValue(0).ToString());
                    pedido.IdEmpleado = (int)Int64.Parse(datos.GetValue(2).ToString());
                    pedido.Via = (int)Int64.Parse(datos.GetValue(6).ToString());

                    pedido.IdCliente = datos.GetValue(1).ToString();

                    pedido.FechaPedido = DateTime.Parse(datos.GetValue(3).ToString());
                    pedido.FechaRequerida = DateTime.Parse(datos.GetValue(4).ToString());

                    //Problema si los pedidos pendientes de envío están a NULL
                    //Usamos tryParse https://thedeveloperblog.com/datetime-tryparse
                    DateTime diaEnvio = new DateTime();
                    DateTime.TryParse(datos.GetValue(5).ToString(), out diaEnvio);
                    if(diaEnvio > DateTime.MinValue)
                    {
                        pedido.FechaEnvio = DateTime.Parse(datos.GetValue(5).ToString());
                    }
                    
                    pedido.Flete = (double)Double.Parse(datos.GetValue(7).ToString());

                    pedidos.Add(pedido);

                }

                if (pedidos.Count == 0)
                {
                    PedidoVO pedidoVO = new PedidoVO();
                    pedidoVO.IdPedido = 0;
                    pedidoVO.IdCliente = "No hay pedidos de " + cliente;
                    pedidos.Add(pedidoVO);
                }

                Console.WriteLine("Query realizada con exito");
                datos.Close();
                command.Dispose();
                return pedidos;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
        }

        /// <summary>
        /// Lista de productos con más facturación por cada vendedor
        /// </summary>
        /// <returns> List<ProductoVendidoPorVendedorDTO></returns>
        public static List<ProductoVendidoPorVendedorDTO> ProductosMasVendidosPorVendedor()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = @"WITH salesData AS (
                SELECT Firstname, LastName, ProductName, Sales,
                    ROW_NUMBER() OVER(PARTITION BY Firstname, LastName ORDER BY Sales DESC) AS Seq
                FROM (
                    SELECT
                        e.FirstName,
                        e.LastName,
                        p.ProductName,
                        SUM(od.UnitPrice * od.Quantity * (1 - Discount)) AS Sales
                    FROM Orders oh
                    INNER JOIN [Order Details] od ON oh.OrderID = od.OrderID
                    INNER JOIN Products p ON p.ProductID = od.ProductID
                    INNER JOIN Employees e ON e.EmployeeID = oh.EmployeeID
                    GROUP BY e.FirstName, e.LastName, p.ProductName
                ) a
            )
            SELECT Firstname, LastName, ProductName, Sales
            FROM SalesData WHERE Seq = 1 ORDER BY Sales DESC";

            SqlDataReader datos;

            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                List<ProductoVendidoPorVendedorDTO> listaProductosMasVendidos = new List<ProductoVendidoPorVendedorDTO>();
                while (datos.Read())
                {
                    ProductoVendidoPorVendedorDTO producto = new ProductoVendidoPorVendedorDTO();
                    producto.NombreApellidoProducto = datos.GetValue(0).ToString()[0] + ". " + datos.GetValue(1).ToString() + " " + datos.GetValue(2).ToString();
                    producto.Ventas = (double)Double.Parse(datos.GetValue(3).ToString());
                    listaProductosMasVendidos.Add(producto);
                }
                Console.WriteLine("Query realizada con exito");
                datos.Close();
                command.Dispose();
                return listaProductosMasVendidos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
        }


        public static List<ProductoVendidoPorVendedorDTO> ProductosVendidosPorVendedorCliente(string cliente, string orden)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "WITH salesData AS(SELECT Firstname, LastName, ProductName, Sales, ROW_NUMBER() OVER(PARTITION BY Firstname, LastName ORDER BY Sales "+orden+" ) AS Seq ";
            sql += "FROM (SELECT e.FirstName,e.LastName, p.ProductName, SUM(od.UnitPrice * od.Quantity * (1 - Discount)) AS Sales ";
            sql += "FROM Orders oh INNER JOIN [Order Details] od ON oh.OrderID = od.OrderID INNER JOIN Products p ON p.ProductID = od.ProductID INNER JOIN Employees e ";
            sql += "ON e.EmployeeID = oh.EmployeeID WHERE oh.CustomerID='"+cliente+"' GROUP BY e.FirstName, e.LastName, p.ProductName) a) ";
            sql += "SELECT Firstname, LastName, ProductName, Sales FROM SalesData WHERE Seq = 1 ORDER BY Sales " + orden;

            SqlDataReader datos;

            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                List<ProductoVendidoPorVendedorDTO> listaProductosMasVendidos = new List<ProductoVendidoPorVendedorDTO>();
                while (datos.Read())
                {
                    ProductoVendidoPorVendedorDTO producto = new ProductoVendidoPorVendedorDTO();
                    producto.NombreApellidoProducto = datos.GetValue(0).ToString()[0] + ". " + datos.GetValue(1).ToString() + " " + datos.GetValue(2).ToString();
                    producto.Ventas = (double)Double.Parse(datos.GetValue(3).ToString());
                    listaProductosMasVendidos.Add(producto);
                }
                Console.WriteLine("Query realizada con exito");
                datos.Close();
                command.Dispose();
                return listaProductosMasVendidos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
        }


        /// <summary>
        /// Lista de productos con menos facturación por cada vendedor
        /// </summary>
        /// <returns>List<ProductoVendidoPorVendedorDTO></returns>
        public static List<ProductoVendidoPorVendedorDTO> ProductosMenosVendidosPorVendedor()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = @"WITH salesData AS (
                SELECT Firstname, LastName, ProductName, Sales,
                    ROW_NUMBER() OVER(PARTITION BY Firstname, LastName ORDER BY Sales ASC) AS Seq
                FROM (
                    SELECT
                        e.FirstName,
                        e.LastName,
                        p.ProductName,
                        SUM(od.UnitPrice * od.Quantity * (1 - Discount)) AS Sales
                    FROM Orders oh
                    INNER JOIN [Order Details] od ON oh.OrderID = od.OrderID
                    INNER JOIN Products p ON p.ProductID = od.ProductID
                    INNER JOIN Employees e ON e.EmployeeID = oh.EmployeeID
                    GROUP BY e.FirstName, e.LastName, p.ProductName
                ) a
            )
            SELECT Firstname, LastName, ProductName, Sales
            FROM SalesData WHERE Seq = 1 ORDER BY Sales ASC";

            SqlDataReader datos;


            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                List<ProductoVendidoPorVendedorDTO> listaProductosMenosVendidos = new List<ProductoVendidoPorVendedorDTO>();
                while (datos.Read())
                {
                    ProductoVendidoPorVendedorDTO producto = new ProductoVendidoPorVendedorDTO();
                    producto.NombreApellidoProducto = datos.GetValue(0).ToString()[0] + ". " + datos.GetValue(1).ToString() + " " + datos.GetValue(2).ToString();
                    producto.Ventas = (double)Double.Parse(datos.GetValue(3).ToString());
                    listaProductosMenosVendidos.Add(producto);
                }
                Console.WriteLine("Query realizada con exito");
                datos.Close();
                command.Dispose();
                return listaProductosMenosVendidos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
        }

        /// <summary>
        /// Devulve lista de factoración por regiones
        /// </summary>
        /// <returns>List<FacturacionRegionDTO></returns>
        public static List<FacturacionRegionDTO> ListaFacturacionRegiones()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = @"WITH    EmployeeSales
          AS(SELECT   e.EmployeeID,
                        e.LastName,
                        SUM(od.Quantity * od.UnitPrice * (1 - Discount)) ESales
               FROM     dbo.Employees AS e
                        INNER JOIN dbo.Orders AS o ON e.EmployeeID = o.EmployeeID
                        INNER JOIN dbo.[Order Details] AS od ON o.OrderID = od.OrderID
               GROUP BY e.EmployeeID,
                        e.LastName
             ),
        EmployeeRegion
          AS(SELECT DISTINCT
                        EmployeeID,
                        r.RegionID,
                        RegionDescription
               FROM     dbo.Region AS r
                        INNER JOIN dbo.Territories AS t ON r.RegionID = t.RegionID
                        INNER JOIN dbo.EmployeeTerritories AS et ON t.TerritoryID = et.TerritoryID
             )
    SELECT EmployeeRegion.RegionID ,
            EmployeeRegion.RegionDescription ,
            SUM(EmployeeSales.ESales) RegionTotalSale
    FROM    EmployeeSales
            INNER JOIN EmployeeRegion ON EmployeeSales.EmployeeID = EmployeeRegion.EmployeeID
    GROUP BY EmployeeRegion.RegionID ,
            EmployeeRegion.RegionDescription";

            SqlDataReader datos;

            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                List<FacturacionRegionDTO> listaFacturacion = new List<FacturacionRegionDTO>();
                while (datos.Read())
                {
                    FacturacionRegionDTO region = new FacturacionRegionDTO();
                    region.RegionId = (int)Int64.Parse(datos.GetValue(0).ToString());
                    region.RegionNombre = datos.GetValue(1).ToString();
                    region.RegionFacturacion = (double)Double.Parse(datos.GetValue(2).ToString());
                    listaFacturacion.Add(region);
                }
                Console.WriteLine("Query realizada con exito");
                datos.Close();
                command.Dispose();
                return listaFacturacion;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
        }
    }
}

//public static void AbrirConexion()
//{
//    // cadena de conexion
//    SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");

//    try
//    {
//        conn.Open();
//        Console.WriteLine("Conexion con la BD abierta con exito");
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("Error al abrir la conexion con la BD: " + e.Message);
//    }
//    finally
//    {
//        conn.Close();
//        Console.WriteLine("Conexion cerrada con la BD");
//    }
//}

