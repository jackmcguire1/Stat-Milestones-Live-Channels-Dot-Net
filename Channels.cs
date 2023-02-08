// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Channel
{
    public Channel(){
        configuration = new Configuration();
    }

    public string broadcaster_id { get; set; } = string.Empty;
    public string broadcaster_name { get; set; } = string.Empty;
    public string game_name { get; set; } = string.Empty;
    public string game_id { get; set; } = string.Empty;
    public string title { get; set; } = string.Empty;
    public Configuration configuration { get; set; }
    public string country_code { get; set; } = string.Empty;
    public DateTime created_date { get; set; }
    public DateTime updated_date { get; set; }
    public int viewers { get; set; }
    public string profile { get; set; } = string.Empty;
    public string type { get; set; } = string.Empty;
    public ChatterInfo chatter_info { get; set; } = new();
}

public class Charity
{
    public string gauge_colour { get; set; } = string.Empty;
}

public class ChatterInfo
{
    public ChatterInfo() {
        chatters = new List<ChatChatter>();
    }

    public int count { get; set; }
    public List<ChatChatter> chatters { get; set; }
    public string error { get; set; } = string.Empty;
}

public class ChatChatter {
    public string profile_url { get; set; } = string.Empty;
    public string user_login { get; set; } = string.Empty;
    public string user_id { get; set; } = string.Empty;
    public string user_name { get; set; } = string.Empty;
}

public class Configuration
{
    public Configuration() {
        messages = new Messages();
        followers = new Followers();
        panel_settings = new PanelSettings();
        hypetrain = new Hypetrain();
        subscribers = new Subscribers();
        motd = new Motd();
        custom = new Custom();
        goals = new Goals();
        charity = new Charity();
        misc = new Misc();
    }

    public Messages messages { get; set; }
    public Followers followers { get; set; }
    public PanelSettings panel_settings { get; set; }
    public Subscribers subscribers { get; set; }
    public Misc misc { get; set; }
    public Motd motd { get; set; }
    public Hypetrain hypetrain { get; set; }
    public Custom custom { get; set; }
    public Goals goals { get; set; }
    public Charity charity { get; set; }
}

public class Custom
{
    public bool enabled { get; set; }
    public int target { get; set; }
    public string gauge_colour { get; set; } = string.Empty;
    public int count { get; set; }
    public string img { get; set; } = string.Empty;
    public string title { get; set; } = string.Empty;
    public bool subButtonEnabled { get; set; }
}

public class Followers
{
    public int target { get; set; }
    public string message { get; set; } = string.Empty;
    public string gauge_colour { get; set; } = string.Empty;
    public bool display_recent_followers { get; set; }
}

public class Goals
{
    public string gauge_colour { get; set; } = string.Empty;
}

public class Hypetrain
{
    public string gauge_colour { get; set; } = string.Empty;
}

public class Messages
{
    public bool enabled { get; set; }
    public int target { get; set; }
    public string gauge_colour { get; set; } = string.Empty;
}

public class Misc
{
    public string view { get; set; } = string.Empty;
    public bool optIn { get; set; }
}

public class Motd
{
    public string msg { get; set; } = string.Empty;
    public int ts { get; set; }
}

public class PanelSettings
{
    public string background_colour { get; set; } = string.Empty;
    public string font_colour { get; set; } = string.Empty;
    public bool dark_mode { get; set; }
}

public class LiveChannelsResponse
{
    public LiveChannelsResponse() {
        channels = new List<Channel>();
    }
    public int total { get; set; }
    public string bookmark { get; set; } = string.Empty;
    public List<Channel> channels { get; set; }
}

public class Subscribers
{
    public int target { get; set; }
    public string gauge_colour { get; set; } = string.Empty;
}

