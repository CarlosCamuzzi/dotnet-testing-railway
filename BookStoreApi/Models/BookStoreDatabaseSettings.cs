namespace BookStoreApi.Models
{
    public class BookStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string BooksCollectionName { get; set; } = null!;
    }
}


/*
 ver appsettings.json
  
 A classe anterior BookStoreDatabaseSettings é usada para armazenar os appsettings.json valores de propriedade do BookStoreDatabase arquivo. Os nomes das propriedades JSON e C# são nomeados de forma idêntica para facilitar o processo de mapeamento.
 */