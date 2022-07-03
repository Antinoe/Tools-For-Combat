using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace ToolsForCombat
{
    public class ToolsForCombatGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if(item.axe > 0 && item.damage > 0)
            {
				item.damage += 5;
                item.damage *= 2;
                item.useAnimation += (int)(item.useAnimation * 0.50f);
            }
            if(item.pick > 0 && item.damage > 0)
            {
				item.damage += 2;
                item.damage *= 2;
                item.useAnimation += (int)(item.useAnimation * 0.65f);
            }
            if(item.hammer > 0 && item.damage > 0)
            {
				item.damage += 7;
                item.damage *= 2;
                item.useAnimation += (int)(item.useAnimation * 0.75f);
            }
			//Finally.. A way to detect Shields...
			//Now I just need to tinker around with it more to get it working the way I want it to.
			/*if(EquipType.Shield > 0)
			{
				item.damage *= 50;
			}*/
        }
	}
}