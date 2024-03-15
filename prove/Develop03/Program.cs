using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("1 Nephi", 3, 7);
        Scripture scripture1 = new Scripture(reference1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        Reference reference2 = new Reference("2 Nephi", 32, 8, 9);
        Scripture scripture2 = new Scripture(reference2, "And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the devil spirit teacheth not a man to pray, but teacheth him that he must not pray. But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul.");

        Console.WriteLine(scripture2.GetDisplayText());
    }
}