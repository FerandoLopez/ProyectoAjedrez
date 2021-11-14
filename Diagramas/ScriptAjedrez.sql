create database Ajedrez;

create table pais(
idpais int primary key auto_increment,
nombre varchar(100),
nclubes int,
fkidpais int,
foreign key (fkidpais) references pais (idpais)
on delete cascade);

create table participante(
idparticipante int primary key auto_increment,
nombre varchar(100),
direccion varchar(100),
telefono varchar(100),
campeonato varchar(100),
rol varchar(100),
fkidpais int,
foreign key (fkidpais) references pais (idpais));

create table color(
idcolor int primary key auto_increment,
nomb_color varchar(100),
fkidparticipante int,
foreign key (fkidparticipante) references participante (idparticipante),
fkidpartida int,
foreign key (fkidpartida) references partidas (idpartida));

create table hotel(
idhotel int primary key not null auto_increment,
nombre varchar(100),
direccion varchar(100),
telefono int);

create table registro(
idregistro int primary key auto_increment,
fecha_entrada varchar(100),
fecha_salida varchar(100),
fkidparticipante int,
fkidhotel int,
foreign key (fkidparticipante) references participante (idparticipante),
foreign key (fkidhotel) references hotel (idhotel));

create table salas(
idsala int primary key auto_increment,
codigo_sala varchar(100),
capacidad varchar(100),
medios varchar(100),
fkidhotel int,
foreign key (fkidhotel) references hotel (idhotel) on delete cascade);

create table partidas(
idpartida int primary key auto_increment,
codigo_partida varchar(100),
jornada varchar(100),
fkidparticipante1 int,
foreign key (fkidparticipante1) references participante (idparticipante),
fkidparticipante2 int,
foreign key (fkidparticipante2) references participante (idparticipante));

create table movimientos(
idmovimiento int,
idpartida int,
jugada varchar(100),
movimiento varchar(100),
comentario varchar(100),
fkidpartida int,
foreign key (fkidpartida) references partidas (idpartida) on delete cascade,
primary key auto_increment(idmovimiento, idpartida));