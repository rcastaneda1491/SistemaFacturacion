CREATE PROC SP_Productos_Fecha @FechaInicio DateTime, @FechaFinal DateTime
AS BEGIN
	SET LANGUAGE Spanish;
	SELECT DATENAME(WEEKDAY ,F.fecha) Dia,
		F.fecha,
		P.codigoProducto,
		P.nombre,
		SUM((FP.precioUnitario * FP.cantidad)) totalVendido
	FROM Productos P, FacturaProducto FP, Facturas F 
	WHERE P.codigoProducto = FP.codigoProducto AND
	FP.numeroFactura = F.numeroFactura AND
	F.fecha BETWEEN @FechaInicio AND @FechaFinal
	GROUP BY F.fecha,p.codigoProducto,p.nombre
END

-------------------------------------------------------------
GO
CREATE PROC SP_Productos_Nombre @CodigoProducto INT
AS BEGIN
	SET LANGUAGE Spanish;
	SELECT DATENAME(WEEKDAY ,F.fecha) Dia,
		F.fecha,
		P.codigoProducto,
		P.nombre,
		SUM((FP.precioUnitario * FP.cantidad)) totalVendido
	FROM Productos P, FacturaProducto FP, Facturas F 
	WHERE P.codigoProducto = FP.codigoProducto AND
	FP.numeroFactura = F.numeroFactura AND
	P.codigoProducto = @CodigoProducto
	GROUP BY F.fecha,P.codigoProducto,P.nombre;
END

--------------------------------------------------------------
GO
CREATE PROC SP_Productos_Fecha_Nombre @FechaInicio DateTime, @FechaFinal DateTime, @CodigoProducto INT
AS BEGIN
	SET LANGUAGE Spanish;
	SELECT DATENAME(WEEKDAY ,F.fecha) Dia,
		F.fecha,
		P.codigoProducto,
		P.nombre,
		SUM((FP.precioUnitario * FP.cantidad)) totalVendido
	FROM Productos P, FacturaProducto FP, Facturas F 
	WHERE P.codigoProducto = FP.codigoProducto AND
	FP.numeroFactura = F.numeroFactura AND
	F.fecha BETWEEN @FechaInicio AND @FechaFinal AND
	P.codigoProducto = @CodigoProducto
	GROUP BY F.fecha,p.codigoProducto,p.nombre
END

-------------------------------------------------------------
GO
CREATE PROC SP_Cliente_Fecha @FechaInicio DateTime, @FechaFinal DateTime
AS BEGIN
	SET LANGUAGE Spanish;
	SELECT DATENAME(WEEKDAY ,F.fecha) Dia,
		F.fecha,
		C.nombres,
		C.apellidos,
		SUM((FP.precioUnitario * FP.cantidad)) Total
	FROM Clientes C, FacturaProducto FP, Facturas F 
	WHERE C.codigoCliente = F.codigoCliente AND
	FP.numeroFactura = F.numeroFactura AND
	F.fecha BETWEEN @FechaInicio AND @FechaFinal
	GROUP BY F.fecha,C.nombres,C.apellidos
END

--------------------------------------------------------------
GO
CREATE PROC SP_Cliente_Nombre @CodigoCliente INT
AS BEGIN
	SET LANGUAGE Spanish;
	SELECT DATENAME(WEEKDAY ,F.fecha) Dia,
		F.fecha,
		C.nombres,
		c.apellidos,
		SUM((FP.precioUnitario * FP.Cantidad)) Total
	FROM Clientes C, FacturaProducto FP, Facturas F  
	WHERE C.codigoCliente = F.codigoCliente AND
	FP.numeroFactura = F.numeroFactura AND
	C.codigoCliente = @CodigoCliente
	GROUP BY F.fecha,C.nombres,C.apellidos;
END

-------------------------------------------------------------------
GO
CREATE PROC SP_Cliente_Fecha_Nombre @FechaInicio DateTime, @FechaFinal DateTime, @CodigoCliente INT
AS BEGIN
	SET LANGUAGE Spanish;
	SELECT DATENAME(WEEKDAY ,F.fecha) Dia,
		F.fecha,
		C.nombres,
		c.apellidos,
		SUM((FP.precioUnitario * FP.Cantidad)) Total
	FROM Clientes C, FacturaProducto FP, Facturas F  
	WHERE C.codigoCliente = F.codigoCliente AND
	FP.numeroFactura = F.numeroFactura AND
	F.fecha BETWEEN @FechaInicio AND @FechaFinal AND
	C.codigoCliente = @CodigoCliente
	GROUP BY F.fecha,C.nombres,C.apellidos;
END
------------------------------------------------------------------
drop proc SP_Estadistica_Facturacion

GO
CREATE PROC SP_Estadistica_Facturacion @FechaInicio DateTime, @FechaFinal DateTime
AS BEGIN
	SET LANGUAGE Spanish;
	SELECT DATENAME(WEEKDAY, F.fecha) Dia,
		CONVERT(DATE, F.fecha) fecha,
		(SELECT COUNT(*) FROM Facturas FF WHERE FF.fecha = F.fecha) facturasEmitidas,
		SUM(FP.precioUnitario * FP.cantidad) total,
		SUM(FP.cantidad) cantidadProductos
	FROM Facturas F, FacturaProducto FP
	WHERE FP.numeroFactura = F.numeroFactura AND
	F.fecha BETWEEN @FechaInicio AND @FechaFinal
	GROUP BY F.fecha;
END

-------------------------------------------------------------------