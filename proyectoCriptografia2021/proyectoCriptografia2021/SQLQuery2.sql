CREATE TABLE MENSAJE(
IdMensaje int not null primary key identity,
mensajeOriginal varchar(MAX),
mensajeCifrado varchar(MAX),
idMetodoCifrado int,
foreign key (idMetodoCifrado) REFERENCES Metodo_Cifrado(idCifrado)
)