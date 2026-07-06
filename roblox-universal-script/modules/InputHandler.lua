local UserInputService = game:GetService("UserInputService")

local InputHandler = {}

function InputHandler.new(script)
    local self = setmetatable({}, { __index = InputHandler })
    self._script = script
    return self
end

function InputHandler:bindKey(keyCode, callback)
    self._script:connect(UserInputService.InputBegan, function(input, gameProcessed)
        if input.KeyCode == keyCode and not gameProcessed then
            callback()
        end
    end)
end

return InputHandler