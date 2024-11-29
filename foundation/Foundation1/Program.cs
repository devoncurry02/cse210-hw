using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video();
        vid1._title = "Funny Cats";
        vid1._author = "emily_the_destroyer";
        vid1._length = "13:44";

        vid1._comment1 = new Comment();
        vid1._comment1._name = "number1h8er";
        vid1._comment1._text = "Why can't you make your videos longer??";

        vid1._comment2 = new Comment();
        vid1._comment2._name = "Howarz";
        vid1._comment2._text = "HAHAHAHA SO FUNNYYY";

        vid1._comment3 = new Comment();
        vid1._comment3._name = "wyt32";
        vid1._comment3._text = "Why can't you make your videos longer??";


        Video vid2 = new Video();
        vid2._title = "NFL highlights";
        vid2._author = "futboal";
        vid2._length = "2:04:14";

        vid2._comment1 = new Comment();
        vid2._comment1._name = "orlanu";
        vid2._comment1._text = "I watced the hole thing";

        vid2._comment2 = new Comment();
        vid2._comment2._name = "Peelers";
        vid2._comment2._text = "Go bears";

        vid2._comment3 = new Comment();
        vid2._comment3._name = "22urgu";
        vid2._comment3._text = "How did I get on this video.";


        Video vid3 = new Video();
        vid3._title = "Day 4 survival camping";
        vid3._author = "emily_the_destroyer";
        vid3._length = "30:11";

        vid3._comment1 = new Comment();
        vid3._comment1._name = "Peelers";
        vid3._comment1._text = "I wish you were playing football instead.";

        vid3._comment2 = new Comment();
        vid3._comment2._name = "JEEEl32";
        vid3._comment2._text = "WAS THAT A BEAR???";

        vid3._comment3 = new Comment();
        vid3._comment3._name = "peilieh";
        vid3._comment3._text = "Yo this is awesome.";
    }
}