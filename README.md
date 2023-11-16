# Aplicativo Bancário Simples

Este programa foi desenvolvido como parte de um estudo prático sobre Programação Orientada a Objetos (POO), com foco nos conceitos de **constructors**, **properties**, e **encapsulation** em C#.

## Objetivo

O objetivo principal deste aplicativo é demonstrar a aplicação dos princípios fundamentais de POO em um contexto prático. O programa simula um sistema bancário simples, permitindo a criação de contas bancárias, depósitos, e saques.

## Funcionalidades Principais

- **Criação de Conta Bancária:** O programa permite que o usuário crie uma nova conta bancária fornecendo um número de conta e o nome do titular.

- **Depósito Inicial Opcional:** O usuário pode optar por fazer um depósito inicial ao criar a conta.

- **Depósito e Saque:** A conta bancária permite operações de depósito e saque, demonstrando o princípio de encapsulamento para controlar o acesso aos dados internos da classe.

## Estrutura do Código

O código-fonte está estruturado em duas classes principais:

### 1. Program

A classe `Program` contém o método `Main`, que é o ponto de entrada do programa. Aqui, são solicitadas as informações ao usuário para criar uma conta bancária, demonstrando o uso de constructors e properties.

### 2. ContaBancaria

A classe `ContaBancaria` representa uma conta bancária e encapsula as operações relacionadas a ela. Destacam-se os seguintes pontos:

- **Constructors:** Dois construtores são implementados para permitir a criação de contas com ou sem depósito inicial.

- **Properties:** São utilizadas properties para garantir o encapsulamento e o controle de acesso aos dados da conta.

- **Métodos de Saque e Depósito:** Métodos que representam operações típicas de uma conta bancária, demonstrando a aplicação do encapsulamento.

## Como Executar o Programa

1. Clone o repositório para a sua máquina local.
2. Abra o projeto em um ambiente de desenvolvimento compatível com C# (por exemplo, Visual Studio).
3. Execute o programa.

## Conclusão

Este programa serve como um exemplo simples, mas prático, de como aplicar conceitos de POO em uma aplicação real. O entendimento desses princípios é essencial para o desenvolvimento de software robusto e modular. Experimente e explore as funcionalidades para uma compreensão mais aprofundada!

**Desenvolvido por Deglas0 - 13/11 - 15/11/2023
EOF
