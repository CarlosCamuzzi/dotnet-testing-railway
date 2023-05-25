using BookStoreApi.Models;
using BookStoreApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Database Connection
builder.Services.Configure<BookStoreDatabaseSettings>(
    builder.Configuration.GetSection("BookStoreDatabase"));

builder.Services.AddSingleton<BooksService>();

builder.Services.AddControllers();

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

app.MapControllers();

app.Run();



/*
 No c�digo anterior, a inst�ncia de configura��o � qual a appsettings.json se��o do BookStoreDatabase arquivo � associada � registrada no cont�iner DI (Inje��o de Depend�ncia). Por exemplo, a BookStoreDatabaseSettings propriedade do ConnectionString objeto � preenchida com a BookStoreDatabase:ConnectionString propriedade em appsettings.json.s  
 */

/*
 Singleton: 
N�o h� a necessidade de transitar a instancia do seu objeto por todo o seu sistema. Garante que so haja uma unica instancia: independente de qual o objeto ou motivo, o Singleton vai garantir que exista apenas uma �nica inst�ncia dentro do seu projeto.

  Linha 10: 
No c�digo anterior, a classe BooksService � registrada com a DI para dar suporte � inje��o de construtor nas classes consumidoras. O tempo de vida do servi�o singleton � mais apropriado porque BooksService usa uma depend�ncia direta de MongoClient. De acordo com as diretrizes oficiais de reutiliza��o do Cliente Mongo, MongoClient deve ser registrado na DI com um tempo de vida de servi�o singleton.
 */