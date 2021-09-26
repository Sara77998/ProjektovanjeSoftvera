using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class SkolaSkijanja : IEntity
    {
        public int SkolaSkijanjaId { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }



        public string TableName => "SkolaSkijanja";
        public string InsertValues => throw new NotImplementedException();
        public string IdName => throw new NotImplementedException();
        public string JoinCondition => "";
        public string JoinTable => "";
        public string TableAlias => "ss";
        public string SelectValues => "*";
        public string WhereCondition => "";
        public string WhereValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Where => throw new NotImplementedException();
        public string JoinCondition1 => "";
        public string JoinTable1 => "";
        public string UpdateText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string JoinCondition2 => "";
        public string JoinTable2 => "";
        public string JoinCondition3 => "";
        public string JoinTable3 => "";
        public override string ToString()
        {
            return $"{Naziv}";
        }

        public List<IEntity> GetEntities(SqlDataReader citac)
        {
            List<IEntity> result = new List<IEntity>();
            while (citac.Read())
            {
                SkolaSkijanja ss = new SkolaSkijanja
                {
                    SkolaSkijanjaId = citac.GetInt32(0),
                    Naziv = citac.GetString(1),
                    Telefon = citac.GetString(2)
                };
                result.Add((IEntity)ss);
            }
            return result;
        }



    }
}
