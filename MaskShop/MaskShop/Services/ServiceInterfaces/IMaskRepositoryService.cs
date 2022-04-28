using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaskShop.Models;

namespace MaskShop.Services.ServiceInterfaces
{
    public interface IMaskRepositoryService
    {
        public IEnumerable<Mask> GetMasksInRange(int from, int count);

        public void AddMask(Mask mask);
    }
}
