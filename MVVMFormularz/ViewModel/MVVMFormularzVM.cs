using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMFormularz.Base;
using MVVMFormularz.Model;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Input;

namespace MVVMFormularz.ViewModel
{
    class MVVMFormularzVM : BaseVM
    {
        #region Commands
        public ObservableCollection<PlayerVM> PlayersOCol { get; set; }
        public ObservableCollection<int> cb_Weight { get; set; }

        public RelayCommand CreatePlayerCommand { get; set; }
        public RelayCommand<PlayerVM> DeletePlayerCommand { get; set; }
        public RelayCommand<PlayerVM> ModifyPLayerCommand { get; set; }

        public RelayCommand SavePlayers { get; set; }
        public RelayCommand LoadPlayers { get; set; }
        #endregion

        #region prop
        private PlayerVM _currSelected;
        public PlayerVM CurrSelected
        {
            get
            {
                return _currSelected;
            }
            set
            {
                SetProperty(ref _currSelected, value);
                SelectedPlayer();
            }
        }

        private string _playerName;
        public string PlayerName
        {
          get
          {
                return _playerName;
          }
          set
          {
                SetProperty(ref _playerName, value);
          }
        }

        private string _playerSurrname;
        public string PlayerSurrname
        {
            get
            {
                return _playerSurrname;
            }
            set
            {
                SetProperty(ref _playerSurrname, value);
            }
        }

        private float _playerWeight;
        public float PlayerWeight
        {
            get
            {
                return _playerWeight;
            }
            set
            {
                SetProperty(ref _playerWeight, value);
            }
        }

        private int _playerAge;
        public int PlayerAge
        {
            get
            {
                return _playerAge;
            }
            set
            {
                SetProperty(ref _playerAge, value);
            }
        }
        #endregion

        #region ctor
        public MVVMFormularzVM()
        {
            PlayersOCol = new ObservableCollection<PlayerVM>();
            cb_Weight = new ObservableCollection<int>();

            CreatePlayerCommand = new RelayCommand(CreatePlayer, CanCreatePlayer);
            DeletePlayerCommand = new RelayCommand<PlayerVM>(DeletePlayer, CanDeletePlayer);
            ModifyPLayerCommand = new RelayCommand<PlayerVM>(ModifyPlayer, CanModifyPlayer);

            //Add Save and Load 
            SavePlayers = new RelayCommand(SaveToFile);
            LoadPlayers = new RelayCommand(LoadFromFile);
            
            ComboBoxWeightInit();
        }
        #endregion

        #region Othres
        public void SelectedPlayer()
        {
            if (CurrSelected == null)
            {
                return;
            }

            PlayerName = CurrSelected.Name;
            PlayerSurrname = CurrSelected.Surrname;
            PlayerWeight = CurrSelected.Weight;
            PlayerAge = CurrSelected.Age;
        }

        public void ComboBoxWeightInit()
        {
            for (int i = 15; i < 50; i++)
            {
                cb_Weight.Add(i);
            }
        }
        #endregion

        #region Func Commands
        //Do CanDo
        //Create Player
        public void CreatePlayer()
        {
            PlayerVM player = new PlayerVM(new Player { name = PlayerName, surrname = PlayerSurrname, age = PlayerAge, weight = PlayerWeight });
            PlayersOCol.Add(player);
            CurrSelected = player;
        }

        public bool CanCreatePlayer(object param)
        {
            if (string.IsNullOrWhiteSpace(PlayerName) || string.IsNullOrWhiteSpace(PlayerSurrname) || PlayerWeight == 0 || PlayerAge ==0)
            {
                return false;
            }
            return true;
        }

        //Delete Player
        public void DeletePlayer(PlayerVM player)
        {
            PlayersOCol.Remove(player);
        }

        public bool CanDeletePlayer(PlayerVM player)
        {
            if (player == null)
            {
                return false;
            }
            return true;
        }

        //Modify Player
        public void ModifyPlayer(PlayerVM player)
        {
            player.Name = PlayerName;
            player.Surrname = PlayerSurrname;
            player.Weight = PlayerWeight;
            player.Age = PlayerAge;
        }

        public bool CanModifyPlayer(PlayerVM player)
        {
            if (player == null)
            {
                return false;
            }
            return true;
        }

        //Save Load 
        public void SaveToFile()
        {
            string jsonFile;
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location + "save.json";
            List<Player> pl = new List<Player>();
            foreach (var item in PlayersOCol)
            {
                pl.Add(new Player { age = item.Age, name = item.Name, surrname = item.Surrname, weight = item.Weight });
            }

            jsonFile = JsonConvert.SerializeObject(pl);
            File.WriteAllText(path, jsonFile);
        }

        public void LoadFromFile()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location + "save.json";
            if (!File.Exists(path))
            {
                return;
            }
            string jsonFile = File.ReadAllText(path);
            List<Player> pl = JsonConvert.DeserializeObject<List<Player>>(jsonFile);

            foreach (var item in pl)
            {
                PlayerVM p = new PlayerVM(item);
                PlayersOCol.Add(p);
            }
        }
        #endregion
    }
}
