using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMFormularz.Base;
using MVVMFormularz.Model;

namespace MVVMFormularz.ViewModel
{
    class PlayerVM : BaseVM
    {
        private Player _playerM;

        #region ctor
        public PlayerVM()
        {
            _playerM = new Player();
        }

        public PlayerVM(Player player)
        {
            _playerM = player;
        }
        #endregion

        #region Prop
        public string Name
        {
            get
            {
                return _playerM.name;
            }
            set
            {
                SetProperty(ref _playerM.name, value);
            }
        }

        public string Surrname
        {
            get
            {
                return _playerM.surrname;
            }
            set
            {
                SetProperty(ref _playerM.surrname, value);
            }
        }

        public float Weight
        {
            get
            {
                return _playerM.weight;
            }
            set
            {
                SetProperty(ref _playerM.weight, value);
            }
        }

        public int Age
        {
            get
            {
                return _playerM.age;
            }
            set
            {
                SetProperty(ref _playerM.age, value);
            }
        }
        #endregion

    }
}
