using InfoCatEmbalses.Data;
using InfoCatEmbalses.Embalses.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddHttpClient<EmbalseService>();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IEmbalseRepository, EmbalseRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Allowlocalhost5173", policyBuilder =>
    {
        policyBuilder.WithOrigins("http://localhost:5173") //URL del front
            .AllowAnyMethod()
            .AllowCredentials()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("Allowlocalhost5173");

app.Run();