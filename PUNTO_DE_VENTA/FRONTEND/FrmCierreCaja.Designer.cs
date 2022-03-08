
namespace PUNTO_DE_VENTA.FRONTEND
{
    partial class FrmCierreCaja
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
            this.pnCierreCaja = new System.Windows.Forms.Panel();
            this.btn_ventas_dia = new System.Windows.Forms.Button();
            this.btn_cerrar_caja = new System.Windows.Forms.Button();
            this.lblSaldoReal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lblDineroAcumulado = new System.Windows.Forms.Label();
            this.pnCierreCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCierreCaja
            // 
            this.pnCierreCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.pnCierreCaja.Controls.Add(this.btn_ventas_dia);
            this.pnCierreCaja.Controls.Add(this.btn_cerrar_caja);
            this.pnCierreCaja.Controls.Add(this.lblSaldoReal);
            this.pnCierreCaja.Controls.Add(this.label4);
            this.pnCierreCaja.Controls.Add(this.txtSaldoInicial);
            this.pnCierreCaja.Controls.Add(this.label3);
            this.pnCierreCaja.Controls.Add(this.label2);
            this.pnCierreCaja.Controls.Add(this.btn_aceptar);
            this.pnCierreCaja.Controls.Add(this.lblDineroAcumulado);
            this.pnCierreCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCierreCaja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnCierreCaja.Location = new System.Drawing.Point(0, 0);
            this.pnCierreCaja.Name = "pnCierreCaja";
            this.pnCierreCaja.Size = new System.Drawing.Size(984, 491);
            this.pnCierreCaja.TabIndex = 0;
            this.pnCierreCaja.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCierreCaja_Paint);
            // 
            // btn_ventas_dia
            // 
            this.btn_ventas_dia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_ventas_dia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas_dia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_ventas_dia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas_dia.ForeColor = System.Drawing.Color.White;
            this.btn_ventas_dia.Location = new System.Drawing.Point(670, 409);
            this.btn_ventas_dia.Name = "btn_ventas_dia";
            this.btn_ventas_dia.Size = new System.Drawing.Size(160, 23);
            this.btn_ventas_dia.TabIndex = 8;
            this.btn_ventas_dia.Text = "VENTAS DEL DIA";
            this.btn_ventas_dia.UseVisualStyleBackColor = false;
            this.btn_ventas_dia.Click += new System.EventHandler(this.btn_ventas_dia_Click);
            // 
            // btn_cerrar_caja
            // 
            this.btn_cerrar_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_cerrar_caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_caja.Enabled = false;
            this.btn_cerrar_caja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_cerrar_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_caja.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar_caja.Location = new System.Drawing.Point(455, 409);
            this.btn_cerrar_caja.Name = "btn_cerrar_caja";
            this.btn_cerrar_caja.Size = new System.Drawing.Size(160, 23);
            this.btn_cerrar_caja.TabIndex = 7;
            this.btn_cerrar_caja.Text = "CERRAR CAJA";
            this.btn_cerrar_caja.UseVisualStyleBackColor = false;
            this.btn_cerrar_caja.Click += new System.EventHandler(this.btn_cerrar_caja_Click);
            // 
            // lblSaldoReal
            // 
            this.lblSaldoReal.AutoSize = true;
            this.lblSaldoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblSaldoReal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSaldoReal.Location = new System.Drawing.Point(380, 290);
            this.lblSaldoReal.Name = "lblSaldoReal";
            this.lblSaldoReal.Size = new System.Drawing.Size(35, 37);
            this.lblSaldoReal.TabIndex = 6;
            this.lblSaldoReal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saldo real:";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(334, 162);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(240, 20);
            this.txtSaldoInicial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DINERO ACUMULADO DURANTE ESTE TURNO: ";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(241, 409);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(160, 23);
            this.btn_aceptar.TabIndex = 1;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lblDineroAcumulado
            // 
            this.lblDineroAcumulado.AutoSize = true;
            this.lblDineroAcumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblDineroAcumulado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDineroAcumulado.Location = new System.Drawing.Point(367, 54);
            this.lblDineroAcumulado.Name = "lblDineroAcumulado";
            this.lblDineroAcumulado.Size = new System.Drawing.Size(36, 39);
            this.lblDineroAcumulado.TabIndex = 0;
            this.lblDineroAcumulado.Text = "0";
            this.lblDineroAcumulado.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 491);
            this.Controls.Add(this.pnCierreCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCierreCaja";
            this.Text = "FrmCierreCaja";
            this.pnCierreCaja.ResumeLayout(false);
            this.pnCierreCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCierreCaja;
        private System.Windows.Forms.Label lblDineroAcumulado;
        private System.Windows.Forms.Button btn_ventas_dia;
        private System.Windows.Forms.Button btn_cerrar_caja;
        private System.Windows.Forms.Label lblSaldoReal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aceptar;
    }
}