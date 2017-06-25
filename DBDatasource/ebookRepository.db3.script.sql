BEGIN TRANSACTION;

DROP TABLE IF EXISTS [FILE_CHECKSUM_MD5];
DROP TABLE IF EXISTS [FILE_CHECKSUM_SHA1];
DROP TABLE IF EXISTS [FILE_CHECKSUM_SHA256];
DROP TABLE IF EXISTS [FILE_DOC];

DROP TABLE IF EXISTS [FILE_DOC];
CREATE TABLE [FILE_DOC]
(
    [F_CODI] INTEGER       CONSTRAINT [PK_FILE_DOC_F_CODI] PRIMARY KEY ASC ON CONFLICT ROLLBACK AUTOINCREMENT
                           CONSTRAINT [NN_FILE_DOC_F_CODI] NOT NULL        ON CONFLICT ROLLBACK
                           CONSTRAINT [UK_FILE_DOC_F_CODI] UNIQUE          ON CONFLICT ROLLBACK
                           CONSTRAINT [CK_FILE_DOC_F_CODI] CHECK ([FILE_DOC].[F_CODI] >= 1),
	[F_NAME] NVARCHAR(255) CONSTRAINT [NN_FILE_DOC_F_NAME] NOT NULL        ON CONFLICT ROLLBACK,
    [F_EXTE] NVARCHAR(5)   CONSTRAINT [NN_FILE_DOC_F_EXTE] NOT NULL        ON CONFLICT ROLLBACK,
	[F_SIZE] NVARCHAR(15)  CONSTRAINT [NN_FILE_DOC_F_SIZE] NOT NULL        ON CONFLICT ROLLBACK,
	[F_BYTE] BLOB          CONSTRAINT [NN_FILE_DOC_F_BYTE] NOT NULL        ON CONFLICT ROLLBACK 
						   CONSTRAINT [UK_FILE_DOC_F_BYTE] UNIQUE          ON CONFLICT ROLLBACK,
	[F_TIME] NVARCHAR(20)  CONSTRAINT [NN_FILE_DOC_F_TIME] NOT NULL        ON CONFLICT ROLLBACK
);

DROP TABLE IF EXISTS [FILE_CHECKSUM_MD5];
CREATE TABLE [FILE_CHECKSUM_MD5] (
    [FILE_DOC_F_CODI]  INTEGER   CONSTRAINT [FK_FILE_CHECKSUM_MD5_FILE_DOC_F_CODI] REFERENCES [FILE_DOC]([F_CODI])
								 CONSTRAINT [NN_FILE_CHECKSUM_MD5_FILE_DOC_F_CODI] NOT NULL   ON CONFLICT ROLLBACK
								 CONSTRAINT [UK_FILE_CHECKSUM_MD5_FILE_DOC_F_CODI] UNIQUE     ON CONFLICT ROLLBACK,
    [CHECKSUM_MD5] NVARCHAR (32) CONSTRAINT [NN_FILE_CHECKSUM_MD5_CHECKSUM]        NOT NULL   ON CONFLICT ROLLBACK
);

DROP TABLE IF EXISTS [FILE_CHECKSUM_SHA1];
CREATE TABLE [FILE_CHECKSUM_SHA1] (
    [FILE_DOC_F_CODI]  INTEGER    CONSTRAINT [FK_FILE_CHECKSUM_SHA1_FILE_DOC_F_CODI] REFERENCES [FILE_DOC]([F_CODI])
								  CONSTRAINT [NN_FILE_CHECKSUM_SHA1_FILE_DOC_F_CODI] NOT NULL   ON CONFLICT ROLLBACK
								  CONSTRAINT [UK_FILE_CHECKSUM_SHA1_FILE_DOC_F_CODI] UNIQUE     ON CONFLICT ROLLBACK,
    [CHECKSUM_SHA1] NVARCHAR (40) CONSTRAINT [NN_FILE_CHECKSUM_SHA1_CHECKSUM]        NOT NULL   ON CONFLICT ROLLBACK
);

CREATE TABLE [FILE_CHECKSUM_SHA256] (
    [FILE_DOC_F_CODI]  INTEGER      CONSTRAINT [FK_FILE_CHECKSUM_SHA256_FILE_DOC_F_CODI] REFERENCES [FILE_DOC]([F_CODI])
							  	    CONSTRAINT [NN_FILE_CHECKSUM_SHA256_FILE_DOC_F_CODI] NOT NULL   ON CONFLICT ROLLBACK
								    CONSTRAINT [UK_FILE_CHECKSUM_SHA256_FILE_DOC_F_CODI] UNIQUE     ON CONFLICT ROLLBACK,
    [CHECKSUM_SHA256] NVARCHAR (64)	CONSTRAINT [NN_FILE_CHECKSUM_SHA256_CHECKSUM]        NOT NULL   ON CONFLICT ROLLBACK
);

COMMIT TRANSACTION;

INSERT INTO [FILE_DOC]([F_NAME], [F_EXTE], [F_SIZE], [F_BYTE], [F_TIME]) VALUES (@F_NAME, @F_EXTE, @F_SIZE, @F_BYTE, @F_TIME);

INSERT INTO [FILE_CHECKSUM_MD5]   ([FILE_DOC_F_CODI], [CHECKSUM_MD5])    VALUES ((SELECT [F].[F_CODI] FROM [FILE_DOC] AS [F] WHERE [ROWID] = @ROWID), @CHECKSUM_MD5);
INSERT INTO [FILE_CHECKSUM_SHA1]  ([FILE_DOC_F_CODI], [CHECKSUM_SHA1])   VALUES ((SELECT [F].[F_CODI] FROM [FILE_DOC] AS [F] WHERE [ROWID] = @ROWID), @CHECKSUM_SHA1);
INSERT INTO [FILE_CHECKSUM_SHA256]([FILE_DOC_F_CODI], [CHECKSUM_SHA256]) VALUES ((SELECT [F].[F_CODI] FROM [FILE_DOC] AS [F] WHERE [ROWID] = @ROWID), @CHECKSUM_SHA256);
DELETE FROM [FILE_CHECKSUM_MD5]	   WHERE  [CHECKSUM_MD5]    = ('SEM_HASH_MD5');
DELETE FROM [FILE_CHECKSUM_SHA1]   WHERE  [CHECKSUM_SHA1]   = ('SEM_HASH_SHA1');
DELETE FROM [FILE_CHECKSUM_SHA256] WHERE  [CHECKSUM_SHA256] = ('SEM_HASH_SHA256');

SELECT [F].*,[MD5].[FILE_DOC_F_CODI] AS [MD5], [SHA1].[FILE_DOC_F_CODI] AS [SHA1], [SHA256].[FILE_DOC_F_CODI] AS [SHA256]  
FROM [FILE_DOC] AS [F]
INNER JOIN [FILE_CHECKSUM_MD5] AS [MD5]
ON [F].[F_CODI] = [MD5].[FILE_DOC_F_CODI]
INNER JOIN [FILE_CHECKSUM_SHA1] AS [SHA1] 
ON [F].[F_CODI] = [SHA1].[FILE_DOC_F_CODI]
INNER JOIN [FILE_CHECKSUM_SHA256] AS [SHA256] 
ON [F].[F_CODI] = [SHA256].[FILE_DOC_F_CODI];











INSERT INTO [FILE_DOC]([NAME], [EXTENSION], [FILEBYTE], [FILEDATE]) VALUES (@NAME, @EXTENSION,@FILEBYTE,@FILEDATE);
INSERT INTO [FILE_DOC]([NAME], [EXTENSION], [FILEBYTE], [FILEDATE]) VALUES (@NAME, @EXTENSION,@FILEBYTE,@FILEDATE);
INSERT INTO [FILE_CHECKSUM_MD5]([FILE_DOC_COD], [CHECKSUM_MD5]) VALUES ((SELECT MAX(COD) FROM [FILE_DOC]), @CHECKSUM_MD5);
INSERT INTO [FILE_CHECKSUM_SHA1]([FILE_DOC_COD], [CHECKSUM_SHA1]) VALUES ((SELECT MAX(COD) FROM [FILE_DOC]), @CHECKSUM_SHA1);
INSERT INTO [FILE_CHECKSUM_SHA256]([FILE_DOC_COD], [CHECKSUM_SHA256]) VALUES ((SELECT MAX(COD) FROM [FILE_DOC]), @CHECKSUM_SHA256);
(SELECT MAX(COD) FROM [FILE_DOC]);
INSERT INTO [FILE_DOC]([NAME], [FILEBYTE], [FILEDATE]) VALUES (@NAME, @FILEBYTE,@FILEDATE);
INSERT INTO [FILE_DOC]([NAME], [FILEBYTE], [FILEDATE]) VALUES (@NAME, @FILEBYTE, (select datetime('now', 'localtime'))

