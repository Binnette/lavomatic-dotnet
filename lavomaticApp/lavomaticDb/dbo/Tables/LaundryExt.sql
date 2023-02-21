CREATE TABLE [dbo].[LaundryExt] (
    [IdLaundry]        BIGINT         NOT NULL,
    [Detergent]        BIT            NULL,
    [DetergentPrice]   NUMERIC (3, 2) NULL,
    [DetergentComment] NVARCHAR (32)  NULL,
    [Softener]         BIT            NULL,
    [SoftenerPrice]    NUMERIC (3, 2) NULL,
    [Desk]             INT            NULL,
    [Seat]             INT            NULL,
    PRIMARY KEY CLUSTERED ([IdLaundry] ASC),
    CONSTRAINT [FK_LaundryExt_Laundry] FOREIGN KEY ([IdLaundry]) REFERENCES [dbo].[Laundry] ([Id])
);

