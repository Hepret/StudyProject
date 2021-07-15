using StudyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject
{
    public class SampleData
    {
        public static void Initialize(CountryContext context)
        {
            if (!context.Countries.Any())
            {
                context.Countries.AddRange(
                    new Country
                    {
                        Name = "Россия",
                        CardDescription = "Самая большая страна в мире",
                        CardPhotoLink = "https://avatars.mds.yandex.net/get-zen_doc/1899089/pub_5e457831c8b6c1499cb12373_5e45784bbb4a6d368b8d4d9a/scale_1200"
                    },

                    new Country
                    {
                        Name = "Ватекан",
                        CardDescription = "Самая маленькая страна в мире.",
                        CardPhotoLink = "https://turproezdka.ru/wp-content/uploads/2018/09/1.-sobor.jpg"

                    },

                    new Country
                    {
                        Name = "США",
                        CardTagline = "Страна народов и возможностей.",
                        CardPhotoLink = "https://about-planet.ru/photos/2/samye_poseshaemye_dostoprimechatelnosti_mira/samye-poseshaemye-dostoprimechatelnosti-mira-4.jpg"
                    }
                    );
                context.SaveChanges();
            }

            /* if (!context.HotCountries.Any())
             {
                 context.HotCountries.AddRange(
                     new HotCountry
                     { 

                     }

                     );
             }*/
        }
    }
}