using System;
using System.Collections.Generic;
using System.Text;

namespace DumpGitApp
{
    class GitClass
    {
        public string[] CommitsHashes {get; set;};
        private Description;

        GitClass(string[] commitHashes)
        {
            CommitsHashes = commitHashes;
        }
    }
}
