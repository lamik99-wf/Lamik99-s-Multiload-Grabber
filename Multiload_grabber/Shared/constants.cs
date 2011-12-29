///A place for constants used all around the program
///

using System;

namespace LocalConst
{
    public enum Server { CZshare, Hellshare, ShareRapid, Rapidshare, Ulozto, Quickshare, Multishare, XXXXX, FileFactory };
    public enum SupportedServers { Hellshare, ShareRapid, Rapidshare, Ulozto, Quickshare, Multishare, FileFactory };

    public static class Const
    {
        //number of Multiload-supported servers
        public const UInt16 multiloadServersCount = 9;

        public const UInt16 multiloadSupportedServersCount = 7; //CZshare and XXX (no. 8 - what is that?) not supported

        //server side link
        public const string serverURL = @"http://mlgrabber.php5.cz/index.php?";

        //homepage
        public const string homepageURL = "http://sourceforge.net/projects/mlgrabber/";

        //changelog
        public const string changelogURL = "http://mlgrabber.php5.cz/changelog.txt";
        
        //list of names of supported servers
        public static string[] servers = { "Multishare", "Hellshare", "Quickshare", "Rapidshare", "Share-Rapid", "Uloz.to", "FileFactory" };
        
        //beginning of folder grab box
        public const string textAreaHeader = "<textarea onclick=\"this.select()\" cols=\"50\" rows=\"10\">";

        //end of folder grab box
        public const string textAreaFooter = "</textarea";

        //marks that it's a link for Multiload folder
        public const string multiloadFolder = "/slozka/";

        //prefix in multiload link before its ID
        public const string multiloadLinkPrefix = "http://www.multiload.cz/stahnout/";

        //marks that this is a valid Multiload link
        public const string multiloadValidator = "multiload";


    }


    
}
