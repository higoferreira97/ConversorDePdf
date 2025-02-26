# 📄 Conversor de PDF
Uma API em ASP.NET Core 8 para converter arquivos (Word, imagens, etc.) em PDF de forma gratuita,
sem necessidade de licença ou instalação de bibliotecas adicionais no projeto.

## 🛠️ Tecnologias Utilizadas

➡ ASP.NET Core 8 – Framework principal para a API.<br/>
➡ C# – Implementação da lógica de conversão de arquivos (Helpers e Controllers).<br/>
➡ Docker – Criação de um ambiente isolado para garantir compatibilidade em qualquer servidor.<br/>
➡ LibreOffice – Ferramenta utilizada para conversão de arquivos em PDF via linha de comando.<br/>
➡ Visual Studio – IDE utilizada para desenvolvimento e execução do projeto.<br/>
➡ Docker Desktop – Gerenciamento de contêineres localmente.<br/>

## ⚙️ Como Funciona

Recebimento do arquivo: A API aceita um arquivo via caminho ou bytes.<br/>
Conversão: O arquivo é salvo temporariamente e convertido em PDF usando comandos do LibreOffice.<br/>
Resposta: O arquivo PDF gerado é retornado como resposta da API.<br/>
Execução em Docker: Todo o processo pode ser executado em um contêiner Docker, facilitando a implantação.<br/>

## ✅ Vantagens

✔️ Sem necessidade de bibliotecas pagas.<br/>
✔️ Conversão rápida e eficiente.<br/>
✔️ Fácil implantação via Docker.<br/>

💡 Simples, eficiente e pronto para uso! 🚀
