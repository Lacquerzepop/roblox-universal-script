from setuptools import setup, find_packages

setup(
    name="roblox-universal-script",
    version="0.1.0",
    packages=find_packages(),
    install_requires=[
        "requests>=2.25.1",
    ],
    entry_points={
        "console_scripts": [
            "roblox-script=roblox_universal_script.cli:main",
        ],
    },
)