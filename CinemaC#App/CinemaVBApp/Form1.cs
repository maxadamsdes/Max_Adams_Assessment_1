using System;

namespace CinemaCSharpApp
{
    public partial class Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public decimal Adult_Before_5(int quantity, string person, string day, decimal time)
        {
            decimal total_price = 14.5M;
            return total_price;
        }

        public decimal Adult_After_5(int quantity, string person, string day, int time)
        {
            var total_price = default(decimal);
            return total_price;
        }

        private void Cinemas_Load(object sender, EventArgs e)
        {
        }

        public decimal Adult_Before_5(int quantity, string person, decimal time)
        {
            //Int(initialPrice == 14.5);
            //string(adult ==  == person, time < 5, DateTime ==  == Monday - Sunday, quantity > 0);
            //return Total; /* TODO ERROR: Skipped SkippedTokensTrivia *//* TODO ERROR: Skipped SkippedTokensTrivia */
        }

        public decimal Adult_After_5(int quantity, string person, decimal time)
        {
            //Int(initialPrice == 14.5);
            //string(adult ==  == person, time > 5, DateTime ==  == Monday - Sunday, quantity > 0);
            //return Total; /* TODO ERROR: Skipped SkippedTokensTrivia *//* TODO ERROR: Skipped SkippedTokensTrivia */
        }

        public decimal Adult_Tuesday(int quantity, string person, string day)
        {
            return default;
        }

        public decimal Child_Under_16(int quantity, string person, object )
        {
            return default;
        }

        public decimal Senior(int quantity, string person, object )
        {
            return default;
        }

        public decimal Student(int quantity, string person, object )
        {
            return default;
        }

        public decimal Family_Pass(int quantity_adult, int quantity_child)
        {
            return default;
        }

        public decimal Chick_Flick_Thursday(int quantity, string person, object )
        {
            return default;
        }

        public decimal Kids_Carers(int quantity, string day, bool holiday)
        {
            return default;
        }
    }
}