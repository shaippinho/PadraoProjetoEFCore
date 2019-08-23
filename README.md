# PadraoProjetoEFCore
Padrão de Projetos com EF Core com Fluent API, Repository Pattern

Script do BD utilizado:

################################################

create database TesteEFCore

GO

create table Teste

(

  id_teste int identity primary key,

  ds_valor varchar(100)

)

GO


insert into Teste(ds_valor) values('Valor 1')

GO

insert into Teste(ds_valor) values('Valor 2')

GO

################################################
