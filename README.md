# NESTranslatorGUI
GUI-fied version of the console-based app. 

Take a NES ROM file and scrapes the header to provide information to the user.
Using the scraped info from the header, it determines the amount of PRGROM (Game Code) is on the ROM file then translates it into readable 6502 ASM code.
After full translation of PRGROM, it outputs that to a provided text file. 

NOTE: This does check for a trainer, but doesn't take that into account when translating. 
