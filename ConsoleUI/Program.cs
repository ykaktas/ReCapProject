using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal()) ;
            InMemoryCarDal methods = new InMemoryCarDal();
            //methods.GetAll();
            //methods.GetById(9000);
        }
    }
}
