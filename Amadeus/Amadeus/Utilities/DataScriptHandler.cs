using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;

namespace Amadeus.Utilities
{
    public sealed class DataScriptHandler
    {
        public static DataScriptHandler Instance { get { return _instance.Value; } }


        private static readonly Lazy<DataScriptHandler> _instance = new Lazy<DataScriptHandler>(() => new DataScriptHandler());
        private IList<string> _scripts;
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

        private void GetScriptFiles()
        {
            var currents = Directory.GetDirectories(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
            var scriptDir = currents.Where(dir => Directory.GetFiles(dir).FirstOrDefault().Contains(".ps1"));
            var files = Directory.GetFiles(scriptDir.ToString());
            _scripts = files;
        }

        private void SetRunspace()
        {
            _runspace = RunspaceFactory.CreateRunspace();
        }

        private Pipeline CreatePipeline()
        {
            return _runspace.CreatePipeline();
        }

        private object ExecuteScript(string scriptFullName, string parameters)
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
                pipeline.Commands.Add(string.Concat(elevation, " -ExecScriptPath", scriptFullName, " -$ArgumentsForScript", parameters));

                result = pipeline.Invoke();

                _runspace.Close();
            }
            return result;
        }

        public object GetScriptResults(string script, string parameters)
        {
            return ExecuteScript(_scripts.Where(name => name.Contains(script)).First()?.ToString() ?? "none", parameters) ?? "no such script found";
        }
    }
}
