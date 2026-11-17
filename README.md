<h3 align="center"> <img src="https://raw.githubusercontent.com/felip3fl/felip3fl/d3fc7831c647a88ff79c6d6d8f1041014bb71028/Material/FL/FLmetroDefault.svg" width="160px" align="center" ><BR><BR>FLex Tools
<BR><BR>
  <img src="https://img.shields.io/badge/STATUS-EM%20DESENVOLVIMENTO-ff265c" alt="Status: em desenvolvimento">
  <img src="https://img.shields.io/badge/PROJECT%20VERSION-1.25.01.29-ff262f" alt="Project version: 1.25.01.29">
<BR><BR>
</h3>

## 📃 Descrição do projeto

<p align="justify">
FLex Tools é uma coleção de utilitários desenvolvidos em C# para executar tarefas rápidas no Windows. O projeto reúne uma aplicação de console com ferramentas para gerar documentos de identificação fictícios, criar GUIDs e transformar o texto da área de transferência, além de um projeto WinUI 3 em desenvolvimento para dividir arquivos de texto.
</p>

<br>

## :hammer: Funcionalidades do projeto

- `Funcionalidade 1`: Gerar um CPF fictício com dígitos verificadores calculados.
- `Funcionalidade 2`: Gerar um CNPJ fictício com dígitos verificadores calculados.
- `Funcionalidade 3`: Gerar um GUID usando `Guid.NewGuid()`.
- `Funcionalidade 4`: Transformar o texto da área de transferência em formato *Title Case* (iniciais das palavras em maiúsculas, conforme a cultura `en-US`).
- `Funcionalidade 5`: Projeto `SplitFile` com interface WinUI 3 para selecionar um arquivo e configurar a quantidade de partes e o sufixo. A interface ainda é um protótipo: a ação de execução não realiza a divisão do arquivo.

As opções da aplicação de console podem ser informadas por argumento ou selecionadas pelo menu exibido ao iniciar o programa. Os valores gerados e o texto transformado são exibidos no console e copiados para a área de transferência.

<br>

## 📁 Acesso ao projeto

O código-fonte está organizado nas seguintes pastas e arquivos principais:

- `FLexTools/`: aplicação de console e suas ferramentas.
  - `Program.cs`: menu, seleção das operações e integração com a área de transferência.
  - `Tools/CPF.cs`: geração de CPF.
  - `Tools/CNPJ.cs`: geração de CNPJ.
  - `Tools/GUID.cs`: geração de GUID.
  - `Tools/Uppercase.cs`: transformação de texto em *Title Case*.
  - `Tools/Snippet.cs`: utilitário para converter trechos de código em texto formatado para snippets do Visual Studio Code.
- `SplitFile/`: aplicação gráfica WinUI 3, atualmente em estágio inicial.
- `FLexTools.sln`: solução do Visual Studio que reúne os dois projetos.
- `Material/` e `Script/`: recursos e arquivos auxiliares do repositório.

<br>

## 🛠️ Abrir e rodar o projeto

1. Instale o **Visual Studio 2022** ou uma versão compatível com os SDKs utilizados pelos projetos.
2. Abra o arquivo `FLexTools.sln`.
3. Restaure os pacotes NuGet e selecione o projeto que deseja executar:
   - `FLexTools`: aplicação de console direcionada ao **.NET 8 para Windows**.
   - `SplitFile`: aplicação WinUI 3 direcionada ao **.NET 10 para Windows 10 (build 19041 ou superior)**.
4. Execute o projeto selecionado pelo Visual Studio.

Na aplicação `FLexTools`, é possível informar uma opção como argumento ao iniciar ou executar sem argumentos para abrir o menu interativo. As opções textuais disponíveis são `CPF` (`CP`), `CNPJ` (`CN`), `GUID` (`GU`) e `UPPERCASE` (`UPPER` ou `UP`). A operação `UPPERCASE` transforma o conteúdo textual que já estiver copiado para a área de transferência; portanto, é necessário que exista texto disponível no clipboard.

<br>  

## ✔️ Técnicas e tecnologias utilizadas
<p align="justify">
<img width="80" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" alt="C#">
&nbsp;&nbsp;<img width="80" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" alt=".NET">
&nbsp;&nbsp;<img width="80" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/git/git-original.svg" alt="Git">
&nbsp;&nbsp;<img width="80" src="https://raw.githubusercontent.com/felip3fl/felip3fl/1a6a66b6a143aab342cf2df18f56d8c1c7e6c8fb/Material/Icon/visual-studio.svg" alt="Visual Studio">
&nbsp;&nbsp;<img width="80" src="https://raw.githubusercontent.com/felip3fl/felip3fl/1a6a66b6a143aab342cf2df18f56d8c1c7e6c8fb/Material/Icon/vscode.svg" alt="Visual Studio Code">
</p>

- `C#`
- `.NET 8` (FLexTools)
- `.NET 10` e `Windows App SDK 1.8` (SplitFile)
- `WinUI 3`
- `Windows Forms` (suporte à integração com a área de transferência)
- `TextCopy 6.2.1`
- `Microsoft.Windows.SDK.BuildTools 10.0.26100.7175`
- `Paradigma de orientação a objetos`
- `Visual Studio`

<br>  

## Autor

| [<img src="https://github.com/felip3fl/felip3fl/blob/main/Material/Nick/nick1.jpg?raw=true" width=115><br><sub>Felipe Lima</sub>](https://github.com/felip3fl) | 
| :---: 

<br>

## Licença

<i><h6>Todos os direitos reservados. O autor permite apenas a visualização do código, sendo proibida qualquer utilização do mesmo, no todo ou em parte.</h6></i>
