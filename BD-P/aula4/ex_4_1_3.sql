Use p1g2
GO

DROP TABLE IF EXISTS Stock_Tem
DROP TABLE IF EXISTS Stock_Encomenda
DROP TABLE IF EXISTS Stock_Fornecedor
DROP TABLE IF EXISTS Stock_Condicoes_Pagamento
DROP TABLE IF EXISTS Stock_Tipo_Fornecedor
DROP TABLE IF EXISTS Stock_Produto
DROP TABLE IF EXISTS Stock_Armazem
GO

CREATE TABLE Stock_Armazem (
    Codigo VARCHAR(8) NOT NULL PRIMARY KEY,
    Morada VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE Stock_Produto (
    Codigo VARCHAR(8) NOT NULL PRIMARY KEY,
    ArmazenCodigo VARCHAR(8) NOT NULL REFERENCES Stock_Armazem (Codigo), 
    Nome VARCHAR(50) NOT NULL,
    IVA FLOAT NOT NULL,
    Preco MONEY NOT NULL,
)
GO

CREATE TABLE Stock_Tipo_Fornecedor (
    Codigo VARCHAR(8) NOT NULL PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE Stock_Condicoes_Pagamento (
    Codigo VARCHAR(8) NOT NULL PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Prazo DATE NOT NULL,
)
GO

CREATE TABLE Stock_Fornecedor (
    Codigo VARCHAR(8) NOT NULL PRIMARY KEY,
    Tipo_Fornecedor_codigo VARCHAR(8) NOT NULL REFERENCES Stock_Tipo_Fornecedor (Codigo),
    Condicoes_Pagamento_codigo VARCHAR(8) NOT NULL REFERENCES Stock_Condicoes_Pagamento (Codigo),
    Nome VARCHAR(50) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    NIF INT NOT NULL,
)
GO

CREATE TABLE Stock_Encomenda (
    Numero INT NOT NULL PRIMARY KEY,
    Fornecedor_Codigo VARCHAR(8) NOT NULL REFERENCES Stock_Fornecedor (Codigo),
    Produto_Codigo VARCHAR(8) NOT NULL REFERENCES Stock_Produto (Codigo),
    Data DATE NOT NULL,
    Quantidade INT NOT NULL,
)
GO

CREATE TABLE Stock_Tem (
    Produto_codigo VARCHAR(8) NOT NULL REFERENCES Stock_Produto (Codigo),
    Encomenda_Numero INT NOT NULL REFERENCES Stock_Encomenda (Numero),
)
GO