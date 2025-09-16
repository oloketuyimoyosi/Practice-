public class SecurityPassMaker
{
    public string GetDisplayName(TeamSupport support)
    {
        string [] Team = new string []{"Chairman","Manager" };
        string[] Security = {"SecurityJunior","SecurityIntern","PoliceLiaison" };
        if (Array.Exists(Team, Teams => Teams == Convert.ToString(support.GetType()))){
            return "Too Important for a Security Pass";
        }else if (Convert.ToString(support.GetType()) == "Security") {
            return "Security Team Member Priority Personnel";
        }
        else if((Array.Exists(Security, SecurityTeam => SecurityTeam == Convert.ToString(support.GetType())))){
            return support.Title;
            
        }
        else{
            return support.Title;
        }
        

    }
}

/**** Please do not alter the code below ****/

public interface TeamSupport { string Title { get; } }

public abstract class Staff : TeamSupport { public abstract string Title { get; } }

public class Manager : TeamSupport { public string Title { get; } = "The Manager"; }

public class Chairman : TeamSupport { public string Title { get; } = "The Chairman"; }

public class Physio : Staff { public override string Title { get; } = "The Physio"; }

public class OffensiveCoach : Staff { public override string Title { get; } = "Offensive Coach"; }

public class GoalKeepingCoach : Staff { public override string Title { get; } = "Goal Keeping Coach"; }

public class Security : Staff { public override string Title { get; } = "Security Team Member"; }

public class SecurityJunior : Security { public override string Title { get; } = "Security Junior"; }

public class SecurityIntern : Security { public override string Title { get; } = "Security Intern"; }

public class PoliceLiaison : Security { public override string Title { get; } = "Police Liaison Officer"; }
