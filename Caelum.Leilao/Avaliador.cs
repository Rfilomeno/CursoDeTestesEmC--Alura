using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class Avaliador
    {
        private double maiordetodos = double.MinValue;
        private double menordetodos = double.MaxValue;
        private IList<Lance> maiores;


        public void Avalia(Leilao leilao)
        {
            foreach (var item in leilao.Lances)
            {
                if (item.Valor > maiordetodos)
                {
                    maiordetodos = item.Valor;
                }
                if (item.Valor < menordetodos)
                {
                    menordetodos = item.Valor;
                }
            }
            pegaOsMaioresNo(leilao);
        }
        private void pegaOsMaioresNo(Leilao leilao)
        {
            var filtro = leilao.Lances.OrderByDescending(p => p.Valor).Take(3);
            maiores = new List<Lance>(filtro);
        }

        public IList<Lance> TresMaiores
        {
            get { return this.maiores; }
        }

        public double ValorMedio(Leilao leilao)
        {
            double valortotal = 0;

            foreach (var item in leilao.Lances)
            {
                valortotal += item.Valor;
            }

            return valortotal / leilao.Lances.Count;
        }

        public double MaiorDeTodos { get { return maiordetodos; } }
        public double MenorDeTodos { get { return menordetodos; } }

    }

}


