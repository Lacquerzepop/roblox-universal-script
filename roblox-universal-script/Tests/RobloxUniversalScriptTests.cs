using System;
using System.Threading.Tasks;
using Xunit;

namespace RobloxUniversalScript.Tests
{
    public class RobloxUniversalScriptTests
    {
        [Fact]
        public async Task ExecuteScriptAsync_ValidScript_ReturnsResult()
        {
            var script = new RobloxUniversalScript("https://test-api.roblox.com");
            var result = await script.ExecuteScriptAsync("print('test')");
            Assert.NotNull(result);
        }

        [Fact]
        public void ScriptParser_EmptyScript_ThrowsException()
        {
            var parser = new ScriptParser();
            Assert.Throws<ArgumentException>(() => parser.ParseAndValidate(""));
        }

        [Fact]
        public void ScriptParser_InvalidScript_ThrowsException()
        {
            var parser = new ScriptParser();
            Assert.Throws<InvalidOperationException>(() => parser.ParseAndValidate("just random text"));
        }

        [Fact]
        public void ScriptParser_ExtractName_ReturnsCorrectName()
        {
            var parser = new ScriptParser();
            var name = parser.ExtractScriptName("-- @name MyScript\nprint('hi')");
            Assert.Equal("MyScript", name);
        }
    }
}