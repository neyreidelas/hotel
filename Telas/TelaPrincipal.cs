﻿using InovaTechSquadHotel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InovaTechSquadHotel.Telas
{
    public partial class TelaPrincipal : Form
    {
        private Funcionario _userLogado;
        public TelaPrincipal(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            _userLogado = funcionarioLogado;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
           if (_userLogado != null)
            {
                TslUsuarioLogado.Text = _userLogado.Nome;
                TslEmailLogado.Text = _userLogado.Email;

                if(_userLogado.Cargo == "Gerente")
                {
                    TslCargoLogado.Text = "Gerente"; 
                }
                else if (_userLogado.Cargo == "Recepcionista")
                {
                    TslCargoLogado.Text = "Recepcionista" ;
                    
                }
                else
                {
                    TslCargoLogado.Text = "Sem cargo";
                }
            }                     
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            TelaCadastrarHospede tlCadastrarHospede = new TelaCadastrarHospede(_userLogado);
            tlCadastrarHospede.MdiParent = this;            
            this.Hide();
            tlCadastrarHospede.Show();
            this.Show();          
        }

        private void TrmRelogio_Tick(object sender, EventArgs e)
        {
            this.TslDataHora.Text = DateTime.Now.ToString("F");
        }


        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionario tlCadastroFuncionario = new TelaCadastroFuncionario(_userLogado);
            tlCadastroFuncionario.MdiParent = this;
            this.Hide();
            tlCadastroFuncionario.Show();
            this.Show();
        }

        private void BtnReserva_Click(object sender, EventArgs e)
        {
            TelaReserva tlReserva = new TelaReserva(_userLogado);
            tlReserva.MdiParent = this;
            this.Hide();
            tlReserva.Show();
            this.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnQuarto_Click(object sender, EventArgs e)
        {
            TelaQuarto tlQuartos = new TelaQuarto(_userLogado);
            tlQuartos.MdiParent = this;
            this.Hide();
            tlQuartos.Show();
            this.Show();      
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            TelaSobre telaSobre = new TelaSobre(_userLogado);
            telaSobre.MdiParent = this;
            this.Hide();
            telaSobre.Show(); 
            this.Show();

        }
    }
}
