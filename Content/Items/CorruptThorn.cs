using Terraria.ModLoader;

namespace CorruptionExpanded.Content.Items
{
    public class CorruptThorn : ModItem
    {
        public override void SetStaticDefaults()
        {
            
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 100;
            Item.rare = 1;
        }
    }
}
