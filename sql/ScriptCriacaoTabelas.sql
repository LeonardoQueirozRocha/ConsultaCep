IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Enderecos] (
    [Id] uniqueidentifier NOT NULL,
    [Cep] varchar(10) NOT NULL,
    [Logradouro] varchar(200) NOT NULL,
    [Complemento] varchar(250) NULL,
    [Bairro] varchar(100) NOT NULL,
    [Localidade] varchar(100) NOT NULL,
    [UF] varchar(50) NOT NULL,
    [Ibge] varchar(7) NOT NULL,
    [Gia] varchar(4) NOT NULL,
    [DDD] varchar(2) NOT NULL,
    [Siafi] varchar(4) NOT NULL,
    [DataCadastro] datetime2 NOT NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220316131131_Mapeamento', N'2.2.6-servicing-10079');

GO

