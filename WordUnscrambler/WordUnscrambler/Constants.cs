using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Constants
    {
        public const string OptionsOnHowToEnterSracmbledWords =
            "Enter scrambled word(s) manually or as a File: F- File/ M-Manual";
        public const string OptionsOnContinuingTheProgram = "Would you like to continue? Y/N";

        public const string EnterScrambledWordsManually = "Enter Word(s) manually (separated by comas if multiple)";
        public const string EnterScrambledWordsViaFile = "Enter full path including the file name:";
        public const string EnterScrambledWordOptionNotRecognized = "The option was not recognized.";

        public const string ErrorScrambledWordCannotBeLoaded =
            "Scrambled words were not loaded because there was an error:";
        public const string ErrorProgramWillBeTerminated = " The program will be terminated:";

        public const string MatchFound = "MATCH FOUND FOR {0}: {1}";
        public const string MatchNotFound = "NO MATCHES HAVE BEEN FOUND";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordlist.txt";
    }
}
