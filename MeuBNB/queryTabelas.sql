create table Imoveis (
	idImovel int primary key identity(1,1),
    rua varchar(50) not null,
    numero int not null,
    bairro varchar(50) not null,
    cidade varchar(50) not null,
    disponibilidade varchar(20) not null,
    valorDiaria decimal(6,2) not null,
    despesas decimal(6,2),
    tipoImovel varchar(20) not null
);

create table Clientes (
    idCliente int primary key identity(1,1),
    nome varchar(100) not null,
    cpf varchar(14) not null,
    diarias int not null,
    qtdPessoas int not null,
    telefone varchar(20) not null,
    dataInicioReserva date not null,
    dataFimReserva date not null,
    valorPago decimal(8,2) not null,
    formaPagamento varchar(10) not null,
    idImovel int foreign key references Imoveis(idImovel)
);