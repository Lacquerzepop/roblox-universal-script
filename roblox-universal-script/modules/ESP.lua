local Players = game:GetService("Players")
local RunService = game:GetService("RunService")

local ESP = {}

function ESP.new(script)
    local self = setmetatable({}, { __index = ESP })
    self._script = script
    self._boxes = {}
    return self
end

function ESP:enable()
    self._script:connect(RunService.Heartbeat, function()
        for _, player in ipairs(Players:GetPlayers()) do
            if player ~= Players.LocalPlayer and player.Character then
                local humanoidRootPart = player.Character:FindFirstChild("HumanoidRootPart")
                if humanoidRootPart then
                    -- Simplified ESP logic
                    if not self._boxes[player] then
                        self._boxes[player] = Instance.new("BoxHandleAdornment")
                        self._boxes[player].Parent = humanoidRootPart
                        self._boxes[player].Adornee = humanoidRootPart
                        self._boxes[player].Size = humanoidRootPart.Size + Vector3.new(0.1, 0.1, 0.1)
                        self._boxes[player].Color3 = Color3.new(1, 0, 0)
                        self._boxes[player].AlwaysOnTop = true
                        self._boxes[player].ZIndex = 10
                    end
                end
            end
        end
    end)
end

function ESP:disable()
    for player, box in pairs(self._boxes) do
        box:Destroy()
        self._boxes[player] = nil
    end
end

return ESP