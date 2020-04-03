using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavDesktopLibrary.Api
{
    public class ProductEndpoint
    {

        private IAPIHelper _apiHelper;

        public ProductEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;

        }

       
    }

}
