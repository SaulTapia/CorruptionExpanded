using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CorruptionExpanded.Content.Buffs;

namespace CorruptionExpanded.Content.Projectiles
{
    public class VileArrowProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.arrow = true;
            Projectile.width = 14;
            Projectile.height = 32;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            // Projectile.ranged = true;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.aiStyle = ProjAIStyleID.Arrow; // or 1
            AIType = ProjectileID.WoodenArrowFriendly;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			Main.player[Projectile.owner].MinionAttackTargetNPC = target.whoAmI;
			target.AddBuff(ModContent.BuffType<VileRot>(), 5); // Applies the VileRot debuff for 600 frames (10 seconds)
			
		}

        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
			target.AddBuff(ModContent.BuffType<VileRot>(), 5);
            base.OnHitPlayer(target, info);
        }
    }
}
