import re
from typing import List

def sanitize_script(script: str) -> str:
    """Remove potentially harmful patterns from scripts."""
    # Basic example - remove infinite loops
    script = re.sub(r"while\s*True\s*:", "while False:", script)
    return script.strip()

def parse_place_ids(input_str: str) -> List[int]:
    """Extract place IDs from a string."""
    return [int(id_) for id_ in re.findall(r"\d{8,}", input_str) if id_.isdigit()]