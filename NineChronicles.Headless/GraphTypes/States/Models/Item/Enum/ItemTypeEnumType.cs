using GraphQL;
using GraphQL.Types;
using Nekoyume.Model.Item;

namespace NineChronicles.Headless.GraphTypes.States.Models.Item.Enum
{
    public class ItemTypeEnumType : EnumerationGraphType<ItemType>
    {
        public ItemTypeEnumType()
        {
            this.AddDeprecatedNames(StringExtensions.ToPascalCase);
        }
    }
}
