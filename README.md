# GetBranchStageFiles
A tool for extracting stage files in Git, the propose is to move changes between repositories

## Usage

Supporting in Git commands:

```bash
git diff --name-only HEAD > files.txt | GetBranchStageFiles.exe files.txt
``` 