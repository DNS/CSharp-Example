/*
 * NuGet Dependencies:
 *	Install-Package Oracle.ManagedDataAccess.Core 
 *	dotnet add package Oracle.ManagedDataAccess.Core
 * 
 * Starting with Visual Studio 2022, Visual Studio no longer includes .NET Framework components for .NET Framework 4.0 - 4.5.1 because these versions are no longer supported. Visual Studio 2022 and later versions can't build apps that target .NET Framework 4.0 through .NET Framework 4.5.1. To continue building these apps, you can use Visual Studio 2019 or an earlier version.
 * 
 * # Download old .NET Framework 4.8.1 Developer Pack (Windows only)
 * https://dotnet.microsoft.com/en-us/download/visual-studio-sdks?cid=getdotnetsdk
 * 
 * 
 * -----------------------------
 * 
 * 
 * Install-Package Oracle.ManagedDataAccess.Core
 * 
 * https://www.nuget.org/packages/Oracle.ManagedDataAccess.Core
 * 
 * # Visual Studio > Tools > NuGet Package Manager > Package Manager Console
 * dotnet add package Oracle.ManagedDataAccess.Core
 * 
 * 
 * -----------------------------
 * # Additional Tools
 * https://marketplace.visualstudio.com/items?itemName=OracleCorporation.OracleDeveloperToolsForVisualStudio2022
 */


using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;

string connectionString = "User Id=sys;Password=a1;Data Source=localhost:1521/FREE;DBA Privilege=SYSDBA";
OracleConnection con = new OracleConnection(connectionString);

// READ
OracleCommand cmd1 = new OracleCommand("SELECT * FROM table2", con);
cmd1.Connection.Open();
OracleDataReader reader = cmd1.ExecuteReader();

while (reader.Read()) {
	Console.WriteLine(reader["nama"].ToString());
}

reader.Close();




// INSERT, UPDATE, DELETE
OracleCommand cmd2 = new OracleCommand("INSERT INTO table2 (nama, alamat) VALUES ('C#','from .NET')", con);
cmd2.ExecuteNonQuery();



con.Close();

Console.WriteLine("Test 123");


