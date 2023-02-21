CREATE TABLE [dbo].[Laundry] (
    [Id]         BIGINT          NOT NULL,
    [Name]       NVARCHAR (30)   NULL,
    [Lat]        DECIMAL (12, 9) NOT NULL,
    [Lon]        DECIMAL (12, 9) NOT NULL,
    [OpenHours]  NVARCHAR (100)  NULL,
    [Phone]      NVARCHAR (20)   NULL,
    [HouseNum]   NVARCHAR (10)   NULL,
    [Street]     NVARCHAR (100)  NULL,
    [Zip]        NVARCHAR (10)   NULL,
    [City]       NVARCHAR (64)   NULL,
    [Web]        NVARCHAR (128)  NULL,
    [WheelChair] BIT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Laundry_LatLon] UNIQUE NONCLUSTERED ([Lat] ASC, [Lon] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Laundry_Lat_Lon]
    ON [dbo].[Laundry]([Lat] ASC, [Lon] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Laundry_Lat]
    ON [dbo].[Laundry]([Lat] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Laundry_Lon]
    ON [dbo].[Laundry]([Lon] ASC);

