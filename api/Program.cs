using TxPanthers.Api.Data;
using TxPanthers.Api.Services;
using TxPanthers.Api.Repositories;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using System.Text.Json.Serialization;

var client = "txpanthers";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddControllers().AddJsonOptions(x => 
{
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

    x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddScoped<IMemberService, MemberService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: client,
                        policy =>
                        {
                            policy.WithOrigins("http://localhost:3000")
                                                .AllowAnyHeader()
                                                .AllowCredentials()
                                                .AllowAnyMethod();
                        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
if (!app.Environment.IsDevelopment())
{
app.UseHttpsRedirection();
}
app.UseCors(client);

app.MapControllers();
app.Run();

