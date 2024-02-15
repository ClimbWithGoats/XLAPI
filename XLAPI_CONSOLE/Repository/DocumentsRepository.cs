using System;
using XLAPI_CONSOLE.Interfaces;

namespace XLAPI_CONSOLE.Repository
{
    public class DocumentsRepository : BaseRepository, IDocumentsRepository, IBaseRepository
    {
        public DocumentsRepository(ConfigRoot configuration) : base(configuration)
        {
        }

        public override object GetData(object name)
        {
            throw new NotImplementedException();
        }

        public override int GetItemById(object obj)
        {
            throw new NotImplementedException();
        }

        public object GetMany()
        {
            string sql =
        string.Format(@"SELECT kk.Knt_Akronim ,kk.Knt_GIDNumer ,Atr_Wartosc 
                                FROM cdn.kntkarty AS kk JOIN (SELECT * FROM cdn.Atrybuty 
                                WHERE Atr_AtkId = (SELECT AtK_ID FROM cdn.AtrybutyKlasy WHERE AtK_Nazwa = 'Zweryfikowany')) 
                                AS rezultatAtrybut ON Atr_ObiTyp = kk.Knt_GIDTyp AND Atr_ObiNumer = kk.Knt_GIDNumer");

            //Do wyciągania danych z db preferuję listę dynamiczną, która zawiera nazwy kolumn zdefiniowane z DB z XL, więc można na sztywno do nich się dobrać znając ich nazwy. 
            //   var res = zbXL.GetData(sql);
            return new NotImplementedException();
        }

        public object GetSingle()
        {
            string sql =
         string.Format(@"SELECT kk.Knt_Akronim ,kk.Knt_GIDNumer ,Atr_Wartosc 
                                FROM cdn.kntkarty AS kk JOIN (SELECT * FROM cdn.Atrybuty 
                                WHERE Atr_AtkId = (SELECT AtK_ID FROM cdn.AtrybutyKlasy WHERE AtK_Nazwa = 'Zweryfikowany')) 
                                AS rezultatAtrybut ON Atr_ObiTyp = kk.Knt_GIDTyp AND Atr_ObiNumer = kk.Knt_GIDNumer");

            //Do wyciągania danych z db preferuję listę dynamiczną, która zawiera nazwy kolumn zdefiniowane z DB z XL, więc można na sztywno do nich się dobrać znając ich nazwy. 
            //var res = zbXL.GetData(sql);
            return new NotImplementedException();
        }
    }
}
