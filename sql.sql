CREATE TABLE TAB012A_Documentos (
    CodigoCliente INT NOT NULL,
    TipoDeDocumento TINYINT NOT NULL,
    NomeDocumento VARCHAR(100) NOT NULL,
    Documento IMAGE NULL,
    Usuario VARCHAR(30) NOT NULL,
    DataInclusao SMALLDATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_TAB012A_Documentos PRIMARY KEY (CodigoCliente, NomeDocumento)
);


SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'TAB012A_Documentos';


CREATE TRIGGER TRG_TAB012A_INCLUSAO
ON TAB012A_Documentos
AFTER INSERT
AS
BEGIN
    -- Aqui você pode adicionar ações que devem ocorrer após inserir um documento
    -- Por exemplo, validar dados ou atualizar outras tabelas
    PRINT 'Trigger de INCLUSÃO executada para TAB012A_Documentos';
END;


CREATE TRIGGER TRG_TAB012A_EXCLUSAO
ON TAB012A_Documentos
AFTER DELETE
AS
BEGIN
    -- Aqui você pode adicionar ações que devem ocorrer após excluir um documento
    PRINT 'Trigger de EXCLUSÃO executada para TAB012A_Documentos';
END;


ALTER TABLE TAB012A_Documentos
ADD CONSTRAINT DF_TAB012A_DataInclusao
DEFAULT GETDATE() FOR DataInclusao;


INSERT INTO TAB012A_Documentos
(CodigoCliente, TipoDeDocumento, NomeDocumento, Documento, Usuario, DataInclusao)
VALUES
(1, 0, 'Contrato_Social.pdf', NULL, 'Raphael', GETDATE());


INSERT INTO TAB012A_Documentos
(CodigoCliente, TipoDeDocumento, NomeDocumento, Documento, Usuario)
VALUES
(1, 0, 'Contrato_Social.pdf', NULL, 'Raphael');


ALTER TABLE TAB012A_Documentos
ADD CONSTRAINT DF_TAB012A_DataInclusao
DEFAULT GETDATE() FOR DataInclusao;


ALTER TABLE TAB012A_Documentos
DROP CONSTRAINT NomeDoDefault;

SELECT * FROM TAB012A_Documentos;


DELETE FROM TAB012A_Documentos
WHERE CodigoCliente = 1 AND NomeDocumento = 'Contrato_Social.pdf';



SELECT * FROM TAB012A_Documentos;
