using System;
using System.Collections.Generic;
namespace Caelum.Leilao
{

    public class Leilao
    {

        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string descricao)
        {
            this.Descricao = descricao;
            this.Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            var total = 0;
            foreach (var item in Lances)
            {
                if (item.Usuario.Equals(lance.Usuario))
                {
                    total += 1;
                }
            }

            if (Lances.Count == 0 || PodeDarLance(lance.Usuario))
            {
                Lances.Add(lance);
            }
            
        }

        private bool PodeDarLance(Usuario usuario)
        {
            return !UltimoLanceDado().Usuario.Equals(usuario) && QtdDeLancesdo(usuario) < 5;
        }

        private int QtdDeLancesdo(Usuario usuario)
        {
            var total = 0;
            foreach (var item in Lances)
            {
                if (item.Usuario.Equals(usuario))
                {
                    total += 1;
                }
            }
            return total;
        }

        private Lance UltimoLanceDado()
        {
            return Lances[Lances.Count - 1];
        }

        public void DobraLance(Usuario usuario)
        {
            Lance ultimoLanceDoUsuario = UltimoLanceDo(usuario);
            
            if (ultimoLanceDoUsuario != null)
            {
                Propoe(new Lance(usuario, ultimoLanceDoUsuario.Valor * 2));

            }
        }

        private Lance UltimoLanceDo(Usuario usuario)
        {
            Lance ultimo = null;

            foreach (var item in Lances)
            {
                if (item.Usuario.Equals(usuario))
                {
                    ultimo= item;
                }
            }
            return ultimo;
        }
    }
}