// Written by Kapil
// Feb 5 2025

using System;

namespace HomeWork2
{
    public class HomeWork2
    {
        // Class variables or member variables
        private int xCoordinate;
        private int yCoordinate;
        private int itemChoice;
        private string userName;
        private int targetNumber;
        private int guessedNumber;
        private int turn;
        private int[] originalArray;
        private int[] copiedArray;

        // Constructor to initialize the values
        public HomeWork2(int aArraySize = 5, int aXCoordinate = 0, int aYCoordinate = 0, int aItemChoice = -1, string aUserName = "n/a", int aTargetNumber = -1, int aGuessedNumber = -1, int aTurn = 0)
        {
            this.xCoordinate = aXCoordinate;
            this.yCoordinate = aYCoordinate;
            this.itemChoice = aItemChoice;
            this.userName = aUserName;
            this.targetNumber = aTargetNumber;
            this.guessedNumber = aGuessedNumber;
            this.turn = aTurn;

            // Initialize arrays with the given size
            this.originalArray = new int[aArraySize];
            this.copiedArray = new int[aArraySize];
        }

        // Properties with custom getters and setters
        public int XCoordinate
        {
            get { return this.xCoordinate; }
            set { this.xCoordinate = value; }
        }

        public int YCoordinate
        {
            get { return this.yCoordinate; }
            set { this.yCoordinate = value; }
        }

        public int ItemChoice
        {
            get { return this.itemChoice; }
            set
            {
                if (value >= 1 && value <= 7)
                    this.itemChoice = value;
                else
                    this.itemChoice = -1;  // Invalid item choice
            }
        }

        public string UserName
        {
            get { return this.userName; }
            set
            {
                // Limiting username length to 16 characters
                this.userName = value.Length > 16 ? value.Substring(0, 16) : value;
            }
        }

        public int TargetNumber
        {
            get { return this.targetNumber; }
            set
            {
                if (value >= 0 && value <= 100)
                    this.targetNumber = value;
                else
                    this.targetNumber = -1; // Invalid target number
            }
        }

        public int GuessedNumber
        {
            get { return this.guessedNumber; }
            set { this.guessedNumber = value; }
        }

        public int Turn
        {
            get { return this.turn; }
            set { this.turn = value; }
        }

        // Methods
        // WatchTower
        public string GetEnemyDirection()
        {
            if (xCoordinate == 0 && yCoordinate == 0)
                return "The enemy is here!";
            if (xCoordinate > 0 && yCoordinate > 0)
                return "The enemy is to the northeast!";
            if (xCoordinate < 0 && yCoordinate > 0)
                return "The enemy is to the northwest!";
            if (xCoordinate > 0 && yCoordinate < 0)
                return "The enemy is to the southeast!";
            if (xCoordinate < 0 && yCoordinate < 0)
                return "The enemy is to the southwest!";
            if (xCoordinate == 0)
                return (yCoordinate > 0) ? "The enemy is to the north!" : "The enemy is to the south!";
            return (xCoordinate > 0) ? "The enemy is to the east!" : "The enemy is to the west!";
        }

        //Buying Inventory
        public string GetItemPrice()
        {
            int price = itemChoice switch
            {
                1 => 10,
                2 => 15,
                3 => 25,
                4 => 1,
                5 => 20,
                6 => 2,
                7 => 1,
                _ => -1
            };
            return (price == -1) ? "Invalid item." : $"The item costs {price} gold.";
        }

        // Discounted Inventory
        public string GetDiscountedPrice()
        {
            int price = itemChoice switch
            {
                1 => 10,
                2 => 15,
                3 => 25,
                4 => 1,
                5 => 20,
                6 => 2,
                7 => 1,
                _ => -1
            };
            if (price == -1)
                return "Invalid item.";
            if (userName.ToLower() == "kapil")
                price /= 2;
            return $"The item costs {price} gold.";
        }

        // Override the ToString method
        public override string ToString()
        {
            string message = "";
            message += "Enemy Coordinates: (" + this.XCoordinate + ", " + this.YCoordinate + ")\n";
            message += "Item Choice: " + this.ItemChoice + "\n";
            message += "User Name: " + this.UserName + "\n";
            message += "Target Number: " + this.TargetNumber + "\n";
            message += "Guessed Number: " + this.GuessedNumber + "\n";
            message += "Turn: " + this.Turn + "\n";
            message += "Original Array: " + string.Join(", ", this.originalArray) + "\n";
            message += "Copied Array: " + string.Join(", ", this.copiedArray) + "\n";
            return message;
        }
    }
}
