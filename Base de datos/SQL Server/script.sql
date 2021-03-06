USE [master]
GO
/****** Object:  Database [Formula1_373886]    Script Date: 25/04/2019 5:57:27 p. m. ******/
CREATE DATABASE [Formula1_373886] ON  PRIMARY 
( NAME = N'Formula1_373886', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Formula1_373886.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Formula1_373886_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Formula1_373886_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Formula1_373886] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Formula1_373886].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Formula1_373886] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Formula1_373886] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Formula1_373886] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Formula1_373886] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Formula1_373886] SET ARITHABORT OFF 
GO
ALTER DATABASE [Formula1_373886] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Formula1_373886] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Formula1_373886] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Formula1_373886] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Formula1_373886] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Formula1_373886] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Formula1_373886] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Formula1_373886] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Formula1_373886] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Formula1_373886] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Formula1_373886] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Formula1_373886] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Formula1_373886] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Formula1_373886] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Formula1_373886] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Formula1_373886] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Formula1_373886] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Formula1_373886] SET RECOVERY FULL 
GO
ALTER DATABASE [Formula1_373886] SET  MULTI_USER 
GO
ALTER DATABASE [Formula1_373886] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Formula1_373886] SET DB_CHAINING OFF 
GO
USE [Formula1_373886]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[IdCar] [int] IDENTITY(1,1) NOT NULL,
	[IdCir] [smallint] NOT NULL,
	[AñoTemp] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[IdPrue] [smallint] NOT NULL,
 CONSTRAINT [PK_Carreras] PRIMARY KEY CLUSTERED 
(
	[IdCar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Circuitos]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Circuitos](
	[IdCir] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](80) NOT NULL,
 CONSTRAINT [PK_Circuitos] PRIMARY KEY CLUSTERED 
(
	[IdCir] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Escuderias]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escuderias](
	[IdEsc] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Escuderias] PRIMARY KEY CLUSTERED 
(
	[IdEsc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pilotos]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pilotos](
	[Doc] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Pilotos] PRIMARY KEY CLUSTERED 
(
	[Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PilotosxEscuderia]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PilotosxEscuderia](
	[Doc] [int] NOT NULL,
	[IdEsc] [smallint] NOT NULL,
	[AñoTemp] [int] NOT NULL,
	[Salario] [money] NOT NULL,
 CONSTRAINT [PK_PilotosxEscuderia] PRIMARY KEY CLUSTERED 
(
	[Doc] ASC,
	[IdEsc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtsTemporada]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtsTemporada](
	[IdPts] [int] IDENTITY(1,1) NOT NULL,
	[AñoTemp] [int] NOT NULL,
	[Pos] [smallint] NOT NULL,
	[Pts] [smallint] NOT NULL,
	[IdPrue] [smallint] NOT NULL,
 CONSTRAINT [PK_PtsTemporada] PRIMARY KEY CLUSTERED 
(
	[IdPts] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resultados]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resultados](
	[IdCar] [int] NOT NULL,
	[Doc] [int] NOT NULL,
	[IdPts] [int] NOT NULL,
	[IdLla] [smallint] NOT NULL,
 CONSTRAINT [PK_Resultados] PRIMARY KEY CLUSTERED 
(
	[IdCar] ASC,
	[Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temporadas]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temporadas](
	[AñoTemp] [int] NOT NULL,
 CONSTRAINT [PK_Temporadas_1] PRIMARY KEY CLUSTERED 
(
	[AñoTemp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposLlanta]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposLlanta](
	[IdLlanta] [smallint] IDENTITY(1,1) NOT NULL,
	[Desc] [nchar](10) NULL,
 CONSTRAINT [PK_TiposLlanta] PRIMARY KEY CLUSTERED 
(
	[IdLlanta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposPrueba]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposPrueba](
	[IdPrue] [smallint] IDENTITY(1,1) NOT NULL,
	[Desc] [nchar](50) NOT NULL,
 CONSTRAINT [PK_TiposPrueba] PRIMARY KEY CLUSTERED 
(
	[IdPrue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Cantidad de carreras por temporadas]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Cantidad de carreras por temporadas]
AS
SELECT        AñoTemp, COUNT(IdCar) AS Carreras
FROM            dbo.Carreras
GROUP BY AñoTemp
GO
/****** Object:  View [dbo].[Carreras-Circuito-TipoPrueba]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Carreras-Circuito-TipoPrueba]
AS
SELECT        TOP (100) PERCENT dbo.Carreras.Fecha, dbo.Circuitos.Nombre AS Circuito, dbo.TiposPrueba.[Desc] AS [Descripcion de prueba]
FROM            dbo.Carreras INNER JOIN
                         dbo.Circuitos ON dbo.Carreras.IdCir = dbo.Circuitos.IdCir INNER JOIN
                         dbo.TiposPrueba ON dbo.Carreras.IdPrue = dbo.TiposPrueba.IdPrue
ORDER BY dbo.Carreras.Fecha
GO
/****** Object:  View [dbo].[Resultados de carreras (Piloto, fecha, posicion, puntos, llanta, prueba)]    Script Date: 25/04/2019 5:57:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Resultados de carreras (Piloto, fecha, posicion, puntos, llanta, prueba)]
AS
SELECT        dbo.Carreras.Fecha, dbo.Pilotos.Nombre, dbo.PtsTemporada.Pos AS Posicion, dbo.PtsTemporada.Pts AS Puntos, dbo.TiposLlanta.[Desc] AS [Tipo de llanta], dbo.TiposPrueba.[Desc] AS [Tipo de prueba]
FROM            dbo.Carreras INNER JOIN
                         dbo.Resultados ON dbo.Carreras.IdCar = dbo.Resultados.IdCar INNER JOIN
                         dbo.Pilotos ON dbo.Resultados.Doc = dbo.Pilotos.Doc INNER JOIN
                         dbo.PtsTemporada ON dbo.Resultados.IdPts = dbo.PtsTemporada.IdPts INNER JOIN
                         dbo.TiposLlanta ON dbo.Resultados.IdLla = dbo.TiposLlanta.IdLlanta INNER JOIN
                         dbo.TiposPrueba ON dbo.Carreras.IdPrue = dbo.TiposPrueba.IdPrue AND dbo.PtsTemporada.IdPrue = dbo.TiposPrueba.IdPrue
GO
SET IDENTITY_INSERT [dbo].[Carreras] ON 

INSERT [dbo].[Carreras] ([IdCar], [IdCir], [AñoTemp], [Fecha], [IdPrue]) VALUES (2, 1, 2018, CAST(N'2018-01-01' AS Date), 2)
INSERT [dbo].[Carreras] ([IdCar], [IdCir], [AñoTemp], [Fecha], [IdPrue]) VALUES (3, 1, 2018, CAST(N'2018-01-02' AS Date), 2)
INSERT [dbo].[Carreras] ([IdCar], [IdCir], [AñoTemp], [Fecha], [IdPrue]) VALUES (4, 2, 2018, CAST(N'2018-01-05' AS Date), 2)
INSERT [dbo].[Carreras] ([IdCar], [IdCir], [AñoTemp], [Fecha], [IdPrue]) VALUES (5, 2, 2018, CAST(N'2018-01-07' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Carreras] OFF
SET IDENTITY_INSERT [dbo].[Circuitos] ON 

INSERT [dbo].[Circuitos] ([IdCir], [Nombre]) VALUES (1, N'Gran circuito de Susuka                                                         ')
INSERT [dbo].[Circuitos] ([IdCir], [Nombre]) VALUES (2, N'Gran circuito de Monza                                                          ')
INSERT [dbo].[Circuitos] ([IdCir], [Nombre]) VALUES (3, N'Gran circuito de Melbourne                                                      ')
INSERT [dbo].[Circuitos] ([IdCir], [Nombre]) VALUES (4, N'Gran circuito de Mónaco                                                         ')
SET IDENTITY_INSERT [dbo].[Circuitos] OFF
SET IDENTITY_INSERT [dbo].[Escuderias] ON 

INSERT [dbo].[Escuderias] ([IdEsc], [Nombre]) VALUES (3, N'Ferrari   ')
INSERT [dbo].[Escuderias] ([IdEsc], [Nombre]) VALUES (2, N'McLauren  ')
INSERT [dbo].[Escuderias] ([IdEsc], [Nombre]) VALUES (1, N'Renault   ')
SET IDENTITY_INSERT [dbo].[Escuderias] OFF
INSERT [dbo].[Pilotos] ([Doc], [Nombre]) VALUES (1, N'Carolina')
INSERT [dbo].[Pilotos] ([Doc], [Nombre]) VALUES (2, N'Andres')
INSERT [dbo].[PilotosxEscuderia] ([Doc], [IdEsc], [AñoTemp], [Salario]) VALUES (1, 1, 2018, 100000.0000)
SET IDENTITY_INSERT [dbo].[PtsTemporada] ON 

INSERT [dbo].[PtsTemporada] ([IdPts], [AñoTemp], [Pos], [Pts], [IdPrue]) VALUES (1, 2018, 1, 10, 2)
INSERT [dbo].[PtsTemporada] ([IdPts], [AñoTemp], [Pos], [Pts], [IdPrue]) VALUES (2, 2018, 2, 8, 2)
SET IDENTITY_INSERT [dbo].[PtsTemporada] OFF
INSERT [dbo].[Resultados] ([IdCar], [Doc], [IdPts], [IdLla]) VALUES (2, 1, 1, 1)
INSERT [dbo].[Resultados] ([IdCar], [Doc], [IdPts], [IdLla]) VALUES (2, 2, 2, 1)
INSERT [dbo].[Temporadas] ([AñoTemp]) VALUES (2018)
INSERT [dbo].[Temporadas] ([AñoTemp]) VALUES (2019)
INSERT [dbo].[Temporadas] ([AñoTemp]) VALUES (2020)
SET IDENTITY_INSERT [dbo].[TiposLlanta] ON 

INSERT [dbo].[TiposLlanta] ([IdLlanta], [Desc]) VALUES (1, N'Michelin  ')
INSERT [dbo].[TiposLlanta] ([IdLlanta], [Desc]) VALUES (2, N'Bridgeston')
SET IDENTITY_INSERT [dbo].[TiposLlanta] OFF
SET IDENTITY_INSERT [dbo].[TiposPrueba] ON 

INSERT [dbo].[TiposPrueba] ([IdPrue], [Desc]) VALUES (1, N'Preclasificacion                                  ')
INSERT [dbo].[TiposPrueba] ([IdPrue], [Desc]) VALUES (2, N'Clasificacion                                     ')
SET IDENTITY_INSERT [dbo].[TiposPrueba] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Escuderias]    Script Date: 25/04/2019 5:57:27 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Escuderias] ON [dbo].[Escuderias]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Carreras]  WITH CHECK ADD  CONSTRAINT [FK_Carreras_Circuitos] FOREIGN KEY([IdCir])
REFERENCES [dbo].[Circuitos] ([IdCir])
GO
ALTER TABLE [dbo].[Carreras] CHECK CONSTRAINT [FK_Carreras_Circuitos]
GO
ALTER TABLE [dbo].[Carreras]  WITH CHECK ADD  CONSTRAINT [FK_Carreras_Temporadas] FOREIGN KEY([AñoTemp])
REFERENCES [dbo].[Temporadas] ([AñoTemp])
GO
ALTER TABLE [dbo].[Carreras] CHECK CONSTRAINT [FK_Carreras_Temporadas]
GO
ALTER TABLE [dbo].[Carreras]  WITH CHECK ADD  CONSTRAINT [FK_Carreras_TiposPrueba] FOREIGN KEY([IdPrue])
REFERENCES [dbo].[TiposPrueba] ([IdPrue])
GO
ALTER TABLE [dbo].[Carreras] CHECK CONSTRAINT [FK_Carreras_TiposPrueba]
GO
ALTER TABLE [dbo].[PilotosxEscuderia]  WITH CHECK ADD  CONSTRAINT [FK_PilotosxEscuderia_Escuderias] FOREIGN KEY([IdEsc])
REFERENCES [dbo].[Escuderias] ([IdEsc])
GO
ALTER TABLE [dbo].[PilotosxEscuderia] CHECK CONSTRAINT [FK_PilotosxEscuderia_Escuderias]
GO
ALTER TABLE [dbo].[PilotosxEscuderia]  WITH CHECK ADD  CONSTRAINT [FK_PilotosxEscuderia_Pilotos] FOREIGN KEY([Doc])
REFERENCES [dbo].[Pilotos] ([Doc])
GO
ALTER TABLE [dbo].[PilotosxEscuderia] CHECK CONSTRAINT [FK_PilotosxEscuderia_Pilotos]
GO
ALTER TABLE [dbo].[PilotosxEscuderia]  WITH CHECK ADD  CONSTRAINT [FK_PilotosxEscuderia_Temporadas] FOREIGN KEY([AñoTemp])
REFERENCES [dbo].[Temporadas] ([AñoTemp])
GO
ALTER TABLE [dbo].[PilotosxEscuderia] CHECK CONSTRAINT [FK_PilotosxEscuderia_Temporadas]
GO
ALTER TABLE [dbo].[PtsTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PtsTemporada_PtsTemporada1] FOREIGN KEY([IdPrue])
REFERENCES [dbo].[TiposPrueba] ([IdPrue])
GO
ALTER TABLE [dbo].[PtsTemporada] CHECK CONSTRAINT [FK_PtsTemporada_PtsTemporada1]
GO
ALTER TABLE [dbo].[PtsTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PtsTemporada_Temporadas] FOREIGN KEY([AñoTemp])
REFERENCES [dbo].[Temporadas] ([AñoTemp])
GO
ALTER TABLE [dbo].[PtsTemporada] CHECK CONSTRAINT [FK_PtsTemporada_Temporadas]
GO
ALTER TABLE [dbo].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_Carreras] FOREIGN KEY([IdCar])
REFERENCES [dbo].[Carreras] ([IdCar])
GO
ALTER TABLE [dbo].[Resultados] CHECK CONSTRAINT [FK_Resultados_Carreras]
GO
ALTER TABLE [dbo].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_Pilotos] FOREIGN KEY([Doc])
REFERENCES [dbo].[Pilotos] ([Doc])
GO
ALTER TABLE [dbo].[Resultados] CHECK CONSTRAINT [FK_Resultados_Pilotos]
GO
ALTER TABLE [dbo].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_PtsTemporada] FOREIGN KEY([IdPts])
REFERENCES [dbo].[PtsTemporada] ([IdPts])
GO
ALTER TABLE [dbo].[Resultados] CHECK CONSTRAINT [FK_Resultados_PtsTemporada]
GO
ALTER TABLE [dbo].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_TiposLlanta] FOREIGN KEY([IdLla])
REFERENCES [dbo].[TiposLlanta] ([IdLlanta])
GO
ALTER TABLE [dbo].[Resultados] CHECK CONSTRAINT [FK_Resultados_TiposLlanta]
GO
ALTER TABLE [dbo].[Carreras]  WITH CHECK ADD  CONSTRAINT [CK_Carreras] CHECK  (([Fecha]<=getdate()))
GO
ALTER TABLE [dbo].[Carreras] CHECK CONSTRAINT [CK_Carreras]
GO
ALTER TABLE [dbo].[PilotosxEscuderia]  WITH CHECK ADD  CONSTRAINT [CK_PilotosxEscuderia] CHECK  (([Salario]>(10000)))
GO
ALTER TABLE [dbo].[PilotosxEscuderia] CHECK CONSTRAINT [CK_PilotosxEscuderia]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Carreras"
            Begin Extent = 
               Top = 110
               Left = 140
               Bottom = 240
               Right = 310
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Cantidad de carreras por temporadas'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Cantidad de carreras por temporadas'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Carreras"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Circuitos"
            Begin Extent = 
               Top = 23
               Left = 276
               Bottom = 119
               Right = 446
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposPrueba"
            Begin Extent = 
               Top = 165
               Left = 240
               Bottom = 261
               Right = 410
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Carreras-Circuito-TipoPrueba'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Carreras-Circuito-TipoPrueba'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Carreras"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Resultados"
            Begin Extent = 
               Top = 4
               Left = 503
               Bottom = 134
               Right = 673
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pilotos"
            Begin Extent = 
               Top = 19
               Left = 763
               Bottom = 115
               Right = 933
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PtsTemporada"
            Begin Extent = 
               Top = 146
               Left = 701
               Bottom = 276
               Right = 871
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposLlanta"
            Begin Extent = 
               Top = 82
               Left = 292
               Bottom = 178
               Right = 462
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposPrueba"
            Begin Extent = 
               Top = 211
               Left = 234
               Bottom = 307
               Right = 404
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Wid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Resultados de carreras (Piloto, fecha, posicion, puntos, llanta, prueba)'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'th = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Resultados de carreras (Piloto, fecha, posicion, puntos, llanta, prueba)'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Resultados de carreras (Piloto, fecha, posicion, puntos, llanta, prueba)'
GO
USE [master]
GO
ALTER DATABASE [Formula1_373886] SET  READ_WRITE 
GO
