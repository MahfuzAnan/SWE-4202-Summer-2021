using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Management_System
{
    internal class Place_Order
    {
        public int order_id;
        public int shirt;
        public int pants;
        public int suits;
        public int sheets;
        public string status;
        public string shirt_to_do;
        public string pants_to_do;
        public string suits_to_do;
        public string sheets_to_do;
        public int price_shirt, price_pants, price_suits, price_sheets;

        public string ShirtHistory()
        {
            return "Type:Shirt" + "\t" + "To_Do:" + shirt_to_do + "\t" + "Quantity:" + shirt.ToString() + "\t" + "Price:" + (price_shirt*shirt).ToString();
        }
        public string PantsHistory()
        {
            return "Type:Pants" + "\t" + "To_Do:" + pants_to_do + "\t" + "Quantity:" + pants.ToString() + "\t" + "Price:" + (price_pants*pants).ToString();
        }
        public string SuitHistory()
        {
            return "Type:Suit" + "\t" + "To_Do:" + suits_to_do + "\t" + "Quantity:" + suits.ToString() + "\t" + "Price:" + (price_suits*suits).ToString();
        }
        public string SheetHistory()
        {
            return "Type:Bed Sheets" + "\t" + "To_Do:" + sheets_to_do + "\t" + "Quantity:" + sheets.ToString() + "\t" + "Price:" + (price_sheets*sheets).ToString();
        }
        public string GetAmount()
        {
            return ((shirt*price_shirt)+(pants*price_pants)+(suits*price_suits)+(sheets*price_sheets)).ToString();
        }
    }
}
