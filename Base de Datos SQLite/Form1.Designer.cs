namespace Base_de_Datos_SQLite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblNombre = new Label();
            lblId = new Label();
            btnInsertar = new Button();
            btbActualizar = new Button();
            btnEliminar = new Button();
            dgvdatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 37);
            label1.Name = "label1";
            label1.Size = new Size(214, 22);
            label1.TabIndex = 0;
            label1.Text = "Base de Datos en SQLite";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(99, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(99, 142);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 111);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(72, 150);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 4;
            lblId.Text = "ID:";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(118, 227);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btbActualizar
            // 
            btbActualizar.Location = new Point(118, 292);
            btbActualizar.Name = "btbActualizar";
            btbActualizar.Size = new Size(75, 23);
            btbActualizar.TabIndex = 6;
            btbActualizar.Text = "Actualizar";
            btbActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(118, 354);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvdatos
            // 
            dgvdatos.BackgroundColor = Color.White;
            dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, ID });
            dgvdatos.Location = new Point(205, 103);
            dgvdatos.Name = "dgvdatos";
            dgvdatos.Size = new Size(486, 274);
            dgvdatos.TabIndex = 8;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 393);
            Controls.Add(dgvdatos);
            Controls.Add(btnEliminar);
            Controls.Add(btbActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblId);
            Controls.Add(lblNombre);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblNombre;
        private Label lblId;
        private Button btnInsertar;
        private Button btbActualizar;
        private Button btnEliminar;
        private DataGridView dgvdatos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ID;
    }
}
