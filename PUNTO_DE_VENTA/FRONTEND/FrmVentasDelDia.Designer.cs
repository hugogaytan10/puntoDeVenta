
namespace PUNTO_DE_VENTA.FRONTEND
{
    partial class FrmVentasDelDia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMontoDelDia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lbMontoDelDia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAceptar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbMontoDelDia
            // 
            this.lbMontoDelDia.AutoSize = true;
            this.lbMontoDelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbMontoDelDia.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbMontoDelDia.Location = new System.Drawing.Point(234, 382);
            this.lbMontoDelDia.Name = "lbMontoDelDia";
            this.lbMontoDelDia.Size = new System.Drawing.Size(20, 24);
            this.lbMontoDelDia.TabIndex = 3;
            this.lbMontoDelDia.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL DEL DIA:";
            // 
            // txtAceptar
            // 
            this.txtAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.txtAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.txtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAceptar.ForeColor = System.Drawing.Color.White;
            this.txtAceptar.Location = new System.Drawing.Point(477, 383);
            this.txtAceptar.Name = "txtAceptar";
            this.txtAceptar.Size = new System.Drawing.Size(210, 23);
            this.txtAceptar.TabIndex = 1;
            this.txtAceptar.Text = "ACEPTAR";
            this.txtAceptar.UseVisualStyleBackColor = false;
            this.txtAceptar.Click += new System.EventHandler(this.txtAceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmVentasDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVentasDelDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS DEL DIA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtAceptar;
        private System.Windows.Forms.Label lbMontoDelDia;
        private System.Windows.Forms.Label label2;
    }
}