using MC_TwoToFourEndpoints.GreaterThanOrLessThan;
using MC_TwoToFourEndpoints.Services.GreaterThanOrLessThan;
using MC_TwoToFourEndpoints.Services.Summation;
using MC_TwoToFourEndpoints.Services.WakeUpTime;
using MC_TwoToFourEndpoints.Summation;
using MC_TwoToFourEndpoints.WakeUpTime;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISummationService, SummationService>();
builder.Services.AddScoped<IGreaterThanOrLessThanService, GreaterThanOrLessThanService>();
builder.Services.AddScoped<IWakeUpTimeService, WakeUpTimeService>();



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

app.Run();
