namespace CRUD_Semana5.Vistas.Roles
{
    partial class frm_lista_roles
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
            btn_Agregar = new Button();
            label1 = new Label();
            btn_Editar = new Button();
            btn_Eliminar = new Button();
            btn_Salir = new Button();
            lst_Lista_Roles = new ListBox();
            SuspendLayout();
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(27, 77);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(107, 37);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(275, 25);
            label1.Name = "label1";
            label1.Size = new Size(252, 25);
            label1.TabIndex = 2;
            label1.Text = "Centro de Control de Roles";
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(27, 120);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(107, 37);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(27, 165);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(107, 37);
            btn_Eliminar.TabIndex = 4;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(27, 208);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(107, 37);
            btn_Salir.TabIndex = 5;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // lst_Lista_Roles
            // 
            lst_Lista_Roles.FormattingEnabled = true;
            lst_Lista_Roles.ItemHeight = 25;
            lst_Lista_Roles.Location = new Point(140, 77);
            lst_Lista_Roles.Name = "lst_Lista_Roles";
            lst_Lista_Roles.Size = new Size(538, 354);
            lst_Lista_Roles.TabIndex = 6;
            // 
            // frm_lista_roles
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 462);
            Controls.Add(lst_Lista_Roles);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Editar);
            Controls.Add(label1);
            Controls.Add(btn_Agregar);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "frm_lista_roles";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Roles";
            Load += frm_lista_roles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Agregar;
        private Label label1;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private Button btn_Salir;
        private ListBox lst_Lista_Roles;
    }
}