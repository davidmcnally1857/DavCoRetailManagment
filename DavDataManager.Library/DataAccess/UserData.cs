using DavDataManager.Library.Internal.DataAccess;
using DavDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            var p = new { Id = Id };

            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "DavData");

            return output;

               
        }
    }
}
