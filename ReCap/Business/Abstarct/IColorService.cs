using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IColorService
    {
        List<Color> GetAll();
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
