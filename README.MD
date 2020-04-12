# RiotGames.Launcher
This launcher is a simple written launcher for all three games made by Riot Games (League of Legends, Legends of Runeterra and Valorant).  
It was created because i wanted to get rid of all the icons on my desktop.

## How to install
Simply download the latest release, extract it and then start it.

## How does the launcher know where the correct path is?
The launcher searches within the registry for the uninstall location to get the path to the RiotService.exe.
The pathes are within the current user:
```
Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Riot Game league_of_legends.live  
Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Riot Game valorant.live  
Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Riot Game bacon.live  
```

## Why does the launcher not recognize the newly installed game?
That's because it initally creates a settings.json within the application path to store the already found locations.  
Simply delete it until i've implemented the settings tab.

## Is this an official launcher made by riot games?
No.