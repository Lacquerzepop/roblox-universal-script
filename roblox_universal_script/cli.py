import argparse
from .main import RobloxUniversalScript

def main():
    parser = argparse.ArgumentParser(description="Roblox Universal Script Tool")
    parser.add_argument("--universe-id", type=int, help="Roblox universe ID")
    parser.add_argument("--script", type=str, help="Script to execute")
    args = parser.parse_args()

    rus = RobloxUniversalScript()
    if args.universe_id:
        info = rus.get_game_info(args.universe_id)
        print(f"Game Info: {info}")
    if args.script:
        rus.execute_script(args.script, args.universe_id or 0)

if __name__ == "__main__":
    main()