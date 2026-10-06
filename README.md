# ComissaoVendas

Projeto desenvolvido em **C#** para cálculo de comissão de vendas por vendedor, utilizando **Programação Orientada a Objetos (POO)** e **testes unitários com xUnit**.

## 📋 Sobre o projeto

O sistema realiza o cálculo da comissão de cada venda de acordo com o valor vendido:

| Valor da venda             | Comissão |
| -------------------------- | -------: |
| Menor que R$ 100,00        |       0% |
| De R$ 100,00 até R$ 499,99 |       1% |
| A partir de R$ 500,00      |       5% |

Além disso, o sistema agrupa as vendas por vendedor e calcula a comissão total de cada um.

## 🛠️ Tecnologias utilizadas

* C#
* .NET
* Programação Orientada a Objetos (POO)
* xUnit
* Testes unitários

```

## 🚀 Como executar o projeto

### 1. Clone o repositório

Clone o projeto utilizando:

```bash
git clone URL_DO_REPOSITORIO
```

Depois, entre na pasta do projeto:

```bash
cd DesafioTarget
```

### 2. Execute a aplicação

Entre na pasta `ComissaoVendas`:

```bash
cd ComissaoVendas
```

Execute:

```bash
dotnet run
```

A aplicação será compilada e executada pelo terminal.

## 🧪 Como executar os testes

Para executar os testes unitários, entre na pasta:

```bash
cd ComissaoVendas.Tests
```

Execute:

```bash
dotnet test
```

O comando irá compilar o projeto de testes e executar todos os testes automatizados utilizando **xUnit**.

## ✅ Testes unitários

Os testes validam principalmente:

* Comissão para vendas abaixo de R$ 100,00;
* Comissão de 1% para vendas entre R$ 100,00 e R$ 499,99;
* Comissão de 5% para vendas a partir de R$ 500,00;
* Valores de fronteira, como R$ 100,00 e R$ 500,00;
* Cálculo da comissão agrupada por vendedor;
* Cenário sem vendas.

## 🎯 Objetivo

O projeto tem como objetivo demonstrar a implementação de uma regra de negócio em **C#**, utilizando boas práticas de organização de código e **testes unitários automatizados** para garantir o comportamento esperado da aplicação.
