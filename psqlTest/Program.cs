// See https://aka.ms/new-console-template for more information
using Npgsql;
Console.WriteLine("Hello, World!");

var connString = "Host=192.168.1.101;Password=Buddbj1569!!!;Username=wenrich85;Database=txpanthers_dev";

var conn = new NpgsqlConnection(connString);
await conn.OpenAsync();

 using (var cmd = new NpgsqlCommand("Select phone FROM members", conn))
await using (var reader = await cmd.ExecuteReaderAsync())
{
	while (await reader.ReadAsync())
		Console.WriteLine(reader.GetString(0));
}
