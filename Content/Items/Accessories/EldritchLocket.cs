using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CorruptionExpanded.Content.Items;

namespace CorruptionExpanded.Content.Items.Accessories
{
    public class EldritchLocket : ModItem
    {
        public override void SetStaticDefaults()
        {

        }

        public override void SetDefaults()
        {
            Item.width = 24; // Width of the item sprite
            Item.height = 24; // Height of the item sprite
            Item.value = Item.sellPrice(gold: 1); // Sell price (optional)
            Item.rare = ItemRarityID.Green; // Rarity of the item
            Item.accessory = true; // Declares that this item is an accessory
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 2; // Adds 2 to player defense
            player.moveSpeed += 0.05f; // Increases movement speed by 5%
            player.lifeRegen += 1; // Adds 1 to player life regeneration
        }
        
        public override void AddRecipes()
        {
            CreateRecipe()
                // .AddIngredient(ModContent.ItemType<Content.Items.CorruptThorn>(), 15)
                .AddIngredient(ItemID.Ebonwood, 50)
                .AddIngredient(ItemID.IronBar, 10)
                .AddTile(TileID.Anvils) // Specifying that this recipe should be craftable at a Work Bench
                .Register(); // Registering this recipe
        }
    }
}
