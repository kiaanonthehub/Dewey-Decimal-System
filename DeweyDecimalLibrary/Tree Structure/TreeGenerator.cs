using DeweyDecimalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Tree_Structure
{
    public class TreeGenerator
    {
        public static Tree<DeweyPair> PlantTree()
        {
            DeweyPair basePair = new DeweyPair { Number = "---", Description = "ROOT" };

            Tree<DeweyPair> dps = new Tree<DeweyPair>(basePair);

            List<DeweyPair> l1 = new List<DeweyPair>();

            #region LEVEL 1
            l1.Add(new DeweyPair { Number = "100", Description = "Philosophy and Psychology" });
            l1.Add(new DeweyPair { Number = "200", Description = "Religion" });
            l1.Add(new DeweyPair { Number = "300", Description = "Social Sciences" });
            l1.Add(new DeweyPair { Number = "400", Description = "Language" });
            l1.Add(new DeweyPair { Number = "500", Description = "Natural Sciences and Mathematics" });
            l1.Add(new DeweyPair { Number = "600", Description = "Applied Sciences" });
            l1.Add(new DeweyPair { Number = "700", Description = "The Arts" });
            l1.Add(new DeweyPair { Number = "800", Description = "Literature" });
            //l1.Add(new DeweyPair { Number = "900", Description = "Geography and History" });

            dps.AddChildren(l1, basePair);
            #endregion

            #region LEVEL 2
            List<DeweyPair> l100 = Philosophy();
            List<DeweyPair> l200 = Religion();
            List<DeweyPair> l300 = SocialScience();
            List<DeweyPair> l400 = Language();
            List<DeweyPair> l500 = NaturalSciences();
            List<DeweyPair> l600 = AppliedSciences();
            List<DeweyPair> l700 = Arts();
            List<DeweyPair> l800 = Literature();

            dps.AddChildren(l100, l1[0]);
            dps.AddChildren(l200, l1[1]);
            dps.AddChildren(l300, l1[2]);
            dps.AddChildren(l400, l1[3]);
            dps.AddChildren(l500, l1[4]);
            dps.AddChildren(l600, l1[5]);
            dps.AddChildren(l700, l1[6]);
            dps.AddChildren(l800, l1[7]);
            #endregion


            #region LEVEL 3
            dps.AddChildren(Metaphysics(), l100[0]);
            dps.AddChildren(ParanormalPhenomena(), l100[1]);
            dps.AddChildren(Logic(), l100[2]);
            dps.AddChildren(Ethics(), l100[3]);

            dps.AddChildren(NaturalTheology(), l200[0]);

            dps.AddChildren(Economics(), l300[0]);
            dps.AddChildren(Law(), l300[1]);

            dps.AddChildren(Linguistics(), l400[0]);

            dps.AddChildren(Mathematics(), l500[0]);
            dps.AddChildren(Physics(), l500[1]);

            dps.AddChildren(Medicine(), l600[0]);
            dps.AddChildren(Engineering(), l600[1]);
            dps.AddChildren(Agriculture(), l600[2]);

            dps.AddChildren(CivicLandscapes(), l700[0]);
            dps.AddChildren(Architecture(), l700[1]);
            dps.AddChildren(Sculpture(), l700[2]);
            dps.AddChildren(Painting(), l700[3]);

            dps.AddChildren(AmericanLiterature(), l800[0]);
            #endregion

            dps.LevelOrderTraversal(dps.Root);


           // Console.WriteLine($"ORIGINAL TREE SIZE {dps.Size}");

            return dps;
        }

        // lists of call number categories and level childern

        #region 100s
        public static List<DeweyPair> Philosophy()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "110", Description = "Metaphysics" });
            DeweyPairs.Add(new DeweyPair { Number = "130", Description = "Paranormal Phenomena" });
            DeweyPairs.Add(new DeweyPair { Number = "160", Description = "Logic" });
            DeweyPairs.Add(new DeweyPair { Number = "170", Description = "Ethics" });

            return DeweyPairs;
        }

        #region 100s CHILDEREN
        public static List<DeweyPair> Metaphysics()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "111", Description = "Ontology" });
            DeweyPairs.Add(new DeweyPair { Number = "113", Description = "Cosmology" });
            DeweyPairs.Add(new DeweyPair { Number = "114", Description = "Space" });
            DeweyPairs.Add(new DeweyPair { Number = "115", Description = "Time" });

            return DeweyPairs;
        }

        public static List<DeweyPair> ParanormalPhenomena()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "131", Description = "Occult methods for achieving well being" });
            DeweyPairs.Add(new DeweyPair { Number = "135", Description = "Dreams and Mysteries" });
            DeweyPairs.Add(new DeweyPair { Number = "137", Description = "Divinatory Graphology" });
            DeweyPairs.Add(new DeweyPair { Number = "138", Description = "Physiognomy" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Logic()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "161", Description = "Induction" });
            DeweyPairs.Add(new DeweyPair { Number = "162", Description = "Deduction" });
            DeweyPairs.Add(new DeweyPair { Number = "167", Description = "Hypotheses" });
            DeweyPairs.Add(new DeweyPair { Number = "169", Description = "Analogy" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Ethics()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "171", Description = "Systems and Doctrines" });
            DeweyPairs.Add(new DeweyPair { Number = "172", Description = "Political Ethics" });
            DeweyPairs.Add(new DeweyPair { Number = "173", Description = "Ethics of Family Relationships" });
            DeweyPairs.Add(new DeweyPair { Number = "174", Description = "Economic and Professional Ethics" });

            return DeweyPairs;
        }
        #endregion

        #endregion

        #region 200s
        public static List<DeweyPair> Religion()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "210", Description = "Natural Theology" });
            //DeweyPairs.Add(new DeweyPair { Number = "220", Description = "Bible" });
            //DeweyPairs.Add(new DeweyPair { Number = "230", Description = "Christian Theology" });
            //DeweyPairs.Add(new DeweyPair { Number = "260", Description = "Christian Social Theology" });

            return DeweyPairs;
        }

        #region 200s CHILDREN
        public static List<DeweyPair> NaturalTheology()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "211", Description = "Concepts of God" });
            DeweyPairs.Add(new DeweyPair { Number = "212", Description = "Existence, Attributes of God" });
            DeweyPairs.Add(new DeweyPair { Number = "213", Description = "Creation" });
            DeweyPairs.Add(new DeweyPair { Number = "216", Description = "Good and Evil" });

            return DeweyPairs;
        }
        #endregion

        #endregion

        #region 300s
        public static List<DeweyPair> SocialScience()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "330", Description = "Economics" });
            DeweyPairs.Add(new DeweyPair { Number = "340", Description = "Law" });

            return DeweyPairs;
        }

        #region 300s CHILDREN
        public static List<DeweyPair> Economics()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "331", Description = "Labor Economics" });
            DeweyPairs.Add(new DeweyPair { Number = "332", Description = "Financial Economics" });
            DeweyPairs.Add(new DeweyPair { Number = "333", Description = "Land Economics" });
            DeweyPairs.Add(new DeweyPair { Number = "334", Description = "Cooperatives" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Law()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "341", Description = "International Law" });
            DeweyPairs.Add(new DeweyPair { Number = "342", Description = "Constitutional and Administrative Law" });
            DeweyPairs.Add(new DeweyPair { Number = "345", Description = "Criminal Law" });
            DeweyPairs.Add(new DeweyPair { Number = "344", Description = "Private Law" });

            return DeweyPairs;
        }

        #endregion


        #endregion

        #region 400s
        public static List<DeweyPair> Language()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "410", Description = "Linguistics" });

            return DeweyPairs;
        }

        #region 400s CHILDREN
        public static List<DeweyPair> Linguistics()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "411", Description = "Writing Systems" });
            DeweyPairs.Add(new DeweyPair { Number = "412", Description = "Etymology" });
            DeweyPairs.Add(new DeweyPair { Number = "413", Description = "Dictionaries" });
            DeweyPairs.Add(new DeweyPair { Number = "414", Description = "Phonology" });

            return DeweyPairs;
        }
        #endregion

        #endregion

        #region 500s
        public static List<DeweyPair> NaturalSciences()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "510", Description = "Mathematics" });
            DeweyPairs.Add(new DeweyPair { Number = "530", Description = "Physics" });

            return DeweyPairs;
        }

        #region 500s CHILDREN
        public static List<DeweyPair> Mathematics()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "511", Description = "General Principles" });
            DeweyPairs.Add(new DeweyPair { Number = "512", Description = "Algebra and Number Theory" });
            DeweyPairs.Add(new DeweyPair { Number = "513", Description = "Arithmetic" });
            DeweyPairs.Add(new DeweyPair { Number = "515", Description = "Analysis" });
            DeweyPairs.Add(new DeweyPair { Number = "516", Description = "Geometry" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Physics()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "532", Description = "Fluid Mechanics" });
            DeweyPairs.Add(new DeweyPair { Number = "533", Description = "Gas Mechanics" });
            DeweyPairs.Add(new DeweyPair { Number = "536", Description = "Heat" });
            DeweyPairs.Add(new DeweyPair { Number = "537", Description = "Electricty and Electronics" });
            DeweyPairs.Add(new DeweyPair { Number = "538", Description = "Magnetism" });

            return DeweyPairs;
        }
        #endregion

        #endregion

        #region 600s
        public static List<DeweyPair> AppliedSciences()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "610", Description = "Medicine" });
            DeweyPairs.Add(new DeweyPair { Number = "620", Description = "Engineering and Allied Operations" });
            DeweyPairs.Add(new DeweyPair { Number = "630", Description = "Agriculture" });

            return DeweyPairs;
        }

        #region 600s CHILDREN
        public static List<DeweyPair> Medicine()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "611", Description = "Human Anatomy" });
            DeweyPairs.Add(new DeweyPair { Number = "612", Description = "Human Physiology" });
            DeweyPairs.Add(new DeweyPair { Number = "613", Description = "Promotion of Health" });
            DeweyPairs.Add(new DeweyPair { Number = "616", Description = "Disesases" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Engineering()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "621", Description = "Applied Physics" });
            DeweyPairs.Add(new DeweyPair { Number = "622", Description = "Mining and Related Operations" });
            DeweyPairs.Add(new DeweyPair { Number = "624", Description = "Civil Engineering" });
            DeweyPairs.Add(new DeweyPair { Number = "627", Description = "Hydraulic Engineering" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Agriculture()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "631", Description = "Techniques, Equipment, Materials" });
            DeweyPairs.Add(new DeweyPair { Number = "632", Description = "Plant Injuries, Diseases, Pests" });
            DeweyPairs.Add(new DeweyPair { Number = "633", Description = "Field and Plantation crops" });
            DeweyPairs.Add(new DeweyPair { Number = "636", Description = "Animal Husbandry" });

            return DeweyPairs;
        }

        #endregion

        #endregion

        #region 700s
        public static List<DeweyPair> Arts()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "710", Description = "Civic and Landscape Art" });
            DeweyPairs.Add(new DeweyPair { Number = "720", Description = "Architecture" });
            DeweyPairs.Add(new DeweyPair { Number = "730", Description = "Plastic Arts, Sculpture" });
            DeweyPairs.Add(new DeweyPair { Number = "750", Description = "Painting and Paintings" });

            return DeweyPairs;
        }

        #region 700s CHILDREN
        public static List<DeweyPair> CivicLandscapes()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "711", Description = "Area Planning (Civic Art)" });
            DeweyPairs.Add(new DeweyPair { Number = "712", Description = "Landscape Architecture" });
            DeweyPairs.Add(new DeweyPair { Number = "714", Description = "Water Features" });
            DeweyPairs.Add(new DeweyPair { Number = "717", Description = "Structures" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Architecture()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "721", Description = "Architectural Structure" });
            DeweyPairs.Add(new DeweyPair { Number = "725", Description = "Public Structures" });
            DeweyPairs.Add(new DeweyPair { Number = "726", Description = "Religious Buildings" });
            DeweyPairs.Add(new DeweyPair { Number = "727", Description = "Buildings for Education and Research" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Sculpture()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "732", Description = "Sculpture to ca. 500" });
            DeweyPairs.Add(new DeweyPair { Number = "735", Description = "Sculpture from 1400" });
            DeweyPairs.Add(new DeweyPair { Number = "738", Description = "Ceramic Arts" });
            DeweyPairs.Add(new DeweyPair { Number = "739", Description = "Art Metalwork" });

            return DeweyPairs;
        }

        public static List<DeweyPair> Painting()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "751", Description = "Painting Techniques, Eqipment, Forms" });
            DeweyPairs.Add(new DeweyPair { Number = "752", Description = "Color" });
            DeweyPairs.Add(new DeweyPair { Number = "754", Description = "Genre Paintings" });
            DeweyPairs.Add(new DeweyPair { Number = "757", Description = "Human Figures" });

            return DeweyPairs;
        }
        #endregion
        #endregion

        #region 800s
        public static List<DeweyPair> Literature()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "810", Description = "American Literature in English" });

            return DeweyPairs;
        }

        #region 800s CHILDREN
        public static List<DeweyPair> AmericanLiterature()
        {
            List<DeweyPair> DeweyPairs = new List<DeweyPair>();

            DeweyPairs.Add(new DeweyPair { Number = "811", Description = "Poetry" });
            DeweyPairs.Add(new DeweyPair { Number = "812", Description = "Drama" });
            DeweyPairs.Add(new DeweyPair { Number = "813", Description = "Fiction" });
            DeweyPairs.Add(new DeweyPair { Number = "814", Description = "Essays" });
            DeweyPairs.Add(new DeweyPair { Number = "815", Description = "Speeches" });
            DeweyPairs.Add(new DeweyPair { Number = "816", Description = "Letters" });
            DeweyPairs.Add(new DeweyPair { Number = "817", Description = "Satire and Humour" });

            return DeweyPairs;
        }
        #endregion


        #endregion
    }
}
