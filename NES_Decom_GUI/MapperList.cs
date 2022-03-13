namespace NES_Decom_GUI
{

    //TODO: Add the rest of the mappers
    class MapperList : NESForm
    {
        public string Mappers(int MapperNumbers, string MapperComp)
        {
            string MapperName = MapperComp;

            switch(MapperNumbers)
            {
                case 0: MapperName = "Nintendo"; break;
                case 1: MapperName = "Nintendo"; break;
                case 2: MapperName = "Nintendo"; break;
                case 3: MapperName = "Nintendo"; break;
                case 4: MapperName = "Nintendo"; break;
                case 5: MapperName = "Nintendo"; break;
                case 6: MapperName = "???"; break;
                case 7: MapperName = "Nintendo/Rare"; break;
                case 8: MapperName = "???";break;
                case 9: MapperName = "Nintendo"; break;
                case 10: MapperName = "Nintendo"; break;
                case 11: MapperName = "Color Dreams/Wisdom Tree"; break;
                case 12: MapperName = "???"; break;
                case 13: MapperName = "Videomation"; break;
                case 14: MapperName = "???"; break;
                case 15: MapperName = "K-1029"; break;
                case 16: MapperName = "Bandai"; break;
                case 17: MapperName = "???"; break;
                case 18: MapperName = "Jaleco"; break;
                case 19: MapperName = "Namco"; break;
                case 20: MapperName = "Famicom Disk System"; break;
                case 21: MapperName = "Konami"; break;
                case 22: MapperName = "Konami"; break;
                case 23: MapperName = "Konami"; break;
                case 24: MapperName = "Konami"; break;
                case 25: MapperName = "Konami"; break;
                case 26: MapperName = "Konami"; break;
                case 27: MapperName = "???"; break;
                case 28: MapperName = "???"; break;
                case 29: MapperName = "???"; break;
                case 30: MapperName = "???"; break;
                case 31: MapperName = "???"; break;
                case 32: MapperName = "Irem"; break;
                case 33: MapperName = "Taito"; break;
                case 34: MapperName = "???"; break;
                case 35: MapperName = "J.Y. Asic"; break;
                case 36: MapperName = "TXC"; break;
                case 37: MapperName = "Nintedo MultiCart"; break;
                case 38: MapperName = "BitCorp"; break;
                case 39: MapperName = "???"; break;
                case 40: MapperName = "???"; break;
                case 41: MapperName = "???"; break;
                case 42: MapperName = "FDS To Cart"; break;
                case 43: MapperName = "FDS to Cart"; break;
                case 44: MapperName = "MultiCart"; break;
                case 45: MapperName = "GA23C ASIC"; break;
                case 46: MapperName = "Color Dreams"; break;
                case 47: MapperName = "MultiCart"; break;
                case 48: MapperName = "Taito"; break;
                case 49: MapperName = "MultiCart"; break;
                case 50: MapperName = "Hacked YUNG-08 conversion"; break;
                case 51: MapperName = "11-in-1 Ball Games"; break;
                case 52: MapperName = "MultiCart"; break;
                case 53: MapperName = "Supervision 16-in-1"; break;
                case 54: MapperName = "Novel Diamond 9999999-in-1"; break;
                case 55: MapperName = "BTL-MARIO1-MALEE2"; break;
                case 56: MapperName = "Mario Bros. 3 Repro"; break;
                case 57: MapperName = "MultiCart"; break;
                case 58: MapperName = "MultiCart"; break;
                case 59: MapperName = "MultiCart"; break;
                case 60: MapperName = "MultiCart"; break;
                case 61: MapperName = "MultiCart"; break;
                case 62: MapperName = "MultiCart"; break;
                case 63: MapperName = "MultiCart"; break;
                case 64: MapperName = "Tengen"; break;
                case 65: MapperName = "MultiCart"; break;
                case 66: MapperName = "Nintendo/Others"; break;
                case 67: MapperName = "Sunsoft-3"; break;
                case 68: MapperName = "Sunsoft-4"; break;
                case 69: MapperName = "Sunsoft"; break;
                case 70: MapperName = "???"; break;
                case 71: MapperName = "Codemasters/Camerica"; break;
                case 72: MapperName = "Jaleco's JF-17"; break;
                case 73: MapperName = "Konami"; break;
                case 74: MapperName = "Waixing"; break;
                case 75: MapperName = "Konami"; break;
                case 76: MapperName = "???"; break;
                case 77: MapperName = "???"; break;
                case 78: MapperName = "???"; break;
                case 79: MapperName = "American Video Entertainment"; break;
                case 80: MapperName = "Taito's X1-005"; break;
                case 81: MapperName = "NTDEC"; break;
                case 82: MapperName = "Taito's X1-017"; break;
                case 83: MapperName = "Cony"; break;
                case 84: MapperName = "???"; break;
                case 85: MapperName = "Konami"; break;
                case 86: MapperName = "Jaleco's JF-13"; break;
                case 87: MapperName = "???"; break;
                case 88: MapperName = "???"; break;
                case 89: MapperName = "Sunsoft"; break;
                case 90: MapperName = "J.Y. Company"; break;
                case 91: MapperName = "J.Y. Company"; break;
                case 92: MapperName = "???"; break;
                case 93: MapperName = "Sunsoft"; break;
                case 94: MapperName = "???"; break;
                case 95: MapperName = "???"; break;
                case 96: MapperName = "???"; break;
                case 97: MapperName = "Irem's TAM-S1"; break;
                case 98: MapperName = "???"; break;
                case 99: MapperName = "Vs. System"; break;

            }

            return MapperName;
        }
    }
}
