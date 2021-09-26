using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Cas : IEntity
    {
        public int CasId { get; set; }
        public string StazaLokacija { get; set; }
        public string TezinaCasa { get; set; }
        public double Cena { get; set; }

        [Browsable(false)]
        public string TableName => "Cas";
        [Browsable(false)]
        public string InsertValues => $"'{StazaLokacija}', '{TezinaCasa}', {Cena}";
        [Browsable(false)]
        public string IdName => "";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "c";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition { get; set; }
        [Browsable(false)]
        public string WhereValue { get; set; }
        [Browsable(false)]
        public string Where => "where";
        [Browsable(false)]
        public string JoinCondition1 => "";
        [Browsable(false)]
        public string JoinTable1 => "";
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
            return $"{StazaLokacija} {TezinaCasa} {Cena}";
        }
        public List<IEntity> GetEntities(SqlDataReader citac)
        {
            List<IEntity> result = new List<IEntity>();
            while (citac.Read())
            {
                Cas c = new Cas
                {
                    CasId = citac.GetInt32(0),
                    StazaLokacija = citac.GetString(1),
                    TezinaCasa = citac.GetString(2),
                    Cena = citac.GetDouble(3)
                };
                result.Add(c);
            }
            return result;
        }
    }


}

