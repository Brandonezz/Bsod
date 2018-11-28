using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wServer.realm.worlds
{
    public class AdminArena : World
    {
        public AdminArena()
        {
            Name = "Admins Arena";
            ClientWorldName = "Admins Arena";
            Background = 0;
            Difficulty = 2;
            AllowTeleport = true;
        }

        protected override void Init()
        {
            LoadMap("wServer.realm.worlds.maps.AdminArena.jm", MapType.Json);
        }
    }
}