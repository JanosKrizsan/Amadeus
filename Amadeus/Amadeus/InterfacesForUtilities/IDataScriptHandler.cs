using System.Collections.Generic;
using System.Management.Automation.Runspaces;

namespace Amadeus.InterfacesForUtilities
{
    /// <summary>
    /// Responsible for handling scripts.
    /// </summary>
    interface IDataScriptHandler
    {
        /// <summary>
        /// Retrieves the script files and saves their paths
        /// </summary>
        /// <returns>A List of paths</returns>
        List<string> GetScriptFiles();

        /// <summary>
        /// Sets the Runspace for PS scripts
        /// </summary>
        void SetRunspace();

        /// <summary>
        /// Creates a Pipeline with which to execute PS scripts
        /// </summary>
        /// <returns></returns>
        Pipeline CreatePipeline();

        /// <summary>
        /// Exectues the given script with the given parameters
        /// </summary>
        /// <param name="scriptFullName">Full path of the script</param>
        /// <param name="parameters">Parameters - if any, for the script</param>
        /// <returns></returns>
        object ExecuteScript(string scriptFullName, string parameters = null);

        /// <summary>
        /// Retrieves the path where the script files are stored, only the path
        /// </summary>
        /// <returns>The full path of the directory</returns>
        string GetScriptsDirPath();

        /// <summary>
        /// Retrieves the results of the script's execution from the Pipeline
        /// </summary>
        /// <param name="script">Full path of the script</param>
        /// <param name="parameters">Parameters - if any, for the script</param>
        /// <returns>Results of the script, or an error prompt</returns>
        object GetScriptResults(string script, string parameters = null);
    }
}
