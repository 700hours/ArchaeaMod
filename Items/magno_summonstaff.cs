﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ArchaeaMod.Buffs;

namespace ArchaeaMod.Items
{
    public class magno_summonstaff : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 32;
            item.useTime = 24;
            item.useAnimation = 18;
            item.useStyle = 1;
            item.damage = 12;
            item.knockBack = 3f;
            item.value = 4000;
            item.rare = 2;
            //  custom sound?
            //  item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/conjure");
            //  or vanilla sound
            //  item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.consumable = false;
            item.noMelee = true;
            item.summon = true;
            item.buffType = mod.BuffType<magno_summon>();
            item.buffTime = 18000;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(9);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            if (player.ownedProjectileCounts[mod.ProjectileType("magno_minion")] < 1)
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/conjure"), player.Center);
                int projMinion = Projectile.NewProjectile(player.position, Vector2.Zero, mod.ProjectileType("magno_minion"), 5, 3f, player.whoAmI, 0f, 0f);
            }
            return true;
        }
    }
}
