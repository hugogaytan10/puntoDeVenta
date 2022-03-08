
namespace PUNTO_DE_VENTA.FRONTEND
{
    partial class FrmCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCobro));
            this.pnCobro = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCobrar = new System.Windows.Forms.Label();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb100 = new System.Windows.Forms.PictureBox();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.pb50 = new System.Windows.Forms.PictureBox();
            this.pb200 = new System.Windows.Forms.PictureBox();
            this.pb1000 = new System.Windows.Forms.PictureBox();
            this.pb500 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pnCobro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCobro
            // 
            this.pnCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.pnCobro.Controls.Add(this.pb10);
            this.pnCobro.Controls.Add(this.pb5);
            this.pnCobro.Controls.Add(this.pb2);
            this.pnCobro.Controls.Add(this.pb1);
            this.pnCobro.Controls.Add(this.pb500);
            this.pnCobro.Controls.Add(this.pb1000);
            this.pnCobro.Controls.Add(this.pb200);
            this.pnCobro.Controls.Add(this.pb50);
            this.pnCobro.Controls.Add(this.pb20);
            this.pnCobro.Controls.Add(this.pb100);
            this.pnCobro.Controls.Add(this.dataGridView1);
            this.pnCobro.Controls.Add(this.button1);
            this.pnCobro.Controls.Add(this.lblCobrar);
            this.pnCobro.Controls.Add(this.txtRecibido);
            this.pnCobro.Controls.Add(this.label2);
            this.pnCobro.Controls.Add(this.label1);
            this.pnCobro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCobro.Location = new System.Drawing.Point(0, 0);
            this.pnCobro.Name = "pnCobro";
            this.pnCobro.Size = new System.Drawing.Size(339, 450);
            this.pnCobro.TabIndex = 0;
            this.pnCobro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCobro_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreProducto,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(0, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(33, 30);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "NombreProducto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(90, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "COBRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCobrar
            // 
            this.lblCobrar.AutoSize = true;
            this.lblCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.lblCobrar.Location = new System.Drawing.Point(267, 29);
            this.lblCobrar.Name = "lblCobrar";
            this.lblCobrar.Size = new System.Drawing.Size(23, 25);
            this.lblCobrar.TabIndex = 4;
            this.lblCobrar.Text = "0";
            // 
            // txtRecibido
            // 
            this.txtRecibido.Location = new System.Drawing.Point(196, 291);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(128, 20);
            this.txtRecibido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(11, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "DINERO RECIBIDO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL A COBRAR:";
            // 
            // pb100
            // 
            this.pb100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb100.Image = ((System.Drawing.Image)(resources.GetObject("pb100.Image")));
            this.pb100.Location = new System.Drawing.Point(12, 134);
            this.pb100.Name = "pb100";
            this.pb100.Size = new System.Drawing.Size(100, 50);
            this.pb100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb100.TabIndex = 7;
            this.pb100.TabStop = false;
            this.pb100.Click += new System.EventHandler(this.pb100_Click);
            // 
            // pb20
            // 
            this.pb20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb20.Image = ((System.Drawing.Image)(resources.GetObject("pb20.Image")));
            this.pb20.Location = new System.Drawing.Point(12, 69);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(100, 50);
            this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb20.TabIndex = 8;
            this.pb20.TabStop = false;
            this.pb20.Click += new System.EventHandler(this.pb20_Click);
            // 
            // pb50
            // 
            this.pb50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb50.Image = ((System.Drawing.Image)(resources.GetObject("pb50.Image")));
            this.pb50.Location = new System.Drawing.Point(118, 69);
            this.pb50.Name = "pb50";
            this.pb50.Size = new System.Drawing.Size(100, 50);
            this.pb50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb50.TabIndex = 9;
            this.pb50.TabStop = false;
            this.pb50.Click += new System.EventHandler(this.pb50_Click);
            // 
            // pb200
            // 
            this.pb200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb200.Image = ((System.Drawing.Image)(resources.GetObject("pb200.Image")));
            this.pb200.Location = new System.Drawing.Point(118, 134);
            this.pb200.Name = "pb200";
            this.pb200.Size = new System.Drawing.Size(100, 50);
            this.pb200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb200.TabIndex = 10;
            this.pb200.TabStop = false;
            this.pb200.Click += new System.EventHandler(this.pb200_Click);
            // 
            // pb1000
            // 
            this.pb1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1000.Image = ((System.Drawing.Image)(resources.GetObject("pb1000.Image")));
            this.pb1000.Location = new System.Drawing.Point(224, 134);
            this.pb1000.Name = "pb1000";
            this.pb1000.Size = new System.Drawing.Size(100, 50);
            this.pb1000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1000.TabIndex = 11;
            this.pb1000.TabStop = false;
            this.pb1000.Click += new System.EventHandler(this.pb1000_Click);
            // 
            // pb500
            // 
            this.pb500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb500.Image = ((System.Drawing.Image)(resources.GetObject("pb500.Image")));
            this.pb500.Location = new System.Drawing.Point(224, 69);
            this.pb500.Name = "pb500";
            this.pb500.Size = new System.Drawing.Size(100, 50);
            this.pb500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb500.TabIndex = 12;
            this.pb500.TabStop = false;
            this.pb500.Click += new System.EventHandler(this.pb500_Click);
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(12, 200);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 50);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 13;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(90, 200);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 50);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 14;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb5
            // 
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(170, 200);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(100, 50);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 15;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb10
            // 
            this.pb10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb10.Image = ((System.Drawing.Image)(resources.GetObject("pb10.Image")));
            this.pb10.Location = new System.Drawing.Point(248, 200);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(100, 50);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb10.TabIndex = 16;
            this.pb10.TabStop = false;
            this.pb10.Click += new System.EventHandler(this.pb10_Click);
            // 
            // FrmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.pnCobro);
            this.Name = "FrmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COBRO";
            this.pnCobro.ResumeLayout(false);
            this.pnCobro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCobro;
        private System.Windows.Forms.Label lblCobrar;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb500;
        private System.Windows.Forms.PictureBox pb1000;
        private System.Windows.Forms.PictureBox pb200;
        private System.Windows.Forms.PictureBox pb50;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.PictureBox pb100;
    }
}