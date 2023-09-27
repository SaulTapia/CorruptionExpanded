using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CorruptionExpanded.Content.Buffs;
using System;

namespace CorruptionExpanded.Content.TileChanges
{
    public class MyGlobalNPC : GlobalNPC
    {

        public override void OnHitPlayer(NPC npc, Player target, Player.HurtInfo hurtInfo)
        {
                                
            if (npc.type == NPCID.EaterofSouls) // Check if the NPC is an Eater of Souls
            {
                target.AddBuff(ModContent.BuffType<VileRot>(), 600); // Applies the VileRot debuff for 600 frames (10 seconds)
            }
            base.OnHitPlayer(npc, target, hurtInfo);
        }    
    }
}