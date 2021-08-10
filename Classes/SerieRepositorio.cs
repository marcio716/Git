using System.Collections.Generic;
using System;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : Irepositorio<Serie>
    // essa classe seriRepositorio implementa O repositorio de serie
    // esse serie ira substituir o T pela serie da classe repositorio
    { private List<Serie> listaSerie = new List<Serie>();
    // Variavel listaSerie Ira conter conter a lista de todas as series
        public void Atualiza(int id, Serie entidade)
        {
           listaSerie[id] = entidade; // irá receber o bjeto se sera serie e colocar 
            // na posiçao do vetor id da listaSerie
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
             listaSerie.Add(entidade); // adiciona o objeto na lista
        }

        public List<Serie> Lista()
        {
             return listaSerie; // retorna lista de series
        }

        public int ProximoId()
        {
            return listaSerie.Count; // retorna o Id e add mais 1
        }

        public Serie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
