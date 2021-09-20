using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection konekcija;
        private SqlCommand komanda;
        private SqlTransaction transakcija;

        public Broker()
        {
            konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SkiSkolaBaza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void OtvoriKonekciju()
        {
            konekcija.Open();
        }

        public void ZatvoriKonekciju()
        {
            konekcija.Close();
        }

        public void ZapocniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
        }
        public void Commit()
        {
            transakcija?.Commit();
        }
        public void Rollback()
        {
            transakcija?.Rollback();
        }



        public void Obrisi(IEntity entity)
        {
            komanda = new SqlCommand("", konekcija, transakcija);
            komanda.CommandText = $"delete from {entity.TableName} where {entity.WhereCondition} {entity.WhereValue} ";
            /*if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greska sa bazom podataka");
            }*/
            try
            {
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Brisanje ovog objekta nije dozvoljeno");
            }

        }


        public List<IEntity> VratiSve(IEntity entity)
        {
            List<IEntity> result;
            komanda = new SqlCommand("", konekcija, transakcija);
            komanda.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} {entity.JoinTable1} {entity.JoinCondition1}";
            SqlDataReader citac = komanda.ExecuteReader();
            result = entity.GetEntities(citac);
            citac.Close();
            return result;
        }

        public List<IEntity> VratiSveGde(IEntity entity)
        {
            List<IEntity> result = new List<IEntity>();
            komanda = new SqlCommand("", konekcija, transakcija);
            komanda.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} {entity.JoinTable1} {entity.JoinCondition1} {entity.JoinTable2} {entity.JoinCondition2} {entity.JoinTable3} {entity.JoinCondition3} {entity.Where} {entity.WhereCondition}'{entity.WhereValue}'";
            SqlDataReader citac = komanda.ExecuteReader();
            result = entity.GetEntities(citac);
            citac.Close();
            return result;
        }


        public void Sacuvaj(IEntity entity)
        {
            komanda = new SqlCommand("", konekcija, transakcija);
            komanda.CommandText = $"insert into {entity.TableName} values ({entity.InsertValues})";
            /*if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }*/
            try
            {
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska sa bazom podataka");
            }
        }

        public void Izmeni(IEntity entity)
        {
            komanda = new SqlCommand("", konekcija, transakcija);
            komanda.CommandText = $"update {entity.TableName} set {entity.UpdateText} {entity.Where} {entity.WhereCondition}{entity.WhereValue}";
            /*if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }*/
            try
            {
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska sa bazom podataka");
            }
        }

        public int VratiNoviId(IEntity entity)
        {
            komanda = new SqlCommand("", konekcija, transakcija);
            komanda.CommandText = $"select max({entity.IdName}) from {entity.TableName} ";
            object result = komanda.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result;
            }
        }

        public bool Postoji(IEntity entity)
        {
            komanda = new SqlCommand("", konekcija, transakcija);
            komanda.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} {entity.JoinTable1} {entity.JoinCondition1} {entity.JoinTable2} {entity.JoinCondition2} {entity.JoinTable3} {entity.JoinCondition3} {entity.Where} {entity.WhereCondition}'{entity.WhereValue}'";
            object result = komanda.ExecuteScalar();
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
