create database LabVPrograIV

create table T_Pais(
	TPA_ID int identity primary key not null,
	TPA_DESCRIPCION varchar (70) not null
)

create table T_Idioma(
	TDI_ID int identity primary key not null,
	TDI_DECRIPCION varchar(70) not null
)

create table T_Gestion_Prestamo(
	TGP_ID int identity primary key not null,
	TGP_PAIS_ID int not null,
	TGP_HABITANTES int not null,
	TGP_IDIOMA_ID int not null,
	TGP_PIB decimal(18,5),
	TGP_SUPERFICIE int not null,
	TGP_RIESGO_SEGURIDAD char not null,
	TGP_ABLE bit not null
	foreign key (TGP_PAIS_ID)references T_Pais(TPA_ID),
	foreign key (TGP_IDIOMA_ID)references T_Idioma(TDI_ID)
)

