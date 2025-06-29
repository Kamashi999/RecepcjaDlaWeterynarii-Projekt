using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Npgsql;
using RecepcjaDlaWeterynarii.Logic;

namespace RecepcjaDlaWeterynarii.Tables
{
    public class DatabaseMethods
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Database=Reception;User Id=reception;Password=admin";

        public Pets GetPetInfo(string name)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM \"Pets\" WHERE \"Name\" = @name", connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    Pets petInfo = new Pets();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        petInfo.PetId = reader.GetInt32(0);
                        petInfo.Name = reader.GetString(1);
                        petInfo.Type = reader.GetString(2);
                        petInfo.Sex = reader.GetString(3);
                        petInfo.Age = reader.GetInt32(4);
                        petInfo.MicrochipNumber = reader.GetInt32(5);
                        petInfo.Weight = reader.GetDouble(6);
                    }

                    return petInfo;
                }
            }
        }

        public Owners GetOwnerInfo(int petId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM \"Owners\" WHERE \"PetId\" = @petId", connection))
                {
                    cmd.Parameters.AddWithValue("@petId", petId);

                    Owners ownerInfo = new Owners();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ownerInfo.OwnerId = reader.GetInt32(0);
                        ownerInfo.PetId = petId;
                        ownerInfo.Name = reader.GetString(2);
                        ownerInfo.LastName = reader.GetString(3);
                        ownerInfo.Phone = reader.GetString(4);
                        ownerInfo.Email = reader.GetString(5);
                        ownerInfo.Address = reader.GetString(6);
                    }

                    return ownerInfo;
                }
            }
        }

        public int GetLatestPetId()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT MAX(\"PetId\") FROM \"Pets\"", connection))
                {
                    var maxPetId = cmd.ExecuteScalar();

                    return int.Parse(maxPetId.ToString());
                }
            }
        }

        public int GetOwnerId(int petId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"OwnerId\" FROM \"Owners\" WHERE \"PetId\" = @petId", connection))
                {
                    cmd.Parameters.AddWithValue("@petId", petId);

                    int ownerId = 0;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ownerId = reader.GetInt32(0);
                    }

                    return ownerId;
                }
            }
        }

        public void AddPet(Pets pet)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand petCommand = new NpgsqlCommand("INSERT INTO \"Pets\"(\"Name\", \"Type\", \"Sex\", \"Age\", \"Microchip_Number\", \"Weight\") VALUES (@name, @type, @sex, @age, @microchip, @weight)", connection))
                {
                    petCommand.Parameters.AddWithValue("@name", pet.Name);
                    petCommand.Parameters.AddWithValue("@type", pet.Type);
                    petCommand.Parameters.AddWithValue("@sex", pet.Sex);
                    petCommand.Parameters.AddWithValue("@age", pet.Age);
                    petCommand.Parameters.AddWithValue("@microchip", pet.MicrochipNumber);
                    petCommand.Parameters.AddWithValue("@weight", pet.Weight);

                    petCommand.ExecuteNonQuery();
                }
            }
        }

        public void AddOwner(Owners owner)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand ownerCommand = new NpgsqlCommand("INSERT INTO \"Owners\"(\"PetId\", \"Name\", \"LastName\", \"Phone\", \"Email\", \"Address\") VALUES (@petId, @name, @lastName, @phone, @email, @address)", connection))
                {
                    ownerCommand.Parameters.AddWithValue("@petId", owner.PetId);
                    ownerCommand.Parameters.AddWithValue("@name", owner.Name);
                    ownerCommand.Parameters.AddWithValue("@lastName", owner.LastName);
                    ownerCommand.Parameters.AddWithValue("@phone", owner.Phone);
                    ownerCommand.Parameters.AddWithValue("@email", owner.Email);
                    ownerCommand.Parameters.AddWithValue("@address", owner.Address);

                    ownerCommand.ExecuteNonQuery();
                }
            }
        }

        public void AddVisit(int ownerId, int petId, string reason)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand visitCommand = new NpgsqlCommand("INSERT INTO \"Visits\"(\"OwnerId\", \"PetId\", \"Reason\") VALUES (@ownerId, @petId, @reason)", connection))
                    {
                        visitCommand.Parameters.AddWithValue("@ownerId", ownerId);
                        visitCommand.Parameters.AddWithValue("@petId", petId);
                        visitCommand.Parameters.AddWithValue("@reason", reason);

                        visitCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {

            }
        }
    }
}
