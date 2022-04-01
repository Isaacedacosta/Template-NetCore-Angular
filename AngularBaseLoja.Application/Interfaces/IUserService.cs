using AngularBaseLoja.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularBaseLoja.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
    }
}
