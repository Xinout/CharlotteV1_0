using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class Common
    {
        private String connectionString;
        private SQLiteConnection connection;

        //PROVEEDOR
        private String SQLInsertProv = "INSERT INTO PROVEEDOR(NOMBRE, DIRECCION, TELEFONO) VALUES(?, ?, ?)";
        private String SQLGetAllProv = "SELECT * FROM PROVEEDOR";
        private String SQLGetFilProv = "SELECT * FROM PROVEEDOR WHERE ";
        private String SQLGetProv = "SELECT * FROM PROVEEDOR WHERE ID = ?";
        private String SQLUpdateProv = "UPDATE PROVEEDOR SET NOMBRE = ?, DIRECCION = ?, TELEFONO = ? WHERE ID = ?";
        private String SQLDeleteProv = "DELETE FROM PROVEEDOR WHERE ID = ?";

        //FACTURA BALANCE
        private String SQLInsertInvProv = "INSERT INTO FACTURA_BALANCE(ID_PROVEEDOR, FECHA, TOTAL) VALUES(?, ?, ?)";
        private String SQLGetAllInvProv = "SELECT FACTURA_BALANCE.ID, FACTURA_BALANCE.FECHA, PROVEEDOR.NOMBRE, FACTURA_BALANCE.TOTAL FROM PROVEEDOR " +
                                          "INNER JOIN FACTURA_BALANCE ON FACTURA_BALANCE.ID_PROVEEDOR = PROVEEDOR.ID " +
                                          "WHERE FACTURA_BALANCE.FECHA = ?";
        private String SQLGetFilInvProv = "SELECT FACTURA_BALANCE.ID, FACTURA_BALANCE.FECHA, PROVEEDOR.NOMBRE, FACTURA_BALANCE.TOTAL FROM PROVEEDOR " +
                                          "INNER JOIN FACTURA_BALANCE ON FACTURA_BALANCE.ID_PROVEEDOR = PROVEEDOR.ID " +
                                          "WHERE ";
        private String SQLDeleteInvProv = "DELETE FROM FACTURA_BALANCE WHERE ID = ?";
        private String SQLUpdateProvInvTotal = "UPDATE FACTURA_BALANCE SET TOTAL = ? WHERE ID = ?";
        private String SQLGetInvProv = "SELECT * FROM FACTURA_BALANCE WHERE ID = ?";


        //FACTURAS
        //private String SQLInsertInvProv = "INSERT INTO FACTURA(ID_PROVEEDOR, FECHA) VALUES(?, ?)";
        //private String SQLGetAllInvProv = "SELECT FACTURA.ID, FACTURA.FECHA, PROVEEDOR.NOMBRE FROM PROVEEDOR " +
        //                                  "INNER JOIN FACTURA ON FACTURA.ID_PROVEEDOR = PROVEEDOR.ID " +
        //                                  "WHERE FACTURA.FECHA = ?";
        //private String SQLGetFilInvProv = "SELECT FACTURA.ID, FACTURA.FECHA, PROVEEDOR.NOMBRE FROM PROVEEDOR " +
        //                                  "INNER JOIN FACTURA ON FACTURA.ID_PROVEEDOR = PROVEEDOR.ID " +
        //                                  "WHERE ";
        //private String SQLDeleteInvProv = "DELETE FROM FACTURA WHERE ID = ?";
        //private String SQLUpdateProvInvtotal = "UPDATE FACTURA SET CANTIDAD = ?, IMPORTE = ? WHERE ID = ?";

        //LINEAS FACTURA
        //private String SQLInsertLineInvProv = "INSERT INTO LINEA_FACTURA(ID_FACTURA, ID_ARTICULO, CANTIDAD, IMPORTE) VALUES(?, ?, ?, ?)";
        //private String SQLDeleteLineInvProv = "DELETE FROM LINEA_FACTURA WHERE ID = ?";
        //private String SQLDeleteAllLineInvProv = "DELETE FROM LINEA_FACTURA WHERE ID_FACTURA = ?";
        //private String SQLGetLinesInvoiceProvById = "SELECT LINEA_FACTURA.ID, ARTICULO.REFERENCIA, ARTICULO.DESCRIPCION, LINEA_FACTURA.CANTIDAD, LINEA_FACTURA.IMPORTE  FROM LINEA_FACTURA " +
        //                                       "INNER JOIN ARTICULO ON ARTICULO.ID = LINEA_FACTURA.ID_ARTICULO " +
        //                                       "WHERE LINEA_FACTURA.ID_FACTURA = ?";
        //private String SQLGetLineInvProv = "SELECT * FROM LINEA_FACTURA WHERE ID = ?";
        //private String SQLUpdateProvInvLine = "UPDATE LINEA_FACTURA SET CANTIDAD = ?, IMPORTE = ? WHERE ID = ?";
        //private String SQLDeleteInvProvIle = "DELETE FROM LINEA_FACTURA WHERE ID = ?";
        //private String SQLGetLineInvProvByItemID = "SELECT * FROM LINEA_FACTURA WHERE ID_ARTICULO = ?";

        //ARTICULOS
        private String SQLInsertItem = "INSERT INTO ARTICULO(REFERENCIA, ID_FACTURA, DESCRIPCION, PVP, DISPONIBLE, ID_PROVEEDOR) VALUES(?, ?, ?, ?, ?, ?)";
        private String SQLGetAllItem = "SELECT * FROM ARTICULO";
        private String SQLGetItem = "SELECT * FROM ARTICULO WHERE ID = ?";
        private String SQLGetFilItem = "SELECT * FROM ARTICULO WHERE ";
        //private String SQLGetItemAv = "SELECT ID, (REFERENCIA || ' - ' || DESCRIPCION) AS REFDESC, PVP, DISPONIBLE FROM ARTICULO WHERE DISPONIBLE > 0";
        private String SQLGetItemAv = "SELECT * FROM ARTICULO";// WHERE DISPONIBLE > 0";
        private String SQLGetItemByRef = "SELECT * FROM ARTICULO WHERE DISPONIBLE > 0 AND REFERENCIA = ?";
        private String SQLUpdateStockItem = "UPDATE ARTICULO SET DISPONIBLE = DISPONIBLE - ? WHERE ID = ?";
        private String SQLUpdateStockItem2 = "UPDATE ARTICULO SET DISPONIBLE = DISPONIBLE + ? WHERE ID = ?";
        private String SQLDeleteItem = "DELETE FROM ARTICULO WHERE ID = ?";
        private String SQLUpdateItem = "UPDATE ARTICULO SET REFERENCIA = ?, DESCRIPCION = ?, PVP = ?, DISPONIBLE = ? WHERE ID = ?";
        private String SQLGetItemsByProv = "SELECT ARTICULO.* " +
                                                 "FROM ARTICULO " +
                                                 "INNER JOIN PROVEEDOR ON PROVEEDOR.ID = ARTICULO.ID_PROVEEDOR " +
                                                 "WHERE ";

        //TICKETS
        private String SQLInsertTicket = "INSERT INTO TICKET(REGALO, FECHA, HORA, TARJETA, EFECTIVO, TOTAL, USADO) VALUES(?, ?, ?, ?, ?, ?, ?)";
        private String SQLGetTicketById = "SELECT * FROM TICKET WHERE ID = ?";
        private String SQLUpdateTicketUsed = "UPDATE TICKET SET USADO = 1 WHERE ID = ?";
        private String SQLGetAllTickets = "SELECT * FROM TICKET WHERE FECHA = ?";
        private String SQLDeleteTicket = "DELETE FROM TICKET WHERE ID = ?";

        //LINEAS TICKET
        private String SQLInsertLineTicket = "INSERT INTO LINEA_TICKET(ID_TICKET, ID_ARTICULO, CANTIDAD, TOTAL, DESCUENTO) VALUES(?, ?, ?, ?, ?)";
        private String SQLDeleteAllLineTicket = "DELETE FROM LINEA_TICKET WHERE ID_TICKET = ?";
        private String SQLDeleteLineTicket = "DELETE FROM LINEA_TICKET WHERE ID = ?";
        private String SQLGetLinesTicketById = "SELECT ARTICULO.REFERENCIA, ARTICULO.DESCRIPCION, LINEA_TICKET.CANTIDAD, LINEA_TICKET.TOTAL FROM LINEA_TICKET " +
                                               "INNER JOIN ARTICULO ON ARTICULO.ID = LINEA_TICKET.ID_ARTICULO " +
                                               "WHERE LINEA_TICKET.ID_TICKET = ?";
        private String SQLGetTicketLineByItemID = "SELECT * FROM LINEA_TICKET WHERE ID_ARTICULO = ?";

        //VENTAS DEL DIA
        private String SQLInsertSalesDayTicket = "SELECT ARTICULO.DESCRIPCION, LINEA_TICKET.TOTAL, LINEA_TICKET.CANTIDAD, " +
                                                 "TICKET.TARJETA, LINEA_TICKET.DESCUENTO FROM TICKET " +
                                                 "INNER JOIN LINEA_TICKET ON TICKET.ID = LINEA_TICKET.ID_TICKET " +
                                                 "INNER JOIN ARTICULO ON ARTICULO.ID = LINEA_TICKET.ID_ARTICULO " +
                                                 "WHERE NOT(TICKET.REGALO = 1 AND TICKET.TARJETA = 0 AND TICKET.EFECTIVO = 0) AND TICKET.FECHA = ?";

        //BALANCE ANUAL POR PROVEEDOR
        //private string SQLGetProvBalanceAnual = "SELECT PROVEEDOR.NOMBRE AS PROVEEDOR,  IFNULL(SUM(FACTURA_BALANCE.TOTAL),0) AS TOTAL_COMPRAS, IFNULL(SUM(LINEA_TICKET.TOTAL), 0) AS TOTAL_VENTAS FROM PROVEEDOR " +
        //                                                "LEFT OUTER JOIN FACTURA_BALANCE ON PROVEEDOR.ID = FACTURA_BALANCE.ID_PROVEEDOR AND substr(FACTURA_BALANCE.FECHA,7)||substr(FACTURA_BALANCE.FECHA,4,2)||substr(FACTURA_BALANCE.FECHA,1,2) BETWEEN ? AND ? " +
        //                                                "LEFT OUTER JOIN ARTICULO ON PROVEEDOR.ID = ARTICULO.ID_PROVEEDOR " +
        //                                                "LEFT OUTER JOIN LINEA_TICKET ON ARTICULO.ID = LINEA_TICKET.ID_ARTICULO " +
        //                                                "LEFT OUTER JOIN TICKET ON LINEA_TICKET.ID_TICKET = TICKET.ID AND substr(TICKET.FECHA,7)||substr(TICKET.FECHA,4,2)||substr(TICKET.FECHA,1,2) BETWEEN ? AND ?" +
        //                                                "GROUP BY PROVEEDOR.NOMBRE ";
        private string SQLGetPurchasesBySup = "SELECT PROVEEDOR.NOMBRE AS PROVEEDOR,  IFNULL(SUM(FACTURA_BALANCE.TOTAL),0) AS TOTAL_COMPRAS FROM PROVEEDOR " +
                                          "LEFT OUTER JOIN FACTURA_BALANCE ON PROVEEDOR.ID = FACTURA_BALANCE.ID_PROVEEDOR AND substr(FACTURA_BALANCE.FECHA,7)||substr(FACTURA_BALANCE.FECHA,4,2)||substr(FACTURA_BALANCE.FECHA,1,2) BETWEEN ? AND ? " +
                                          "GROUP BY PROVEEDOR.NOMBRE";

        private string SQLGetSalesBySup = "SELECT PROVEEDOR.NOMBRE AS PROVEEDOR,  IFNULL(SUM(LINEA_TICKET.TOTAL), 0) AS TOTAL_VENTAS FROM PROVEEDOR " +
                                          "LEFT OUTER JOIN ARTICULO ON PROVEEDOR.ID = ARTICULO.ID_PROVEEDOR " +
                                          "LEFT OUTER JOIN LINEA_TICKET ON ARTICULO.ID = LINEA_TICKET.ID_ARTICULO " +
                                          "LEFT OUTER JOIN TICKET ON LINEA_TICKET.ID_TICKET = TICKET.ID AND substr(TICKET.FECHA,7)||substr(TICKET.FECHA,4,2)||substr(TICKET.FECHA,1,2) BETWEEN ? AND ? " +
                                          "GROUP BY PROVEEDOR.NOMBRE";

        //private String prueba = "SELECT FACTURA.FECHA, PROVEEDOR.NOMBRE" +
        //                                         "INNER JOIN FACTURA ON FACTURA.ID_PROVEEDOR = PROVEEDOR.ID " +
        //                                         "WHERE TICKET.NOMBRE = ?";

        //CIERRE
        private String SQLGetIdCloseDateSQL = "SELECT * FROM CIERRE WHERE FECHA = ?";
        private String SQLInsertCloseDateSQL = "INSERT INTO CIERRE(FECHA) VALUES(?)";

        #region "Constructor"

        public Common()
        {
            connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            connection = new SQLiteConnection(connectionString);
        }

        #endregion

        #region "Métodos Abrir&Cerrar Conexion"

        private bool openConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool closeConnection()
        {
            try
            {
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region "Métodos Proveedor"

        public bool insertProviderSQL(string name, string address, string phone) {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLInsertProv;

                command.Parameters.AddWithValue("NOMBRE", name);
                command.Parameters.AddWithValue("DIRECCION", address);
                command.Parameters.AddWithValue("TELEFONO", phone);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex) {
                throw ex;
            }

        }

        public bool updateProviderSQL(int id, string name, string address, string phone)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLUpdateProv;

                command.Parameters.AddWithValue("NOMBRE", name);
                command.Parameters.AddWithValue("DIRECCION", address);
                command.Parameters.AddWithValue("TELEFONO", phone);

                command.Parameters.AddWithValue("ID", id);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool deleteProviderSQL(int id)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLDeleteProv;

                command.Parameters.AddWithValue("ID", id);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getAllProviderSQL()
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetAllProv;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable proveedores = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(proveedores);

                closeConnection();

                return proveedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getFilteredProviderSQL(string filter)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetFilProv + filter;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable proveedores = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(proveedores);

                closeConnection();

                return proveedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getProviderSQL(int idProvider)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetProv;

                command.Parameters.AddWithValue("ID", idProvider);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable proveedores = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(proveedores);

                closeConnection();

                return proveedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region "Métodos Factura Balance"

        public long insertInvoiceProvSQL(int idProv, string dateInvoice, double total)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLInsertInvProv;

                command.Parameters.AddWithValue("ID_PROVEEDOR", idProv);
                command.Parameters.AddWithValue("FECHA", dateInvoice);
                command.Parameters.AddWithValue("TOTAL", total);

                command.ExecuteNonQuery();

                //Recuperamos ID insertado
                SQLiteCommand commandID = connection.CreateCommand();
                commandID.CommandText = @"select last_insert_rowid()";

                long lastId = (long)commandID.ExecuteScalar();

                closeConnection();

                return lastId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getAllInvoiceProviderSQL()
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetAllInvProv;

                command.Parameters.AddWithValue("FECHA", DateTime.Now.ToShortDateString());

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable facturas = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(facturas);

                closeConnection();

                return facturas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getFilteredInvoiceProvSQL(string filter)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetFilInvProv + filter;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable facturas = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(facturas);

                closeConnection();

                return facturas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool deleteInvProvSQL(int id)
        {
            try
            {
                //if (deleteAllLinesInvoiceSQL(id))
                //{
                    openConnection();

                    SQLiteCommand command = connection.CreateCommand();
                    command.CommandText = SQLDeleteInvProv;

                    command.Parameters.AddWithValue("ID", id);

                    command.ExecuteNonQuery();

                    closeConnection();

                    return true;
                //}

                //return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool updateProviderInvoiceTotalSQL(int id, string total)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLUpdateProvInvTotal;

                command.Parameters.AddWithValue("TOTAL", total);

                command.Parameters.AddWithValue("ID", id);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getInvoiceSQL(int idInvoiceLine)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetInvProv;

                command.Parameters.AddWithValue("ID_FACTURA", idInvoiceLine);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable invoices = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(invoices);

                closeConnection();

                return invoices;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region "Métodos Articulo"

        public long insertItemSQL(string reference, long idInv, string description, double pvp, int cantidad, int idProv)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLInsertItem;

                command.Parameters.AddWithValue("REFERENCIA", reference);
                command.Parameters.AddWithValue("ID_FACTURA", idInv);
                command.Parameters.AddWithValue("DESCRIPCION", description);
                command.Parameters.AddWithValue("PVP", pvp);
                command.Parameters.AddWithValue("DISPONIBLE", cantidad);
                command.Parameters.AddWithValue("ID_PROVEEDOR", idProv);

                command.ExecuteNonQuery();

                //Recuperamos ID insertado
                SQLiteCommand commandID = connection.CreateCommand();
                commandID.CommandText = @"select last_insert_rowid()";

                long lastId = (long)commandID.ExecuteScalar();

                closeConnection();

                return lastId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getAllItemSQL()
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetAllItem;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable items = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(items);

                closeConnection();

                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getItemsAvailableSQL()
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetItemAv;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable items = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(items);

                closeConnection();

                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getItemsByReferenceSQL()
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetItemByRef;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable items = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(items);

                closeConnection();

                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getFilteredItemSQL(string filter)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetFilItem + filter;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable items = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(items);

                closeConnection();

                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getFilteredItemByProvSQL(string filter)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetItemsByProv + filter;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable items = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(items);

                closeConnection();

                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool updateStockItemSQL(int idItem, int cantidad)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLUpdateStockItem;

                command.Parameters.AddWithValue("DISPONIBLE", cantidad);
                command.Parameters.AddWithValue("ID", idItem);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool updateStockItemSQL2(int idItem, int cantidad)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLUpdateStockItem2;

                command.Parameters.AddWithValue("DISPONIBLE", cantidad);
                command.Parameters.AddWithValue("ID", idItem);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool deleteItemSQL(int id)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLDeleteItem;

                command.Parameters.AddWithValue("ID", id);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool updateItemSQL(int id, string referencia, string desc, double pvp, int cantidad)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLUpdateItem;

                command.Parameters.AddWithValue("REFERENCIA", referencia);
                command.Parameters.AddWithValue("DESCRIPCION", desc);
                command.Parameters.AddWithValue("PVP", pvp);
                command.Parameters.AddWithValue("DISPONIBLE", cantidad);

                command.Parameters.AddWithValue("ID", id);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getItemSQL(int idItem)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetItem;

                command.Parameters.AddWithValue("ID", idItem);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable items = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(items);

                closeConnection();

                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region "Métodos Linea Factura"

        //public long insertLineInvoiceSQL(long idInvoice, long idItem, double cost, int cantidad)
        //{
        //    try
        //    {
        //        openConnection();

        //        SQLiteCommand command = connection.CreateCommand();
        //        command.CommandText = SQLInsertLineInvProv;

        //        command.Parameters.AddWithValue("ID_FACTURA", idInvoice);
        //        command.Parameters.AddWithValue("ID_ARTICULO", idItem);
        //        command.Parameters.AddWithValue("CANTIDAD", cantidad);
        //        command.Parameters.AddWithValue("IMPORTE", cost);
                

        //        command.ExecuteNonQuery();

        //        //Recuperamos ID insertado
        //        SQLiteCommand commandID = connection.CreateCommand();
        //        commandID.CommandText = @"select last_insert_rowid()";

        //        long lastId = (long)commandID.ExecuteScalar();

        //        closeConnection();

        //        return lastId;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public bool deleteLineInvoiceSQL(int id)
        //{
        //    try
        //    {
        //        openConnection();

        //        SQLiteCommand command = connection.CreateCommand();
        //        command.CommandText = SQLDeleteLineInvProv;

        //        command.Parameters.AddWithValue("ID", id);

        //        command.ExecuteNonQuery();

        //        closeConnection();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public bool deleteAllLinesInvoiceSQL(int id)
        //{
        //    try
        //    {
        //        openConnection();

        //        SQLiteCommand command = connection.CreateCommand();
        //        command.CommandText = SQLDeleteAllLineInvProv;

        //        command.Parameters.AddWithValue("ID_FACTURA", id);

        //        command.ExecuteNonQuery();

        //        closeConnection();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public DataTable getAllLinesInvoiceSQL(int idInvoice)
        //{
        //    try
        //    {
        //        openConnection();

        //        SQLiteCommand command = connection.CreateCommand();
        //        command.CommandText = SQLGetLinesInvoiceProvById;

        //        command.Parameters.AddWithValue("ID_FACTURA", idInvoice);

        //        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        //        DataTable invoices = new DataTable();

        //        adapter.SelectCommand = command;
        //        adapter.Fill(invoices);

        //        closeConnection();

        //        return invoices;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public DataTable getLineInvoiceSQL(int idInvoiceLine)
        //{
        //    try
        //    {
        //        openConnection();

        //        SQLiteCommand command = connection.CreateCommand();
        //        command.CommandText = SQLGetLineInvProv;

        //        command.Parameters.AddWithValue("ID_FACTURA", idInvoiceLine);

        //        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        //        DataTable invoices = new DataTable();

        //        adapter.SelectCommand = command;
        //        adapter.Fill(invoices);

        //        closeConnection();

        //        return invoices;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public bool updateProviderInvoiceLineSQL(int id, string cantidad, string importe)
        //{
        //    try
        //    {
        //        openConnection();

        //        SQLiteCommand command = connection.CreateCommand();
        //        command.CommandText = SQLUpdateProvInvLine;

        //        command.Parameters.AddWithValue("CANTIDAD", cantidad);
        //        command.Parameters.AddWithValue("IMPORTE", importe);

        //        command.Parameters.AddWithValue("ID", id);

        //        command.ExecuteNonQuery();

        //        closeConnection();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public bool deleteProviderInvoiceLineSQL(int id)
        //{
        //    try
        //    {
        //        openConnection();

        //        SQLiteCommand command = connection.CreateCommand();
        //        command.CommandText = SQLDeleteInvProvIle;

        //        command.Parameters.AddWithValue("ID", id);

        //        command.ExecuteNonQuery();

        //        closeConnection();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public bool existItemInvoiceLineSQL(int idItem)
        //{
        //    try
        //    {
        //        openConnection();

        //        SQLiteCommand command = connection.CreateCommand();
        //        command.CommandText = SQLGetLineInvProvByItemID;

        //        command.Parameters.AddWithValue("ID_ARTICULO", idItem);

        //        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        //        DataTable invoicesLines = new DataTable();

        //        adapter.SelectCommand = command;
        //        adapter.Fill(invoicesLines);

        //        closeConnection();

        //        if (invoicesLines.Rows.Count > 0)
        //        {
        //            return true;
        //        }
        //        else {
        //            return false;
        //        }
                
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        #endregion

        #region "Métodos Ticket"

        public long insertTicketSQL(bool bRegalo, string dateInvoice, string timeInvoice, bool bByCard, double dEfectivo, double dTotal)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLInsertTicket;

                command.Parameters.AddWithValue("REGALO", bRegalo);
                command.Parameters.AddWithValue("FECHA", dateInvoice);
                command.Parameters.AddWithValue("HORA", timeInvoice);
                command.Parameters.AddWithValue("TARJETA", bByCard);
                command.Parameters.AddWithValue("EFECTIVO", dEfectivo);
                command.Parameters.AddWithValue("TOTAL", dTotal);
                command.Parameters.AddWithValue("USADO", false);

                command.ExecuteNonQuery();

                //Recuperamos ID insertado
                SQLiteCommand commandID = connection.CreateCommand();
                commandID.CommandText = @"select last_insert_rowid()";

                long lastId = (long)commandID.ExecuteScalar();

                closeConnection();

                return lastId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getTicketByIdSQL(int idTicket)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetTicketById;

                command.Parameters.AddWithValue("ID", idTicket);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable ticket = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(ticket);

                closeConnection();

                return ticket;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool updateTicketSQL(int idTicket)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLUpdateTicketUsed;

                command.Parameters.AddWithValue("ID", idTicket);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getAllTicketsSQL()
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetAllTickets;

                command.Parameters.AddWithValue("FECHA", DateTime.Now.ToShortDateString());

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable tickets = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(tickets);

                closeConnection();

                return tickets;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool deleteTicketSQL(int id)
        {
            try
            { if (deleteAllLinesTicketSQL(id))
                {
                    openConnection();

                    SQLiteCommand command = connection.CreateCommand();
                    command.CommandText = SQLDeleteTicket;

                    command.Parameters.AddWithValue("ID", id);

                    command.ExecuteNonQuery();

                    closeConnection();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region "Métodos Linea Ticket"

        public long insertLineTicketSQL(long idTicket, long idItem, double cost, int cantidad, double descuento)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLInsertLineTicket;

                command.Parameters.AddWithValue("ID_TICKET", idTicket);
                command.Parameters.AddWithValue("ID_ARTICULO", idItem);
                command.Parameters.AddWithValue("CANTIDAD", cantidad);
                command.Parameters.AddWithValue("TOTAL", cost);
                command.Parameters.AddWithValue("DESCUENTO", descuento);

                command.ExecuteNonQuery();

                //Recuperamos ID insertado
                SQLiteCommand commandID = connection.CreateCommand();
                commandID.CommandText = @"select last_insert_rowid()";

                long lastId = (long)commandID.ExecuteScalar();

                closeConnection();

                return lastId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getSalesTodaySQL(string date)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLInsertSalesDayTicket;

                command.Parameters.AddWithValue("FECHA", date);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable sales = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(sales);

                closeConnection();

                return sales;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool deleteLineTicketSQL(int id)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLDeleteLineTicket;

                command.Parameters.AddWithValue("ID", id);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool deleteAllLinesTicketSQL(int id)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLDeleteAllLineTicket;

                command.Parameters.AddWithValue("ID_TICKET", id);

                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getAllLinesTicketSQL(int idTicket)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetLinesTicketById;

                command.Parameters.AddWithValue("ID_TICKET", idTicket);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable tickets = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(tickets);

                closeConnection();

                return tickets;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool existItemTicketLineSQL(int idItem)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetTicketLineByItemID;

                command.Parameters.AddWithValue("ID_ARTICULO", idItem);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable invoicesLines = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(invoicesLines);

                closeConnection();

                if (invoicesLines.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region "Balances"
        public DataTable getProvBalance(string strIni, string strFin)
        {
            openConnection();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = SQLGetPurchasesBySup;

            command.Parameters.AddWithValue("FECHA_INI", strIni);
            command.Parameters.AddWithValue("FECHA_FIN", strFin);

            SQLiteCommand command2 = connection.CreateCommand();

            command2.CommandText = SQLGetSalesBySup;
            command2.Parameters.AddWithValue("FECHA_INI2", strIni);
            command2.Parameters.AddWithValue("FECHA_FIN2", strFin);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable balance = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(balance);

            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter();
            DataTable balance2 = new DataTable();

            adapter2.SelectCommand = command2;
            adapter2.Fill(balance2);

            balance.Columns.Add("TOTAL_VENTAS", typeof(System.Double));

            int i = 0;
            foreach (DataRow dr in balance.Rows)
            {
                dr[2] = balance2.Rows[i][1];
                i++;
            }

            closeConnection();

            return balance;
        }
        #endregion

        #region "Cierre"
        public DataTable getIdCloseDateSQL(string strFecha)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLGetIdCloseDateSQL;

                command.Parameters.AddWithValue("FECHA", strFecha);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable lastReg = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(lastReg);

                closeConnection();

                return lastReg;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public long insertCloseDateSQL(string date)
        {
            try
            {
                openConnection();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = SQLInsertCloseDateSQL;

                command.Parameters.AddWithValue("FECHA", date);

                command.ExecuteNonQuery();

                //Recuperamos ID insertado
                SQLiteCommand commandID = connection.CreateCommand();
                commandID.CommandText = @"select last_insert_rowid()";

                long lastId = (long)commandID.ExecuteScalar();

                closeConnection();

                return lastId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

    }
}
