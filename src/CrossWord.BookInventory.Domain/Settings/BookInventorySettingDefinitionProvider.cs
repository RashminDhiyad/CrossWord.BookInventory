using Volo.Abp.Settings;

namespace CrossWord.BookInventory.Settings;

public class BookInventorySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookInventorySettings.MySetting1));
    }
}
