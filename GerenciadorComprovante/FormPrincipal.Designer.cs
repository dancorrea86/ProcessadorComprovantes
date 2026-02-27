namespace GerenciadorComprovante
{
    partial class FormPrincipal
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
            btnRenomear = new Button();
            button1 = new Button();
            btnCriarUsuario = new Button();
            cmbCarregarUsuario = new ComboBox();
            btnSelecionarFiles = new Button();
            SuspendLayout();
            // 
            // btnRenomear
            // 
            btnRenomear.Location = new Point(166, 136);
            btnRenomear.Name = "btnRenomear";
            btnRenomear.Size = new Size(152, 39);
            btnRenomear.TabIndex = 0;
            btnRenomear.Text = "Renomear Arquivos";
            btnRenomear.UseVisualStyleBackColor = true;
            btnRenomear.Click += btnAbrirArquivos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(166, 191);
            button1.Name = "button1";
            button1.Size = new Size(152, 39);
            button1.TabIndex = 1;
            button1.Text = "Mover Arquivos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnProcessar_Click;
            // 
            // btnCriarUsuario
            // 
            btnCriarUsuario.Location = new Point(12, 22);
            btnCriarUsuario.Name = "btnCriarUsuario";
            btnCriarUsuario.Size = new Size(152, 39);
            btnCriarUsuario.TabIndex = 2;
            btnCriarUsuario.Text = "Criar Usuario";
            btnCriarUsuario.UseVisualStyleBackColor = true;
            btnCriarUsuario.Click += btnCriarUsuario_Click;
            // 
            // cmbCarregarUsuario
            // 
            cmbCarregarUsuario.FormattingEnabled = true;
            cmbCarregarUsuario.Location = new Point(298, 22);
            cmbCarregarUsuario.Name = "cmbCarregarUsuario";
            cmbCarregarUsuario.Size = new Size(121, 23);
            cmbCarregarUsuario.TabIndex = 3;
            cmbCarregarUsuario.SelectedIndexChanged += cmbCarregarUsuario_SelectedIndexChanged;
            // 
            // btnSelecionarFiles
            // 
            btnSelecionarFiles.Location = new Point(166, 80);
            btnSelecionarFiles.Name = "btnSelecionarFiles";
            btnSelecionarFiles.Size = new Size(152, 39);
            btnSelecionarFiles.TabIndex = 4;
            btnSelecionarFiles.Text = "Selecionar Arquivos";
            btnSelecionarFiles.UseVisualStyleBackColor = true;
            btnSelecionarFiles.Click += btnAbrirArquivos_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 319);
            Controls.Add(btnSelecionarFiles);
            Controls.Add(cmbCarregarUsuario);
            Controls.Add(btnCriarUsuario);
            Controls.Add(button1);
            Controls.Add(btnRenomear);
            Name = "FormPrincipal";
            Text = "Gerenciador de Comprovantes";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRenomear;
        private Button button1;
        private Button btnCriarUsuario;
        private ComboBox cmbCarregarUsuario;
        private Button btnSelecionarFiles;
    }
}
