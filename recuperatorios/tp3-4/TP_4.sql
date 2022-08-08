USE [master]
GO
/****** Object:  Database [TP_4]    Script Date: 8/8/2022 10:28:08 ******/
CREATE DATABASE [TP_4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP_4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP_4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP_4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP_4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP_4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP_4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP_4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP_4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP_4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP_4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP_4] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP_4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP_4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP_4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP_4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP_4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP_4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP_4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP_4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP_4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP_4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP_4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP_4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP_4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP_4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP_4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP_4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP_4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP_4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP_4] SET  MULTI_USER 
GO
ALTER DATABASE [TP_4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP_4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP_4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP_4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP_4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP_4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP_4] SET QUERY_STORE = OFF
GO
USE [TP_4]
GO
/****** Object:  Table [dbo].[Afiliado]    Script Date: 8/8/2022 10:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Afiliado](
	[IdPersona] [int] NOT NULL,
	[IsActivo] [bit] NOT NULL,
 CONSTRAINT [PK_Afiliado_1] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Atencion]    Script Date: 8/8/2022 10:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atencion](
	[IdAfiliado] [int] NOT NULL,
	[IdProfesional] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Atencion_1] PRIMARY KEY CLUSTERED 
(
	[IdAfiliado] ASC,
	[IdProfesional] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 8/8/2022 10:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [int] NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesional]    Script Date: 8/8/2022 10:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesional](
	[IdPersona] [int] NOT NULL,
	[Especialidad] [int] NOT NULL,
 CONSTRAINT [PK_Profesional] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Afiliado] ([IdPersona], [IsActivo]) VALUES (46, 1)
GO
INSERT [dbo].[Afiliado] ([IdPersona], [IsActivo]) VALUES (1006, 1)
GO
INSERT [dbo].[Afiliado] ([IdPersona], [IsActivo]) VALUES (1014, 1)
GO
INSERT [dbo].[Afiliado] ([IdPersona], [IsActivo]) VALUES (1015, 1)
GO
INSERT [dbo].[Afiliado] ([IdPersona], [IsActivo]) VALUES (1016, 1)
GO
INSERT [dbo].[Atencion] ([IdAfiliado], [IdProfesional], [Fecha]) VALUES (1014, 1011, CAST(N'2022-08-08' AS Date))
GO
INSERT [dbo].[Atencion] ([IdAfiliado], [IdProfesional], [Fecha]) VALUES (1014, 1012, CAST(N'2022-09-15' AS Date))
GO
INSERT [dbo].[Atencion] ([IdAfiliado], [IdProfesional], [Fecha]) VALUES (1015, 1010, CAST(N'2022-08-07' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (46, N'Lezcano', N'Hugo', 12345678, N'papa@hotmail.com', 123456)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1006, N'Perez', N'Enzo', 12345678, N'enzo@gmail.com', 123456)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1008, N'Perez', N'Juan', 12345678, N'juan@gmail.com', 123456)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1009, N'Perez', N'Pedro', 12345678, N'juan@gmail.com', 123456)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1010, N'Perez', N'Jorge', 12345678, N'juan@gmail.com', 123456)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1011, N'Perez', N'Maria', 12345678, N'juan@gmail.com', 123456)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1012, N'Perez', N'Lucia', 12345678, N'juan@gmail.com', 123456)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1013, N'Perez', N'Dario', 12345678, N'juan@gmail.com', 123456)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1014, N'Lezcano', N'Camila', 37467112, N'camilezucol@gmail.com', 12345678)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1015, N'testApellido', N'testNombre', 12345678, N'test@gmail.com', 424511)
GO
INSERT [dbo].[Persona] ([Id], [Apellido], [Nombre], [DNI], [Email], [Telefono]) VALUES (1016, N'testApellido', N'testNombre', 12345678, N'test@gmail.com', 424511)
GO
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
INSERT [dbo].[Profesional] ([IdPersona], [Especialidad]) VALUES (1008, 1)
GO
INSERT [dbo].[Profesional] ([IdPersona], [Especialidad]) VALUES (1009, 2)
GO
INSERT [dbo].[Profesional] ([IdPersona], [Especialidad]) VALUES (1010, 3)
GO
INSERT [dbo].[Profesional] ([IdPersona], [Especialidad]) VALUES (1011, 4)
GO
INSERT [dbo].[Profesional] ([IdPersona], [Especialidad]) VALUES (1012, 5)
GO
INSERT [dbo].[Profesional] ([IdPersona], [Especialidad]) VALUES (1013, 6)
GO
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Persona] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Persona] ([Id])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Persona]
GO
ALTER TABLE [dbo].[Atencion]  WITH CHECK ADD  CONSTRAINT [FK_Atencion_Atencion] FOREIGN KEY([IdAfiliado], [IdProfesional], [Fecha])
REFERENCES [dbo].[Atencion] ([IdAfiliado], [IdProfesional], [Fecha])
GO
ALTER TABLE [dbo].[Atencion] CHECK CONSTRAINT [FK_Atencion_Atencion]
GO
ALTER TABLE [dbo].[Atencion]  WITH CHECK ADD  CONSTRAINT [FK_Atencion_Profesional] FOREIGN KEY([IdProfesional])
REFERENCES [dbo].[Profesional] ([IdPersona])
GO
ALTER TABLE [dbo].[Atencion] CHECK CONSTRAINT [FK_Atencion_Profesional]
GO
ALTER TABLE [dbo].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_Persona] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Persona] ([Id])
GO
ALTER TABLE [dbo].[Profesional] CHECK CONSTRAINT [FK_Profesional_Persona]
GO
USE [master]
GO
ALTER DATABASE [TP_4] SET  READ_WRITE 
GO
