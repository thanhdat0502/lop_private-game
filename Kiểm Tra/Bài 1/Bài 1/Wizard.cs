using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
    {
        class Wizard
        {
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Mana { get; set; }
            public Wizard (string name, int damage, int mana)
            {
                Name = name;
                Damage = damage;
                Mana = mana;
            }
            public void CastSpell(string name, int damage, int mana)
            {
                Console.WriteLine($"Thay phap Quang Minh tung chuong {name} gay {damage} sat thuong voi {mana} Mana");
            }
        }
    }

