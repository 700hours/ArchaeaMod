﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ArchaeaMod.Projectiles;

namespace ArchaeaMod.Items
{
    public class magno_yoyo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magno Yoyo");
            Tooltip.SetDefault("Throws out a Magno Yoyo");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.damage = 10;
            item.knockBack = 3f;
            item.value = 2500;
            item.rare = 1;

            //  custom sound?
            //  item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/*");
            //  default usesound
            item.UseSound = SoundID.Item1;
            item.channel = true;

            item.autoReuse = false;
            item.consumable = false;
            item.noMelee = true;
            item.melee = true;
            item.noUseGraphic = true;
            item.shoot = mod.ProjectileType<m_yoyoprojectile>();
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(9);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}