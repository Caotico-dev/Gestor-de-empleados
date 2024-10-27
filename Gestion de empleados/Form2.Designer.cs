namespace Gestion_de_empleados_
{
    partial class DepartamentoDeProyectos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartamentoDeProyectos));
            dataGridViewdep = new DataGridView();
            departamentoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            funcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proyectoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proyectoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departamentoBindingSource = new BindingSource(components);
            dataGridViewpr = new DataGridView();
            proyectoIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proyectoBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            BoxDpt = new TextBox();
            buscardept = new Button();
            label12 = new Label();
            btn_buscardescripcion = new Button();
            box_proyecto = new TextBox();
            label13 = new Label();
            btn_guardar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departamentoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proyectoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewdep
            // 
            dataGridViewdep.AutoGenerateColumns = false;
            dataGridViewdep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewdep.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewdep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdep.Columns.AddRange(new DataGridViewColumn[] { departamentoIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, funcionDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, proyectoIdDataGridViewTextBoxColumn, empleadoDataGridViewTextBoxColumn, proyectoDataGridViewTextBoxColumn });
            dataGridViewdep.DataSource = departamentoBindingSource;
            dataGridViewdep.Location = new Point(14, 45);
            dataGridViewdep.Name = "dataGridViewdep";
            dataGridViewdep.Size = new Size(618, 297);
            dataGridViewdep.TabIndex = 0;
            // 
            // departamentoIdDataGridViewTextBoxColumn
            // 
            departamentoIdDataGridViewTextBoxColumn.DataPropertyName = "DepartamentoId";
            departamentoIdDataGridViewTextBoxColumn.HeaderText = "DepartamentoId";
            departamentoIdDataGridViewTextBoxColumn.Name = "departamentoIdDataGridViewTextBoxColumn";
            departamentoIdDataGridViewTextBoxColumn.Width = 131;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 81;
            // 
            // funcionDataGridViewTextBoxColumn
            // 
            funcionDataGridViewTextBoxColumn.DataPropertyName = "Funcion";
            funcionDataGridViewTextBoxColumn.HeaderText = "Funcion";
            funcionDataGridViewTextBoxColumn.Name = "funcionDataGridViewTextBoxColumn";
            funcionDataGridViewTextBoxColumn.Width = 80;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.Width = 104;
            // 
            // proyectoIdDataGridViewTextBoxColumn
            // 
            proyectoIdDataGridViewTextBoxColumn.DataPropertyName = "ProyectoId";
            proyectoIdDataGridViewTextBoxColumn.HeaderText = "ProyectoId";
            proyectoIdDataGridViewTextBoxColumn.Name = "proyectoIdDataGridViewTextBoxColumn";
            proyectoIdDataGridViewTextBoxColumn.Width = 98;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            empleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // proyectoDataGridViewTextBoxColumn
            // 
            proyectoDataGridViewTextBoxColumn.DataPropertyName = "Proyecto";
            proyectoDataGridViewTextBoxColumn.HeaderText = "Proyecto";
            proyectoDataGridViewTextBoxColumn.Name = "proyectoDataGridViewTextBoxColumn";
            proyectoDataGridViewTextBoxColumn.Visible = false;
            // 
            // departamentoBindingSource
            // 
            departamentoBindingSource.DataSource = typeof(Models.Departamento);
            // 
            // dataGridViewpr
            // 
            dataGridViewpr.AutoGenerateColumns = false;
            dataGridViewpr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewpr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewpr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpr.Columns.AddRange(new DataGridViewColumn[] { proyectoIdDataGridViewTextBoxColumn1, nombreDataGridViewTextBoxColumn1, descripcionDataGridViewTextBoxColumn });
            dataGridViewpr.DataSource = proyectoBindingSource;
            dataGridViewpr.Location = new Point(638, 45);
            dataGridViewpr.Name = "dataGridViewpr";
            dataGridViewpr.Size = new Size(490, 297);
            dataGridViewpr.TabIndex = 1;
            dataGridViewpr.SelectionChanged += dataGridViewpr_SelectionChanged;
            // 
            // proyectoIdDataGridViewTextBoxColumn1
            // 
            proyectoIdDataGridViewTextBoxColumn1.DataPropertyName = "ProyectoId";
            proyectoIdDataGridViewTextBoxColumn1.HeaderText = "ProyectoId";
            proyectoIdDataGridViewTextBoxColumn1.Name = "proyectoIdDataGridViewTextBoxColumn1";
            proyectoIdDataGridViewTextBoxColumn1.Width = 98;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            nombreDataGridViewTextBoxColumn1.Width = 81;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.Width = 103;
            // 
            // proyectoBindingSource
            // 
            proyectoBindingSource.DataSource = typeof(Models.Proyecto);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 5);
            label1.Name = "label1";
            label1.Size = new Size(221, 37);
            label1.TabIndex = 2;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(638, 5);
            label2.Name = "label2";
            label2.Size = new Size(149, 37);
            label2.TabIndex = 6;
            label2.Text = "Proyectos";
            // 
            // BoxDpt
            // 
            BoxDpt.Location = new Point(12, 363);
            BoxDpt.Name = "BoxDpt";
            BoxDpt.Size = new Size(100, 24);
            BoxDpt.TabIndex = 29;
            // 
            // buscardept
            // 
            buscardept.Cursor = Cursors.Hand;
            buscardept.FlatStyle = FlatStyle.Flat;
            buscardept.Location = new Point(118, 359);
            buscardept.Name = "buscardept";
            buscardept.Size = new Size(86, 28);
            buscardept.TabIndex = 30;
            buscardept.Text = "Buscar";
            buscardept.UseVisualStyleBackColor = true;
            buscardept.Click += buscardept_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 345);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 31;
            label12.Text = "Departamento";
            // 
            // btn_buscardescripcion
            // 
            btn_buscardescripcion.Cursor = Cursors.Hand;
            btn_buscardescripcion.FlatStyle = FlatStyle.Flat;
            btn_buscardescripcion.Location = new Point(742, 359);
            btn_buscardescripcion.Name = "btn_buscardescripcion";
            btn_buscardescripcion.Size = new Size(86, 28);
            btn_buscardescripcion.TabIndex = 33;
            btn_buscardescripcion.Text = "Buscar";
            btn_buscardescripcion.UseVisualStyleBackColor = true;
            btn_buscardescripcion.Click += btn_buscardescripcion_Click;
            // 
            // box_proyecto
            // 
            box_proyecto.Location = new Point(636, 362);
            box_proyecto.Name = "box_proyecto";
            box_proyecto.Size = new Size(100, 24);
            box_proyecto.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(638, 345);
            label13.Name = "label13";
            label13.Size = new Size(61, 15);
            label13.TabIndex = 34;
            label13.Text = "Proyecto";
            // 
            // btn_guardar
            // 
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Location = new Point(1042, 363);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(86, 28);
            btn_guardar.TabIndex = 35;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(950, 362);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 36;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DepartamentoDeProyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 402);
            Controls.Add(button1);
            Controls.Add(btn_guardar);
            Controls.Add(label13);
            Controls.Add(btn_buscardescripcion);
            Controls.Add(box_proyecto);
            Controls.Add(label12);
            Controls.Add(buscardept);
            Controls.Add(BoxDpt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewpr);
            Controls.Add(dataGridViewdep);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DepartamentoDeProyectos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departamentos y Proyectos";
            FormClosing += DepartamentoDeProyectos_FormClosing;
            Load += DepartamentoDeProyectos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewdep).EndInit();
            ((System.ComponentModel.ISupportInitialize)departamentoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpr).EndInit();
            ((System.ComponentModel.ISupportInitialize)proyectoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewdep;
        private DataGridView dataGridViewpr;
        private Label label1;
        private Label label2;
        private TextBox BoxDpt;
        private Button buscardept;
        private Label label12;
        private Button btn_buscardescripcion;
        private TextBox box_proyecto;
        private Label label13;
        private BindingSource departamentoBindingSource;
        private DataGridViewTextBoxColumn proyectoIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private BindingSource proyectoBindingSource;
        private DataGridViewTextBoxColumn departamentoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn funcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proyectoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proyectoDataGridViewTextBoxColumn;
        private Button btn_guardar;
        private Button button1;
    }
}