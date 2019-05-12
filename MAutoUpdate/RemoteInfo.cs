using System;
using System.Collections.Generic;
using System.Text;

namespace MAutoUpdate
{
    public class RemoteInfo
    {
        public string ApplicationStart { get; set; }
        public string AppName { get; set; }
        public string MinVersion { get; set; }
        public string ReleaseDate { get; set; }
        public string ReleaseUrl { get; set; }
        public string ReleaseVersion { get; set; }
        public string UpdateMode { get; set; }
        public string VersionDesc { get; set; }
    }
}
