public class TimeMiddleware
{
    readonly RequestDelegate next; // esta propiedad nos ayuda a invocar la siguiente propiedad en el ciclo del middleware 

    //Este es el llamado al siguiente middleware 
    public TimeMiddleware(RequestDelegate nextRequest)
    {
        next = nextRequest;
    }
    //Toda la informacion del Request se hace aqui 
    public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context)
    {
        //con este vamos a recibir la utlma respuesta del ultimo middlware 
        await next(context);
        // y aqui ya le agregamos la logica del middleware 
        if (context.Request.Query.Any(p => p.Key == "time"))
        {
            await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
        }
    }
}
    public static class TimeMiddlewareExtension
    {
        public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
        {
            //Aqui retornamos el builder y usamos UseMiddleware
            return builder.UseMiddleware<TimeMiddleware>();
        }
    }