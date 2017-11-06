# pinwin - stands for "Pin Windows"
### What?
I always liked [DeskPins](http://efotinis.neocities.org/deskpins/index.html) windows application, written by [Elias Fotinis](http://efotinis.neocities.org/about.html) - very simple and intuitive, it allows you to make any 3rd party window, i.e. that of another application, [top most](https://msdn.microsoft.com/en-us/library/system.windows.window.topmost%28v=vs.110%29.aspx) (also known as "always-on-top"), and it will appear on top of other windows at all times, until DeskPins is closed. Below is a screenshot of how it works, self-explanatory:

![DeskPins in action](http://i.imgur.com/Y65spks.png)

[Link for DeskPins direct download](https://drive.google.com/file/d/0BzOSyp06l5JwMVNXYkFMQXNMUTQ/view?usp=sharing) is provided here for your convenience (no ads, using Google Drive).

DeskPins was written in C++ and [its source code recently made public](https://bitbucket.org/efotinis/deskpins) (thank you, Elias).

### Why?
If you look at the attached readme file, the original software is not meant to work on Windows Vista and above. However, it kept working all the way until Windows 7, but then unfortunately, stopped working on Windows 8 and higher.
So I decided to write one in .NET with support for all OS (hopefully).

### How is the progress so far?

![PinWin in action](https://i.imgur.com/aH0FWrw.png)

- Basic functionality is there, tested on Windows XP, 7 and 8.1.
- Multi-monitor supported (verified dual extend configuration).
- High DPI supported (verified 100-200%).
- Set other windows as top most via CTRL+F11 (same as DeskPins).
- User friendly installer with upgrade support.
- No user configuration is available yet.

### Download

You can download PinWin [via GitHub releases](https://github.com/VictorZakharov/pinwin/releases), where the most recent version is available (source code, binaries or installer).

### Credits

I would like to thank below people and communities for making this project happen:
- StackOverflow, for [this answer](http://stackoverflow.com/questions/17897646/gma-useractivitymonitor-setwindowshookex-error-126) (special thanks to [Hans Passant](http://stackoverflow.com/users/17034/hans-passant)) and [this answer](http://stackoverflow.com/questions/4604023/unable-to-read-another-applications-caption) (special thanks to [Tergiver](http://stackoverflow.com/users/351385/tergiver)).
- Creators of [Inno Setup](http://www.jrsoftware.org/isinfo.php), developer-friendly installer tool with a flat learning curve.
