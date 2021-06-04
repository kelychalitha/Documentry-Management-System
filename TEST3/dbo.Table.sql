CREATE TABLE [dbo].[Admin]
(
	[UserName] NCHAR(10) NOT NULL, 
    [UserID] NCHAR(5) NOT NULL, 
    [Password] NCHAR(10) NOT NULL, 
    [ConfirmPassword] NCHAR(10) NOT NULL, 
    CONSTRAINT [PK_Admin] PRIMARY KEY ([UserID]) 
)
