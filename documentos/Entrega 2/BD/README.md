CREATE DATABASE Messier;
use Messier;

CREATE TABLE Game (
    ID_Game INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(100) NOT NULL,
    descricao TEXT
);

CREATE TABLE Escola (
    ID_Escola INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(100) NOT NULL
);

CREATE TABLE Pacote (
    ID_Pacote INT PRIMARY KEY AUTO_INCREMENT,
    Plano VARCHAR(50) NOT NULL,
    idEscola INT,

    FOREIGN KEY (idEscola)
    REFERENCES Escola(ID_Escola)
);

CREATE TABLE PacoteGame (
    ID_Game INT,
    ID_Pacote INT,

    PRIMARY KEY (ID_Game, ID_Pacote),

    FOREIGN KEY (ID_Game)
    REFERENCES Game(ID_Game),

    FOREIGN KEY (ID_Pacote)
    REFERENCES Pacote(ID_Pacote)
);

CREATE TABLE Acesso_Log (
    ID_Acesso INT PRIMARY KEY AUTO_INCREMENT,
    data_hora DATETIME NOT NULL,
    idGame INT,
    idEscola INT,

    FOREIGN KEY (idGame)
    REFERENCES Game(ID_Game),

    FOREIGN KEY (idEscola)
    REFERENCES Escola(ID_Escola)
);

CREATE TABLE IP_Autorizado (
    ID_IP INT PRIMARY KEY AUTO_INCREMENT,
    IP VARCHAR(45) NOT NULL,
    idEscola INT,

    FOREIGN KEY (idEscola)
    REFERENCES Escola(ID_Escola)
);
