var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// builder.Services.AddScoped();  // se crea una nueva isntancia de la dependencia pero a nivel de controlador o clase 
builder.Services.AddScoped<IHelloWorldService, HelloWorldServices> ();
// builder.Services.AddSingleton(); // se crea una unica instancia de esa dependencia a nivel de todo la Api "No recomendarlo hacerlo ay que maneja un unico estado "

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
