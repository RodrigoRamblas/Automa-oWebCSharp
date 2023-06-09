<h1 align="center">  Automação Web Selenium </h1>

## ![image](https://user-images.githubusercontent.com/50155338/227587087-4a8f23f6-50d4-4bac-b281-e346842215a3.png)


#### Este projeto é uma automação do site https://ramblasassessoria.com/ com as melhores práticas de código limpo e automação Web.

## Pré-requisitos
* Visual Studio
* Selenium WebDriver
* .Net Framework

## Versão do Google Chrome
  * 110.0.5481.104 (Official Build) (32-bit)
  
## Instalação
#### 1. Para instalar o projeto você deve ter o git instalado na sua máquina, você pode baixar o git em 
```
https://git-scm.com/downloads
```
#### 2. Após a instalação do git você pode abrir o Git Bash e executar o comando
```
git clone https://github.com/RodrigoRamblas/Automa-oWebCSharp.git
```
#### 3. Abra o Visual Studio e abra o projeto clonado.
#### 4. Restaure as dependências do projeto via NuGet Package Manager.
#### 5. Configure as variáveis de ambiente do WebDriver.
#### 6. Rode os testes.

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

## Como executar um teste no projeto?
#### 1. Crie um novo teste de unidade clicando com o botão direito do mouse no nome da classe em que deseja criar o teste e selecionando a opção "Adicionar" > "Novo Item".
#### 2. Na janela de adição de novo item, selecione "Teste de Unidade" na lista de modelos e defina um nome para o teste.
#### 3. Para rodar o teste, você pode clicar no botão "Executar Testes" no menu superior da janela de Test Explorer, ou clicar com o botão direito do mouse no nome do teste e selecionar "Executar".
#### 4. Se o teste falhar, o Visual Studio irá exibir uma mensagem de erro e destacar a linha de código que causou a falha.
#### 5. Para depurar o teste, você pode colocar pontos de interrupção (breakpoints) em seu código e rodar o teste em modo de depuração, clicando no botão "Depurar Testes" no menu superior da janela de Test Explorer.
![image](https://user-images.githubusercontent.com/50155338/227557318-976d524d-c7db-4bb1-b872-9a38efffcda9.png)

