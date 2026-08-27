namespace pryED_CapelloBruno
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbListado = new System.Windows.Forms.ListBox();
            this.gbEliminarElemento = new System.Windows.Forms.GroupBox();
            this.lblMuestraTramite = new System.Windows.Forms.Label();
            this.lblMuestraNombre = new System.Windows.Forms.Label();
            this.lblMuestraCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.picPila = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbEliminarElemento.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTramite});
            this.dgvListado.Location = new System.Drawing.Point(235, 18);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.Size = new System.Drawing.Size(448, 173);
            this.dgvListado.TabIndex = 16;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            // 
            // colTramite
            // 
            this.colTramite.HeaderText = "Trámite";
            this.colTramite.MinimumWidth = 6;
            this.colTramite.Name = "colTramite";
            // 
            // lbListado
            // 
            this.lbListado.FormattingEnabled = true;
            this.lbListado.Location = new System.Drawing.Point(6, 18);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(216, 173);
            this.lbListado.TabIndex = 15;
            // 
            // gbEliminarElemento
            // 
            this.gbEliminarElemento.BackColor = System.Drawing.Color.White;
            this.gbEliminarElemento.Controls.Add(this.lblMuestraTramite);
            this.gbEliminarElemento.Controls.Add(this.lblMuestraNombre);
            this.gbEliminarElemento.Controls.Add(this.lblMuestraCodigo);
            this.gbEliminarElemento.Controls.Add(this.btnEliminar);
            this.gbEliminarElemento.Controls.Add(this.lblTramiteEliminar);
            this.gbEliminarElemento.Controls.Add(this.lblNombreEliminar);
            this.gbEliminarElemento.Controls.Add(this.lblCodigoEliminar);
            this.gbEliminarElemento.Location = new System.Drawing.Point(498, 12);
            this.gbEliminarElemento.Name = "gbEliminarElemento";
            this.gbEliminarElemento.Size = new System.Drawing.Size(210, 157);
            this.gbEliminarElemento.TabIndex = 14;
            this.gbEliminarElemento.TabStop = false;
            this.gbEliminarElemento.Text = "Elemento a Eliminar";
            // 
            // lblMuestraTramite
            // 
            this.lblMuestraTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraTramite.Location = new System.Drawing.Point(73, 100);
            this.lblMuestraTramite.Name = "lblMuestraTramite";
            this.lblMuestraTramite.Size = new System.Drawing.Size(121, 21);
            this.lblMuestraTramite.TabIndex = 2;
            // 
            // lblMuestraNombre
            // 
            this.lblMuestraNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraNombre.Location = new System.Drawing.Point(73, 65);
            this.lblMuestraNombre.Name = "lblMuestraNombre";
            this.lblMuestraNombre.Size = new System.Drawing.Size(121, 21);
            this.lblMuestraNombre.TabIndex = 1;
            // 
            // lblMuestraCodigo
            // 
            this.lblMuestraCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraCodigo.Location = new System.Drawing.Point(73, 30);
            this.lblMuestraCodigo.Name = "lblMuestraCodigo";
            this.lblMuestraCodigo.Size = new System.Drawing.Size(121, 21);
            this.lblMuestraCodigo.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(73, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.AutoSize = true;
            this.lblTramiteEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteEliminar.Location = new System.Drawing.Point(15, 101);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(52, 15);
            this.lblTramiteEliminar.TabIndex = 7;
            this.lblTramiteEliminar.Text = "Trámite:";
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEliminar.Location = new System.Drawing.Point(15, 66);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(55, 15);
            this.lblNombreEliminar.TabIndex = 5;
            this.lblNombreEliminar.Text = "Nombre:";
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEliminar.Location = new System.Drawing.Point(15, 31);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(49, 15);
            this.lblCodigoEliminar.TabIndex = 3;
            this.lblCodigoEliminar.Text = "Código:";
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.BackColor = System.Drawing.Color.White;
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Location = new System.Drawing.Point(260, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(210, 157);
            this.gbNuevoElemento.TabIndex = 12;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(76, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(15, 101);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(52, 15);
            this.lblTramite.TabIndex = 7;
            this.lblTramite.Text = "Trámite:";
            // 
            // txtTramite
            // 
            this.txtTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(76, 98);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(121, 21);
            this.txtTramite.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(76, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(76, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.lbListado);
            this.gbListado.Location = new System.Drawing.Point(25, 182);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(694, 204);
            this.gbListado.TabIndex = 17;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listad en una Lista y una Grilla";
            // 
            // picPila
            // 
            this.picPila.Image = ((System.Drawing.Image)(resources.GetObject("picPila.Image")));
            this.picPila.Location = new System.Drawing.Point(25, 12);
            this.picPila.Name = "picPila";
            this.picPila.Size = new System.Drawing.Size(222, 157);
            this.picPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila.TabIndex = 18;
            this.picPila.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(731, 398);
            this.Controls.Add(this.picPila);
            this.Controls.Add(this.gbEliminarElemento);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.gbListado);
            this.Name = "frmPila";
            this.Text = "Estructura de datos lineal: Pila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbEliminarElemento.ResumeLayout(false);
            this.gbEliminarElemento.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
        private System.Windows.Forms.ListBox lbListado;
        private System.Windows.Forms.GroupBox gbEliminarElemento;
        private System.Windows.Forms.Label lblMuestraTramite;
        private System.Windows.Forms.Label lblMuestraNombre;
        private System.Windows.Forms.Label lblMuestraCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.PictureBox picPila;
    }
}