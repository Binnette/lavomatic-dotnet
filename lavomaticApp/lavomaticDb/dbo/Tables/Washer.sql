CREATE TABLE [dbo].[Washer] (
    [IdLaundry]             BIGINT         NOT NULL,
    [Weight]                INT            NULL,
    [Number]                INT            NULL,
    [Price]                 NUMERIC (4, 2) NULL,
    [PriceWithDisinfectant] NUMERIC (4, 2) NULL,
    CONSTRAINT [FK_Washer_Laundry] FOREIGN KEY ([IdLaundry]) REFERENCES [dbo].[Laundry] ([Id]),
    CONSTRAINT [AK_Washer_IdLaundry_Weight] UNIQUE CLUSTERED ([IdLaundry] ASC, [Weight] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Washer_IdLaundry]
    ON [dbo].[Washer]([IdLaundry] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Washer_IdLaundry_Weight]
    ON [dbo].[Washer]([IdLaundry] ASC, [Weight] ASC);

