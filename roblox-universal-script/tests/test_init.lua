local UniversalScript = require(script.Parent.Parent)

local testScript = UniversalScript.new()

local function testConnection()
    local event = Instance.new("BindableEvent")
    local called = false
    testScript:connect(event.Event, function()
        called = true
    end)
    event:Fire()
    assert(called, "Connection callback was not called")
    testScript:destroy()
    event:Fire()
    assert(not called, "Connection was not disconnected")
    print("Connection test passed")
end

testConnection()