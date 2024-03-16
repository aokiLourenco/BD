Use p1g2
GO

DROP TABLE IF EXISTS SNS_Produz
DROP TABLE IF EXISTS SNS_Comercializa
DROP TABLE IF EXISTS SNS_Farmaceutica
DROP TABLE IF EXISTS SNS_Medicamento
DROP TABLE IF EXISTS SNS_Prescricao
DROP TABLE IF EXISTS SNS_Medico
DROP TABLE IF EXISTS SNS_Paciente
DROP TABLE IF EXISTS SNS_Farmacia
GO

CREATE TABLE SNS_Farmacia (
    NIF INT NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Endereco VARCHAR(100) NOT NULL,
    Telefone INT NOT NULL,
)
GO

CREATE TABLE SNS_Paciente (
    Num_utente INT NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    DataNascimento DATE NOT NULL,
    Endereco VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE SNS_Medico (
    Num_identificacao INT NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Especialidade VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE SNS_Prescricao (
    Numero_prescricao INT NOT NULL IDENTITY PRIMARY KEY,
    Data DATE NOT NULL,
    Medico_Num_identificacao INT NOT NULL REFERENCES SNS_Medico (Num_identificacao),
    Paciente_Num_utente INT NOT NULL REFERENCES SNS_Paciente (Num_utente),
    Farmacia_NIF INT NOT NULL REFERENCES SNS_Farmacia (NIF),
)
GO

CREATE TABLE SNS_Medicamento (
    Nome_comercial VARCHAR(50) NOT NULL PRIMARY KEY,
    Prescricao_numero INT NOT NULL REFERENCES SNS_Prescricao (Numero_prescricao),
    Formula VARCHAR(50) NOT NULL,
)

CREATE TABLE SNS_Farmaceutica (
    Num_registo_nacional INT NOT NULL PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Endereco VARCHAR(100) NOT NULL,
    Telefone INT NOT NULL,
)
GO

CREATE TABLE SNS_Comercializa (
    Farmacia_NIF INT NOT NULL REFERENCES SNS_Farmacia (NIF),
    Farmaco_nome_comercial VARCHAR(50) NOT NULL REFERENCES SNS_Medicamento (Nome_comercial),
    PRIMARY KEY (Farmacia_NIF, Farmaco_nome_comercial),
)

CREATE TABLE SNS_Produz (
    Prescricao_num_unico INT NOT NULL REFERENCES SNS_Prescricao (Numero_prescricao),
    Farmaco_nome_comercial VARCHAR(50) NOT NULL REFERENCES SNS_Medicamento (Nome_comercial),
    Farmaceutica_NRN INT NOT NULL REFERENCES SNS_Farmaceutica (Num_registo_nacional),
    Medico_Num_identificacao INT NOT NULL REFERENCES SNS_Medico (Num_identificacao),
    PRIMARY KEY (Prescricao_num_unico, Farmaco_nome_comercial, Farmaceutica_NRN, Medico_Num_identificacao),
)
GO