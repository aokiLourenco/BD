DROP TABLE PRESCRICAO_Presc_farmaco
DROP TABLE PRESCRICAO_Prescricao
DROP TABLE PRESCRICAO_Farmaco
DROP TABLE PRESCRICAO_Farmaceutica
DROP TABLE PRESCRICAO_Farmacia
DROP TABLE PRESCRICAO_Paciente
DROP TABLE PRESCRICAO_Medico

CREATE TABLE PRESCRICAO_Medico(
    numSNS              INT         PRIMARY KEY,
    nome                VARCHAR(45) NOT NULL,
    especialidade       VARCHAR(45),                      
);

CREATE TABLE PRESCRICAO_Paciente(
    numUtente           INT         PRIMARY KEY,
    nome                VARCHAR(45) NOT NULL,
    dataNasc            DATE        NOT NULL,
    endereco            TEXT,
);

CREATE TABLE PRESCRICAO_Farmacia(
    nome                VARCHAR(45) PRIMARY KEY,
    telefone            INT         UNIQUE,
    endereco            TEXT,                      
);

CREATE TABLE PRESCRICAO_Farmaceutica(
    numReg              INT         PRIMARY KEY,
    nome                VARCHAR(45),
    endereco            TEXT,                      
);

CREATE TABLE PRESCRICAO_Farmaco(
    numRegFarm          INT,
    nome                VARCHAR(45),
    formula             TEXT,                      
    PRIMARY KEY (numRegFarm, nome),
	FOREIGN KEY (numRegFarm)REFERENCES PRESCRICAO_Farmaceutica(numReg) ON DELETE NO ACTION ON UPDATE CASCADE,
);

CREATE TABLE PRESCRICAO_Prescricao(
    numPresc            INT         PRIMARY KEY,
    numUtente           INT         NOT NULL REFERENCES PRESCRICAO_Paciente(numUtente) ON DELETE NO ACTION ON UPDATE CASCADE,
    numMedico           INT         NOT NULL REFERENCES PRESCRICAO_Medico(numSNS) ON DELETE NO ACTION ON UPDATE CASCADE,
    farmacia            VARCHAR(45) REFERENCES PRESCRICAO_Farmacia(nome) ON DELETE NO ACTION ON UPDATE CASCADE,
    dataProc            DATE,
);

CREATE TABLE PRESCRICAO_Presc_farmaco(
    numPresc            INT	REFERENCES PRESCRICAO_Prescricao(numPresc) ON DELETE NO ACTION ON UPDATE CASCADE,
    numRegFarm          INT,
    nomeFarmaco         VARCHAR(45),
    FOREIGN KEY (numRegFarm, nomeFarmaco) REFERENCES PRESCRICAO_Farmaco(numRegFarm, nome) ON DELETE NO ACTION ON UPDATE CASCADE,
    PRIMARY KEY (numPresc, numRegFarm, nomeFarmaco),
);