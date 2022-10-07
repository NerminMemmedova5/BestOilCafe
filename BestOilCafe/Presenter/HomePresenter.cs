using BestOilCafe.Data;
using BestOilCafe.Model;
using BestOilCafe.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilCafe.Presenter
{
    public class HomePresenter
    {
        private readonly PetrolContext _db;
        private IHomeWindow _view;

        

        public HomePresenter(IHomeWindow view)
        {
            _view = view;
           _db=new PetrolContext();

            var count = _db.Petrols.Count();
            if (count == 0)
            {
                _db.Petrols.AddRange(new List<Petrol>
                {
                    new Petrol
                    {
                        Name="A-92",
                        Price=1,
                    },
                    new Petrol
                    {
                        Name="A-95",
                        Price=2,
                    },
                    new Petrol
                    {
                        Name="A-98",
                        Price=2.30,
                    },
                    new Petrol
                    {
                        Name="Dizel",
                        Price=0.80,
                    }
                });
                _db.SaveChanges();
            }

            _view.WindowLoad += WindowLoad;
            _view.PetrolChangeClicked += PetrolChangeClicked;
            _view.MoneyChangeClicked += MoneyChangeClicked;
            _view.LiterChangeClicked += LiterChangeClicked;
            _view.CheckClicked += CheckClicked;
        }
        private void WindowLoad(object sender, EventArgs e)
        {
            _view.Petrols=_db.Petrols.ToList();
        }
        private void PetrolChangeClicked(object sender, EventArgs e)
        {
            var selecteditem = (sender as ComboBox).SelectedItem as Petrol;
            _view.PriceText = selecteditem.Price.ToString();
        }
        private void MoneyChangeClicked(object sender, EventArgs e)
        {
            _view.SetEnableMoney = !_view.SetEnableMoney;
        }
        private void LiterChangeClicked(object sender, EventArgs e)
        {
            _view.SetEnableLiter=!_view.SetEnableLiter;
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            
        }

        private void moneyTxtB_TextChanged(object sender, EventArgs e)
        {
            var petrol=(sender as ComboBox).SelectedItem as Petrol;
            var price = petrol.Price;

        }


    }
}
