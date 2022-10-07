using BestOilCafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilCafe.View
{
    public partial class HomeWindow : Form,IHomeWindow
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> WindowLoad { get ; set ; }
        public EventHandler<EventArgs> PetrolChangeClicked { get; set ; }
        public EventHandler<EventArgs> MoneyChangeClicked { get ; set; }
        public EventHandler<EventArgs> LiterChangeClicked { get ; set ; }
        public EventHandler<EventArgs> CheckClicked { get; set ; }
        public List<Petrol> Petrols { set {
                petrolComboB.DataSource = null;
                petrolComboB.DataSource = value;
            } }
        public List<Check> Checks { set
            {
                checkListB.DataSource = null;
                checkListB.DataSource = value;
            }
        }
        public string PriceText { get =>priceTxtB.Text ; set =>priceTxtB.Text=value; }
        public string MoneyText { get => moneyTxtB.Text; set => moneyTxtB.Text=value; }
        public string LiterText { get => literTxtB.Text; set => literTxtB.Text=value; }
        public string SumPetrolPrice { get => sumpetrolpriceTxtB.Text; set => sumpetrolpriceTxtB.Text=value; }
        public bool SetEnableMoney { get => moneyTxtB.Enabled; set =>moneyTxtB.Enabled=value; }
        public bool SetEnableLiter { get => literTxtB.Enabled; set => literTxtB.Enabled=value; }
        
        public string HotDogPriceText { get => HotdogpriceTxtB.Text; set => HotdogpriceTxtB.Text=value; }
        public string HotDogPiecesText { get => hotdogPiecesTxtB.Text; set => hotdogPiecesTxtB.Text=value; }
        public string HamburgerPriceText { get => hamburgerPriceTxtB.Text; set => hamburgerPriceTxtB.Text = value; }
        public string HamburgerPiecesText { get => hamburgerPiecesTxtB.Text; set => hamburgerPiecesTxtB.Text=value; }
        public string FriPriceText { get => friPriceTxtB.Text; set => friPriceTxtB.Text=value; }
        public string FriPiecesText { get => friPiecesTxtB.Text; set => friPiecesTxtB.Text=value; }
        public string ColaPriceText { get => colaPriceTxtB.Text; set => colaPriceTxtB.Text=value; }
        public string ColaPiecesText { get => colaPiecesTxtB.Text; set => colaPiecesTxtB.Text=value; }
        public bool SetEnableHotdog { get =>hotdogPiecesTxtB.Enabled; set =>hotdogPiecesTxtB.Enabled=value ; }
       
        public bool SetEnableHamburger { get => hamburgerPiecesTxtB.Enabled; set => hamburgerPiecesTxtB.Enabled=value; }
        public bool SetEnableFri { get =>friPiecesTxtB.Enabled; set => friPiecesTxtB.Enabled=value; }
        public bool SetEnableCola { get => colaPiecesTxtB.Enabled; set => colaPiecesTxtB.Enabled = value; }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            WindowLoad.Invoke(sender, e);
        }
        private void petrolComboB_SelectedIndexChanged(object sender, EventArgs e)
        {
            PetrolChangeClicked.Invoke(sender, e);
        }
        private void moneyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            MoneyChangeClicked.Invoke(sender, e);
        }

        private void literRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LiterChangeClicked.Invoke(sender, e);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            CheckClicked.Invoke(sender, e);
        }

        private void petrolcheckListB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
