create database proj_ele
use proj_ele

create table candidato
(num_partido int not null primary key,
 nm_partido varchar (45) not null,
 nm_candidato varchar (45) not null,
 foto_candidato varchar (500)  not null);

create table voto
(id_voto int not null primary key identity (0,1),
 num_partido int null,
 constraint candidato_num_partido foreign key (num_partido) references candidato);
