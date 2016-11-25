using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Utils
{
    public class CreaTicket
    {
        string ticket = "";
        string parte1, parte2;
        string impresora = "TOTALES"; // nombre exacto de la impresora como esta en el panel de control
        int max, cort;
        public void LineasGuion()
        {
            ticket = "--------------------------------------------\n";   // agrega lineas separadoras -
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
        }
        public void LineasAsterisco()
        {
            ticket = "****************************************\n";   // agrega lineas separadoras *
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
        }
        public void LineasIgual()
        {
            ticket = "========================================\n";   // agrega lineas separadoras =
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
        }
        public void LineasTotales()
        {
            ticket = "                                 -----------\n"; ;   // agrega lineas de total
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
        }
        public void EncabezadoVenta()
        {
            ticket = "Ref      Descripcion  Can P.Unit  Dto    Imp\n";   // agrega lineas de  encabezados
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void EncabezadoVentaPorAgente()
        {
            ticket = "AGENTE DE VENTA      IMPORTE     CANTIDAD\n";   // agrega lineas de  encabezados
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void EncabezadoVentaPorFamilia()
        {
            ticket = "Familia          Importe   Cantidad        %\n";   // agrega lineas de  encabezados
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void EncabezadoCierreCaja()
        {
            ticket = "IVA %      SUBTOTAL        IVA         TOTAL\n";   // agrega lineas de  encabezados
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
        {
            max = par1.Length;
            if (max > 44)                                 // **********
            {
                cort = max - 44;
                parte1 = par1.Remove(44, cort);        // si es mayor que 60 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1 + "\n";
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void TextoDerecha(string par1)
        {
            ticket = "";
            max = par1.Length;
            if (max > 44)                                 // **********
            {
                cort = max - 44;
                parte1 = par1.Remove(44, cort);           // si es mayor que 60 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            max = 44 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 60
            for (int i = 0; i < max; i++)
            {
                ticket += " ";                          // agrega espacios para alinear a la derecha
            }
            ticket += parte1 + "\n";                    //Agrega el texto
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void TextoCentro(string par1)
        {
            ticket = "";
            max = par1.Length;
            if (max > 44)                                 // **********
            {
                cort = max - 44;
                parte1 = par1.Remove(44, cort);          // si es mayor que 60 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            max = (int)(44 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios antes del texto a centrar
            }                                            // **********
            ticket += parte1 + "\n";
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void TextoExtremos(string par1, string par2)
        {
            max = par1.Length;
            if (max > 18)                                 // **********
            {
                cort = max - 18;
                parte1 = par1.Remove(18, cort);          // si par1 es mayor que 18 lo corta
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1;                             // agrega el primer parametro
            max = par2.Length;
            if (max > 18)                                 // **********
            {
                cort = max - 18;
                parte2 = par2.Remove(18, cort);          // si par2 es mayor que 18 lo corta
            }
            else { parte2 = par2; }
            max = 60 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)                 // **********
            {
                ticket += " ";                            // Agrega espacios para poner par2 al final
            }                                             // **********
            ticket += parte2 + "\n";                     // agrega el segundo parametro al final
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void AgregaTotales(string par1, double total)
        {
            max = par1.Length;
            if (max > 25)                                 // **********
            {
                cort = max - 25;
                parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1;
            parte2 = string.Format("{0:0.00}", total).ToString();
            max = 44 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += parte2 + "\n";
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void AgregaTotalesAgente(string par1, int unidades, double total)
        {
            max = par1.Length;
            if (max > 25)                                 // **********
            {
                cort = max - 25;
                parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1;
            parte2 = string.Format("{0:0.00}", total).ToString();
            max = 28 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += parte2;

            max = 13 - string.Format("{0:0.00} Uds", unidades).ToString().Length;
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += string.Format("{0:0.00} Uds", unidades).ToString() + "\n";
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void AgregaTotalesFamilia(string par1, int unidades, double total, double percTotal)
        {
            max = par1.Length;
            if (max > 25)                                 // **********
            {
                cort = max - 25;
                parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1;
            parte2 = string.Format("{0:0.00}", total).ToString();
            max = 24 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += parte2;

            max = 11 - string.Format("{0:0.00}", unidades).ToString().Length;
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += string.Format("{0:0.00}", unidades).ToString();

            max = 9 - string.Format("{0:0.00}", percTotal).ToString().Length;
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += string.Format("{0:0.00}", percTotal).ToString() + "\n";
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void AgregaTotalesCierreCaja(string par1, double subtotal, double re, double iva, double total)
        {
            max = par1.Length;
            if (max > 5)                                 // **********
            {
                cort = max - 5;
                parte1 = par1.Remove(5, cort);          // si es mayor que 25 lo corta
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1;
            parte2 = string.Format("{0:0.00}", subtotal).ToString();
            max = 19 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += parte2;

            max = 11 - string.Format("{0:0.00}", iva).ToString().Length;
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += string.Format("{0:0.00}", iva).ToString();

            //max = 8 - string.Format("{0:0.00}", re).ToString().Length;
            //for (int i = 0; i < max; i++)                // **********
            //{
            //    ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            //}                                            // **********
            //ticket += string.Format("{0:0.00}", re).ToString();

            max = 14 - string.Format("{0:0.00}", total).ToString().Length;
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += string.Format("{0:0.00}", total).ToString() + "\n";
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void AgregaArticulo(string par1, string par2, int cant, double precio, double total, double descuento)
        {
            if (cant.ToString().Length <= 3 && string.Format("{0:0.00}",precio).ToString().Length <= 10 && string.Format("{0:0.00}",total).ToString().Length <= 11) // valida que cant precio y string.Format("{0:0.00}",total) esten dentro de rango
            {
                max = par1.Length;
                if (max > 9)                                 // **********
                {
                    cort = max - 9;
                    parte1 = par1.Remove(9, cort);          // corta a 16 la descripcion del articulo
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega articulo

                max = 9 - parte1.Length;
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }

                max = par2.Length;
                if (max > 12)
                {
                    cort = max - 12;
                    parte2 = par2.Remove(12, cort);
                    par2 = parte2;
                }
                ticket += par2.ToString();

                max = (3 - cant.ToString().Length) + (11 - par2.Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }
                ticket += cant.ToString();                   // agrega cantidad
                max = 9 - (string.Format("{0:0.00}",precio).ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }
                ticket += string.Format("{0:0.00}", precio).ToString();// **********
                max = 4 - (string.Format("{0:0}", descuento).ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }
                ticket += string.Format("{0:0}", descuento).ToString() + "%"; // agrega precio
                max = 7 - (string.Format("{0:0.00}",total).ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                ticket += string.Format("{0:0.00}", total).ToString() + "\n"; // agrega precio
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            else
            {
                //MessageBox.Show("Valores fuera de rango");
                RawPrinterHelper.SendStringToPrinter(impresora, "Error, valor fuera de rango\n"); // imprime texto
            }
        }
        public void AgregaAgente(int cant, double precio)
        {

            if (cant.ToString().Length <= 3 && string.Format("{0:0.00}", precio).ToString().Length <= 10) // valida que cant precio y string.Format("{0:0.00}",total) esten dentro de rango
            {                       // agrega articulo
                ticket = "";
                max = 15;
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }

                max = 13 - (string.Format("{0:0.00}", precio).ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                ticket += string.Format("{0:0.00}", precio).ToString(); // agrega precio

                max = (13 - cant.ToString().Length - 4);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }
                ticket += cant.ToString() + " Uds";                   // agrega cantidad
                
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            else
            {
                //MessageBox.Show("Valores fuera de rango");
                RawPrinterHelper.SendStringToPrinter(impresora, "Error, valor fuera de rango\n"); // imprime texto
            }
        }
        public void AgregaFamilia(string par1, int cant, double precio, double total, double porcentaje)
        {
            if (cant.ToString().Length <= 3 && string.Format("{0:0.00}", precio).ToString().Length <= 10 && string.Format("{0:0.00}", total).ToString().Length <= 11) // valida que cant precio y string.Format("{0:0.00}",total) esten dentro de rango
            {
                max = par1.Length;
                if (max > 12)                                 // **********
                {
                    cort = max - 12;
                    parte1 = par1.Remove(12, cort);          // corta a 16 la descripcion del articulo
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega articulo

                max = 14 - parte1.Length;
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }

                max = 10 - (string.Format("{0:0.00}", precio).ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                ticket += string.Format("{0:0.00}", precio).ToString(); // agrega precio

                max = (11 - cant.ToString().Length); 
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }
                ticket += cant.ToString();

                max = (9 - string.Format("{0:0.00}", porcentaje).ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }
                ticket += string.Format("{0:0.00}", porcentaje).ToString() + "\n";

                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            else
            {
                //MessageBox.Show("Valores fuera de rango");
                RawPrinterHelper.SendStringToPrinter(impresora, "Error, valor fuera de rango\n"); // imprime texto
            }
        }
        public void AgregaCierreCaja(string par1, string par2, int cant, double precio, double total)
        {
            if (cant.ToString().Length <= 3 && string.Format("{0:0.00}", precio).ToString().Length <= 10 && string.Format("{0:0.00}", total).ToString().Length <= 11) // valida que cant precio y string.Format("{0:0.00}",total) esten dentro de rango
            {
                max = par1.Length;
                if (max > 9)                                 // **********
                {
                    cort = max - 9;
                    parte1 = par1.Remove(9, cort);          // corta a 16 la descripcion del articulo
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega articulo

                max = 9 - parte1.Length;
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }
                ticket += par2.ToString();

                max = (3 - cant.ToString().Length) + (23 - par2.Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }
                ticket += cant.ToString();                   // agrega cantidad
                max = 10 - (string.Format("{0:0.00}", precio).ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                ticket += string.Format("{0:0.00}", precio).ToString(); // agrega precio
                max = 11 - (string.Format("{0:0.00}", total).ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                ticket += string.Format("{0:0.00}", total).ToString() + "\n"; // agrega precio
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            else
            {
                //MessageBox.Show("Valores fuera de rango");
                RawPrinterHelper.SendStringToPrinter(impresora, "Error, valor fuera de rango\n"); // imprime texto
            }
        }
        public void CortaTicket()
        {
            string corte = "\x1B" + "m";                  // caracteres de corte
            string avance = "\x1B" + "d" + "\x09";        // avanza 9 renglones
            RawPrinterHelper.SendStringToPrinter(impresora, avance); // avanza
            RawPrinterHelper.SendStringToPrinter(impresora, corte); // corta
        }
        public void AbreCajon()
        {
            string cajon0 = "\x1B" + "p" + "\x00" + "\x0F" + "\x96";                  // caracteres de apertura cajon 0
            //string cajon1 = "\x1B" + "p" + "\x01" + "\x0F" + "\x96";                 // caracteres de apertura cajon 1
            RawPrinterHelper.SendStringToPrinter(impresora, cajon0); // abre cajon0
            //RawPrinterHelper.SendStringToPrinter(impresora, cajon1); // abre cajon1
        }
    }
}
