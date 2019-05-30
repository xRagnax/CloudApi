using ChiroAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChiroAPI.Data
{
    public class DBinit
    {
        public static void Init(LeidingContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Leiders.Any())
            {
                var leider1 = new Leiding()
                {
                    
                    Naam = "Pieter Florus",
                    Leeftheid = 22,
                    Groep = "Speelclubs",
                    JaarLeiding = 4,
                    Email = "een@email.com"             
                };
                var leider2 = new Leiding()
                {

                    Naam = "Toon",
                    Leeftheid = 22,
                    Groep = "Sloebers",
                    JaarLeiding = 4,
                    Email = "een@email.com"
                };

                var leider3 = new Leiding()
                {

                    Naam = "Rik",
                    Leeftheid = 23,
                    Groep = "Aspiranten",
                    JaarLeiding = 5,
                    Email = "een@email.com"
                };

                context.Leiders.Add(leider1);
                context.Leiders.Add(leider2);
                context.Leiders.Add(leider3);
                context.SaveChanges();
            }
        }
    }
}
