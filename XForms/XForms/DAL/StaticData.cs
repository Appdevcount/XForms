using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XForms.DAL
{
    class StaticData
    {
    }

    
    #region Listview demo
    /// <summary>
    /// Listview demo
    /// </summary>
    public class Fruits
    {
        public Fruits()
        {
        }
        public Fruits(string _ItemName, double _Price)
        {
            this.ItemName = _ItemName;
            this.Price = _Price;
        }
        public string ItemName { get; set; }
        public double Price { get; set; }

        public List<Fruits> FruitList()
        {
            List<Fruits> FruitList = new List<Fruits>
            {
                new Fruits("Apple",1041.00),
                new Fruits("Orange",1029.00),
                new Fruits("JackFruit",1250.00),
                new Fruits("Mango",1023.00),
                new Fruits("Banana",1230.00)

            };
            return FruitList;
        }
    }

    #endregion Listview demo

}
