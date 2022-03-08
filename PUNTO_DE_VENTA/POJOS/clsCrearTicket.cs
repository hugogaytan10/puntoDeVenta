using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace PUNTO_DE_VENTA.POJOS
{
    public class clsCrearTicket
    {
        public string empresa { get; set; }
        public string direccion { get; set; }
        public string telefeno { get; set; }
        public double total { get; set; }
        public string nombreTicket { get; set; }
        public double dinero_recibido { get; set; }
        public List<clsProductos> listaP = new List<clsProductos>();
        public Image logo { get; set; }
        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();
        string ticket = "";
        string parte1, parte2;
        string impresora = "L4150 Series(Network)"; // nombre exacto de la impresora como esta en el panel de control
        int max, cort;
        int posx, posy;
        string textoIzquierda = "";
        string textoCentro = "";
        string textoDerecha = "";
        Font fuente = new Font("consola", 6);
        public void imprimir(clsCrearTicket t)
        {
            // para obtener la impresora 
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            // metodo
            //textoIzquierda = "Cajero 1";
            //doc.PrintPage += new PrintPageEventHandler(textoIzquieraEvent);
            //textoDerecha = "Caja 1";
            //doc.PrintPage += new PrintPageEventHandler(textoDerechaEvent);


            doc.PrintPage += new PrintPageEventHandler(imprimirTicket);
            vista.Document = doc;
            vista.Show();
            doc.Print();
        }
        public void imprimirTicket(object sender, PrintPageEventArgs e)
        {

            try
            {
                posx = 0;  posy = 10;
                e.Graphics.DrawImage(logo, 15, 20, 100, 100);
                posy += 115;
                e.Graphics.DrawString(empresa, fuente, Brushes.Black, posx, posy);
                posy += 15; posx = 0;
                e.Graphics.DrawString(direccion, fuente, Brushes.Black, posx, posy);
                posy += 15;
                e.Graphics.DrawString(telefeno, fuente, Brushes.Black, posx, posy);
                posy += 15;

                fuente = new Font("consola", 4);
                //e.Graphics.DrawString("-------------------------------------------------------------------------------", fuente, Brushes.Black, posx, posy);
                //posy += 15;
                //e.Graphics.DrawString("PRODUCTO           PRECIO         CANT.          SUBTOTAL", fuente, Brushes.Black, posx, posy);
                //posy += 15;
                //e.Graphics.DrawString("-------------------------------------------------------------------------------", fuente, Brushes.Black, posx, posy);
                //posy += 25;
                // 18 26 30 36 40

                // SINO FUNCIONA PONER UNA VARIBALE STRING ANTES DE CADA METODO
                string documento = empresa + '\n' + direccion + '\n' + telefeno + '\n';
                clsCrearTicket Ticket1 = new clsCrearTicket();
                documento += Ticket1.TextoIzquierda("Empleado 1");
                
                e.Graphics.DrawString("Empleado 1", fuente, Brushes.Black, posx, posy);
                posy += 15; posx = 180;
                documento += Ticket1.TextoDerecha("Caja 1");
                e.Graphics.DrawString("Caja 1", fuente, Brushes.Black, posx, posy);
                posy += 15; posx = 70;
                documento += Ticket1.TextoCentro("Ticket: " + nombreTicket);
                e.Graphics.DrawString("Ticket: "+nombreTicket, fuente, Brushes.Black, posx, posy);
                posy += 15; posx = 0;
                fuente = new Font("consola", 3);
                string fecha = DateTime.Today.ToString("yyyy-MM-dd");
                string hora = DateTime.Now.ToString("hh:mm:ss tt");
                documento += Ticket1.TextoExtremos("Fecha: " + fecha, "Hora: " + hora);
                e.Graphics.DrawString("Fecha: " + fecha, fuente, Brushes.Black, posx, posy);
                posx = 120;
                e.Graphics.DrawString("Hora: " + hora, fuente, Brushes.Black, posx, posy);
                posy += 15; posx -= 55;
                documento += Ticket1.TextoCentro("Venta mostrador"); // imprime en el centro "Venta mostrador"
                e.Graphics.DrawString("Venta mostrador", fuente, Brushes.Black, posx, posy);
                posy += 15; posx = 1;



                documento += Ticket1.LineasGuion(); // imprime una linea de guiones
                documento += Ticket1.EncabezadoVenta(); // imprime encabezados

                fuente = new Font("consola", 5);
                e.Graphics.DrawString("-------------------------------------------------------------------------------", fuente, Brushes.Black, posx, posy);
                posy += 15;
                e.Graphics.DrawString("PRODUCTO           PRECIO         CANT.          SUBTOTAL", fuente, Brushes.Black, posx, posy);
                posy += 15;
                e.Graphics.DrawString("-------------------------------------------------------------------------------", fuente, Brushes.Black, posx, posy);
                posy += 25;


                fuente = new Font("consola", 4);
                for (int i = 0; i < listaP.Count; i++)
                {
                    e.Graphics.DrawString(listaP[i].NombreProducto, fuente, Brushes.Black, posx, posy);
                    posy += 15;
                    e.Graphics.DrawString(espaciar(0, 45) + listaP[i].PrecioUnitario +
                        espaciar(listaP[i].PrecioUnitario.ToString().Length, 30) +
                        listaP[i].Cantidad + espaciar(listaP[i].Cantidad.ToString().Length, 25) +
                        listaP[i].SubTotal, fuente, Brushes.Black, posx, posy);
                    posy += 10;
                    //AGREGAMOS ESTO A NUESTRO DOCUMENTO PARA GUARDARLO EN LA BD
                    documento += Ticket1.AgregaArticulo(listaP[i].NombreProducto, Convert.ToDouble(listaP[i].Cantidad), listaP[i].PrecioUnitario, listaP[i].SubTotal);
                }
                //SE ALTERNA ENTRE CAMBIAR DE FUENTE 
                //AGREGARLO AL DOCUMENTO QUE SE GUARDARÁ EN EL DISPOSITIVO COMO
                //LO QUE SE ESTA DIBUJANDO PARAIMPRIMIR
                fuente = new Font("consola", 5);
                e.Graphics.DrawString("-------------------------------------------------------------------------------", fuente, Brushes.Black, posx, posy);
                posx += 69; posy += 15;
                documento += Ticket1.TextoCentro("TOTAL: "+total);
                fuente = new Font("consola", 4, FontStyle.Bold);
                e.Graphics.DrawString("TOTAL:       *** " + total +" ***", fuente, Brushes.Black, posx, posy);
                posy += 15;
                //SACAMOS EL IVA DE LA VENTA
                double iva = total / 1.16;
                iva = Math.Round((iva - total),2);
                if (iva < 0)
                {
                    iva = iva * -1;
                }
                documento += Ticket1.TextoCentro("IVA 16%: "+iva);
                e.Graphics.DrawString("            IVA 16%:                            " + iva + "", fuente, Brushes.Black, posx, posy);
                posy += 15; posx = 1;
                documento += Ticket1.TextoCentro("EFECTIVO: " + dinero_recibido);
                e.Graphics.DrawString("EFECTIVO:                                                                                 " + dinero_recibido, fuente, Brushes.Black, posx, posy);
                posy += 15; posx = 70;
                //PONEMOS EL CAMBIO DE LA VENTA
                double cambio = Math.Round((dinero_recibido - total),2);
                fuente = new Font("consola", 4);
                documento += Ticket1.TextoCentro("CAMBIO: " + cambio);
                e.Graphics.DrawString("CAMBIO:                                             " + cambio, fuente, Brushes.Black, posx, posy);
                posy += 15; posx = 60;
                documento += Ticket1.TextoCentro("GRACIAS POR SU COMPRA");
                e.Graphics.DrawString("GRACIAS POR SU COMPRA", fuente, Brushes.Black, posx, posy);
                posy += 25;

                //LE DAMOS EL NOMBRE DE CADA ORDEN
                string path = @"C:\Users\estar\OneDrive\Documentos\"+nombreTicket+".txt";
                //string path = @"C:\"+nombreTicket+".doc";

                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(documento);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                }
                catch (Exception ex) { }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public string espaciar(int tamano, int valor)
        {
            string espacio = "";
            int subvalor = 0;
            subvalor = valor - tamano;
            for(int i=0; i<subvalor; i++)
            {
                espacio = espacio + " ";
            }
            return espacio;
        }
        public void textoIzquieraEvent(object sender, PrintPageEventArgs e)
        {
            posx += 0; posy += 8;
            textoIzquierda = TextoIzquierda(textoIzquierda);
            e.Graphics.DrawString(textoIzquierda, fuente, Brushes.Black, posx, posy);
            posy += 10;
        }
        public string TextoIzquierda(string par1)                          // agrega texto a la izquierda
        {
            
            max = par1.Length;
            if (max > 40)                                 // **********
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);        // si es mayor que 40 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1 + "\n";

            return ticket;
        }
        public void textoDerechaEvent(object sender, PrintPageEventArgs e)
        {
            TextoDerecha(textoDerecha);
            posx += max;
            e.Graphics.DrawString(textoDerecha,fuente, Brushes.Black, posx, posy);
            posy += 10;
        }
        public string TextoDerecha(string par1)
        {
            ticket = "";
            max = par1.Length;
            if (max > 40)                                 // **********
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);           // si es mayor que 40 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            max = 40 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
            for (int i = 0; i < max; i++)
            {
                ticket += " ";                          // agrega espacios para alinear a la derecha
            }
            ticket += parte1 + "\n";                    //Agrega el texto
            return ticket;
        }
        public string EncabezadoVenta()
        {
            return ticket = "Articulo        Can    P.Unit    Importe\n";   // agrega lineas de  encabezados
            
        }
        public string TextoCentro(string par1)
        {
            ticket = "";
            max = par1.Length;
            if (max > 40)                                 // **********
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios antes del texto a centrar
            }                                            // **********
            return ticket += parte1 + "\n";
            
        }
        public string TextoExtremos(string par1, string par2)
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
            max = 40 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)                 // **********
            {
                ticket += " ";                            // Agrega espacios para poner par2 al final
            }                                             // **********
            return ticket += parte2 + "\n";                     // agrega el segundo parametro al final
            
        }
        public string LineasGuion()
        {
            return ticket = "----------------------------------------\n";   // agrega lineas separadoras -
        }
        public string AgregaArticulo(string par1, double cant, double precio, double total)
        {
            if (cant.ToString().Length <= 4 && precio.ToString("c").Length <= 10 && total.ToString("c").Length <= 11) // valida que cant precio y total esten dentro de rango
            {
                max = par1.Length;
                if (max > 16)                                 // **********
                {
                    cort = max - 16;
                    parte1 = par1.Remove(16, cort);          // corta a 16 la descripcion del articulo
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega articulo
                max = (3 - cant.ToString().Length) + (16 - parte1.Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }
                ticket += cant.ToString();                   // agrega cantidad
                max = 10 - (precio.ToString("c").Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                ticket += precio.ToString("c"); // agrega precio
                max = 11 - (total.ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                return ticket += total.ToString("c") + "\n"; // agrega precio
            }
            else
            {
                MessageBox.Show("Valores fuera de rango");
                return "\n";
            }
        }



        // caliz
        /*
        public void inicio()
        {
            string descripcion = "Aspirina tabletas";
            int cantidad = 2;
            double precio = 45.25;
            double total = 90.5;
            double TotalFinal = 0;
            CreaTicket Ticket1 = new CreaTicket();
            //Ticket1.AbreCajon();  //abre el cajon
            Ticket1.TextoIzquierda("Empleado 1");
            Ticket1.TextoDerecha("Caja 1");
            Ticket1.TextoCentro("Ticket");
            string fecha = DateTime.Today.ToString("yyyy-MM-dd"); 
            string hora = DateTime.Today.ToString("hh:mm:ss"); 
            Ticket1.TextoExtremos("Fecha: "+fecha, "Hora: "+hora);
            Ticket1.TextoCentro("Venta mostrador"); // imprime en el centro "Venta mostrador"
            Ticket1.LineasGuion(); // imprime una linea de guiones
            Ticket1.EncabezadoVenta(); // imprime encabezados
            for (int i=0; i<listaP.Count; i++)
            {
                descripcion = listaP[i].NombreProducto;
                cantidad = listaP[i].Cantidad;
                precio = listaP[i].PrecioUnitario;
                total = listaP[i].SubTotal;
                Ticket1.AgregaArticulo(descripcion, cantidad, precio, total); //imprime una linea de descripcion
                TotalFinal += total;
            }
            
            
            Ticket1.LineasTotales(); // imprime linea
            Ticket1.AgregaTotales("Total", TotalFinal); // imprime linea con total
            Ticket1.LineasAsterisco();
            Ticket1.LineasIgual();
            Ticket1.CortaTicket(); // corta el ticket
        }*/
    }
    //#region Clase para generar ticket
    // La clase "CreaTicket" tiene varios metodos para imprimir con diferentes formatos (izquierda, derecha, centrado, desripcion precio,etc), a
    // continuacion se muestra el metodo con ejemplo de parametro que acepta, longitud maxima y un ejemplo de como imprimira, esta clase esta
    // basada en una impresora Epson de matriz de puntos con impresion maxima de 40 caracteres por renglon
    // METODO                                      MAX_LONG                        EJEMPLOS
    //--------------------------------------------------------------------------------------------------------------------------
    // TextoIzquierda("Empleado 1")                    40                      Empleado 1      
    // TextoDerecha("Caja 1")                          40                                                        Caja 1
    // TextoCentro("Ticket")                           40                                         Ticket   
    // TextoExtremos("Fecha 6/1/2011","Hora:13:25")     18 y 18                 Fecha 6/1/2011                Hora:13:25
    // EncabezadoVenta()                                n/a                     Articulo        Can    P.Unit    Importe
    // LineasGuion()                                    n/a                     ----------------------------------------
    // AgregaArticulo("Aspirina","2",45.25,90.5)        16,3,10,11              Aspirina          2    $45.25     $90.50
    // LineasTotales()                                  n/a                                                ----------
    // AgregaTotales("Subtotal",235.25)                 25 y 15                Subtotal                         $235.25
    // LineasAsterisco()                                n/a                     ****************************************
    // LineasIgual()                                    n/a                     ========================================
    // CortaTicket()
    // AbreCajon()
    

    /*
    public class CreaTicket
    {
        string ticket = "";
        string parte1, parte2;
        string impresora = "L4150 Series(Network)"; // nombre exacto de la impresora como esta en el panel de control
        int max, cort;
        public void LineasGuion()
        {
            ticket = "----------------------------------------\n";   // agrega lineas separadoras -
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
            ticket = "                             -----------\n"; ;   // agrega lineas de total
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
        }
        public void EncabezadoVenta()
        {
            ticket = "Articulo        Can    P.Unit    Importe\n";   // agrega lineas de  encabezados
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
        {
            max = par1.Length;
            if (max > 40)                                 // **********
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);        // si es mayor que 40 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1 + "\n";
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        public void TextoDerecha(string par1)
        {
            ticket = "";
            max = par1.Length;
            if (max > 40)                                 // **********
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);           // si es mayor que 40 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            max = 40 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
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
            if (max > 40)                                 // **********
            {
                cort = max - 40;
                parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
            }
            else { parte1 = par1; }                      // **********
            max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
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
            max = 40 - (parte1.Length + parte2.Length);
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
            parte2 = total.ToString("c");
            max = 40 - (parte1.Length + parte2.Length);
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
            }                                            // **********
            ticket += parte2 + "\n";
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            
        }
        public void AgregaArticulo(string par1, int cant, double precio, double total)
        {
            if (cant.ToString().Length <= 4 && precio.ToString("c").Length <= 10 && total.ToString("c").Length <= 11) // valida que cant precio y total esten dentro de rango
            {
                max = par1.Length;
                if (max > 16)                                 // **********
                {
                    cort = max - 16;
                    parte1 = par1.Remove(16, cort);          // corta a 16 la descripcion del articulo
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega articulo
                max = (3 - cant.ToString().Length) + (16 - parte1.Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                }
                ticket += cant.ToString();                   // agrega cantidad
                max = 10 - (precio.ToString("c").Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                ticket += precio.ToString("c"); // agrega precio
                max = 11 - (total.ToString().Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios
                }                                            // **********
                ticket += total.ToString("c") + "\n"; // agrega precio
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            else
            {
                MessageBox.Show("Valores fuera de rango");
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
            string cajon1 = "\x1B" + "p" + "\x01" + "\x0F" + "\x96";                 // caracteres de apertura cajon 1
            RawPrinterHelper.SendStringToPrinter(impresora, cajon0); // abre cajon0
            //RawPrinterHelper.SendStringToPrinter(impresora, cajon1); // abre cajon1
        }
    
    #endregion
    #region Clase para enviar a imprsora texto plano
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "My C#.NET RAW Document";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                        
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
                
            return true;
        }
    }
    #endregion
    }*/
}
