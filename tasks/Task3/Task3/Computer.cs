using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;

namespace Task3
{
    class Computer : IItem
    {
        /// <PRIVATE_FIELD>
        /// Über 10 Stück am Lager 10 % Rabatt
        /// </summary>
        private decimal discount = 90;

        /// <CONSTRUCTOR>
        /// Creats new Object
        /// </summary>
        /// <param name="newCompany"></param>
        /// <param name="newModel"></param>
        /// <param name="newPieces"></param>
        /// <param name="newPrice"></param>
        [JsonConstructor]
        public Computer(string newCompany, string newModel, uint newPieces, decimal newPrice)
        {
           // if (string.IsNullOrEmpty(newCompany)) throw new ArgumentException("Company must not be emty", nameof(newCompany));
           // if (string.IsNullOrEmpty(newModel)) throw new ArgumentException("Model must not be emty", nameof(newModel));

            if (newPieces > 99) throw new ArgumentException("Pieces must be lesser than 99.", nameof(newPieces));

            if (newPrice > 99999) throw new ArgumentException("Price must be lesser than 99999.", nameof(newPrice));
            if (newPrice < 0) throw new ArgumentException("Price must not be negative.", nameof(newPrice));

            Company = newCompany;
            Model = newModel;
            Pieces = UpdatePieces(newPieces);
            Price = UpdatePrice(newPieces, newPrice);

        }
        /// <PROPERTIES>
        /// Properties from the object
        /// </summary>
        public string Company { get; }
        public string Model { get; }
        public uint Pieces { get; set; }
        public decimal Price { get; private set; }

        /// <METHODE>
        /// Neue Bestellung!
        /// </summary>
        /// <param name="Pieces"></param>
        /// <returns></returns>
        public uint UpdatePieces(uint Pieces)
        {
            if (Pieces <= 5)
            {
                Pieces += 10;
            }
            return Pieces;
        }
        /// <METHODE>
        /// Discount!
        /// </summary>
        /// <param name="Pieces"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        private decimal UpdatePrice(uint Pieces, decimal Price)
        {
            if (Pieces > 10)
            {
                Price *= discount;
                return Price / 100;
            }
            return Price;
        }

        #region IInfo implementation


        /// <summary>
        /// Gets a textual description of this item.
        /// </summary>
        public string Description => Company;

        /// <summary>
        /// Gets the amount
        /// </summary>
        public uint GetPieces => Pieces;

        /// <summary>
        /// Gets a special price of this item.
        /// </summary>
        public decimal GetPrice => Price;


        #endregion


    }
}
