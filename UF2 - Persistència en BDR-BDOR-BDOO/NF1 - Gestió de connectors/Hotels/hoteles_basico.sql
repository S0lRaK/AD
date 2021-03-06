USE [hoteles_basico]
GO
/****** Object:  Table [dbo].[cadenas]    Script Date: 26/11/2013 5:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cadenas](
	[cif] [varchar](9) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[dir_fis] [varchar](50) NOT NULL,
 CONSTRAINT [pk_cadenas] PRIMARY KEY CLUSTERED 
(
	[cif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ciudades]    Script Date: 26/11/2013 5:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ciudades](
	[id_ciudad] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
 CONSTRAINT [pk_ciudades] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoteles]    Script Date: 26/11/2013 5:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoteles](
	[id_ciudad] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[categoria] [int] NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[tipo] [varchar](15) NOT NULL,
	[cif] [varchar](9) NOT NULL,
 CONSTRAINT [pk_hoteles] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC,
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A21394990', N'Intercontinental', N'Paseo de Gracia 120')
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A23545451', N'NH', N'Av. Diagonal 230')
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473819', N'NH', N'Paseo de Gracia 120')
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473820', N'Intercotinental', N'Av. Diagonal 230')
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473821', N'Sol Meliá', N'C. Rosellón 123')
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473822', N'HUSA', N'C. Urgel 45')
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473823', N'Hilton', N'Pase de San Juan 123')
INSERT [dbo].[cadenas] ([cif], [nombre], [dir_fis]) VALUES (N'A65473824', N'Tryp', N'Av. Diagonal 130')
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (1, N'Barcelona')
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (2, N'Madrid')
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (3, N'Valencia')
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (4, N'Bilbao')
INSERT [dbo].[ciudades] ([id_ciudad], [nombre]) VALUES (5, N'Sevilla')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (1, N'Alejandría', 5, N'Pérez Galdós, 231', 934215645, N'MONTAÑA', N'A21394990')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (1, N'Alexandra', 4, N'Plaza Cataluña 12', 934567723, N'PLAYA', N'A65473819')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (1, N'Barcelona', 4, N'Santa Ana 33', 934453812, N'PLAYA', N'A65473824')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (1, N'Calderon', 4, N'Rambla Cataluña 23', 933324156, N'PLAYA', N'A65473819')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (1, N'Condor', 5, N'Mallorca 3', 932228409, N'PLAYA', N'A65473821')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (1, N'Presidente', 4, N'Paseo Marítimo 1', 934446944, N'PLAYA', N'A65473824')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (1, N'Princesa Sofia', 4, N'Pelayo 14', 934465201, N'PLAYA', N'A65473820')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (1, N'Urquinaona', 4, N'Urquinaona, 9', 934445566, N'MONTAÑA', N'A65473824')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (2, N'Cibeles', 5, N'Paseo de la Castellana 287', 917643212, N'MONTAÑA', N'A65473821')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (2, N'Covadonga', 3, N'Paseo de la Castellana 234', 916231099, N'MONTAÑA', N'A65473819')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (2, N'Imperial', 3, N'Plaza España, 2', 91222343, N'MONTAÑA', N'A65473821')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (2, N'Juan Carlos I', 5, N'Lincoln 34', 914487213, N'MONTAÑA', N'A65473820')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (2, N'Madrid', 5, N'Gaudí 31', 912310076, N'MONTAÑA', N'A65473823')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (2, N'Olimpiadas', 4, N'Gran Vía, 324', 912223322, N'MONTAÑA', N'A65473823')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (2, N'Oriente', 5, N'Gran Via 345', 915438299, N'MONTAÑA', N'A65473819')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (3, N'Moderno', 3, N'Aragón 21', 949075512, N'PLAYA', N'A65473821')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (3, N'Suizo', 4, N'Miramar 34', 946339617, N'PLAYA', N'A65473819')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (3, N'Valencia', 5, N'Mestalla 7', 946334217, N'MONTAÑA', N'A65473823')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (4, N'Pepe', 5, N'Ria de Guevara 23', 986756432, N'PLAYA', N'A65473822')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (4, N'Regina', 3, N'Paseo Central 20', 965573090, N'MONTAÑA', N'A65473819')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (5, N'Condado', 4, N'Brasil 34', 984445122, N'MONTAÑA', N'A65473819')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (5, N'Everest', 3, N'Cisneros', 984125673, N'MONTAÑA', N'A65473821')
INSERT [dbo].[hoteles] ([id_ciudad], [nombre], [categoria], [direccion], [telefono], [tipo], [cif]) VALUES (5, N'Toros', 3, N'Mayoral, 32', 986333333, N'MONTAÑA', N'A65473822')
ALTER TABLE [dbo].[hoteles]  WITH CHECK ADD  CONSTRAINT [fk_hoteles_cadenas] FOREIGN KEY([cif])
REFERENCES [dbo].[cadenas] ([cif])
GO
ALTER TABLE [dbo].[hoteles] CHECK CONSTRAINT [fk_hoteles_cadenas]
GO
ALTER TABLE [dbo].[hoteles]  WITH CHECK ADD  CONSTRAINT [fk_hoteles_ciudades] FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[ciudades] ([id_ciudad])
GO
ALTER TABLE [dbo].[hoteles] CHECK CONSTRAINT [fk_hoteles_ciudades]
GO
USE [master]
GO
ALTER DATABASE [hoteles_basico] SET  READ_WRITE 
GO
