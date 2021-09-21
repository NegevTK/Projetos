using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoLocadoraFema.CAMADAS.BLL
{
    public class Aluguel
    {
        public void Insert(MODEL.Aluguel aluguel)
        {
            DAL.Aluguel dalAluguel = new CAMADAS.DAL.Aluguel();
            dalAluguel.Insert(aluguel);
        }

        public List<MODEL.Aluguel> Select()
        {
            DAL.Aluguel DALContratos = new DAL.Aluguel();
            return DALContratos.Select();
        }

        public void Delete(int idcontrato)
        {
            DAL.Aluguel dalContratos = new DAL.Aluguel();
            dalContratos.Delete(idcontrato);
        }
    }
}
