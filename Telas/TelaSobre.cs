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
    public partial class TelaSobre : Form
    {

        Funcionario _userLogado;
        public TelaSobre(Funcionario funcionarioLogado)
        {
            InitializeComponent();

            _userLogado = new Funcionario();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
