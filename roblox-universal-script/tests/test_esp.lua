local UniversalScript = require(script.Parent.Parent)
local ESP = require(script.Parent.Parent.modules.ESP)

local testScript = UniversalScript.new()
local esp = ESP.new(testScript)

local function testESP()
    esp:enable()
    wait(1)
    esp:disable()
    print("ESP test completed (visual inspection required)")
end

testESP()