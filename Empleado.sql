



--El servicio para esta Query nombralo "reportes" porfa, solo esta recibiendo un parametro que es numero de empleado
CREATE PROCEDURE ReportesByIdEmpleado
@idEmpleado INT
AS
BEGIN
SELECT tiempo.id_tiempo,
       tiempo.quincena,
       tiempo.mes,
       tiempo.ano,
       tiempo.horas_asignables,
       tiempo.horas_no_asignables,
       tiempo.total,
       tiempo.envio
FROM   empleado
       LEFT OUTER JOIN tiempo
                    ON empleado.id_empleado = tiempo.empleado
       LEFT OUTER JOIN periodo_mes
                    ON periodo_mes.mes = tiempo.mes
WHERE  empleado.num_empleado = @idEmpleado
ORDER  BY tiempo.ano DESC,
          periodo_mes.id_periodo_mes DESC,
          tiempo.quincena DESC 
		  END

EXEC ReportesByIdEmpleado 1512
--------------------------------------------------------------------------------------------------------
--que el metodo se llame Reporte porfa solo recibe un parametro
SELECT
    administracion.dbo.hora_asignable.id_hora_asignable as 'ID Hora Asignable',
    administracion.dbo.proyecto.id_proyecto as 'ID Proyecto',
    IIF(administracion.dbo.proyecto.clave_proyecto is null,'N/A',administracion.dbo.proyecto.clave_proyecto) as 'Clave',
    administracion.dbo.hora_asignable.uno ,
    administracion.dbo.hora_asignable.dos ,
    administracion.dbo.hora_asignable.tres,
    administracion.dbo.hora_asignable.cuatro ,
    administracion.dbo.hora_asignable.cinco,
    administracion.dbo.hora_asignable.seis,
    administracion.dbo.hora_asignable.siete,
    administracion.dbo.hora_asignable.ocho,
    administracion.dbo.hora_asignable.nueve,
    administracion.dbo.hora_asignable.diez,
    administracion.dbo.hora_asignable.once,
    administracion.dbo.hora_asignable.doce,
    administracion.dbo.hora_asignable.trece,
    administracion.dbo.hora_asignable.catorce,
    administracion.dbo.hora_asignable.quince,
    administracion.dbo.hora_asignable.diez_y_seis,
    administracion.dbo.hora_asignable.total as 'Total',
    administracion.dbo.cliente.nom_cliente as 'Cliente',
    CONCAT(
        administracion.dbo.gerente.nom_gerente,
        ' ',
        administracion.dbo.gerente.apellido
    ) as 'Gerente',
    administracion.dbo.hora_asignable.cuota,
    administracion.dbo.hora_asignable.costo,
    administracion.dbo.hora_asignable.total_cuota,
    administracion.dbo.hora_asignable.total_costo,
    administracion.dbo.cliente.id_cliente,
    administracion.dbo.gerente.id_gerente
FROM
    administracion.dbo.tiempo
LEFT OUTER JOIN administracion.dbo.hora_asignable ON administracion.dbo.tiempo.id_tiempo = administracion.dbo.hora_asignable.tiempo
LEFT OUTER JOIN administracion.dbo.proyecto ON administracion.dbo.proyecto.id_proyecto = administracion.dbo.hora_asignable.proyecto
LEFT OUTER JOIN administracion.dbo.cliente ON administracion.dbo.cliente.id_cliente = administracion.dbo.proyecto.cliente
LEFT OUTER JOIN administracion.dbo.gerente ON administracion.dbo.gerente.id_gerente = administracion.dbo.proyecto.gerente
WHERE   administracion.dbo.tiempo.id_tiempo = 25478
ORDER BY
    administracion.dbo.hora_asignable.id_hora_asignable ASC

GO

CREATE PROCEDURE ReporteByIdTiempo
@Id_Tiempo INT
AS
BEGIN
SELECT
    administracion.dbo.hora_asignable.id_hora_asignable as 'ID Hora Asignable',
    administracion.dbo.proyecto.id_proyecto as 'ID Proyecto',
    IIF(administracion.dbo.proyecto.clave_proyecto is null,'N/A',administracion.dbo.proyecto.clave_proyecto) as 'Clave',
    administracion.dbo.hora_asignable.uno ,
    administracion.dbo.hora_asignable.dos ,
    administracion.dbo.hora_asignable.tres,
    administracion.dbo.hora_asignable.cuatro ,
    administracion.dbo.hora_asignable.cinco,
    administracion.dbo.hora_asignable.seis,
    administracion.dbo.hora_asignable.siete,
    administracion.dbo.hora_asignable.ocho,
    administracion.dbo.hora_asignable.nueve,
    administracion.dbo.hora_asignable.diez,
    administracion.dbo.hora_asignable.once,
    administracion.dbo.hora_asignable.doce,
    administracion.dbo.hora_asignable.trece,
    administracion.dbo.hora_asignable.catorce,
    administracion.dbo.hora_asignable.quince,
    administracion.dbo.hora_asignable.diez_y_seis,
    administracion.dbo.hora_asignable.total as 'Total',
    administracion.dbo.cliente.nom_cliente as 'Cliente',
    CONCAT(
        administracion.dbo.gerente.nom_gerente,
        ' ',
        administracion.dbo.gerente.apellido
    ) as 'Gerente',
    administracion.dbo.hora_asignable.cuota,
    administracion.dbo.hora_asignable.costo,
    administracion.dbo.hora_asignable.total_cuota,
    administracion.dbo.hora_asignable.total_costo,
    administracion.dbo.cliente.id_cliente,
    administracion.dbo.gerente.id_gerente
FROM
    administracion.dbo.tiempo
LEFT OUTER JOIN administracion.dbo.hora_asignable ON administracion.dbo.tiempo.id_tiempo = administracion.dbo.hora_asignable.tiempo
LEFT OUTER JOIN administracion.dbo.proyecto ON administracion.dbo.proyecto.id_proyecto = administracion.dbo.hora_asignable.proyecto
LEFT OUTER JOIN administracion.dbo.cliente ON administracion.dbo.cliente.id_cliente = administracion.dbo.proyecto.cliente
LEFT OUTER JOIN administracion.dbo.gerente ON administracion.dbo.gerente.id_gerente = administracion.dbo.proyecto.gerente
WHERE   administracion.dbo.tiempo.id_tiempo = @Id_Tiempo
ORDER BY
    administracion.dbo.hora_asignable.id_hora_asignable ASC
END
GO

EXEC ReporteByIdTiempo 25478

--Nombre del metodo "gerentesConProyecto"

SELECT gerente.id_gerente                                  AS 'ID',
       Concat (gerente.nom_gerente, ' ', gerente.apellido) AS 'Nombre',
       Sum (proyecto.estatus)                              AS Abierto
FROM   cliente
       INNER JOIN proyecto
               ON cliente.id_cliente = proyecto.cliente
       INNER JOIN gerente
               ON gerente.id_gerente = proyecto.gerente
WHERE  gerente.estatus = 1
GROUP  BY gerente.id_gerente,
          Concat (gerente.nom_gerente, ' ', gerente.apellido)
HAVING Sum (proyecto.estatus) >= 1
ORDER  BY 'Nombre' 
GO

CREATE PROCEDURE GerenteByEstatus
AS
BEGIN
SELECT gerente.id_gerente                                  AS 'ID',
       Concat (gerente.nom_gerente, ' ', gerente.apellido) AS 'Nombre',
       Sum (proyecto.estatus)                              AS Abierto
FROM   cliente
       INNER JOIN proyecto
               ON cliente.id_cliente = proyecto.cliente
       INNER JOIN gerente
               ON gerente.id_gerente = proyecto.gerente
WHERE  gerente.estatus = 1
GROUP  BY gerente.id_gerente,
          Concat (gerente.nom_gerente, ' ', gerente.apellido)
HAVING Sum (proyecto.estatus) >= 1
ORDER  BY 'Nombre' 
END


--Nombre del metodo "clientesPorGerente" solo recibe un parametro "id_gerente"

SELECT cliente.id_cliente     AS 'ID',
       cliente.nom_cliente    AS 'Cliente',
       Sum (proyecto.estatus) AS 'Abierto'
FROM   cliente
       INNER JOIN proyecto
               ON cliente.id_cliente = proyecto.cliente
       INNER JOIN gerente
               ON gerente.id_gerente = proyecto.gerente
WHERE  gerente.id_gerente = 10
GROUP  BY cliente.id_cliente,
          cliente.nom_cliente
HAVING Sum (proyecto.estatus) >= 1
ORDER  BY cliente 
GO


CREATE PROCEDURE clientesPorGerente
@idCliente INT
AS
BEGIN
SELECT cliente.id_cliente     AS 'ID',
       cliente.nom_cliente    AS 'Cliente',
       Sum (proyecto.estatus) AS 'Abierto'
FROM   cliente
       INNER JOIN proyecto
               ON cliente.id_cliente = proyecto.cliente
       INNER JOIN gerente
               ON gerente.id_gerente = proyecto.gerente
WHERE  gerente.id_gerente = @idCliente
GROUP  BY cliente.id_cliente,
          cliente.nom_cliente
HAVING Sum (proyecto.estatus) >= 1
ORDER  BY cliente 
END
GO

EXEC clientesPorGerente 10


--Nombre del metodo ""proyectosPorClienteGerente" recibe 2 parametros  "id_gerente y id_gerente"
SELECT DISTINCT proyecto.id_proyecto    AS 'ID',
                proyecto.clave_proyecto AS 'Nombre'
FROM   cliente
       INNER JOIN proyecto
               ON cliente.id_cliente = proyecto.cliente
       INNER JOIN gerente
               ON gerente.id_gerente = proyecto.gerente
WHERE  gerente.id_gerente = 10
       AND cliente.id_cliente = 2129
       AND proyecto.estatus = 1
ORDER  BY nombre ASC 

GO
CREATE PROCEDURE proyectosPorClienteGerente
@IdGerente INT,
@IdCliente INT
AS
BEGIN
SELECT DISTINCT proyecto.id_proyecto    AS 'ID',
                proyecto.clave_proyecto AS 'Nombre'
FROM   cliente
       INNER JOIN proyecto
               ON cliente.id_cliente = proyecto.cliente
       INNER JOIN gerente
               ON gerente.id_gerente = proyecto.gerente
WHERE  gerente.id_gerente = @IdGerente
       AND cliente.id_cliente = @IdCliente
       AND proyecto.estatus = 1
ORDER  BY nombre ASC 
END
GO

EXEC proyectosPorClienteGerente 10,2129

--Nombre del metodo "horasNoAsignables" solo requiere de un parametro que es el id_tiempo
SELECT hora_no_asignable.id_hora_no_asignable,
       actividad.id_actividad,
       actividad.nom_actividad,
       hora_no_asignable.uno,
       hora_no_asignable.dos,
       hora_no_asignable.tres,
       hora_no_asignable.cuatro,
       hora_no_asignable.cinco,
       hora_no_asignable.seis,
       hora_no_asignable.siete,
       hora_no_asignable.ocho,
       hora_no_asignable.nueve,
       hora_no_asignable.diez,
       hora_no_asignable.once,
       hora_no_asignable.doce,
       hora_no_asignable.trece,
       hora_no_asignable.catorce,
       hora_no_asignable.quince,
       hora_no_asignable.diez_y_seis,
       hora_no_asignable.total,
       hora_no_asignable.cuota,
       hora_no_asignable.costo,
       hora_no_asignable.total_cuota,
       hora_no_asignable.total_costo,
       actividad.descripcion
FROM   tiempo
       INNER JOIN hora_no_asignable
               ON tiempo.id_tiempo = hora_no_asignable.tiempo
       INNER JOIN actividad
               ON actividad.id_actividad = hora_no_asignable.actividad
WHERE  tiempo.id_tiempo = 23147
ORDER  BY hora_no_asignable.id_hora_no_asignable
GO

CREATE PROCEDURE horasNoAsignables
@IdTiempo INT
AS
BEGIN
SELECT hora_no_asignable.id_hora_no_asignable,
       actividad.id_actividad,
       actividad.nom_actividad,
       hora_no_asignable.uno,
       hora_no_asignable.dos,
       hora_no_asignable.tres,
       hora_no_asignable.cuatro,
       hora_no_asignable.cinco,
       hora_no_asignable.seis,
       hora_no_asignable.siete,
       hora_no_asignable.ocho,
       hora_no_asignable.nueve,
       hora_no_asignable.diez,
       hora_no_asignable.once,
       hora_no_asignable.doce,
       hora_no_asignable.trece,
       hora_no_asignable.catorce,
       hora_no_asignable.quince,
       hora_no_asignable.diez_y_seis,
       hora_no_asignable.total,
       hora_no_asignable.cuota,
       hora_no_asignable.costo,
       hora_no_asignable.total_cuota,
       hora_no_asignable.total_costo,
       actividad.descripcion
FROM   tiempo
       INNER JOIN hora_no_asignable
               ON tiempo.id_tiempo = hora_no_asignable.tiempo
       INNER JOIN actividad
               ON actividad.id_actividad = hora_no_asignable.actividad
WHERE  tiempo.id_tiempo = @IdTiempo
ORDER  BY hora_no_asignable.id_hora_no_asignable
END 
GO

EXEC horasNoAsignables 23147

--nombre del metodo "actividadesPorEmpleado" El único parametro es "empleado.id_empleado"
SELECT actividad.id_actividad,
       actividad.nom_actividad,
       actividad.descripcion
FROM   actividad
       INNER JOIN empleado_actividad
               ON actividad.id_actividad = empleado_actividad.id_actividad
       INNER JOIN empleado
               ON empleado.id_empleado = empleado_actividad.id_empleado
WHERE  actividad.estatus = 1
       AND empleado_actividad.estatus = 1
       AND empleado.id_empleado = 131
ORDER  BY actividad.nom_actividad
GO


CREATE PROCEDURE actividadesPorEmpleado
@idEmpleado INT
AS
BEGIN
SELECT actividad.id_actividad,
       actividad.nom_actividad,
       actividad.descripcion
FROM   actividad
       INNER JOIN empleado_actividad
               ON actividad.id_actividad = empleado_actividad.id_actividad
       INNER JOIN empleado
               ON empleado.id_empleado = empleado_actividad.id_empleado
WHERE  actividad.estatus = 1
       AND empleado_actividad.estatus = 1
       AND empleado.id_empleado = @idEmpleado
ORDER  BY actividad.nom_actividad
END
GO

EXEC actividadesPorEmpleado 131

SELECT ano AS 'Año' FROM periodo_ano WHERE estatus_tiempo = 1 UNION ALL SELECT YEAR (GETDATE()) UNION ALL SELECT YEAR (GETDATE()) - 1 ORDER BY 'Año' DESC


----nombre del metodo "Meses"
IF (DATEPART(MONTH, GETDATE()) IN (1))
SELECT id_periodo_mes as 'ID', mes as 'Mes' FROM periodo_mes WHERE id_periodo_mes = 1 OR id_periodo_mes = 12 ORDER BY id_periodo_mes DESC
SELECT TOP 2 id_periodo_mes as 'ID', mes as 'Mes' FROM periodo_mes WHERE estatus = 1 AND id_periodo_mes <= DATEPART( MONTH, getdate()) ORDER BY id_periodo_mes DESC
GO

CREATE PROCEDURE Meses
AS
BEGIN
IF (DATEPART(MONTH, GETDATE()) IN (1))
SELECT id_periodo_mes as 'ID', mes as 'Mes' FROM periodo_mes WHERE id_periodo_mes = 1 OR id_periodo_mes = 12 ORDER BY id_periodo_mes DESC
SELECT TOP 2 id_periodo_mes as 'ID', mes as 'Mes' FROM periodo_mes WHERE estatus = 1 AND id_periodo_mes <= DATEPART( MONTH, getdate()) ORDER BY id_periodo_mes DESC
END


--nombre del metodo "Anios"
SELECT ano AS 'Año'
FROM   periodo_ano
WHERE  estatus_tiempo = 1
UNION ALL
SELECT Year (Getdate())
UNION ALL
SELECT Year (Getdate()) - 1
ORDER  BY 'Año' DESC 
GO

CREATE PROCEDURE Anios
AS
BEGIN
SELECT ano AS 'Año'
FROM   periodo_ano
WHERE  estatus_tiempo = 1
UNION ALL
SELECT Year (Getdate())
UNION ALL
SELECT Year (Getdate()) - 1
ORDER  BY 'Año' DESC 
END

--Login
--GO
--CREATE PROCEDURE Loginuser @num_empleado INT,
--                           @pwd          VARCHAR(50)
--AS
--  BEGIN
--      DECLARE @Correct BIT

--      IF EXISTS(SELECT *
--                FROM   empleado
--                WHERE  num_empleado = @num_empleado
--                       AND pwd = @pwd)
--        BEGIN
--            SELECT nom_empleado,apellido,num_departamento,email,estado FROM empleado WHERE  num_empleado = @num_empleado
--                       AND pwd = @pwd
--        END
--      ELSE
--        BEGIN
--            SET @Correct = 0

--            SELECT @Correct AS 'Correct'
--        END
--  END 


EXEC [LoginUser] 0194,'3132333435'


--CREATE PROCEDURE Loginuser @num_empleado INT,
--                           @pwd          VARCHAR(50)
--AS
--  BEGIN
--      DECLARE @Correct BIT

--      IF EXISTS(SELECT *
--                FROM   empleado
--                WHERE  num_empleado = @num_empleado
--                       AND pwd = @pwd)
--        BEGIN
--            SELECT nom_empleado,apellido,num_departamento,email,estado FROM empleado WHERE  num_empleado = @num_empleado
--                       AND pwd = @pwd
--        END
--      ELSE
--        BEGIN
--            SET @Correct = 0

--            SELECT @Correct AS 'Correct'
--        END
--  END 

--GO
--  CREATE PROCEDURE Loginuser
--  @num_empleado INT,
--  @pwd VARCHAR(50)
--  AS
--  BEGIN
-- SELECT empleado.id_empleado, empleado.num_empleado,empleado.nom_empleado,empleado.apellido, departamento.nom_departamento,empleado.email,empleado.estado from empleado
--INNER JOIN departamento on empleado.num_departamento = departamento.id_departamento
--WHERE empleado.num_empleado = @num_empleado AND empleado.pwd = @pwd
--					   END
--GO
GO
CREATE PROCEDURE [dbo].[Loginuser]
  @num_empleado INT,
  @pwd VARCHAR(50)
  AS
  BEGIN
 SELECT
    empleado.id_empleado,
    empleado.num_empleado,
		empleado.nom_empleado,
		empleado.apellido,
    CONCAT (nom_empleado, ' ', apellido) as 'NombreCompleto',
    empleado.email,
    nivel.id_nivel,
    departamento.id_departamento,
    departamento.nom_departamento,
		empleado.estado,
		empleado.estatus_tiempo,
    nivel.clave_nivel,
    cuota.cuota,  
    cuota.costo
FROM
    empleado
    INNER JOIN nivel ON nivel.id_nivel = empleado.nivel
    INNER JOIN departamento ON departamento.id_departamento= empleado.num_departamento
    LEFT OUTER JOIN cuota ON departamento.id_departamento = cuota.area AND nivel.id_nivel = cuota.nivel
WHERE empleado.num_empleado = @num_empleado AND empleado.pwd = @pwd
					   END

GO

--3 parametros (Quincena, mes, año y numero de empleado)
--Nombre del metodo "existePeriodo"

select COUNT(*) AS 'existePeriodo' from tiempo where quincena= '1' and mes= 'enero' and ano=2022 and empleado=130
GO

CREATE PROCEDURE existePeriodo
@quincena VARCHAR(50),
@mes VARCHAR(50),
@anio INT,
@empleado INT
AS
BEGIN
select COUNT(*) AS 'existePeriodo' from tiempo where quincena= @quincena and mes= @mes and ano=@anio and empleado=@empleado
END
GO

--Insert
CREATE PROCEDURE Registranuevoreporte @quincena               INT,
                                      @mes                    VARCHAR(50),
                                      @anio                   INT,
                                      @totalhorasasignables   INT,
                                      @totalhorasnoasignables INT,
                                      @total                  INT,
                                      @idempleado             INT,
                                      @estatus                BIT,
                                      @envio                  BIT,
                                      @fechareporte           VARCHAR(50)
AS
  BEGIN
      INSERT INTO tiempo
                  (quincena,
                   mes,
                   ano,
                   horas_asignables,
                   horas_no_asignables,
                   total,
                   empleado,
                   estatus,
                   envio,
                   fecha_creacion,
                   fecha_reporte)
      VALUES      (@quincena,
                   @mes,
                   @anio,
                   @totalhorasasignables,
                   @totalhorasnoasignables,
                   @total,
                   @idempleado,
                   @estatus,
                   @envio,
                   GETDATE(),
                   CONVERT(DATE, @fechareporte, 10))
  END

BEGIN
    SELECT @@IDENTITY
END
GO



SELECT * FROM tiempo where id_tiempo = 607
SELECT * FROM hora_asignable where tiempo = 607
SELECT * FROM hora_no_asignable 

SELECT * FROM tiempo INNER JOIN hora_asignable on  hora_asignable.tiempo = tiempo.id_tiempo


EXEC Registranuevoreporte 1,'agosto',2021,55,44,99,130,0,1,'20220829'

DELETE FROM tiempo where id_tiempo = 27739
DELETE FROM hora_asignable where id_hora_asignable >= 143634
GO

CREATE PROCEDURE Registrarhorasasignables @idproyecto INT,
                                          @idtiempo   INT,
                                          @uno        INT,
                                          @dos        INT,
                                          @tres       INT,
                                          @cuatro     INT,
                                          @cinco      INT,
                                          @seis       INT,
                                          @siete      INT,
                                          @ocho       INT,
                                          @nueve      INT,
                                          @diez       INT,
                                          @once       INT,
                                          @doce       INT,
                                          @trece      INT,
                                          @catorce    INT,
                                          @quince     INT,
                                          @diezyseis  INT,
                                          @total      INT,
                                          @cuota      MONEY,
                                          @costo      MONEY,
                                          @totalcuota MONEY,
                                          @totalcosto MONEY
AS
  BEGIN
      INSERT INTO hora_asignable
                  (proyecto,
                   tiempo,
                   uno,
                   dos,
                   tres,
                   cuatro,
                   cinco,
                   seis,
                   siete,
                   ocho,
                   nueve,
                   diez,
                   once,
                   doce,
                   trece,
                   catorce,
                   quince,
                   diez_y_seis,
                   total,
                   cuota,
                   costo,
                   total_cuota,
                   total_costo)
      VALUES      (@idproyecto,
                   @idtiempo,
                   @uno,
                   @dos,
                   @tres,
                   @cuatro,
                   @cinco,
                   @seis,
                   @siete,
                   @ocho,
                   @nueve,
                   @diez,
                   @once,
                   @doce,
                   @trece,
                   @catorce,
                   @quince,
                   @diezyseis,
                   @total,
                   @cuota,
                   @costo,
                   @totalcuota,
                   @totalcosto)
  END 
  GO


SELECT * FROM tiempo --27699
SELECT * FROM hora_no_asignable --40963
SELECT * FROM hora_asignable --143633
SELECT * FROM actividad


INSERT INTO hora_no_asignable
            (actividad,
             tiempo,
             uno,
             dos,
             tres,
             cuatro,
             cinco,
             seis,
             siete,
             ocho,
             nueve,
             diez,
             once,
             doce,
             trece,
             catorce,
             quince,
             diez_y_seis,
             total,
             cuota,
             costo,
             total_cuota,
             total_costo)
VALUES      (id_actividad,
             idtiempo,
             uno,
             dos,
             tres,
             cuatro,
             cinco,
             seis,
             siete,
             ocho,
             nueve,
             diez,
             once,
             doce,
             trece,
             catorce,
             quince,
             diezyseis,
             total,
             cuota,
             costo,
             totalcuota,
             totalcosto) 


GO

CREATE PROCEDURE Registrarhorasnoasignables @id_actividad INT,
                                            @idtiempo     INT,
                                            @uno          INT,
                                            @dos          INT,
                                            @tres         INT,
                                            @cuatro       INT,
                                            @cinco        INT,
                                            @seis         INT,
                                            @siete        INT,
                                            @ocho         INT,
                                            @nueve        INT,
                                            @diez         INT,
                                            @once         INT,
                                            @doce         INT,
                                            @trece        INT,
                                            @catorce      INT,
                                            @quince       INT,
                                            @diezyseis    INT,
                                            @total        INT,
                                            @cuota        MONEY,
                                            @costo        MONEY,
                                            @totalcuota   MONEY,
                                            @totalcosto   MONEY
AS
  BEGIN
      INSERT INTO hora_no_asignable
                  (actividad,
                   tiempo,
                   uno,
                   dos,
                   tres,
                   cuatro,
                   cinco,
                   seis,
                   siete,
                   ocho,
                   nueve,
                   diez,
                   once,
                   doce,
                   trece,
                   catorce,
                   quince,
                   diez_y_seis,
                   total,
                   cuota,
                   costo,
                   total_cuota,
                   total_costo)
      VALUES      (@id_actividad,
                   @idtiempo,
                   @uno,
                   @dos,
                   @tres,
                   @cuatro,
                   @cinco,
                   @seis,
                   @siete,
                   @ocho,
                   @nueve,
                   @diez,
                   @once,
                   @doce,
                   @trece,
                   @catorce,
                   @quince,
                   @diezyseis,
                   @total,
                   @cuota,
                   @costo,
                   @totalcuota,
                   @totalcosto)
  END
GO 


delete from hora_asignable  where tiempo=1
delete from hora_no_asignable  where tiempo=1
delete from tiempo  where id_tiempo=1
go


CREATE PROCEDURE EliminarHoraAsignable @Id_Tiempo INT
AS
  BEGIN
      DELETE FROM hora_asignable
      WHERE  tiempo = @Id_Tiempo
  END

GO 

CREATE PROCEDURE EliminarHoraNoAsignable @Id_Tiempo INT
AS
	BEGIN
		DELETE FROM hora_no_asignable
		WHERE tiempo = @Id_Tiempo
	END
GO

CREATE PROCEDURE EliminarTiempo @IdTiempo INT
AS
	BEGIN
		DELETE FROM tiempo
		WHERE id_tiempo = @IdTiempo
	END
GO


SELECT * FROM tiempo WHERE id_tiempo = 27740
SELECT * FROM hora_asignable where tiempo = 27740

GO

CREATE PROCEDURE EliminarReporteTiempo @IdTiempo INT
AS
  BEGIN
      IF EXISTS(SELECT *
                FROM   hora_asignable
                WHERE  tiempo = @IdTiempo)
        BEGIN
            DELETE FROM hora_asignable
            WHERE  tiempo = @IdTiempo
        END

      IF EXISTS(SELECT *
                FROM   hora_no_asignable
                WHERE  tiempo = @IdTiempo)
        BEGIN
            DELETE FROM hora_no_asignable
            WHERE  tiempo = @IdTiempo
        END

      IF EXISTS(SELECT *
                FROM   tiempo
                WHERE  id_tiempo = @IdTiempo)
        DELETE FROM tiempo
        WHERE  id_tiempo = @IdTiempo
  END 
  GO

  EXEC EliminarReporteTiempo 27751

  SELECT * FROM tiempo 

  GO


UPDATE
  tiempo
SET
  horas_asignables = 35,
  horas_no_asignables = 20,
  total = 55,
  estatus = 0,
  envio = 1,
  fecha_modificacion = '" & stamp & "'
WHERE
  id_tiempo = 1;
  GO
  SELECT * FROM tiempo
  GO


  select * from tiempo
  GO

CREATE PROCEDURE Actualizatiempo
  @horas_asignables    INT,
  @horas_no_asignables INT,
  @total               INT,
  @estatus             INT,
  @envio               INT,
  @id_tiempo           INT
AS
  BEGIN
    UPDATE tiempo
    SET    horas_asignables = @horas_asignables,
           horas_no_asignables = @horas_no_asignables,
           total = @total,
           estatus = @estatus,
           envio = @envio,
           fecha_modificacion = Getdate()
    WHERE  id_tiempo = @id_tiempo
  END
  GO


UPDATE
  hora_asignable
SET
  proyecto = 55,
  uno = 1,
  dos = 2,
  tres = 3,
  cuatro = 4,
  cinco = 5,
  seis = 6,
  siete = 7,
  ocho = 8,
  nueve = 9,
  diez = 10,
  once = 11,
  doce = 12,
  trece = 13,
  catorce = 14,
  quince = 15,
  diez_y_seis = 16,
  total = 99,
  cuota = 44,
  costo = 66,
  total_cuota = 77,
  total_costo = 56
WHERE
  id_hora_asignable = 22;
  GO

  SELECT * FROM hora_asignable WHERE id_hora_asignable = 32 AND tiempo = 26
  GO

 CREATE PROCEDURE ActualizaHoraAsignable @Id_Hora_Asignable INT,
                                        @IdTiempo           INT,
                                        @proyecto           INT,
                                        @uno                INT,
                                        @dos                INT,
                                        @tres               INT,
                                        @cuatro             INT,
                                        @cinco              INT,
                                        @seis               INT,
                                        @siete              INT,
                                        @ocho               INT,
                                        @nueve              INT,
                                        @diez               INT,
                                        @once               INT,
                                        @doce               INT,
                                        @trece              INT,
                                        @catorce            INT,
                                        @quince             INT,
                                        @diez_y_seis        INT,
                                        @total              INT,
                                        @cuota              MONEY,
                                        @costo              MONEY,
                                        @total_cuota        MONEY,
                                        @total_costo        MONEY
AS
  BEGIN
      IF EXISTS(SELECT *
                FROM   hora_asignable
                WHERE  id_hora_asignable = @Id_Hora_Asignable
                       AND tiempo = @IdTiempo)
        BEGIN
            UPDATE hora_asignable
            SET    proyecto = @proyecto,
                   uno = @uno,
                   dos = @dos,
                   tres = @tres,
                   cuatro = @cuatro,
                   cinco = @cinco,
                   seis = @seis,
                   siete = @siete,
                   ocho = @ocho,
                   nueve = @nueve,
                   diez = @diez,
                   once = @once,
                   doce = @doce,
                   trece = @trece,
                   catorce = @catorce,
                   quince = @quince,
                   diez_y_seis = @diez_y_seis,
                   total = @total,
                   cuota = @cuota,
                   costo = @costo,
                   total_cuota = @total_cuota,
                   total_costo = @total_costo
            WHERE  id_hora_asignable = @Id_Hora_Asignable AND tiempo = @IdTiempo;
        END
      ELSE
        BEGIN
            INSERT INTO hora_asignable
                        (proyecto,
                         tiempo,
                         uno,
                         dos,
                         tres,
                         cuatro,
                         cinco,
                         seis,
                         siete,
                         ocho,
                         nueve,
                         diez,
                         once,
                         doce,
                         trece,
                         catorce,
                         quince,
                         diez_y_seis,
                         total,
                         cuota,
                         costo,
                         total_cuota,
                         total_costo)
            VALUES      (@proyecto,
                         @idtiempo,
                         @uno,
                         @dos,
                         @tres,
                         @cuatro,
                         @cinco,
                         @seis,
                         @siete,
                         @ocho,
                         @nueve,
                         @diez,
                         @once,
                         @doce,
                         @trece,
                         @catorce,
                         @quince,
                         @diez_y_seis,
                         @total,
                         @cuota,
                         @costo,
                         @total_cuota,
                         @total_costo)
        END
  END 




GO
UPDATE
  hora_no_asignable
SET
  actividad = 5,
  uno = 1,
  dos = 2,
  tres = 3,
  cuatro = 4,
  cinco = 5,
  seis = 6,
  siete = 7,
  ocho = 8,
  nueve = 9,
  diez = 10,
  once = 11,
  doce = 12,
  trece = 13,
  catorce = 14,
  quince = 15,
  diez_y_seis = 16,
  total = 55,
  cuota = 43,
  costo = 34,
  total_cuota = 55,
  total_costo = 65
WHERE
  id_hora_no_asignable = 32

  GO

CREATE PROCEDURE ActualizaHoraNoAsignable @id_hora_no_asignable INT,
                                          @tiempo               INT,
                                          @actividad            INT,
                                          @uno                  INT,
                                          @dos                  INT,
                                          @tres                 INT,
                                          @cuatro               INT,
                                          @cinco                INT,
                                          @seis                 INT,
                                          @siete                INT,
                                          @ocho                 INT,
                                          @nueve                INT,
                                          @diez                 INT,
                                          @once                 INT,
                                          @doce                 INT,
                                          @trece                INT,
                                          @catorce              INT,
                                          @quince               INT,
                                          @diez_y_seis          INT,
                                          @total                INT,
                                          @cuota                MONEY,
                                          @costo                MONEY,
                                          @total_cuota          MONEY,
                                          @total_costo          MONEY
AS
    IF EXISTS(SELECT *
              FROM   hora_no_asignable
              WHERE  id_hora_no_asignable = @id_hora_no_asignable
                     AND tiempo = @tiempo)
      BEGIN
          UPDATE hora_no_asignable
          SET    actividad = @actividad,
                 uno = @uno,
                 dos = @dos,
                 tres = @tres,
                 cuatro = @cuatro,
                 cinco = @cinco,
                 seis = @seis,
                 siete = @siete,
                 ocho = @ocho,
                 nueve = @nueve,
                 diez = @diez,
                 once = @once,
                 doce = @doce,
                 trece = @trece,
                 catorce = @catorce,
                 quince = @quince,
                 diez_y_seis = @diez_y_seis,
                 total = @total,
                 cuota = @cuota,
                 costo = @costo,
                 total_cuota = @total_cuota,
                 total_costo = @total_costo
          WHERE  id_hora_no_asignable = @id_hora_no_asignable AND tiempo = @tiempo
      END
    ELSE
      BEGIN
          INSERT INTO hora_no_asignable
                      (actividad,
                       tiempo,
                       uno,
                       dos,
                       tres,
                       cuatro,
                       cinco,
                       seis,
                       siete,
                       ocho,
                       nueve,
                       diez,
                       once,
                       doce,
                       trece,
                       catorce,
                       quince,
                       diez_y_seis,
                       total,
                       cuota,
                       costo,
                       total_cuota,
                       total_costo)
          VALUES      (@actividad,
                       @tiempo,
                       @uno,
                       @dos,
                       @tres,
                       @cuatro,
                       @cinco,
                       @seis,
                       @siete,
                       @ocho,
                       @nueve,
                       @diez,
                       @once,
                       @doce,
                       @trece,
                       @catorce,
                       @quince,
                       @diez_y_seis,
                       @total,
                       @cuota,
                       @costo,
                       @total_cuota,
                       @total_costo)
      END

GO




SELECT * FROM hora_no_asignable WHERE id_hora_no_asignable = 32 AND tiempo = 35