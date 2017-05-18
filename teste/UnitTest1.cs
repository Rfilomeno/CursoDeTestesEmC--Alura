using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caelum.Leilao;

namespace teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveEntenderLeilaoEmOrdemCrescente()
        {
            Usuario u1 = new Usuario("Jose");
            Usuario u2 = new Usuario("Joao");
            Usuario u3 = new Usuario("Maria");

            Leilao leilao = new Leilao("PlayStation 3");

            leilao.Propoe(new Lance(u1, 200));
            leilao.Propoe(new Lance(u2, 300));
            leilao.Propoe(new Lance(u3, 400));

            Avaliador avaliador = new Avaliador();
            avaliador.Avalia(leilao);

            double MaiorLance = 400;
            double MenorLance = 200;

            double ValorMedio = avaliador.ValorMedio(leilao);
            var ValorMedioEsperado = 300;

            Assert.AreEqual(MaiorLance, avaliador.MaiorDeTodos);
            Assert.AreEqual(MenorLance, avaliador.MenorDeTodos);
            Assert.AreEqual(ValorMedioEsperado, ValorMedio);
        }
        [TestMethod]
        public void DeveEntenderLeilaoComSomenteUmValor()
        {
            Usuario u1 = new Usuario("Jose");
           

            Leilao leilao = new Leilao("PlayStation 3");

            leilao.Propoe(new Lance(u1, 200));
           

            Avaliador avaliador = new Avaliador();
            avaliador.Avalia(leilao);
            
            Assert.AreEqual(200, avaliador.MaiorDeTodos);
            Assert.AreEqual(200, avaliador.MenorDeTodos);

        }
        [TestMethod]
        public void DeveEntenderLeilaoComValoresRandomicos()
        {
            Usuario u1 = new Usuario("Jose");
            Usuario u2 = new Usuario("Maria");

            Leilao leilao = new Leilao("PlayStation 3");

            leilao.Propoe(new Lance(u1, 200));
            leilao.Propoe(new Lance(u1, 450));
            leilao.Propoe(new Lance(u1, 120));
            leilao.Propoe(new Lance(u1, 700));
            leilao.Propoe(new Lance(u1, 630));
            leilao.Propoe(new Lance(u1, 230));


            Avaliador avaliador = new Avaliador();
            avaliador.Avalia(leilao);

            Assert.AreEqual(700, avaliador.MaiorDeTodos, 0.0001);
            Assert.AreEqual(120, avaliador.MenorDeTodos, 0.0001);

        }
        [TestMethod]
        public void DeveEntenderLeilaoComValoresDescrescentes()
        {
            Usuario u1 = new Usuario("Jose");
            Usuario u2 = new Usuario("Maria");

            Leilao leilao = new Leilao("PlayStation 3");

            leilao.Propoe(new Lance(u1, 400));
            leilao.Propoe(new Lance(u2, 300));
            leilao.Propoe(new Lance(u1, 200));
            leilao.Propoe(new Lance(u2, 100));

            Avaliador avaliador = new Avaliador();
            avaliador.Avalia(leilao);

            Assert.AreEqual(400, avaliador.MaiorDeTodos, 0.0001);
            Assert.AreEqual(100, avaliador.MenorDeTodos, 0.0001);

        }
        [TestMethod]
        public void DeveEncontrarOsTresMaiores()
        {
            Usuario u1 = new Usuario("Jose");
            Usuario u2 = new Usuario("Maria");

            Leilao leilao = new Leilao("PlayStation 3");

            leilao.Propoe(new Lance(u1, 400));
            leilao.Propoe(new Lance(u2, 300));
            leilao.Propoe(new Lance(u1, 200));
            leilao.Propoe(new Lance(u2, 100));
            leilao.Propoe(new Lance(u1, 500));


            Avaliador avaliador = new Avaliador();
            avaliador.Avalia(leilao);
            var lista = avaliador.TresMaiores;

            Assert.AreEqual(3, avaliador.TresMaiores.Count);
            Assert.AreEqual(500, lista[0].Valor, 0.0001);
            Assert.AreEqual(400, lista[1].Valor, 0.0001);
            Assert.AreEqual(300, lista[2].Valor, 0.0001);

        }
        [TestMethod]
        public void DeveDevolverApenasDoisLances()
        {
            Usuario u1 = new Usuario("Jose");
            Usuario u2 = new Usuario("Maria");

            Leilao leilao = new Leilao("PlayStation 3");

            leilao.Propoe(new Lance(u1, 400));
            leilao.Propoe(new Lance(u1, 500));


            Avaliador avaliador = new Avaliador();
            avaliador.Avalia(leilao);
            var lista = avaliador.TresMaiores;

            Assert.AreEqual(2, avaliador.TresMaiores.Count);
            Assert.AreEqual(500, lista[0].Valor, 0.0001);
            Assert.AreEqual(400, lista[1].Valor, 0.0001);
            

        }
        [TestMethod]
        public void DeveDevolverListaVazia()
        {
            Usuario u1 = new Usuario("Jose");
            Usuario u2 = new Usuario("Maria");

            Leilao leilao = new Leilao("PlayStation 3");

            Avaliador avaliador = new Avaliador();
            avaliador.Avalia(leilao);
            var lista = avaliador.TresMaiores;

            Assert.AreEqual(0, avaliador.TresMaiores.Count);
        }



        [TestMethod]
        public void DeveVerificarSeAFraseEPalindromo()
        {
            Palindromo frase = new Palindromo();

            var resultado = frase.EhPalindromo("Anotaram a data da maratona");

            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void DeveTestarMultiplicacaoPor4()
        {
            MatematicaMaluca math = new MatematicaMaluca();
            Assert.AreEqual(160, math.ContaMaluca(40));
        }
        [TestMethod]
        public void DeveTestarMultiplicacaoPor3()
        {
            MatematicaMaluca math = new MatematicaMaluca();
            Assert.AreEqual(60, math.ContaMaluca(20));
        }
        [TestMethod]
        public void DeveTestarMultiplicacaoPor2()
        {
            MatematicaMaluca math = new MatematicaMaluca();           
            Assert.AreEqual(10, math.ContaMaluca(5));

        }

        
    }
}
