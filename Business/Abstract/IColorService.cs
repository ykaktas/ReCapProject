using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int ColorId);
        void Add(Color Color);
        void Update(Color Color );
        void Delete(Color Color);
    }
}
