CREATE TABLE Inss (
    Id          INTEGER         PRIMARY KEY AUTOINCREMENT
                                NOT NULL,
    Competencia DATE            NOT NULL
                                UNIQUE,
    Faixa     INTEGER NOT NULL,
    Teto_Faixa DECIMAL(10,2) NOT NULL,
    Porcentagem DECIMAL(3,2) NOT NULL
);
CREATE TABLE Irrf (
    Id          INTEGER         PRIMARY KEY AUTOINCREMENT
                                NOT NULL,
    Competencia DATE            NOT NULL
                                UNIQUE,
    Limite     DECIMAL(10,2) NOT NULL,
    Porcentagem DECIMAL(3,2) NOT NULL,
    Desconto DECIMAL(10,2) NOT NULL
);

CREATE TABLE Dependente (
    Id          INTEGER         PRIMARY KEY AUTOINCREMENT
                                NOT NULL,
    Competencia DATE            NOT NULL
                                UNIQUE,
    Valor     DECIMAL (10, 2) NOT NULL
);
