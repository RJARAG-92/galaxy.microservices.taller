#wait for the SQL Server to come up
#Save in Unix(LF) format
sleep 60s
#run the setup script to create the DB and the schema in the DB
/opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P Password1234 -d master -i /var/opt/sqlserver/SqlCmdScript.sql -C