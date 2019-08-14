using BlackSlope.Repositories.Movies.DtoModels;
using Microsoft.EntityFrameworkCore;

namespace BlackSlope.Api.Repositories.Movies.Context.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieDtoModel>().HasData(
                new MovieDtoModel { Id = 1, Title = "The Shawshank Redemption", Description = "Lorem ipsum dolor sit amet, ut consul soluta persius quo, et eam mundi scribentur, eros invidunt dissentias no eum." },
                new MovieDtoModel { Id = 2, Title = "The Godfather", Description = "Eos dolor perpetua ne, cum agam causae petentium ei." },
                new MovieDtoModel { Id = 3, Title = "The Dark Knight", Description = "At idque electram moderatius vix. Legere postulant at per." },
                new MovieDtoModel { Id = 4, Title = "The Godfather: Part II", Description = "Sanctus fuisset pericula cu usu, mea an idque dicam accumsan." },
                new MovieDtoModel { Id = 5, Title = "The Lord of the Rings: The Return of the King", Description = "Et natum tollit sed." },
                new MovieDtoModel { Id = 6, Title = "Pulp Fiction", Description = "Usu ad omnium civibus persecuti." }, 
                new MovieDtoModel { Id = 7, Title = "Schindler's List", Description = "In graeco omnesque oporteat vim, ad sed nonumy consulatu." },
                new MovieDtoModel { Id = 8, Title = "12 Angry Men", Description = "Odio euismod et vel, has ad modo graecis pertinacia." },
                new MovieDtoModel { Id = 9, Title = "Inception", Description = "Vim nibh solet scaevola te, sea illud posse partem an." },
                new MovieDtoModel { Id = 10, Title = "Fight Club", Description = "Ad mea errem legimus efficiendi." },
                new MovieDtoModel { Id = 11, Title = "The Lord of the Rings: The Fellowship of the Ring", Description = "Sale dolorum fabellas te cum, cu sea purto civibus menandri." },
                new MovieDtoModel { Id = 12, Title = "Forrest Gump", Description = "Idque viris zril vel et." },
                new MovieDtoModel { Id = 13, Title = "The Good, the Bad and the Ugly", Description = "Ius ut luptatum democritum ullamcorper. Dolor possit facilis sit an, sit ei rebum meliore interesset." },
                new MovieDtoModel { Id = 14, Title = "Avengers: Endgame", Description = "Cum meliore admodum ei, eos id summo audire, qui facilisi deterruisset ei." },
                new MovieDtoModel { Id = 15, Title = "The Lord of the Rings: The Two Towers", Description = "Vix ei falli salutatus eloquentiam." },
                new MovieDtoModel { Id = 16, Title = "The Matrix", Description = "Congue verear consetetur pri at." },
                new MovieDtoModel { Id = 17, Title = "Goodfellas", Description = "Ius eu sapientem constituam, aeque assueverit his ea, in homero graeco saperet quo." },
                new MovieDtoModel { Id = 18, Title = "Star Wars: Episode V - The Empire Strikes Back", Description = "Et est vero animal torquatos, illum principes eum ad, ad vocent iisque fuisset qui." },
                new MovieDtoModel { Id = 19, Title = "One Flew Over the Cuckoo's Nest", Description = "Has vocent fastidii appareat ne, mel eu fabellas scripserit." },
                new MovieDtoModel { Id = 20, Title = "Seven Samurai", Description = "Et duo iudico semper fabulas." },
                new MovieDtoModel { Id = 21, Title = "Interstellar", Description = "Eos te volumus interesset, sint cotidieque eum et." },
                new MovieDtoModel { Id = 22, Title = "City of God", Description = "Ad vel graece principes definitiones, ad vide populo vis, ex eos sumo efficiantur necessitatibus." },
                new MovieDtoModel { Id = 23, Title = "Spirited Away", Description = "Mel an sumo iusto, clita facilis adipiscing cum cu." },
                new MovieDtoModel { Id = 24, Title = "Saving Private Ryan", Description = "Has vocent alienum te." },
                new MovieDtoModel { Id = 25, Title = "The Green Mile", Description = "Eu adhuc percipit eleifend eam." },
                new MovieDtoModel { Id = 26, Title = "Life Is Beautiful ", Description = "Clita mollis disputando cu eam, no pri insolens abhorreant." },
                new MovieDtoModel { Id = 27, Title = "The Usual Suspects", Description = "Ex atomorum repudiandae has, euismod vocibus ei eam, ei eam esse pertinacia abhorreant." },
                new MovieDtoModel { Id = 28, Title = "Se7en", Description = "Et probo ornatus sententiae cum, in unum urbanitas usu." },
                new MovieDtoModel { Id = 29, Title = "Léon: The Professional", Description = "Velit omittam inciderint te cum, sit at urbanitas reformidans." },
                new MovieDtoModel { Id = 30, Title = "The Silence of the Lambs", Description = "Causae tincidunt pro no, ius munere viderer albucius ex." },
                new MovieDtoModel { Id = 31, Title = "Star Wars: Episode IV - A New Hope", Description = "Id detraxit facilisi eleifend mea, mel ex nobis bonorum oporteat, ius oportere evertitur ut." },
                new MovieDtoModel { Id = 32, Title = "It's a Wonderful Life", Description = "No discere adolescens mnesarchum eam, quo latine voluptua ei." },
                new MovieDtoModel { Id = 33, Title = "Once Upon a Time ... in Hollywood", Description = "Ei pro dolorem fierent blandit, te mea viris nihil legimus." },
                new MovieDtoModel { Id = 34, Title = "Spider-Man: Into the Spider-Verse", Description = "Ex duo euismod fastidii, cu euismod splendide signiferumque qui, eu eos doctus virtute." },
                new MovieDtoModel { Id = 35, Title = "Avengers: Infinity War", Description = "Eum cu quem integre verterem, has animal fabulas ut." },
                new MovieDtoModel { Id = 36, Title = "Whiplash", Description = "Tacimates definiebas has an." },
                new MovieDtoModel { Id = 37, Title = "The Intouchables", Description = "Nec ut ridens meliore pertinax." },
                new MovieDtoModel { Id = 38, Title = "The Prestige", Description = "Mei te graeci essent, dico sapientem cum ea, eum ei graeci alterum." }, 
                new MovieDtoModel { Id = 39, Title = "The Departed", Description = "Elit quando dictas eos ei." },
                new MovieDtoModel { Id = 40, Title = "The Pianist", Description = "Eros tota utinam mei ei, iisque consequuntur te his." },
                new MovieDtoModel { Id = 41, Title = "Memento", Description = "Ne per fugit graece, quando expetendis id sea." },
                new MovieDtoModel { Id = 42, Title = "Gladiator", Description = "Duo novum noluisse et, at vel adhuc porro minim." },
                new MovieDtoModel { Id = 43, Title = "American History X", Description = "Dictas contentiones no his, exerci oportere ea eam." },
                new MovieDtoModel { Id = 44, Title = "The Lion King", Description = "No sonet omnes mnesarchum quo." },
                new MovieDtoModel { Id = 45, Title = "Terminator 2: Judgment Day", Description = "Postea platonem has te, ei quod dicit sit, sea et movet delicata scribentur." },
                new MovieDtoModel { Id = 46, Title = "Cinema Paradiso", Description = "Malis dictas detracto et ius, no qualisque vulputate per." },
                new MovieDtoModel { Id = 47, Title = "Grave of the Fireflies", Description = "Platonem oportere in has, nam recusabo delicata elaboraret ei, dico gubergren hendrerit ex sea." },
                new MovieDtoModel { Id = 48, Title = "Back to the Future", Description = "Cu usu velit omittam temporibus, natum vulputate sea eu." },
                new MovieDtoModel { Id = 49, Title = "Raiders of the Lost Ark", Description = "Gubergren scriptorem eu vel, eius percipitur te per, vel tale habeo et." },
                new MovieDtoModel { Id = 50, Title = "Apocalypse Now", Description = "Alii insolens inciderint pro an, ei eos utinam commodo tacimates." }
            );
        }
    }
}
