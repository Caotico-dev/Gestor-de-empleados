namespace Gestion_de_empleados_
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            Cantidaemple = new Label();
            Cantidapro = new Label();
            Cantidadpt = new Label();
            pictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 199);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 0;
            label1.Text = "Empleados Activos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 151);
            label2.Name = "label2";
            label2.Size = new Size(322, 37);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de proyectos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 103);
            label3.Name = "label3";
            label3.Size = new Size(392, 37);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de departamentos:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Cantidaemple);
            panel1.Controls.Add(Cantidapro);
            panel1.Controls.Add(Cantidadpt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 419);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(169, 37);
            label7.TabIndex = 7;
            label7.Text = "Estadisticas";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(255, 325);
            button1.Name = "button1";
            button1.Size = new Size(169, 45);
            button1.TabIndex = 5;
            button1.Text = "Gestor Empleados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(14, 325);
            button2.Name = "button2";
            button2.Size = new Size(215, 45);
            button2.TabIndex = 6;
            button2.Text = "Departamentos y Proyectos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cantidaemple
            // 
            Cantidaemple.AutoSize = true;
            Cantidaemple.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cantidaemple.Location = new Point(423, 199);
            Cantidaemple.Name = "Cantidaemple";
            Cantidaemple.Size = new Size(33, 37);
            Cantidaemple.TabIndex = 5;
            Cantidaemple.Text = "0";
            // 
            // Cantidapro
            // 
            Cantidapro.AutoSize = true;
            Cantidapro.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cantidapro.Location = new Point(423, 151);
            Cantidapro.Name = "Cantidapro";
            Cantidapro.Size = new Size(33, 37);
            Cantidapro.TabIndex = 4;
            Cantidapro.Text = "0";
            // 
            // Cantidadpt
            // 
            Cantidadpt.AutoSize = true;
            Cantidadpt.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cantidadpt.Location = new Point(423, 103);
            Cantidadpt.Name = "Cantidadpt";
            Cantidadpt.Size = new Size(33, 37);
            Cantidadpt.TabIndex = 3;
            Cantidadpt.Text = "0";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(519, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(383, 419);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 8000;
            timer1.Tick += timer1_Tick;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(pictureBox);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicion Gestor Empleados";
            FormClosing += FormInicio_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label Cantidaemple;
        private Label Cantidapro;
        private Label Cantidadpt;
        private PictureBox pictureBox;
        private Button button1;
        private Button button2;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}