namespace Gestion_de_empleados_
{
    partial class FormGestion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestion));
            dataGridViewEmpleados = new DataGridView();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDeIngresoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sueldoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoBindingSource = new BindingSource(components);
            Box_Eliminar = new TextBox();
            Btn_eliminar = new Button();
            Btn_guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            Btn_buscar = new Button();
            btn_buscardescripcion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.AutoGenerateColumns = false;
            dataGridViewEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Columns.AddRange(new DataGridViewColumn[] { empleadoIdDataGridViewTextBoxColumn, fechaDeIngresoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, activoDataGridViewTextBoxColumn, sueldoDataGridViewTextBoxColumn });
            dataGridViewEmpleados.DataSource = empleadoBindingSource;
            dataGridViewEmpleados.Location = new Point(16, 49);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.Size = new Size(1010, 356);
            dataGridViewEmpleados.TabIndex = 0;
            dataGridViewEmpleados.DataError += dataGridViewEmpleados_DataError;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.Width = 104;
            // 
            // fechaDeIngresoDataGridViewTextBoxColumn
            // 
            fechaDeIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaDeIngreso";
            fechaDeIngresoDataGridViewTextBoxColumn.HeaderText = "FechaDeIngreso";
            fechaDeIngresoDataGridViewTextBoxColumn.Name = "fechaDeIngresoDataGridViewTextBoxColumn";
            fechaDeIngresoDataGridViewTextBoxColumn.Width = 127;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 81;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.Width = 84;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.Width = 135;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.Width = 89;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 65;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            activoDataGridViewTextBoxColumn.Width = 71;
            // 
            // sueldoDataGridViewTextBoxColumn
            // 
            sueldoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo";
            sueldoDataGridViewTextBoxColumn.HeaderText = "Sueldo";
            sueldoDataGridViewTextBoxColumn.Name = "sueldoDataGridViewTextBoxColumn";
            sueldoDataGridViewTextBoxColumn.Width = 74;
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(Models.Empleado);
            // 
            // Box_Eliminar
            // 
            Box_Eliminar.Location = new Point(14, 432);
            Box_Eliminar.Name = "Box_Eliminar";
            Box_Eliminar.Size = new Size(114, 24);
            Box_Eliminar.TabIndex = 1;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.Cursor = Cursors.Hand;
            Btn_eliminar.FlatStyle = FlatStyle.Flat;
            Btn_eliminar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_eliminar.Location = new Point(226, 425);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(86, 31);
            Btn_eliminar.TabIndex = 2;
            Btn_eliminar.Text = "Eliminar";
            Btn_eliminar.UseVisualStyleBackColor = true;
            Btn_eliminar.Click += Btn_eliminar_Click;
            // 
            // Btn_guardar
            // 
            Btn_guardar.Cursor = Cursors.Hand;
            Btn_guardar.FlatStyle = FlatStyle.Flat;
            Btn_guardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_guardar.Location = new Point(940, 425);
            Btn_guardar.Name = "Btn_guardar";
            Btn_guardar.Size = new Size(86, 31);
            Btn_guardar.TabIndex = 4;
            Btn_guardar.Text = "Guardar";
            Btn_guardar.UseVisualStyleBackColor = true;
            Btn_guardar.Click += Btn_guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 37);
            label1.TabIndex = 5;
            label1.Text = "Gestor Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 414);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 6;
            label2.Text = "Id";
            // 
            // Btn_buscar
            // 
            Btn_buscar.Cursor = Cursors.Hand;
            Btn_buscar.FlatStyle = FlatStyle.Flat;
            Btn_buscar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_buscar.Location = new Point(134, 425);
            Btn_buscar.Name = "Btn_buscar";
            Btn_buscar.Size = new Size(86, 31);
            Btn_buscar.TabIndex = 8;
            Btn_buscar.Text = "Buscar";
            Btn_buscar.UseVisualStyleBackColor = true;
            Btn_buscar.Click += Btn_buscar_Click;
            // 
            // btn_buscardescripcion
            // 
            btn_buscardescripcion.Cursor = Cursors.Hand;
            btn_buscardescripcion.FlatStyle = FlatStyle.Flat;
            btn_buscardescripcion.Location = new Point(848, 428);
            btn_buscardescripcion.Name = "btn_buscardescripcion";
            btn_buscardescripcion.Size = new Size(86, 28);
            btn_buscardescripcion.TabIndex = 34;
            btn_buscardescripcion.Text = "Refresh";
            btn_buscardescripcion.UseVisualStyleBackColor = true;
            btn_buscardescripcion.Click += btn_buscardescripcion_Click;
            // 
            // FormGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1044, 474);
            Controls.Add(btn_buscardescripcion);
            Controls.Add(Btn_buscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_guardar);
            Controls.Add(Btn_eliminar);
            Controls.Add(Box_Eliminar);
            Controls.Add(dataGridViewEmpleados);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormGestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Empleados";
            FormClosing += FormGestion_FormClosing;
            Load += FormGestion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmpleados;
        private TextBox Box_Eliminar;
        private Button Btn_eliminar;
        private Button Btn_guardar;
        private Label label1;
        private Label label2;
        private Button Btn_buscar;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDeIngresoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sueldoDataGridViewTextBoxColumn;
        private BindingSource empleadoBindingSource;
        private Button btn_buscardescripcion;
    }
}
