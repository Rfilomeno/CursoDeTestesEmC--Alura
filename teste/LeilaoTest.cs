using Caelum.Leilao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    //[TestClass]
    //public class LeilaoTest
    //{
    //    [TestMethod]
    //    public void DeveIncluirLeiloes()
    //    {
    //        Leilao leilao = new Leilao("Mac Book");
    //        Usuario u1 = new Usuario("Rodrigo");
    //        Assert.AreEqual(0, leilao.Lances.Count);

    //        leilao.Propoe(new Lance(u1, 2000));
    //        Assert.AreEqual(1, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);

    //    }


    //    [TestMethod]
    //    public void NaoDeveAceitarDoisLancesSeguidosDoMesmoUsuario()
    //    {
    //        Leilao leilao = new Leilao("Mac Book");
    //        Usuario u1 = new Usuario("Rodrigo");
    //        Assert.AreEqual(0, leilao.Lances.Count);

    //        leilao.Propoe(new Lance(u1, 2000));
    //        Assert.AreEqual(1, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);

    //        leilao.Propoe(new Lance(u1, 3000));
    //        Assert.AreEqual(1, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
    //    }

    //    [TestMethod]
    //    public void NaoDeveAceitarMaisDoQue5LancesDeUmMesmoUsuario()
    //    {
    //        Leilao leilao = new Leilao("Mac Book");
    //        Usuario u1 = new Usuario("Rodrigo");
    //        Usuario u2 = new Usuario("Agatha");
    //        Assert.AreEqual(0, leilao.Lances.Count);

    //        leilao.Propoe(new Lance(u1, 2000));
    //        leilao.Propoe(new Lance(u2, 3000));
    //        leilao.Propoe(new Lance(u1, 4000));
    //        leilao.Propoe(new Lance(u2, 5000));
    //        leilao.Propoe(new Lance(u1, 6000));
    //        leilao.Propoe(new Lance(u2, 7000));
    //        leilao.Propoe(new Lance(u1, 8000));
    //        leilao.Propoe(new Lance(u2, 9000));
    //        leilao.Propoe(new Lance(u1, 10000));
    //        leilao.Propoe(new Lance(u2, 11000));
    //        // nao deve aceitar o 5 lance do mesmo usuario
    //        leilao.Propoe(new Lance(u1, 12000));



    //        Assert.AreEqual(10, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
    //        Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001);
    //        Assert.AreEqual(4000, leilao.Lances[2].Valor, 0.0001);
    //        Assert.AreEqual(5000, leilao.Lances[3].Valor, 0.0001);
    //        Assert.AreEqual(6000, leilao.Lances[4].Valor, 0.0001);
    //        Assert.AreEqual(7000, leilao.Lances[5].Valor, 0.0001);
    //        Assert.AreEqual(8000, leilao.Lances[6].Valor, 0.0001);
    //        Assert.AreEqual(9000, leilao.Lances[7].Valor, 0.0001);
    //        Assert.AreEqual(10000, leilao.Lances[8].Valor, 0.0001);
    //        Assert.AreEqual(11000, leilao.Lances[9].Valor, 0.0001);


    //    }

    //    [TestMethod]
    //    public void DeveDobrarLanceAnterior()
    //    {
    //        Leilao leilao = new Leilao("Mac Book");
    //        Usuario u1 = new Usuario("Rodrigo");
    //        Usuario u2 = new Usuario("Agatha");
    //        Assert.AreEqual(0, leilao.Lances.Count);

    //        leilao.Propoe(new Lance(u1, 2000));
    //        leilao.Propoe(new Lance(u2, 3000));

    //        Assert.AreEqual(2, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
    //        Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001);

    //        leilao.DobraLance(u1);
    //        Assert.AreEqual(3, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
    //        Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001);
    //        Assert.AreEqual(4000, leilao.Lances[2].Valor, 0.0001);

    //        //nao deve aceitar dois lances seguidos do mesmo usuário
    //        leilao.DobraLance(u1);
    //        Assert.AreEqual(3, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
    //        Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001);
    //        Assert.AreEqual(4000, leilao.Lances[2].Valor, 0.0001);

    //        leilao.DobraLance(u2);
    //        Assert.AreEqual(4, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
    //        Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001);
    //        Assert.AreEqual(4000, leilao.Lances[2].Valor, 0.0001);
    //        Assert.AreEqual(6000, leilao.Lances[3].Valor, 0.0001);

    //        leilao.DobraLance(u1);
    //        leilao.DobraLance(u2);
    //        leilao.DobraLance(u1);
    //        leilao.DobraLance(u2);
    //        leilao.DobraLance(u1);
    //        leilao.DobraLance(u2);
    //        Assert.AreEqual(10, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
    //        Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001);
    //        Assert.AreEqual(4000, leilao.Lances[2].Valor, 0.0001);
    //        Assert.AreEqual(6000, leilao.Lances[3].Valor, 0.0001);
    //        Assert.AreEqual(8000, leilao.Lances[4].Valor, 0.0001);
    //        Assert.AreEqual(12000, leilao.Lances[5].Valor, 0.0001);
    //        Assert.AreEqual(16000, leilao.Lances[6].Valor, 0.0001);
    //        Assert.AreEqual(24000, leilao.Lances[7].Valor, 0.0001);
    //        Assert.AreEqual(32000, leilao.Lances[8].Valor, 0.0001);
    //        Assert.AreEqual(48000, leilao.Lances[9].Valor, 0.0001);
    //        // não deve aceitar mais de 5 lances de um mesmo usuário
    //        leilao.DobraLance(u1);
    //        Assert.AreEqual(10, leilao.Lances.Count);
    //        Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
    //        Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001);
    //        Assert.AreEqual(4000, leilao.Lances[2].Valor, 0.0001);
    //        Assert.AreEqual(6000, leilao.Lances[3].Valor, 0.0001);
    //        Assert.AreEqual(8000, leilao.Lances[4].Valor, 0.0001);
    //        Assert.AreEqual(12000, leilao.Lances[5].Valor, 0.0001);
    //        Assert.AreEqual(16000, leilao.Lances[6].Valor, 0.0001);
    //        Assert.AreEqual(24000, leilao.Lances[7].Valor, 0.0001);
    //        Assert.AreEqual(32000, leilao.Lances[8].Valor, 0.0001);
    //        Assert.AreEqual(48000, leilao.Lances[9].Valor, 0.0001);

    //    }

    //    [TestMethod]
    //    public void NaoDeveDobrarCasoNaoTenhaLanceAnterior()
    //    {
    //        Leilao leilao = new Leilao("Mac Book");
    //        Usuario u1 = new Usuario("Rodrigo");

    //        leilao.DobraLance(u1);
    //        Assert.AreEqual(0, leilao.Lances.Count);

    //    }
    //}

}
