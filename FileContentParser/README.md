# File content parser

This console app parses json format files and displays into the conosle.

At the moment it reads json file from the bin directory where the both valid and invalid json files are placed.

File `games.json` and `gamesInvalidFormat.json` has both valid and invalid format. In the case of invalid formate, app will show appropriate exception
and logs it to the the `errorLog.txt` which is as well located in bin dir.