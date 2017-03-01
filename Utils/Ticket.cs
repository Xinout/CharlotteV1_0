using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;

namespace Utils
{
    public class Ticket
    {
        public bool getTicket(string[,] aItems, bool bEfectivo, double dEfectivo, bool bTicketRegalo, long idTicket)
        {
            try
            {
                double dTotal = 0;
                double dSubtotal = 0;
                double dImpuestos = 0;
                double dCambio = 0;
                double dIVA = 0;

                CreaTicket Ticket1 = new CreaTicket();

                if (bEfectivo)
                {
                    Ticket1.AbreCajon();  //abre el cajon
                }
                
                //Cabecera
                Ticket1.TextoCentro("CRINS CB"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("C/ Collado 17 Local-puerta 4");
                Ticket1.TextoCentro("42002 Soria");
                Ticket1.TextoCentro("Cif. E42213124");
                Ticket1.TextoCentro("Telf. 975 030627");
                Ticket1.LineasGuion();
                Ticket1.EncabezadoVenta();
                Ticket1.LineasGuion();


                
                double dAuxCost, dAuxCostDesc, dDesc = 0;
                int iAuxCant = 0;

                    //Articulos
                for (int i = 0; i < aItems.GetLength(0); i++)
                {
                    double.TryParse(aItems[i, 3], out dAuxCost);
                    int.TryParse(aItems[i, 4], out iAuxCant);
                    double.TryParse(aItems[i, 5], out dDesc);

                    dAuxCostDesc = dAuxCost - (dAuxCost * (dDesc / 100));

                    if(dDesc > 0)
                    {
                        dAuxCostDesc = redondea(dAuxCostDesc);
                    }

                    dTotal += (dAuxCostDesc * iAuxCant);

                    if (!bTicketRegalo)
                    {
                        Ticket1.AgregaArticulo(aItems[i, 1], aItems[i, 2], iAuxCant, dAuxCost, dAuxCostDesc * iAuxCant, dDesc);
                    }
                    else
                    {
                        Ticket1.AgregaArticulo(aItems[i, 1], aItems[i, 2], iAuxCant, 0,0, dDesc);
                    }                      
                }

                if (!bTicketRegalo)
                {
                    //Calculos
                    double.TryParse(ConfigurationManager.AppSettings["IVA"].ToString(), out dIVA);

                    dImpuestos = dTotal * dIVA / 100;
                    dSubtotal = dTotal - dImpuestos;
                    
                    //Totales
                    Ticket1.LineasTotales(); // imprime linea
                    Ticket1.AgregaTotales("Subtotal", dSubtotal); // imprime linea con total
                    Ticket1.AgregaTotales("Impuestos", dImpuestos); // imprime linea con total
                    Ticket1.LineasGuion();
                    Ticket1.AgregaTotales("TOTAL", dTotal);
                    Ticket1.LineasGuion();

                    //Pago
                    if (bEfectivo)
                    {
                        dCambio = dEfectivo - dTotal;

                        Ticket1.TextoIzquierda("Efectivo " + string.Format("{0:0.00}", dEfectivo));
                        Ticket1.TextoIzquierda("Cambio " + string.Format("{0:0.00}", dCambio));
                    }
                    else
                    {
                        Ticket1.TextoIzquierda("Tarjeta " + string.Format("{0:0.00}", dTotal));
                    }

                }
                else
                {
                    //Ticket regalo
                    Ticket1.TextoCentro("TICKET REGALO");
                }

                //Pie
                Ticket1.TextoCentro("Factura simplificada\n");
                if (idTicket == 0)
                {
                    Ticket1.TextoIzquierda(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
                }
                else
                {
                    Ticket1.TextoIzquierda("TK: " + idTicket + " - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
                }

                Ticket1.TextoCentro("Gracias por su visita");

                //Corta el ticket
                Ticket1.CortaTicket(); 
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool getClosingCash(DataTable dtItems, string date, long idFactura)
        {
            try
            {
                CreaTicket Ticket1 = new CreaTicket(); 

                //Cabecera
                Ticket1.TextoCentro("CRINS CB"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("C/ Collado 17 Local-puerta 4");
                Ticket1.TextoCentro("42002 Soria");
                Ticket1.TextoCentro("Cif. E42213124");
                Ticket1.TextoCentro("Telf. 975 030627");

                Ticket1.TextoIzquierda("CAJA DEL DIA:");
                Ticket1.TextoIzquierda("REALIZADA: " + date + " " + DateTime.Now.ToShortTimeString() + "   N.FRA "+ idFactura +"\n");

                //Venta por agente
                //Ticket1.TextoIzquierda("VENTA POR AGENTE:");
                //Ticket1.EncabezadoVentaPorAgente();

                int iUnidades = 0, iAux = 0;
                double dTotal = 0, dAux = 0, dTarjeta = 0, dEfectivo = 0, dDesc = 0;
                bool bAux;
                for (int i = 0; i < dtItems.Rows.Count; i++)
                {
                    double.TryParse(dtItems.Rows[i][1].ToString(), out dAux);
                    int.TryParse(dtItems.Rows[i][2].ToString(), out iAux);
                    bool.TryParse(dtItems.Rows[i][3].ToString(), out bAux);
                    double.TryParse(dtItems.Rows[i][4].ToString(), out dDesc);

                    if (dDesc > 0)
                    {
                        dAux = redondea(dAux);
                    }

                    iUnidades += iAux;
                    dTotal += dAux * iAux;

                    if (bAux)
                    {
                        dTarjeta += dAux * iAux;
                    }
                    else
                    {
                        dEfectivo += dAux * iAux;
                    }
                }
                //Ticket1.AgregaAgente(iUnidades, dTotal);
                //Ticket1.AgregaTotalesAgente("          TOTAL", iUnidades, dTotal);

                //Venta por familia
                Ticket1.TextoIzquierda("VENTA POR FAMILIA:");
                Ticket1.EncabezadoVentaPorFamilia();

                double dPerc = 0;
                for (int i = 0; i < dtItems.Rows.Count; i++)
                {
                    double.TryParse(dtItems.Rows[i][1].ToString(), out dAux);
                    int.TryParse(dtItems.Rows[i][2].ToString(), out iAux);
                    double.TryParse(dtItems.Rows[i][4].ToString(), out dDesc);

                    if (dDesc > 0)
                    {
                        dAux = redondea(dAux);
                    }

                    dPerc = (dAux * iAux) * 100 / dTotal;

                    Ticket1.AgregaFamilia(dtItems.Rows[i][0].ToString(), iAux, dAux,dAux*iAux, dPerc); 
                }
                Ticket1.LineasGuion();
                Ticket1.AgregaTotalesFamilia("          TOTAL", iUnidades, dTotal, 100);


                Ticket1.TextoIzquierda("\n**La moneda activa es: Eur**\n");

                //Totales
                double dIVAPerc = 0, dSubTotal = 0, dRE = 0, dIVAAmount = 0;
                double.TryParse(ConfigurationManager.AppSettings["IVA"].ToString(), out dIVAPerc);

                dIVAAmount = dTotal * dIVAPerc / 100;
                dSubTotal = dTotal - dIVAAmount;

                Ticket1.TextoIzquierda("TOTAL VENTAS: " + string.Format("{0:0.00}", dTotal).ToString());
                Ticket1.TextoIzquierda("EN EFECTIVO: " + string.Format("{0:0.00}", dEfectivo).ToString());
                Ticket1.TextoIzquierda("CON TARJETA: " + string.Format("{0:0.00}", dTarjeta).ToString());
                //Ticket1.TextoIzquierda("EFECTIVO EN CAJA: ");
                Ticket1.LineasGuion();
                Ticket1.EncabezadoCierreCaja();
                Ticket1.AgregaTotalesCierreCaja(string.Format("{0:0.00}", dIVAPerc).ToString(), dSubTotal, dRE, dIVAAmount, dTotal);
                

                //Pie
                Ticket1.TextoCentro("Factura simplificada\n");

                Ticket1.TextoCentro("Gracias por su visita");

                //Corta el ticket
                Ticket1.CortaTicket();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool getTarjetaRegalo(double dValor, string strNombre, long idTicket)
        {
            try
            {
                CreaTicket Ticket1 = new CreaTicket();

                //Cabecera
                Ticket1.TextoCentro("CRINS CB"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("C/ Collado 17 Local-puerta 4");
                Ticket1.TextoCentro("42002 Soria");
                Ticket1.TextoCentro("Cif. E42213124");
                Ticket1.TextoCentro("Telf. 975 030627");

                Ticket1.TextoCentro("TICKET REGALO");
                if (!string.IsNullOrEmpty(strNombre))
                {
                    Ticket1.TextoCentro("ENTREGADO A: " + strNombre);
                }

                Ticket1.TextoCentro("POR VALOR DE " + string.Format("{0:0.00} EUROS", dValor).ToString() + "\n");

                //Pie
                Ticket1.TextoCentro("Factura simplificada\n");
                Ticket1.TextoIzquierda("TK: " + idTicket + " - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
                Ticket1.TextoCentro("Gracias por su visita");

                //Corta el ticket
                Ticket1.CortaTicket();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool getTicketVale(string[,] aItems, long idTicket)
        {
            try
            {
                CreaTicket Ticket1 = new CreaTicket();

                //Cabecera
                Ticket1.TextoCentro("CRINS CB"); 
                Ticket1.TextoCentro("C/ Collado 17 Local-puerta 4");
                Ticket1.TextoCentro("42002 Soria");
                Ticket1.TextoCentro("Cif. E42213124");
                Ticket1.TextoCentro("Telf. 975 030627");

                Ticket1.LineasGuion();
                Ticket1.EncabezadoVenta();
                Ticket1.LineasGuion();


                double dTotal = 0;
                double dAuxCost = 0;
                int iAuxCant = 0;

                //Articulos
                for (int i = 0; i < aItems.GetLength(0); i++)
                {
                    double.TryParse(aItems[i, 3], out dAuxCost);
                    int.TryParse(aItems[i, 4], out iAuxCant);

                    dTotal += dAuxCost * iAuxCant;

                    Ticket1.AgregaArticulo(aItems[i, 1], aItems[i, 2], iAuxCant, dAuxCost, dAuxCost * iAuxCant,0);
                }

                Ticket1.TextoCentro("DEVOLUCION\n");
                Ticket1.TextoCentro("ESTE TICKET TIENE UN VALOR DE:\n");
                Ticket1.TextoCentro(string.Format("{0:0.00}", Math.Abs(dTotal)).ToString() + " EUROS\n");

                //Pie
                Ticket1.TextoCentro("Factura simplificada\n");
                Ticket1.TextoIzquierda("TK: " + idTicket + " - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
                Ticket1.TextoCentro("Gracias por su visita");

                //Corta el ticket
                Ticket1.CortaTicket();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool getTicketCopy(int idTicket)
        {
            try
            {
                double dTotal = 0;
                double dSubtotal = 0;
                double dImpuestos = 0;
                double dCambio = 0;
                double dIVA = 0;

                CreaTicket Ticket1 = new CreaTicket();

                //Cabecera
                Ticket1.TextoCentro("CRINS CB"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("C/ Collado 17 Local-puerta 4");
                Ticket1.TextoCentro("42002 Soria");
                Ticket1.TextoCentro("Cif. E42213124");
                Ticket1.TextoCentro("Telf. 975 030627");
                Ticket1.LineasGuion();
                Ticket1.EncabezadoVenta();
                Ticket1.LineasGuion();



                double dAuxCost = 0;
                int iAuxCant = 0;

                //Articulos
                //for (int i = 0; i < aItems.GetLength(0); i++)
                //{
                //    double.TryParse(aItems[i, 3], out dAuxCost);
                //    int.TryParse(aItems[i, 4], out iAuxCant);

                //    dTotal += dAuxCost * iAuxCant;

                //    //if (!bTicketRegalo)
                //    //{
                //    //    Ticket1.AgregaArticulo(aItems[i, 1], aItems[i, 2], iAuxCant, dAuxCost, dAuxCost * iAuxCant);
                //    //}
                //    //else
                //    //{
                //    //    Ticket1.AgregaArticulo(aItems[i, 1], aItems[i, 2], iAuxCant, 0, 0);
                //    //}
                //}

                //if (!bTicketRegalo)
                //{
                //    //Calculos
                //    double.TryParse(ConfigurationManager.AppSettings["IVA"].ToString(), out dIVA);

                //    dImpuestos = dTotal * dIVA / 100;
                //    dSubtotal = dTotal - dImpuestos;

                //    //Totales
                //    Ticket1.LineasTotales(); // imprime linea
                //    Ticket1.AgregaTotales("Subtotal", dSubtotal); // imprime linea con total
                //    Ticket1.AgregaTotales("Impuestos", dImpuestos); // imprime linea con total
                //    Ticket1.LineasGuion();
                //    Ticket1.AgregaTotales("TOTAL", dTotal);
                //    Ticket1.LineasGuion();

                //    //Pago
                //    //if (bEfectivo)
                //    //{
                //    //    dCambio = dEfectivo - dTotal;

                //    //    Ticket1.TextoIzquierda("Efectivo " + string.Format("{0:0.00}", dEfectivo));
                //    //    Ticket1.TextoIzquierda("Cambio " + string.Format("{0:0.00}", dCambio));
                //    //}
                //    //else
                //    //{
                //    //    Ticket1.TextoIzquierda("Tarjeta " + string.Format("{0:0.00}", dTotal));
                //    //}

                //}
                //else
                //{
                //    //Ticket regalo
                //    Ticket1.TextoCentro("TICKET REGALO");
                //}

                //Pie
                Ticket1.TextoCentro("Factura simplificada\n");
                Ticket1.TextoIzquierda("TK: " + idTicket + " - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
                Ticket1.TextoCentro("Gracias por su visita");

                //Corta el ticket
                Ticket1.CortaTicket();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        private double redondea(double total)
        {
            double aux = total * 2;
            aux = Math.Round(aux, MidpointRounding.AwayFromZero);
            aux = aux / 2;

            return aux;
        }

    }
}
