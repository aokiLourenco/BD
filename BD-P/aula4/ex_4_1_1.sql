Use p1g2
GO

DROP TABLE IF EXISTS RentACar_Aluger
DROP TABLE IF EXISTS RentACar_Veiculo
DROP TABLE IF EXISTS RentACar_Cliente
DROP TABLE IF EXISTS RentACar_Balcao
DROP TABLE IF EXISTS RentACar_Similaridade
DROP TABLE IF EXISTS RentACar_Pesado
DROP TABLE IF EXISTS RentACar_Ligeiro
DROP TABLE IF EXISTS RentACar_TipoVeiculo
GO

CREATE TABLE RentACar_TipoVeiculo (
    Codigo INT NOT NULL IDENTITY PRIMARY KEY,
    Designacao VARCHAR(50) NOT NULL,
    ArCondicionado BIT NOT NULL,
)
GO

CREATE TABLE RentACar_Ligeiro (
    CodigoVeiculo INT NOT NULL PRIMARY KEY REFERENCES RentACar_TipoVeiculo (Codigo),
    NLugares INT NOT NULL,
    Portas INT NOT NULL,
    Combustivel VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE RentACar_Pesado (
    CodigoVeiculo INT NOT NULL PRIMARY KEY REFERENCES RentACar_TipoVeiculo (Codigo),
    Passageiros INT NOT NULL,
    Peso INT NOT NULL,
)
GO

CREATE TABLE RentACar_Similaridade (
    Chave1 INT NOT NULL REFERENCES RentACar_TipoVeiculo (Codigo),
    Chave2 INT NOT NULL REFERENCES RentACar_TipoVeiculo (Codigo),
    Similaridade FLOAT NOT NULL,
    PRIMARY KEY (Chave1, Chave2),
)
GO

CREATE TABLE RentACar_Balcao (
    Numero INT PRIMARY KEY,
    Endereco VARCHAR(100) NOT NULL,
    Nome VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE RentACar_Cliente (
    NIF INT PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Endereco VARCHAR(100) NOT NULL,
    NCarta INT NOT NULL,
)
GO

CREATE TABLE RentACar_Veiculo (
    Matricula VARCHAR(10) PRIMARY KEY,
    Ano INT NOT NULL,
    Marca VARCHAR(50) NOT NULL,
    CodigoTipoVeiculo INT NOT NULL REFERENCES RentACar_TipoVeiculo (Codigo),
)
GO

CREATE TABLE RentACar_Aluger (
    Numero INT PRIMARY KEY,
    Duracao INT NOT NULL,
    Data DATE NOT NULL,
    NIFCliente INT NOT NULL REFERENCES RentACar_Cliente (NIF),
    NBalcao INT NOT NULL REFERENCES RentACar_Balcao (Numero),
    MatriculaVeiculo VARCHAR(10) NOT NULL REFERENCES RentACar_Veiculo (Matricula),
)
GO