namespace Exercism.SwitchStatements
{
    public static class FootballMatchReports
    {
        public static string AnalyzeOnField(int shirtNum) => shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException()
        };

        public static string AnalyzeOffField(object report) => report switch
        {
            int supportersAtMatch => $"There are {supportersAtMatch} supporters at the match.",
            string announcement => $"{announcement}",
            Injury injury => $"Oh no! {injury.GetDescription()} Medics are on the field.",
            Incident incident => incident.GetDescription(),
            Manager { club: null } manager => $"{manager.name}",
            Manager manager => $"{manager.name} ({manager.club})",
            _ => throw new ArgumentException()
        };
    }

    public class Incident
    {
        public virtual string GetDescription() => "The referee deemed a foul.";
    }

    public class Injury : Incident
    {
        private int playerNumber;
        public Injury(int playerNumber) => this.playerNumber = playerNumber;

        public override string GetDescription() => $"Player {playerNumber} is injured.";
    }

    public class Manager
    {
        public string name;
        public string? club;

        public Manager(string name, string? club)
        {
            this.name = name;
            this.club = club;
        }
    }

}
