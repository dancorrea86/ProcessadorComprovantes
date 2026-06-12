namespace ProcessadorComprovantes.GerenciadorComprovante
{
    partial class formCreateUser
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
            txtNome = new TextBox();
            txtPasta = new TextBox();
            lblNome = new Label();
            lblPasta = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(160, 171);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(178, 23);
            txtNome.TabIndex = 0;
            // 
            // txtPasta
            // 
            txtPasta.Location = new Point(160, 217);
            txtPasta.Name = "txtPasta";
            txtPasta.Size = new Size(178, 23);
            txtPasta.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(90, 174);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // lblPasta
            // 
            lblPasta.AutoSize = true;
            lblPasta.Location = new Point(90, 217);
            lblPasta.Name = "lblPasta";
            lblPasta.Size = new Size(38, 15);
            lblPasta.TabIndex = 3;
            lblPasta.Text = "Pasta:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(296, 338);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // formCreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
            Controls.Add(btnSalvar);
            Controls.Add(lblPasta);
            Controls.Add(lblNome);
            Controls.Add(txtPasta);
            Controls.Add(txtNome);
            Name = "formCreateUser";
            Text = "CriarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPasta;
        private Label lblNome;
        private Label lblPasta;
        private Button btnSalvar;
    }
}