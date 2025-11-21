using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Analyzing the Best Scene in Breaking Bad", "Tim's Video Essays", 790);
        video1.AddComment("@mystdxrxck2059", "Ok nerd");
        video1.AddComment("@guilhermehank4938", "The most tragic thing is that this is one of the few scenes Walter is being 100% honest with his family and this time they dont believe a word he says");
        video1.AddComment("@DDub04", "'No, no, NO! I tried to save him!'\n\nCranston earned that Emmy with this line.");
        videoList.Add(video1);

        Video video2 = new Video("WORST Christmas Movies on Tubi", "FunkyFrogBait", 1448);
        video2.AddComment("@literallytomdcas", "i can’t believe funkyfrogbait is santa. this is unbelievable");
        video2.AddComment("@SirMrSkellyBones", "As an aspiring filmmaker, I can only dream of making a movie as amazing as Christmas with Cookie");
        video2.AddComment("@Sudomanic", "'I am haunted by my own inadequacies.' is a banger of an opening line.");
        video2.AddComment("@Fizzy_boo", "There's no way the actors in Christmas with Cookie weren't laughing with every scene. I refuse to believe they made that movie with the intention of it being as good as possible");
        videoList.Add(video2);

        Video video3 = new Video("Australia just found a NEW SHARK", "More Parz", 124);
        video3.AddComment("@NyxMoonReads", "You know, if the Megalodon is actually still alive somehow, it's 100% gonna be discovered in Australia.");
        video3.AddComment("@d4v_y", "The gacha statement got me");
        video3.AddComment("@AsherKadmiel", "'we had no sun, so we became our own'  -the shark, probably");
        video3.AddComment("@JT_The_Banana", "The Devs dropping a new shark design so late into the 20.25 patch is kinda bold im not gonna lie, at least they dropped it off in the testing servers");
        videoList.Add(video3);

        Video video4 = new Video("Spooky's Jump Scare Mansion EXTRA Specimens Ranked", "Wambu", 4437);
        video4.AddComment("@NightmareFueler", "You know, I just realized. If Body Bag's backstory is ascended canon, that means YOU'RE canon to Spooky's... But just by some weird technicality, I suppose.");
        video4.AddComment("@BeanieBabyXx", "I know monster 2s backstory is just a bit but the idea of a guy completely giving up on life and willingly climbing into a cursed body bag which effectively kills him without killing him is actually pretty good and goes well with the humour of the game.");
        video4.AddComment("@rbpgamemaster", "Fitting that spooper takes the #1 because he's basically a microcosm of the game as a whole.\nCute harmless joke->Absolute Nightmare fuel");
        video4.AddComment(" ", "I love the back-and-forth between the two ghosts, it gives me a hilarious internal image of two ghosts talking about the various monsters in the haunted house they inhabit and getting into a deep discussion about the nuances of evil creatures.\n\nLike, while watching an animatronic otter rip an intruder apart with solid metal claws, one of them offhandedly comments\n'Yeah this one could be improved upon.'");
        videoList.Add(video4);

        foreach (Video video in videoList)
        {
            video.Display();
        }
    }
}