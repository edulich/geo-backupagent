USE LicenseServer_2_0;

SELECT u.Date, c.CustomerName, c.CompanyName, l.DNSname, u.ServerVersion, u.UsedHomeCALs, u.UsedProfCALs
FROM dbo.Usage u
JOIN dbo.License l ON u.LicenseID = l.ID
JOIN dbo.Customer c ON l.CustomerID = c.ID
WHERE u.Date BETWEEN 
    CONVERT (datetime, '2012-08-31', 126) AND
    CONVERT (datetime, '2012-08-31', 126) + 1