using Jurassic.RECP.DataBase.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic.RECP.DataBase.Service
{
    public interface IUserProfileEFRepository : IEntityFrameworkRepository<UserProfile>
    {
    }
}
