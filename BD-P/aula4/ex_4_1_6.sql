DROP TABLE IF EXISTS Atl_Aluno
DROP TABLE IF EXISTS Atl_Realiza
DROP TABLE IF EXISTS Atl_Atividade
DROP TABLE IF EXISTS Atl_Turma
DROP TABLE IF EXISTS Atl_Encarregado_De_Educacao
DROP TABLE IF EXISTS Atl_Responsavel
DROP TABLE IF EXISTS Atl_Professor
DROP TABLE IF EXISTS Atl_Pessoa




CREATE TABLE Atl_Pessoa(
    Numero_CC INT NOT NULL,
    Nome VARCHAR(128) NOT NULL,
    Morada VARCHAR(128) NOT NULL,
    Email VARCHAR(128) NOT NULL,
    Data_Nascimento VARCHAR(128) NOT NULL,
    Telefone INT NOT NULL,
    PRIMARY KEY (Numero_CC)
)

CREATE TABLE Atl_Professor(
    Num_Funcionario INT NOT NULL,
    Numero_CC INT NOT NULL,
    PRIMARY KEY (Num_Funcionario)
)

CREATE TABLE Atl_Encarregado_De_Educacao(
    Numero_CC INT NOT NULL,
    PRIMARY KEY (Numero_CC)
)

CREATE TABLE Atl_Responsavel(
    Numero_CC INT NOT NULL,
    PRIMARY KEY (Numero_CC)
)

CREATE TABLE Atl_Turma(
    ID INT NOT NULL,
    Classe INT NOT NULL,
    Designacao VARCHAR(4) NOT NULL,
    Ano INT NOT NULL,
    Num_Max_Alunos INT NOT NULL,
    Professor_Num INT NOT NULL REFERENCES Atl_Professor(Num_Funcionario),
    PRIMARY KEY (ID)

)

CREATE TABLE Atl_Atividade(
    ID INT NOT NULL,
    Designacao VARCHAR(128) NOT NULL,
    Custo_Financeiro INT NOT NULL,
    PRIMARY KEY (ID)

)

CREATE TABLE Atl_Realiza(
    Atividade_ID INT NOT NULL REFERENCES Atl_Atividade(ID),
    Turma_ID INT NOT NULL REFERENCES Atl_Turma(ID),
    Professor_Num INT NOT NULL REFERENCES Atl_Professor(Num_Funcionario),
    PRIMARY KEY (Atividade_ID,Turma_ID,Professor_Num)
)

CREATE TABLE Atl_Aluno(
    Numero_CC INT NOT NULL,
    Nome VARCHAR(128) NOT NULL,
    Morada VARCHAR(128) NOT NULL,
    Data_Nascimento VARCHAR(128) NOT NULL,
    Professor_Num INT NOT NULL REFERENCES Atl_Professor(Num_Funcionario),
    PRIMARY KEY (Numero_CC)
)