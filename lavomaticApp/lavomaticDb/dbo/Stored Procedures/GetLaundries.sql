CREATE PROCEDURE [dbo].[GetLaundries]
AS
	SELECT Id, Name, Lat, Lon, OpenHours, WheelChair
	FROM [dbo].[Laundry]
RETURN 0
