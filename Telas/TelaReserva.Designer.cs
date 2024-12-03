namespace InovaTechSquadHotel.Telas
{
    partial class TelaReserva
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
            this.lblinfoNquarto = new System.Windows.Forms.Label();
            this.CbxNumQuarto = new System.Windows.Forms.ComboBox();
            this.InfoNomeCliente = new System.Windows.Forms.Label();
            this.InfoValorDiaria = new System.Windows.Forms.Label();
            this.DgvRegistroReserva = new System.Windows.Forms.DataGridView();
            this.CbxNomeCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LblIdReserva = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.DtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistroReserva)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinfoNquarto
            // 
            this.lblinfoNquarto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblinfoNquarto.AutoSize = true;
            this.lblinfoNquarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoNquarto.Location = new System.Drawing.Point(349, 146);
            this.lblinfoNquarto.Name = "lblinfoNquarto";
            this.lblinfoNquarto.Size = new System.Drawing.Size(73, 16);
            this.lblinfoNquarto.TabIndex = 6;
            this.lblinfoNquarto.Text = "N° Quarto";
            // 
            // CbxNumQuarto
            // 
            this.CbxNumQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxNumQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNumQuarto.FormattingEnabled = true;
            this.CbxNumQuarto.Location = new System.Drawing.Point(428, 143);
            this.CbxNumQuarto.Name = "CbxNumQuarto";
            this.CbxNumQuarto.Size = new System.Drawing.Size(131, 23);
            this.CbxNumQuarto.TabIndex = 12;
            this.CbxNumQuarto.SelectedIndexChanged += new System.EventHandler(this.CbxNumQuarto_SelectedIndexChanged);
            // 
            // InfoNomeCliente
            // 
            this.InfoNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoNomeCliente.AutoSize = true;
            this.InfoNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNomeCliente.Location = new System.Drawing.Point(21, 108);
            this.InfoNomeCliente.Name = "InfoNomeCliente";
            this.InfoNomeCliente.Size = new System.Drawing.Size(120, 16);
            this.InfoNomeCliente.TabIndex = 13;
            this.InfoNomeCliente.Text = "Nome do cliente";
            // 
            // InfoValorDiaria
            // 
            this.InfoValorDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoValorDiaria.AutoSize = true;
            this.InfoValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoValorDiaria.Location = new System.Drawing.Point(331, 187);
            this.InfoValorDiaria.Name = "InfoValorDiaria";
            this.InfoValorDiaria.Size = new System.Drawing.Size(90, 16);
            this.InfoValorDiaria.TabIndex = 14;
            this.InfoValorDiaria.Text = "Valor Diária";
            // 
            // DgvRegistroReserva
            // 
            this.DgvRegistroReserva.AllowUserToAddRows = false;
            this.DgvRegistroReserva.AllowUserToDeleteRows = false;
            this.DgvRegistroReserva.AllowUserToResizeRows = false;
            this.DgvRegistroReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRegistroReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistroReserva.Location = new System.Drawing.Point(12, 291);
            this.DgvRegistroReserva.MultiSelect = false;
            this.DgvRegistroReserva.Name = "DgvRegistroReserva";
            this.DgvRegistroReserva.ReadOnly = true;
            this.DgvRegistroReserva.RowHeadersVisible = false;
            this.DgvRegistroReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistroReserva.Size = new System.Drawing.Size(1082, 242);
            this.DgvRegistroReserva.TabIndex = 49;
            this.DgvRegistroReserva.SelectionChanged += new System.EventHandler(this.DgvRegistroReserva_SelectionChanged);
            // 
            // CbxNomeCliente
            // 
            this.CbxNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNomeCliente.FormattingEnabled = true;
            this.CbxNomeCliente.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.CbxNomeCliente.Location = new System.Drawing.Point(147, 105);
            this.CbxNomeCliente.Name = "CbxNomeCliente";
            this.CbxNomeCliente.Size = new System.Drawing.Size(412, 23);
            this.CbxNomeCliente.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.LblIdReserva);
            this.groupBox1.Controls.Add(this.txtValorDiaria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtpCheckout);
            this.groupBox1.Controls.Add(this.DtpCheckin);
            this.groupBox1.Controls.Add(this.BtnSair);
            this.groupBox1.Controls.Add(this.BtnNovo);
            this.groupBox1.Controls.Add(this.BtnDeletar);
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.CbxNomeCliente);
            this.groupBox1.Controls.Add(this.InfoValorDiaria);
            this.groupBox1.Controls.Add(this.InfoNomeCliente);
            this.groupBox1.Controls.Add(this.CbxNumQuarto);
            this.groupBox1.Controls.Add(this.lblinfoNquarto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(427, 226);
            this.txtValorTotal.Multiline = true;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(130, 24);
            this.txtValorTotal.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Valor Total";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 30);
            this.panel2.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(485, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reserva";
            // 
            // LblIdReserva
            // 
            this.LblIdReserva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdReserva.Location = new System.Drawing.Point(24, 74);
            this.LblIdReserva.Name = "LblIdReserva";
            this.LblIdReserva.Size = new System.Drawing.Size(32, 20);
            this.LblIdReserva.TabIndex = 70;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDiaria.Location = new System.Drawing.Point(428, 187);
            this.txtValorDiaria.Multiline = true;
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(129, 21);
            this.txtValorDiaria.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Dias";
            // 
            // txtDias
            // 
            this.txtDias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(147, 227);
            this.txtDias.Multiline = true;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(143, 23);
            this.txtDias.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Dada Check-out";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Data Check-in";
            // 
            // DtpCheckout
            // 
            this.DtpCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCheckout.Location = new System.Drawing.Point(147, 187);
            this.DtpCheckout.Name = "DtpCheckout";
            this.DtpCheckout.Size = new System.Drawing.Size(143, 21);
            this.DtpCheckout.TabIndex = 63;
            // 
            // DtpCheckin
            // 
            this.DtpCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCheckin.Location = new System.Drawing.Point(147, 146);
            this.DtpCheckin.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DtpCheckin.Name = "DtpCheckin";
            this.DtpCheckin.Size = new System.Drawing.Size(143, 21);
            this.DtpCheckin.TabIndex = 62;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.Location = new System.Drawing.Point(856, 230);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(112, 24);
            this.BtnSair.TabIndex = 59;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNovo.Location = new System.Drawing.Point(856, 179);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(112, 24);
            this.BtnNovo.TabIndex = 57;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeletar.Location = new System.Drawing.Point(634, 230);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(112, 24);
            this.BtnDeletar.TabIndex = 56;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrar.Location = new System.Drawing.Point(634, 183);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(112, 24);
            this.BtnCadastrar.TabIndex = 55;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TelaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvRegistroReserva);
            this.MinimumSize = new System.Drawing.Size(1122, 584);
            this.Name = "TelaReserva";
            this.Text = "TelaReserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistroReserva)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblinfoNquarto;
        private System.Windows.Forms.ComboBox CbxNumQuarto;
        private System.Windows.Forms.Label InfoNomeCliente;
        private System.Windows.Forms.Label InfoValorDiaria;
        private System.Windows.Forms.DataGridView DgvRegistroReserva;
        private System.Windows.Forms.ComboBox CbxNomeCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpCheckout;
        private System.Windows.Forms.DateTimePicker DtpCheckin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Label LblIdReserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorTotal;
    }
}