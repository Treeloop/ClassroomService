using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomService.Data
{
    public class Repository
    {
        public static List<Category> Categories { get; set; }
        public static List<Product> Products { get; set; }

        static Repository()
        {
            if (Products == null) Reset();
        }

        public static int NextProductID
        {
            get
            {
                int id = 1;
                while (true)
                {
                    var product = Products.SingleOrDefault(p => p.Id == id);
                    if (product == null) break;
                    id++;
                }
                return id;
            }
        }

        public static void Reset()
        {
            Categories = new List<Category>() {
                new Category(1, "Beverages", "Soft drinks, coffees, teas, beers, and ales"),
                new Category(2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings"),
                new Category(3, "Confections", "Desserts, candies, and sweet breads"),
                new Category(4, "Dairy Products", "Cheeses"),
                new Category(5, "Grains/Cereals", "Breads, crackers, pasta, and cereal"),
                new Category(6, "Meat/Poultry", "Prepared meats"),
                new Category(7, "Produce", "Dried fruit and bean curd"),
                new Category(8, "Seafood", "Seaweed and fish")
            };

            Products = new List<Product>() {
                new Product(1,"Chai",18.00,"10 boxes x 20 bags",false),
                new Product(2,"Chang",19.00,"24 - 12 oz bottles",false),
                new Product(3,"Aniseed Syrup",10.00,"12 - 550 ml bottles",false),
                new Product(4,"Chef Anton's Cajun Seasoning",22.00,"48 - 6 oz jars",false),
                new Product(5,"Chef Anton's Gumbo Mix",21.35,"36 boxes",true),
                new Product(6,"Grandma's Boysenberry Spread",25.00,"12 - 8 oz jars",false),
                new Product(7,"Uncle Bob's Organic Dried Pears",30.00,"12 - 1 lb pkgs.",false),
                new Product(8,"Northwoods Cranberry Sauce",40.00,"12 - 12 oz jars",false),
                new Product(9,"Mishi Kobe Niku",97.00,"18 - 500 g pkgs.",true),
                new Product(10,"Ikura",31.00,"12 - 200 ml jars",false),
                new Product(11,"Queso Cabrales",21.00,"1 kg pkg.",false),
                new Product(12,"Queso Manchego La Pastora",38.00,"10 - 500 g pkgs.",false),
                new Product(13,"Konbu",6.00,"2 kg box",false),
                new Product(14,"Tofu",23.25,"40 - 100 g pkgs.",false),
                new Product(15,"Genen Shouyu",15.50,"24 - 250 ml bottles",false),
                new Product(16,"Pavlova",17.45,"32 - 500 g boxes",false),
                new Product(17,"Alice Mutton",39.00,"20 - 1 kg tins",true),
                new Product(18,"Carnarvon Tigers",62.50,"16 kg pkg.",false),
                new Product(19,"Teatime Chocolate Biscuits",9.20,"10 boxes x 12 pieces",false),
                new Product(20,"Sir Rodney's Marmalade",81.00,"30 gift boxes",false),
                new Product(21,"Sir Rodney's Scones",10.00,"24 pkgs. x 4 pieces",false),
                new Product(22,"Gustaf's Knäckebröd",21.00,"24 - 500 g pkgs.",false),
                new Product(23,"Tunnbröd",9.00,"12 - 250 g pkgs.",false),
                new Product(24,"Guaraná Fantástica",4.50,"12 - 355 ml cans",true),
                new Product(25,"NuNuCa Nuß-Nougat-Creme",14.00,"20 - 450 g glasses",false),
                new Product(26,"Gumbär Gummibärchen",31.23,"100 - 250 g bags",false),
                new Product(27,"Schoggi Schokolade",43.90,"100 - 100 g pieces",false),
                new Product(28,"Rössle Sauerkraut",45.60,"25 - 825 g cans",true),
                new Product(29,"Thüringer Rostbratwurst",123.79,"50 bags x 30 sausgs.",true),
                new Product(30,"Nord-Ost Matjeshering",25.89,"10 - 200 g glasses",false),
                new Product(31,"Gorgonzola Telino",12.50,"12 - 100 g pkgs",false),
                new Product(32,"Mascarpone Fabioli",32.00,"24 - 200 g pkgs.",false),
                new Product(33,"Geitost",2.50,"500 g",false),
                new Product(34,"Sasquatch Ale",14.00,"24 - 12 oz bottles",false),
                new Product(35,"Steeleye Stout",18.00,"24 - 12 oz bottles",false),
                new Product(36,"Inlagd Sill",19.00,"24 - 250 g  jars",false),
                new Product(37,"Gravad lax",26.00,"12 - 500 g pkgs.",false),
                new Product(38,"Côte de Blaye",263.50,"12 - 75 cl bottles",false),
                new Product(39,"Chartreuse verte",18.00,"750 cc per bottle",false),
                new Product(40,"Boston Crab Meat",18.40,"24 - 4 oz tins",false),
                new Product(41,"Jack's New England Clam Chowder",9.65,"12 - 12 oz cans",false),
                new Product(42,"Singaporean Hokkien Fried Mee",14.00,"32 - 1 kg pkgs.",true),
                new Product(43,"Ipoh Coffee",46.00,"16 - 500 g tins",false),
                new Product(44,"Gula Malacca",19.45,"20 - 2 kg bags",false),
                new Product(45,"Rogede sild",9.50,"1k pkg.",false),
                new Product(46,"Spegesild",12.00,"4 - 450 g glasses",false),
                new Product(47,"Zaanse koeken",9.50,"10 - 4 oz boxes",false),
                new Product(48,"Chocolade",12.75,"10 pkgs.",false),
                new Product(49,"Maxilaku",20.00,"24 - 50 g pkgs.",false),
                new Product(50,"Valkoinen suklaa",16.25,"12 - 100 g bars",false),
                new Product(51,"Manjimup Dried Apples",53.00,"50 - 300 g pkgs.",false),
                new Product(52,"Filo Mix",7.00,"16 - 2 kg boxes",false),
                new Product(53,"Perth Pasties",32.80,"48 pieces",true),
                new Product(54,"Tourtière",7.45,"16 pies",false),
                new Product(55,"Pâté chinois",24.00,"24 boxes x 2 pies",false),
                new Product(56,"Gnocchi di nonna Alice",38.00,"24 - 250 g pkgs.",false),
                new Product(57,"Ravioli Angelo",19.50,"24 - 250 g pkgs.",false),
                new Product(58,"Escargots de Bourgogne",13.25,"24 pieces",false),
                new Product(59,"Raclette Courdavault",55.00,"5 kg pkg.",false),
                new Product(60,"Camembert Pierrot",34.00,"15 - 300 g rounds",false),
                new Product(61,"Sirop d'érable",28.50,"24 - 500 ml bottles",false),
                new Product(62,"Tarte au sucre",49.30,"48 pies",false),
                new Product(63,"Vegie-spread",43.90,"15 - 625 g jars",false),
                new Product(64,"Wimmers gute Semmelknödel",33.25,"20 bags x 4 pieces",false),
                new Product(65,"Louisiana Fiery Hot Pepper Sauce",21.05,"32 - 8 oz bottles",false),
                new Product(66,"Louisiana Hot Spiced Okra",17.00,"24 - 8 oz jars",false),
                new Product(67,"Laughing Lumberjack Lager",14.00,"24 - 12 oz bottles",false),
                new Product(68,"Scottish Longbreads",12.50,"10 boxes x 8 pieces",false),
                new Product(69,"Gudbrandsdalsost",36.00,"10 kg pkg.",false),
                new Product(70,"Outback Lager",15.00,"24 - 355 ml bottles",false),
                new Product(71,"Flotemysost",21.50,"10 - 500 g pkgs.",false),
                new Product(72,"Mozzarella di Giovanni",34.80,"24 - 200 g pkgs.",false),
                new Product(73,"Röd Kaviar",15.00,"24 - 150 g jars",false),
                new Product(74,"Longlife Tofu",10.00,"5 kg pkg.",false),
                new Product(75,"Rhönbräu Klosterbier",7.75,"24 - 0.5 l bottles",false),
                new Product(76,"Lakkalikööri",18.00,"500 ml",false),
                new Product(77,"Original Frankfurter grüne Soße",13.00,"12 boxes",false),
                new Product(78,"Stroopwafels",9.75,"24 pieces",false)
            };
        }
    }
}
