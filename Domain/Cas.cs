﻿using System;
using System.Collections.Generic;
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

        public string TableName => "Cas";
        public string InsertValues => $"'{StazaLokacija}', '{TezinaCasa}', {Cena}";
        public string IdName => "";
        public string JoinCondition => "";
        public string JoinTable => "";
        public string TableAlias => "c";
        public string SelectValues => "*";
        public string WhereCondition { get; set; }
        public string WhereValue { get; set; }
        public string Where => "where";
        public string JoinCondition1 => "";
        public string JoinTable1 => "";
        public string UpdateText { get; set; }
        public string JoinCondition2 => "";
        public string JoinTable2 => "";
        public string JoinCondition3 => "";
        public string JoinTable3 => "";




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

