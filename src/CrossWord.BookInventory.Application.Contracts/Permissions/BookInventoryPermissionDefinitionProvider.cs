using CrossWord.BookInventory.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CrossWord.BookInventory.Permissions;

public class BookInventoryPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(BookInventoryPermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = bookStoreGroup.AddPermission(BookInventoryPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookInventoryPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookInventoryPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookInventoryPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = bookStoreGroup.AddPermission(BookInventoryPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(BookInventoryPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(BookInventoryPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(BookInventoryPermissions.Authors.Delete, L("Permission:Authors.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookInventoryResource>(name);
    }
}
