namespace AppProyectoLista
{
    partial class Productos_de_venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombredelProducto = new System.Windows.Forms.TextBox();
            this.txtPreciodeVenta = new System.Windows.Forms.TextBox();
            this.txtFechadeCompra = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listViewProductos = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PreciodeVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechadeCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unidades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "P. de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unidades";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 60);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombredelProducto
            // 
            this.txtNombredelProducto.Location = new System.Drawing.Point(124, 60);
            this.txtNombredelProducto.Name = "txtNombredelProducto";
            this.txtNombredelProducto.Size = new System.Drawing.Size(154, 20);
            this.txtNombredelProducto.TabIndex = 6;
            // 
            // txtPreciodeVenta
            // 
            this.txtPreciodeVenta.Location = new System.Drawing.Point(313, 60);
            this.txtPreciodeVenta.Name = "txtPreciodeVenta";
            this.txtPreciodeVenta.Size = new System.Drawing.Size(96, 20);
            this.txtPreciodeVenta.TabIndex = 7;
            // 
            // txtFechadeCompra
            // 
            this.txtFechadeCompra.Location = new System.Drawing.Point(445, 60);
            this.txtFechadeCompra.Name = "txtFechadeCompra";
            this.txtFechadeCompra.Size = new System.Drawing.Size(111, 20);
            this.txtFechadeCompra.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 40);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listViewProductos
            // 
            this.listViewProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.NombreProducto,
            this.PreciodeVenta,
            this.FechadeCompra,
            this.Unidades});
            this.listViewProductos.HideSelection = false;
            this.listViewProductos.Location = new System.Drawing.Point(132, 127);
            this.listViewProductos.Name = "listViewProductos";
            this.listViewProductos.Size = new System.Drawing.Size(562, 249);
            this.listViewProductos.TabIndex = 11;
            this.listViewProductos.UseCompatibleStateImageBehavior = false;
            this.listViewProductos.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 85;
            // 
            // NombreProducto
            // 
            this.NombreProducto.Text = "Nombre del producto";
            this.NombreProducto.Width = 142;
            // 
            // PreciodeVenta
            // 
            this.PreciodeVenta.Text = "P. de venta";
            this.PreciodeVenta.Width = 116;
            // 
            // FechadeCompra
            // 
            this.FechadeCompra.Text = "Fecha de compra";
            this.FechadeCompra.Width = 130;
            // 
            // Unidades
            // 
            this.Unidades.Text = "Unidades";
            this.Unidades.Width = 84;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(596, 60);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(98, 20);
            this.txtUnidades.TabIndex = 12;
            // 
            // Productos_de_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 409);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.listViewProductos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFechadeCompra);
            this.Controls.Add(this.txtPreciodeVenta);
            this.Controls.Add(this.txtNombredelProducto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Productos_de_venta";
            this.Text = "Productos_de_venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombredelProducto;
        private System.Windows.Forms.TextBox txtPreciodeVenta;
        private System.Windows.Forms.TextBox txtFechadeCompra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listViewProductos;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader NombreProducto;
        private System.Windows.Forms.ColumnHeader PreciodeVenta;
        private System.Windows.Forms.ColumnHeader FechadeCompra;
        private System.Windows.Forms.ColumnHeader Unidades;
        private System.Windows.Forms.TextBox txtUnidades;
    }
}