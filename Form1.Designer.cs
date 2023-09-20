namespace WinFormsApp4
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
            lsLista = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            txtName = new TextBox();
            txtData = new TextBox();
            txtNodosCrear = new TextBox();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // lsLista
            // 
            lsLista.FormattingEnabled = true;
            lsLista.ItemHeight = 20;
            lsLista.Location = new Point(519, 31);
            lsLista.Name = "lsLista";
            lsLista.Size = new Size(252, 384);
            lsLista.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(319, 39);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 50);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(319, 119);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 50);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(48, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 27);
            txtName.TabIndex = 3;
            // 
            // txtData
            // 
            txtData.Location = new Point(48, 51);
            txtData.Name = "txtData";
            txtData.Size = new Size(251, 27);
            txtData.TabIndex = 4;
            // 
            // txtNodosCrear
            // 
            txtNodosCrear.Location = new Point(48, 377);
            txtNodosCrear.Name = "txtNodosCrear";
            txtNodosCrear.Size = new Size(251, 27);
            txtNodosCrear.TabIndex = 6;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(319, 365);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(132, 50);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNodosCrear);
            Controls.Add(btnCrear);
            Controls.Add(txtData);
            Controls.Add(txtName);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lsLista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsLista;
        private Button btnAgregar;
        private Button btnEliminar;
        private TextBox txtName;
        private TextBox txtData;
        private TextBox txtNodosCrear;
        private Button btnCrear;
    }
}