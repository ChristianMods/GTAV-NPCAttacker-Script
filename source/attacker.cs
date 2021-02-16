using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Math;
using GTA.Native;
using System.Windows.Forms;
using System.Drawing;

namespace npcAttacker
{
    public class attacker : Script
    {
        public attacker()
        {
            this.Tick += onTick;
            this.KeyUp += onKeyUp;
            this.KeyDown += onKeyDown;
        }

        private void onTick(object sender, EventArgs e) // these arent needed but are included for a gernal template for other mods
        {
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J)
            {
                var npc = World.CreatePed(PedHash.LamarDavis, Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0, 5, 0)));
                npc.Weapons.Give(WeaponHash.Unarmed, 1, true, true);
                npc.Task.FightAgainst(Game.Player.Character);
            }
        }
    }
}