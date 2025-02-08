using System;

class Program
{
    static private List<Scripture> _scriptures = new();
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("ScriptureMemorizer");
        Thread.Sleep(3000);

        /** 
        Scriptures Library
        */

        // Create reference
        Reference reference1 = new Reference("1 Nefi", 3, 7);
        // Create scripture text string
        string text1 = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        // Create Scripture Object
        Scripture scripture1 = new Scripture(reference1, text1);

        _scriptures.Add(scripture1);

        // Create reference
        Reference reference2 = new Reference("2 Nefi", 25, 26);
        // Create scripture text string
        string text2 = "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.";
        // Create Scripture Object
        Scripture scripture2 =
         new Scripture(reference2, text2);

        _scriptures.Add(scripture2);

        // Create reference
        Reference reference3 = new Reference("Enos", 1, 4, 6);
        // Create scripture text string
        string text3 = "And my soul hungered; and I kneeled down before my Maker, and I cried unto him in mighty prayer and supplication for mine own soul; and all the day long did I cry unto him; yea, and when the night came I did still raise my voice high that it reached the heavens. And there came a voice unto me, saying: Enos, thy sins are forgiven thee, and thou shalt be blessed. And I, Enos, knew that God could not lie; wherefore, my guilt was swept away.";
        // Create Scripture Object
        Scripture scripture3 =
         new Scripture(reference3, text3);

        _scriptures.Add(scripture3);


        // Create reference
        Reference reference4 = new Reference("Mosiah", 3, 19);
        // Create scripture text string
        string text4 = "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.";
        // Create Scripture Object
        Scripture scripture4 =
         new Scripture(reference4, text4);

        _scriptures.Add(scripture4);

        /**
        Select random scripture
        */

        Scripture scripture = GetRandomScripture();
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Please press enter to continue and hide random words or type \"quit\" to finish: ");
            string option = Console.ReadLine();
            if (option.Equals("quit", StringComparison.CurrentCultureIgnoreCase) || scripture.AreAllWordsHidden())
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(7);
            }

        } while (true);

    }

    static Scripture GetRandomScripture()
    {
        Random _random = new Random();
        int randomIndex = _random.Next(_scriptures.Count);
        return _scriptures[randomIndex];
    }
}