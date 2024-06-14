using EPiServer.Shell.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arlanet.Optimizely.ProductMarkets
{
    [MenuProvider]
    public class ProductMarketsMenuProvider : IMenuProvider
    {
        private const string MainMenuPath = MenuPaths.Global + "/commerce";  

        public IEnumerable<MenuItem> GetMenuItems()
        {
            var menuItems = new List<MenuItem>();

            menuItems.Add(new UrlMenuItem("Product Markets", MainMenuPath + "/productmarkets", "/episerver/productmarkets/index")
            {
                SortIndex = 100
            });

            return menuItems;

        }
    }
}
