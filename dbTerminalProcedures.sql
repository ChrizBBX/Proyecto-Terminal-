
/*************************************** PROCEDURES *******************************/
USE dbTerminal 
GO



/*###############  tbCargos ###############*/

-------->	VIEW tbCargos
CREATE OR ALTER VIEW term.VW_tbCargos
AS
SELECT	carg_ID, 
		carg_Nombre, 
		carg_Estado, 
		carg_UsuarioCreador,
		usr1.usua_Usuario AS carg_UsuarioCreador_Nombre,
		carg_FechaCreacion,
		carg_UsuarioModificador,
		usr2.usua_Usuario AS carg_UsuarioModificador_Nombre,
		carg_FechaModificacion
FROM term.tbCargos AS cargo INNER JOIN acce.tbUsuarios AS usr1
ON cargo.carg_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON cargo.carg_UsuarioModificador = usr2.usua_ID
GO

GO

-------->	READ
CREATE OR ALTER PROCEDURE term.UDP_VW_tbCargos_VW
AS
BEGIN
	SELECT * FROM term.VW_tbCargos WHERE carg_Estado = 1
END
GO


-------->	CREATE
CREATE OR ALTER PROCEDURE term.UDP_tbCargos_Create
@carg_UsuarioCreador INT,
@carg_Nombre VARCHAR(200)
AS
BEGIN
	BEGIN TRY
	
	IF NOT EXISTS(SELECT carg_Nombre FROM term.tbCargos WHERE carg_Nombre = @carg_Nombre)
	BEGIN
		INSERT INTO term.tbCargos(carg_Nombre, carg_UsuarioCreador, carg_UsuarioModificador, carg_FechaModificacion)
		VALUES (@carg_Nombre, @carg_UsuarioCreador, NULL, NULL)
		SELECT 'Registro agregado exitosamente'
		END
		ELSE IF EXISTS(SELECT carg_Nombre FROM term.tbCargos WHERE carg_Nombre = @carg_Nombre AND carg_Estado = 0)
		BEGIN
		UPDATE term.tbCargos
		SET carg_Estado = 1
		WHERE carg_Nombre = @carg_Nombre;
	SELECT 'Registro agregado exitosamente'
		END
		ELSE
		SELECT 'Ya existe un cargo con ese nombre'

	END TRY

	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO


-------->	FIND
CREATE OR ALTER PROCEDURE term.UDP_tbCargos_Find 
@carg_ID INT
AS
BEGIN
	SELECT carg_ID, 
		carg_Nombre, 
		carg_Estado, 
		carg_UsuarioCreador,
		carg_UsuarioCreador_Nombre,
		carg_FechaCreacion,
		carg_UsuarioModificador,
		carg_UsuarioModificador_Nombre,
		carg_FechaModificacion
	FROM term.VW_tbCargos
	WHERE carg_ID = @carg_ID

END
GO


-------->	UPDATE
CREATE OR ALTER PROCEDURE term.UDP_tbCargos_Update
	@carg_UsuarioModificador	INT,
	@carg_ID					INT,
	@carg_Nombre				VARCHAR(200)
AS
BEGIN
	BEGIN TRY
		IF NOT EXISTS (SELECT carg_Id FROM term.tbCargos WHERE carg_Id = @carg_Id)
			BEGIN 
				SELECT 'El registro que intenta editar no existe'
			END
		ELSE
			BEGIN
				IF NOT EXISTS (SELECT carg_Nombre 
					   FROM term.tbCargos 
					   WHERE carg_Nombre = @carg_Nombre
					   AND carg_Id != @carg_Id)
					BEGIN
						UPDATE term.tbCargos 
						SET carg_Nombre = @carg_Nombre,
							carg_UsuarioModificador = @carg_UsuarioModificador,
							carg_FechaModificacion = GETDATE()
						WHERE carg_Id = @carg_Id

						SELECT 'El registro ha sido editado con éxito'
					END
				ELSE IF EXISTS (SELECT carg_Nombre 
								FROM term.tbCargos
								WHERE carg_Estado = 0
								AND carg_Nombre = @carg_Nombre)
					BEGIN
						UPDATE term.tbCargos
						SET carg_Estado = 1
						WHERE carg_Nombre = @carg_Nombre

						SELECT 'El registro ha sido editado con éxito'
					END
				ELSE
					SELECT 'Ya existe un cargo con este nombre'
			END
	END TRY
	BEGIN CATCH
		SELECT 'Ha ocurrido un error'
	END CATCH
END
GO

-------->	DELETE
CREATE OR ALTER PROCEDURE term.UDP_tbCargos_Delete
	@carg_ID	INT
AS
BEGIN
	BEGIN TRY
		UPDATE term.tbCargos
		SET carg_Estado = 0
		WHERE carg_ID = @carg_ID
		SELECT 'Registro Eliminado con exito'
	END TRY
	BEGIN CATCH 
		SELECT 'Ha ocurrido un error'
	END CATCH 
END
GO



/*###############  tbClientes  ###############*/


CREATE OR ALTER VIEW term.VW_tbClientes
AS
SELECT	clie_ID, 
		clie_Nombres, 
		clie_Apellidos,
		CONCAT(clie_Nombres,  ' ', clie_Apellidos) AS clie_NombreCompleto,
		clie_DNI,
		clie_Sexo,
		clie_Telefono,
		clie_Email,		
		clie_Estado,
		clie_UsuarioCreador,
		usr1.usua_Usuario AS clie_UsuarioCreador_Nombre,
		clie_FechaCreacion,
		clie_UsuarioModificador, 
		usr2.usua_Usuario AS clie_UsuarioModificador_Nombre,
		clie_FechaModificacion

FROM term.tbClientes AS clie INNER JOIN acce.tbUsuarios AS usr1
ON clie.clie_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON clie.clie_UsuarioModificador = usr2.usua_ID
GO


-------->	READ
CREATE OR ALTER PROCEDURE term.UDP_VW_tbClientes_VW
AS
BEGIN
	SELECT * FROM term.VW_tbClientes WHERE clie_Estado = 1

END
GO

-------->	CREATE	
CREATE OR ALTER PROCEDURE term.UDP_tbClientes_Create
	@clie_UsuarioCreador		INT,
	@clie_Nombres				NVARCHAR(100),
	@clie_Apellidos				NVARCHAR(100),
	@clie_DNI					CHAR(13),
	@clie_Sexo					CHAR(1),
	@clie_Telefono				CHAR(8),
	@clie_Email					NVARCHAR(300)
AS
BEGIN
	BEGIN TRY
	IF NOT EXISTS (SELECT clie_DNI FROM term.tbClientes WHERE clie_DNI  = @clie_DNI)
	BEGIN
		INSERT INTO term.tbClientes(clie_Nombres ,clie_Apellidos,clie_DNI ,clie_Sexo, clie_Telefono, clie_Email, clie_UsuarioCreador, 
									clie_UsuarioModificador, clie_FechaModificacion)
		VALUES	(@clie_Nombres, @clie_Apellidos ,@clie_DNI, @clie_Sexo, @clie_Telefono, 
				@clie_Email, @clie_UsuarioCreador, NULL, NULL)
		SELECT 'Registro agregado correctamente'
		END
		ELSE IF EXISTS (SELECT clie_DNI FROM term.tbClientes WHERE clie_DNI = @clie_DNI AND clie_Estado = 0) 
		BEGIN
		UPDATE term.tbClientes
		SET clie_Estado = 1
		WHERE clie_ID = @clie_DNI
		SELECT 'Registro agregado correctamente'
		END
		ELSE IF EXISTS (SELECT clie_DNI FROM term.tbClientes WHERE clie_DNI  = @clie_DNI)
		BEGIN
		SELECT 'Ya existe un cliente con ese numero de Identidad'
		END
	
	END TRY
	BEGIN CATCH
		SELECT 'Ha ocurrido un error'
	END CATCH
END
GO

-------->	FIND
CREATE OR ALTER PROCEDURE term.UDP_tbClientes_Find 
@clie_ID INT
AS
BEGIN

	SELECT clie_ID, clie_Nombres, clie_Apellidos, clie_NombreCompleto, clie_DNI, clie_Sexo, clie_Telefono, clie_Email, clie_Estado, clie_UsuarioCreador, clie_UsuarioCreador_Nombre, clie_FechaCreacion, clie_UsuarioModificador, clie_UsuarioModificador_Nombre, clie_FechaModificacion
	FROM term.VW_tbClientes
	WHERE clie_ID = @clie_ID
 
END
GO

-------->	UPDATE	
CREATE OR ALTER PROCEDURE term.UDP_tbClientes_Update
	@clie_UsuarioModificador	INT,
	@clie_ID					INT,
	@clie_Nombres				NVARCHAR(100),
	@clie_Apellidos				NVARCHAR(100),
	@clie_DNI					CHAR(13),
	@clie_Sexo					CHAR(1),
	@clie_Telefono				CHAR(8),
	@clie_Email					NVARCHAR(300)
AS
BEGIN
	BEGIN TRY
	IF EXISTS (SELECT clie_DNI FROM term.tbClientes WHERE clie_DNI = @clie_DNI AND clie_ID != @clie_ID)
	BEGIN 
	SELECT 'Ya hay un cliente con ese numero de identidad'
	END 
	ELSE 
	BEGIN
		UPDATE	term.tbClientes 
		SET		clie_Nombres = @clie_Nombres,
				clie_Apellidos = @clie_Apellidos,
				clie_DNI = @clie_DNI,
				clie_Sexo = @clie_Sexo, 
				clie_Telefono= @clie_Telefono, 
				clie_Email = @clie_Email,
				clie_UsuarioModificador = @clie_UsuarioModificador, 
				clie_FechaModificacion = GETDATE()
		WHERE	clie_ID = @clie_ID
		SELECT 'Registro editado exitosamente'
		END
	END TRY
	BEGIN CATCH
		SELECT 'Ha ocurrido un error'
	END CATCH
END
GO


-------->	DELETE	
CREATE OR ALTER PROCEDURE term.UDP_tbClientes_Delete
@clie_ID INT
AS
BEGIN
	BEGIN TRY
		UPDATE	term.tbClientes
		SET		clie_Estado  = 0
		WHERE clie_ID = @clie_ID
		SELECT 'Registro eliminado correctamente'
	END TRY

	BEGIN CATCH 
		SELECT 'Ha ocurrido un error'
	END CATCH
END
GO





/*###############  tbHorarios  ###############*/
/*Vista*/
CREATE OR ALTER VIEW term.VW_tbHorarios
AS
SELECT	hora_ID,
		hora_Salida,
		hora_Llegada,
		hora_Origen,
		dept1.dept_Descripcion AS hora_Origen_DeptoNombre,
		hora_Destino,
		dept2.dept_Descripcion AS hora_Destino_DeptoNombre,
		CONCAT(hora_Salida, ' / ' , dept2.dept_Descripcion ) AS horario,
		hora_CantidadPasajerosMax,
		hora_CantidadPasajerosActual,
		hora.hora_Precio,
		hora_Estado,
		hora_UsuarioCreador,
		usr1.usua_Usuario AS hora_UsuarioCreador_Nombre,
		hora_FechaCreacion,
		hora_UsuarioModificador,
		usr2.usua_Usuario AS hora_UsuarioModificador_Nombre,
		hora_FechaModificacion

FROM term.tbHorarios AS hora INNER JOIN gral.tbDepartamentos AS dept1
ON hora.hora_Origen = dept1.dept_ID INNER JOIN gral.tbDepartamentos AS dept2
ON hora.hora_Destino = dept2.dept_ID INNER JOIN acce.tbUsuarios AS usr1
ON hora.hora_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON hora.hora_UsuarioModificador = usr2.usua_ID
GO


CREATE OR ALTER PROCEDURE term.UDP_VW_tbHorarios_VW
AS
BEGIN
	SELECT * FROM term.VW_tbHorarios WHERE hora_Estado = 1
END
GO


--------> CREATE
CREATE OR ALTER PROCEDURE term.UDP_tbHorarios_Create
	@hora_UsuarioCreador		INT,
	@hora_Salida			DATETIME,
	@hora_Llegada			DATETIME,
	@hora_Origen				CHAR(2),
	@hora_Destino				CHAR(2),
	@hora_Precio				DECIMAL(18,2),
	@hora_CantidadPasajerosMax	INT
AS
BEGIN
	BEGIN TRY

		INSERT INTO term.tbHorarios(hora_Salida, hora_Llegada, hora_Origen, hora_Destino, hora_Precio,hora_CantidadPasajerosMax, hora_UsuarioCreador, hora_UsuarioModificador, hora_FechaModificacion)
		VALUES(@hora_Salida, @hora_Llegada, @hora_Origen, @hora_Destino, @hora_Precio ,@hora_CantidadPasajerosMax, @hora_UsuarioCreador, NULL, NULL)
SELECT 'Registro agregado exitosamente'
	END TRY
	BEGIN CATCH
SELECT 'A ocurrido un Error!!!'
	END CATCH

END
GO


--------> UPDATE
CREATE OR ALTER PROCEDURE term.UDP_VW_tbHorarios_Find
	@hora_ID INT
AS
BEGIN
	SELECT hora_ID,
		hora_Salida,
		hora_Llegada,
		hora_Origen,
		hora_Origen_DeptoNombre,
		hora_Destino,
		hora_Destino_DeptoNombre,
		hora_CantidadPasajerosMax,
		hora_Precio,
		hora_Estado,
		hora_UsuarioCreador,
		hora_UsuarioCreador_Nombre,
		hora_FechaCreacion,
		hora_UsuarioModificador,
		hora_UsuarioModificador_Nombre,
		hora_FechaModificacion
	FROM term.VW_tbHorarios WHERE hora_ID = @hora_ID
END
GO


--------> UPDATE
CREATE OR ALTER PROCEDURE term.UDP_tbHorarios_Update
	@hora_UsuarioModificador	INT,
	@hora_ID					INT,
	@hora_Salida				DATETIME,
	@hora_Llegada				DATETIME,
	@hora_Origen				CHAR(2),
	@hora_Destino				CHAR(2),
	@hora_Precio				DECIMAL(18,2),
	@hora_CantidadPasajerosMax	INT
AS
BEGIN
BEGIN TRY	
UPDATE	term.tbHorarios 
	SET		hora_Salida = @hora_Salida, 
			hora_Llegada = @hora_Llegada, 
			hora_Origen = @hora_Origen, 
			hora_Destino = @hora_Destino,
			hora_Precio = @hora_Precio,
			hora_CantidadPasajerosMax = @hora_CantidadPasajerosMax,
			hora_UsuarioModificador = @hora_UsuarioModificador, 
			hora_FechaModificacion = GETDATE()
	WHERE	hora_ID = @hora_ID

	SELECT 'Registro editado exitosamente'
	END TRY
	BEGIN CATCH
SELECT 'A ocurrido un Error!!!'
	END CATCH

END
GO

CREATE OR ALTER PROCEDURE term.UDP_tbHorarios_Delete
	@hora_ID INT
AS
BEGIN
BEGIN TRY	UPDATE term.tbHorarios
	SET hora_Estado = 0
	WHERE hora_ID = @hora_ID 

	SELECT 'Registro eliminado exitosamente'
	END TRY
	BEGIN CATCH
SELECT 'A ocurrido un Error!!!'
	END CATCH

END
GO



/*###############  tbTerminales  ###############*/

CREATE OR ALTER VIEW term.VW_tbTerminales
AS
SELECT	term_ID, 
		terminal.muni_ID,
		muni.muni_Descripcion,
		muni.dept_ID,
		depto.dept_Descripcion,
		term_Nombre,
		term_DireccionExacta, 
		term_CantidadTransportes, 
		term_Estado, 
		term_UsuarioCreador,
		usr1.usua_Usuario AS term_UsuarioCreador_Nombre,
		term_FechaCreacion, 
		term_UsuarioModificador, 
		usr2.usua_Usuario AS term_UsuarioModificador_Nombre,
		term_FechaModificacion
FROM term.tbTerminales AS terminal INNER JOIN gral.tbMunicipios AS muni
ON terminal.muni_ID = muni.muni_ID INNER JOIN gral.tbDepartamentos AS depto
ON muni.dept_ID = depto.dept_ID INNER JOIN acce.tbUsuarios AS usr1
ON terminal.term_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON terminal.term_UsuarioModificador = usr2.usua_ID
GO


-------->	READ
CREATE OR ALTER PROCEDURE term.UDP_VW_tbTerminales_VW
AS
BEGIN
	SELECT * FROM term.VW_tbTerminales WHERE term_Estado = 1
END
GO

--------> CREATE
CREATE OR ALTER PROCEDURE term.UDP_tbTerminales_Create
@muni_ID					CHAR(4),
@term_Nombre				VARCHAR(300),
@term_DireccionExacta		VARCHAR(500),
@term_CantidadTransportes	INT,
@term_UsuarioCreador		INT
AS
BEGIN

BEGIN TRY

	INSERT INTO [term].[tbTerminales]
           ([muni_ID]
           ,[term_Nombre]
           ,[term_DireccionExacta]
           ,[term_CantidadTransportes]
           ,[term_UsuarioCreador]
           ,[term_UsuarioModificador]
           ,[term_FechaModificacion])
     VALUES
           (@muni_ID
           ,@term_Nombre
           ,@term_DireccionExacta
           ,@term_CantidadTransportes
           ,@term_UsuarioCreador
           ,NULL
           ,NULL)
SELECT 'Registro agregado exitosamente'
	END TRY
	BEGIN CATCH
SELECT 'A ocurrido un Error!!!'
	END CATCH

END
GO


--------> FIND
CREATE OR ALTER PROCEDURE term.UDP_VW_tbTerminales_Find
@term_ID INT
AS
BEGIN

	SELECT	term_ID, 
			muni_ID,
			muni_Descripcion,
			dept_ID,
			dept_Descripcion,
			term_Nombre,
			term_DireccionExacta, 
			term_CantidadTransportes, 
			term_Estado, 
			term_UsuarioCreador,
			term_UsuarioCreador_Nombre,
			term_FechaCreacion, 
			term_UsuarioModificador, 
			term_UsuarioModificador_Nombre,
			term_FechaModificacion
	FROM term.VW_tbTerminales 
	WHERE term_ID = @term_ID
END
GO


--------> UPDATE	
CREATE OR ALTER PROCEDURE term.UDP_tbTerminales_Update
@term_ID					INT,
@muni_ID					CHAR(4),
@term_Nombre				VARCHAR(300),
@term_DireccionExacta		VARCHAR(500),
@term_CantidadTransportes	INT,
@term_UsuarioModificador	INT
AS
BEGIN

BEGIN TRY

UPDATE [term].[tbTerminales]
   SET [muni_ID] = @muni_ID
      ,[term_Nombre] = @term_Nombre
      ,[term_DireccionExacta] = @term_DireccionExacta
      ,[term_CantidadTransportes] = @term_CantidadTransportes
      ,[term_UsuarioModificador] = @term_UsuarioModificador
      ,[term_FechaModificacion] = GETDATE()
 WHERE term_ID	= @term_ID	

SELECT 'Registro actualizado exitosamente'
	END TRY
	BEGIN CATCH
SELECT 'A ocurrido un Error!!!'
	END CATCH

END
GO
--------> DELETE	

CREATE OR ALTER PROCEDURE term.UDP_tbTerminales_Delete
@term_ID					INT
AS
BEGIN

BEGIN TRY

UPDATE [term].[tbTerminales]
   SET [term_Estado] = 0
  WHERE term_ID	= @term_ID	


  SELECT 'Registro eliminado exitosamente'	END TRY
	BEGIN CATCH
  SELECT 'A ocurrido un Error!!!'
	END CATCH
END
GO

/*###############  tbBoletos  ###############*/

--------> VIEW	
CREATE OR ALTER VIEW term.VW_tbBoletos
AS
	SELECT	bole_ID, 
			bole_Fecha,
			bole.term_ID,
			term.term_Nombre,
			term.term_DireccionExacta,
			bole.comp_ID,
			comp.comp_Nombre,
			comp.comp_Direccion,
			bole.empl_ID,
			empl.empl_PrimerNombre,
			empl.empl_SegundoNombre,
			empl.empl_PrimerApellido,
			empl.empl_SegundoApellido,
			CONCAT(empl_PrimerNombre, ' ', empl_SegundoNombre, ' ', empl_PrimerApellido , ' ', empl_SegundoApellido) AS bole_empl_Nombre_Completo,
			bole.clie_ID,
			clie.clie_Nombres,
			clie.clie_Apellidos,
			CONCAT(clie_Nombres, ' ', clie_Apellidos) AS bole_clie_Nombre_Completo,
			clie.clie_Sexo,
			bole.hora_ID,
			hora.hora_Salida,
			hora.hora_Origen,
			dept1.dept_Descripcion AS bole_hora_Origen_Nombre,
			hora.hora_Llegada,
			hora.hora_Destino,
			dept2.dept_Descripcion AS bole_hora_Destino_Nombre,
			bole.pago_ID,
			pago.pago_Descripcion,
			hora.hora_Precio,
			bole_Estado,
			bole_UsuarioCreador,
			usr1.usua_Usuario AS bole_UsuarioCreador_Nombre,
			bole_FechaCreacion,
			bole_UsuarioModificador,
			usr2.usua_Usuario AS bole_UsuarioModificador_Nombre,
			bole_FechaModificacion

	FROM term.tbBoletos AS bole INNER JOIN term.tbTerminales AS term
	ON bole.term_ID = term.term_ID INNER JOIN term.tbCompania AS comp
	ON bole.comp_ID = comp.comp_ID INNER JOIN term.tbEmpleados AS empl
	ON bole.empl_ID = empl.empl_ID INNER JOIN term.tbClientes AS clie
	ON bole.clie_ID = clie.clie_ID INNER JOIN term.tbHorarios AS hora
	ON bole.hora_ID = hora.hora_ID INNER JOIN gral.tbMetodosPago AS pago
	ON bole.pago_ID = pago.pago_ID INNER JOIN acce.tbUsuarios AS usr1
	ON bole.bole_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
	ON bole.bole_UsuarioModificador = usr2.usua_ID INNER JOIN gral.tbDepartamentos AS dept1
	ON hora.hora_Origen = dept1.dept_ID LEFT JOIN gral.tbDepartamentos AS dept2
	ON hora.hora_Destino = dept2.dept_ID
GO


--------> READ
CREATE OR ALTER PROCEDURE term.UDP_VW_tbBoletos_VW
AS
BEGIN
	SELECT * FROM term.VW_tbBoletos WHERE bole_Estado = 1
END
GO

--------> CREATE	
CREATE OR ALTER PROCEDURE term.UDP_tbBoletos_Create
	@bole_UsuarioCreador	INT,
	@term_ID				INT,
	@comp_ID				INT,
	@empl_ID				INT,
	@clie_ID				INT,
	@hora_ID				INT,
	@pago_ID				INT
AS
BEGIN 
	BEGIN TRY
		INSERT INTO term.tbBoletos (term_ID, comp_ID, empl_ID, clie_ID, hora_ID, pago_ID,
					bole_UsuarioCreador, bole_UsuarioModificador, bole_FechaModificacion)
		VALUES (@term_ID, @comp_ID, @empl_ID, @clie_ID, @hora_ID, @pago_ID,
				@bole_UsuarioCreador, NULL, NULL)
		UPDATE term.tbHorarios
		SET hora_CantidadPasajerosActual = hora_CantidadPasajerosActual+1
		WHERE hora_ID = @hora_ID
		SELECT 'Registro agregado exitosamente'
	END TRY
	BEGIN CATCH
		SELECT 'Ha ocurrido un error'
	END CATCH 
END
GO


--------> FIND	
CREATE OR ALTER PROCEDURE term.UDP_VW_tbBoletos_Find
	@bole_ID INT
AS
BEGIN
	SELECT bole_ID, 
			bole_Fecha,
			term_ID,
			term_Nombre,
			term_DireccionExacta,
			comp_ID,
			comp_Nombre,
			comp_Direccion,
			empl_ID,
			empl_PrimerNombre,
			empl_SegundoNombre,
			empl_PrimerApellido,
			empl_SegundoApellido,
			bole_empl_Nombre_Completo,
			clie_ID,
			clie_Nombres,
			clie_Apellidos,
			bole_clie_Nombre_Completo,
			clie_Sexo,
			hora_ID,
			hora_Salida,
			hora_Origen,
			bole_hora_Origen_Nombre,
			hora_Llegada,
			hora_Destino,
			bole_hora_Destino_Nombre,
			pago_ID,
			pago_Descripcion,
			hora_Precio,
			bole_Estado,
			bole_UsuarioCreador,
			bole_UsuarioCreador_Nombre,
			bole_FechaCreacion,
			bole_UsuarioModificador,
			bole_UsuarioModificador_Nombre,
			bole_FechaModificacion
	FROM term.VW_tbBoletos WHERE bole_ID = @bole_ID
END
GO



--------> UPDATE	
CREATE OR ALTER PROCEDURE term.UDP_tbBoletos_Update
	@bole_UsuarioModificador	INT,
	@bole_ID					INT ,
	@term_ID					INT,
	@comp_ID					INT,
	@empl_ID					INT,
	@clie_ID					INT,
	@hora_ID					INT,
	@pago_ID					INT
AS
BEGIN 
	BEGIN TRY
		UPDATE term.tbBoletos 
		SET term_ID = @term_ID, 
		comp_ID = @comp_ID, 
		empl_ID = @empl_ID, 
		clie_ID = @clie_ID, 
		hora_ID = @hora_ID, 
		pago_ID = @pago_ID,
		bole_UsuarioModificador = @bole_UsuarioModificador, 
		bole_FechaModificacion = GETDATE()
		WHERE bole_ID = @bole_ID
		SELECT 'Registro editado exitosamente'
	END TRY 
	BEGIN CATCH
		SELECT 'Ha ocurrido un error'
	END CATCH
END
GO



--------> DELETE	
CREATE OR ALTER PROCEDURE term.UDP_tbBoletos_Delete
	@bole_ID				INT
AS
BEGIN 
	BEGIN TRY
		UPDATE term.tbBoletos
		SET bole_Estado = 0
		WHERE bole_ID = @bole_ID
		SELECT 'Registro eliminado correctamente'
	END TRY
	BEGIN CATCH 
		SELECT 'Ha ocurrido un error'
	END CATCH
END
GO


go
CREATE OR ALTER PROCEDURE gral.UDP_CargarDepartamento_Load 
AS
BEGIN
SELECT [dept_ID], 
[dept_Descripcion], 
[dept_Estado], 
[dept_UsuarioCreador],
[dept_FechaCreacion], 
[dept_UsuarioModificador],
[dept_FechaModificacion]
FROM [gral].[tbDepartamentos]
WHERE dept_Estado = 1

END

go
CREATE OR ALTER PROCEDURE gral.UDP_CargarMunicipio_Load 
@dept_ID   varchar(10)
AS
BEGIN
SELECT  [dept_ID], 
		[muni_ID], 
		[muni_Descripcion],
		[muni_Estado],
		[muni_UsuarioCreador],
		[muni_FechaCreacion], 
		[muni_UsuarioModificador],
		[muni_FechaModificacion]
FROM [gral].[tbMunicipios]
WHERE [dept_ID] = @dept_ID

END

GO
CREATE OR ALTER VIEW gral.VW_graficaViaje
AS
SELECT bole_hora_Destino_Nombre, COUNT(hora_Destino) AS Cantidad
    FROM term.VW_tbBoletos
	group by hora_Destino,bole_hora_Destino_Nombre



GO
CREATE OR ALTER VIEW gral.VW_graficaSexo
AS
 
select	( SELECT COUNT(clie_Sexo) FROM term.VW_tbBoletos where clie_Sexo = 'M' group by clie_Sexo ) Masculino,
			( SELECT COUNT(clie_Sexo) FROM term.VW_tbBoletos where clie_Sexo = 'F' group by clie_Sexo ) Femenino


GO
CREATE OR ALTER PROCEDURE gral.UDP_GraficaViajes_Load
AS
BEGIN
 
	SELECT * from gral.VW_graficaViaje

END 


GO
CREATE OR ALTER PROCEDURE gral.UDP_GraficaSexo_Load
AS
BEGIN

SELECT * FROM gral.VW_graficaSexo
		
END 
/*###############  tbCompa�ia ###############*/
GO
CREATE OR ALTER PROCEDURE term.UDP_tbCompania_List
AS
BEGIN
SELECT * FROM term.tbCompania WHERE comp_Estado = 1 
END

/*###############  tbEmpleados ###############*/
/*Empleados Vista*/
GO
CREATE OR ALTER VIEW term.VW_tbEmpleados
AS
SELECT empl_ID, 
empl_PrimerNombre, 
empl_SegundoNombre, 
empl_PrimerApellido, 
empl_SegundoApellido, 
CONCAT(empl_PrimerNombre, ' ' ,empl_PrimerApellido) AS empl_NombreCompleto, 
empl_DNI, 
empl_FechaNacimiento, 
empl_Sexo, 
empl_Telefono, 
carg_ID, 
role_ID,
estciv_ID, 
muni_ID, 
empl_Estado, 
empl_UsuarioCreador, 
empl_FechaCreacion, 
empl_UsuarioModificador, 
empl_FechaModificacion
FROM term.tbEmpleados

/*Empleados Vista UDP*/
GO
CREATE OR ALTER PROCEDURE term.UDP_tbEmpleado_List
AS
BEGIN
SELECT * FROM term.VW_tbEmpleados WHERE empl_Estado = 1
END
GO

/*tb Usuarios*/

--------> VIEW
CREATE OR ALTER VIEW acce.VW_tbUsuarios
AS
SELECT	usrs.usua_ID,
		usrs.usua_Usuario,
		usrs.usua_Clave,
		usrs.usua_EsAdmin,
		usrs.empl_ID,
		empl.empl_PrimerNombre,
		empl.empl_SegundoNombre,
		empl.empl_PrimerApellido,
		empl.empl_SegundoApellido,
		CONCAT(empl_PrimerNombre, ' ', empl_SegundoNombre) AS usua_empl_Nombres,
		CONCAT(empl_PrimerApellido, ' ', empl_SegundoApellido) AS usua_empl_Apellidos,
		CONCAT(empl_PrimerNombre, ' ', empl_SegundoNombre, ' ',empl_PrimerApellido, ' ', empl_SegundoApellido) AS usua_empl_NombreCompleto,
		empl.carg_ID,
		carg.carg_Nombre,
		empl.role_ID,
		rol.role_Descripcion,
		usr1.usua_Usuario AS usua_UsuarioCreador_Nombre,
		usr2.usua_Usuario AS usua_UsuarioModificador_Nombre,
		usrs.usua_Estado,
		usrs.usua_UsuarioCreador,
		usrs.usua_FechaCreacion,
		usrs.usua_UsuarioModificador,
		usrs.usua_FechaModificacion
FROM acce.tbUsuarios AS usrs INNER JOIN term.tbEmpleados AS empl
ON usrs.empl_ID = empl.empl_ID INNER JOIN acce.tbUsuarios AS usr1
ON usrs.usua_UsuarioCreador = usr1.usua_ID LEFT JOIN acce.tbUsuarios AS usr2
ON usrs.usua_UsuarioModificador = usr2.usua_ID INNER JOIN acce.tbRoles AS rol
ON empl.role_ID = rol.role_ID INNER JOIN term.tbCargos AS carg
ON empl.carg_ID = carg.carg_ID
GO


--------> READ	
CREATE OR ALTER PROCEDURE acce.UDP_VW_tbUsuarios_VW
AS
BEGIN
	SELECT * FROM acce.VW_tbUsuarios WHERE usua_Estado = 1
END
GO


--------> CREATE	
CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_Create
	@usua_UsuarioCreador	INT,
	@usua_Usuario			NVARCHAR(100), 
	@usua_Clave				VARCHAR(MAX),
	@usua_EsAdmin			INT, 
	@empl_ID				INT
 AS
 BEGIN
	BEGIN TRY
		DECLARE @PassEncrypt VARBINARY(MAX) = HASHBYTES('SHA2_512', @usua_Clave)
		INSERT INTO acce.tbUsuarios(usua_Usuario, usua_Clave, usua_EsAdmin, empl_ID, usua_UsuarioCreador, usua_UsuarioModificador, usua_FechaModificacion)
		VALUES(@usua_Usuario, @PassEncrypt, @usua_EsAdmin, @empl_ID, @usua_UsuarioCreador, NULL, NULL)
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO

--------> FIND
CREATE OR ALTER PROCEDURE acce.UDP_VW_tbUsuarios_Find
	@usua_ID INT
AS
BEGIN
	SELECT usua_ID,
		usua_Usuario,
		usua_Clave,
		usua_EsAdmin,
		empl_ID,
		empl_PrimerNombre,
		empl_SegundoNombre,
		empl_PrimerApellido,
		empl_SegundoApellido,
		usua_empl_Nombres,
		usua_empl_Apellidos,
		usua_empl_NombreCompleto,
		carg_ID,
		carg_Nombre,
		role_ID,
		role_Descripcion,
		usua_UsuarioCreador_Nombre,
		usua_UsuarioModificador_Nombre,
		usua_Estado,
		usua_UsuarioCreador,
		usua_FechaCreacion,
		usua_UsuarioModificador,
		usua_FechaModificacion
	FROM acce.VW_tbUsuarios WHERE usua_ID = @usua_ID
END
GO



--------> UPDATE
CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_Update
	@usua_UsuarioModificador	INT,
	@usua_ID					INT,
	@usua_Usuario				NVARCHAR(100),
	@usua_Clave					VARCHAR(MAX),
	@usua_EsAdmin				INT, 
	@empl_ID					INT
AS
BEGIN
	BEGIN TRY
		UPDATE acce.tbUsuarios
		SET usua_Usuario = @usua_Usuario,
			usua_UsuarioModificador = @usua_UsuarioModificador,
			usua_EsAdmin = @usua_EsAdmin,
			empl_ID = @empl_ID
		WHERE usua_ID = @usua_ID		
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH 
END
GO


--------> DELETE	
CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_Delete
	@usua_ID INT
AS
BEGIN
	BEGIN TRY
		UPDATE acce.tbUsuarios
		SET usua_Estado = 0
		WHERE usua_ID = @usua_ID
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO



 DECLARE @e VARCHAR(MAX) = 'HOLA'
 DECLARE @f VARBINARY(MAX) = HASHBYTES('SHA2_512', @e)

 SELECT @f
 GO

 --CREATE OR ALTER VIEW acce.VW_tbUsuarios_EmpleadosDDl
 --AS
 --SELECT * FROM term.tbEmpleados WHERE empl_ID NOT IN ()

 --SELECT usr.empl_ID FROM term.tbEmpleados AS empl INNER JOIN acce.tbUsuarios AS usr
 --ON empl.empl_ID = usr.empl_ID
 --GO

 --CREATE OR ALTER PROCEDURE acce.UDP_VW_-tbUsuarios_EmpleadosDDL
 --AS
 --BEGIN
	--SELECT * FROM acce.VW_tbUsuarios WHERE 
 --END
 --GO


 -- LOGIN ----
CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_Login

	@usua_Usuario  NVARCHAR(150),
	@usua_Clave   VARCHAR(150)
AS
BEGIN
	DECLARE @Pass VARBINARY(MAX) = CONVERT(VARBINARY(MAX), HASHBYTES('SHA2_512', @usua_Clave));

	SELECT	*
	  FROM  acce.VW_tbUsuarios
	 WHERE  (usua_Usuario = @usua_Usuario AND usua_Clave = @Pass)
	   AND  usua_Estado = 1
END
GO



--CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_UserExists
--    @usua_Usuario    NVARCHAR(20)
--AS
--BEGIN
--    SELECT usua_ID  
--	  FROM acce.[tbUsuarios] 
--	 WHERE usua_Usuario = @usua_Usuario 
--	   AND usua_Estado = 1
--END
--GO


--CREATE PROCEDURE 'UDP_tbUsuarios_ActualizarContraseniausuario'
CREATE OR ALTER PROCEDURE acce.UDP_tbUsuarios_ChangePassword
	@usua_Usuario NVARCHAR(150),
	@usua_Clave   VARCHAR(150)
AS
BEGIN
	DECLARE @Pass VARBINARY(MAX) = CONVERT(VARBINARY(MAX), HASHBYTES('SHA2_512', @usua_Clave));

	UPDATE acce.tbUsuarios
	   SET usua_Clave = @Pass
	 WHERE usua_Usuario = @usua_Usuario
END
GO
