DROP TABLE IF EXISTS Conferencias_Tem
DROP TABLE IF EXISTS Conferencias_Nao_Estudante
DROP TABLE IF EXISTS Conferencias_Estudante
DROP TABLE IF EXISTS Conferencias_Participante
DROP TABLE IF EXISTS Conferencias_Autor
DROP TABLE IF EXISTS Conferencias_Pessoa
DROP TABLE IF EXISTS Conferencias_Instituicao
DROP TABLE IF EXISTS Conferencias_Artigos
DROP TABLE IF EXISTS Conferencias_Conferencia

CREATE TABLE Conferencias_Conferencia(
    Codigo INT NOT NULL,
    PRIMARY KEY(Codigo)
)

CREATE TABLE Conferencias_Artigos(
    Codigo INT NOT NULL,
    Conferencia_Codigo INT NOT NULL REFERENCES Conferencias_Conferencia(Codigo),
    Titulo VARCHAR(128) NOT NULL,
    Num_Registos INT NOT NULL,
    PRIMARY KEY(Codigo, Conferencia_Codigo)
)

CREATE TABLE Conferencias_Instituicao(
    Codigo INT NOT NULL,
    Nome VARCHAR(128) NOT NULL,
    Morada VARCHAR(128) NOT NULL,
    PRIMARY KEY(Codigo)
)

CREATE TABLE Conferencias_Pessoa(
    Codigo INT NOT NULL,
    Instituicao_Codigo INT NOT NULL REFERENCES Conferencias_Instituicao(Codigo),
    Nome VARCHAR(128) NOT NULL,
    Email VARCHAR(128) NOT NULL,
    PRIMARY KEY(Codigo)
)

CREATE TABLE Conferencias_Autor(
    Codigo INT NOT NULL,
    Pessoa_Codigo INT NOT NULL,
    FOREIGN KEY (Pessoa_Codigo) REFERENCES Conferencias_Pessoa(Codigo),
    PRIMARY KEY(Codigo,Pessoa_Codigo)
)


CREATE TABLE Conferencias_Participante(
    Codigo INT NOT NULL,
    Pessoa_Codigo INT NOT NULL REFERENCES Conferencias_Pessoa(Codigo),
    Conferencia_Codigo INT NOT NULL REFERENCES Conferencias_Conferencia(Codigo),
    Morada VARCHAR(128) NOT NULL,
    Data_Inscricao VARCHAR(10) NOT NULL,
    PRIMARY KEY(Codigo, Pessoa_Codigo)
)

CREATE TABLE Conferencias_Estudante(
    Comprovativo INT NOT NULL,
    Pessoa_Codigo INT NOT NULL,
    Participante_Codigo INT NOT NULL,
    FOREIGN KEY (Participante_Codigo,Pessoa_Codigo) REFERENCES Conferencias_Participante(Codigo,Pessoa_Codigo),
    PRIMARY KEY(Comprovativo)
)

CREATE TABLE Conferencias_Nao_Estudante(
    Referencia_Bancaria INT NOT NULL,
    Pessoa_Codigo INT NOT NULL,
    Participante_Codigo INT NOT NULL,
    FOREIGN KEY (Participante_Codigo,Pessoa_Codigo) REFERENCES Conferencias_Participante(Codigo,Pessoa_Codigo),
    PRIMARY KEY(Referencia_Bancaria,Pessoa_Codigo,Participante_Codigo)
)

CREATE TABLE Conferencias_Tem(
    Autor_Codigo INT NOT NULL,
    Pessoa_Codigo INT NOT NULL,
    Artigos_Codigo INT NOT NULL, 
    Conferencia_Codigo INT NOT NULL,
    FOREIGN KEY (Artigos_Codigo, Conferencia_Codigo) REFERENCES Conferencias_Artigos(Codigo,Conferencia_Codigo),
    FOREIGN KEY (Autor_Codigo, Pessoa_Codigo) REFERENCES Conferencias_Autor(Codigo, Pessoa_Codigo),
    PRIMARY KEY(Autor_Codigo, Artigos_Codigo)
)