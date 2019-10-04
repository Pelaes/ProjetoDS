USE ProjetoDS;

SELECT * FROM dbo.Pessoa;

INSERT INTO dbo.Pessoa
(
    nome,
    email,
    userName,
    senha,
    cargo,
    dtNascimento,
    sexo,
    telFixo,
    telCelular,
    ativo,
    RG,
    CPF
)
VALUES
(   'Marcelo Pelaes Almeida',        -- nome - varchar(200)
    'celo.pelaes@hotmail.com',        -- email - varchar(150)
    'celo_almeida',        -- userName - varchar(100)
    '123456',        -- senha - varchar(100)
    'Funcionario',        -- cargo - varchar(50)
    '1984-03-08', -- dtNascimento - date
    'Masculino',        -- sexo - varchar(15)
    '1133334444',        -- telFixo - varchar(10)
    '11952827130',        -- telCelular - varchar(11)
    'true',      -- ativo - binary(1)
    '123456',        -- RG - varchar(25)
    '33355588879'         -- CPF - varchar(11)
    )

	ALTER TABLE dbo.Pessoa DROP CONSTRAINT DF__Pessoa__ativo__36B12243;

	ALTER TABLE dbo.Pessoa ALTER COLUMN ativo VARCHAR(5);

	DELETE dbo.Pessoa WHERE idPessoa = 1;