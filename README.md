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


FAQ:

Q: Why does the mapper name produce "MultiCart" or "???"  
A: Some mappers don't have a lot of documentation, might be a specialized mapper, might be used for only one game, might be a multicart, or a combination of all of these. 

Q: Does this account for .ORG/.DB/.BYTE/etc?  
A: No. Those are lost during compiling to a Binary/ROM file. 

Q: The created text file doesn't show up after creating it inside the save file dialog box. Did something go wrong?  
A: No. You might have to click the refresh button next to the directy bar at the top. You could also try pressing enter to select the newly created text file.

Q: Why is the information in the text boxes being mirrored to the left text box?  
A: I mirrored everything in the text file to the large text box. This is so you don't have to keep scraping the same ROM file over and over to gather that information.

Q: Can I use the same text for different ROM files?  
A: No. One ROM file to one text file. This is to keep the text file clean. I suggest creating text files with the same name as your ROM files. 

Q: Does this utilize undocumented 6502 opcodes?  
A: At the moment, no. I might add it later, but there's not too many licensed games that utilize them. 
