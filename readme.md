
# Projeto demo de conexão com banco de dados
> Utilização inicial de ADO.NET e evolução para Dapper

Neste projeto, bem simples, são demonstradas maneiras de conexão com um banco de dados utilizando ADO.NET e evoluindo então o projeto para Dapper. Para exemplificação, utilizei um banco de dados SQL Server em um conteiner Docker e realizei operações básicas de conexão, seleção, insert e update no banco. 

Vale reparar o cuidado tomado na construção dos exemplos do projeto em se utilizar a passagem de parâmetros (SQLParameter) para a execução da instrução SQL, levando-se em conta o risco de SQL Injection quando se utiliza strings concatenadas com parâmetros para sua execução.
