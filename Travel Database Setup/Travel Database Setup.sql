USE Travel
go 

CREATE TABLE tblHoliday(
	[HolidayNo] [int] PRIMARY KEY  NOT NULL,
	[Destination] [varchar](20) NOT NULL,
	[Cost] [decimal](10, 2) NOT NULL,
	[DepartureDate] [date] NULL,
	[NoOfDays] [int] NOT NULL,
	[Available] [bit] NULL,
)

INSERT INTO tblHoliday (HolidayNo, Destination, Cost, DepartureDate, NoOfDays, Available)
VALUES (205, 'Barcelona', 259.99, '2008-09-12', 14, 1),
(206, 'Paris', 350.00, '2008-07-20', 7, 1),
(207, 'Tokyo', 325.99, '2009-12-07', 14, 0),
(208, 'Rome', 459.99, '2008-10-14', 14, 1),
(209, 'Dubai', 259.99, '2009-01-22', 5, 1),
(210, 'Barcelona', 300.00, '2008-11-25', 7, 0),
(211, 'Tokyo', 200.00, '2008-12-27', 6, 1),
(212, 'Dubai', 259.99, '2008-09-12', 14, 1),
(213, 'Dubai', 159.99, '2008-08-10', 7, 1),
(214, 'Rome', 259.99, '2008-12-01', 5, 1),
(215, 'Tokyo', 300.00, '2008-10-22', 8, 1),
(216, 'Barcelona', 159.99, '2008-07-05', 7, 0),
(217, 'Dubai', 259.99, '2008-09-12', 14, 1),
(218, 'Rome', 189.99, '2008-07-26', 4, 1),
(219, 'Tokyo', 359.99, '2008-08-23', 18, 0),
(220, 'Paris', 499.99, '2008-07-07', 14, 1),
(221, 'Paris', 359.99, '2008-11-12', 10, 1)