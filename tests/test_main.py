import unittest
from unittest.mock import patch
from roblox_universal_script.main import RobloxUniversalScript

class TestRobloxUniversalScript(unittest.TestCase):
    @patch("requests.get")
    def test_get_game_info(self, mock_get):
        mock_get.return_value.status_code = 200
        mock_get.return_value.json.return_value = {"Name": "Test Game"}

        rus = RobloxUniversalScript()
        result = rus.get_game_info(12345678)
        self.assertEqual(result["Name"], "Test Game")

    def test_execute_script(self):
        rus = RobloxUniversalScript()
        result = rus.execute_script("print('test')", 12345678)
        self.assertTrue(result)

if __name__ == "__main__":
    unittest.main()