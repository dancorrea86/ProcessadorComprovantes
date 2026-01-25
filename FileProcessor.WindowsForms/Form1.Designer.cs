namespace FileProcessor.WindowsForms
{
    partial class FormGerenciador
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
            ofdArquivos = new OpenFileDialog();
            btnArquivos = new Button();
            SuspendLayout();
            // 
            // ofdArquivos
            // 
            ofdArquivos.FileName = "Arquivos";
            // 
            // btnArquivos
            // 
            btnArquivos.Location = new Point(21, 147);
            btnArquivos.Name = "btnArquivos";
            btnArquivos.Size = new Size(104, 55);
            btnArquivos.TabIndex = 0;
            btnArquivos.Text = "Selecionar Arquivos";
            btnArquivos.UseVisualStyleBackColor = true;
            btnArquivos.Click += BtnArquivos_Click;
            // 
            // FormGerenciador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 450);
            Controls.Add(btnArquivos);
            Name = "FormGerenciador";
            Text = "Gerenciador Comprovantes";
            Load += FormGerenciador_Load;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog ofdArquivos;
        private Button btnArquivos;
    }
}
