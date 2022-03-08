
namespace PUNTO_DE_VENTA
{
    partial class FrmBuscarProducto
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOp2 = new System.Windows.Forms.RadioButton();
            this.rbOp1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Green;
            this.txtCodigo.Location = new System.Drawing.Point(0, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "CODIGO";
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(32)))));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(46, 139);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(200, 35);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(589, 162);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombre.ForeColor = System.Drawing.Color.Green;
            this.txtNombre.Location = new System.Drawing.Point(367, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 21);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOp2);
            this.panel1.Controls.Add(this.rbOp1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Location = new System.Drawing.Point(46, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 110);
            this.panel1.TabIndex = 6;
            // 
            // rbOp2
            // 
            this.rbOp2.AutoSize = true;
            this.rbOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbOp2.ForeColor = System.Drawing.Color.White;
            this.rbOp2.Location = new System.Drawing.Point(367, 19);
            this.rbOp2.Name = "rbOp2";
            this.rbOp2.Size = new System.Drawing.Size(180, 21);
            this.rbOp2.TabIndex = 6;
            this.rbOp2.Text = "BUSCAR POR NOMBRE";
            this.rbOp2.UseVisualStyleBackColor = true;
            this.rbOp2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbOp1
            // 
            this.rbOp1.AutoSize = true;
            this.rbOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbOp1.ForeColor = System.Drawing.Color.White;
            this.rbOp1.Location = new System.Drawing.Point(0, 19);
            this.rbOp1.Name = "rbOp1";
            this.rbOp1.Size = new System.Drawing.Size(175, 21);
            this.rbOp1.TabIndex = 3;
            this.rbOp1.TabStop = true;
            this.rbOp1.Text = "BUSCAR POR CODIGO";
            this.rbOp1.UseVisualStyleBackColor = true;
            this.rbOp1.CheckedChanged += new System.EventHandler(this.rbOp1_CheckedChanged);
            // 
            // FrmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR PRODUCTO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOp2;
        private System.Windows.Forms.RadioButton rbOp1;
    }
}