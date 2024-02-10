using System.Threading.Tasks;
using CrossWord.BookInventory.Localization;
using CrossWord.BookInventory.MultiTenancy;
using CrossWord.BookInventory.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace CrossWord.BookInventory.Web.Menus;

public class BookInventoryMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<BookInventoryResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                BookInventoryMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        var bookStoreMenu = new ApplicationMenuItem(
               "BooksStore",
               l["Menu:BookStore"],
               icon: "fa fa-book"
           );

        context.Menu.AddItem(bookStoreMenu);

        //CHECK the PERMISSION
        if (context.IsGrantedAsync(BookInventoryPermissions.Books.Default).Result)
        {
            bookStoreMenu.AddItem(new ApplicationMenuItem(
                "BooksStore.Books",
                l["Menu:Books"],
                url: "/Books"
            ));
        }

        if (context.IsGrantedAsync(BookInventoryPermissions.Authors.Default).Result)
        {
            bookStoreMenu.AddItem(new ApplicationMenuItem(
                "BooksStore.Authors",
                l["Menu:Authors"],
                url: "/Authors"
            ));
        }

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
