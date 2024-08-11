using minimal_api.Dominio.DTOs;    


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/Login", (LoginDTO loginDTO) => {
    if(loginDTO.email == "admteste@hotmail.com" && loginDTO.senha == "senha"){
        return Results.Ok("Login feito com sucesso");
    }
    else
    {
       return Results.Unauthorized(); 
    }
});

app.Run();


