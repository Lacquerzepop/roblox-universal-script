using System;
using System.Text.RegularExpressions;

namespace RobloxUniversalScript
{
    public class ScriptParser
    {
        public string ParseAndValidate(string rawScript)
        {
            if (string.IsNullOrWhiteSpace(rawScript))
                throw new ArgumentException("Script cannot be empty");

            // Basic Roblox Lua-like validation
            var scriptPattern = @"\b(function|local|end|if|then|else|for|while|do|return)\b";
            var matches = Regex.Matches(rawScript, scriptPattern, RegexOptions.IgnoreCase);

            if (matches.Count == 0)
                throw new InvalidOperationException("Script must contain valid Roblox Lua syntax");

            // Normalize line endings
            return rawScript.Replace("\r\n", "\n").Replace("\r", "\n");
        }

        public string ExtractScriptName(string scriptContent)
        {
            var match = Regex.Match(scriptContent, @"--\s*@name\s+(.+)", RegexOptions.IgnoreCase);
            return match.Success ? match.Groups[1].Value.Trim() : "UnnamedScript";
        }
    }
}