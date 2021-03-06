USE [cinefilo]
GO
/****** Object:  Table [dbo].[ACTORES]    Script Date: 08/04/2014 9:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACTORES](
	[dni] [nvarchar](9) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[edad] [int] NULL,
	[sexo] [nvarchar](6) NULL,
 CONSTRAINT [PK_ACTORES] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PAPEL]    Script Date: 08/04/2014 9:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAPEL](
	[dni] [nvarchar](9) NOT NULL,
	[id_pelicula] [int] NOT NULL,
	[id_tipo_papel] [int] NOT NULL,
 CONSTRAINT [PK_PAPEL] PRIMARY KEY CLUSTERED 
(
	[dni] ASC,
	[id_pelicula] ASC,
	[id_tipo_papel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PELICULAS]    Script Date: 08/04/2014 9:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PELICULAS](
	[id_pelicula] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [nvarchar](50) NOT NULL,
	[director] [nvarchar](50) NULL,
 CONSTRAINT [PK_PELICULAS] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TEMAS]    Script Date: 08/04/2014 9:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TEMAS](
	[id_tema] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TEMAS] PRIMARY KEY CLUSTERED 
(
	[id_tema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TEMAS_PEL]    Script Date: 08/04/2014 9:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEMAS_PEL](
	[id_pelicula] [int] NOT NULL,
	[id_tema] [int] NOT NULL,
 CONSTRAINT [PK_TEMAS_PEL] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC,
	[id_tema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIPOS_PAPEL]    Script Date: 08/04/2014 9:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOS_PAPEL](
	[id_tipos] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TIPOS_PAPEL] PRIMARY KEY CLUSTERED 
(
	[id_tipos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'11111112', N'Pepe Reina', 43, N'Hombre')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570768', N'Hugh Grant', 42, N'Hombre')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570769', N'Dennis Quaid', 50, N'Hombre')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570770', N'Willem Dafoe', 60, N'Hombre')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570771', N'Keanu Reeves', 42, N'Hombre')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570772', N'Clint Eastwood', 65, N'Hombre')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570773', N'Kim Basinger', 53, N'Mujer')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570774', N'Monica Bellucci', 42, N'Mujer')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570775', N'Halle Berry', 40, N'Mujer')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570776', N'Rene Russo', 52, N'Mujer')
INSERT [dbo].[ACTORES] ([dni], [nombre], [edad], [sexo]) VALUES (N'46570777', N'Salma Hayed', 38, N'Mujer')
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'11111112', 1, 2)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'11111112', 2, 2)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'11111112', 7, 1)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'11111112', 7, 3)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'11111112', 16, 2)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570768', 1, 1)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570768', 2, 1)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570768', 3, 2)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570768', 6, 1)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570768', 12, 2)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570771', 11, 1)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570775', 1, 2)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570777', 7, 1)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570777', 9, 1)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570777', 10, 1)
INSERT [dbo].[PAPEL] ([dni], [id_pelicula], [id_tipo_papel]) VALUES (N'46570777', 17, 2)
SET IDENTITY_INSERT [dbo].[PELICULAS] ON 

INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (1, N'American Dreamz', N'Paul Weitz')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (2, N'Amor en defensa propia', N'Rafa Russo')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (3, N'Camino a la gloria', N'James Gartner')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (4, N'Cuando llama un  extraño', N'Simon West')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (5, N'Diario de un ejecutivo agresivo', N'Mike Binder')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (6, N'El juego de los idiotas 2', N'Francis Veber')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (7, N'En la tiniebla', N'Craig Rosenberg')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (8, N'El asesino de Richard Nixon', N'Niels Mueller')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (9, N'Fearless.Sin miedo', N'Ronny Yu')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (10, N'Galatasaray', N'Hannes Stöhr')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (11, N'Hacia el sur', N'Laurent Cantet')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (12, N'Heróes imaginarios', N'Dan Harris')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (13, N'La condesa rusa', N'James Ivory')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (14, N'La dignidad de los nadie', N'Fernando E. Solanas')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (15, N'La profecía', N'John Moore')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (16, N'Paparazzi', N'Paul Abascal')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (17, N'Promedio rojo', N'Nicolas Lopez')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (18, N'The king', N'James Marsh')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (19, N'Thumbsucker', N'Mike Mills')
INSERT [dbo].[PELICULAS] ([id_pelicula], [titulo], [director]) VALUES (20, N'El gato con Botas', N'Antonio Banderas')
SET IDENTITY_INSERT [dbo].[PELICULAS] OFF
SET IDENTITY_INSERT [dbo].[TEMAS] ON 

INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (5, N'Acción')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (13, N'Ciencia ficción')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (4, N'Comedia')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (7, N'Dibujos animados')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (6, N'Documental')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (1, N'Drama')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (15, N'El tema que no estaba')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (28, N'Hola')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (3, N'Intriga')
INSERT [dbo].[TEMAS] ([id_tema], [descripcion]) VALUES (2, N'Terror')
SET IDENTITY_INSERT [dbo].[TEMAS] OFF
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (2, 1)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (3, 1)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (4, 2)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (4, 3)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (5, 4)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (6, 4)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (7, 3)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (8, 1)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (8, 3)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (9, 5)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (10, 4)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (11, 1)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (12, 1)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (13, 1)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (14, 6)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (15, 2)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (15, 3)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (16, 3)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (17, 4)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (18, 1)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (19, 1)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (19, 4)
INSERT [dbo].[TEMAS_PEL] ([id_pelicula], [id_tema]) VALUES (20, 7)
SET IDENTITY_INSERT [dbo].[TIPOS_PAPEL] ON 

INSERT [dbo].[TIPOS_PAPEL] ([id_tipos], [descripcion]) VALUES (12, N'Artista invitado')
INSERT [dbo].[TIPOS_PAPEL] ([id_tipos], [descripcion]) VALUES (8, N'Comparsa')
INSERT [dbo].[TIPOS_PAPEL] ([id_tipos], [descripcion]) VALUES (3, N'Extra')
INSERT [dbo].[TIPOS_PAPEL] ([id_tipos], [descripcion]) VALUES (7, N'Personaje visitante')
INSERT [dbo].[TIPOS_PAPEL] ([id_tipos], [descripcion]) VALUES (1, N'Principal')
INSERT [dbo].[TIPOS_PAPEL] ([id_tipos], [descripcion]) VALUES (2, N'Secundario')
SET IDENTITY_INSERT [dbo].[TIPOS_PAPEL] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_TEMAS]    Script Date: 08/04/2014 9:01:05 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_TEMAS] ON [dbo].[TEMAS]
(
	[descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_TIPOS_PAPEL]    Script Date: 08/04/2014 9:01:05 ******/
ALTER TABLE [dbo].[TIPOS_PAPEL] ADD  CONSTRAINT [IX_TIPOS_PAPEL] UNIQUE NONCLUSTERED 
(
	[descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PAPEL]  WITH CHECK ADD  CONSTRAINT [FK_PAPEL_ACTORES] FOREIGN KEY([dni])
REFERENCES [dbo].[ACTORES] ([dni])
GO
ALTER TABLE [dbo].[PAPEL] CHECK CONSTRAINT [FK_PAPEL_ACTORES]
GO
ALTER TABLE [dbo].[PAPEL]  WITH CHECK ADD  CONSTRAINT [FK_PAPEL_PELICULAS] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[PELICULAS] ([id_pelicula])
GO
ALTER TABLE [dbo].[PAPEL] CHECK CONSTRAINT [FK_PAPEL_PELICULAS]
GO
ALTER TABLE [dbo].[PAPEL]  WITH CHECK ADD  CONSTRAINT [FK_PAPEL_TIPOS_PAPEL] FOREIGN KEY([id_tipo_papel])
REFERENCES [dbo].[TIPOS_PAPEL] ([id_tipos])
GO
ALTER TABLE [dbo].[PAPEL] CHECK CONSTRAINT [FK_PAPEL_TIPOS_PAPEL]
GO
ALTER TABLE [dbo].[TEMAS_PEL]  WITH CHECK ADD  CONSTRAINT [FK_TEMAS_PEL_PELICULAS] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[PELICULAS] ([id_pelicula])
GO
ALTER TABLE [dbo].[TEMAS_PEL] CHECK CONSTRAINT [FK_TEMAS_PEL_PELICULAS]
GO
ALTER TABLE [dbo].[TEMAS_PEL]  WITH CHECK ADD  CONSTRAINT [FK_TEMAS_PEL_TEMAS] FOREIGN KEY([id_tema])
REFERENCES [dbo].[TEMAS] ([id_tema])
GO
ALTER TABLE [dbo].[TEMAS_PEL] CHECK CONSTRAINT [FK_TEMAS_PEL_TEMAS]
GO
USE [master]
GO
ALTER DATABASE [cinefilo] SET  READ_WRITE 
GO
