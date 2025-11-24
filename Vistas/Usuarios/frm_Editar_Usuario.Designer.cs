namespace CRUD_Semana5.Vistas.Usuarios
{
    partial class frm_Editar_Usuario
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
            txt_Contrasenias = new TextBox();
            label1 = new Label();
            txt_Correos = new TextBox();
            label2 = new Label();
            txt_Apellidos = new TextBox();
            txt_Cedulas = new TextBox();
            txt_Nombres = new TextBox();
            label4 = new Label();
            label6 = new Label();
            chb_Estados = new CheckBox();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            panel2 = new Panel();
            label7 = new Label();
            cb_Rol = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Contrasenias
            // 
            txt_Contrasenias.Location = new Point(54, 345);
            txt_Contrasenias.MaxLength = 50;
            txt_Contrasenias.Name = "txt_Contrasenias";
            txt_Contrasenias.Size = new Size(277, 32);
            txt_Contrasenias.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(105, 11);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 0;
            label1.Text = "EDITAR USUARIO";
            // 
            // txt_Correos
            // 
            txt_Correos.Location = new Point(54, 282);
            txt_Correos.MaxLength = 50;
            txt_Correos.Name = "txt_Correos";
            txt_Correos.Size = new Size(277, 32);
            txt_Correos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 67);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Cédula";
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(54, 219);
            txt_Apellidos.MaxLength = 50;
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(277, 32);
            txt_Apellidos.TabIndex = 3;
            // 
            // txt_Cedulas
            // 
            txt_Cedulas.Location = new Point(54, 95);
            txt_Cedulas.MaxLength = 10;
            txt_Cedulas.Name = "txt_Cedulas";
            txt_Cedulas.ReadOnly = true;
            txt_Cedulas.Size = new Size(277, 32);
            txt_Cedulas.TabIndex = 1;
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(54, 156);
            txt_Nombres.MaxLength = 50;
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(277, 32);
            txt_Nombres.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 191);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 5;
            label4.Text = "Apellidos*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 317);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 7;
            label6.Text = "Contraseña*";
            // 
            // chb_Estados
            // 
            chb_Estados.AutoSize = true;
            chb_Estados.Location = new Point(244, 404);
            chb_Estados.Name = "chb_Estados";
            chb_Estados.Size = new Size(87, 29);
            chb_Estados.TabIndex = 6;
            chb_Estados.Text = "Estado";
            chb_Estados.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 254);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 6;
            label5.Text = "Correo*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 130);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 4;
            label3.Text = "Nombres*";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Salir);
            panel1.Controls.Add(btn_Cancelar);
            panel1.Controls.Add(btn_Guardar);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 456);
            panel1.TabIndex = 14;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(10, 180);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(114, 39);
            btn_Salir.TabIndex = 9;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(10, 135);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(114, 39);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(10, 88);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(114, 39);
            btn_Guardar.TabIndex = 7;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cb_Rol);
            panel2.Controls.Add(txt_Contrasenias);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_Correos);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_Apellidos);
            panel2.Controls.Add(txt_Cedulas);
            panel2.Controls.Add(txt_Nombres);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(chb_Estados);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(132, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 456);
            panel2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 403);
            label7.Name = "label7";
            label7.Size = new Size(38, 25);
            label7.TabIndex = 9;
            label7.Text = "Rol";
            // 
            // cb_Rol
            // 
            cb_Rol.FormattingEnabled = true;
            cb_Rol.Location = new Point(98, 400);
            cb_Rol.Name = "cb_Rol";
            cb_Rol.Size = new Size(121, 33);
            cb_Rol.TabIndex = 8;
            // 
            // frm_Editar_Usuario
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 454);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Editar_Usuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Usuario";
            Load += frm_Editar_Usuario_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_Contrasenias;
        private Label label1;
        private TextBox txt_Correos;
        private Label label2;
        private TextBox txt_Apellidos;
        private TextBox txt_Cedulas;
        private TextBox txt_Nombres;
        private Label label4;
        private Label label6;
        private CheckBox chb_Estados;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Panel panel2;
        private ComboBox cb_Rol;
        private Label label7;
    }
}