create database ajedrez;

create table Pais(
IdPais int auto_increment primary key,
nombre varchar(100),
clubes int);


create table Representa(
IdRepresenta int auto_increment primary key,
PaisRepresentante int,
PaisRepresentado int,
foreign key (PaisRepresentante) references Pais (IdPais) on delete cascade,
foreign key (PaisRepresentado) references Pais (IdPais) on delete cascade);


create table Participante(
IdParticipante int primary key auto_increment,
nombre varchar(100),
direccion varchar(100),
campeonato varchar(100),
telefono varchar(10),
rol varchar(30),
FkPais int,
foreign key (FkPais) references Pais (IdPais) on delete cascade);

create table Jugador(
IdJugador varchar(100) primary key,
FkIdParticipante int,
nivel int,
foreign key (FkIdParticipante) references Participante (IdParticipante));

create table Arbitro(
IdArbitro varchar(100) primary key,
FkIdParticipante int,
foreign key (FkIdParticipante) references Participante (IdParticipante) on delete cascade);

create table Hotel(
Nombre varchar(100) primary key,
Direccion varchar(100),
Telefono varchar(100));

create table Aloja(
IdAloja int auto_increment,
IdParticipante int,
FkHotel varchar(100),
FechaEntrada varchar(100),
FechaSalida varchar(100),
primary key (IdAloja, IdParticipante, FKHotel,FechaEntrada),
foreign key (IdParticipante) references Participante (IdParticipante) on delete cascade,
foreign key (FkHotel) references Hotel (Nombre) on delete cascade);

create table Sala(
IdSala int primary key auto_increment,
Medios varchar(100),
Capacidad int,
FKHotel varchar(100),
foreign key (FKHotel) references Hotel (Nombre) on delete cascade);

create table Partida(
IdPartida int primary key auto_increment,
Fecha varchar(100),
Jugador1 varchar(100),
ColorJugador1 varchar(20),
Jugador2 varchar(100),
ColorJugador2 varchar(20),
Arbitro varchar(100),
FKSala int,
Entradas int,
foreign key (Jugador1) references Jugador (IdJugador) on delete cascade,
foreign key (Jugador2) references Jugador (IdJugador) on delete cascade,
foreign key (Arbitro) references Arbitro (IdArbitro) on delete cascade,
foreign key (FKSala) references Sala (IdSala) on delete cascade);

create table Movimiento(
IdMovimiento int auto_increment,
FKIdPartida int,
Jugada varchar(100),
Movimientos int,
Comentario varchar(100),
primary key (IdMovimiento, FKIdPartida),
foreign key (FKIdPartida) references Partida (IdPartida) on delete cascade);

create table login(
Usuario varchar(20),
Contraseña varchar(20));

insert into login values('Admin','admin');






