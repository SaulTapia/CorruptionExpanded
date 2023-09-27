using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CorruptionExpanded.Content.Projectiles
{
	public class BallBusterProjectile : ModProjectile
	{
		
		public override void SetDefaults()
		{			
			Projectile.width = 10;
			Projectile.height = 10;			
			Projectile.friendly = false;
			Projectile.DamageType = DamageClass.Magic;

			AIType = ProjectileID.DiamondBolt;
            Projectile.CloneDefaults(ProjectileID.DiamondBolt);        	// projectile.aiStyle = 3; This line is not needed since CloneDefaults sets it already.	        
			Projectile.DamageType = DamageClass.Magic;
		}

		// Additional hooks/methods here.
        
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)  {
            Main.NewText(target.FullName + "'s balls have been busted");
        }
	}
}