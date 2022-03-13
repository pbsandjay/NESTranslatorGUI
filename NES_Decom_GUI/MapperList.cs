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

            }

            return MapperName;
        }
    }
}
