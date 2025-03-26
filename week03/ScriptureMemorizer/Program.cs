// Exceeding Requirement: 
// It has a function in the Reference Class that can perform calculations for multiple verses and display them in a single line.
// Example: 1 Matthew 25:1-5;24;25-26;30
// This example covers all the possible scenarios of consecutive verses and single verses.
// Example 2: 1 John 3:16-20;22-23;35
// This example is the one for the Scripture memorizer.

class Program
{
    static void Main(string[] args)
    {
        Scripture s1 = new Scripture("John", 3, new List<Verse>
        {
            new Verse(16, "For God so loved the world, " +
                         "that he gave his only begotten Son, " +
                         "that whosoever believeth in him should not perish, " +
                         "but have everlasting life."),
                         new Verse(17, "For God sent not his Son into the world to condemn the world; " +
                         "but that the world through him might be saved."),
                         new Verse(18, "He that believeth on him is not condemned: " +
                         "but he that believeth not is condemned already, " +
                         "because he hath not believed in the name of the only begotten Son of God."),
                         new Verse(19, "And this is the condemnation, that light is come into the world, " +
                            "and the world loved darkness rather than light, because their deeds were evil."),
                         new Verse(20, "For every one that doeth evil hateth the light, " +
                         "neither cometh to the light, lest his deeds should be reproved."),
                        new Verse(22, "But he that doeth truth cometh to the light, " +
                         "that his deeds may be made manifest, that they are wrought in God."),
                         new Verse(23, "After these things came Jesus and his disciples into the land of Judaea; " +
                            "and there he tarried with them, and baptized."),
                            new Verse(25, "Then there arose a question between some of John's disciples" +
                            "about purifying."),
        });

        string answer = "INITIAL";

        while  (answer != "quit" && !s1.IsCompletelyEmpty()){
            if (answer != "INITIAL") {
                s1.HideRandom();
            }
            s1.Display();
            Console.WriteLine("Type \"quit\" to quit or press Enter to continue... ");
            Console.Write("> ");
            answer = Console.ReadLine();
        } 
    }
}