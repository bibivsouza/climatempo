## Aplicação Climatempo
## Autor: Bianca Vilela de Souza - 18/10/2019 
## Solicitante Stefanini

## Desafio - Mobile Development
## Desenvolvimento App Xamarin - Climatempo

Proposta: Desenvolver uma aplicação híbrida onde o usuário poderá selecionar determinada cidades dentro de uma lista, podendo ver respectivas informações de clima. 
 
 ## Detalhes técnicos:  */
 
 • Linguagem: Java / Kotlin (Android), Objective-C / Swift (iOS) ou C#(Xamarin). 
 • Tests: Testes automatizados serão bem vindos. 
 • Seguindo o critério de aceite, o comportamento do aplicativo e disposição do layout será a gosto do desenvolvedor. 
 • Documentação da API: https://openweathermap.org 
 • Exemplo de chamada da API: http://api.openweathermap.org/data/2.5/weather?id=3470127&appid=2bac87e0cb16557bf f7d4ebcbaa89d2f&lang=pt&units=metric 
 • Chave da API:2bac87e0cb16557bff7d4ebcbaa89d2f  

## Critérios de aceite: */
 
 • O aplicativo deverá consumir dados do serviço openweathermap.org, para exibição dos dados de clima; 
 • O aplicativo deverá usar o arquivo JSON (city.list.json) para exibição das cidades que podem ser pesquisadas na API; 
 • Os dados de cidades como favorito, devem ser persistidos usando SQLite; 
 • O aplicativo deverá conter no mínimo três telas
 
 ## Observações: Desenvolvedor */
  
  Diante o desafio de desenvolver o aplicativo em 48h, foram verificados alguns pontos onde, se houvesse um tempo maior, poderiam ter sido tratados.
  Tais como:
  - delecao da cidade no SQlite, retirando ela dos favoritos;
  - um tempo dedicado para estudar como emular apps Android de uma forma menos lenta, ganhado em produtividade;
  - tratamento de sincronismo das theads
  - inclusão de imagens e de um elemento loading...
  - melhora de desdign o tornando mais intuitivo
  - refatoração de código e arquitetura
  - inserção de comentários
  - validações
  - inserção de imagens
  
## Uso de Bibliotecas: */
  Foram utilizadas bibliotecas tais como 
  - NewtonSoft.Json - para manipulação de objeto json.
  - SQLite-NET - criação e utilização de sgbd
  - API - https://openweathermap.org 
