using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("Funny Cats", "emily_the_destroyer", 2113);
        vid1.WriteComment(new Comment("number1h8er", "Why can't you make your videos longer??"));
        vid1.WriteComment(new Comment("Howarz", "HAHAHAHA SO FUNNY"));
        vid1.WriteComment(new Comment("wyt32", "698s is crazy"));

        Video vid2 = new Video("NFL highlights", "futboal", 3567);
        vid2.WriteComment(new Comment("orlanu", "I watced the hole thing"));
        vid2.WriteComment(new Comment("Peelers", "Go bears"));
        vid2.WriteComment(new Comment("22urgu", "How did I get on this video"));

        Video vid3 = new Video("Day 4 survival camping", "emily_the_destroyer", 910);
        vid3.WriteComment(new Comment("Peelers", "I wish you were playing football instead."));
        vid3.WriteComment(new Comment("JEEEl32", "WAS THAT A BEAR"));
        vid3.WriteComment(new Comment("peilieh", "Yo this is awesome"));

        Video vid4 = new Video("How to fix v8 engine", "deisel_man8", 1981);
        vid4.WriteComment(new Comment("deisel_man8", "UPDATE: I put the pulley on wrong here's how to actually do it..."));
        vid4.WriteComment(new Comment("orlanu", "You put the pulley on wrong..."));
        vid4.WriteComment(new Comment("wyt32", "THANK YOU I was freaking out until this helped me."));


        vid1.PrintInfo();
        vid2.PrintInfo();
        vid3.PrintInfo();
        vid4.PrintInfo();
    }
}