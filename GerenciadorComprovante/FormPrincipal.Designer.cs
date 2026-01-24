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
            btnAbrirArquivos = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAbrirArquivos
            // 
            btnAbrirArquivos.Location = new Point(239, 33);
            btnAbrirArquivos.Name = "btnAbrirArquivos";
            btnAbrirArquivos.Size = new Size(114, 39);
            btnAbrirArquivos.TabIndex = 0;
            btnAbrirArquivos.Text = "Abrir Arquivos";
            btnAbrirArquivos.UseVisualStyleBackColor = true;
            btnAbrirArquivos.Click += btnAbrirArquivos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(239, 94);
            button1.Name = "button1";
            button1.Size = new Size(114, 39);
            button1.TabIndex = 1;
            button1.Text = "Mover Arquivos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnProcessar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAbrirArquivos);
            Name = "FormPrincipal";
            Text = "Gerenciador de Comprovantes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirArquivos;
        private Button button1;
    }
}
