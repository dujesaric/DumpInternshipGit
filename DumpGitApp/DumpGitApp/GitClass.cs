using System;
using System.Collections.Generic;
using System.Text;

namespace DumpGitApp
{
    class GitClass
    {
        public string[] CommitsHashes {get; set;};
        public Description {get; set;};

        GitClass(string[] commitHashes)
        {
            CommitsHashes = commitHashes;
        }
    }
}
