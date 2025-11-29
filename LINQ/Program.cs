namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NBA Teams");
            
            List<string> nbaEasternConferenceTeams = new List<string>()
            {
                "Chicago Bulls", "Detroit Pistons", "Cleveland Cavaliers",
                "Toronto Raptors", "Miami Heat", "New York Knicks", "Atlanta Hawks",
                "Orlando Magic", "Boston Celtics", "Philadelphia 76'ers", "Milwaukee Bucks",
                "Charlotte Hornets", "New Jersey Nets", "Washington Wizards", "Indiana Pacers"
            };
            
            // List the teams by length of name - shortest to longest
            var orderedNbaTeams = nbaEasternConferenceTeams.OrderBy(n => n.Length);
            foreach (var nbaTeam in orderedNbaTeams)
            {
                Console.WriteLine(nbaTeam);
            }
        }
    }
}
