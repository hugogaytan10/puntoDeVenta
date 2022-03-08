
namespace PUNTO_DE_VENTA
{
    partial class Frm_Cajero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cajero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cierre_caja = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btn_ventas = new FontAwesome.Sharp.IconButton();
            this.btn_inventario = new FontAwesome.Sharp.IconButton();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_cierre_caja);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.btn_ventas);
            this.panel1.Controls.Add(this.btn_inventario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 814);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_cierre_caja
            // 
            this.btn_cierre_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.btn_cierre_caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cierre_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cierre_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_cierre_caja.ForeColor = System.Drawing.Color.Green;
            this.btn_cierre_caja.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btn_cierre_caja.IconColor = System.Drawing.Color.Green;
            this.btn_cierre_caja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cierre_caja.IconSize = 40;
            this.btn_cierre_caja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cierre_caja.Location = new System.Drawing.Point(4, 507);
            this.btn_cierre_caja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cierre_caja.Name = "btn_cierre_caja";
            this.btn_cierre_caja.Size = new System.Drawing.Size(276, 62);
            this.btn_cierre_caja.TabIndex = 5;
            this.btn_cierre_caja.Text = "Cierre de caja";
            this.btn_cierre_caja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cierre_caja.UseVisualStyleBackColor = false;
            this.btn_cierre_caja.Click += new System.EventHandler(this.btn_cierre_caja_Click);
            this.btn_cierre_caja.MouseLeave += new System.EventHandler(this.btn_cierre_caja_MouseLeave);
            this.btn_cierre_caja.MouseHover += new System.EventHandler(this.btn_cierre_caja_MouseHover);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.iconButton4.ForeColor = System.Drawing.Color.Green;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
            this.iconButton4.IconColor = System.Drawing.Color.Green;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 40;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(3, 100);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(277, 64);
            this.iconButton4.TabIndex = 1;
            this.iconButton4.Text = "Buscar Producto";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            this.iconButton4.MouseLeave += new System.EventHandler(this.iconButton4_MouseLeave);
            this.iconButton4.MouseHover += new System.EventHandler(this.iconButton4_MouseHover);
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_ventas.ForeColor = System.Drawing.Color.Green;
            this.btn_ventas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_ventas.IconColor = System.Drawing.Color.Green;
            this.btn_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ventas.IconSize = 40;
            this.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.Location = new System.Drawing.Point(5, 245);
            this.btn_ventas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(275, 62);
            this.btn_ventas.TabIndex = 2;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.iconButton2_Click);
            this.btn_ventas.MouseLeave += new System.EventHandler(this.btn_ventas_MouseLeave);
            this.btn_ventas.MouseHover += new System.EventHandler(this.btn_ventas_MouseHover);
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.btn_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_inventario.ForeColor = System.Drawing.Color.Green;
            this.btn_inventario.IconChar = FontAwesome.Sharp.IconChar.GripVertical;
            this.btn_inventario.IconColor = System.Drawing.Color.Green;
            this.btn_inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_inventario.IconSize = 40;
            this.btn_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventario.Location = new System.Drawing.Point(3, 378);
            this.btn_inventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(277, 62);
            this.btn_inventario.TabIndex = 3;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            this.btn_inventario.MouseLeave += new System.EventHandler(this.btn_inventario_MouseLeave);
            this.btn_inventario.MouseHover += new System.EventHandler(this.btn_inventario_MouseHover);
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.pnContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(281, 0);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(1319, 814);
            this.pnContenedor.TabIndex = 5;
            this.pnContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Frm_Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1600, 814);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Cajero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Cajero_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Frm_Cajero_MouseClick);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_ventas;
        private FontAwesome.Sharp.IconButton btn_inventario;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel pnContenedor;
        private FontAwesome.Sharp.IconButton btn_cierre_caja;
    }
}

