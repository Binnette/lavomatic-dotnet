CREATE PROCEDURE [dbo].[SearchLaundries]
	@lat1 decimal(12,9),
	@lon1 decimal(12,9),
	@lat2 decimal(12,9),
	@lon2 decimal(12,9)
AS
	SELECT Id, Name, Lat, Lon, OpenHours, WheelChair
	FROM [dbo].[Laundry]
	WHERE Laundry.Lat >= @lat1 and Laundry.Lat <= @lat2
	and Laundry.Lon >= @lon1 and Laundry.Lon <= @lon2

RETURN 0
