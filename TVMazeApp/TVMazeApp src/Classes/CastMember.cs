using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class CastMember
    {
        public string name { get; set; }
        public string character { get; set; }

        public CastMember(string name, string character)
        {
            this.name = name;
            this.character = character;
        }

        public override string ToString()
        {
            return $"{name} as {character}";
        }
    }
}
