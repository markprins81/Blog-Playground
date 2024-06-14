using EPiServer.Shell.Navigation;

namespace Foundation.CmsPlugin
{
    [MenuProvider]
    public class PluginMenuProvider : IMenuProvider
    {
        private const string MainMenuPath = MenuPaths.Global + "/cms";  // commerce

        public IEnumerable<MenuItem> GetMenuItems()
        {
            var menuItems = new List<MenuItem>();

            menuItems.Add(new UrlMenuItem("CmsPlugin", MainMenuPath + "/cmsplugin", "/episerver/plugin/index")
            {
                SortIndex = 100
            });

            return menuItems;

        }
    }
}
