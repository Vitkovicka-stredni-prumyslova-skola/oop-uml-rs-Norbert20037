namespace UMLRS{
    class Program {
        public  static void Main (string [] args){

            Autor nemcova = new Autor("Němcová");

            Clanek clanek1 = new Clanek(1, nemcova, "Babička", "prefix", "text clanku");

            Console.WriteLine(nemcova.ToString());
            
            Console.WriteLine(clanek1.ToString());

            Console.WriteLine(clanek1.AutorClanku);

        }
    }
}
