﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcBootstrapCrud.Models;

namespace MvcBootstrapCrud.DAL
{
    public class MobileDBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MobileDBContext>
    {

        protected override void Seed(MobileDBContext context)
        {
            var phones = new List<Phone>
            {
                new Phone{Model="Samsung Galaxy Note 1", Company="Samsung",Price= 339},
                new Phone{Model="Samsung Galaxy Note 2", Company="Samsung",Price= 399},
                new Phone{Model="Samsung Galaxy S III", Company="Samsung",Price= 217},
                new Phone{Model="Samsung Galaxy S IV", Company="Samsung",Price= 234},
                new Phone{Model="Samsung Galaxy Note 1", Company="Samsung",Price= 339},
                new Phone{Model="Samsung Galaxy Note 2", Company="Samsung",Price= 399},
                new Phone{Model="Samsung Galaxy S III", Company="Samsung",Price= 217},
                new Phone{Model="Samsung Galaxy S IV", Company="Samsung",Price= 234},
                new Phone{Model="Samsung Galaxy Note 1", Company="Samsung",Price= 339},
                new Phone{Model="Samsung Galaxy Note 2", Company="Samsung",Price= 399},
                new Phone{Model="Samsung Galaxy S III", Company="Samsung",Price= 217},
                new Phone{Model="Samsung Galaxy S IV", Company="Samsung",Price= 234},
                new Phone{Model="Samsung Galaxy Note 1", Company="Samsung",Price= 339},
                new Phone{Model="Samsung Galaxy Note 2", Company="Samsung",Price= 399},
                new Phone{Model="Samsung Galaxy S III", Company="Samsung",Price= 217},
                new Phone{Model="Samsung Galaxy S IV", Company="Samsung",Price= 234},
                new Phone{Model="Samsung Galaxy Note 1", Company="Samsung",Price= 339},
                new Phone{Model="Samsung Galaxy Note 2", Company="Samsung",Price= 399},
                new Phone{Model="Samsung Galaxy S III", Company="Samsung",Price= 217},
                new Phone{Model="Samsung Galaxy S IV", Company="Samsung",Price= 234},
                new Phone{Model="Samsung Galaxy Note 1", Company="Samsung",Price= 339},
                new Phone{Model="Samsung Galaxy Note 2", Company="Samsung",Price= 399},
                new Phone{Model="Samsung Galaxy S III", Company="Samsung",Price= 217},
                new Phone{Model="Samsung Galaxy S IV", Company="Samsung",Price= 234},
                new Phone{Model="Samsung Galaxy Note 1", Company="Samsung",Price= 339},
                new Phone{Model="Samsung Galaxy Note 2", Company="Samsung",Price= 399},
                new Phone{Model="Samsung Galaxy S III", Company="Samsung",Price= 217},
                new Phone{Model="Samsung Galaxy S IV", Company="Samsung",Price= 234},
                new Phone{Model="iPhone 5", Company="Apple",Price= 456}
            };

            phones.ForEach(p => context.Phones.Add(p));
            context.SaveChanges();
        }
    }
}