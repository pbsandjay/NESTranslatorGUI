# NESTranslatorGUI
GUI-fied version of the console-based app. 

Take a NES ROM file and scrapes the header to provide information to the user.
Using the scraped info from the header, it determines the amount of PRGROM (Game Code) is on the ROM file then translates it into readable 6502 ASM code.
After full translation of PRGROM, it outputs that to a provided text file. 

This shouldn't touch anything pertaining to CHR ROM data. Some bytes might slip through the cracks. 


NOTE: This does check for a trainer, but doesn't take that into account when translating.


USAGE:
1. Select your NES ROM file
2. Select your text file for outputting the translation
3. Click Translate


EXAMPLE:

$3C7 to $3CE in Tetris opened in a hex editor will yield 
18 69 8F 85 A1 A9 53 85 A2

After translation you'll get the output like so...

3C7: CLC 
3C8: ADC    #$8F
3CA: STA    $A1
3CC: LDA    #$53
3CE: STA    $A2
