USE [Test]
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 12/6/2024 19:22:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Productos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoProducto] [int] NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[PRECIO] [real] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_IdTipoProducto] FOREIGN KEY([IdTipoProducto])
REFERENCES [dbo].[TipoProductos] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_IdTipoProducto]
GO


