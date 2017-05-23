using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caelum.Leilao;

namespace teste
{
    
    [TestClass]
    public class AvaliadorTest
    {
        Avaliador avaliador;
        CriadorDeLeilao CriadorLeilao;
        Usuario u1;
        Usuario u2;
        Usuario u3;

        [TestInitialize]
        public void Setup()
        {
            this.avaliador = new Avaliador();
            this.CriadorLeilao = new CriadorDeLeilao();
            u1 = new Usuario("Jose");
            u2 = new Usuario("Joao");
            u3 = new Usuario("Maria");
            Console.WriteLine("inicializando teste!");
        }
        
        [TestCleanup]
        public void Finaliza()
        {
            Console.WriteLine("fim");
        }
        
        [TestMethod]
        public void DeveEntenderLeilaoEmOrdemCrescente()
        {
           

            Leilao leilao = CriadorLeilao.Para("PlayStation 3")
                .Lance(u1, 200)
                .Lance(u2, 300)
                .Lance(u3, 400)
                .Cria();

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
            
            Leilao leilao = CriadorLeilao.Para("PlayStation 3")
                .Lance(u1, 200)                
                .Cria();

            avaliador.Avalia(leilao);

            Assert.AreEqual(200, avaliador.MaiorDeTodos);
            Assert.AreEqual(200, avaliador.MenorDeTodos);

        }
        [TestMethod]
        public void DeveEntenderLeilaoComValoresRandomicos()
        {
           Leilao leilao = CriadorLeilao.Para("PlayStation 3")
                .Lance(u1, 200)
                .Lance(u2, 450)
                .Lance(u1, 120)
                .Lance(u2, 700)
                .Lance(u1, 630)
                .Lance(u2, 230)
                .Cria();
           
            avaliador.Avalia(leilao);

            Assert.AreEqual(700, avaliador.MaiorDeTodos, 0.0001);
            Assert.AreEqual(120, avaliador.MenorDeTodos, 0.0001);

        }
        [TestMethod]
        public void DeveEntenderLeilaoComValoresDescrescentes()
        {
            
            Leilao leilao = CriadorLeilao.Para("PlayStation 3")
                .Lance(u1, 400)
                .Lance(u2, 300)
                .Lance(u1, 200)
                .Lance(u2, 100)                
                .Cria();           

            avaliador.Avalia(leilao);

            Assert.AreEqual(400, avaliador.MaiorDeTodos, 0.0001);
            Assert.AreEqual(100, avaliador.MenorDeTodos, 0.0001);

        }
        [TestMethod]
        public void DeveEncontrarOsTresMaiores()
        {
            
            Leilao leilao = CriadorLeilao.Para("PlayStation 3")
                .Lance(u1, 400)
                .Lance(u2, 300)
                .Lance(u1, 200)
                .Lance(u2, 100)
                .Lance(u1, 500)
                .Cria();

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
            
            Leilao leilao = CriadorLeilao.Para("PlayStation 3")
                .Lance(u1, 400)
                .Lance(u2, 500)                
                .Cria();

            avaliador.Avalia(leilao);
            var lista = avaliador.TresMaiores;

            Assert.AreEqual(2, avaliador.TresMaiores.Count);
            Assert.AreEqual(500, lista[0].Valor, 0.0001);
            Assert.AreEqual(400, lista[1].Valor, 0.0001);


        }
        [TestMethod]
        public void DeveDevolverListaVazia()
        {
            
            Leilao leilao = CriadorLeilao.Para("PlayStation 3")
                .Cria();

            avaliador.Avalia(leilao);
            var lista = avaliador.TresMaiores;

            Assert.AreEqual(0, avaliador.TresMaiores.Count);
        }
        //[TestMethod]
        //public void DeveVerificarSeAFraseEPalindromo()
        //{
        //    Palindromo frase = new Palindromo();

        //    var resultado = frase.EhPalindromo("Anotaram a data da maratona");

        //    Assert.AreEqual(true, resultado);
        //}
        //[TestMethod]
        //public void DeveTestarMultiplicacaoPor4()
        //{
        //    MatematicaMaluca math = new MatematicaMaluca();
        //    Assert.AreEqual(160, math.ContaMaluca(40));
        //}
        //[TestMethod]
        //public void DeveTestarMultiplicacaoPor3()
        //{
        //    MatematicaMaluca math = new MatematicaMaluca();
        //    Assert.AreEqual(60, math.ContaMaluca(20));
        //}
        //[TestMethod]
        //public void DeveTestarMultiplicacaoPor2()
        //{
        //    MatematicaMaluca math = new MatematicaMaluca();
        //    Assert.AreEqual(10, math.ContaMaluca(5));

        //}


    }
}
