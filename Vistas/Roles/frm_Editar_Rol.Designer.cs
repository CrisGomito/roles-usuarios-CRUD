namespace CRUD_Semana5.Vistas.Roles
{
    partial class frm_Editar_Rol
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
            txt_Nombre = new TextBox();
            label1 = new Label();
            txt_Descripcion = new TextBox();
            label2 = new Label();
            chb_Estados = new CheckBox();
            panel1 = new Panel();
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(54, 92);
            txt_Nombre.MaxLength = 50;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(277, 32);
            txt_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(105, 11);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "EDITAR ROL";
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Location = new Point(54, 154);
            txt_Descripcion.MaxLength = 250;
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(277, 80);
            txt_Descripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 60);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre*";
            // 
            // chb_Estados
            // 
            chb_Estados.AutoSize = true;
            chb_Estados.Location = new Point(54, 240);
            chb_Estados.Name = "chb_Estados";
            chb_Estados.Size = new Size(87, 29);
            chb_Estados.TabIndex = 6;
            chb_Estados.Text = "Estado";
            chb_Estados.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Salir);
            panel1.Controls.Add(btn_Cancelar);
            panel1.Controls.Add(btn_Guardar);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 300);
            panel1.TabIndex = 2;
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
            panel2.Controls.Add(txt_Descripcion);
            panel2.Controls.Add(txt_Nombre);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(chb_Estados);
            panel2.Location = new Point(132, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 300);
            panel2.TabIndex = 13;
            // 
            // frm_Editar_Rol
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 300);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Editar_Rol";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frm_Editar_Rol";
            Load += frm_Editar_Rol_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_Nombre;
        private Label label1;
        private TextBox txt_Descripcion;
        private Label label2;
        private CheckBox chb_Estados;
        private Panel panel1;
        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Panel panel2;
    }
}