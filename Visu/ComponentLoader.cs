using mitoSoft.Razor.homeNet.Components.Contracts;
using mitoSoft.Razor.homeNet.Components.Models;

namespace Visu
{
    public class ComponentLoader : IComponentLoader
    {
        //TODO hier die Componenten eintragen
        public void RegisterComponents(ComponentList components)
        {
            //TODO weg
            var mila = new SingleLight("MilasRoomController/Deckenlicht");
            components.Add(mila);

            var kueche = new SingleLight("EGController1/kuecheLicht");
            var essen = new SingleLight("EGController1/essenLicht");
            var esstisch = new SingleLight("EGController1/esstischLicht");
            var wohnen = new SingleLight("EGController1/wohnenLicht");
            //var blind = new Blind("EGController1/Shutter1");
            //var shutter = new Shutter("EGController1/Shutter2");

            components.Add(kueche);
            components.Add(essen);
            components.Add(esstisch);
            components.Add(wohnen);
            components.Add(new LightGroup("EGController1/EssenLichter", kueche, essen, esstisch));
            components.Add(new LightGroup("EGController1/ErdgeschossLichter", kueche, essen, esstisch, wohnen));
        }
    }
}