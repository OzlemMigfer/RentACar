using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Burası Car la ilgili veritabanında yapacağım operasyonları içerir sil ekle falan...
    //interface nin kendisi public değil,içindeki metotlar public
    public interface ICarDal:IEntityRepository<Car>
    {
        
    }
}
