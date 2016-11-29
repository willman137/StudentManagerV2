DROP USER [aspnet]
CREATE USER [aspnet]
FOR LOGIN [NAIT\WEBBAIST$]
GRANT EXECUTE ON [dbo].[AddStudent],[dbo].[DeleteStudent]
to [aspnet]

SELECT
   p.Name,
   GrantCmd = 'GRANT EXECUTE ON OBJECT::' + p.name + ' TO [aspnet]'
FROM sys.procedures p
WHERE p.Name LIKE '%Student'
OR p.Name LIKE '%Program'