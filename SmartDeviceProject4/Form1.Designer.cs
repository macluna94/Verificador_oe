namespace SmartDeviceProject4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagenFondo = new System.Windows.Forms.PictureBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblentrada = new System.Windows.Forms.Label();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblpromocion = new System.Windows.Forms.Label();
            this.lblmayoreo = new System.Windows.Forms.Label();
            this.lblmayorista = new System.Windows.Forms.Label();
            this.lblpromosapl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.banner = new System.Windows.Forms.PictureBox();
            this.chsumar = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltotalsuma = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imagenFondo
            // 
            this.imagenFondo.Location = new System.Drawing.Point(0, 0);
            this.imagenFondo.Name = "imagenFondo";
            this.imagenFondo.Size = new System.Drawing.Size(100, 50);
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombre.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblnombre.Location = new System.Drawing.Point(10, 133);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(755, 62);
            this.lblnombre.Text = "Nombre";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblnombre.TextChanged += new System.EventHandler(this.lblnombre_TextChanged);
            this.lblnombre.ParentChanged += new System.EventHandler(this.lblnombre_ParentChanged);
            // 
            // lblentrada
            // 
            this.lblentrada.ForeColor = System.Drawing.Color.Black;
            this.lblentrada.Location = new System.Drawing.Point(6, 158);
            this.lblentrada.Name = "lblentrada";
            this.lblentrada.Size = new System.Drawing.Size(774, 37);
            this.lblentrada.Text = "entrada";
            this.lblentrada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblentrada.TextChanged += new System.EventHandler(this.lblentrada_TextChanged);
            // 
            // lblexistencia
            // 
            this.lblexistencia.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblexistencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblexistencia.Location = new System.Drawing.Point(714, 360);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(28, 22);
            this.lblexistencia.Text = "0";
            this.lblexistencia.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(604, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.Text = "Existencia";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(292, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.Text = "Precio Normal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(227, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 30);
            this.label3.Text = "Precio con Descuento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(17, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.Text = "Mayorista descuento";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(604, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 11);
            this.label5.Text = "Mayorista";
            this.label5.Visible = false;
            // 
            // lblprecio
            // 
            this.lblprecio.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.lblprecio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblprecio.Location = new System.Drawing.Point(292, 246);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(187, 30);
            this.lblprecio.Text = "0";
            this.lblprecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblpromocion
            // 
            this.lblpromocion.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.lblpromocion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblpromocion.Location = new System.Drawing.Point(292, 333);
            this.lblpromocion.Name = "lblpromocion";
            this.lblpromocion.Size = new System.Drawing.Size(187, 38);
            this.lblpromocion.Text = "0";
            this.lblpromocion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblpromocion.TextChanged += new System.EventHandler(this.lblpromocion_TextChanged);
            // 
            // lblmayoreo
            // 
            this.lblmayoreo.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.lblmayoreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmayoreo.Location = new System.Drawing.Point(171, 405);
            this.lblmayoreo.Name = "lblmayoreo";
            this.lblmayoreo.Size = new System.Drawing.Size(31, 30);
            this.lblmayoreo.Text = "0";
            this.lblmayoreo.Visible = false;
            // 
            // lblmayorista
            // 
            this.lblmayorista.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblmayorista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmayorista.Location = new System.Drawing.Point(123, 414);
            this.lblmayorista.Name = "lblmayorista";
            this.lblmayorista.Size = new System.Drawing.Size(42, 20);
            this.lblmayorista.Text = "0";
            this.lblmayorista.Visible = false;
            // 
            // lblpromosapl
            // 
            this.lblpromosapl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblpromosapl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpromosapl.Location = new System.Drawing.Point(158, 395);
            this.lblpromosapl.Name = "lblpromosapl";
            this.lblpromosapl.Size = new System.Drawing.Size(458, 36);
            this.lblpromosapl.Text = "Promociones\r\n1\r\n2\r\n3\r\n";
            this.lblpromosapl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblpromosapl.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(337, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 2);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(533, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 2);
            this.label7.Visible = false;
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(100, 50);
            // 
            // chsumar
            // 
            this.chsumar.AutoCheck = false;
            this.chsumar.Enabled = false;
            this.chsumar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chsumar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chsumar.Location = new System.Drawing.Point(51, 390);
            this.chsumar.Name = "chsumar";
            this.chsumar.Size = new System.Drawing.Size(100, 65);
            this.chsumar.TabIndex = 17;
            this.chsumar.Text = "Sumar";
            this.chsumar.Visible = false;
            this.chsumar.CheckStateChanged += new System.EventHandler(this.chsumar_CheckStateChanged);
            this.chsumar.Click += new System.EventHandler(this.chsumar_Click);
            this.chsumar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chsumar_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(604, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.Text = "Total de suma";
            this.label8.Visible = false;
            // 
            // lbltotalsuma
            // 
            this.lbltotalsuma.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.lbltotalsuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltotalsuma.Location = new System.Drawing.Point(714, 405);
            this.lbltotalsuma.Name = "lbltotalsuma";
            this.lbltotalsuma.Size = new System.Drawing.Size(40, 30);
            this.lbltotalsuma.Text = "0";
            this.lbltotalsuma.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(0, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(788, 111);
            this.label9.Text = "OE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.ParentChanged += new System.EventHandler(this.label9_ParentChanged);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(7, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(774, 128);
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 525);
            this.ControlBox = false;
            this.Controls.Add(this.lblentrada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblpromocion);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.lbltotalsuma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpromosapl);
            this.Controls.Add(this.lblmayorista);
            this.Controls.Add(this.lblmayoreo);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblexistencia);
            this.Controls.Add(this.imagenFondo);
            this.Controls.Add(this.chsumar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenFondo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblentrada;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblpromocion;
        private System.Windows.Forms.Label lblmayoreo;
        private System.Windows.Forms.Label lblmayorista;
        private System.Windows.Forms.Label lblpromosapl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.CheckBox chsumar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltotalsuma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}