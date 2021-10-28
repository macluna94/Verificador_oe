using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;


namespace SmartDeviceProject4
{
    public partial class Form1 : Form
    {

        DB db = new DB("SERVER=DESKTOP-5R3S1IE\\SQLEXPRESS;DATABASE=Retail One;User Id=sa; Password=B1Admin ");
        //DB db = new DB("SERVER=DESKTOP-TM0V60N\\SQLEXPRESS;DATABASE=Retail One;User Id=sa; Password=B1Admin ");
 

        String cadena = "", promociones, barras;
        String nombre, price, existencia, mayoreo;
        //, promosapl;
        List<String> ltipo = new List<String>();
        List<String> lpromo = new List<String>();
        List<String> laplica = new List<String>();
        //ThreadStart delegado2;
        //Thread hilo2;

        float precio = 0;

        public Form1()
        {
            InitializeComponent();


        }
        private void label2_ParentChanged(object sender, EventArgs e)
        {
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            banner.Visible = true;
            String var = "";
            var = e.KeyChar.ToString();
            if (var.Contains("1") || var.Contains("2") || var.Contains("3") || var.Contains("4") || var.Contains("5") || var.Contains("6") || var.Contains("7") || var.Contains("8") || var.Contains("9") || var.Contains("0"))
            {
                cadena += e.KeyChar;
                lblentrada.Text = cadena;
            }
            if (var.Equals(Keys.Enter))
            {
            }
            if (cadena.Length == 13)
            {
                lblentrada.Text = cadena;
                cadena = "";
            }
        }
        private void lblentrada_TextChanged(object sender, EventArgs e)
        {
            if (lblentrada.Text.Length == 13)
            {
                if (lblentrada.Text.Equals("0000000000000"))
                {
                    Application.Exit();


                    //MessageBox.Show("CERRAR APP");
                }
                else
                {
                    limpiar();
                    banner.Visible = false;
                    barras = lblentrada.Text;
                    ThreadStart delegado = new ThreadStart(escaner);
                    Thread hilo = new Thread(delegado);
                    hilo.Start();
                    hilo.Join();
                    lblnombre.Text = nombre;
                    lblprecio.Text = price;
                    lblexistencia.Text = existencia;
                    lblmayoreo.Text = mayoreo;
                    mostrarPromos();
                    lblpromocion.Text = precio.ToString("0.00");
                    if (precio <= 0)
                    {
                        lblmayorista.Text = (float.Parse(lblprecio.Text) * .85).ToString("0.00");
                    }
                    else
                    {
                        lblmayorista.Text = (precio * .85).ToString("0.00");
                    }
                    lbltotalsuma.Text = "" + (float.Parse(lbltotalsuma.Text) + float.Parse(lblpromocion.Text));
                    barras = "";
                    ThreadStart delegado2 = new ThreadStart(esperar);
                    Thread hilo2 = new Thread(delegado2);
                    hilo2.Start();
                }
            }
        }
        public void esperar()
        {
            Thread.Sleep(30000);
            banner.Invoke((Action)(() => banner.Visible = true));
        }
        public void escaner()
        {
            Buscar();
            sacarPromociones();
        }
        private void Buscar()
        {
            //MessageBox.Show("Buscando");
            db.Consulta("select isnull(t0.ItemName,'No se encontro') , round(Price*1.16,2) as Price , t2.OnHand, round((Price*1.16)*.85,2) from oitm t0 " +
                                        "inner join ITM1 t1 on t0.ItemCode = t1.ItemCode and t1.pricelist = 5 " +
                                        "inner join OITW t2 on t0.ItemCode = t2.ItemCode and t2.whscode = '2011' " +
                                        "where CodeBars = '" + barras + "'");
            while (db.Dr.Read())
            {
                nombre = db.Dr.GetString(0);
                price = db.Dr.GetDecimal(1).ToString("0.00");
                existencia = Math.Round(db.Dr.GetDecimal(2)).ToString("0");
                mayoreo = db.Dr.GetDecimal(3).ToString("0.00");
            }
            precio = float.Parse(price.Replace("$", "")); ;
        }



        public void sacarPromociones()
        {
            db.consultar("select * from [@SO1_01PROMOCION] where U_SO1_PROMOCION in (" +
                "select U_SO1_PROMOCION from [@SO1_01PROMOARTICULO] t0 " +
                "inner join OITM t1 on t0.U_SO1_ARTICULO = t1.ItemCode " +
                "where t1.CodeBars = '" + barras + "' " +
                "and U_SO1_PROMOCION in (select t0.U_SO1_PROMOCION from SO1_VI_01PROMOCIONACTIVA t0 " +
                "inner join [@SO1_01PROMOSUCURSAL] t1 on t0.U_SO1_PROMOCION = t1.U_SO1_PROMOCION " +
                "where t1.U_SO1_SUCURSAL = (select Code from [@SO1_01SUCURSAL])) " +
                "union " +
                "select t0.U_SO1_PROMOCION from [@SO1_01PROMOARTIGRUP] t0 " +
                "inner join OITM t1 on t0.U_SO1_GRUPO = t1.ItmsGrpCod " +
                "where t1.CodeBars = '" + barras + "'  and t0.U_SO1_ACTIVO = 'Y' " +
                "and U_SO1_PROMOCION in (select t0.U_SO1_PROMOCION from SO1_VI_01PROMOCIONACTIVA t0 " +
                "inner join [@SO1_01PROMOSUCURSAL] t1 on t0.U_SO1_PROMOCION = t1.U_SO1_PROMOCION " +
                "where t1.U_SO1_SUCURSAL = (select Code from [@SO1_01SUCURSAL]))) and U_SO1_FILTRARPROMALI = 'N'" +
                "order by U_SO1_JERARQUIA desc");
            while (db.Dr.Read())
            {
                ltipo.Add(db.Dr.GetString(4));
                lpromo.Add("" + db.Dr.GetSqlValue(2));
                laplica.Add(db.Dr.GetString(69));
            }
            for (int i = 0; i < ltipo.Count(); i++)
            {
                if (ltipo[i].Equals("AB"))
                {
                    if (laplica[i].Equals("Y"))
                    {
                        SqlDataReader resultadoAXB = db.consultar("select * from [@SO1_01PROMOAXB] where U_SO1_PROMOCION = " + lpromo[i]);

                        while (resultadoAXB.Read())
                        {
                            promociones = promociones + "Paga " + resultadoAXB.GetDecimal(5) + " y llevate " + Math.Round(resultadoAXB.GetDecimal(4)) + "\n";
                        }
                    }
                    else if (laplica[i].Equals("N") || ltipo[1 + 1].Equals("AB"))
                    {
                        SqlDataReader resultadoAXBna = db.consultar("select * from [@SO1_01PROMOAXB] where U_SO1_PROMOCION = " + lpromo[i]);
                        if (resultadoAXBna != null)
                        {
                            while (resultadoAXBna.Read())
                            {
                                promociones = promociones + "Paga " + resultadoAXBna.GetFloat(5) + " y llévate " + Math.Round(resultadoAXBna.GetFloat(4)) + "\n";
                            }
                        }
                        return;
                    }
                }
                if (ltipo[i].Equals("DX"))
                {
                    if (laplica[i].Equals("N") || ltipo.Count() == 1 || ltipo[i + 1].Equals("DX"))
                    {
                        SqlDataReader resultadoDX = db.consultar("select * from [@SO1_01PROMODESPOR] where U_SO1_PROMOCION = " + lpromo[i]);
                        if (resultadoDX != null)
                        {
                            while (resultadoDX.Read())
                            {
                                precio = precio * (1 - ((float)resultadoDX.GetDecimal(4) / 100));
                                promociones = promociones + Math.Round(resultadoDX.GetDecimal(4)) + "% de descuento " + "\n";
                            }
                        }
                        //mostrarPromos();
                        return;
                    }
                    else if (laplica[i].Equals("Y"))
                    {
                        SqlDataReader resultadoDX = db.consultar("select * from [@SO1_01PROMODESPOR] where U_SO1_PROMOCION = " + lpromo[i]);
                        while (resultadoDX.Read())
                        {
                            precio = precio * (1 - ((float)resultadoDX.GetDecimal(4) / 100));
                            promociones = promociones + Math.Round(resultadoDX.GetDecimal(4)) + "% de descuento " + "\n";
                        }
                    }
                }
                if (ltipo[i].Equals("PU"))
                {
                    if (laplica[i].Equals("Y"))
                    {
                        SqlDataReader resultadoPU = db.consultar("select * from [@SO1_01PROMOPREUNI] where U_SO1_PROMOCION = " + lpromo[i]);
                        if (resultadoPU != null)
                        {
                            while (resultadoPU.Read())
                            {
                                precio = (float)resultadoPU.GetDecimal(5);
                                promociones = promociones + "Promoción de precio unico\n";
                            }
                        }
                        else if (laplica[i].Equals("N"))
                        {
                            SqlDataReader resultadoPUna = db.consultar("select * from [@SO1_01PROMOPREUNI] where U_SO1_PROMOCION = " + lpromo[i]);
                            if (resultadoPUna != null)
                            {
                                while (resultadoPUna.Read())
                                {
                                    precio = (float)resultadoPUna.GetDecimal(5);
                                    promociones = promociones + " Promoción de precio unico\n";
                                }
                            }
                            //txtapromos.Text = promociones + "$" + dosdec(String.valueOf(decimal.format(precio))) + " Total";
                            return;
                        }
                    }
                }
                if (ltipo[i].Equals("DV"))
                {
                    float precioprov = precio;
                    if (laplica[i].Equals("Y"))
                    {
                        SqlDataReader resultadoDV = db.consultar("select * from [@SO1_01PROMODESVOLES] where U_SO1_PROMOCION = " + lpromo[i]);
                        if (resultadoDV != null)
                        {
                            while (resultadoDV.Read())
                            {
                                promociones = promociones + "Si te llevas " + Math.Round(resultadoDV.GetDecimal(4))
                                    + " obtén el " + Math.Round(resultadoDV.GetDecimal(5)) + "%";
                                if (resultadoDV.GetDecimal(4) == 1)
                                {
                                    precio = precio - ((precioprov * (float)resultadoDV.GetDecimal(4)) * (float)resultadoDV.GetDecimal(5)) / 100;
                                }
                            }
                        }
                    }
                    else if (ltipo[i].Equals("N"))
                    {
                        SqlDataReader resultadoDVna = db.consultar("select * from [@SO1_01PROMOAXB] where U_SO1_PROMOCION = " + lpromo[i]);
                        if (resultadoDVna != null)
                        {
                            while (resultadoDVna.Read())
                            {
                                promociones = promociones + "Si te llevas " + resultadoDVna.GetDecimal(4) + " obtén el " + resultadoDVna.GetDecimal(5) + "%\n";
                                if (resultadoDVna.GetDecimal(4) == 1)
                                {
                                    precio = precio - ((precioprov * (float)resultadoDVna.GetDecimal(4)) * (float)resultadoDVna.GetDecimal(5)) / 100;
                                }
                            }
                        }
                        return;
                    }
                }
            }
        }
        public void mostrarPromos()
        {
            if (barras.Equals(""))
            {
            }
            else
            {
                lblpromosapl.Text = promociones;
                if (promociones.Equals(""))
                {
                    if (lblpromocion.Text.Equals(lblprecio.Text))
                    {
                        lblpromocion.Text = "";
                        lblmayoreo.Text = "";
                    }
                }
                else
                {
                }
                if (float.Parse((lblprecio.Text.ToString().Replace("$", "")).Replace(",", "")) - precio <= 0.9)
                {
                }
                else
                {
                }
            }
        }
        public void limpiar()
        {
            lblnombre.Text = "";
            lblprecio.Text = "";
            lblpromocion.Text = "";
            lblmayoreo.Text = "";
            lblmayorista.Text = "";
            lblpromosapl.Text = "";
            promociones = "";
            ltipo.Clear();
            lpromo.Clear();
            laplica.Clear();
        }
        private void lblnombre_TextChanged(object sender, EventArgs e)
        {
        }
        private void lblpromocion_TextChanged(object sender, EventArgs e)
        {
        }
        private void chsumar_Click(object sender, EventArgs e)
        {
            if (chsumar.Checked == true)
            {
                lbltotalsuma.Text = lblpromocion.Text;
                lbltotalsuma.Visible = true;
                label8.Visible = true;
            }
            else
            {
                lbltotalsuma.Text = "0";
                lbltotalsuma.Visible = false;
                label8.Visible = false;
            }
        }

        private void chsumar_KeyPress(object sender, KeyPressEventArgs e)
        {
            String var = "";
            var = e.KeyChar.ToString();
            if (var.Contains("1") || var.Contains("2") || var.Contains("3") || var.Contains("4") || var.Contains("5") || var.Contains("6") || var.Contains("7") || var.Contains("8") || var.Contains("9") || var.Contains("0"))
            {
                cadena += e.KeyChar;
                lblentrada.Text = cadena;
            }
            if (var.Equals(Keys.Enter))
            {
            }
            if (cadena.Length == 13)
            {
                lblentrada.Text = cadena;
                cadena = "";
            }
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }

        private void chsumar_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void label9_ParentChanged(object sender, EventArgs e)
        {

        }

        private void lblnombre_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}