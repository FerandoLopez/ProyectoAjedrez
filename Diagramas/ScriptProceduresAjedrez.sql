DELIMITER //
create procedure p_insertarpais(
in p_idpais int,
in p_nombre varchar(100),
in p_nclubes int
)
BEGIN
	declare existe int default 0;
    select count(*) from pais where nombre = p_nombre into existe;
    if existe < 1 then
		insert into pais values(p_idpais,p_nombre,p_nclubes);
	end if;
END //
DELIMITER ;

DELIMITER //
create procedure p_modificarpais(
in p_idpais int,
in p_nombre varchar(100),
in p_nclubes int
)
BEGIN
	update pais set nombre = p_nombre, clubes = p_nclubes where idpais = p_idpais;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminarpais(
in p_idpais int
)
BEGIN
	delete from pais where IdPais = p_idpais;
END //
DELIMITER ;

DELIMITER //
create procedure p_mostrarpais(
in p_nombre varchar(100)
)
BEGIN
	select * from pais where nombre like concat('%',p_nombre,'%');
END //
DELIMITER ;






DELIMITER //
create procedure p_insertarepresenta(
in p_idrepresenta int,
in p_PaisRepresentante int,
in p_PaisRepresentado int
)
BEGIN
	declare existe int default 0;
    select count(*) from representa where PaisRepresentante = p_PaisRepresentante into existe;
    if existe < 1 then
		insert into representa values(p_idrepresenta,p_PaisRepresentante,p_PaisRepresentado);
	end if;
END //
DELIMITER ;

DELIMITER //
create procedure p_modificarepresenta(
in p_idrepresenta int,
in p_PaisRepresentante int,
in p_PaisRepresentado int
)
BEGIN
	update representa set PaisRepresentante = p_PaisRepresentante, PaisRepresentado = p_PaisRepresentado where idrepresenta = p_idrepresenta;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminarepresenta(
in p_idrepresenta int
)
BEGIN
	delete from representa where idrepresenta = p_idrepresenta;
END //
DELIMITER ;

DELIMITER //
create procedure p_mostrarepresenta(
in p_PaisRepresentante int
)
BEGIN
	select * from representa where PaisRepresentante like concat('%',p_PaisRepresentante,'%');
END //
DELIMITER ;





























DELIMITER //
create procedure p_insertarparticipante(
in p_IdParticipante int,
in p_nombre varchar(100),
in p_direccion varchar(100),
in p_campeonato varchar(100),
in p_telefono varchar(10),
in p_rol varchar(30),
in p_FkidPais int
)
BEGIN
	declare existe int default 0;
    select count(*) from participante where nombre = p_nombre into existe;
    if existe < 1 then
		insert into participante values(p_idparticipante,p_nombre,p_direccion,p_campeonato,p_telefono,p_rol,p_fkidpais);
	end if;
END //
DELIMITER ;


DELIMITER //
create procedure p_modificarparticipante(
in p_IdParticipante int,
in p_nombre varchar(100),
in p_direccion varchar(100),
in p_campeonato varchar(100),
in p_telefono varchar(10),
in p_rol varchar(30),
in p_fkidpais int
)
BEGIN
	update participante set nombre = p_nombre, direccion = p_direccion, campeonato = p_campeonato, telefono = p_telefono, rol = p_rol, fkpais = p_fkidpais where idparticipante = p_idparticipante;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminarparticipante(
in p_idparticipante int
)
BEGIN
	delete from participante where idparticipante = p_idparticipante;
END //
DELIMITER ;

DELIMITER //
create procedure p_mostrarparticipante(
in p_nombre varchar(100)
)
BEGIN
	select * from participante where nombre like concat('%',p_nombre,'%');
END //
DELIMITER ;



DELIMITER //
create procedure p_insertarjugador(
in p_IdJugador varchar(100),
in p_FkIdParticipante int,
in p_Nivel int
)
BEGIN
	declare existe int default 0;
    select count(*) from jugador where FkIdParticipante = p_FkIdParticipante into existe;
    if existe < 1 then
		insert into jugador values(p_idjugador,p_FkIdParticipante,p_nivel);
	end if;
END //
DELIMITER ;


DELIMITER //
create procedure p_modificarjugador(
in p_IdJugador  varchar(100),
in p_FkIdParticipante int,
in p_Nivel int
)
BEGIN
	update jugador set fkidparticipante = p_fkidparticipante, nivel = p_nivel where idjugador = p_idjugador;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminarjugador(
in p_idjugador varchar(100)
)
BEGIN
	delete from jugador where idjugador = p_idjugador;
END //
DELIMITER ;

/*DELIMITER //
create procedure p_mostrarjugador(
in p_idjugador int
)
BEGIN
	select * from jugador where idjugador like concat('%',p_idjugador,'%');
END //
DELIMITER ;*/










DELIMITER //
create procedure p_insertararbitro(
in p_IdArbitro varchar(100),
in p_FkIdParticipante int
)
BEGIN
	declare existe int default 0;
    select count(*) from arbitro where FkIdParticipante = p_FkIdParticipante into existe;
    if existe < 1 then
		insert into arbitro values(p_idarbitro,p_fkidparticipante);
	end if;
END //
DELIMITER ;


DELIMITER //
create procedure p_modificararbitro(
in p_IdArbitro  varchar(100),
in p_FkIdParticipante int
)
BEGIN
	update arbitro set fkidparticipante = p_fkidparticipante where idarbitro = p_idarbitro;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminararbitro(
in p_idarbitro varchar(100)
)
BEGIN
	delete from arbitro where idarbitro = p_idarbitro;
END //
DELIMITER ;

/*DELIMITER //
create procedure p_mostrarjugador(
in p_idjugador int
)
BEGIN
	select * from jugador where idjugador like concat('%',p_idjugador,'%');
END //
DELIMITER ;*/

















DELIMITER //
create procedure p_insertarhotel(
in p_nombre varchar(100),
in p_direccion varchar(100),
in p_telefono varchar(100)
)
BEGIN
	declare existe int default 0;
    select count(*) from hotel where nombre = p_nombre into existe;
    if existe < 1 then
		insert into hotel values(p_nombre,p_direccion,p_telefono);
	end if;
END //
DELIMITER ;

DELIMITER //
create procedure p_modificarhotel(
in p_nombre varchar(100),
in p_direccion varchar(100),
in p_telefono varchar(100)
)
BEGIN
	update hotel set direccion = p_direccion, telefono = p_telefono where nombre = p_nombre;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminarhotel(
in p_nombre varchar(100)
)
BEGIN
	delete from hotel where nombre = p_nombre;
END //
DELIMITER ;

DELIMITER //
create procedure p_mostrarhotel(
in p_nombre varchar(100)
)
BEGIN
	select * from hotel where nombre like concat('%',p_nombre,'%');
END //
DELIMITER ;






DELIMITER //
create procedure p_insertarregistro(
in p_idaloja int,
in p_fkidparticipante int,
in p_fkhotel varchar(100),
in p_fechaentrada varchar(100),
in p_fechasalida varchar(100)
)
BEGIN
	declare existe int default 0;
    select count(*) from aloja where fechaentrada = p_fechaentrada into existe;
    if existe < 1 then
		insert into aloja values(p_idaloja,p_fkidparticipante,p_fkhotel,p_fechaentrada,p_fechasalida);
	end if;
END //
DELIMITER ;


DELIMITER //
create procedure p_modificarregistro(
in p_idaloja int,
in p_fkidparticipante int,
in p_fkhotel varchar(100),
in p_fechaentrada varchar(100),
in p_fechasalida varchar(100)
)
BEGIN
	update aloja set idparticipante = p_fkidparticipante, fkhotel = p_fkhotel,  fechaentrada = p_fechaentrada, fechasalida = p_fechasalida where idaloja = p_idaloja;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminarregistro(
in p_idaloja int
)
BEGIN
	delete from aloja where idaloja = p_idaloja;
END //
DELIMITER ;


DELIMITER //
create procedure p_mostrarregistro(
in p_fechaentrada varchar(100)
)
BEGIN
	select * from aloja where fechaentrada like concat('%',p_fechaentrada,'%');
END //
DELIMITER ;








DELIMITER //
create procedure p_insertarsala(
in p_idsala int,
in p_medios varchar(100),
in p_capacidad int,
in p_fkhotel varchar(100)
)
BEGIN
	declare existe int default 0;
    select count(*) from sala where IdSala = p_idsala into existe;
    if existe < 1 then
		insert into sala values(p_idsala,p_medios,p_capacidad,p_fkhotel);
	end if;
END //
DELIMITER ;

DELIMITER //
create procedure p_modificarsala(
in p_idsala int,
in p_medios varchar(100),
in p_capacidad int,
in p_fkhotel varchar(100)
)
BEGIN
	update sala set  medios = p_medios,  capacidad = p_capacidad, fkhotel = p_fkhotel where idsala = p_idsala;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminarsala(
in p_idsala int
)
BEGIN
	delete from sala where idsala = p_idsala;
END //
DELIMITER ;

DELIMITER //
create procedure p_mostrarsala(
in p_capacidad varchar(100)
)
BEGIN
	select * from sala where capacidad like concat('%',p_capacidad,'%');
END //
DELIMITER ;








DELIMITER //
create procedure p_insertarpartida(
in p_idpartida int,
in p_fecha varchar(100),
in p_jugador1 varchar(100),
in p_colorjugador1 varchar(20),
in p_jugador2 varchar(100),
in p_colorjugador2 varchar(20),
in p_arbitro varchar(100),
in p_idsala int,
in p_entradas int
)
BEGIN
	declare existe int default 0;
    select count(*) from partida where fecha = p_fecha into existe;
    if existe < 1 then
		insert into partida values(p_idpartida,p_fecha,p_jugador1,p_colorjugador1,p_jugador2,p_colorjugador2,p_arbitro,p_idsala,p_entradas);
	end if;
END //
DELIMITER ;

DELIMITER //
create procedure p_modificarpartida(
in p_idpartida int,
in p_fecha varchar(100),
in p_jugador1 varchar(100),
in p_colorjugador1 varchar(20),
in p_jugador2 varchar(100),
in p_colorjugador2 varchar(20),
in p_arbitro varchar(100),
in p_idsala int,
in p_entradas int
)
BEGIN
	update partida set fecha = p_fecha, jugador1 = p_jugador1, colorjugador1 = p_colorjugador1,
    jugador2 = p_jugador2, colorjugador2 = p_colorjugador2, arbitro = p_arbitro, fksala = p_idsala, entradas = p_entradas 
	where idpartida = p_idpartida;
END //
DELIMITER ;

DELIMITER //
create procedure p_eliminarpartida(
in p_idpartida int
)
BEGIN
	delete from partida where idpartida = p_idpartida;
END //
DELIMITER ;

DELIMITER //
create procedure p_mostrarpartida(
in p_fecha varchar(100)
)
BEGIN
	select * from partida where fecha like concat('%',p_fecha,'%');
END //
DELIMITER ;









DELIMITER //
create procedure p_insertarmovimiento(
in p_idmovimiento int,
in p_idpartida int,
in p_jugada varchar(100),
in p_movimiento varchar(100),
in p_comentario varchar(100)
)
BEGIN
	declare existe int default 0;
    select count(*) from movimiento where jugada = p_jugada into existe;
    if existe < 1 then
		insert into movimiento values(p_idmovimiento,p_idpartida,p_jugada,p_movimiento,p_comentario);
	end if;
END //
DELIMITER ;

DELIMITER //
create procedure p_modificarmovimiento(
in p_idmovimiento int,
in p_idpartida int,
in p_jugada varchar(100),
in p_movimiento varchar(100),
in p_comentario varchar(100)
)
BEGIN
	update movimiento set fkidpartida = p_idpartida, jugada = p_jugada, movimientos = p_movimiento, comentario = p_comentario where idmovimiento = p_idmovimiento;
END //
DELIMITER ;

drop procedure p_modificarmovimiento;
DELIMITER //
create procedure p_eliminarmovimiento(
in p_idmovimiento int
)
BEGIN
	delete from movimiento where idmovimiento = p_idmovimiento;
END //
DELIMITER ;

DELIMITER //
create procedure p_mostrarmovimiento(
in p_idmovimiento int
)
BEGIN
	select * from movimiento where idmovimiento like concat('%',p_idmovimiento,'%');
END //
DELIMITER ;





