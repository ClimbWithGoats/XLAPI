using System;
using System.Threading.Tasks;
using XLAPI_CONSOLE.Interfaces;

namespace XLAPI_CONSOLE.XLControllers
{
    // Kontroller XL dla kategorii
    public class XLCategoriesController : XLBaseController
    {

        //public XLCategoriesController(ZarzadcaBazy zb, XLAbstractService xl) : base(zb, xl)
        ICategoriesRepository _categoriesRepository { get; set; }
        public XLCategoriesController(Interfaces.ICategoriesRepository categoriesRepository) : base()
        {
            _categoriesRepository = categoriesRepository;

        }

        internal Task AddCategory()
        {
            throw new NotImplementedException();
        }


    }
}