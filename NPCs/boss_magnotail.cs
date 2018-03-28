﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestEnvironment.NPCs
{
    public class boss_magnotail : ModNPC
    {
        public override void SetDefaults()
        {
            npc.width = 64;
            npc.height = 128;
            npc.friendly = false;
            npc.aiStyle = 6;
        //  aiType = NPCID.Worm;
            npc.noTileCollide = true;
            npc.noGravity = true;
            npc.behindTiles = true;
            npc.damage = 18;
            npc.defense = 4;
            npc.lifeMax = 120;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0f;
        }
        public override void AI()
        {
            if (!Main.npc[(int)npc.ai[1]].active || Main.npc[(int)npc.ai[1]].life <= 0)
            {
                npc.life = 0;
                npc.HitEffect(0, 10.0);
                npc.active = false;
            }
        }
    }
}