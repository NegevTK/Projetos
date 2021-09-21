using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.BLL
{
    public class Filmes
    {

        public List<MODEL.Filmes> Select()
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.Select();
        }

        public List<MODEL.Filmes> SelectAtivos()
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectAtivos();
        }

        public List<MODEL.Filmes> SelectDesativados()
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectDesativados();
        }

        public void Insert(MODEL.Filmes filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            dalFilmes.Insert(filmes);
        }

        public void Update(MODEL.Filmes filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            dalFilmes.Update(filmes);
        }

        public void Delete(int idFilmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            dalFilmes.Delete(idFilmes);
        }

        public List<CAMADAS.MODEL.Filmes> SelectByIDAtivos(int filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectByIDAtivos(filmes);
            
        }

        public List<CAMADAS.MODEL.Filmes> SelectByNomeAtivos(String filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectByNomeAtivos(filmes);

        }

        public List<CAMADAS.MODEL.Filmes> SelectByIDDesativados(int filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectByIDDesativados(filmes);

        }

        public List<CAMADAS.MODEL.Filmes> SelectByNomeDesativados(String filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectByNomeDesativados(filmes);

        }

        public List<CAMADAS.MODEL.Filmes> SelectByID(int filmes)
        {
            DAL.Filmes dalFilmes = new DAL.Filmes();
            return dalFilmes.SelectByIDAtivos(filmes);

        }
    }
}
