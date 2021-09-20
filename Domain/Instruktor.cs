using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Instruktor : IEntity
    {
        public int InstruktorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public SkolaSkijanja SkolaSkijanja { get; set; }
        public string KorisnickoIme { get; set; }
        [Browsable(false)]
        public string Lozinka { get; set; }



        [Browsable(false)]
        public string TableName => "Instruktor";
        [Browsable(false)]
        public string InsertValues => throw new NotImplementedException();
        [Browsable(false)]
        public string IdName => "ID";
        [Browsable(false)]
        public string JoinCondition => "on (i.SkolaSkijanja=ss.skolaskijanjaid)";
        [Browsable(false)]
        public string JoinTable => "join SkolaSkijanja ss";
        [Browsable(false)]
        public string TableAlias => "i";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string WhereValue { get => ""; set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string Where => "";
        [Browsable(false)]
        public string JoinCondition1 => "";
        [Browsable(false)]
        public string JoinTable1 => "";
        [Browsable(false)]
        public string UpdateText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string JoinCondition2 => "";
        [Browsable(false)]
        public string JoinTable2 => "";
        [Browsable(false)]
        public string JoinCondition3 => "";
        [Browsable(false)]
        public string JoinTable3 => "";

        public List<IEntity> GetEntities(SqlDataReader citac)
        {
            List<IEntity> result = new List<IEntity>();
            while (citac.Read())
            {
                Instruktor i = new Instruktor
                {
                    InstruktorId = (int)citac["InstruktorId"],
                    Ime = (string)citac["Ime"],
                    Prezime = (string)citac["Prezime"],
                    DatumRodjenja = (DateTime)citac["DatumRodjenja"],
                    Email = (string)citac["Email"],
                    SkolaSkijanja = new SkolaSkijanja
                    {
                        SkolaSkijanjaId = (int)citac["SkolaSkijanjaId"]
                    },
                    KorisnickoIme = (string)citac["KorisnickoIme"],
                    Lozinka = (string)citac["Lozinka"]
                };
                result.Add(i);

            }
            return result;
        }

    }
}
