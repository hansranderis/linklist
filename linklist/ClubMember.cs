using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linklist
{
    class ClubMember
    {
        public int Nr { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"NR: {Nr} Fornavn: {Fname} Lastname: {Lname} Alder: {Age}";
        }
    }
}
