using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InovaTechSquadHotel.Classes
{
    internal class Reserva
    {
        #region Propriedades

        public int Id { get; set; }
        public List<Hospede> Hospedes { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int QtdDiaria { get; set; }
        public decimal ValorTotal { get; set; }
        public int HospedeId { get; set; }
        public List<Quarto> NumQuarto { get; set; }
        public int QuartoId { get; set; }
        #endregion

        #region Construtores
        public Reserva()
        {
            
        }

        public Reserva(int id,DateTime checkin,DateTime checkout, int qdtDiaria, decimal valorTotal, int hospedeId, int quarto)
        {
            Id = id;
            Checkin = checkin;
            Checkout = checkout;
            QtdDiaria = qdtDiaria;
            ValorTotal = valorTotal;
            HospedeId = hospedeId;
            QuartoId = quarto;
            
        }
        #endregion

        #region Métodos

        public static List<Reserva> BuscarReserva()
        {
            string query = string.Format("SELECT * FROM Reserva");
            ConexaoSQL cn = new ConexaoSQL(query);

            List<Reserva> reservas = new List<Reserva>();

            try
            {
                cn.AbriConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    reservas.Add(new Reserva()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Checkin = Convert.ToDateTime(cn.dr[1]),
                        Checkout = Convert.ToDateTime(cn.dr[2]),
                        QtdDiaria = Convert.ToInt32(cn.dr[3]),
                        ValorTotal = Convert.ToInt32(cn.dr[4]),
                        HospedeId = Convert.ToInt32(cn.dr[5]),
                        QuartoId = Convert.ToInt32(cn.dr[6])
                        
                    });
                }
                return reservas;
            }
            catch(Exception) 
            {    
                throw;
            }           
           
        }
        public void CadastrarReserva(List<Reserva> reservas)
        {
            string query = string.Format($"INSERT INTO Reserva (Checkin,Checkout,QtdDiaria,ValorTotal,HospedeId,QuartoId) VALUES ('{Checkin}','{Checkout}','{QtdDiaria}','{ValorTotal}','{HospedeId}','{QuartoId}')");
            query += "; SELECT SCOPE_IDENTITY()";
            ConexaoSQL cn = new ConexaoSQL(query);

            try
            {
                cn.AbriConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                reservas.Add(this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void ExcluirReserva()
        {
            string query = string.Format($"DELETE FROM Reserva WHERE Id = {Id}");
            ConexaoSQL cn = new ConexaoSQL(query);

            try
            {
                cn.AbriConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }

        #endregion
    }
}
