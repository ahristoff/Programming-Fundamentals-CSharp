using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Teamwork_projects
{
    class Team
    {
        public string ImeNaEkip { get; set; }
        public string Syzdatel { get; set; }
        public List<string> Uchastnici { get; set; }

        public Team()
        {
            Uchastnici = new List<string>();
        }
    }
}
