namespace DIO.Series
{
// Todas a classes que estiverem no 
// name space irão herdar dela.
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
   // todas as classe que herdarem teram o identificador do objeto que sera o "ID"
   // ID esta protected pois só podera ser acessado pela nossa dll  
        
    }
}