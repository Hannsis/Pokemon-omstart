namespace Pokemon_omstart;

internal class Program
{
    static void Main(string[] args)
    {
        var logics = new Logics();

        logics.Run(new Bulbasaur(), new Charmander(), new Squirtle());
    }
}
