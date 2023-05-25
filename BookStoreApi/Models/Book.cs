using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStoreApi.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")] // Aqui só funciona se add uma configuração em program
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}



/*Anotações
 Necessário para mapear o objeto CLR (Common Language Runtime) para a coleção MongoDB.

Anotado com [BsonId] para tornar essa propriedade a chave primária do documento.

Anotado com [BsonRepresentation(BsonType.ObjectId)] para permitir a passagem do parâmetro como tipo string em vez de uma estrutura ObjectId . O Mongo processa a conversão de string para ObjectId.

A BookName propriedade é anotada com o [BsonElement] atributo . O valor do atributo de Name representa o nome da propriedade da coleção do MongoDB.
 
 */

/*
 Lenha 12:
Em program:

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

Em book
using System.Text.Json.Serialization;
[BsonElement("Name")]
[JsonPropertyName("Name")]
public string BookName { get; set; } = null!;
 */

/*
    https://learn.microsoft.com/pt-br/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-7.0&tabs=visual-studio
 */
