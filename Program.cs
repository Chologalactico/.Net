var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors(); // Este nos permitira ver quien pueda usarla y quien no pueda usarla

app.UseAuthorization();

//app.UseWelcomePage(); //Este es que da una pagina de bienvenida cada vez que se ingresa(Usarla mas si apenas se crea el proyecto )
app.UseTimeMiddleware();//  Ya con esto usamos el middleware de Time

app.MapControllers(); //Siempre los middlewares perzonalisados deben ir entre el Autorization y los endpoints

app.Run();
