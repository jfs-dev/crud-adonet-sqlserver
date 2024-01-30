# crud-adonet-sqlserver
Operações CRUD com SQL Server rodando no Docker Desktop usando ADO.NET para acesso a dados

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

## Sobre o projeto
Este projeto mostra como executar operações CRUD em um banco de dados SQL Server rodando no Docker usando ADO.NET para acesso a dados.

ADO.NET fornece uma camada de baixo nível para interagir com bancos de dados relacionais sem a abstração adicional oferecida por tecnologias ORM (Object-Relational Mapping) como o Entity Framework.

Ao utilizar ADO.NET, os desenvolvedores têm mais controle direto sobre as operações de banco de dados, o que pode ser benéfico em casos em que o desempenho é uma prioridade ou quando se precisa de uma manipulação de dados mais específica e detalhada.

**SqlConnection:** A classe SqlConnection representa uma conexão física com um banco de dados SQL Server. Ela é usada para abrir, fechar e gerenciar a conexão com o banco de dados.

**SqlCommand:** A classe SqlCommand representa uma instrução SQL ou uma stored procedure que será executada no banco de dados. Ela é usada para executar consultas, comandos de atualização, inserção, exclusão e outras operações no banco de dados.

**SqlDataReader:** A classe SqlDataReader é usada para ler um fluxo de dados de uma consulta SQL executada no banco de dados. Ela permite iterar sobre as linhas retornadas pela consulta.

<div align="center">
    <img src="https://github.com/jfs-dev/crud-adonet-sqlserver/assets/54154628/655ef91e-7b85-4810-85c6-f0c608b61f63"</img>
    <img src="https://github.com/jfs-dev/crud-adonet-sqlserver/assets/54154628/4a58bc4a-3065-4a80-a6e5-2d676ddfdba9"</img>
</div>

Com o Docker Desktop instalado no Windows + WSL habilitado, siga os seguintes passos através do CLI:

1. Obter a imagem do SQL Server através do comando: <code>docker pull mcr.microsoft.com/mssql/server</code>

2. Configurar e executar o SQL Server através do comando: <code>docker run -v ~/docker --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=1q2w3e4r@#$" -p 1433:1433 -d mcr.microsoft.com/mssql/server</code>

<div align="center">
    <img src="https://github.com/jfs-dev/crud-adonet-sqlserver/assets/54154628/aa1809b3-b299-4654-8908-4723564e2266"</img>
</div>

## Referências
https://learn.microsoft.com/pt-br/dotnet/framework/data/adonet/

https://learn.microsoft.com/pt-br/sql/connect/ado-net/introduction-microsoft-data-sqlclient-namespace?view=sql-server-ver16

https://learn.microsoft.com/en-us/azure-data-studio/

https://www.docker.com/

https://hub.docker.com/

https://balta.io/artigos/docker-instalacao-configuracao-e-primeiros-passos/

https://balta.io/blog/sql-server-docker/

## Licença
GPL-3.0 license
