USE INDRASIO
GO

BEGIN TRAN
	DELETE FROM CodeNotes

	DBCC CHECKIDENT('CODENOTES',RESEED,0)

	INSERT INTO CODENOTES
	(TITLE, DESCRIPTION, STATUSCODE,UPDATEDATE)
	VALUES('Entity Framework Powershell Migrations',
		'In the powershell console, 1.) Enable Migrations\n 2.) Add-Migration Initial\n 3.) Update-Database -Verbose',
		'A',
		SYSDATETIME())


	INSERT INTO CODENOTES
		(TITLE, DESCRIPTION,URL, STATUSCODE,UPDATEDATE)
		VALUES('Unable to update database to match the current model because there are pending changes.',
		'Entity Framework Error: "Unable to update database to match the current model because there are pending changes and automatic migration is disabled. Either write the pending model changes to a code-based migration or enable automatic migration. Set DbMigrationsConfiguration.AutomaticMigrationsEnabled to true to enable automatic migration. You can use the Add-Migration command to write the pending model changes to a code-based migration."
		This error occurs when you have pending changes in your database migrations that have not been added yet. If you find this error staring you in the face during your programming adventures, simply type Add-Migration. This will take all of the database updates you have made (inadvertently or explicitly) since the last migration and add them to a new database migration file.
		Once your pending changes are all synced up, Update-Database will work again.',
		'http://robertgreiner.com/2012/05/unable-to-update-database-to-match-the-current-model-pending-changes/',
		'A',
		SYSDATETIME())

	INSERT INTO CODENOTES
		(TITLE, DESCRIPTION,URL, STATUSCODE,UPDATEDATE)
		VALUES('StackOverflow File Upload for AngularJS',
		'',
		'https://stackoverflow.com/questions/36847133/file-upload-using-angularjs-net-web-api-2-sql-server',
		'A',
		SYSDATETIME())

	INSERT INTO CODENOTES
		(TITLE, DESCRIPTION,URL, STATUSCODE,UPDATEDATE)
		VALUES('StackOverflow Storing Files in SQL Server',
		'',
		'https://stackoverflow.com/questions/13420305/storing-files-in-sql-server/13421029#13421029',
		'A',
		SYSDATETIME())

	--INSERT INTO CODENOTES
	--	(TITLE, DESCRIPTION, STATUSCODE,UPDATEDATE)
	--	VALUES('',
	--	'',
	--	'A',
	--	SYSDATETIME())



COMMIT