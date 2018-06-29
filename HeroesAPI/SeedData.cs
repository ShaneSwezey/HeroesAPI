using System.Collections.Generic;
using HeroesAPI.Models;

namespace HeroesAPI
{
    public static class SeedData
    {
        
        public static void InjectIntoDb(HeroApiContext context)
        {
            var heroList = CreateHeroesList();
            foreach(Hero h in heroList)
            {
                context.Heroes.Add(h);
            }
            context.SaveChanges();
        }

        public static IEnumerable<Hero> CreateHeroesList()
        {
            return new List<Hero>
            {
                new Hero
                {
                    Name = "Stitches",
                    Title = "Terror of Darkshire",
                    Description = "Take care when traversing the shadowed trails " +
                        "of Duskwood... " +
                        "Ever since Abercrombie the Embalmer unleashed " +
                        "his vile abomination upon Darkshire, Stitches has " +
                        "wandered the road aimlessly, " +
                        "hungering for the flesh of low level Alliance players.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Muradin",
                    Title = "Mountain King",
                    Description = "Once a mentor to Prince Arthas, Muradin was " +
                        "unable to prevent his corruption. After recovering from" +
                        " a mild case of amnesia, he is now the leader of the " +
                        "Bronzebeard clan after the \"diamond-ization\" of " +
                        "his brother King Magni.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Sonya",
                    Title = "Wandering Barbarian",
                    Description = "From the frozen Dreadlands of the north come " +
                        "the mighty Barbarian warriors. After surviving the " +
                        "destruction of her home and death of her tribe, " +
                        "Sonya wanders Sanctuary in search of battle and a " +
                        "better life for her people.",
                    Role = "Warrior",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Tyrael",
                    Title = "Archangel Of Justice",
                    Description = "Among the angels it is the Archangel of " +
                        "Justice Tyrael who is humanity's greatest defender. " +
                        "Wielding his sword El'druin against the Burning Hells, " +
                        "the Prime Evils would have enslaved humanity long " +
                        "ago if Tyrael had not intervened.",
                    Role = "Warrior",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Raynor",
                    Title = "Renegade Commander",
                    Description = "Ex-Confederate Marshal James Raynor has " +
                        "stood against whatever the universe can throw at " +
                        "him and survived. He stands as a beacon of hope " +
                        "among enigmatic aliens and monsters, fighting for " +
                        "justice in a cold uncaring universe.",
                    Role = "Assassin",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Nova",
                    Title = "Dominion Ghost",
                    Description = "November \"Nova\" Terra is a ghost of the " +
                        "Terran Dominion and one of the most powerful psionic " +
                        "soldiers ever known. Nova is highly focused, " +
                        "determined, and extremely deadly. Even Jim Raynor " +
                        "wouldn't want to be caught in her crosshairs.",
                    Role = "Assassin",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Kerrigan",
                    Title = "Queen Of Blades",
                    Description = "Once a terran ghost with formidable psionic " +
                        "abilities, Sarah Kerrigan was betrayed by her allies " +
                        "and transformed into the Queen of Blades. Now freed " +
                        "of the dark one's corruption, Kerrigan faces a " +
                        "threat that could destroy the galaxy itself.",
                    Role = "Assassin",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Illidan",
                    Title = "The Betrayer",
                    Description = "Illidan Stormrage, the first demon hunter, " +
                        "betrayed his people and created a new Well of Eternity" +
                        " after the demonic invasion of Azeroth. Now Illidan " +
                        "lords over Outland slaying unsuitably prepared Heroes " +
                        "who venture into his domain.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Tyrande",
                    Title = "High Priestess Of Elune",
                    Description = "Tyrande Whisperwind strikes fear into all " +
                        "who wish ill of the Kaldorei. As the highest ranking " +
                        "Sentinel and High Priestess of Elune, she is not only " +
                        "the night elves' most deadly warrior, but also " +
                        "their most cunning leader.",
                    Role = "Support",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Diablo",
                    Title = "Lord Of Terror",
                    Description = "Known in the ancient tongue as Al'Diabolos, " +
                        "the Prime Evil of Terror, the Demon Lord Diablo seeks " +
                        "to claim the world of Sanctuary for the Burning Hells. " +
                        "His victims are innumerable, his schemes unknowable, " +
                        "and his gender... malleable.",
                    Role = "Warrior",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Gazlowe",
                    Title = "Boss Of Ratchet",
                    Description = "Few would consider Gazlowe a fighter, but " +
                        "what he lacks in height, he makes up in mechanical " +
                        "know-how. Besides, you don't get to be boss of a " +
                        "\"boom\"-town like Ratchet with just a charming " +
                        "personality, if you know what I mean.",
                    Role = "Specalist",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Zeratul",
                    Title = "Dark Prelate",
                    Description = "The enigmatic dark templar Zeratul serves " +
                        "the xel'naga. While he expertly wields the power of " +
                        "the Void, it is his wisdom that earns him the respect " +
                        "of the Koprulu sector's leaders - despite his " +
                        "penchant for dramatic entrances.",
                    Role = "Assassin",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Falstad",
                    Title = "Wildhammer Thane",
                    Description = "Falstad is the High Thane of the Wildhammer " +
                        "Clan and a founding member of the Council of " +
                        "Three Hammers that presides over Ironforge. Despite " +
                        "speculation, Falstad has never been dead and anyone " +
                        "who claims such is a liar.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Nazeebo",
                    Title = "Heretic Witch Doctor",
                    Description = "With cabalistic incantations and vestments " +
                        "of feather and bone, the witch doctor Nazeebo " +
                        "calls upon spirits from the Unformed Land to aid him." +
                        " Few outlanders encounter a witch doctor in the flesh," +
                        " without losing their own.",
                    Role = "Specalist",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "SGT. Hammer",
                    Title = "Siege Tank Operator",
                    Description = "Sergeant Bama \"the Hammer\" Kowalski has " +
                        "served some of the toughest tours around the Koprulu " +
                        "sector. The roar of her siege tank's shock cannon " +
                        "strikes fear right into the heart of the toughest " +
                        "of warriors... including some of her allies.",
                    Role = "Specalist",
                    Universe = "Starcraft",
                },
                new Hero
                {
                    Name = "Malfurion",
                    Title = "Archdruid",
                    Description = "Malfurion Stormrage is the greatest druid " +
                        "on Azeroth, and a student of the demi-god Cenarius. " +
                        "Communing with nature and Cenarius through the " +
                        "Emerald dream, Malfurion protects the wilds " +
                        "from demonic influences.",
                    Role = "Support",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Tassadar",
                    Title = "Savior Of The Templar",
                    Description = "An Executor without equal, Tassadar has " +
                        "fought tirelessly to purify the Koprulu sector of " +
                        "zerg infestation. Only now, after learning to wield " +
                        "the power of the void, is Tassadar finally ready to " +
                        "face the Overmind and its all-consuming Swarm.",
                    Role = "Support",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Arthas",
                    Title = "The Lich King",
                    Description = "Once the crown prince of Lordaeron, and " +
                        "protégé of Uther the Lightbringer, Arthas was " +
                        "corrupted by the cursed blade Frostmourne in a bid " +
                        "to save his people. Now he rules over the damned as " +
                        "the Lich King and all shall know his wrath.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Uther",
                    Title = "The Lightbringer",
                    Description = "The first paladin and founder of the Order " +
                        "of the Silver Hand, Uther the Lightbringer is a " +
                        "faithful servant of the Light. Dispensing justice " +
                        "with the swing of his hammer, Uther is a bastion of " +
                        "truth and an unflinching symbol of the Alliance.",
                    Role = "Support",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Abathur",
                    Title = "Evolution Master",
                    Description = "Abathur, the Evolution Master of " +
                        "Kerrigan's Swarm, works ceaselessly to improve " +
                        "the zerg from the genetic level up. His hate for " +
                        "chaos and imperfection almost rivals his hatred " +
                        "of pronouns.",
                    Role = "Specalist",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "E.T.C",
                    Title = "Rock God",
                    Description = "The Power of the Horde incarnated by brutal " +
                        "rhythms and blistering guitar riffs into the most " +
                        "elite tauren chieftain to ever headbang across the " +
                        "surface of Azeroth. Don't bother putting on socks. " +
                        "He's just going to rock them off anyways.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Valla",
                    Title = "Demon Hunter",
                    Description = "Valla witnessed the ferocity of hellspawn " +
                        "firsthand as the demons ravaged her village and " +
                        "left her for dead. Now, with no people to call her own," +
                        " her only allegiance is to her cause: to rid Sanctuary" +
                        " of the demonic filth corrupting its lands.",
                    Role = "Assassin",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Tychus",
                    Title = "Notorious Outlaw",
                    Description = "Tychus Findlay is a big man with a big " +
                        "ego and a bigger gun. Fortunately, his loyalty " +
                        "is easily won. Buy him a drink or three and promise" +
                        " him enough credits, and there's no job in the whole" +
                        " universe too dangerous for this outlaw.",
                    Role = "Assassin",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Li Li",
                    Title = "World Wanderer",
                    Description = "Born upon Shen-zin Su, the Wandering Isle," +
                        " Li Li Stormstout led an uneventful life until she " +
                        "began reading her uncle Chen's journals. Soon, " +
                        "nothing would sate her desire for adventure, " +
                        "exploration, and pestering adventurers around Halfhill.",
                    Role = "Support",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Brightwing",
                    Title = "Faerie Dragon",
                    Description = "Like many faerie dragons, Brightwing is " +
                        "happiest darting around the forests of Ashenvale, " +
                        "healing friends, and then grabbing a light snack. " +
                        "By the way, did you know a human head only weighs " +
                        "ten pounds? Talk about light!",
                    Role = "Support",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Murky",
                    Title = "Baby Murloc",
                    Description = "Mrgglglbrlg rmrmgllg mrggggm. Mrrglglgy," +
                        " mgllglgl mgggrrmgl? MRGGGLGLLM! Mrrggllgggllggll " +
                        "mrrglrlg mrrg mrrg mrrrg.",
                    Role = "Specalist",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Zagara",
                    Title = "Broodmother Of The Swarm",
                    Description = "If Kerrigan is the Queen of the Zerg, " +
                        "then Zagara is the mother of the brood. Cunning " +
                        "and tenacious, she commands her minions on the " +
                        "field of battle. Encounter her brood and beware: " +
                        "Mess with her children, and you answer to mama.",
                    Role = "Specalist",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Rehgar",
                    Title = "Shaman Of The Earthen Ring",
                    Description = "Rehgar Earthfury has seen his share of " +
                        "combat, both as a gladiator, and a master of his " +
                        "own team. Now, having put that life aside, he " +
                        "serves as a simple shaman of the Earthen Ring, " +
                        "earning his redemption by healing the lands of Azeroth.",
                    Role = "Support",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Chen",
                    Title = "Legendary Brewmaster",
                    Description = "To be a brewmaster is to be an explorer, " +
                        "a lover of nature, and when the need arises; a " +
                        "powerful fighter. For years Chen Stormstout has " +
                        "wandered the world of Azeroth in search of rare " +
                        "ingredients, stirring stories, and of course, good brew.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Anub'Arak",
                    Title = "Traitor King",
                    Description = "Once a proud nerubian king, Anub'arak dared" +
                        " to stand against the Lich King's invasion, but " +
                        "despite his bravery, he too fell to the unrelenting" +
                        " Scourge. Resurrected into undeath, the Traitor King" +
                        " now serves as a towering weapon of destruction.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Azmodan",
                    Title = "Lord Of Sin",
                    Description = "The Lord of Sin rules over a densely " +
                        "populated land of Hell where both the greatest joys" +
                        " and despair, and the deepest depravities can be " +
                        "experienced. But it is never enough for Azmodan, " +
                        "who has set his eyes on the realm of Sanctuary.",
                    Role = "Specalist",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Jaina",
                    Title = "Archmage",
                    Description = "Once the apprentice of the Archmage " +
                        "Antonidas, Jaina Proudmoore led the survivors of " +
                        "Lordaeron to Kalimdor and founded the city of " +
                        "Theramore. Now, she serves the Alliance as a " +
                        "powerful voice fighting for reason and diplomacy.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Thrall",
                    Title = "Warchief Of The Horde",
                    Description = "As a child, Thrall served the cruel " +
                        "Aedelas Blackmoore as a slave. After gaining his " +
                        "reedom, he guided the liberated orcs to a land of " +
                        "their own and worked to recover their ancient " +
                        "traditions. Now and forever he is the Warchief " +
                        "of the Horde.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "The Lost Vikings",
                    Title = "Triple Trouble",
                    Description = "The Lost Vikings are back! While they " +
                        "briefly considered retirement after defeating the " +
                        "emperor Tomator, there were only so many polar bears" +
                        " they could wrestle before falling into a Nexus " +
                        "portal seemed like a solid life decision.",
                    Role = "Specalist",
                    Universe = "Retro"
                },
                new Hero
                {
                    Name = "Sylvanas",
                    Title = "The Banshee Queen",
                    Description = "Sylvanas Windrunner was not always the " +
                        "Dark Lady of the Forsaken. In another life, " +
                        "she was the Ranger-General of Silvermoon. But " +
                        "that was before the Death Knight Arthas slew her " +
                        "and her people and raised her as the first Banshee.",
                    Role = "Specalist",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Kael'Thas",
                    Title = "The Sun King",
                    Description = "Like all Blood Elves, Prince Kael'thas " +
                        "was transformed by the fall of Quel'Thalas. " +
                        "Desperate to save his people from being consumed " +
                        "by their magical addiction, he joined forces with " +
                        "the Burning Legion and now lords over Tempest Keep.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Johanna",
                    Title = "Crusader Of Zakarum",
                    Description = "There have been many women who have borne" +
                        " the name Johanna in service of the crusade, and " +
                        "each has given her life to purify her faith. Johanna" +
                        " carries on their legacy as she searches the kingdom" +
                        " of Khanduras for the fallen star.",
                    Role = "Warrior",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "The Butcher",
                    Title = "Flesh Carver",
                    Description = "An unrelenting hacking echoed off the " +
                        "walls of the Cathedral and as Prince Aidan made " +
                        "his way through its depths, the sound only grew " +
                        "louder. There were no screams; just that " +
                        "dreadful sound... over and over.",
                    Role = "Assassin",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Leoric",
                    Title = "The Skeleton King",
                    Description = "Madness. Betrayal. Death. These are the" +
                        " legacy of the Black King Leoric's reign. Driven to" +
                        " madness by the spirit of Diablo, Leoric brought " +
                        "untold suffering on his kingdom. Even after his " +
                        "death there was no release for the Skeleton King.",
                    Role = "Warrior",
                    Universe = "Diablo"

                },
                new Hero
                {
                    Name = "Kharazim",
                    Title = "Veradani Monk",
                    Description = "To the monks of Ivgorod, the gods are" +
                        " in all things, and their divine will is proclaimed" +
                        " by the Patriarchs. With unshakable faith, Kharazim" +
                        " carries forth the decrees of the thousand and one" +
                        " gods to the ends of Sanctuary and the realms beyond.",
                    Role = "Support",
                    Universe = "Diablo"

                },
                new Hero
                {
                    Name = "Rexxar",
                    Title = "Champion Of The Horder",
                    Description = "It was a strange twist of fate that led" +
                        " the wandering half-ogre Rexxar to the fledgling " +
                        "city of Orgrimmar. With his aid, Thrall and the Horde" +
                        " were able to secure their homeland and defend it " +
                        "from the invading forces of Lord Admiral " +
                        "Daelin Proudmoore.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Lt. Morales",
                    Title = "Combat Medic",
                    Description = "To good marines, the only thing more " +
                        "important than the rifle in their hand is the " +
                        "medic at their back. As one of the first officers" +
                        " deployed during the United Earth Directorate's " +
                        "invasion, Lt. Rosa Morales is the best of the best.",
                    Role = "Support",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Artanis",
                    Title = "Hierarch Of The Daelaam",
                    Description = "Despite his relative youth, " +
                        "Artanis was named Hierarch of the Daelaam after " +
                        "the fall of Aiur. Driven by the promise of a brighter" +
                        " future, he hopes to reclaim the protoss' " +
                        "fallen home world and rebuild their once " +
                        "glorious civilization. ",
                    Role = "Warrior",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Cho",
                    Title = "Twilight's Hammer Chieftain",
                    Description = "Two personalities share the body of " +
                        "Cho’gall: Gall, cunning master of dark magics " +
                        "and forbidden incantations, and Cho, who’s never" +
                        " met a problem he couldn’t punch really, really " +
                        "hard. When working together, their enemies rue the" +
                        " day they crossed paths with this ogre.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Gall",
                    Title = "Twilight's Hammer Chieftain",
                    Description = "Two personalities share the body of " +
                        "Cho’gall: Gall, cunning master of dark magics " +
                        "and forbidden incantations, and Cho, who’s never" +
                        " met a problem he couldn’t punch really, really " +
                        "hard. When working together, their enemies rue the" +
                        " day they crossed paths with this ogre.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Lunara",
                    Title = "First Daughter Of Cenarius",
                    Description = "While her younger sisters frolicked in " +
                        "idyllic forests, Lunara watched as mortals " +
                        "exploited nature’s splendor. On Azeroth, her " +
                        "father Cenarius forbade her from retaliating. " +
                        "But this is the Nexus, and it’s time for nature" +
                        " to take its revenge.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Greymane",
                    Title = "Lord of The Worgen",
                    Description = "Like most Gilneans, Genn Greymane is " +
                        "afflicted by the worgen curse. Though he feels " +
                        "at fault for his people’s ill fate, he has " +
                        "embraced his inner beast without giving in to its " +
                        "feral nature. Now he leads his pack as both their " +
                        "alpha and their king.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Li-Ming",
                    Title = "Rebellious Wizard",
                    Description = "The derogatory moniker \"wizard\" " +
                        "is often given to mages with rebellious " +
                        "attitudes or an obsession with power. " +
                        "Li-Ming displays a little of both and she's " +
                        "hardly ashamed of it. After all, who are they " +
                        "to judge a wielder of limitless arcane magic?",
                    Role = "Assassin",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Xul",
                    Title = "Cryptic Necromancer",
                    Description = "From the recesses of the eastern jungles" +
                        " comes a man cloaked in mystery. As a member of the" +
                        " secretive Priests of Rathma, or the Necromancers, " +
                        "Xul wields powerful death magic and fights to " +
                        "preserve the delicate balance between order and chaos.",
                    Role = "Specalist",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Dehaka",
                    Title = "Primal Pack Leader",
                    Description = "Cunning and wise, Dehaka is one of the last" +
                        " surviving pack leaders of the forgotten world of " +
                        "Zerus. As with all primal zerg, he is driven by a " +
                        "powerful desire to consume the essence of his foes " +
                        "and evolve into newer and more deadly forms.",
                    Role = "Warrior",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Tracer",
                    Title = "Agent of Overwatch",
                    Description = "Lena Oxton (call sign: \"Tracer\"), " +
                        "is both an adventurer and an irrepressible force " +
                        "for good. With the ability to alter her own time " +
                        "at will, she fights the good fight wherever she " +
                        "goes--even the Nexus. Don't worry, loves. " +
                        "The cavalry's finally here.",
                    Role = "Assassin",
                    Universe = "Overwatch"
                },
                new Hero
                {
                    Name = "Chromie",
                    Title = "Keeper Of Time",
                    Description = "At first glance, Chromie appears to be an " +
                        "ordinary gnome. In truth, she is Chronormu, " +
                        "Bronze Dragon and a master of time. When it comes" +
                        " to temporal manipulation there's no problem she " +
                        "can't solve... with some help from her future " +
                        "self, of course.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Medivh",
                    Title = "The Last Guardian",
                    Description = "Under the demon lord Sargeras's influence, " +
                        "Medivh opened the Dark Portal and unleashed the Horde" +
                        " upon Azeroth. To atone for this sin, he rallied a " +
                        "new generation of heroes to stand against the " +
                        "Burning Legion. Now, he takes his place " +
                        "amongst legends.",
                    Role = "Specalist",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Gul'Dan",
                    Title = "Darkness Incarnate",
                    Description = "Abandoning the ways of shamanism, " +
                        "Gul'dan entered a pact with the demon lord " +
                        "Kil'jaeden and betrayed his people in " +
                        "exchange for limitless power. With the " +
                        "orcish Horde under his master's thrall, " +
                        "both Draenor and Azeroth nearly fell into his grasp.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Auriel",
                    Title = "Archangel Of Hope",
                    Description = "It is through the archangel Auriel that " +
                        "the power of hope flows into the fabric of " +
                        "creation. Her eternal light illuminates even " +
                        "the darkest souls. Seeking harmony in all things, " +
                        "she is a mediator, a counselor, and when the need " +
                        "arises, a fearless warrior.",
                    Role = "Support",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Alarak",
                    Title = "Highlord Of The Tal'Darim",
                    Description = "Not all heroes are born of altruism... " +
                        "some, like Alarak, simply desire vengeance. " +
                        "As the new Highlord of the Tal'darim, Alarak " +
                        "leads his people to a destiny free of the corrupt" +
                        " influence of the fallen xel'naga, Amon.",
                    Role = "Assassin",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Zarya",
                    Title = "Defender Of Russia",
                    Description = "Aleksandra Zaryanova is one of the world's " +
                        "strongest women and was a promising athlete, but all " +
                        "that changed when the Siberian omnium reawakened. " +
                        "As a soldier in the Russian Defense Force, " +
                        "she now proudly uses her strength to " +
                        "protect the ones she loves.",
                    Role = "Warrior",
                    Universe = "Overwatch"
                },
                new Hero
                {
                    Name = "Samuro",
                    Title = "The Blademaster",
                    Description = "Samuro, the last remaining blademaster to " +
                        "wear the banner of the Burning Blade, is on a " +
                        "warrior's pilgrimage in search of vengeance and " +
                        "redemption for his fallen clan. It will be a long " +
                        "journey, but he has sworn an oath to restore " +
                        "his clan's honor.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Varian",
                    Title = "High King Of The Alliane",
                    Description = "Few would have expected that the gladiator " +
                        "known only as Lo'Gosh was in truth the missing ruler " +
                        "of Stormwind, Varian Wrynn. Now the High King of " +
                        "the Alliance, his every action shapes the " +
                        "destiny of Azeroth itself.",
                    Role = "Multiclass",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Ragnaros",
                    Title = "The Firelord",
                    Description = "As the lord of Azeroth’s fire elementals, " +
                        "Ragnaros desires nothing more than to burn the " +
                        "world to ash. Banished to the Firelands eons ago, " +
                        "the Firelord now turns his rage toward the Nexus, " +
                        "intent on incinerating everything and everyone " +
                        "within it.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Zul'Jin",
                    Title = "Warlod Of The Amani",
                    Description = "Before the elves and their Alliance, " +
                        "the forests of Lordaeron belonged to the trolls " +
                        "of the Amani empire. As their warlord, Zul'jin " +
                        "has united the tribes into an army that stands " +
                        "ready to take back what is theirs and to slay " +
                        "the elves who stole it from them.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Valeera",
                    Title = "Shadow Of The Uncrowned",
                    Description = "For a time, the gladiator Valeera Sanguinar" +
                        " served dutifully as one of Varian Wrynn's personal" +
                        " bodyguards. Now, her shadowy skills find her a " +
                        "natural fit within the secretive rogue order, " +
                        "the Uncrowned, in their fight against the Legion.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Lucio",
                    Title = "Freedom Fighting DJ",
                    Description = "From the streets of Rio to the clubs on " +
                        "King's Row, Lúcio's beats bring the party to life, " +
                        "and drive the people to action. Now he's on tour " +
                        "in the Nexus, ready to break it down, and to continue" +
                        " fighting for what's right.",
                    Role = "Support",
                    Universe = "Overwatch"
                },
                new Hero
                {
                    Name = "Probius",
                    Title = "Curious Probe",
                    Description = "Since his activation, Probius has always " +
                        "wanted to prove himself. He may be small, but he " +
                        "made a big difference by warping in a critical " +
                        "pylon during the retaking of Aiur. As the bravest " +
                        "of probes, Probius is eager to fulfill his purpose " +
                        "in the Nexus.",
                    Role = "Specalist",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Cassia",
                    Title = "Amazon Warmatron",
                    Description = "After shattering the Worldstone, the young" +
                        " Amazon Cassia had changed. She had seen hatred, " +
                        "terror, and destruction firsthand. If the Askari " +
                        "were to survive the coming darkness, they needed " +
                        "an army. She would begin their training immediately.",
                    Role = "Assassin",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Genji",
                    Title = "Cybernetic Ninja",
                    Description = "Once the carefree youngest scion of the " +
                        "Shimada clan, Genji was cut down by his own brother" +
                        " for refusing to take part in their illegal ventures." +
                        " Grafted into a cyborg body by Overwatch, Genji " +
                        "walks his own path as one who fights for what's right.",
                    Role = "Assassin",
                    Universe = "Overwatch"
                },
                new Hero
                {
                    Name = "D.VA",
                    Title = "Meka Pilot",
                    Description = "Hana Song, also known as \"D.Va,\" " +
                        "is both a world champion professional gamer " +
                        "and a burgeoning global icon. As a member of " +
                        "South Korea’s elite MEKA unit, she fights to protect " +
                        "her homeland from the colossal omnic threat lurking " +
                        "within the East China Sea.",
                    Role = "Warrior",
                    Universe = "Overwatch"
                },
                new Hero
                {
                    Name = "Malthael",
                    Title = "Aspect Of Death",
                    Description = "Once the Aspect of Wisdom, Malthael " +
                        "abandoned heaven after the Worldstone's " +
                        "destruction. In secret, he had resolved to " +
                        "end the Eternal Conflict by becoming a Reaper of " +
                        "Souls and eliminating everything affected by " +
                        "demonic corruption, including humanity.",
                    Role = "Assassin",
                    Universe = "Diablo"
                },
                new Hero
                {
                    Name = "Stukov",
                    Title = "Infested Admiral",
                    Description = "Alexei Stukov had a hard life, " +
                        "and an even harder death. He has been betrayed, " +
                        "shot into space, resurrected and infested, almost " +
                        "cured, and then experimented upon as the infestation " +
                        "returned. Now, his infestation spreads within " +
                        "the Nexus...",
                    Role = "Support",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Garrosh",
                    Title = "Son Of Hellscream",
                    Description = "As the new warchief of the Horde, " +
                        "Garrosh is a proud and vicious warrior who " +
                        "rules with an iron fist. His hatred for the " +
                        "Alliance burns like wildfire, and he will stop " +
                        "at nothing to destroy them. By his axe, the orcs" +
                        " will reclaim their rightful glory.",
                    Role = "Warrior",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Kel'Thuzad",
                    Title = "Archlich Of Naxxramas",
                    Description = "Kel'Thuzad has faithfully served the Lich " +
                        "King both in life and after death. Reanimated as " +
                        "the Archlich of the Scourge and given domain of " +
                        "the Dread Necropolis, Naxxramas, Kel’Thuzad remains" +
                        " Arthas’s most trusted advisor and master of " +
                        "the cold dark.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Ana",
                    Title = "Vertran Sniper",
                    Description = "As a founding member of Overwatch " +
                        "and one of the world's best snipers, Ana Amari" +
                        " uses her skills to protect the innocent. Though" +
                        " she went MIA after losing her eye, Ana's sense of" +
                        " duty and responsibility has brought her back to" +
                        " the fight.",
                    Role = "Support",
                    Universe = "Overwatch"
                },
                new Hero
                {
                    Name = "Junkrat",
                    Title = "Junker Demolitionist",
                    Description = "The destruction of the Australian omnium" +
                        " left the area an irradiated waste and survivors " +
                        "like Jamison Fawkes were greatly affected by " +
                        "radiation. Now as the explosive-obsessed criminal " +
                        "Junkrat, he is renowned for leaving havoc and bedlam" +
                        " in his wake.",
                    Role = "Specalist",
                    Universe = "Overwatch"
                },
                new Hero
                {
                    Name = "Alexstrasza",
                    Title = "The Life-Binder",
                    Description = "Alexstrasza, the queen of dragons, was " +
                        "empowered by the titans to be the guardian of all " +
                        "life on Azeroth. She has aided mortals time and " +
                        "again, even at great personal cost. Now, she soars " +
                        "across the Nexus, protecting life wherever " +
                        "she finds it.",
                    Role = "Support",
                    Universe = "Warcraft"
                },
                new Hero
                {
                    Name = "Hanzo",
                    Title = "Master Assassin",
                    Description = "Once heir to the Shimada clan's criminal " +
                        "empire, Hanzo abandoned his birthright after he " +
                        "almost killed his younger brother. He now strives " +
                        "to perfect his skills as a warrior, and sees the " +
                        "Nexus and its endless conflict as the ideal " +
                        "training ground.",
                    Role = "Assassin",
                    Universe = "Overwatch"
                },
                new Hero
                {
                    Name = "Blaze",
                    Title = "Veteran Firebat",
                    Description = "Cpl. Miles \"Blaze\" Lewis has always " +
                        "been drawn to the flame, but it wasn't until he " +
                        "joined up with Raynor's Raiders that he put his " +
                        "pyromania to good use. He's seen his fair share " +
                        "of battles since then, and has never failed to " +
                        "bring the heat.",
                    Role = "Warrior",
                    Universe = "Starcraft"
                },
                new Hero
                {
                    Name = "Maiev",
                    Title = "The Warden",
                    Description = "Maiev Shadowsong stood watch over the " +
                        "imprisoned Betrayer for ten thousand years, " +
                        "and hunted him relentlessly after he was " +
                        "released. Some say she's determined; others say " +
                        "she's obsessed. Either way, she will stop at " +
                        "nothing to ensure the security of her world.",
                    Role = "Assassin",
                    Universe = "Warcraft"
                },
                new Hero
                {
                Name = "Fenix",
                Title = "Steward Of The Templar",
                Description = "As one of the greatest heroes in protoss history," +
                    " Fenix's deeds on the battlefield are legendary. After " +
                    "falling to the zerg during the invasion of Aiur, " +
                    "his body was recovered and implanted into a dragoon " +
                    "so he could continue to fight. Not even death can " +
                    "stop Fenix from achieving glory and valor.",
                Universe = "Starcraft",
                Role = "Assassin"
                },
                new Hero
                {
                Name = "Deckard",
                Title = "The Last Horadrim",
                Description = "As an avid scholar, Deckard Cain has dedicated " +
                    "his life to the pursuit of knowledge. He has been an " +
                    "advisor, storyteller, and friend to Sanctuary's " +
                    "greatest heroes, guiding them through peril time " +
                    "and again. When Deckard speaks, it's wise to stay " +
                    "awhile and listen.",
                Universe = "Diablo",
                Role = "Support"
                }
            };
        }
    }
}
 