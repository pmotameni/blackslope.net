using BlackSlope.Repositories.Movies.DtoModels;
using Microsoft.EntityFrameworkCore;

namespace BlackSlope.Api.Repositories.Movies.Context.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieDtoModel>().HasData(
                new MovieDtoModel { Id = 1, Title = "The Shawshank Redemption", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency." },
                new MovieDtoModel { Id = 2, Title = "The Godfather", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son." },
                new MovieDtoModel { Id = 3, Title = "The Dark Knight", Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham." },
                new MovieDtoModel { Id = 4, Title = "The Godfather: Part II", Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate." },
                new MovieDtoModel { Id = 5, Title = "The Lord of the Rings: The Return of the King", Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring." },
                new MovieDtoModel { Id = 6, Title = "Pulp Fiction", Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption." }, 
                new MovieDtoModel { Id = 7, Title = "Schindler's List", Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis." },
                new MovieDtoModel { Id = 8, Title = "12 Angry Men", Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence." },
                new MovieDtoModel { Id = 9, Title = "Inception", Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O." },
                new MovieDtoModel { Id = 10, Title = "Fight Club", Description = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more." },
                new MovieDtoModel { Id = 11, Title = "The Lord of the Rings: The Fellowship of the Ring", Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron." },
                new MovieDtoModel { Id = 12, Title = "Forrest Gump", Description = "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75." },
                new MovieDtoModel { Id = 13, Title = "The Good, the Bad and the Ugly", Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery." },
                new MovieDtoModel { Id = 14, Title = "Avengers: Endgame", Description = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe." },
                new MovieDtoModel { Id = 15, Title = "The Lord of the Rings: The Two Towers", Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard." },
                new MovieDtoModel { Id = 16, Title = "The Matrix", Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers." },
                new MovieDtoModel { Id = 17, Title = "Goodfellas", Description = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate." },
                new MovieDtoModel { Id = 18, Title = "Star Wars: Episode V - The Empire Strikes Back", Description = "After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued by Darth Vader." },
                new MovieDtoModel { Id = 19, Title = "One Flew Over the Cuckoo's Nest", Description = "A criminal pleads insanity after getting into trouble again and once in the mental institution rebels against the oppressive nurse and rallies up the scared patients." },
                new MovieDtoModel { Id = 20, Title = "Seven Samurai", Description = "A poor village under attack by bandits recruits seven unemployed samurai to help them defend themselves." },
                new MovieDtoModel { Id = 21, Title = "Interstellar", Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival." },
                new MovieDtoModel { Id = 22, Title = "City of God", Description = "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin." },
                new MovieDtoModel { Id = 23, Title = "Spirited Away", Description = "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts." },
                new MovieDtoModel { Id = 24, Title = "Saving Private Ryan", Description = "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action." },
                new MovieDtoModel { Id = 25, Title = "The Green Mile", Description = "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift." },
                new MovieDtoModel { Id = 26, Title = "Life Is Beautiful ", Description = "When an open-minded Jewish librarian and his son become victims of the Holocaust, he uses a perfect mixture of will, humor, and imagination to protect his son from the dangers around their camp." },
                new MovieDtoModel { Id = 27, Title = "The Usual Suspects", Description = "A sole survivor tells of the twisty events leading up to a horrific gun battle on a boat, which began when five criminals met at a seemingly random police lineup." },
                new MovieDtoModel { Id = 28, Title = "Se7en", Description = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives." },
                new MovieDtoModel { Id = 29, Title = "Léon: The Professional", Description = "Mathilda, a 12-year-old girl, is reluctantly taken in by Léon, a professional assassin, after her family is murdered." },
                new MovieDtoModel { Id = 30, Title = "The Silence of the Lambs", Description = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims." },
                new MovieDtoModel { Id = 31, Title = "Star Wars: Episode IV - A New Hope", Description = "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader." },
                new MovieDtoModel { Id = 32, Title = "It's a Wonderful Life", Description = "An angel is sent from Heaven to help a desperately frustrated businessman by showing him what life would have been like if he had never existed." },
                new MovieDtoModel { Id = 33, Title = "Once Upon a Time ... in Hollywood", Description = "A faded television actor and his stunt double strive to achieve fame and success in the film industry during the final years of Hollywood's Golden Age in 1969 Los Angeles." },
                new MovieDtoModel { Id = 34, Title = "Spider-Man: Into the Spider-Verse", Description = "Teen Miles Morales becomes Spider-Man of his reality, crossing his path with five counterparts from other dimensions to stop a threat for all realities." },
                new MovieDtoModel { Id = 35, Title = "Avengers: Infinity War", Description = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe." },
                new MovieDtoModel { Id = 36, Title = "Whiplash", Description = "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential." },
                new MovieDtoModel { Id = 37, Title = "The Intouchables", Description = "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver." },
                new MovieDtoModel { Id = 38, Title = "The Prestige", Description = "After a tragic accident, two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other." }, 
                new MovieDtoModel { Id = 39, Title = "The Departed", Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston." },
                new MovieDtoModel { Id = 40, Title = "The Pianist", Description = "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II." },
                new MovieDtoModel { Id = 41, Title = "Memento", Description = "A man with short-term memory loss attempts to track down his wife's murderer." },
                new MovieDtoModel { Id = 42, Title = "Gladiator", Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery." },
                new MovieDtoModel { Id = 43, Title = "American History X", Description = "A former neo-nazi skinhead tries to prevent his younger brother from going down the same wrong path that he did." },
                new MovieDtoModel { Id = 44, Title = "The Lion King", Description = "A Lion cub crown prince is tricked by a treacherous uncle into thinking he caused his father's death and flees into exile in despair, only to learn in adulthood his identity and his responsibilities." },
                new MovieDtoModel { Id = 45, Title = "Terminator 2: Judgment Day", Description = "A cyborg, identical to the one who failed to kill Sarah Connor, must now protect her teenage son, John Connor, from a more advanced and powerful cyborg." },
                new MovieDtoModel { Id = 46, Title = "Cinema Paradiso", Description = "A filmmaker recalls his childhood when falling in love with the pictures at the cinema of his home village and forms a deep friendship with the cinema's projectionist." },
                new MovieDtoModel { Id = 47, Title = "Grave of the Fireflies", Description = "A young boy and his little sister struggle to survive in Japan during World War II." },
                new MovieDtoModel { Id = 48, Title = "Back to the Future", Description = "Marty McFly, a 17-year-old high school student, is accidentally sent thirty years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown." },
                new MovieDtoModel { Id = 49, Title = "Raiders of the Lost Ark", Description = "In 1936, archaeologist and adventurer Indiana Jones is hired by the U.S. government to find the Ark of the Covenant before Adolf Hitler's Nazis can obtain its awesome powers." },
                new MovieDtoModel { Id = 50, Title = "Apocalypse Now", Description = "A U.S. Army officer serving in Vietnam is tasked with assassinating a renegade Special Forces Colonel who sees himself as a god." }
            );
        }
    }
}
