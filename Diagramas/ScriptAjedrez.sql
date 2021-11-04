create database Ajedrez;

create table pais(
idpais int primary key,
nombre varchar(100),
nclubes int,
fkidpais int,
foreign key (fkidpais) references pais (idpais)
on delete cascade);

create table participante(
idparticipante int primary key,
nombre varchar(100),
direccion varchar(100),
telefono varchar(100),
campeonato varchar(100),
rol varchar(100),
fkidpais int,
foreign key (fkidpais) references pais (idpais));

create table color(
idcolor int primary key,
nomb_color varchar(100),
fkidparticipante int,
foreign key (fkidparticipante) references participante (idparticipante),
fkidpartida int,
foreign key (fkidpartida) references partidas (idpartida));

create table hotel(
idhotel int primary key not null,
nombre varchar(100),
direccion varchar(100),
telefono int);

create table registro(
idregistro int primary key,
fecha_entrada varchar(100),
fecha_salida varchar(100),
fkidparticipante int,
fkidhotel int,
foreign key (fkidparticipante) references participante (idparticipante),
foreign key (fkidhotel) references hotel (idhotel));

create table salas(
idsala int primary key,
codigo_sala varchar(100),
capacidad varchar(100),
medios varchar(100),
fkidhotel int,
foreign key (fkidhotel) references hotel (idhotel) on delete cascade);

create table partidas(
idpartida int primary key,
codigo_partida varchar(100),
jornada varchar(100),
fkidparticipante int,
foreign key (fkidparticipante) references participante (idparticipante));

create table movimiento(
idmovimiento int,
idpartida int,
jugada varchar(100),
movimiento varchar(100),
comentario varchar(100),
fkidpartida int,
foreign key (fkidpartida) references partidas (idpartida) on delete cascade,
primary key(idmovimiento, idpartida));