using Microsoft.EntityFrameworkCore;
using Tarkov_Ballistics_Calculator.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//armor Table
builder.Services.AddDbContext<ArmorContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("TBC-DB")    
));

//bullet table
builder.Services.AddDbContext<BulletContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("TBC-DB"))
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
