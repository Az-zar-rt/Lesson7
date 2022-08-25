string s1 = "Hello";
string s2 = "Hello";
string s3 = "dle,cvvertp";

int result = string.Compare(s1, s2);
if (result < 0)
{
    Console.WriteLine(" s1 not equal s2");
}
else if (result > 0)
{
    Console.WriteLine(" s1 not equal s2");
}
else
{
    Console.WriteLine("Strings s1 and s2 are equal");
}
static string Sort(string s1)
{
    string s2 = s1.ToLower();

    char[] alphabet = s2.ToCharArray();

    for (int i = 0; i < s1.Length; i++)
    {
        for (int a = 1; a < s1.Length; a++)
        {
            int cmpVal = s1[a].CompareTo(s1[a - 1]);

            if (cmpVal < 0)
            {
                char x = alphabet[a];
                alphabet[a] = alphabet[a - 1];
                alphabet[a - 1] = x;
            }
            s1 = new string(alphabet);
        }
    }
    Console.WriteLine(s1);
    return s1;
}
Sort(s3);
static void Dublicate()
{

    var Word1 = Convert.ToString(Console.ReadLine());
    var Word2 = Convert.ToString(Console.ReadLine());

    for (int i = 0; i < Word1.Length; i++)
    {
        for (int j = 0; j < Word2.Length; j++)
        {
            if (Word1[i] == Word2[j])
            {
                Console.Write(Word1[i]);
            }
        }
    }
}
Dublicate();
static void Analyze()
{
    string Word1 = "e98203tu?,&*3";
    string Word2 = "greighherh";

    Console.WriteLine(Word1.Length);
    Console.WriteLine(Word2.Length);
}
Analyze();