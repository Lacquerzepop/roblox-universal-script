local UniversalScript = {}

function UniversalScript.new()
    local self = setmetatable({}, { __index = UniversalScript })
    self._connections = {}
    return self
end

function UniversalScript:connect(event, callback)
    table.insert(self._connections, event:Connect(callback))
end

function UniversalScript:destroy()
    for _, connection in ipairs(self._connections) do
        connection:Disconnect()
    end
    self._connections = {}
end

return UniversalScript