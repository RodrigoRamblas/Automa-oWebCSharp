using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWebSelenium.Dados
{
    public static class DadosPO
    {
        public const string Url = "https://ramblasassessoria.com";

        public const string QA = "id2";
        public const string IrParaOTopo = "//*[@id=\"discover\"]/div/div/div[1]/div/div/a";

        public const string SoliciteOrcamento = "id6";
        public const string Nome = "//*[@id=\"budget\"]/div/div/div[2]/div/form/input[1]";
        public const string Email = "//*[@id=\"budget\"]/div/div/div[2]/div/form/input[2]";
        public const string Numero = "//*[@id=\"telefone\"]";
        public const string Mensagem = "//*[@id=\"budget\"]/div/div/div[2]/div/form/textarea";
        public const string Enviar = "//*[@id=\"budget\"]/div/div/div[2]/div/form/button";
        public const string VoltarAoTopo = "//*[@id=\"root\"]/div[1]";
    }
}
