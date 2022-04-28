using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaskShop.DataBase;
using MaskShop.Models;
using MaskShop.Services.ServiceInterfaces;

namespace MaskShop.Services.ServiceRealisations
{
    public class MaskRepositoryService : IMaskRepositoryService
    {
        private readonly DataBaseContext _dataBase;
        public MaskRepositoryService(DataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public IEnumerable<Mask> GetMasksInRange(int from, int count)
        {
            if (from < 0 || count <=0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return _dataBase.Masks.Skip(from).Take(count);
        }

        public void AddMask(Mask mask)
        {
            _dataBase.Masks.Add(mask);
            _dataBase.SaveChanges();
        }
    }
}
