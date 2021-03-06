//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entreprise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public partial class financement
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> DateInsert { get; set; }
        public string MoneyType { get; set; }
        public Nullable<double> caisse { get; set; }

        public static void Add_Money(DateTime date, string type, double money)
        {
            BDGestionAssociationEntities3 bd = new BDGestionAssociationEntities3();
            financement f = new financement();
            f.DateInsert = date;
            f.MoneyType = type;
            f.caisse = money;
            bd.financements.Add(f);
            bd.SaveChanges();
        }

        public static List<financement> getAllFinance()
        {
            BDGestionAssociationEntities3 bd = new BDGestionAssociationEntities3();
            List<financement> ls = bd.financements.ToList<financement>();
            return ls;
        }

        public static List<financement> searchFinancement(int year, int month, string type)
        {
            BDGestionAssociationEntities3 bd = new BDGestionAssociationEntities3();
            List<financement> ls;
            if (type == null)
            {
                if (year == 0 && month != 0)
                {
                    ls = bd.financements.Where(f => f.DateInsert.Value.Month == month).ToList<financement>();
                    return ls;
                }
                else if (year != 0 && month == 0)
                {
                    ls = bd.financements.Where(f => f.DateInsert.Value.Year == year).ToList<financement>();
                    return ls;
                }
                else if (year != 0 && month != 0)
                {
                    ls = bd.financements.Where(f => f.DateInsert.Value.Year == year && f.DateInsert.Value.Month == month).ToList<financement>();
                    return ls;
                }
            }
            else
            {
                if (year == 0 && month != 0)
                {
                    ls = bd.financements.Where(f => f.DateInsert.Value.Month == month && f.MoneyType == type).ToList<financement>();
                    return ls;
                }
                else if (year != 0 && month == 0)
                {
                    ls = bd.financements.Where(f => f.DateInsert.Value.Year == year && f.MoneyType == type).ToList<financement>();
                    return ls;
                }
                else if (year != 0 && month != 0)
                {
                    ls = bd.financements.Where(f => f.DateInsert.Value.Year == year && f.DateInsert.Value.Month == month && f.MoneyType == type).ToList<financement>();
                    return ls;
                }
                else if (year == 0 && month == 0)
                {
                    ls = bd.financements.Where(f => f.MoneyType == type).ToList<financement>();
                    return ls;
                }
            }
            return null;
        }

        public static double GetCaisse()
        {
            BDGestionAssociationEntities3 bd = new BDGestionAssociationEntities3();
            double money;
            double entre = bd.financements.Where(x => x.MoneyType == "entre").Sum(x => x.caisse).GetValueOrDefault();
            double sortie = bd.financements.Where(x => x.MoneyType == "sortie").Sum(x => x.caisse).GetValueOrDefault();
            money = entre - sortie;
            return money;
        }
    }
}
