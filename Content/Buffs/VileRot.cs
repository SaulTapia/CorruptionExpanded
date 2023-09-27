using Terraria;
using Terraria.ModLoader;

namespace CorruptionExpanded.Content.Buffs
{
    public class VileRot : ModBuff
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Vile Rot");
            // Description.SetDefault("Losing life over time due to vile corruption"); // Modify with your debuff's effect
            Main.debuff[Type] = true; // Indicates that this is a debuff as opposed to a buff
            Main.buffNoSave[Type] = true; // Indicates whether or not the buff should save between sessions.            
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 2; // This is just an example to make the player lose life over time. Modify as you see fit.
            // You can add additional effects here, based on what you want the debuff to do.
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeRegen -= 5; // The NPC loses life over time; adjust as needed.
        }
    }
}
