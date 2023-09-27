using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CorruptionExpanded.Content.Projectiles;

namespace CorruptionExpanded.Content.Items
{
    public class VileArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            
        }

        public override void SetDefaults()
        {
            Item.damage = 10; // The damage of your arrow
            // Item.ranged = true;
            Item.width = 14;
            Item.height = 32;
            Item.maxStack = 999;
            Item.consumable = true; // This means the arrow is a consumable item
            Item.knockBack = 1.5f;
            Item.value = 10;
            Item.rare = ItemRarityID.Green;
            Item.shoot = ModContent.ProjectileType<VileArrowProjectile>(); // The projectile it shoots
            Item.ammo = AmmoID.Arrow; // The ammo type
            Item.DamageType = DamageClass.Ranged;
        }

        public override void AddRecipes()
        {
            CreateRecipe(25)
                .AddIngredient(ModContent.ItemType<Content.Items.CorruptThorn>(), 1)
                .AddIngredient(ItemID.WoodenArrow, 25)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
