using Desafio_Tecnico.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.ViewModels
{
    public class MainViewModels: ViewModelBase
    {

        //Fields
        //private UserAccountModel _currentUserAccount;
        //private readonly IProductoRepository _IProductoRepository;

        //public UserAccountModel CurrentUserAccount
        //{
        //    get
        //    {
        //        return _currentUserAccount;
        //    }

        //    set
        //    {
        //        _currentUserAccount = value;
        //        OnPropertyChanged(nameof(CurrentUserAccount));
        //    }
        //}

        public MainViewModels()
        {
            //userRepository = new UserRepository();
            //CurrentUserAccount = new UserAccountModel();
            //LoadCurrentUserData();
        }

        //private void LoadCurrentUserData()
        //{
        //    var product = 
        //    var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
        //    if (user != null)
        //    {
        //        CurrentUserAccount.Username = user.Username;
        //        CurrentUserAccount.DisplayName = $"Welcome {user.Name} {user.LastName} ;)";
        //        CurrentUserAccount.ProfilePicture = null;
        //    }
        //    else
        //    {
        //        CurrentUserAccount.DisplayName = "Invalid user, not logged in";
        //        //Hide child views.
        //    }
        //}


    }
}
