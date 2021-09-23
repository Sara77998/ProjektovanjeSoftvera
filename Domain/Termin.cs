using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Termin : IEntity
    {
        
        public int TerminId { get; set; }
        public DateTime DatumIVreme { get; set; }
        public Instruktor Instruktor { get; set; }
        public Cas CasId { get; set; }
        public List<StavkaTermina> StavkeTermina { get; set; }

        [Browsable(false)]
        public string TableName => "Termin";
        [Browsable(false)]
        public string InsertValues { get; set; }
        [Browsable(false)]
        public string IdName => "TerminId";
        [Browsable(false)]
        public string JoinCondition => "on(t.Instruktor = i.InstruktorId)";
        [Browsable(false)]
        public string JoinTable => "join Instruktor i";
        [Browsable(false)]
        public string JoinCondition1 => "on(t.CasId = c.CasId)";
        [Browsable(false)]
        public string JoinTable1 => "join Cas c";
        [Browsable(false)]
        public string TableAlias => "t";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string Where => "where";
        [Browsable(false)]
        public string WhereCondition { get; set; }
        [Browsable(false)]
        public string WhereValue { get; set; }
        [Browsable(false)]
        public string UpdateText { get; set; }
        [Browsable(false)]
        public string JoinCondition2 => "";
        [Browsable(false)]
        public string JoinTable2 => "";
        [Browsable(false)]
        public string JoinCondition3 => "";
        [Browsable(false)]
        public string JoinTable3 => "";

        public override string ToString()
        {
            return $"{TerminId} {DatumIVreme} {Instruktor} {CasId}";
        }

        public List<IEntity> GetEntities(SqlDataReader citac)
        {
            List<IEntity> result = new List<IEntity>();
            while (citac.Read())
            {
                Termin t = new Termin
                {
                    TerminId = citac.GetInt32(0),
                    DatumIVreme = citac.GetDateTime(1),
                    Instruktor = new Instruktor
                    {
                        InstruktorId = citac.GetInt32(2),
                        Ime = citac.GetString(5),
                        Prezime = citac.GetString(6)
                    },
                    CasId = new Cas
                    {
                        CasId = citac.GetInt32(3),
                        StazaLokacija = citac.GetString(13),
                        TezinaCasa = citac.GetString(14)

                    }
                };
                

                result.Add(t);
            }
            return result;
        }


    }
}
