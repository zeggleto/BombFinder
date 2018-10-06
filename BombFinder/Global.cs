using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BombFinder.Items;

namespace BombFinder
{
    public static class Global
    {
        public static BombField MainBombField { get; set; }
        public static Label GameStatusLabel { get; set; }
    }
}
