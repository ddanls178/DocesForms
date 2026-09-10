namespace DocesForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            lblChrys = new Label();
            pictureBox1 = new PictureBox();
            lblNomeDoce = new Label();
            lblPrecoUnitario = new Label();
            lblQuantidade = new Label();
            lblIdadeCliente = new Label();
            txtNomeDoce = new TextBox();
            txtPrecoUnitario = new TextBox();
            txtQuantidade = new TextBox();
            txtIdadeCliente = new TextBox();
            lblNome = new Label();
            lblDesconto = new Label();
            lblValorFinal = new Label();
            lblParcela = new Label();
            lblStatus = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Forte", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 59);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(637, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Loja de Doces/Guéris ";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChrys
            // 
            lblChrys.AutoSize = true;
            lblChrys.BackColor = Color.Transparent;
            lblChrys.Font = new Font("Forte", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChrys.ForeColor = Color.Gold;
            lblChrys.Location = new Point(198, 129);
            lblChrys.Name = "lblChrys";
            lblChrys.Size = new Size(219, 35);
            lblChrys.TabIndex = 1;
            lblChrys.Text = "do Chrys Dias";
            lblChrys.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(290, 460);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 327);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblNomeDoce
            // 
            lblNomeDoce.AutoSize = true;
            lblNomeDoce.BackColor = Color.Transparent;
            lblNomeDoce.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeDoce.ForeColor = Color.Gold;
            lblNomeDoce.Location = new Point(33, 186);
            lblNomeDoce.Name = "lblNomeDoce";
            lblNomeDoce.Size = new Size(121, 25);
            lblNomeDoce.TabIndex = 4;
            lblNomeDoce.Text = "Nome Doce:";
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.BackColor = Color.Transparent;
            lblPrecoUnitario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecoUnitario.ForeColor = Color.Gold;
            lblPrecoUnitario.Location = new Point(33, 222);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(146, 25);
            lblPrecoUnitario.TabIndex = 5;
            lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.ForeColor = Color.Gold;
            lblQuantidade.Location = new Point(33, 260);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(121, 25);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.BackColor = Color.Transparent;
            lblIdadeCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdadeCliente.ForeColor = Color.Gold;
            lblIdadeCliente.Location = new Point(33, 296);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(133, 25);
            lblIdadeCliente.TabIndex = 7;
            lblIdadeCliente.Text = "Idade Cliente:";
            // 
            // txtNomeDoce
            // 
            txtNomeDoce.Location = new Point(160, 188);
            txtNomeDoce.Name = "txtNomeDoce";
            txtNomeDoce.Size = new Size(192, 23);
            txtNomeDoce.TabIndex = 8;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Location = new Point(185, 224);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(167, 23);
            txtPrecoUnitario.TabIndex = 9;
            txtPrecoUnitario.TextChanged += txtPrecoUnitario_TextChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(160, 260);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(192, 23);
            txtQuantidade.TabIndex = 10;
            // 
            // txtIdadeCliente
            // 
            txtIdadeCliente.Location = new Point(172, 296);
            txtIdadeCliente.Name = "txtIdadeCliente";
            txtIdadeCliente.Size = new Size(180, 23);
            txtIdadeCliente.TabIndex = 11;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.Gold;
            lblNome.Location = new Point(375, 183);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(71, 25);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome:";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.BackColor = Color.Transparent;
            lblDesconto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesconto.ForeColor = Color.Gold;
            lblDesconto.Location = new Point(375, 216);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(101, 25);
            lblDesconto.TabIndex = 13;
            lblDesconto.Text = "Desconto:";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.BackColor = Color.Transparent;
            lblValorFinal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorFinal.ForeColor = Color.Gold;
            lblValorFinal.Location = new Point(375, 252);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(111, 25);
            lblValorFinal.TabIndex = 14;
            lblValorFinal.Text = "Valor Final:";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.BackColor = Color.Transparent;
            lblParcela.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParcela.ForeColor = Color.Gold;
            lblParcela.Location = new Point(375, 288);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(81, 25);
            lblParcela.TabIndex = 15;
            lblParcela.Text = "Parcela:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Gold;
            lblStatus.Location = new Point(375, 326);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(72, 25);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Status:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.WhiteSmoke;
            btnCalcular.BackgroundImage = (Image)resources.GetObject("btnCalcular.BackgroundImage");
            btnCalcular.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalcular.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.Gold;
            btnCalcular.Location = new Point(33, 336);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(319, 56);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.TopCenter;
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.WhiteSmoke;
            btnLimpar.BackgroundImage = (Image)resources.GetObject("btnLimpar.BackgroundImage");
            btnLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpar.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.Gold;
            btnLimpar.Location = new Point(33, 398);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(319, 56);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.TopCenter;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(643, 789);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(lblStatus);
            Controls.Add(lblParcela);
            Controls.Add(lblValorFinal);
            Controls.Add(lblDesconto);
            Controls.Add(lblNome);
            Controls.Add(txtIdadeCliente);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(txtNomeDoce);
            Controls.Add(lblIdadeCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(lblNomeDoce);
            Controls.Add(pictureBox1);
            Controls.Add(lblChrys);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "LojasDoces";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblChrys;
        private PictureBox pictureBox1;
        private Label lblNomeDoce;
        private Label lblPrecoUnitario;
        private Label lblQuantidade;
        private Label lblIdadeCliente;
        private TextBox txtNomeDoce;
        private TextBox txtPrecoUnitario;
        private TextBox txtQuantidade;
        private TextBox txtIdadeCliente;
        private Label lblNome;
        private Label lblDesconto;
        private Label lblValorFinal;
        private Label lblParcela;
        private Label lblStatus;
        private Button btnCalcular;
        private Button btnLimpar;
    }
}
