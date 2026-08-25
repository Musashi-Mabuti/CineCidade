# CineCidade

Sistema de venda de ingressos para a rede de cinemas CineCidade, desenvolvido em C# utilizando uma aplicação Console.

## Objetivo

O sistema calcula o valor final da compra de ingressos, aplicando desconto por cupom e verificando a elegibilidade do cliente para a sessão noturna.

## Funcionalidades

- Solicitação do nome do cliente
- Solicitação da quantidade de ingressos
- Solicitação do cupom de desconto
- Solicitação da idade do cliente
- Cálculo do custo bruto
- Aplicação de 10% de desconto com o cupom `CINEMA10`
- Cálculo do valor final da compra
- Formatação do nome do cliente em letras maiúsculas
- Verificação da elegibilidade para sessão noturna

## Regras

### Custo bruto

- Taxa de conveniência: R$ 5,00
- Cada ingresso: R$ 25,00

### Desconto

O cupom `CINEMA10` concede 10% de desconto sobre o custo bruto.

O cupom não diferencia letras maiúsculas de minúsculas.

### Sessão noturna

O cliente é elegível quando:

- A quantidade de ingressos é maior que 1
- A idade é maior ou igual a 18 anos

## Tecnologias

- C#
- .NET
- Visual Studio
- Aplicação Console

## Exemplo

```text
Digite o nome do cliente: João
Digite a quantidade de ingressos: 2
Digite o cupom de desconto: CINEMA10
Digite a idade do cliente: 20

===== CINECIDADE =====
Cliente: JOÃO
Valor bruto: R$ 55,00
Valor final: R$ 49,50
Elegível para Sessão Noturna: True