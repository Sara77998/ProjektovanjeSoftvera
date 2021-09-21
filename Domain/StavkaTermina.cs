using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class StavkaTermina : IEntity
    {
        public Termin TerminId { get; set; }
        public int RB { get; set; }
       
        public Ucenik Ucenik { get; set; }



        [Browsable(false)]
        public string TableName => "StavkaTermina";
        [Browsable(false)]
        public string InsertValues { get; set; }
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => "on(st.Ucenik=u.UcenikId)";
        [Browsable(false)]
        public string JoinTable => "join Ucenik u";
        [Browsable(false)]
        public string JoinCondition1 => "on(st.Terminid=t.terminid)";
        [Browsable(false)]
        public string JoinTable1 => "join Termin t";
        [Browsable(false)]
        public string TableAlias => "st";
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
        public string JoinCondition2 => "on(a.ModelID=m.ID)";
        [Browsable(false)]
        public string JoinTable2 => "join Model m";
        [Browsable(false)]
        public string JoinCondition3 => "on(m.MarkaID=ma.ID)";
        [Browsable(false)]
        public string JoinTable3 => "join Marka ma";

        public List<IEntity> GetEntities(SqlDataReader citac)
        {
            List<IEntity> result = new List<IEntity>();
            while (citac.Read())
            {
                StavkaTermina st = new StavkaTermina
                {
                    TerminId = new Termin
                    {
                        TerminId = citac.GetInt32(0)
                        

                    },
                    RB = citac.GetInt32(1),
                    Ucenik = new Ucenik
                    {
                        //UcenikId = citac.GetString(2),
                        Ime = citac.GetString(4),
                        Prezime = citac.GetString(5)
                    }
                };
                result.Add(st);
            }
           
            return result;
        }
    }
}
