using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CorruptionExpanded.Content.Items;
using Terraria.DataStructures;

namespace CorruptionExpanded.Content.TileChanges
{
    public class CorruptionThornyBush : GlobalTile
    {
        public override void Drop(int i, int j, int type)
        {            

            switch (type) {
                case 32: // Corrupt thorny bush
                    {
                        Vector2 position = new Vector2(i * 16, j * 16); // converted tile coordinates to world coordinates
                        Vector2 randomBox = new Vector2(16, 16); // Size of the box
                        var tileEntitySource = new AEntitySource_Tile(i, j, ""); // Or a similar existing class                
                        Item.NewItem(tileEntitySource, position, randomBox, ModContent.ItemType<CorruptThorn>(), Main.rand.Next(1, 4));
                        break;
                    }
                case 24:
                    {
                        Vector2 position = new Vector2(i * 16, j * 16); // converted tile coordinates to world coordinates
                        Vector2 randomBox = new Vector2(16, 16); // Size of the box
                        var tileEntitySource = new AEntitySource_Tile(i, j, ""); // Or a similar existing class
                        if(Main.rand.Next(0, 2) > 0) {
                            Item.NewItem(tileEntitySource, position, randomBox, ModContent.ItemType<CorruptThorn>(), 1);
                        }
                        break;
                    }
            }            
            base.Drop(i, j, type);
        }
    }
}
