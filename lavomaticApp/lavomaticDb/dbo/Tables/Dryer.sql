CREATE TABLE [dbo].[Dryer] (
    [IdLaundry] BIGINT         NOT NULL,
    [Duration]  INT            NULL,
    [Weight]    INT            NULL,
    [Number]    INT            NULL,
    [Price]     NUMERIC (4, 2) NULL,
    CONSTRAINT [FK_Dryer_Laundry] FOREIGN KEY ([IdLaundry]) REFERENCES [dbo].[Laundry] ([Id]),
    CONSTRAINT [AK_Dryer_IdLaundry_Duration_Weight] UNIQUE CLUSTERED ([IdLaundry] ASC, [Duration] ASC, [Weight] ASC)
);

