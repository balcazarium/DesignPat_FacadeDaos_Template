

CREATE TABLE [dbo].[CodigoAgrupadorDeCuentasSAT](
	[codigoAgrupador] [char](8) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
	[codigoAgrupadorPadre] [char](8) NOT NULL,
	[naturaleza] [char](2) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE LibroDiario(
	id uniqueidentifier NOT NULL PRIMARY KEY,
	idCodigoAgrupador char(8),
	debe decimal(18,2),
	haber decimal(18,2)
)
GO
CREATE TABLE CatalogoCuentas(
	id uniqueidentifier NOT NULL Primary Key,
	idCodigoAgrupador char(8) NOT NULL,
	idCuentaPadre uniqueidentifier NOT NULL,
	numeroCuenta varchar(max) NOT NULL,
	descripcion varchar(max) NOT NULL
)
GO

