using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycTest.Entities.Entities;

namespace CycTest.Definitions.Category_Definitons
{
    interface IMainCategory
    {

        Stock_Book AddMainCat(Stock_Book stockcat);
        void UpdateMainCat(Stock_Book stockcat);
        Stock_Book DeleteMainCat(Stock_Book stockcat);

        Stock_Book[] GetAllMainCat();
    }
        
}
