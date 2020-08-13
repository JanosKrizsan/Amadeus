using Amadeus.InterfacesForUtilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;

namespace Amadeus.Utilities
{
    public sealed class DataScriptHandler : IDataScriptHandler
    {
        public static DataScriptHandler Instance { get { return _instance.Value; } }
        private static readonly Lazy<DataScriptHandler> _instance = new Lazy<DataScriptHandler>(() => new DataScriptHandler());
        private List<string> _scripts => GetScriptFiles();
        private Runspace _runspace;

        private DataScriptHandler()
        {
            StartRenewProcess();
        }

        private void StartRenewProcess()
        {
            GetScriptFiles();
            SetRunspace();
        }

        public List<string> GetScriptFiles()
        {
            var currents = Directory.GetDirectories(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
            var scriptDir = currents.Where(dir => Directory.GetFiles(dir).FirstOrDefault().Contains(".ps1"));
            var files = Directory.GetFiles(scriptDir.ToString()).ToList();
            return files;
        }

        public void SetRunspace()
        {
            _runspace = RunspaceFactory.CreateRunspace();
        }

        public Pipeline CreatePipeline()
        {
            return _runspace.CreatePipeline();
        }

        public object ExecuteScript(string scriptFullName, string parameters = null)
        {
            var elevation = _scripts.Where(script => script.Contains("Execute-As-Admin.ps1")).ToString();
            object result = null;
            if (!scriptFullName.Contains("none"))
            {
                if (_runspace is null)
                {
                    SetRunspace();
                }
                _runspace.Open();
                var pipeline = CreatePipeline();
                var arguments = parameters == null ? "" : string.Concat(" -$ArgumentsForScript", parameters);
                pipeline.Commands.Add(string.Concat(elevation, " -ExecScriptPath", scriptFullName, arguments));

                result = pipeline.Invoke();

                _runspace.Close();
            }
            return result;
        }

        public string GetScriptsDirPath()
        {
            return Path.GetDirectoryName(_scripts.FirstOrDefault());
        }

        public object GetScriptResults(string script, string parameters = null)
        {
            return ExecuteScript(_scripts.Where(name => name.Contains(script)).First()?.ToString() ?? "none", parameters ?? "") ?? "no such script found";
        }
    }
}
