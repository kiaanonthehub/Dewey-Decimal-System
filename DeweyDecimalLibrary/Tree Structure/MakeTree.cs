using DeweyDecimalLibrary.Models;

namespace DeweyDecimalLibrary.Tree_Structure
{
    public class MakeTree
    {
        public static Tree<DeweyPair> GrowATree()
        {
            // instantiate class obj
            DeweyPair basePair = new DeweyPair { Number = "---", Description = "ROOT" };
            Tree<DeweyPair> lstPair = new Tree<DeweyPair>(basePair);

            // declare list
            List<DeweyPair> lstLevel1 = new List<DeweyPair>();

            // initialise list
            #region level 1 options
            lstLevel1.Add(new DeweyPair { Number = "100", Description = "Philosophy and Psychology" });
            lstLevel1.Add(new DeweyPair { Number = "200", Description = "Religion" });
            lstLevel1.Add(new DeweyPair { Number = "300", Description = "Social Sciences" });
            lstLevel1.Add(new DeweyPair { Number = "400", Description = "Language" });
            lstLevel1.Add(new DeweyPair { Number = "500", Description = "Natural Sciences and Mathematics" });
            lstLevel1.Add(new DeweyPair { Number = "600", Description = "Applied Sciences" });
            lstLevel1.Add(new DeweyPair { Number = "700", Description = "The Arts" });
            lstLevel1.Add(new DeweyPair { Number = "800", Description = "Literature" });

            // add list to object base pair
            lstPair.AddChildren(lstLevel1, basePair);
            #endregion

            #region level 2 options

            // instantiate list objects
            List<DeweyPair> l100 = Philosophy();
            List<DeweyPair> l200 = Religion();
            List<DeweyPair> l300 = SocialScience();
            List<DeweyPair> l400 = Language();
            List<DeweyPair> l500 = NaturalSciences();
            List<DeweyPair> l600 = AppliedSciences();
            List<DeweyPair> l700 = Arts();
            List<DeweyPair> l800 = Literature();

            // populate list
            lstPair.AddChildren(l100, lstLevel1[0]);
            lstPair.AddChildren(l200, lstLevel1[1]);
            lstPair.AddChildren(l300, lstLevel1[2]);
            lstPair.AddChildren(l400, lstLevel1[3]);
            lstPair.AddChildren(l500, lstLevel1[4]);
            lstPair.AddChildren(l600, lstLevel1[5]);
            lstPair.AddChildren(l700, lstLevel1[6]);
            lstPair.AddChildren(l800, lstLevel1[7]);
            #endregion

            #region level 3 options

            // add childrent to list
            lstPair.AddChildren(Metaphysics(), l100[0]);
            lstPair.AddChildren(ParanormalPhenomena(), l100[1]);
            lstPair.AddChildren(Logic(), l100[2]);
            lstPair.AddChildren(Ethics(), l100[3]);


            // pair up
            lstPair.AddChildren(NaturalTheology(), l200[0]);

            // pair up
            lstPair.AddChildren(Economics(), l300[0]);

            // pair up
            lstPair.AddChildren(Law(), l300[1]);
            lstPair.AddChildren(Linguistics(), l400[0]);

            // pair up
            lstPair.AddChildren(Mathematics(), l500[0]);
            lstPair.AddChildren(Physics(), l500[1]);

            // pair up
            lstPair.AddChildren(Medicine(), l600[0]);
            lstPair.AddChildren(Engineering(), l600[1]);
            lstPair.AddChildren(Agriculture(), l600[2]);

            // pair up
            lstPair.AddChildren(CivicLandscapes(), l700[0]);
            lstPair.AddChildren(Architecture(), l700[1]);
            lstPair.AddChildren(Sculpture(), l700[2]);
            lstPair.AddChildren(Painting(), l700[3]);

            // pair up
            lstPair.AddChildren(AmericanLiterature(), l800[0]);
            #endregion

            // transverse the list
            lstPair.OrderTraversal(lstPair.Root);

            return lstPair;
        }

        // lists of call number categories and level childern

        #region 100s
        public static List<DeweyPair> Philosophy()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "110", Description = "Metaphysics" });
            lstPairs.Add(new DeweyPair { Number = "130", Description = "Paranormal Phenomena" });
            lstPairs.Add(new DeweyPair { Number = "160", Description = "Logic" });
            lstPairs.Add(new DeweyPair { Number = "170", Description = "Ethics" });

            return lstPairs;
        }

        #region 100s CHILDEREN
        public static List<DeweyPair> Metaphysics()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            lstPairs.Add(new DeweyPair { Number = "111", Description = "Ontology" });
            lstPairs.Add(new DeweyPair { Number = "113", Description = "Cosmology" });
            lstPairs.Add(new DeweyPair { Number = "114", Description = "Space" });
            lstPairs.Add(new DeweyPair { Number = "115", Description = "Time" });

            return lstPairs;
        }

        public static List<DeweyPair> ParanormalPhenomena()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "131", Description = "Occult methods for achieving well being" });
            lstPairs.Add(new DeweyPair { Number = "135", Description = "Dreams and Mysteries" });
            lstPairs.Add(new DeweyPair { Number = "137", Description = "Divinatory Graphology" });
            lstPairs.Add(new DeweyPair { Number = "138", Description = "Physiognomy" });

            return lstPairs;
        }

        public static List<DeweyPair> Logic()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "161", Description = "Induction" });
            lstPairs.Add(new DeweyPair { Number = "162", Description = "Deduction" });
            lstPairs.Add(new DeweyPair { Number = "167", Description = "Hypotheses" });
            lstPairs.Add(new DeweyPair { Number = "169", Description = "Analogy" });

            return lstPairs;
        }

        public static List<DeweyPair> Ethics()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "171", Description = "Systems and Doctrines" });
            lstPairs.Add(new DeweyPair { Number = "172", Description = "Political Ethics" });
            lstPairs.Add(new DeweyPair { Number = "173", Description = "Ethics of Family Relationships" });
            lstPairs.Add(new DeweyPair { Number = "174", Description = "Economic and Professional Ethics" });

            return lstPairs;
        }
        #endregion

        #endregion

        #region 200s
        public static List<DeweyPair> Religion()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "210", Description = "Natural Theology" });
            return lstPairs;
        }

        #region 200s CHILDREN
        public static List<DeweyPair> NaturalTheology()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "211", Description = "Concepts of God" });
            lstPairs.Add(new DeweyPair { Number = "212", Description = "Existence, Attributes of God" });
            lstPairs.Add(new DeweyPair { Number = "213", Description = "Creation" });
            lstPairs.Add(new DeweyPair { Number = "216", Description = "Good and Evil" });

            return lstPairs;
        }
        #endregion

        #endregion

        #region 300s
        public static List<DeweyPair> SocialScience()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "330", Description = "Economics" });
            lstPairs.Add(new DeweyPair { Number = "340", Description = "Law" });

            return lstPairs;
        }

        #region 300s CHILDREN
        public static List<DeweyPair> Economics()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "331", Description = "Labor Economics" });
            lstPairs.Add(new DeweyPair { Number = "332", Description = "Financial Economics" });
            lstPairs.Add(new DeweyPair { Number = "333", Description = "Land Economics" });
            lstPairs.Add(new DeweyPair { Number = "334", Description = "Cooperatives" });

            return lstPairs;
        }

        public static List<DeweyPair> Law()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "341", Description = "International Law" });
            lstPairs.Add(new DeweyPair { Number = "342", Description = "Constitutional and Administrative Law" });
            lstPairs.Add(new DeweyPair { Number = "345", Description = "Criminal Law" });
            lstPairs.Add(new DeweyPair { Number = "344", Description = "Private Law" });

            return lstPairs;
        }

        #endregion


        #endregion

        #region 400s
        public static List<DeweyPair> Language()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "410", Description = "Linguistics" });

            return lstPairs;
        }

        #region 400s CHILDREN
        public static List<DeweyPair> Linguistics()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "411", Description = "Writing Systems" });
            lstPairs.Add(new DeweyPair { Number = "412", Description = "Etymology" });
            lstPairs.Add(new DeweyPair { Number = "413", Description = "Dictionaries" });
            lstPairs.Add(new DeweyPair { Number = "414", Description = "Phonology" });

            return lstPairs;
        }
        #endregion

        #endregion

        #region 500s
        public static List<DeweyPair> NaturalSciences()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "510", Description = "Mathematics" });
            lstPairs.Add(new DeweyPair { Number = "530", Description = "Physics" });

            return lstPairs;
        }

        #region 500s CHILDREN
        public static List<DeweyPair> Mathematics()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "511", Description = "General Principles" });
            lstPairs.Add(new DeweyPair { Number = "512", Description = "Algebra and Number Theory" });
            lstPairs.Add(new DeweyPair { Number = "513", Description = "Arithmetic" });
            lstPairs.Add(new DeweyPair { Number = "515", Description = "Analysis" });
            lstPairs.Add(new DeweyPair { Number = "516", Description = "Geometry" });

            return lstPairs;
        }

        public static List<DeweyPair> Physics()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "532", Description = "Fluid Mechanics" });
            lstPairs.Add(new DeweyPair { Number = "533", Description = "Gas Mechanics" });
            lstPairs.Add(new DeweyPair { Number = "536", Description = "Heat" });
            lstPairs.Add(new DeweyPair { Number = "537", Description = "Electricty and Electronics" });
            lstPairs.Add(new DeweyPair { Number = "538", Description = "Magnetism" });

            return lstPairs;
        }
        #endregion

        #endregion

        #region 600s
        public static List<DeweyPair> AppliedSciences()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "610", Description = "Medicine" });
            lstPairs.Add(new DeweyPair { Number = "620", Description = "Engineering and Allied Operations" });
            lstPairs.Add(new DeweyPair { Number = "630", Description = "Agriculture" });

            return lstPairs;
        }

        #region 600s CHILDREN
        public static List<DeweyPair> Medicine()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "611", Description = "Human Anatomy" });
            lstPairs.Add(new DeweyPair { Number = "612", Description = "Human Physiology" });
            lstPairs.Add(new DeweyPair { Number = "613", Description = "Promotion of Health" });
            lstPairs.Add(new DeweyPair { Number = "616", Description = "Disesases" });

            return lstPairs;
        }

        public static List<DeweyPair> Engineering()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "621", Description = "Applied Physics" });
            lstPairs.Add(new DeweyPair { Number = "622", Description = "Mining and Related Operations" });
            lstPairs.Add(new DeweyPair { Number = "624", Description = "Civil Engineering" });
            lstPairs.Add(new DeweyPair { Number = "627", Description = "Hydraulic Engineering" });

            return lstPairs;
        }

        public static List<DeweyPair> Agriculture()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "631", Description = "Techniques, Equipment, Materials" });
            lstPairs.Add(new DeweyPair { Number = "632", Description = "Plant Injuries, Diseases, Pests" });
            lstPairs.Add(new DeweyPair { Number = "633", Description = "Field and Plantation crops" });
            lstPairs.Add(new DeweyPair { Number = "636", Description = "Animal Husbandry" });

            return lstPairs;
        }

        #endregion

        #endregion

        #region 700s
        public static List<DeweyPair> Arts()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "710", Description = "Civic and Landscape Art" });
            lstPairs.Add(new DeweyPair { Number = "720", Description = "Architecture" });
            lstPairs.Add(new DeweyPair { Number = "730", Description = "Plastic Arts, Sculpture" });
            lstPairs.Add(new DeweyPair { Number = "750", Description = "Painting and Paintings" });

            return lstPairs;
        }

        #region 700s CHILDREN
        public static List<DeweyPair> CivicLandscapes()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "711", Description = "Area Planning (Civic Art)" });
            lstPairs.Add(new DeweyPair { Number = "712", Description = "Landscape Architecture" });
            lstPairs.Add(new DeweyPair { Number = "714", Description = "Water Features" });
            lstPairs.Add(new DeweyPair { Number = "717", Description = "Structures" });

            return lstPairs;
        }

        public static List<DeweyPair> Architecture()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "721", Description = "Architectural Structure" });
            lstPairs.Add(new DeweyPair { Number = "725", Description = "Public Structures" });
            lstPairs.Add(new DeweyPair { Number = "726", Description = "Religious Buildings" });
            lstPairs.Add(new DeweyPair { Number = "727", Description = "Buildings for Education and Research" });

            return lstPairs;
        }

        public static List<DeweyPair> Sculpture()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "732", Description = "Sculpture to ca. 500" });
            lstPairs.Add(new DeweyPair { Number = "735", Description = "Sculpture from 1400" });
            lstPairs.Add(new DeweyPair { Number = "738", Description = "Ceramic Arts" });
            lstPairs.Add(new DeweyPair { Number = "739", Description = "Art Metalwork" });

            return lstPairs;
        }

        public static List<DeweyPair> Painting()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "751", Description = "Painting Techniques, Eqipment, Forms" });
            lstPairs.Add(new DeweyPair { Number = "752", Description = "Color" });
            lstPairs.Add(new DeweyPair { Number = "754", Description = "Genre Paintings" });
            lstPairs.Add(new DeweyPair { Number = "757", Description = "Human Figures" });

            return lstPairs;
        }
        #endregion
        #endregion

        #region 800s
        public static List<DeweyPair> Literature()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "810", Description = "American Literature in English" });

            return lstPairs;
        }

        #region 800s CHILDREN
        public static List<DeweyPair> AmericanLiterature()
        {
            // instantiate list object
            List<DeweyPair> lstPairs = new List<DeweyPair>();

            // populate the list
            lstPairs.Add(new DeweyPair { Number = "811", Description = "Poetry" });
            lstPairs.Add(new DeweyPair { Number = "812", Description = "Drama" });
            lstPairs.Add(new DeweyPair { Number = "813", Description = "Fiction" });
            lstPairs.Add(new DeweyPair { Number = "814", Description = "Essays" });
            lstPairs.Add(new DeweyPair { Number = "815", Description = "Speeches" });
            lstPairs.Add(new DeweyPair { Number = "816", Description = "Letters" });
            lstPairs.Add(new DeweyPair { Number = "817", Description = "Satire and Humour" });

            return lstPairs;
        }
        #endregion


        #endregion
    }
}
