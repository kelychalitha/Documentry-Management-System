CREATE TABLE [dbo].[Registration] (
    [MobileNumber]    INT        NOT NULL,
    [UserName]        NVARCHAR(MAX) NOT NULL,
    [E-mail]          NVARCHAR(MAX) NOT NULL,
    [Password]        NVARCHAR(MAX) NOT NULL,
    [ConfirmPassword] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Registration] PRIMARY KEY ([MobileNumber])
);

