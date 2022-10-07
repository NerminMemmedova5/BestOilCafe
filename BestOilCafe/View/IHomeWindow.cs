using BestOilCafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOilCafe.View
{
    public interface IHomeWindow
    {
        EventHandler<EventArgs> WindowLoad { get; set; }
        EventHandler<EventArgs> PetrolChangeClicked { get; set; }
        EventHandler<EventArgs> MoneyChangeClicked { get; set; }
        EventHandler<EventArgs> LiterChangeClicked { get; set; }
        EventHandler<EventArgs> CheckClicked { get; set; }
        List<Petrol> Petrols { set; }
        List<Check> Checks { set; }
        string PriceText { get; set; }
        string MoneyText { get; set; }
        string LiterText { get; set; }
        string SumPetrolPrice { get; set; }
        bool SetEnableMoney { get; set; }
        bool SetEnableLiter { get; set; }

        string HotDogPriceText { get; set; }
        string HotDogPiecesText { get; set; }
        string HamburgerPriceText { get; set; }
        string HamburgerPiecesText { get; set; }
        string FriPriceText { get; set; }
        string FriPiecesText { get; set; }
        string ColaPriceText { get; set; }
        string ColaPiecesText { get; set; }

        bool SetEnableHotdog { get; set; }
        bool SetEnableHamburger { get; set; }
        bool SetEnableFri { get; set; }
        bool SetEnableCola { get; set; }


    }
}
