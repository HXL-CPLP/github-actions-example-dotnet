# Programma exemplum .NET
**_Um_ exemplo de como estruturar aplicação .NET com integração com
[GitHub Actions](https://docs.github.com/pt/actions) e testes unitários**.
Veja <https://github.com/HXL-CPLP/forum/issues/61>.

<!--
Trivia:
- programma, https://en.wiktionary.org/wiki/programma#Latin
- exemplum, https://en.wiktionary.org/wiki/exemplum#Latin
-->

---

**Índice de conteúdo**

<!-- TOC -->

- [Programma exemplum .NET](#programma-exemplum-net)
    - [Documentação](#documentação)
        - [Limitações explícitas](#limitações-explícitas)
        - [Documentação por plataforma de desenvolvimento](#documentação-por-plataforma-de-desenvolvimento)
            - [Android (termux)](#android-termux)
            - [Linux-like](#linux-like)
            - [Online](#online)
            - [Windows-like](#windows-like)
        - [Referências adicionais](#referências-adicionais)
    - [Licença](#licença)

<!-- /TOC -->
---


## Documentação

### Limitações explícitas

- **Os _entregáveis_ deste repositório estão principalmente na
  pasta [.github/workflows](.github/workflows)**
- **Explicitamente, a forma como os códigos em C# foram usadas aqui são mais
  simples do que seria usado em produção**
- (...)

> TODO: dividir em subdiretórios (talvez mais de uma aplicação)

> TODO: talvez fazer testes com ao menos uma aplicação GUI

### Documentação por plataforma de desenvolvimento
> Nota: a maior parte do rascunho aqui foi baseado em
> <https://docs.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code>
> e testado em Ubuntu 20.04, o que implica que possivelmente é aplicável em
> outras plataformas.

#### Android (termux)

```bash
# _[por-Latn]
# Pergunta: é possível fazer bootstrapping de aplicação .NET usando
# Android (termux)?
# Editar aplicação DEPOIS de todo pipeline pronto online certamente é
# (já que pessoa poderia usar até GitHub web).
# TODO: https://github.com/EticaAI/inclusao-digital
# [por-Latn]_

```

#### Linux-like
```bash
#### programma-exemplum-dotnet: Linux
# @see https://docs.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code

### VSCode install
# @see https://code.visualstudio.com/download
# @see https://snapcraft.io/code

### .NET setup _________________________________________________________________
# @see https://docs.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu
cd /tmp
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb


sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0

### Bootstrapping template _____________________________________________________
# _[por-Latn]
# Este comando vai criar mais arquivos do que os que estão commitados no
# GitHub
# [por-Latn]_
dotnet new console --framework net5.0

### dotnet build _______________________________________________________________
dotnet build

### run ________________________________________________________________________
## historiam/v0/Program.cs.bak .................................................
dotnet run
# > Hello World!

## historiam/v1/Program.cs.bak .................................................

## historiam/v1/Program.cs.cs.bak ..............................................
# Edit Program.cs (backup at versions/v1/Program.cs)
dotnet run
# > What is your name?
# $ rocha
# >
# > Hello, rocha, on 23/10/2021 at 15:59!
# Press any key to exit...


### publishing-with-visual-studio-code _________________________________________
# @see https://docs.microsoft.com/pt-br/dotnet/core/tutorials/publishing-with-visual-studio-code
dotnet publish --configuration Release
```

#### Online

> TODO:
> - https://vscode.dev/ (?)
> - https://github.dev/ (?)

#### Windows-like

```bash
# @see https://docs.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code

# TODO: windows
```

### Referências adicionais

- **Automation**
  - **GitHub Actions**
    - https://docs.github.com/pt/actions
  - **.NET GitHub Action**
    - https://github.com/actions/setup-dotnet
- **Code**
  - **Documentação do .NET (oficial)**
      - https://docs.microsoft.com/pt-br/dotnet/
      - **Avançado, testes**
        - https://docs.microsoft.com/pt-br/dotnet/core/testing/
        - https://docs.microsoft.com/pt-br/dotnet/core/tools/dotnet-test
        - https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices
        - https://github.com/dariusz-wozniak/List-of-Testing-Tools-and-Frameworks-for-.NET
    - **.NET Linux, Ubuntu**
      - https://docs.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu
  - **Guias Rápidos**
    - https://docs.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code
  - **Code Templates**
    - https://github.com/topics/dotnet-template
- **IDE**
  - **VSCode**
    - **Extensions**:
      - https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp


## Licença

[![Dominium publicum](https://i.creativecommons.org/p/zero/1.0/88x31.png)](https://unlicense.org/)

Licentiam: [Dominium publicum](https://unlicense.org/).