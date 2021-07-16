create database proyectoProg3;

use  proyectoProg3;

create table trabajos (
trabajo_id int identity (1,1),
ubicacion varchar(60),
posicion varchar(60),
compañia varchar (60));

--vemos los campos
select * from  trabajos;

--insertamos datos para la tabla 
insert into trabajos (ubicacion,posicion,compañia) values ('Santo Domingo de Guzman','Angular Developer','Newtech S.R.L');
insert into trabajos (ubicacion,posicion,compañia) values ('Santo Domingo de Guzman','Data Analyst	','PedidosYa');
insert into trabajos (ubicacion,posicion,compañia) values ('Santo Domingo de Guzman','Technical Lead','Newtech S.R.L');
insert into trabajos (ubicacion,posicion,compañia) values ('Santo Domingo de Guzman ','Software Developer','GlowTouch Technologies');
insert into trabajos (ubicacion,posicion,compañia) values ('Santo Domingo de Guzman','Go developer ','Toptal');
insert into trabajos (ubicacion,posicion,compañia) values ('Santo Domingo de Guzman','Java Software Developer ','Navivo Technology Solutions');
insert into trabajos (ubicacion,posicion,compañia) values ('Santo Domingo de Guzman','Senior Fulls Stack Developer','Media Revolution S.R.L');

--vemos los campos
 select * from  trabajos;

 --agregamos primary key 

 alter table trabajos add constraint pk_trabajosId primary key(trabajo_id);