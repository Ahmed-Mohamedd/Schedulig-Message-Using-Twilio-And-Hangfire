using Hangfire;
using Hangfire.SqlServer;
using TestSchedulingMessageWithTwilioandHangfire.Services;
using TestSchedulingMessageWithTwilioandHangfire.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add Hangfire Service
builder.Services.AddHangfire(x => x.UseSqlServerStorage(builder.Configuration.GetConnectionString("HangfireConnection"), new SqlServerStorageOptions
{
    TryAutoDetectSchemaDependentOptions = false // Defaults to `true`
}));


// Add services to the container.

builder.Services.AddControllers();

//Add configuration For TwilioSetting Class
builder.Services.Configure<TwilioSetting>(builder.Configuration.GetSection("Twilio"));

// Allow DI for WhatsAppService Per Transient
builder.Services.AddScoped<IWhatsAppService , WhatsAppService>();

// Allow DI for HangfireService Per Scoope
builder.Services.AddScoped<IHangfireService, HangfireService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHangfireDashboard("/dashboard");

app.MapControllers();

app.Run();
