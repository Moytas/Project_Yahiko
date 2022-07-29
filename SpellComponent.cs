using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class SpellComponent
    {
        public bool Verbal, Somatic, Material;

        public List<Items> Materials = new List<Items>();

        public SpellComponent(bool verbal, bool somatic, bool material, List<Items> materials)
        {
            Verbal = verbal;
            Somatic = somatic;
            Material = material;
            Materials = materials;
        }
    }
}
