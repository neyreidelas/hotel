namespace InovaTechSquadHotel.Telas
{
    partial class TelaQuarto
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblInfoTipoQuarto = new System.Windows.Forms.Label();
            this.BtnTipoQuarto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LblIdQuarto = new System.Windows.Forms.Label();
            this.CbxTipoQuarto = new System.Windows.Forms.ComboBox();
            this.tipoQuartoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LblIdTipoQuarto = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.LblInfoValorDiaria = new System.Windows.Forms.Label();
            this.LblInfoNAndar = new System.Windows.Forms.Label();
            this.LblInfoNquarto = new System.Windows.Forms.Label();
            this.TxtValorDiaria = new System.Windows.Forms.TextBox();
            this.TxtNAndar = new System.Windows.Forms.TextBox();
            this.TxtNquarto = new System.Windows.Forms.TextBox();
            this.tipoQuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgvRegistro = new System.Windows.Forms.DataGridView();
            this.tipoQuartoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.LblIdQuarto);
            this.groupBox1.Controls.Add(this.CbxTipoQuarto);
            this.groupBox1.Controls.Add(this.LblIdTipoQuarto);
            this.groupBox1.Controls.Add(this.BtnNovo);
            this.groupBox1.Controls.Add(this.BtnAlterar);
            this.groupBox1.Controls.Add(this.BtnExcluir);
            this.groupBox1.Controls.Add(this.BtnFechar);
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.LblInfoValorDiaria);
            this.groupBox1.Controls.Add(this.LblInfoNAndar);
            this.groupBox1.Controls.Add(this.LblInfoNquarto);
            this.groupBox1.Controls.Add(this.TxtValorDiaria);
            this.groupBox1.Controls.Add(this.TxtNAndar);
            this.groupBox1.Controls.Add(this.TxtNquarto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LblInfoTipoQuarto);
            this.groupBox2.Controls.Add(this.BtnTipoQuarto);
            this.groupBox2.Location = new System.Drawing.Point(649, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 201);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // LblInfoTipoQuarto
            // 
            this.LblInfoTipoQuarto.AutoSize = true;
            this.LblInfoTipoQuarto.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoTipoQuarto.Location = new System.Drawing.Point(131, 37);
            this.LblInfoTipoQuarto.Name = "LblInfoTipoQuarto";
            this.LblInfoTipoQuarto.Size = new System.Drawing.Size(204, 22);
            this.LblInfoTipoQuarto.TabIndex = 12;
            this.LblInfoTipoQuarto.Text = "Cadastrar tipo de quarto";
            // 
            // BtnTipoQuarto
            // 
            this.BtnTipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTipoQuarto.Location = new System.Drawing.Point(173, 97);
            this.BtnTipoQuarto.Name = "BtnTipoQuarto";
            this.BtnTipoQuarto.Size = new System.Drawing.Size(101, 27);
            this.BtnTipoQuarto.TabIndex = 11;
            this.BtnTipoQuarto.Text = "Entrar";
            this.BtnTipoQuarto.UseVisualStyleBackColor = true;
            this.BtnTipoQuarto.Click += new System.EventHandler(this.BtnTipoQuarto_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 33);
            this.panel2.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(488, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quartos";
            // 
            // LblIdQuarto
            // 
            this.LblIdQuarto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdQuarto.Location = new System.Drawing.Point(33, 59);
            this.LblIdQuarto.Name = "LblIdQuarto";
            this.LblIdQuarto.Size = new System.Drawing.Size(100, 24);
            this.LblIdQuarto.TabIndex = 13;
            // 
            // CbxTipoQuarto
            // 
            this.CbxTipoQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxTipoQuarto.DataSource = this.tipoQuartoBindingSource1;
            this.CbxTipoQuarto.DisplayMember = "Descricao";
            this.CbxTipoQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoQuarto.FormattingEnabled = true;
            this.CbxTipoQuarto.Location = new System.Drawing.Point(364, 97);
            this.CbxTipoQuarto.Name = "CbxTipoQuarto";
            this.CbxTipoQuarto.Size = new System.Drawing.Size(239, 21);
            this.CbxTipoQuarto.TabIndex = 12;
            // 
            // tipoQuartoBindingSource1
            // 
            this.tipoQuartoBindingSource1.DataSource = typeof(InovaTechSquadHotel.Classes.TipoQuarto);
            // 
            // LblIdTipoQuarto
            // 
            this.LblIdTipoQuarto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdTipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdTipoQuarto.Location = new System.Drawing.Point(441, 59);
            this.LblIdTipoQuarto.Name = "LblIdTipoQuarto";
            this.LblIdTipoQuarto.Size = new System.Drawing.Size(100, 24);
            this.LblIdTipoQuarto.TabIndex = 11;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNovo.Location = new System.Drawing.Point(364, 148);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(107, 23);
            this.BtnNovo.TabIndex = 10;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlterar.Location = new System.Drawing.Point(501, 145);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(107, 23);
            this.BtnAlterar.TabIndex = 9;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Location = new System.Drawing.Point(364, 198);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(107, 23);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.Location = new System.Drawing.Point(501, 237);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(107, 23);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrar.Location = new System.Drawing.Point(501, 198);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(107, 23);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LblInfoValorDiaria
            // 
            this.LblInfoValorDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInfoValorDiaria.AutoSize = true;
            this.LblInfoValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoValorDiaria.Location = new System.Drawing.Point(29, 198);
            this.LblInfoValorDiaria.Name = "LblInfoValorDiaria";
            this.LblInfoValorDiaria.Size = new System.Drawing.Size(130, 24);
            this.LblInfoValorDiaria.TabIndex = 5;
            this.LblInfoValorDiaria.Text = "Valor da diaria";
            // 
            // LblInfoNAndar
            // 
            this.LblInfoNAndar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInfoNAndar.AutoSize = true;
            this.LblInfoNAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoNAndar.Location = new System.Drawing.Point(29, 145);
            this.LblInfoNAndar.Name = "LblInfoNAndar";
            this.LblInfoNAndar.Size = new System.Drawing.Size(88, 24);
            this.LblInfoNAndar.TabIndex = 4;
            this.LblInfoNAndar.Text = "N° andar:";
            // 
            // LblInfoNquarto
            // 
            this.LblInfoNquarto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInfoNquarto.AutoSize = true;
            this.LblInfoNquarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoNquarto.Location = new System.Drawing.Point(29, 98);
            this.LblInfoNquarto.Name = "LblInfoNquarto";
            this.LblInfoNquarto.Size = new System.Drawing.Size(93, 24);
            this.LblInfoNquarto.TabIndex = 3;
            this.LblInfoNquarto.Text = "N° quarto:";
            // 
            // TxtValorDiaria
            // 
            this.TxtValorDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValorDiaria.Location = new System.Drawing.Point(165, 202);
            this.TxtValorDiaria.Name = "TxtValorDiaria";
            this.TxtValorDiaria.Size = new System.Drawing.Size(150, 20);
            this.TxtValorDiaria.TabIndex = 2;
            // 
            // TxtNAndar
            // 
            this.TxtNAndar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNAndar.Location = new System.Drawing.Point(165, 149);
            this.TxtNAndar.Name = "TxtNAndar";
            this.TxtNAndar.Size = new System.Drawing.Size(150, 20);
            this.TxtNAndar.TabIndex = 1;
            // 
            // TxtNquarto
            // 
            this.TxtNquarto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNquarto.Location = new System.Drawing.Point(165, 98);
            this.TxtNquarto.Name = "TxtNquarto";
            this.TxtNquarto.Size = new System.Drawing.Size(150, 20);
            this.TxtNquarto.TabIndex = 0;
            // 
            // tipoQuartoBindingSource
            // 
            this.tipoQuartoBindingSource.DataSource = typeof(InovaTechSquadHotel.Classes.TipoQuarto);
            // 
            // DgvRegistro
            // 
            this.DgvRegistro.AllowUserToAddRows = false;
            this.DgvRegistro.AllowUserToDeleteRows = false;
            this.DgvRegistro.AllowUserToResizeRows = false;
            this.DgvRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistro.Location = new System.Drawing.Point(12, 284);
            this.DgvRegistro.MultiSelect = false;
            this.DgvRegistro.Name = "DgvRegistro";
            this.DgvRegistro.ReadOnly = true;
            this.DgvRegistro.RowHeadersVisible = false;
            this.DgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistro.Size = new System.Drawing.Size(1082, 249);
            this.DgvRegistro.TabIndex = 7;
            this.DgvRegistro.SelectionChanged += new System.EventHandler(this.DgvRegistro_SelectionChanged);
            // 
            // tipoQuartoBindingSource2
            // 
            this.tipoQuartoBindingSource2.DataSource = typeof(InovaTechSquadHotel.Classes.TipoQuarto);
            // 
            // TelaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 545);
            this.Controls.Add(this.DgvRegistro);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1122, 584);
            this.Name = "TelaQuarto";
            this.Text = "TelaQuartos";
            this.Load += new System.EventHandler(this.TelaQuartos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblInfoValorDiaria;
        private System.Windows.Forms.Label LblInfoNAndar;
        private System.Windows.Forms.Label LblInfoNquarto;
        private System.Windows.Forms.TextBox TxtValorDiaria;
        private System.Windows.Forms.TextBox TxtNAndar;
        private System.Windows.Forms.TextBox TxtNquarto;
        private System.Windows.Forms.DataGridView DgvRegistro;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label LblIdTipoQuarto;
        private System.Windows.Forms.ComboBox CbxTipoQuarto;
        private System.Windows.Forms.BindingSource tipoQuartoBindingSource;
        private System.Windows.Forms.BindingSource tipoQuartoBindingSource1;
        private System.Windows.Forms.BindingSource tipoQuartoBindingSource2;
        private System.Windows.Forms.Label LblIdQuarto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblInfoTipoQuarto;
        private System.Windows.Forms.Button BtnTipoQuarto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}