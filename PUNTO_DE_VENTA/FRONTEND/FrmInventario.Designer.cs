
namespace PUNTO_DE_VENTA
{
    partial class FrmInventario
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
            this.dtg_stock = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btn_codigo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btn_nombre = new System.Windows.Forms.Button();
            this.btn_todo = new System.Windows.Forms.Button();
            this.pnInventario = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnInventario.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_stock
            // 
            this.dtg_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_stock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.dtg_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_stock.Location = new System.Drawing.Point(16, 199);
            this.dtg_stock.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_stock.MultiSelect = false;
            this.dtg_stock.Name = "dtg_stock";
            this.dtg_stock.ReadOnly = true;
            this.dtg_stock.RowHeadersWidth = 51;
            this.dtg_stock.Size = new System.Drawing.Size(1243, 341);
            this.dtg_stock.TabIndex = 0;
            this.dtg_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_stock_CellClick);
            this.dtg_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_stock_CellContentClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Green;
            this.txtCodigo.Location = new System.Drawing.Point(0, 52);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(339, 34);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "BUSCAR POR CODIGO";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // btn_codigo
            // 
            this.btn_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_codigo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_codigo.ForeColor = System.Drawing.Color.White;
            this.btn_codigo.Location = new System.Drawing.Point(61, 112);
            this.btn_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_codigo.Name = "btn_codigo";
            this.btn_codigo.Size = new System.Drawing.Size(229, 39);
            this.btn_codigo.TabIndex = 2;
            this.btn_codigo.Text = "BUSCAR";
            this.btn_codigo.UseVisualStyleBackColor = false;
            this.btn_codigo.Click += new System.EventHandler(this.btn_codigo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btn_codigo);
            this.panel1.Location = new System.Drawing.Point(80, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 155);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.btn_nombre);
            this.panel2.Location = new System.Drawing.Point(444, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 155);
            this.panel2.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.Green;
            this.txtNombre.Location = new System.Drawing.Point(0, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(339, 34);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "BUSCAR POR NOMBRE";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // btn_nombre
            // 
            this.btn_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_nombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nombre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_nombre.ForeColor = System.Drawing.Color.White;
            this.btn_nombre.Location = new System.Drawing.Point(60, 112);
            this.btn_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nombre.Name = "btn_nombre";
            this.btn_nombre.Size = new System.Drawing.Size(229, 39);
            this.btn_nombre.TabIndex = 2;
            this.btn_nombre.Text = "BUSCAR";
            this.btn_nombre.UseVisualStyleBackColor = false;
            this.btn_nombre.Click += new System.EventHandler(this.btn_nombre_Click);
            // 
            // btn_todo
            // 
            this.btn_todo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_todo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_todo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_todo.ForeColor = System.Drawing.Color.White;
            this.btn_todo.Location = new System.Drawing.Point(14, 18);
            this.btn_todo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_todo.Name = "btn_todo";
            this.btn_todo.Size = new System.Drawing.Size(329, 60);
            this.btn_todo.TabIndex = 6;
            this.btn_todo.Text = "MOSTRAR TODO";
            this.btn_todo.UseVisualStyleBackColor = false;
            this.btn_todo.Click += new System.EventHandler(this.btn_todo_Click);
            // 
            // pnInventario
            // 
            this.pnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.pnInventario.Controls.Add(this.panel4);
            this.pnInventario.Controls.Add(this.panel1);
            this.pnInventario.Controls.Add(this.dtg_stock);
            this.pnInventario.Controls.Add(this.panel2);
            this.pnInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInventario.Location = new System.Drawing.Point(0, 0);
            this.pnInventario.Margin = new System.Windows.Forms.Padding(4);
            this.pnInventario.Name = "pnInventario";
            this.pnInventario.Size = new System.Drawing.Size(1312, 604);
            this.pnInventario.TabIndex = 7;
            this.pnInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnInventario_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_agregar);
            this.panel4.Controls.Add(this.btn_todo);
            this.panel4.Location = new System.Drawing.Point(898, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 173);
            this.panel4.TabIndex = 12;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(14, 114);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(329, 55);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 604);
            this.Controls.Add(this.pnInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnInventario.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_stock;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btn_codigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btn_nombre;
        private System.Windows.Forms.Button btn_todo;
        private System.Windows.Forms.Panel pnInventario;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Panel panel4;
    }
}