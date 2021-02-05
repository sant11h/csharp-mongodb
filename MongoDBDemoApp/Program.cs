using System;

namespace MongoDBDemoApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Agus",
            //    LastName = "Gerhart",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "Calle 404",
            //        City = "Urdilandia",
            //        Province = "ER",
            //        ZipCode = "2826"
            //    }
            //};

            //db.InsertRecord("Users", person);

            var records = db.LoadRecords<NameModel>("Users");

            foreach (var item in records)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}");

                //if (item.PrimaryAddress != null)
                //{
                //    Console.WriteLine(item.PrimaryAddress.City);
                //}
                Console.WriteLine();
            }

            //var user = db.LoadRecordById<PersonModel>("Users", new Guid("278ec935-0ffb-4623-8baa-e9f12e7abcdd"));
            //user.DateOfBirth = new DateTime(2004, 12, 4, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", user.Id, user);

            //db.DeleteRecord<PersonModel>("Users", user.Id);

            Console.ReadLine();
        }
    }
}
