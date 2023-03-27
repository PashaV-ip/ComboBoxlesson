using ComboBoxLesson.DbEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComboBoxLesson.ViewModel
{
    public class MainVM : BaseVM
    {
        private ObservableCollection<ManufacturerItem> _manuItems;

        private ManufacturerItem _selectedManufItem;

        public ManufacturerItem SelectedManufItem
        {
            get => _selectedManufItem;

            set
            {
                _selectedManufItem = value;
                OnPropertyChanged(nameof(SelectedManufItem));
            }
        }

        public ObservableCollection<ManufacturerItem> ManuItems
        {
            get => _manuItems;
            set
            {
                _manuItems = value;
                OnPropertyChanged(nameof(ManuItems));
            }
        }



        public MainVM()
        {
            Initialize();

            LoadData();
        }

        private void Initialize()
        {
            ManuItems = new ObservableCollection<ManufacturerItem>();
        }

        private void LoadData()
        {

            var item = new ManufacturerItem();

            DbStorage.DB.Entry(item).State = System.Data.Entity.EntityState.Added;



            var manufList = DbStorage.DB.ManufacturerItem.ToList();

            manufList.ForEach(elem => ManuItems.Add(elem));
        }

        public void ShowInfo()
        {
            if (SelectedManufItem != null)
            {
                MessageBox.Show(SelectedManufItem.Product.ToList().First().Discription);
            }
        }
    }
}
