namespace Api.net;

// Esta es una clase que contiene cada una de las propiedada que necesitemos para guardar nuestra informacion
// Cada modelo que nostros creemos tiene que estar relacionado con un controlador
public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
