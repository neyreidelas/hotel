using InovaTechSquadHotel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InovaTechSquadHotel.Telas
{
    public partial class TelaReserva : Form
    {
        private Funcionario _userLogado;
        private List<Reserva> _reserva;
        private List<Hospede> _hospedes;
        private Reserva _reservaSelecionada;
        //private Hospede _hospedeSelecionado;
        private List<Quarto> _quartos;

        public TelaReserva(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            _userLogado = funcionarioLogado;

            this.WindowState = FormWindowState.Maximized;

            try
            {

                _reserva = Reserva.BuscarReserva().ConvertAll(u => (Reserva)u);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void configDgv()
        {

            //Criação das colunas
            DgvRegistroReserva.Columns.Add("Id", "Id Reserva");
            DgvRegistroReserva.Columns.Add("Checkin", "Data do Check-in");
            DgvRegistroReserva.Columns.Add("Checkout", "Data do Check-out");       
            DgvRegistroReserva.Columns.Add("QtdDiaria", "Dias Reservados");
            DgvRegistroReserva.Columns.Add("ValorTotal", "Valor Total a pagar");
            DgvRegistroReserva.Columns.Add("HospedeId", "Id Hospede");
            DgvRegistroReserva.Columns.Add("QuartoId", "Numero do quarto");


            //Alinhamento das colunas

            DgvRegistroReserva.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroReserva.Columns["Checkin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroReserva.Columns["Checkout"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroReserva.Columns["QtdDiaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroReserva.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroReserva.Columns["HospedeId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroReserva.Columns["QuartoId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Tamanho das colunas

            DgvRegistroReserva.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistroReserva.Columns["Checkin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistroReserva.Columns["Checkout"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistroReserva.Columns["QtdDiaria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistroReserva.Columns["ValorTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistroReserva.Columns["HospedeId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistroReserva.Columns["QuartoId"].AutoSizeMode= DataGridViewAutoSizeColumnMode.ColumnHeader;

            //Altura das colunas

            DgvRegistroReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvRegistroReserva.ColumnHeadersHeight = 35;
            DgvRegistroReserva.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Definindo uma cor para intercalar linhas
            DgvRegistroReserva.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void carregaDgv(List<Reserva> reservas = null)
        {
            DgvRegistroReserva.Rows.Clear();

            foreach (Reserva reserva in reservas == null ? _reserva : reservas)
            {
                DgvRegistroReserva.Rows.Add(reserva.Id, reserva.Checkin, reserva.Checkout, reserva.QtdDiaria, reserva.ValorTotal, reserva.HospedeId, reserva.QuartoId) ;
            }
        }

        private void LimpaCampos()
        {
            CbxNumQuarto.Text = string.Empty;
            CbxNomeCliente.Text = string.Empty;
            txtDias.Text = string.Empty;
            txtValorDiaria.Text = string.Empty;
            txtValorTotal.Text = string.Empty;
            BtnCadastrar.Enabled = true;
            BtnDeletar.Enabled = false;
            DgvRegistroReserva.ClearSelection();
        }

        private void TelaReserva_Load(object sender, EventArgs e)
        {

            DtpCheckin.MinDate = DateTime.Today;
            DtpCheckout.MinDate = DateTime.Today.AddDays(1);

            try
            {
                configDgv();
                carregaDgv();
                LimpaCampos();
                

                List<Quarto> quartos = Quarto.BuscarQuartos();


                CbxNumQuarto.DataSource = quartos;
                CbxNumQuarto.DisplayMember = "NumQuarto";
                CbxNumQuarto.ValueMember = "Id";

                CbxNumQuarto.SelectedIndexChanged += CbxNumQuarto_SelectedIndexChanged;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                List<Hospede> hospedes = Hospede.BuscarHospede();
                CbxNomeCliente.DataSource = hospedes;
                CbxNomeCliente.DisplayMember = "Nome";
                CbxNomeCliente.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            TimeSpan diferenca = DtpCheckout.Value - DtpCheckin.Value;

            int dias = (int)diferenca.TotalDays + 1;

            double valorDiaria;
            if (!double.TryParse(txtValorDiaria.Text, out valorDiaria))
            {
                MessageBox.Show("Por favor, insira um valor de diária válido.");
                try
                {
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }

            double valorTotal = dias * valorDiaria;

            txtDias.Text = dias.ToString();
            txtValorTotal.Text = valorTotal.ToString(); 
            

            Reserva reserva = new Reserva(0,DtpCheckin.Value,DtpCheckout.Value,Convert.ToInt32(txtDias.Text),Convert.ToInt32(txtValorTotal.Text),Convert.ToInt32(CbxNomeCliente.SelectedValue),Convert.ToInt32(CbxNumQuarto.SelectedValue));
            reserva.CadastrarReserva(_reserva);

            carregaDgv();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbxNumQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxNumQuarto.SelectedItem != null)
            {
                Quarto quartoSelecionado = (Quarto)CbxNumQuarto.SelectedItem;
                txtValorDiaria.Text = quartoSelecionado.ValorDiaria.ToString(); 
            }
            else
            {
                txtValorDiaria.Text = "";
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja excluir {_reservaSelecionada} ?", "Excluir essa reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    _reservaSelecionada.ExcluirReserva();
                    _reserva.RemoveAt(_reserva.FindIndex(a => a.Id == (int)DgvRegistroReserva.SelectedRows[0].Cells[0].Value));
                    carregaDgv();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DgvRegistroReserva_SelectionChanged(object sender, EventArgs e)
        {
            if(DgvRegistroReserva.Rows.Count < 1 || DgvRegistroReserva.SelectedRows.Count < 1)
            {
                return;
            }

            try
            {
                _reservaSelecionada = _reserva.Find(a => a.Id == (int)DgvRegistroReserva.SelectedRows[0].Cells[0].Value);
                LblIdReserva.Text = _reservaSelecionada.HospedeId.ToString();
                txtDias.Text = _reservaSelecionada.QtdDiaria.ToString();
                txtValorTotal.Text = _reservaSelecionada.ValorTotal.ToString();
                BtnCadastrar.Enabled = false;
                BtnDeletar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }       
}
