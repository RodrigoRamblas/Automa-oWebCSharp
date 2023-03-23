using OpenQA.Selenium;
using Xunit;
using AutomacaoWebSelenium;
using AutomacaoWebSelenium.Helper.HelperC;
using System;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;
using AutomacaoWebSelenium.Dados;

namespace AutomacaoWebSelenium.Test
{
    public class UnitTest1
    {
        HelperC hel = new HelperC();

        [Theory]
        [InlineData(DadosPO.Url)]
        public void AcessarOSite(string url)
        {
            hel.NavegarPorUrl(url);
            hel.MaximizarNavegador();
            hel.FecharNavegador();
        }

        [Theory]
        [InlineData(DadosPO.Url, DadosPO.QA, DadosPO.IrParaOTopo)]
        public void ClicarNoBotaoQA(string url, string qa, string irParaOTopo)
        {
            hel.NavegarPorUrl(url);
            hel.MaximizarNavegador();
            hel.ClicarPorId(qa); 
            hel.ClicarPorXpath(irParaOTopo);
            hel.FecharNavegador();
        }

        [Theory]
        [InlineData(DadosPO.Url, DadosPO.SoliciteOrcamento, DadosPO.Nome, DadosPO.Email, DadosPO.Numero, DadosPO.Mensagem, DadosPO.Enviar, DadosPO.VoltarAoTopo)]
        public void SolicitarOrcamento(string url, string soliciteOrcamento, string nome, string email, string numero, string mensagem, string enviar, string voltarAoTopo)
        {
            hel.NavegarPorUrl(url);                                                   //inicia o navegador
            hel.MaximizarNavegador();                                                 //deixa o navegador em tela cheia
            hel.ClicarPorId(soliciteOrcamento);                                       //clica em solicitar orçamento
            hel.PreencherPorXpath(nome, "Rosangela");                                 //preenche o nome
            hel.PreencherPorXpath(email, "rose.meire@hotmail.com");                   //preenche o email
            hel.PreencherPorXpath(numero, "11996573127");                             //preenche o numero
            hel.PreencherPorXpath(mensagem, "desejo realizar um orçamento");          //preenche a mensagem
            hel.ClicarPorXpath(enviar);                                               //clica no botão enviar
            hel.ClicarPorXpath(voltarAoTopo);                                         //clica no botão voltar ao topo
            hel.FecharNavegador();                                                    //fecha o navegador
        }

    }
}