var A = new string[]
{
    "unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us",
    "a.b.c.d.e", "x.e.y", "ijkm", "z.p.o", "r.s.t", "f.g.h.l.m"
};
var B = new string[]
    { "microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us", "e", "p.o", "r.s.t", "m" };
var result = Solution.Solution.solution(A, B);

foreach(var ind in result)
    Console.Write(ind + " ");
Console.WriteLine();

Console.ReadKey(true);    