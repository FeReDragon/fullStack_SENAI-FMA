CREATE DATABASE pizzariaLAB365;

CREATE TABLE Massas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    preco DECIMAL(10,2) NOT NULL CHECK(preco > 50),
    tamanho VARCHAR(10) NOT NULL
);

CREATE TABLE Bordas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE Pizzas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_massa INT NOT NULL,
    id_borda INT NOT NULL,
    FOREIGN KEY (id_massa) REFERENCES Massas(id),
    FOREIGN KEY (id_borda) REFERENCES Bordas(id)
);

CREATE TABLE Sabores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE Pizza_Sabor (
    id_pizza INT NOT NULL,
    id_sabor INT NOT NULL,
    PRIMARY KEY (id_pizza, id_sabor),
    FOREIGN KEY (id_pizza) REFERENCES Pizzas(id),
    FOREIGN KEY (id_sabor) REFERENCES Sabores(id)
);

CREATE TABLE Status (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE Pedidos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    data DATE NOT NULL,
    forma_pagamento VARCHAR(20) NOT NULL,
    endereco_entrega VARCHAR(100) NOT NULL,
    id_status INT NOT NULL,
    FOREIGN KEY (id_status) REFERENCES Status(id)
);

CREATE TABLE Pedido_Pizza (
    id_pedido INT NOT NULL,
    id_pizza INT NOT NULL,
    PRIMARY KEY (id_pedido, id_pizza),
    FOREIGN KEY (id_pedido) REFERENCES Pedidos(id),
    FOREIGN KEY (id_pizza) REFERENCES Pizzas(id)
);

INSERT INTO Massas (nome, preco, tamanho) VALUES ('Tradicional', 60.00, 'M'), ('Integral', 65.00, 'M'), ('Tradicional', 75.00, 'G'), ('Integral', 80.00, 'G');

INSERT INTO Bordas (nome) VALUES ('Catupiry'), ('Cheddar'), ('Chocolate preto'), ('Chocolate branco');

INSERT INTO Pizzas (id_massa, id_borda) VALUES (1, 1), (2, 2);

INSERT INTO Sabores (nome) VALUES ('Calabresa'), ('Margherita'), ('Frango com catupiry');

INSERT INTO Pizza_Sabor (id_pizza, id_sabor) VALUES (1, 1), (1, 2), (2, 3);

INSERT INTO Status (nome) VALUES ('Pedido realizado'), ('Pedido em preparo'), ('Pedido entregue');

INSERT INTO Pedidos (data, forma_pagamento, endereco_entrega, id_status) VALUES ('2022-03-15', 'Cartão de crédito', 'Rua A, nº 123', 1), ('2022-03-16', 'Dinheiro', 'Av. B, nº 456', 2);

INSERT INTO Pedido_Pizza (id_pedido, id_pizza) VALUES (1, 1), (2, 2);

INSERT INTO Sabores (nome) VALUES ('Portuguesa'), ('Quatro Queijos'), ('Frango com milho'), ('Marguerita'), ('Romeu e Julieta'), ('Lombo com Catupiry'), ('Palmito'), ('Atum'), ('Bacon'), ('Calabresa com Cebola');

select *from Pedido_Pizza
select *from Pedidos
select *from Sabores