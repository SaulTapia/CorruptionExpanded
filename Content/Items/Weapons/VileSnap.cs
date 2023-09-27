using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using CorruptionExpanded.Content.Projectiles;
using CorruptionExpanded.Content.Buffs;

namespace CorruptionExpanded.Content.Items.Weapons
{
	public class VileSnap : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;			
		}

		public override void SetDefaults()
		{
			Item.DefaultToWhip(ModContent.ProjectileType<VileSnapProjectile>(), 10, 2, 4);
			Item.shootSpeed = 4;
			Item.rare = ItemRarityID.Blue;    
			Item.channel = true;
			Item.DamageType = DamageClass.Summon;
		}

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Content.Items.CorruptThorn>(), 15) // Adding 15 Corrupt Thorns as an ingredient
                .AddIngredient(ItemID.IronBar, 3) // Adding 3 Iron Bars as an ingredient
                .AddTile(TileID.WorkBenches) // Specifying that this recipe should be craftable at a Work Bench
                .Register(); // Registering this recipe
        }

		// Makes the whip receive melee prefixes
		public override bool MeleePrefix()
		{
			return true;
		}

        

    }
}