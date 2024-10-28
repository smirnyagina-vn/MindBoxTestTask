CREATE TABLE [dbo].[Products] (
    [ProductId]   INT           IDENTITY (1, 1) NOT NULL,
    [ProductName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

