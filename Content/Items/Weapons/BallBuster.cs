using Terraria;
using Terraria.Chat;
using Terraria.ID;
using Terraria.ModLoader;
using CorruptionExpanded.Content.Projectiles;

namespace CorruptionExpanded.Content.Items.Weapons
{
    public class BallBuster : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 100;
            Item.rare = ItemRarityID.Blue;
            Item.useStyle = 5;
            Item.useTurn = false;
            Item.damage = 999999999;

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.mana = 1;
            // Set other Item.X values here

            Item.noMelee = true;
            Item.shoot = ModContent.ProjectileType<BallBusterProjectile>();
            Item.shootSpeed = 20f;

            Item.DamageType = DamageClass.Magic;
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }

    }
}