# AutomacaoWebSelenium
Este projeto é uma automação do site https://ramblasassessoria.com/ com as melhores práticas de código limpo e automação Web.
![image](https://user-images.githubusercontent.com/50155338/227548121-21fec312-3ee5-41bb-b9eb-eef409ddb8b1.png)

## IDE utilizada neste projeto
  * Visual Studio
## Versão do Google Chrome
  * 110.0.5481.104 (Official Build) (32-bit)
  
  ---------------------------------------------------------------------------------------------------------------------
## Como eu faço para baixar o projeto?
### Para baixar o projeto você deve ter o git instalado na sua máquina, você pode baixar o git em 
```
https://git-scm.com/downloads
```
### Após a instalação do git você pode abrir o Git Bash e executar o comando 
```
git clone https://github.com/RodrigoRamblas/Automa-oWebCSharp.git
```
---------------------------------------------------------------------------------------------------------------------

# Conhecendo a estrutura do projeto

## Selenium com C#
#### O Selenium é uma ferramenta de automação de teste de software que permite simular ações do usuário em um navegador web, como clicar em botões, preencher formulários e navegar por diferentes páginas. Quando combinado com C#, o Selenium pode ser usado para criar testes automatizados mais robustos e eficientes.
![image](https://user-images.githubusercontent.com/50155338/227555008-9d534180-bfc1-4b33-b1b3-134b0f1bec7e.png)

## Classes
#### A classe Driver é responsável por inicializar o driver e ter os métodos comuns ao projeto.
![image](https://user-images.githubusercontent.com/50155338/227552430-6111ba61-23b8-4aa0-9655-636adc65c257.png)
#### A classe Helper contém métodos que encapsulam ações comuns de navegação, como clique e preenchimento em elementos de uma página da web. Alguns dos métodos disponíveis na classe incluem ClicarPorId, PreencherPorXpath, NavegarPorUrl, MaximizarNavegador e FecharNavegador.
![image](https://user-images.githubusercontent.com/50155338/227553090-f5b92aa6-8740-4485-91ee-b583ffbb2793.png)
#### A classe Dados é uma classe estática que contém constantes para os elementos da página usados nos testes. Ela define os valores dos IDs, XPaths e Links necessários para localizar e interagir com os elementos da página, como botões, campos de entrada de texto, entre outros.
![image](https://user-images.githubusercontent.com/50155338/227553408-d648f5d9-f93c-4203-98d4-3ad446324c49.png)
#### A classe UnitTest1 utiliza o framework de testes xUnit. A classe possui métodos de teste, que usam um objeto da classe "HelperC" para interagir com o navegador web usando o Selenium WebDriver.
![image](https://user-images.githubusercontent.com/50155338/227553650-9f2da7b2-0268-4cd2-961b-257b789105ee.png)

## Como executar o projeto?
#### O projeto deve ser executado pelo gerenciador de testes do Visual Studio
![image](https://user-images.githubusercontent.com/50155338/227557318-976d524d-c7db-4bb1-b872-9a38efffcda9.png)

