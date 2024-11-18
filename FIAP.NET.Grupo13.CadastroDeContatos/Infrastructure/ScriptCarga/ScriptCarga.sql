CREATE TABLE ddd (
    ddd INT PRIMARY KEY, -- O próprio DDD como chave primária
    descricao VARCHAR(100) NOT NULL -- Descrição do estado ou região associada ao DDD
);

INSERT INTO ddd (ddd, descricao) VALUES
-- Região Norte
(91, 'Pará (Belém)'),
(92, 'Amazonas (Manaus)'),
(93, 'Pará (Santarém)'),
(94, 'Pará (Marabá)'),
(95, 'Roraima (Boa Vista)'),
(96, 'Amapá (Macapá)'),
(97, 'Amazonas (Interior)'),
(98, 'Maranhão (São Luís)'),
(99, 'Maranhão (Interior)'),

-- Região Nordeste
(71, 'Bahia (Salvador)'),
(73, 'Bahia (Interior - Sul)'),
(74, 'Bahia (Interior - Norte)'),
(75, 'Bahia (Interior - Centro-Norte)'),
(77, 'Bahia (Interior - Oeste)'),
(79, 'Sergipe'),
(81, 'Pernambuco (Recife)'),
(82, 'Alagoas'),
(83, 'Paraíba'),
(84, 'Rio Grande do Norte'),
(85, 'Ceará (Fortaleza)'),
(86, 'Piauí (Teresina)'),
(87, 'Pernambuco (Interior)'),
(88, 'Ceará (Interior)'),
(89, 'Piauí (Interior)'),

-- Região Centro-Oeste
(61, 'Distrito Federal (Brasília)'),
(62, 'Goiás (Goiânia)'),
(64, 'Goiás (Interior)'),
(65, 'Mato Grosso (Cuiabá)'),
(66, 'Mato Grosso (Interior)'),
(67, 'Mato Grosso do Sul'),

-- Região Sudeste
(11, 'São Paulo (Capital e Região Metropolitana)'),
(12, 'São Paulo (Vale do Paraíba e Litoral Norte)'),
(13, 'São Paulo (Baixada Santista)'),
(14, 'São Paulo (Centro-Oeste)'),
(15, 'São Paulo (Sorocaba)'),
(16, 'São Paulo (Ribeirão Preto)'),
(17, 'São Paulo (São José do Rio Preto)'),
(18, 'São Paulo (Presidente Prudente)'),
(19, 'São Paulo (Campinas)'),
(21, 'Rio de Janeiro (Capital e Região Metropolitana)'),
(22, 'Rio de Janeiro (Interior - Norte)'),
(24, 'Rio de Janeiro (Interior - Sul)'),
(27, 'Espírito Santo (Vitória e Região Metropolitana)'),
(28, 'Espírito Santo (Interior)'),
(31, 'Minas Gerais (Belo Horizonte e Região Metropolitana)'),
(32, 'Minas Gerais (Zona da Mata)'),
(33, 'Minas Gerais (Vale do Aço)'),
(34, 'Minas Gerais (Triângulo Mineiro)'),
(35, 'Minas Gerais (Sul)'),
(37, 'Minas Gerais (Centro-Oeste)'),
(38, 'Minas Gerais (Norte)'),

-- Região Sul
(41, 'Paraná (Curitiba e Região Metropolitana)'),
(42, 'Paraná (Interior - Centro-Sul)'),
(43, 'Paraná (Interior - Norte)'),
(44, 'Paraná (Interior - Noroeste)'),
(45, 'Paraná (Interior - Oeste)'),
(46, 'Paraná (Interior - Sudoeste)'),
(47, 'Santa Catarina (Norte e Vale do Itajaí)'),
(48, 'Santa Catarina (Sul e Grande Florianópolis)'),
(49, 'Santa Catarina (Oeste)'),
(51, 'Rio Grande do Sul (Porto Alegre e Região Metropolitana)'),
(53, 'Rio Grande do Sul (Interior - Sul)'),
(54, 'Rio Grande do Sul (Interior - Norte)'),
(55, 'Rio Grande do Sul (Interior - Oeste)');

-- Criação da tabela Contato
CREATE TABLE Contato (
    Id SERIAL PRIMARY KEY,          -- Chave primária, gerada automaticamente
    Nome VARCHAR(100) NOT NULL,     -- Nome do contato
    Telefone VARCHAR(15) NOT NULL,  -- Número do telefone
    Email VARCHAR(255) NOT NULL,    -- E-mail do contato
    IdDDD INT NOT NULL,             -- Chave estrangeira para CodigoDDD
    CONSTRAINT FK_Contato_CodigoDDD FOREIGN KEY (IdDDD) REFERENCES CodigoDDD(Id) ON DELETE CASCADE
);

INSERT INTO Contato (Nome, Telefone, Email, IdDDD) VALUES 
('João Silva', '99999-1234', 'joao.silva@email.com', 1); -- Associado ao DDD 011
INSERT INTO Contato (Nome, Telefone, Email, IdDDD) VALUES 
('Maria Oliveira', '98888-5678', 'maria.oliveira@email.com', 2); -- Associado ao DDD 021