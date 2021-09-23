using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Ucenik : IEntity
    {
        public string UcenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }



        [Browsable(false)]
        public string TableName => "Ucenik";
        [Browsable(false)]
        public string InsertValues => $"'{UcenikId}','{Ime}','{Prezime}','{DatumRodjenja.ToString("MM/dd/yyyy")}','{Telefon}','{Email}'";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "u";
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
            return $"{UcenikId} {Ime} {Prezime}";
        }
        public Ucenik Objekat
        {
            get
            {
                return this;
            }
        }
        public string Prikaz
        {
            get
            {
                return Prezime;
            }
        }
        public List<IEntity> GetEntities(SqlDataReader citac)
        {

            List<IEntity> result = new List<IEntity>();
            while (citac.Read())
            {
                Ucenik u = new Ucenik
                {
                    UcenikId = citac.GetString(0),
                    Ime = citac.GetString(1),
                    Prezime = citac.GetString(2),
                    DatumRodjenja = (DateTime)citac["DatumRodjenja"],
                    Telefon = citac.GetString(4),
                    Email = citac.GetString(5)
                };
                result.Add(u);
            }
            return result;
        }
    }
}
