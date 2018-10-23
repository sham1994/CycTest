using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycTest.Entities.Entities;

namespace CycTest.Definitions.Category_Definitons
{
    interface ISubCategory
    {
        Stock_Cat AddMainCat(Stock_Cat stockcat);
        void UpdateMainCat(Stock_Cat stockcat);
        Stock_Cat DeleteMainCat(Stock_Cat stockcat);



    }
}
