using System.Collections.Generic;
namespace DIO.Series.Interfaces
{
    public interface Irepositorio<T>
    {
       List<T> Lista();//retorna uma lista de T 
        T RetornaPorId(int id);// passo Id por parametro e retorna um T como parametro
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();

    }   
}