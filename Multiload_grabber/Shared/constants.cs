///A place for constants used all around the program

namespace LocalConst
{
    public enum Server { CZshare, Hellshare, ShareRapid, Rapidshare, Ulozto, Quickshare, Multishare, XXXXX, FileFactory };

    public static class Const
    {
        //server side link
        public const string serverURL = @"http://mlgrabber.php5.cz/index.php?";

        //beginning of folder grab box
        public const string textAreaZahlavi = "<textarea onclick=\"this.select()\" cols=\"50\" rows=\"10\">";

        //list of supported servers
        public static string[] servers = { "Multishare", "Hellshare", "Quickshare", "Rapidshare", "Share-Rapid", "Uloz.to", "FileFactory" };
    }


    
}
