using Caelum.Leilao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public class CriadorDeLeilao
    {
        public CriadorDeLeilao()
        {
                
        }

        Leilao leilao;
        public CriadorDeLeilao Para(string descricao)
        {
            this.leilao = new Leilao(descricao);
            return this;
        }
        public CriadorDeLeilao Lance(Usuario usuario, double valor)
        {
            leilao.Propoe(new Lance(usuario, valor));
            return this;
        }
        public Leilao Cria()
        {
            return leilao;
        }


    }
}
