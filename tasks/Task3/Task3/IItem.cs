using System;


namespace Task3
{
    public interface IItem
    {
        /// <summary>
        /// Gets a description 
        /// </summary>
        string Description { get; }


        /// <summary>
        /// Gets the amount of pieces
        /// </summary>
        uint GetPieces { get; }

        /// <summary>
        /// Gets a price
        /// </summary>
        decimal GetPrice { get; }



    }
}
